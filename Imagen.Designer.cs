namespace Actividades
{
    partial class Imagen
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
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pctb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Actividades.Properties.Resources._1814083_arrow_left_icon;
            this.btnBack.Location = new System.Drawing.Point(98, 247);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 48);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pctb
            // 
            this.pctb.Location = new System.Drawing.Point(12, 12);
            this.pctb.Name = "pctb";
            this.pctb.Size = new System.Drawing.Size(221, 229);
            this.pctb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb.TabIndex = 0;
            this.pctb.TabStop = false;
            // 
            // Imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pctb);
            this.Name = "Imagen";
            this.Text = "Imagen";
            this.Load += new System.EventHandler(this.Imagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctb;
        private System.Windows.Forms.PictureBox btnBack;
    }
}