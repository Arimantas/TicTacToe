namespace Tic_tac_toe
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPvP = new System.Windows.Forms.Button();
            this.buttonPvC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPvP
            // 
            this.buttonPvP.Location = new System.Drawing.Point(200, 25);
            this.buttonPvP.Name = "buttonPvP";
            this.buttonPvP.Size = new System.Drawing.Size(200, 50);
            this.buttonPvP.TabIndex = 1;
            this.buttonPvP.Text = "Player vs Player";
            this.buttonPvP.UseVisualStyleBackColor = true;
            this.buttonPvP.Click += new System.EventHandler(this.buttonPvP_Click);
            // 
            // buttonPvC
            // 
            this.buttonPvC.Location = new System.Drawing.Point(200, 103);
            this.buttonPvC.Name = "buttonPvC";
            this.buttonPvC.Size = new System.Drawing.Size(200, 50);
            this.buttonPvC.TabIndex = 2;
            this.buttonPvC.Text = "Player vs Computer";
            this.buttonPvC.UseVisualStyleBackColor = true;
            this.buttonPvC.Click += new System.EventHandler(this.buttonPvC_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(25, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 105);
            this.button1.TabIndex = 3;
            this.button1.Text = "Čia gali būti tavo reklama";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(432, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPvC);
            this.Controls.Add(this.buttonPvP);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPvP;
        private System.Windows.Forms.Button buttonPvC;
        private System.Windows.Forms.Button button1;
    }
}