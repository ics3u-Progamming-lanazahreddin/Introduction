namespace HelloIntLanaZE
{
    partial class frmHelloWorldInt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorldInt));
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.radFilipino = new System.Windows.Forms.RadioButton();
            this.radArabic = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("ScriptS_IV25", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHelloWorld.Location = new System.Drawing.Point(154, 46);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(428, 102);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello,World!";
            this.lblHelloWorld.Click += new System.EventHandler(this.LblHelloWorld_Click);
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radFilipino);
            this.grbLanguages.Controls.Add(this.radArabic);
            this.grbLanguages.Controls.Add(this.radSpanish);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Font = new System.Drawing.Font("Gentium Basic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLanguages.ForeColor = System.Drawing.Color.Navy;
            this.grbLanguages.Location = new System.Drawing.Point(12, 183);
            this.grbLanguages.Margin = new System.Windows.Forms.Padding(5);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(776, 149);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "Languages";
            this.grbLanguages.Enter += new System.EventHandler(this.Grp1_Enter);
            // 
            // radFilipino
            // 
            this.radFilipino.AutoSize = true;
            this.radFilipino.BackColor = System.Drawing.Color.LightCoral;
            this.radFilipino.Location = new System.Drawing.Point(611, 68);
            this.radFilipino.Name = "radFilipino";
            this.radFilipino.Size = new System.Drawing.Size(115, 36);
            this.radFilipino.TabIndex = 3;
            this.radFilipino.TabStop = true;
            this.radFilipino.Text = "Filipino";
            this.radFilipino.UseVisualStyleBackColor = false;
            this.radFilipino.CheckedChanged += new System.EventHandler(this.RadFilipino_CheckedChanged);
            // 
            // radArabic
            // 
            this.radArabic.AutoSize = true;
            this.radArabic.BackColor = System.Drawing.SystemColors.Info;
            this.radArabic.Location = new System.Drawing.Point(428, 68);
            this.radArabic.Name = "radArabic";
            this.radArabic.Size = new System.Drawing.Size(106, 36);
            this.radArabic.TabIndex = 2;
            this.radArabic.TabStop = true;
            this.radArabic.Text = "Arabic";
            this.radArabic.UseVisualStyleBackColor = false;
            this.radArabic.CheckedChanged += new System.EventHandler(this.RadArabic_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.radSpanish.Location = new System.Drawing.Point(232, 68);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(119, 36);
            this.radSpanish.TabIndex = 1;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = false;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadSpanish_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radEnglish.Location = new System.Drawing.Point(43, 65);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(112, 36);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = false;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International ";
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radFilipino;
        private System.Windows.Forms.RadioButton radArabic;
        private System.Windows.Forms.RadioButton radSpanish;
    }
}

