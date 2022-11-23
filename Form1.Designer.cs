namespace Actividades
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mntClnd = new Pabo.Calendar.MonthCalendar();
            this.btnCheck = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // mntClnd
            // 
            this.mntClnd.ActiveMonth.Month = 5;
            this.mntClnd.ActiveMonth.Year = 2022;
            this.mntClnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.mntClnd.Culture = new System.Globalization.CultureInfo("es-MX");
            this.mntClnd.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mntClnd.Header.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(179)))), ((int)(((byte)(200)))));
            this.mntClnd.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mntClnd.Header.TextColor = System.Drawing.Color.White;
            this.mntClnd.ImageList = null;
            this.mntClnd.KeyboardEnabled = false;
            this.mntClnd.Location = new System.Drawing.Point(0, -2);
            this.mntClnd.MaxDate = new System.DateTime(2023, 3, 24, 0, 0, 0, 0);
            this.mntClnd.MinDate = new System.DateTime(2022, 4, 24, 0, 0, 0, 0);
            this.mntClnd.Month.BackgroundImage = null;
            this.mntClnd.Month.Colors.Focus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.mntClnd.Month.Colors.Focus.Border = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.mntClnd.Month.Colors.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.mntClnd.Month.Colors.Selected.Border = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(97)))), ((int)(((byte)(135)))));
            this.mntClnd.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mntClnd.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mntClnd.Name = "mntClnd";
            this.mntClnd.SelectionMode = Pabo.Calendar.mcSelectionMode.One;
            this.mntClnd.SelectTrailingDates = false;
            this.mntClnd.ShowFooter = false;
            this.mntClnd.Size = new System.Drawing.Size(968, 437);
            this.mntClnd.TabIndex = 12;
            this.mntClnd.Theme = true;
            this.mntClnd.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mntClnd.Weekdays.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(179)))), ((int)(((byte)(200)))));
            this.mntClnd.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mntClnd.Weeknumbers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(179)))), ((int)(((byte)(200)))));
            this.mntClnd.DayClick += new Pabo.Calendar.DayClickEventHandler(this.mntClnd_DayClick);
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Image = global::Actividades.Properties.Resources._1814097_clock_schedule_time_icon;
            this.btnCheck.Location = new System.Drawing.Point(892, 441);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(64, 64);
            this.btnCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCheck.TabIndex = 11;
            this.btnCheck.TabStop = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::Actividades.Properties.Resources._1814113_add_more_plus_icon;
            this.btnAdd.Location = new System.Drawing.Point(784, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 64);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Actividades.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(12, 441);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mntClnd);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calendario de Actividades";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCheck;
        private Pabo.Calendar.MonthCalendar mntClnd;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

