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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lMorse = new System.Windows.Forms.Label();
            this.lNapis = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bWyczysc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(480, 360);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // lMorse
            // 
            this.lMorse.BackColor = System.Drawing.Color.DarkOrange;
            this.lMorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMorse.Location = new System.Drawing.Point(12, 388);
            this.lMorse.Name = "lMorse";
            this.lMorse.Size = new System.Drawing.Size(96, 25);
            this.lMorse.TabIndex = 8;
            this.lMorse.Text = "lMorse";
            // 
            // lNapis
            // 
            this.lNapis.BackColor = System.Drawing.Color.DarkOrange;
            this.lNapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNapis.Location = new System.Drawing.Point(12, 429);
            this.lNapis.Name = "lNapis";
            this.lNapis.Size = new System.Drawing.Size(394, 25);
            this.lNapis.TabIndex = 9;
            this.lNapis.Text = "lNapis";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(498, 429);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(235, 23);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Pokaż więcej";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Litera w Morse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Odkodowany napis: ";
            // 
            // bWyczysc
            // 
            this.bWyczysc.Location = new System.Drawing.Point(412, 429);
            this.bWyczysc.Name = "bWyczysc";
            this.bWyczysc.Size = new System.Drawing.Size(80, 25);
            this.bWyczysc.TabIndex = 13;
            this.bWyczysc.Text = "Wyczyść";
            this.bWyczysc.UseVisualStyleBackColor = true;
            this.bWyczysc.Click += new System.EventHandler(this.bWyczysc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::naiMorse.Properties.Resources.morse_operator;
            this.pictureBox1.Location = new System.Drawing.Point(498, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bWyczysc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.lNapis);
            this.Controls.Add(this.lMorse);
            this.Controls.Add(this.pb1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAI Morse project";          
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lMorse;
        private System.Windows.Forms.Label lNapis;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bWyczysc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

