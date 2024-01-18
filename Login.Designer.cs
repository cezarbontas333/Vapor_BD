namespace Vapor
{
    partial class Login_Page
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
            Title_Login_Page = new Label();
            Login_label = new Label();
            Login_Button = new Button();
            Username_Input_Label = new Label();
            Password_Input_Label = new Label();
            Username_Input_Box = new TextBox();
            Password_Input_Box = new TextBox();
            SuspendLayout();
            // 
            // Title_Login_Page
            // 
            Title_Login_Page.AutoSize = true;
            Title_Login_Page.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Title_Login_Page.Location = new Point(251, 9);
            Title_Login_Page.Name = "Title_Login_Page";
            Title_Login_Page.Size = new Size(194, 81);
            Title_Login_Page.TabIndex = 0;
            Title_Login_Page.Text = "Vapor";
            Title_Login_Page.Click += label1_Click;
            // 
            // Login_label
            // 
            Login_label.AutoSize = true;
            Login_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Login_label.Location = new Point(300, 110);
            Login_label.Name = "Login_label";
            Login_label.Size = new Size(92, 41);
            Login_label.TabIndex = 1;
            Login_label.Text = "Login";
            Login_label.Click += label2_Click;
            // 
            // Login_Button
            // 
            Login_Button.FlatStyle = FlatStyle.System;
            Login_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Login_Button.Location = new Point(280, 507);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(125, 41);
            Login_Button.TabIndex = 2;
            Login_Button.Text = "Log In";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Username_Input_Label
            // 
            Username_Input_Label.AutoSize = true;
            Username_Input_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Username_Input_Label.Location = new Point(74, 207);
            Username_Input_Label.Name = "Username_Input_Label";
            Username_Input_Label.Size = new Size(99, 28);
            Username_Input_Label.TabIndex = 3;
            Username_Input_Label.Text = "Username";
            Username_Input_Label.Click += label3_Click;
            // 
            // Password_Input_Label
            // 
            Password_Input_Label.AutoSize = true;
            Password_Input_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password_Input_Label.Location = new Point(74, 285);
            Password_Input_Label.Name = "Password_Input_Label";
            Password_Input_Label.Size = new Size(93, 28);
            Password_Input_Label.TabIndex = 4;
            Password_Input_Label.Text = "Password";
            Password_Input_Label.Click += label4_Click;
            // 
            // Username_Input_Box
            // 
            Username_Input_Box.Location = new Point(223, 208);
            Username_Input_Box.Name = "Username_Input_Box";
            Username_Input_Box.Size = new Size(341, 27);
            Username_Input_Box.TabIndex = 5;
            Username_Input_Box.TextChanged += Username_Input_Box_TextChanged;
            // 
            // Password_Input_Box
            // 
            Password_Input_Box.Location = new Point(223, 285);
            Password_Input_Box.Name = "Password_Input_Box";
            Password_Input_Box.Size = new Size(341, 27);
            Password_Input_Box.TabIndex = 6;
            Password_Input_Box.TextChanged += Password_Input_Box_TextChanged;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 588);
            Controls.Add(Password_Input_Box);
            Controls.Add(Username_Input_Box);
            Controls.Add(Password_Input_Label);
            Controls.Add(Username_Input_Label);
            Controls.Add(Login_Button);
            Controls.Add(Login_label);
            Controls.Add(Title_Login_Page);
            Name = "Login_Page";
            Text = "Vapor - Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_Login_Page;
        private Label Login_label;
        private Button Login_Button;
        private Label Username_Input_Label;
        private Label Password_Input_Label;
        private TextBox Username_Input_Box;
        private TextBox Password_Input_Box;
    }
}