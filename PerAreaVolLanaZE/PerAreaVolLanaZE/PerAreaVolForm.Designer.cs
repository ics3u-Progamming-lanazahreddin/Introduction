namespace PerAreaVolLanaZE
{
    partial class frmPerAeaVol
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
            this.lblQPerimeter = new System.Windows.Forms.Label();
            this.lblAPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQPerimeter
            // 
            this.lblQPerimeter.AutoSize = true;
            this.lblQPerimeter.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQPerimeter.Location = new System.Drawing.Point(-119, 42);
            this.lblQPerimeter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQPerimeter.Name = "lblQPerimeter";
            this.lblQPerimeter.Size = new System.Drawing.Size(1207, 39);
            this.lblQPerimeter.TabIndex = 0;
            this.lblQPerimeter.Text = "Calculate the perimeter of a rectangle with a length of 8cm and a width of 5cm";
            this.lblQPerimeter.Click += new System.EventHandler(this.LblQPerimeter_Click);
            // 
            // lblAPerimeter
            // 
            this.lblAPerimeter.AutoSize = true;
            this.lblAPerimeter.Location = new System.Drawing.Point(820, 81);
            this.lblAPerimeter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAPerimeter.Name = "lblAPerimeter";
            this.lblAPerimeter.Size = new System.Drawing.Size(30, 24);
            this.lblAPerimeter.TabIndex = 1;
            this.lblAPerimeter.Text = "??";
            this.lblAPerimeter.Click += new System.EventHandler(this.LblAPerimeter_Click);
            // 
            // frmPerAeaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.lblAPerimeter);
            this.Controls.Add(this.lblQPerimeter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPerAeaVol";
            this.Text = "Perimeter, Area, Volume by Lana ZE";
            this.Load += new System.EventHandler(this.FrmPerAeaVol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQPerimeter;
        private System.Windows.Forms.Label lblAPerimeter;
    }
}

