namespace Vapor
{
    partial class GamePage
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
            gameTitle = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            setingsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            PriceLabel = new Label();
            DateLabel = new Label();
            PublisherLabel = new Label();
            label7 = new Label();
            label8 = new Label();
            RatingBox = new ComboBox();
            ReviewWriteBox = new TextBox();
            label9 = new Label();
            SubmitReview = new Button();
            label10 = new Label();
            AvgRating = new Label();
            ReviewsGrid = new DataGridView();
            Buy = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReviewsGrid).BeginInit();
            SuspendLayout();
            // 
            // gameTitle
            // 
            gameTitle.AutoSize = true;
            gameTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameTitle.Location = new Point(112, 107);
            gameTitle.Name = "gameTitle";
            gameTitle.Size = new Size(385, 81);
            gameTitle.TabIndex = 0;
            gameTitle.Text = "$gameTitle$";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1169, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountToolStripMenuItem, setingsToolStripMenuItem, logOutToolStripMenuItem });
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
            // setingsToolStripMenuItem
            // 
            setingsToolStripMenuItem.Name = "setingsToolStripMenuItem";
            setingsToolStripMenuItem.Size = new Size(146, 26);
            setingsToolStripMenuItem.Text = "Setings";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(146, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 194);
            label2.Name = "label2";
            label2.Size = new Size(147, 41);
            label2.TabIndex = 6;
            label2.Text = "Publisher:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 235);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 7;
            label1.Text = "Date of release:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(115, 276);
            label3.Name = "label3";
            label3.Size = new Size(89, 41);
            label3.TabIndex = 8;
            label3.Text = "Price:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(210, 276);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(161, 41);
            PriceLabel.TabIndex = 11;
            PriceLabel.Text = "$priceTag$";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(342, 235);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(241, 41);
            DateLabel.TabIndex = 10;
            DateLabel.Text = "$dateOfRelease$";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherLabel.Location = new Point(266, 194);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(246, 41);
            PublisherLabel.TabIndex = 9;
            PublisherLabel.Text = "$namePublisher$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(170, 333);
            label7.Name = "label7";
            label7.Size = new Size(98, 32);
            label7.TabIndex = 13;
            label7.Text = "Reviews";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(112, 655);
            label8.Name = "label8";
            label8.Size = new Size(259, 32);
            label8.TabIndex = 14;
            label8.Text = "Write your own review:";
            // 
            // RatingBox
            // 
            RatingBox.FormattingEnabled = true;
            RatingBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            RatingBox.Location = new Point(284, 711);
            RatingBox.Name = "RatingBox";
            RatingBox.Size = new Size(142, 28);
            RatingBox.TabIndex = 15;
            // 
            // ReviewWriteBox
            // 
            ReviewWriteBox.Location = new Point(478, 655);
            ReviewWriteBox.Multiline = true;
            ReviewWriteBox.Name = "ReviewWriteBox";
            ReviewWriteBox.Size = new Size(613, 135);
            ReviewWriteBox.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(44, 705);
            label9.Name = "label9";
            label9.Size = new Size(199, 32);
            label9.TabIndex = 17;
            label9.Text = "Give a star rating:";
            // 
            // SubmitReview
            // 
            SubmitReview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitReview.Location = new Point(170, 769);
            SubmitReview.Name = "SubmitReview";
            SubmitReview.Size = new Size(131, 45);
            SubmitReview.TabIndex = 18;
            SubmitReview.Text = "Submit";
            SubmitReview.UseVisualStyleBackColor = true;
            SubmitReview.Click += SubmitReview_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(861, 147);
            label10.Name = "label10";
            label10.Size = new Size(87, 32);
            label10.TabIndex = 19;
            label10.Text = "Rating:";
            // 
            // AvgRating
            // 
            AvgRating.AutoSize = true;
            AvgRating.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AvgRating.Location = new Point(954, 147);
            AvgRating.Name = "AvgRating";
            AvgRating.Size = new Size(137, 32);
            AvgRating.TabIndex = 20;
            AvgRating.Text = "$avgScore$";
            // 
            // ReviewsGrid
            // 
            ReviewsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReviewsGrid.Location = new Point(112, 368);
            ReviewsGrid.Name = "ReviewsGrid";
            ReviewsGrid.RowHeadersWidth = 51;
            ReviewsGrid.RowTemplate.Height = 29;
            ReviewsGrid.Size = new Size(979, 196);
            ReviewsGrid.TabIndex = 21;
            // 
            // Buy
            // 
            Buy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Buy.Location = new Point(909, 238);
            Buy.Name = "Buy";
            Buy.Size = new Size(157, 42);
            Buy.TabIndex = 22;
            Buy.Text = "Buy";
            Buy.UseVisualStyleBackColor = true;
            // 
            // GamePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 871);
            Controls.Add(Buy);
            Controls.Add(ReviewsGrid);
            Controls.Add(AvgRating);
            Controls.Add(label10);
            Controls.Add(SubmitReview);
            Controls.Add(label9);
            Controls.Add(ReviewWriteBox);
            Controls.Add(RatingBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PriceLabel);
            Controls.Add(DateLabel);
            Controls.Add(PublisherLabel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(gameTitle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GamePage";
            Text = "GamePage";
            Load += GamePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReviewsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameTitle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem setingsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label PriceLabel;
        private Label DateLabel;
        private Label PublisherLabel;
        private Label label7;
        private Label label8;
        private ComboBox RatingBox;
        private TextBox ReviewWriteBox;
        private Label label9;
        private Button SubmitReview;
        private Label label10;
        private Label AvgRating;
        private DataGridView ReviewsGrid;
        private Button Buy;
    }
}