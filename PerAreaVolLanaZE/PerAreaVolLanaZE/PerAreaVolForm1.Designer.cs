namespace PerAreaVolLanaZE
{
    partial class frmPerAreaVolForm1
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
            this.btnQPerimeter = new System.Windows.Forms.Button();
            this.btnQVolume = new System.Windows.Forms.Button();
            this.btnQArea = new System.Windows.Forms.Button();
            this.lblAPerimeter = new System.Windows.Forms.Label();
            this.lblAArea = new System.Windows.Forms.Label();
            this.lblAVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQPerimeter
            // 
            this.btnQPerimeter.Location = new System.Drawing.Point(26, 35);
            this.btnQPerimeter.Name = "btnQPerimeter";
            this.btnQPerimeter.Size = new System.Drawing.Size(336, 106);
            this.btnQPerimeter.TabIndex = 0;
            this.btnQPerimeter.Text = "What is the perimeter of a rectangle with width of 5cm and length of 8cm";
            this.btnQPerimeter.UseVisualStyleBackColor = true;
            this.btnQPerimeter.Click += new System.EventHandler(this.BtnQPerimeter_Click);
            // 
            // btnQVolume
            // 
            this.btnQVolume.Location = new System.Drawing.Point(26, 305);
            this.btnQVolume.Name = "btnQVolume";
            this.btnQVolume.Size = new System.Drawing.Size(336, 106);
            this.btnQVolume.TabIndex = 1;
            this.btnQVolume.Text = "what is the volume of a sphere with a radius of 3cm";
            this.btnQVolume.UseVisualStyleBackColor = true;
            this.btnQVolume.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnQArea
            // 
            this.btnQArea.Location = new System.Drawing.Point(26, 168);
            this.btnQArea.Name = "btnQArea";
            this.btnQArea.Size = new System.Drawing.Size(336, 106);
            this.btnQArea.TabIndex = 2;
            this.btnQArea.Text = "what is the Area of a circle with a radius of 7cm";
            this.btnQArea.UseVisualStyleBackColor = true;
            this.btnQArea.Click += new System.EventHandler(this.BtnQArea_Click);
            // 
            // lblAPerimeter
            // 
            this.lblAPerimeter.AutoSize = true;
            this.lblAPerimeter.Location = new System.Drawing.Point(543, 73);
            this.lblAPerimeter.Name = "lblAPerimeter";
            this.lblAPerimeter.Size = new System.Drawing.Size(0, 13);
            this.lblAPerimeter.TabIndex = 3;
            // 
            // lblAArea
            // 
            this.lblAArea.AutoSize = true;
            this.lblAArea.Location = new System.Drawing.Point(543, 215);
            this.lblAArea.Name = "lblAArea";
            this.lblAArea.Size = new System.Drawing.Size(0, 13);
            this.lblAArea.TabIndex = 4;
            // 
            // lblAVolume
            // 
            this.lblAVolume.AutoSize = true;
            this.lblAVolume.Location = new System.Drawing.Point(543, 352);
            this.lblAVolume.Name = "lblAVolume";
            this.lblAVolume.Size = new System.Drawing.Size(0, 13);
            this.lblAVolume.TabIndex = 5;
            // 
            // frmPerAreaVolForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAVolume);
            this.Controls.Add(this.lblAArea);
            this.Controls.Add(this.lblAPerimeter);
            this.Controls.Add(this.btnQArea);
            this.Controls.Add(this.btnQVolume);
            this.Controls.Add(this.btnQPerimeter);
            this.Name = "frmPerAreaVolForm1";
            this.Text = "Perimeter, Area, Volume by Lana ZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQPerimeter;
        private System.Windows.Forms.Button btnQVolume;
        private System.Windows.Forms.Button btnQArea;
        private System.Windows.Forms.Label lblAPerimeter;
        private System.Windows.Forms.Label lblAArea;
        private System.Windows.Forms.Label lblAVolume;
    }
}

