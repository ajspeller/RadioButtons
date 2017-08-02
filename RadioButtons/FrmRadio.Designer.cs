namespace RadioButtons
{
    partial class FrmRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadio));
            this.GrpMood = new System.Windows.Forms.GroupBox();
            this.RdoSad = new System.Windows.Forms.RadioButton();
            this.RdoHappy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PicSad = new System.Windows.Forms.PictureBox();
            this.PicHappy = new System.Windows.Forms.PictureBox();
            this.GrpMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHappy)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpMood
            // 
            this.GrpMood.Controls.Add(this.RdoSad);
            this.GrpMood.Controls.Add(this.RdoHappy);
            this.GrpMood.Location = new System.Drawing.Point(42, 32);
            this.GrpMood.Name = "GrpMood";
            this.GrpMood.Size = new System.Drawing.Size(238, 134);
            this.GrpMood.TabIndex = 0;
            this.GrpMood.TabStop = false;
            this.GrpMood.Text = "Moods";
            this.GrpMood.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdoSad
            // 
            this.RdoSad.AutoSize = true;
            this.RdoSad.Location = new System.Drawing.Point(26, 87);
            this.RdoSad.Name = "RdoSad";
            this.RdoSad.Size = new System.Drawing.Size(44, 17);
            this.RdoSad.TabIndex = 1;
            this.RdoSad.TabStop = true;
            this.RdoSad.Text = "Sad";
            this.RdoSad.UseVisualStyleBackColor = true;
            this.RdoSad.CheckedChanged += new System.EventHandler(this.RdoSad_CheckedChanged);
            // 
            // RdoHappy
            // 
            this.RdoHappy.AutoSize = true;
            this.RdoHappy.Location = new System.Drawing.Point(26, 31);
            this.RdoHappy.Name = "RdoHappy";
            this.RdoHappy.Size = new System.Drawing.Size(56, 17);
            this.RdoHappy.TabIndex = 0;
            this.RdoHappy.TabStop = true;
            this.RdoHappy.Text = "Happy";
            this.RdoHappy.UseVisualStyleBackColor = true;
            this.RdoHappy.CheckedChanged += new System.EventHandler(this.RdoHappy_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(36, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weather";
            // 
            // PicSad
            // 
            this.PicSad.Image = ((System.Drawing.Image)(resources.GetObject("PicSad.Image")));
            this.PicSad.Location = new System.Drawing.Point(354, 58);
            this.PicSad.Name = "PicSad";
            this.PicSad.Size = new System.Drawing.Size(100, 63);
            this.PicSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSad.TabIndex = 2;
            this.PicSad.TabStop = false;
            this.PicSad.Visible = false;
            this.PicSad.Click += new System.EventHandler(this.PicSad_Click);
            // 
            // PicHappy
            // 
            this.PicHappy.Image = ((System.Drawing.Image)(resources.GetObject("PicHappy.Image")));
            this.PicHappy.Location = new System.Drawing.Point(354, 58);
            this.PicHappy.Name = "PicHappy";
            this.PicHappy.Size = new System.Drawing.Size(100, 61);
            this.PicHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicHappy.TabIndex = 3;
            this.PicHappy.TabStop = false;
            this.PicHappy.Visible = false;
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 455);
            this.Controls.Add(this.PicSad);
            this.Controls.Add(this.PicHappy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrpMood);
            this.Name = "FrmRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Button Example";
            this.Load += new System.EventHandler(this.FrmRadio_Load);
            this.GrpMood.ResumeLayout(false);
            this.GrpMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHappy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpMood;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoSad;
        private System.Windows.Forms.RadioButton RdoHappy;
        private System.Windows.Forms.PictureBox PicSad;
        private System.Windows.Forms.PictureBox PicHappy;
    }
}

