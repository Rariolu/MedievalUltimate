namespace MedievalUltimate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCreateMusic = new System.Windows.Forms.Button();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.btnSaveMusic = new System.Windows.Forms.Button();
            this.cbSamePath = new System.Windows.Forms.CheckBox();
            this.lblSongCreated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateMusic
            // 
            this.btnCreateMusic.Location = new System.Drawing.Point(12, 12);
            this.btnCreateMusic.Name = "btnCreateMusic";
            this.btnCreateMusic.Size = new System.Drawing.Size(124, 50);
            this.btnCreateMusic.TabIndex = 0;
            this.btnCreateMusic.Text = "Create Music";
            this.btnCreateMusic.UseVisualStyleBackColor = true;
            this.btnCreateMusic.Click += new System.EventHandler(this.btnCreateMusic_Click);
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(142, 12);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(116, 50);
            this.btnPlayMusic.TabIndex = 1;
            this.btnPlayMusic.Text = "Play Music";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // btnSaveMusic
            // 
            this.btnSaveMusic.Location = new System.Drawing.Point(264, 12);
            this.btnSaveMusic.Name = "btnSaveMusic";
            this.btnSaveMusic.Size = new System.Drawing.Size(124, 50);
            this.btnSaveMusic.TabIndex = 2;
            this.btnSaveMusic.Text = "Save Music";
            this.btnSaveMusic.UseVisualStyleBackColor = true;
            this.btnSaveMusic.Click += new System.EventHandler(this.btnSaveMusic_Click);
            // 
            // cbSamePath
            // 
            this.cbSamePath.AutoSize = true;
            this.cbSamePath.Enabled = false;
            this.cbSamePath.Location = new System.Drawing.Point(264, 68);
            this.cbSamePath.Name = "cbSamePath";
            this.cbSamePath.Size = new System.Drawing.Size(113, 17);
            this.cbSamePath.TabIndex = 3;
            this.cbSamePath.Text = "Use same file path";
            this.cbSamePath.UseVisualStyleBackColor = true;
            // 
            // lblSongCreated
            // 
            this.lblSongCreated.AutoSize = true;
            this.lblSongCreated.Location = new System.Drawing.Point(12, 80);
            this.lblSongCreated.Name = "lblSongCreated";
            this.lblSongCreated.Size = new System.Drawing.Size(153, 13);
            this.lblSongCreated.TabIndex = 4;
            this.lblSongCreated.Text = "No song has been created yet.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 102);
            this.Controls.Add(this.lblSongCreated);
            this.Controls.Add(this.cbSamePath);
            this.Controls.Add(this.btnSaveMusic);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.btnCreateMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MedievalUltimate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMusic;
        private System.Windows.Forms.Button btnPlayMusic;
        private System.Windows.Forms.Button btnSaveMusic;
        private System.Windows.Forms.CheckBox cbSamePath;
        private System.Windows.Forms.Label lblSongCreated;
    }
}

