namespace HelloWoldLana
{
    partial class frmHelloWold
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblsignature = new System.Windows.Forms.Label();
            this.picFlowers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFlowers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGreeting.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblGreeting.Location = new System.Drawing.Point(301, 41);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(457, 64);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            this.lblGreeting.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblsignature
            // 
            this.lblsignature.AutoSize = true;
            this.lblsignature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsignature.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignature.ForeColor = System.Drawing.Color.Black;
            this.lblsignature.Location = new System.Drawing.Point(370, 197);
            this.lblsignature.Name = "lblsignature";
            this.lblsignature.Size = new System.Drawing.Size(325, 65);
            this.lblsignature.TabIndex = 2;
            this.lblsignature.Text = "by Lana ZE.";
            // 
            // picFlowers
            // 
            this.picFlowers.Image = global::HelloWoldLana.Properties.Resources.proven_winners_annuals_argprw1097524_64_1000;
            this.picFlowers.Location = new System.Drawing.Point(370, 416);
            this.picFlowers.Name = "picFlowers";
            this.picFlowers.Size = new System.Drawing.Size(338, 293);
            this.picFlowers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlowers.TabIndex = 3;
            this.picFlowers.TabStop = false;
            // 
            // frmHelloWold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 721);
            this.Controls.Add(this.picFlowers);
            this.Controls.Add(this.lblsignature);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloWold";
            this.Text = "Hello, World by Lana";
            ((System.ComponentModel.ISupportInitialize)(this.picFlowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblsignature;
        private System.Windows.Forms.PictureBox picFlowers;
    }
}

