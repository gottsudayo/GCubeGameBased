namespace GCubeGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            GameField = new Panel();
            GameStatusPanel = new Label();
            Tile8 = new Button();
            Tile7 = new Button();
            Tile6 = new Button();
            Tile5 = new Button();
            Tile4 = new Button();
            Tile3 = new Button();
            Tile2 = new Button();
            Tile1 = new Button();
            Tile0 = new Button();
            Line1 = new Label();
            Line2 = new Label();
            Line3 = new Label();
            LineA = new Label();
            LineB = new Label();
            LineC = new Label();
            ScoreBackPanel = new Panel();
            ScoreDisp = new Label();
            ScoreTitle = new Label();
            CubeSecondThirdPanel = new Panel();
            ThirdLabel = new Label();
            ThirdCube = new Label();
            SecondLabel = new Label();
            SecondCube = new Label();
            ResetButton = new Button();
            RankingButton = new Button();
            LoadButton = new Button();
            SaveButton = new Button();
            GameField.SuspendLayout();
            ScoreBackPanel.SuspendLayout();
            CubeSecondThirdPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GameField
            // 
            GameField.BackColor = Color.FromArgb(22, 6, 0);
            GameField.Controls.Add(GameStatusPanel);
            GameField.Controls.Add(Tile8);
            GameField.Controls.Add(Tile7);
            GameField.Controls.Add(Tile6);
            GameField.Controls.Add(Tile5);
            GameField.Controls.Add(Tile4);
            GameField.Controls.Add(Tile3);
            GameField.Controls.Add(Tile2);
            GameField.Controls.Add(Tile1);
            GameField.Controls.Add(Tile0);
            GameField.Controls.Add(Line1);
            GameField.Controls.Add(Line2);
            GameField.Controls.Add(Line3);
            GameField.Controls.Add(LineA);
            GameField.Controls.Add(LineB);
            GameField.Controls.Add(LineC);
            GameField.Location = new Point(12, 12);
            GameField.Name = "GameField";
            GameField.Size = new Size(430, 430);
            GameField.TabIndex = 0;
            // 
            // GameStatusPanel
            // 
            GameStatusPanel.BackColor = Color.LimeGreen;
            GameStatusPanel.Font = new Font("PMingLiU-ExtB", 30F);
            GameStatusPanel.Location = new Point(28, 178);
            GameStatusPanel.Name = "GameStatusPanel";
            GameStatusPanel.Size = new Size(381, 80);
            GameStatusPanel.TabIndex = 18;
            GameStatusPanel.Text = "GAME CLEAR";
            GameStatusPanel.TextAlign = ContentAlignment.MiddleCenter;
            GameStatusPanel.Visible = false;
            // 
            // Tile8
            // 
            Tile8.Font = new Font("PMingLiU-ExtB", 30F);
            Tile8.ForeColor = Color.Black;
            Tile8.Location = new Point(286, 286);
            Tile8.Name = "Tile8";
            Tile8.Size = new Size(123, 123);
            Tile8.TabIndex = 8;
            Tile8.UseVisualStyleBackColor = true;
            Tile8.Click += TileC3_Click;
            // 
            // Tile7
            // 
            Tile7.Font = new Font("PMingLiU-ExtB", 30F);
            Tile7.ForeColor = Color.Black;
            Tile7.Location = new Point(157, 286);
            Tile7.Name = "Tile7";
            Tile7.Size = new Size(123, 123);
            Tile7.TabIndex = 7;
            Tile7.UseVisualStyleBackColor = true;
            Tile7.Click += TileC2_Click;
            // 
            // Tile6
            // 
            Tile6.Font = new Font("PMingLiU-ExtB", 30F);
            Tile6.ForeColor = Color.Black;
            Tile6.Location = new Point(28, 286);
            Tile6.Name = "Tile6";
            Tile6.Size = new Size(123, 123);
            Tile6.TabIndex = 6;
            Tile6.UseVisualStyleBackColor = true;
            Tile6.Click += TileC1_Click;
            // 
            // Tile5
            // 
            Tile5.Font = new Font("PMingLiU-ExtB", 30F);
            Tile5.ForeColor = Color.Black;
            Tile5.Location = new Point(286, 157);
            Tile5.Name = "Tile5";
            Tile5.Size = new Size(123, 123);
            Tile5.TabIndex = 5;
            Tile5.UseVisualStyleBackColor = true;
            Tile5.Click += TileB3_Click;
            // 
            // Tile4
            // 
            Tile4.Font = new Font("PMingLiU-ExtB", 30F);
            Tile4.ForeColor = Color.Black;
            Tile4.Location = new Point(157, 157);
            Tile4.Name = "Tile4";
            Tile4.Size = new Size(123, 123);
            Tile4.TabIndex = 4;
            Tile4.UseVisualStyleBackColor = true;
            Tile4.Click += TileB2_Click;
            // 
            // Tile3
            // 
            Tile3.Font = new Font("PMingLiU-ExtB", 30F);
            Tile3.ForeColor = Color.Black;
            Tile3.Location = new Point(28, 157);
            Tile3.Name = "Tile3";
            Tile3.Size = new Size(123, 123);
            Tile3.TabIndex = 3;
            Tile3.UseVisualStyleBackColor = true;
            Tile3.Click += TileB1_Click;
            // 
            // Tile2
            // 
            Tile2.Font = new Font("PMingLiU-ExtB", 30F);
            Tile2.ForeColor = Color.Black;
            Tile2.Location = new Point(286, 28);
            Tile2.Name = "Tile2";
            Tile2.Size = new Size(123, 123);
            Tile2.TabIndex = 2;
            Tile2.UseVisualStyleBackColor = true;
            Tile2.Click += TileA3_Click;
            // 
            // Tile1
            // 
            Tile1.Font = new Font("PMingLiU-ExtB", 30F);
            Tile1.ForeColor = Color.Black;
            Tile1.Location = new Point(157, 28);
            Tile1.Name = "Tile1";
            Tile1.Size = new Size(123, 123);
            Tile1.TabIndex = 1;
            Tile1.UseVisualStyleBackColor = true;
            Tile1.Click += TileA2_Click;
            // 
            // Tile0
            // 
            Tile0.Font = new Font("PMingLiU-ExtB", 30F);
            Tile0.ForeColor = Color.Black;
            Tile0.Location = new Point(28, 28);
            Tile0.Name = "Tile0";
            Tile0.Size = new Size(123, 123);
            Tile0.TabIndex = 0;
            Tile0.UseVisualStyleBackColor = true;
            Tile0.Click += TileA1_Click;
            // 
            // Line1
            // 
            Line1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Line1.BackColor = Color.FromArgb(96, 29, 0);
            Line1.Font = new Font("PMingLiU-ExtB", 20F);
            Line1.Location = new Point(59, 0);
            Line1.Name = "Line1";
            Line1.Size = new Size(60, 40);
            Line1.TabIndex = 0;
            Line1.Text = "1";
            Line1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Line2
            // 
            Line2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Line2.BackColor = Color.FromArgb(96, 29, 0);
            Line2.Font = new Font("PMingLiU-ExtB", 20F);
            Line2.Location = new Point(188, 0);
            Line2.Name = "Line2";
            Line2.Size = new Size(60, 40);
            Line2.TabIndex = 13;
            Line2.Text = "2";
            Line2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Line3
            // 
            Line3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Line3.BackColor = Color.FromArgb(96, 29, 0);
            Line3.Font = new Font("PMingLiU-ExtB", 20F);
            Line3.Location = new Point(317, 0);
            Line3.Name = "Line3";
            Line3.Size = new Size(60, 40);
            Line3.TabIndex = 14;
            Line3.Text = "3";
            Line3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LineA
            // 
            LineA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LineA.BackColor = Color.FromArgb(96, 29, 0);
            LineA.Font = new Font("PMingLiU-ExtB", 20F);
            LineA.Location = new Point(0, 59);
            LineA.Name = "LineA";
            LineA.Size = new Size(40, 60);
            LineA.TabIndex = 15;
            LineA.Text = "A";
            LineA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LineB
            // 
            LineB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LineB.BackColor = Color.FromArgb(96, 29, 0);
            LineB.Font = new Font("PMingLiU-ExtB", 20F);
            LineB.Location = new Point(0, 188);
            LineB.Name = "LineB";
            LineB.Size = new Size(40, 60);
            LineB.TabIndex = 16;
            LineB.Text = "B";
            LineB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LineC
            // 
            LineC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LineC.BackColor = Color.FromArgb(96, 29, 0);
            LineC.Font = new Font("PMingLiU-ExtB", 20F);
            LineC.Location = new Point(0, 317);
            LineC.Name = "LineC";
            LineC.Size = new Size(40, 60);
            LineC.TabIndex = 17;
            LineC.Text = "C";
            LineC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ScoreBackPanel
            // 
            ScoreBackPanel.BackColor = Color.FromArgb(255, 195, 0);
            ScoreBackPanel.Controls.Add(ScoreDisp);
            ScoreBackPanel.Location = new Point(476, 40);
            ScoreBackPanel.Name = "ScoreBackPanel";
            ScoreBackPanel.Size = new Size(287, 74);
            ScoreBackPanel.TabIndex = 1;
            // 
            // ScoreDisp
            // 
            ScoreDisp.Font = new Font("Impact", 20F);
            ScoreDisp.Location = new Point(3, 0);
            ScoreDisp.Name = "ScoreDisp";
            ScoreDisp.Size = new Size(281, 74);
            ScoreDisp.TabIndex = 0;
            ScoreDisp.Text = "0";
            ScoreDisp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ScoreTitle
            // 
            ScoreTitle.BackColor = Color.FromArgb(165, 127, 0);
            ScoreTitle.Font = new Font("PMingLiU-ExtB", 20F);
            ScoreTitle.Location = new Point(479, 12);
            ScoreTitle.Name = "ScoreTitle";
            ScoreTitle.Size = new Size(126, 46);
            ScoreTitle.TabIndex = 0;
            ScoreTitle.Text = "COUNT";
            ScoreTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CubeSecondThirdPanel
            // 
            CubeSecondThirdPanel.BackColor = Color.FromArgb(22, 6, 0);
            CubeSecondThirdPanel.Controls.Add(ThirdLabel);
            CubeSecondThirdPanel.Controls.Add(ThirdCube);
            CubeSecondThirdPanel.Controls.Add(SecondLabel);
            CubeSecondThirdPanel.Controls.Add(SecondCube);
            CubeSecondThirdPanel.Location = new Point(598, 120);
            CubeSecondThirdPanel.Name = "CubeSecondThirdPanel";
            CubeSecondThirdPanel.Size = new Size(205, 319);
            CubeSecondThirdPanel.TabIndex = 2;
            // 
            // ThirdLabel
            // 
            ThirdLabel.AutoSize = true;
            ThirdLabel.Font = new Font("PMingLiU-ExtB", 15F);
            ThirdLabel.Location = new Point(14, 281);
            ThirdLabel.Name = "ThirdLabel";
            ThirdLabel.Size = new Size(49, 20);
            ThirdLabel.TabIndex = 3;
            ThirdLabel.Text = "Third";
            // 
            // ThirdCube
            // 
            ThirdCube.BackColor = Color.White;
            ThirdCube.Font = new Font("PMingLiU-ExtB", 30F);
            ThirdCube.Location = new Point(69, 178);
            ThirdCube.Name = "ThirdCube";
            ThirdCube.Size = new Size(123, 123);
            ThirdCube.TabIndex = 2;
            ThirdCube.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SecondLabel
            // 
            SecondLabel.AutoSize = true;
            SecondLabel.Font = new Font("PMingLiU-ExtB", 15F);
            SecondLabel.Location = new Point(3, 120);
            SecondLabel.Name = "SecondLabel";
            SecondLabel.Size = new Size(62, 20);
            SecondLabel.TabIndex = 1;
            SecondLabel.Text = "Second";
            // 
            // SecondCube
            // 
            SecondCube.BackColor = Color.White;
            SecondCube.Font = new Font("PMingLiU-ExtB", 30F);
            SecondCube.Location = new Point(69, 13);
            SecondCube.Name = "SecondCube";
            SecondCube.Size = new Size(123, 123);
            SecondCube.TabIndex = 0;
            SecondCube.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.IndianRed;
            ResetButton.Font = new Font("PMingLiU-ExtB", 20F);
            ResetButton.ForeColor = Color.Transparent;
            ResetButton.Location = new Point(448, 392);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(144, 47);
            ResetButton.TabIndex = 3;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // RankingButton
            // 
            RankingButton.BackColor = Color.Gold;
            RankingButton.Font = new Font("PMingLiU-ExtB", 20F);
            RankingButton.ForeColor = Color.Black;
            RankingButton.Location = new Point(448, 336);
            RankingButton.Name = "RankingButton";
            RankingButton.Size = new Size(144, 47);
            RankingButton.TabIndex = 4;
            RankingButton.Text = "RANK";
            RankingButton.UseVisualStyleBackColor = false;
            RankingButton.Click += RankingButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = Color.MediumBlue;
            LoadButton.Font = new Font("PMingLiU-ExtB", 20F);
            LoadButton.ForeColor = Color.Transparent;
            LoadButton.Location = new Point(448, 283);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(144, 47);
            LoadButton.TabIndex = 5;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.LimeGreen;
            SaveButton.Font = new Font("PMingLiU-ExtB", 20F);
            SaveButton.ForeColor = Color.Transparent;
            SaveButton.Location = new Point(448, 230);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(144, 47);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 1, 15);
            ClientSize = new Size(804, 451);
            Controls.Add(SaveButton);
            Controls.Add(LoadButton);
            Controls.Add(RankingButton);
            Controls.Add(ResetButton);
            Controls.Add(CubeSecondThirdPanel);
            Controls.Add(ScoreTitle);
            Controls.Add(ScoreBackPanel);
            Controls.Add(GameField);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "GCubeGame v1.0.0";
            Shown += MainForm_Shown;
            GameField.ResumeLayout(false);
            ScoreBackPanel.ResumeLayout(false);
            CubeSecondThirdPanel.ResumeLayout(false);
            CubeSecondThirdPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel GameField;
        private Label LineA;
        private Label Line3;
        private Label Line2;
        private Label Line1;
        private Label LineB;
        private Label LineC;
        private Panel ScoreBackPanel;
        private Label ScoreTitle;
        private Panel CubeSecondThirdPanel;
        private Label ThirdLabel;
        private Label SecondLabel;
        private Button ResetButton;
        private Button RankingButton;
        private Button LoadButton;
        private Button SaveButton;
        private Button Tile0;
        private Button Tile1;
        private Button Tile2;
        private Button Tile3;
        private Button Tile4;
        private Button Tile5;
        private Button Tile6;
        private Button Tile7;
        private Button Tile8;
        private Label ScoreDisp;
        private Label SecondCube;
        private Label ThirdCube;
        private Label GameStatusPanel;

        
    }
}
