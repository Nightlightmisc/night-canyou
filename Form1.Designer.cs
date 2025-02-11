namespace canyou
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainBackground_ingame = new PictureBox();
            playButton_ingame = new Button();
            ((System.ComponentModel.ISupportInitialize)mainBackground_ingame).BeginInit();
            SuspendLayout();
            // 
            // mainBackground_ingame
            // 
            mainBackground_ingame.Dock = DockStyle.Fill;
            mainBackground_ingame.Image = (Image)resources.GetObject("mainBackground_ingame.Image");
            mainBackground_ingame.Location = new Point(0, 0);
            mainBackground_ingame.Name = "mainBackground_ingame";
            mainBackground_ingame.Size = new Size(884, 461);
            mainBackground_ingame.SizeMode = PictureBoxSizeMode.CenterImage;
            mainBackground_ingame.TabIndex = 0;
            mainBackground_ingame.TabStop = false;
            // 
            // playButton_ingame
            // 
            playButton_ingame.BackColor = Color.FromArgb(25, 25, 25);
            playButton_ingame.FlatAppearance.BorderSize = 0;
            playButton_ingame.FlatStyle = FlatStyle.Flat;
            playButton_ingame.Location = new Point(376, 413);
            playButton_ingame.Name = "playButton_ingame";
            playButton_ingame.Size = new Size(155, 36);
            playButton_ingame.TabIndex = 1;
            playButton_ingame.Text = "PLAY";
            playButton_ingame.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(884, 461);
            Controls.Add(playButton_ingame);
            Controls.Add(mainBackground_ingame);
            ForeColor = Color.White;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ingame";
            ((System.ComponentModel.ISupportInitialize)mainBackground_ingame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainBackground_ingame;
        private Button playButton_ingame;
    }
}
