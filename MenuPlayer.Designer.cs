namespace Vapor
{
    partial class MenuPlayer
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
            menuStrip1 = new MenuStrip();
            storeToolStripMenuItem = new ToolStripMenuItem();
            libraryToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            programToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            greetings = new Label();
            fav_label = new Label();
            MostPlayedGrid = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostPlayedGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { storeToolStripMenuItem, libraryToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1223, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // storeToolStripMenuItem
            // 
            storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            storeToolStripMenuItem.Size = new Size(58, 24);
            storeToolStripMenuItem.Text = "Store";
            storeToolStripMenuItem.Click += storeToolStripMenuItem_Click;
            // 
            // libraryToolStripMenuItem
            // 
            libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            libraryToolStripMenuItem.Size = new Size(68, 24);
            libraryToolStripMenuItem.Text = "Library";
            libraryToolStripMenuItem.Click += libraryToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountToolStripMenuItem, programToolStripMenuItem, logOutToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(149, 26);
            accountToolStripMenuItem.Text = "Account";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(149, 26);
            programToolStripMenuItem.Text = "Program";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(149, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // greetings
            // 
            greetings.AutoSize = true;
            greetings.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            greetings.Location = new Point(266, 107);
            greetings.Name = "greetings";
            greetings.Size = new Size(523, 81);
            greetings.TabIndex = 2;
            greetings.Text = "Welcome to Vapor";
            // 
            // fav_label
            // 
            fav_label.AutoSize = true;
            fav_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            fav_label.Location = new Point(465, 251);
            fav_label.Name = "fav_label";
            fav_label.Size = new Size(279, 41);
            fav_label.TabIndex = 6;
            fav_label.Text = "Most played games";
            // 
            // MostPlayedGrid
            // 
            MostPlayedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostPlayedGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MostPlayedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostPlayedGrid.Location = new Point(129, 329);
            MostPlayedGrid.Name = "MostPlayedGrid";
            MostPlayedGrid.ReadOnly = true;
            MostPlayedGrid.RowHeadersWidth = 51;
            MostPlayedGrid.RowTemplate.Height = 29;
            MostPlayedGrid.Size = new Size(966, 598);
            MostPlayedGrid.TabIndex = 10;
            // 
            // MenuPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 1029);
            Controls.Add(MostPlayedGrid);
            Controls.Add(fav_label);
            Controls.Add(greetings);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPlayer";
            Text = "Home";
            Load += MenuPlayer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostPlayedGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem storeToolStripMenuItem;
        private ToolStripMenuItem libraryToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private Label greetings;
        private Label fav_label;
        private DataGridView MostPlayedGrid;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}