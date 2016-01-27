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
        Capture kamerka;
        Image<Bgr, Byte> obraz1; //oryginalny obraz z kamerki

        public frmMain()
        {
            InitializeComponent();
            //inicjalizacja kamerki
            kamerka = new Capture(0);
            //wątek odczytu start
            th_pobierzObraz = new Thread(pobierzObraz);
            th_pobierzObraz.Start();
        }

        void pobierzObraz() //funkcja z nieskonczoną pętlą, działa w wątku th_pobierzObraz
        {
            for(;;)
            {
                //oryginalny obraz                
                obraz1 = new Image<Bgr, byte>(new Size(640, 480));
                obraz1 = kamerka.QueryFrame();

                pbObraz1.Image = obraz1.Bitmap;

                Thread.Sleep(10);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
         
        }
    }
}
