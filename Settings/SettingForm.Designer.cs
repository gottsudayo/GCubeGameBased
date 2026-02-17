namespace Settings
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            EnableBGMCheck = new CheckBox();
            EnableSECheck = new CheckBox();
            BGMVolumeBar = new TrackBar();
            SEVolumeBar = new TrackBar();
            BGMVolumeLabel = new Label();
            SEVolumeLabel = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)BGMVolumeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SEVolumeBar).BeginInit();
            SuspendLayout();
            // 
            // EnableBGMCheck
            // 
            EnableBGMCheck.AutoSize = true;
            EnableBGMCheck.Font = new Font("Yu Gothic UI", 15F);
            EnableBGMCheck.Location = new Point(12, 12);
            EnableBGMCheck.Name = "EnableBGMCheck";
            EnableBGMCheck.Size = new Size(137, 32);
            EnableBGMCheck.TabIndex = 0;
            EnableBGMCheck.Text = "Enable BGM";
            EnableBGMCheck.UseVisualStyleBackColor = true;
            // 
            // EnableSECheck
            // 
            EnableSECheck.AutoSize = true;
            EnableSECheck.Font = new Font("Yu Gothic UI", 15F);
            EnableSECheck.Location = new Point(12, 126);
            EnableSECheck.Name = "EnableSECheck";
            EnableSECheck.Size = new Size(115, 32);
            EnableSECheck.TabIndex = 1;
            EnableSECheck.Text = "Enable SE";
            EnableSECheck.UseVisualStyleBackColor = true;
            // 
            // BGMVolumeBar
            // 
            BGMVolumeBar.Location = new Point(12, 75);
            BGMVolumeBar.Name = "BGMVolumeBar";
            BGMVolumeBar.Size = new Size(466, 45);
            BGMVolumeBar.TabIndex = 2;
            // 
            // SEVolumeBar
            // 
            SEVolumeBar.Location = new Point(12, 190);
            SEVolumeBar.Name = "SEVolumeBar";
            SEVolumeBar.Size = new Size(466, 45);
            SEVolumeBar.TabIndex = 3;
            // 
            // BGMVolumeLabel
            // 
            BGMVolumeLabel.AutoSize = true;
            BGMVolumeLabel.Font = new Font("Yu Gothic UI", 11F);
            BGMVolumeLabel.Location = new Point(12, 47);
            BGMVolumeLabel.Name = "BGMVolumeLabel";
            BGMVolumeLabel.Size = new Size(59, 20);
            BGMVolumeLabel.TabIndex = 4;
            BGMVolumeLabel.Text = "Volume";
            // 
            // SEVolumeLabel
            // 
            SEVolumeLabel.AutoSize = true;
            SEVolumeLabel.Font = new Font("Yu Gothic UI", 11F);
            SEVolumeLabel.Location = new Point(12, 161);
            SEVolumeLabel.Name = "SEVolumeLabel";
            SEVolumeLabel.Size = new Size(59, 20);
            SEVolumeLabel.TabIndex = 5;
            SEVolumeLabel.Text = "Volume";
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Yu Gothic UI", 13F);
            CancelButton.Location = new Point(357, 246);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(121, 38);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Yu Gothic UI", 13F);
            SaveButton.Location = new Point(230, 246);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(121, 38);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += this.SaveButton_Click;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 296);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(SEVolumeLabel);
            Controls.Add(BGMVolumeLabel);
            Controls.Add(SEVolumeBar);
            Controls.Add(BGMVolumeBar);
            Controls.Add(EnableSECheck);
            Controls.Add(EnableBGMCheck);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingForm";
            Text = "GCG Settings";
            Shown += SettingForm_Shown;
            ((System.ComponentModel.ISupportInitialize)BGMVolumeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SEVolumeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox EnableBGMCheck;
        private CheckBox EnableSECheck;
        private TrackBar BGMVolumeBar;
        private TrackBar SEVolumeBar;
        private Label BGMVolumeLabel;
        private Label SEVolumeLabel;
        private Button CancelButton;
        private Button SaveButton;
    }
}
