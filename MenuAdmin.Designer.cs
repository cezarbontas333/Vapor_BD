namespace Vapor
{
    partial class MenuAdmin
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
            optionsToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            Users_label = new Label();
            Games_Search_label = new Label();
            gamesSearchBox = new TextBox();
            userSearchBox = new TextBox();
            submitSearchUser = new Button();
            submitSearchGames = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1141, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(350, 103);
            label1.Name = "label1";
            label1.Size = new Size(424, 60);
            label1.TabIndex = 1;
            label1.Text = "Admin Management\r\n";
            // 
            // Users_label
            // 
            Users_label.AutoSize = true;
            Users_label.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Users_label.Location = new Point(173, 341);
            Users_label.Name = "Users_label";
            Users_label.Size = new Size(162, 37);
            Users_label.TabIndex = 2;
            Users_label.Text = "Search users";
            // 
            // Games_Search_label
            // 
            Games_Search_label.AutoSize = true;
            Games_Search_label.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Games_Search_label.Location = new Point(782, 341);
            Games_Search_label.Name = "Games_Search_label";
            Games_Search_label.Size = new Size(180, 37);
            Games_Search_label.TabIndex = 3;
            Games_Search_label.Text = "Search games";
            // 
            // gamesSearchBox
            // 
            gamesSearchBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gamesSearchBox.Location = new Point(711, 381);
            gamesSearchBox.Multiline = true;
            gamesSearchBox.Name = "gamesSearchBox";
            gamesSearchBox.Size = new Size(321, 73);
            gamesSearchBox.TabIndex = 5;
            // 
            // userSearchBox
            // 
            userSearchBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            userSearchBox.Location = new Point(98, 381);
            userSearchBox.Multiline = true;
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(321, 73);
            userSearchBox.TabIndex = 6;
            // 
            // submitSearchUser
            // 
            submitSearchUser.Location = new Point(199, 510);
            submitSearchUser.Name = "submitSearchUser";
            submitSearchUser.Size = new Size(94, 29);
            submitSearchUser.TabIndex = 7;
            submitSearchUser.Text = "Submit";
            submitSearchUser.UseVisualStyleBackColor = true;
            // 
            // submitSearchGames
            // 
            submitSearchGames.Location = new Point(826, 510);
            submitSearchGames.Name = "submitSearchGames";
            submitSearchGames.Size = new Size(94, 29);
            submitSearchGames.TabIndex = 8;
            submitSearchGames.Text = "Submit";
            submitSearchGames.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 897);
            Controls.Add(submitSearchGames);
            Controls.Add(submitSearchUser);
            Controls.Add(userSearchBox);
            Controls.Add(gamesSearchBox);
            Controls.Add(Games_Search_label);
            Controls.Add(Users_label);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuAdmin";
            Text = "Admin Panel";
            Load += MenuAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Label Users_label;
        private Label Games_Search_label;
        private TextBox gamesSearchBox;
        private TextBox userSearchBox;
        private Button submitSearchUser;
        private Button submitSearchGames;
    }
}