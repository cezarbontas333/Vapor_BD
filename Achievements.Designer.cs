namespace Vapor
{
    partial class Achievements
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
            AchievementsView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AchievementsView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 35);
            label1.Name = "label1";
            label1.Size = new Size(296, 60);
            label1.TabIndex = 0;
            label1.Text = "Achievements";
            // 
            // AchievementsView
            // 
            AchievementsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AchievementsView.Location = new Point(67, 127);
            AchievementsView.Name = "AchievementsView";
            AchievementsView.RowHeadersWidth = 51;
            AchievementsView.RowTemplate.Height = 29;
            AchievementsView.Size = new Size(674, 445);
            AchievementsView.TabIndex = 1;
            AchievementsView.CellContentClick += AchievementsView_CellContentClick;
            // 
            // Achievements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 646);
            Controls.Add(AchievementsView);
            Controls.Add(label1);
            Name = "Achievements";
            Text = "Achievements";
            Load += Achievements_Load;
            ((System.ComponentModel.ISupportInitialize)AchievementsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView AchievementsView;
    }
}