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
            this.pbObraz1 = new System.Windows.Forms.PictureBox();
            this.pbTlo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbObraz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTlo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbObraz1
            // 
            this.pbObraz1.Location = new System.Drawing.Point(12, 12);
            this.pbObraz1.Name = "pbObraz1";
            this.pbObraz1.Size = new System.Drawing.Size(320, 240);
            this.pbObraz1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbObraz1.TabIndex = 0;
            this.pbObraz1.TabStop = false;
            // 
            // pbTlo
            // 
            this.pbTlo.Location = new System.Drawing.Point(793, 12);
            this.pbTlo.Name = "pbTlo";
            this.pbTlo.Size = new System.Drawing.Size(320, 240);
            this.pbTlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTlo.TabIndex = 1;
            this.pbTlo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1038, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbTlo);
            this.Controls.Add(this.pbObraz1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAI Morse project";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbObraz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTlo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbObraz1;
        private System.Windows.Forms.PictureBox pbTlo;
        private System.Windows.Forms.Button button1;
    }
}

