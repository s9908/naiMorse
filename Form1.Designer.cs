namespace naiMorse
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("NA");
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.lvCzasy = new System.Windows.Forms.ListView();
            this.stan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.czas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvZnak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lMorse = new System.Windows.Forms.Label();
            this.lNapis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(320, 240);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(793, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(320, 240);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(793, 258);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(320, 240);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(12, 258);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(320, 240);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(391, 258);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(320, 240);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 5;
            this.pb5.TabStop = false;
            // 
            // lvCzasy
            // 
            this.lvCzasy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stan,
            this.czas});
            this.lvCzasy.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvCzasy.Location = new System.Drawing.Point(338, 12);
            this.lvCzasy.Name = "lvCzasy";
            this.lvCzasy.Size = new System.Drawing.Size(183, 240);
            this.lvCzasy.TabIndex = 6;
            this.lvCzasy.UseCompatibleStateImageBehavior = false;
            this.lvCzasy.View = System.Windows.Forms.View.Details;
            this.lvCzasy.SelectedIndexChanged += new System.EventHandler(this.lvCzasy_SelectedIndexChanged);
            // 
            // stan
            // 
            this.stan.Text = "Stan";
            this.stan.Width = 78;
            // 
            // czas
            // 
            this.czas.Text = "Czas";
            this.czas.Width = 67;
            // 
            // lvZnak
            // 
            this.lvZnak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvZnak.Location = new System.Drawing.Point(527, 12);
            this.lvZnak.Name = "lvZnak";
            this.lvZnak.Size = new System.Drawing.Size(120, 240);
            this.lvZnak.TabIndex = 7;
            this.lvZnak.UseCompatibleStateImageBehavior = false;
            this.lvZnak.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Znak";
            // 
            // lMorse
            // 
            this.lMorse.AutoSize = true;
            this.lMorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMorse.Location = new System.Drawing.Point(653, 57);
            this.lMorse.Name = "lMorse";
            this.lMorse.Size = new System.Drawing.Size(83, 25);
            this.lMorse.TabIndex = 8;
            this.lMorse.Text = "lMorse";
            // 
            // lNapis
            // 
            this.lNapis.AutoSize = true;
            this.lNapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNapis.Location = new System.Drawing.Point(653, 93);
            this.lNapis.Name = "lNapis";
            this.lNapis.Size = new System.Drawing.Size(78, 25);
            this.lNapis.TabIndex = 9;
            this.lNapis.Text = "lNapis";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 608);
            this.Controls.Add(this.lNapis);
            this.Controls.Add(this.lMorse);
            this.Controls.Add(this.lvZnak);
            this.Controls.Add(this.lvCzasy);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAI Morse project";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.ListView lvCzasy;
        private System.Windows.Forms.ColumnHeader stan;
        private System.Windows.Forms.ColumnHeader czas;
        private System.Windows.Forms.ListView lvZnak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lMorse;
        private System.Windows.Forms.Label lNapis;
    }
}

