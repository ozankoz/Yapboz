namespace Yapboz
{
    partial class Form1
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
            this.panelBoard = new System.Windows.Forms.Panel();
            this.btnKaristir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSeviye = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofdResimSec = new System.Windows.Forms.OpenFileDialog();
            this.btnResimSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Enabled = false;
            this.panelBoard.Location = new System.Drawing.Point(12, 12);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(410, 410);
            this.panelBoard.TabIndex = 2;
            // 
            // btnKaristir
            // 
            this.btnKaristir.Enabled = false;
            this.btnKaristir.Location = new System.Drawing.Point(458, 81);
            this.btnKaristir.Name = "btnKaristir";
            this.btnKaristir.Size = new System.Drawing.Size(75, 23);
            this.btnKaristir.TabIndex = 3;
            this.btnKaristir.Text = "Karıştır";
            this.btnKaristir.UseVisualStyleBackColor = true;
            this.btnKaristir.Click += new System.EventHandler(this.btnKaristir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seviye";
            // 
            // cbSeviye
            // 
            this.cbSeviye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeviye.FormattingEnabled = true;
            this.cbSeviye.Items.AddRange(new object[] {
            "Seviye 1",
            "Seviye 2",
            "Seviye 3",
            "Seviye 4"});
            this.cbSeviye.Location = new System.Drawing.Point(458, 54);
            this.cbSeviye.Name = "cbSeviye";
            this.cbSeviye.Size = new System.Drawing.Size(75, 21);
            this.cbSeviye.TabIndex = 5;
            this.cbSeviye.SelectedIndexChanged += new System.EventHandler(this.cbSeviye_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(435, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(458, 12);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(75, 23);
            this.btnResimSec.TabIndex = 7;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 438);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbSeviye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaristir);
            this.Controls.Add(this.panelBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Yapboz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Button btnKaristir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSeviye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofdResimSec;
        private System.Windows.Forms.Button btnResimSec;
    }
}

