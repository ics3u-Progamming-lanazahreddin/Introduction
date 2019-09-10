namespace ProgramMenuLana
{
    partial class frmProgramMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgramMenu));
            this.lblSoccerTeam = new System.Windows.Forms.Label();
            this.lblSoccerPlayer = new System.Windows.Forms.Label();
            this.picCR7 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picCR7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoccerTeam
            // 
            this.lblSoccerTeam.AutoSize = true;
            this.lblSoccerTeam.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoccerTeam.ForeColor = System.Drawing.Color.Coral;
            this.lblSoccerTeam.Location = new System.Drawing.Point(17, 50);
            this.lblSoccerTeam.Name = "lblSoccerTeam";
            this.lblSoccerTeam.Size = new System.Drawing.Size(439, 112);
            this.lblSoccerTeam.TabIndex = 0;
            this.lblSoccerTeam.Text = "Real Madrid";
            // 
            // lblSoccerPlayer
            // 
            this.lblSoccerPlayer.Font = new System.Drawing.Font("Vineta BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoccerPlayer.ForeColor = System.Drawing.Color.DimGray;
            this.lblSoccerPlayer.Location = new System.Drawing.Point(12, 162);
            this.lblSoccerPlayer.Name = "lblSoccerPlayer";
            this.lblSoccerPlayer.Size = new System.Drawing.Size(461, 89);
            this.lblSoccerPlayer.TabIndex = 1;
            this.lblSoccerPlayer.Text = "Christiano Ronaldo";
            this.lblSoccerPlayer.Click += new System.EventHandler(this.LblSoccerPlayer_Click);
            // 
            // picCR7
            // 
            this.picCR7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCR7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCR7.Image = ((System.Drawing.Image)(resources.GetObject("picCR7.Image")));
            this.picCR7.Location = new System.Drawing.Point(506, -1);
            this.picCR7.Name = "picCR7";
            this.picCR7.Size = new System.Drawing.Size(291, 450);
            this.picCR7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCR7.TabIndex = 2;
            this.picCR7.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.BackColor = System.Drawing.Color.BurlyWood;
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // frmProgramMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSoccerPlayer);
            this.Controls.Add(this.lblSoccerTeam);
            this.Controls.Add(this.picCR7);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProgramMenu";
            this.Text = "Program Menu by Lana ZE";
            ((System.ComponentModel.ISupportInitialize)(this.picCR7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoccerTeam;
        private System.Windows.Forms.Label lblSoccerPlayer;
        private System.Windows.Forms.PictureBox picCR7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

