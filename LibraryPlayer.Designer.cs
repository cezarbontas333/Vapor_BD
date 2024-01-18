namespace Vapor
{
    partial class LibraryPlayer
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
            playGame = new Button();
            sendToGamePage = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            storeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            ShowAchievements = new Button();
            LibraryView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LibraryView).BeginInit();
            SuspendLayout();
            // 
            // playGame
            // 
            playGame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playGame.Location = new Point(502, 608);
            playGame.Name = "playGame";
            playGame.Size = new Size(156, 55);
            playGame.TabIndex = 8;
            playGame.Text = "Play";
            playGame.UseVisualStyleBackColor = true;
            // 
            // sendToGamePage
            // 
            sendToGamePage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sendToGamePage.Location = new Point(85, 608);
            sendToGamePage.Name = "sendToGamePage";
            sendToGamePage.Size = new Size(156, 55);
            sendToGamePage.TabIndex = 6;
            sendToGamePage.Text = "Game's page";
            sendToGamePage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 72);
            label1.Name = "label1";
            label1.Size = new Size(349, 81);
            label1.TabIndex = 5;
            label1.Text = "Your Games";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, storeToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1178, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // storeToolStripMenuItem
            // 
            storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            storeToolStripMenuItem.Size = new Size(58, 24);
            storeToolStripMenuItem.Text = "Store";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountToolStripMenuItem, settingsToolStripMenuItem, logOutToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(146, 26);
            accountToolStripMenuItem.Text = "Account";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(146, 26);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(146, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // ShowAchievements
            // 
            ShowAchievements.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowAchievements.Location = new Point(902, 608);
            ShowAchievements.Name = "ShowAchievements";
            ShowAchievements.Size = new Size(156, 55);
            ShowAchievements.TabIndex = 10;
            ShowAchievements.Text = "Achievements";
            ShowAchievements.UseVisualStyleBackColor = true;
            ShowAchievements.Click += ShowAchievements_Click;
            // 
            // LibraryView
            // 
            LibraryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LibraryView.Location = new Point(85, 177);
            LibraryView.Name = "LibraryView";
            LibraryView.RowHeadersWidth = 51;
            LibraryView.RowTemplate.Height = 29;
            LibraryView.Size = new Size(973, 352);
            LibraryView.TabIndex = 11;
            LibraryView.CellContentClick += LibraryView_CellContentClick;
            // 
            // LibraryPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 715);
            Controls.Add(LibraryView);
            Controls.Add(ShowAchievements);
            Controls.Add(playGame);
            Controls.Add(sendToGamePage);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "LibraryPlayer";
            Text = "LibraryPlayer";
            Load += LibraryPlayer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LibraryView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playGame;
        private Button sendToGamePage;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem storeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Button ShowAchievements;
        private DataGridView LibraryView;
    }
}