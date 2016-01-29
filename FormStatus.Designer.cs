namespace naiMorse
{
    partial class frmStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("NA");
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvCzasy = new System.Windows.Forms.ListView();
            this.stan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.czas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvZnak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(16, 32);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(320, 240);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tło: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolor biały na obrazie z kamery: ";
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(363, 32);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(320, 240);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kolor biały na tle: ";
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(16, 309);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(320, 240);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 7;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(363, 309);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(320, 240);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 8;
            this.pb5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(359, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Różnica koloru białego na obrazie i tle:";
            // 
            // lvCzasy
            // 
            this.lvCzasy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stan,
            this.czas});
            this.lvCzasy.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvCzasy.Location = new System.Drawing.Point(700, 32);
            this.lvCzasy.Name = "lvCzasy";
            this.lvCzasy.Size = new System.Drawing.Size(100, 240);
            this.lvCzasy.TabIndex = 10;
            this.lvCzasy.UseCompatibleStateImageBehavior = false;
            this.lvCzasy.View = System.Windows.Forms.View.Details;
            // 
            // stan
            // 
            this.stan.Text = "Stan";
            this.stan.Width = 44;
            // 
            // czas
            // 
            this.czas.Text = "Czas";
            this.czas.Width = 48;
            // 
            // lvZnak
            // 
            this.lvZnak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvZnak.Location = new System.Drawing.Point(700, 311);
            this.lvZnak.Name = "lvZnak";
            this.lvZnak.Size = new System.Drawing.Size(100, 199);
            this.lvZnak.TabIndex = 11;
            this.lvZnak.UseCompatibleStateImageBehavior = false;
            this.lvZnak.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Znak";
            this.columnHeader1.Width = 85;
            // 
            // bZamknij
            // 
            this.bZamknij.Location = new System.Drawing.Point(700, 526);
            this.bZamknij.Name = "bZamknij";
            this.bZamknij.Size = new System.Drawing.Size(100, 23);
            this.bZamknij.TabIndex = 12;
            this.bZamknij.Text = "Zamknij";
            this.bZamknij.UseVisualStyleBackColor = true;
            this.bZamknij.Click += new System.EventHandler(this.bZamknij_Click);
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 563);
            this.Controls.Add(this.bZamknij);
            this.Controls.Add(this.lvZnak);
            this.Controls.Add(this.lvCzasy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb3);
            this.Name = "frmStatus";
            this.Text = "Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatus_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pb4;
        public System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListView lvCzasy;
        private System.Windows.Forms.ColumnHeader stan;
        private System.Windows.Forms.ColumnHeader czas;
        public System.Windows.Forms.ListView lvZnak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button bZamknij;
    }
}