
namespace TopDownshooter
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.play = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.play.AutoSize = true;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.play.Location = new System.Drawing.Point(218, 250);
            this.play.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(121, 55);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.Click += new System.EventHandler(this.label1_Click);
            // 
            // options
            // 
            this.options.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.options.AutoSize = true;
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.options.Location = new System.Drawing.Point(218, 315);
            this.options.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(135, 37);
            this.options.TabIndex = 3;
            this.options.Text = "Options";
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(221, 365);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(69, 36);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TopDownshooter.Properties.Resources.w__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1440, 878);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TopDownshooter.Properties.Resources.w__1_;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.options);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiirka Killer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label play;
        private System.Windows.Forms.Label options;
        private System.Windows.Forms.Label exit;
    }
}