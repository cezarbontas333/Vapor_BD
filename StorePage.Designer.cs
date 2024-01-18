namespace Vapor
{
    partial class StorePage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            libraryToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem1 = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            SubmitSearchGame = new Button();
            label5 = new Label();
            SearchGameBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            BestGamesGrid = new DataGridView();
            RecommendedGrid = new DataGridView();
            RandomGrid = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BestGamesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecommendedGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RandomGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(787, 52);
            label1.Name = "label1";
            label1.Size = new Size(343, 81);
            label1.TabIndex = 0;
            label1.Text = "Vapor Store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(242, 217);
            label2.Name = "label2";
            label2.Size = new Size(247, 41);
            label2.TabIndex = 4;
            label2.Text = "Best rated games";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(797, 217);
            label3.Name = "label3";
            label3.Size = new Size(323, 41);
            label3.TabIndex = 5;
            label3.Text = "Recommended for you";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1435, 217);
            label4.Name = "label4";
            label4.Size = new Size(190, 41);
            label4.TabIndex = 6;
            label4.Text = "Other games";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, libraryToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1886, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // libraryToolStripMenuItem
            // 
            libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            libraryToolStripMenuItem.Size = new Size(68, 24);
            libraryToolStripMenuItem.Text = "Library";
            libraryToolStripMenuItem.Click += libraryToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountToolStripMenuItem1, settingsToolStripMenuItem, logOutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(75, 24);
            accountToolStripMenuItem.Text = "Options";
            // 
            // accountToolStripMenuItem1
            // 
            accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            accountToolStripMenuItem1.Size = new Size(146, 26);
            accountToolStripMenuItem1.Text = "Account";
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
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // SubmitSearchGame
            // 
            SubmitSearchGame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitSearchGame.Location = new Point(1185, 836);
            SubmitSearchGame.Name = "SubmitSearchGame";
            SubmitSearchGame.Size = new Size(143, 38);
            SubmitSearchGame.TabIndex = 12;
            SubmitSearchGame.Text = "Search";
            SubmitSearchGame.UseVisualStyleBackColor = true;
            SubmitSearchGame.Click += SubmitSearchGame_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(498, 834);
            label5.Name = "label5";
            label5.Size = new Size(215, 37);
            label5.TabIndex = 11;
            label5.Text = "Search for game:";
            // 
            // SearchGameBox
            // 
            SearchGameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchGameBox.Location = new Point(719, 811);
            SearchGameBox.Multiline = true;
            SearchGameBox.Name = "SearchGameBox";
            SearchGameBox.Size = new Size(460, 93);
            SearchGameBox.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.6504059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.6504059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // BestGamesGrid
            // 
            BestGamesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BestGamesGrid.Location = new Point(149, 302);
            BestGamesGrid.Name = "BestGamesGrid";
            BestGamesGrid.RowHeadersWidth = 51;
            BestGamesGrid.RowTemplate.Height = 29;
            BestGamesGrid.Size = new Size(441, 439);
            BestGamesGrid.TabIndex = 13;
            // 
            // RecommendedGrid
            // 
            RecommendedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecommendedGrid.Location = new Point(729, 302);
            RecommendedGrid.Name = "RecommendedGrid";
            RecommendedGrid.RowHeadersWidth = 51;
            RecommendedGrid.RowTemplate.Height = 29;
            RecommendedGrid.Size = new Size(441, 439);
            RecommendedGrid.TabIndex = 14;
            // 
            // RandomGrid
            // 
            RandomGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RandomGrid.Location = new Point(1298, 302);
            RandomGrid.Name = "RandomGrid";
            RandomGrid.RowHeadersWidth = 51;
            RandomGrid.RowTemplate.Height = 29;
            RandomGrid.Size = new Size(441, 439);
            RandomGrid.TabIndex = 15;
            // 
            // StorePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1886, 974);
            Controls.Add(RandomGrid);
            Controls.Add(RecommendedGrid);
            Controls.Add(BestGamesGrid);
            Controls.Add(SubmitSearchGame);
            Controls.Add(label5);
            Controls.Add(SearchGameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StorePage";
            Text = "StorePage";
            Load += StorePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BestGamesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecommendedGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RandomGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem libraryToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Button SubmitSearchGame;
        private Label label5;
        private TextBox SearchGameBox;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView BestGamesGrid;
        private DataGridView RecommendedGrid;
        private DataGridView RandomGrid;
    }
}