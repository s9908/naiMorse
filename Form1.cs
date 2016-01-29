using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Threading;

namespace naiMorse
{
    public partial class frmMain : Form
    {
        Thread th_pobierzObraz; //wątek do odczytu kamerki i przetwarzania obrazu
        Thread th_liczCzas; //watek do liczenia czasów ON/OFF
        int licz; //licznik
        bool st; //stan ON/OFF
        bool st_poprzedni; //do sledzena zmian ON/OFF
        Capture kamerka;
        frmStatus Status;

        Image<Bgr, Byte> obraz1; //oryginalny obraz z kamerki
        Image<Bgr, Byte> obraz1_mod; //oryginalny obraz z kamerki po modyfikacjach do wyswietlenia uztkownikowi
        Image<Bgr, Byte> tlo; //tło
        Image<Gray, Byte> tlo_v; //składowa V dla tła  
        Image<Gray, Byte> bin_tlo_bialy; //kolor biały na składowej V tła    
        Image<Gray, Byte> obraz1_v; //składowa V dla obrazu z kamery  
        Image<Gray, Byte> bin_obraz1_bialy; //kolor biały na składowej V obrazu z kamery    

        //parametry do funkcji erode i dilate
        StructuringElementEx rect_12;
        StructuringElementEx rect_6;

        string MorseNaLitere(string morse) //zamiana kodu morsea na litere
        {
            string l = "";
            switch (morse)
            {
                case "•—": l = "A"; break;
                case "—•••": l = "B"; break;
                case "—•—•": l = "C"; break;
                case "—••": l = "D"; break;
                case "•": l = "E"; break;
                case "••—•": l = "F"; break;
                case "——•": l = "G"; break;
                case "••••": l = "H"; break;
                case "••": l = "I"; break;
                case "•———": l = "J"; break;
                case "—•—": l = "K"; break;
                case "•—••": l = "L"; break;
                case "——": l = "M"; break;
                case "—•": l = "N"; break;
                case "———": l = "O"; break;
                case "•——•": l = "P"; break;
                case "——•—": l = "Q"; break;
                case "•—•": l = "R"; break;
                case "•••": l = "S"; break;
                case "—": l = "T"; break;
                case "••—": l = "U"; break;
                case "•••—": l = "V"; break;
                case "•——": l = "W"; break;
                case "—••—": l = "X"; break;
                case "—•——": l = "Y"; break;
                case "——••": l = "Z"; break;
                case "•—•—": l = "ą"; break;
                case "—•—••": l = "ć"; break;
                case "••—••": l = "ę"; break;
                case "————": l = "ch"; break;
                case "•—••—": l = "ł"; break;
                case "——•——": l = "ń"; break;
                case "———•": l = "ó"; break;
                case "•••—•••": l = "ś"; break;
                case "——••—•": l = "ż"; break;
                case "——••—": l = "ź"; break;
                case "•————": l = "1"; break;
                case "••———": l = "2"; break;
                case "•••——": l = "3"; break;
                case "••••—": l = "4"; break;
                case "•••••": l = "5"; break;
                case "—••••": l = "6"; break;
                case "——•••": l = "7"; break;
                case "———••": l = "8"; break;
                case "————•": l = "9"; break;
                case "—————": l = "0"; break;
            }
            return l;
        }

        public frmMain()
        {
            InitializeComponent();
            Status = new frmStatus(); //okienko w którym będzie podgląd jak działa aplikacja
            Thread.Sleep(200);
            CheckForIllegalCrossThreadCalls = false;
            obraz1 = new Image<Bgr, byte>(new Size(640, 480));
            tlo = new Image<Bgr, byte>(new Size(640, 480));
            //inicjalizacja kamerki
            kamerka = new Capture(0);
            aktualizujTlo();
            //wątek odczytu start
            th_pobierzObraz = new Thread(pobierzObraz);
            th_pobierzObraz.Start();
            //wątek zliczania czasu
            th_liczCzas = new Thread(liczCzas);
            th_liczCzas.Start();

            Thread.Sleep(500);
            aktualizujTlo();

            rect_12 = new StructuringElementEx(12, 12, 6, 6, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
            rect_6 = new StructuringElementEx(6, 6, 3, 3, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
            lNapis.Text = "";
        }

        void pobierzObraz() //funkcja z nieskonczoną pętlą, działa w wątku th_pobierzObraz
        {
            for(;;)
            {
                //oryginalny obraz                   
                obraz1 = kamerka.QueryFrame();
                obraz1_mod = obraz1.Copy();

                //składowa V i obraz binarny światła na obrazie z kamery
                Image<Hsv, Byte> obraz1_hsv = new Image<Hsv, byte>(obraz1.Bitmap);
                CvInvoke.cvCvtColor(obraz1, obraz1_hsv, Emgu.CV.CvEnum.COLOR_CONVERSION.BGR2HSV);
                obraz1_v = obraz1_hsv.Split()[2];
                bin_obraz1_bialy = obraz1_v.InRange(new Gray(250), new Gray(255));
                CvInvoke.cvErode(bin_obraz1_bialy, bin_obraz1_bialy, rect_12, 5);
                CvInvoke.cvDilate(bin_obraz1_bialy, bin_obraz1_bialy, rect_6, 5);
                Status.pb2.Image = bin_obraz1_bialy.Bitmap;

                //składowa V i obraz binarny światła na tle
                Image<Hsv, Byte> tlo_hsv = new Image<Hsv, byte>(tlo.Bitmap);
                CvInvoke.cvCvtColor(tlo, tlo_hsv, Emgu.CV.CvEnum.COLOR_CONVERSION.BGR2HSV);
                tlo_v = tlo_hsv.Split()[2];
                bin_tlo_bialy = tlo_v.InRange(new Gray(250), new Gray(255));
                CvInvoke.cvErode(bin_tlo_bialy, bin_tlo_bialy, rect_12, 5);
                CvInvoke.cvDilate(bin_tlo_bialy, bin_tlo_bialy, rect_6, 5);
                Status.pb4.Image = bin_tlo_bialy.Bitmap;


                //różnica powyższych
                Image<Gray, Byte> bin_diff = new Image<Gray, byte>(tlo.Bitmap);              
                bin_diff = bin_obraz1_bialy - bin_tlo_bialy;
                Status.pb5.Image = bin_diff.Bitmap;

                //kontury na swietle
                MemStorage mem = new MemStorage();
                Contour<Point> kontur_all = bin_diff.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, mem);
                Contour<Point> kontur = null; //kontur ktory bedzie brany pod uwage 
                //okreslanie najwiekszego konturu
                while (kontur_all != null)
                {
                    double rozmiar = 0;
                    if (kontur != null) rozmiar = kontur.Area;
                    if (kontur_all.Area > rozmiar)
                        kontur = kontur_all;
                    kontur_all = kontur_all.HNext;
                }

                if (kontur != null && kontur.Area > 500)
                {
                    kontur = kontur.ApproxPoly(kontur.Perimeter * 0.0025, mem);
                    obraz1_mod.Draw(kontur, new Bgr(Color.Red), 12);
                    st = true;
                }
                else
                {
                    st = false;
                }

                //wyswietlanie obrazu z kamerki z naznaczonymi konturami
                pb1.Image = obraz1_mod.Bitmap;

                //wyswietlanie tla
                Status.pb3.Image = tlo.Bitmap;
            }
        }

        void liczCzas() //funkcja do watku zliczania czasu poszczegolnych stanow ON/OFF
        {
            licz = 0;            
            st_poprzedni = st;
            bool done = true; //czy odczytano znak (skonwertowano czas trwania impulsu na znak)
            bool done_litera = true;
            int t = 0;
            for(;;)
            {
                if(st != st_poprzedni) //zmiana stanu
                {
                    Status.lvCzasy.Items.Add(st.ToString());
                    Status.lvCzasy.Items[Status.lvCzasy.Items.Count - 2].SubItems.Add(licz.ToString());
                    Status.lvCzasy.Items[Status.lvCzasy.Items.Count - 1].EnsureVisible();
                    st_poprzedni = st;
                    done = false;
                    t = licz;
                    Thread.Sleep(100);
                    licz = 0;
                }

                if(licz > 1000) //gdy swieci sie za dlugo, zakladamy ze to tło
                {
                    if(st == true) aktualizujTlo();
                    licz = 0;
                }

                if (st == false && licz > 400 && done_litera == false) //zakonczono odczyt litery
                {
                    done_litera = true;
                    licz = 0;
                    Status.lvZnak.Items.Add("=======");
                    Status.lvZnak.Items[Status.lvZnak.Items.Count - 1].EnsureVisible();
                    lNapis.Text += MorseNaLitere(lMorse.Text);
                    lMorse.Text = "";
                }

                if(done == false && st == false) //dioda nie swieci i nie odczytano poprzedniego znaku - odczytywanie go
                {
                    string z = "";
                    if (t > 200) z = "—";
                        else z = "•";
                    //  int cz = int.Parse(lvCzasy.Items[lvCzasy.Items.Count - 1].Text);
                    lMorse.Text += z;
                    Status.lvZnak.Items.Add(z);
                    Status.lvZnak.Items[Status.lvZnak.Items.Count - 1].EnsureVisible();
                    done = true;
                    done_litera = false;
                }

                licz++;
                Thread.Sleep(1);
            }

        }

        void aktualizujTlo() //pobiera klatke i zapisuje w "Image<Bgr, Byte> tlo"
        {
            tlo = new Image<Bgr, byte>(obraz1.Bitmap);
            tlo = obraz1.Copy();           
        }        

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Status.Show();
        }

        private void bWyczysc_Click(object sender, EventArgs e)
        {
            lNapis.Text = "";
        }
    }
}
