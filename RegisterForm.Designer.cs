namespace MyVisualApplication
{
    partial class RegisterForm
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
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityForm = new System.Windows.Forms.TextBox();
            this.CountryForm = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RPasswordLabel = new System.Windows.Forms.Label();
            this.RPasswordForm = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordForm = new System.Windows.Forms.TextBox();
            this.LoginForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SurNameForm = new System.Windows.Forms.TextBox();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.FatherNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FatherNameForm = new System.Windows.Forms.TextBox();
            this.FirstNameForm = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.GreetingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GreetingsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreetingsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingsLabel.Location = new System.Drawing.Point(31, 9);
            this.GreetingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(450, 40);
            this.GreetingsLabel.TabIndex = 2;
            this.GreetingsLabel.Text = "Welcome, dear client!";
            this.GreetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SendButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(31, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 610);
            this.panel1.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(122, 566);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(210, 28);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CountryLabel);
            this.panel4.Controls.Add(this.CityLabel);
            this.panel4.Controls.Add(this.CityForm);
            this.panel4.Controls.Add(this.CountryForm);
            this.panel4.Location = new System.Drawing.Point(61, 426);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 125);
            this.panel4.TabIndex = 4;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(143, 9);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 3;
            this.CountryLabel.Text = "Country";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(152, 67);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Text = "City";
            // 
            // CityForm
            // 
            this.CityForm.Location = new System.Drawing.Point(61, 92);
            this.CityForm.Name = "CityForm";
            this.CityForm.Size = new System.Drawing.Size(210, 20);
            this.CityForm.TabIndex = 1;
            // 
            // CountryForm
            // 
            this.CountryForm.Location = new System.Drawing.Point(61, 35);
            this.CountryForm.Name = "CountryForm";
            this.CountryForm.Size = new System.Drawing.Size(210, 20);
            this.CountryForm.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LoginLabel);
            this.panel3.Controls.Add(this.RPasswordLabel);
            this.panel3.Controls.Add(this.RPasswordForm);
            this.panel3.Controls.Add(this.PasswordLabel);
            this.panel3.Controls.Add(this.PasswordForm);
            this.panel3.Controls.Add(this.LoginForm);
            this.panel3.Location = new System.Drawing.Point(61, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 187);
            this.panel3.TabIndex = 4;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(152, 10);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Login";
            // 
            // RPasswordLabel
            // 
            this.RPasswordLabel.AutoSize = true;
            this.RPasswordLabel.Location = new System.Drawing.Point(119, 124);
            this.RPasswordLabel.Name = "RPasswordLabel";
            this.RPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.RPasswordLabel.TabIndex = 5;
            this.RPasswordLabel.Text = "Repeat Password";
            // 
            // RPasswordForm
            // 
            this.RPasswordForm.Location = new System.Drawing.Point(61, 151);
            this.RPasswordForm.Name = "RPasswordForm";
            this.RPasswordForm.Size = new System.Drawing.Size(210, 20);
            this.RPasswordForm.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(139, 67);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordForm
            // 
            this.PasswordForm.Location = new System.Drawing.Point(61, 92);
            this.PasswordForm.Name = "PasswordForm";
            this.PasswordForm.Size = new System.Drawing.Size(210, 20);
            this.PasswordForm.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.LoginForm.Location = new System.Drawing.Point(61, 35);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(210, 20);
            this.LoginForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fill the forms below";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SurNameForm);
            this.panel2.Controls.Add(this.SurNameLabel);
            this.panel2.Controls.Add(this.FatherNameLabel);
            this.panel2.Controls.Add(this.FirstNameLabel);
            this.panel2.Controls.Add(this.FatherNameForm);
            this.panel2.Controls.Add(this.FirstNameForm);
            this.panel2.Location = new System.Drawing.Point(61, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 184);
            this.panel2.TabIndex = 0;
            // 
            // SurNameForm
            // 
            this.SurNameForm.Location = new System.Drawing.Point(61, 149);
            this.SurNameForm.Name = "SurNameForm";
            this.SurNameForm.Size = new System.Drawing.Size(210, 20);
            this.SurNameForm.TabIndex = 4;
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Location = new System.Drawing.Point(134, 124);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurNameLabel.TabIndex = 3;
            this.SurNameLabel.Text = "Surname";
            // 
            // FatherNameLabel
            // 
            this.FatherNameLabel.AutoSize = true;
            this.FatherNameLabel.Location = new System.Drawing.Point(143, 67);
            this.FatherNameLabel.Name = "FatherNameLabel";
            this.FatherNameLabel.Size = new System.Drawing.Size(68, 13);
            this.FatherNameLabel.TabIndex = 3;
            this.FatherNameLabel.Text = "Father Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(143, 10);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FatherNameForm
            // 
            this.FatherNameForm.Location = new System.Drawing.Point(61, 92);
            this.FatherNameForm.Name = "FatherNameForm";
            this.FatherNameForm.Size = new System.Drawing.Size(210, 20);
            this.FatherNameForm.TabIndex = 1;
            // 
            // FirstNameForm
            // 
            this.FirstNameForm.Location = new System.Drawing.Point(61, 35);
            this.FirstNameForm.Name = "FirstNameForm";
            this.FirstNameForm.Size = new System.Drawing.Size(210, 20);
            this.FirstNameForm.TabIndex = 0;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GreetingsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityForm;
        private System.Windows.Forms.TextBox CountryForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label RPasswordLabel;
        private System.Windows.Forms.TextBox RPasswordForm;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordForm;
        private System.Windows.Forms.TextBox LoginForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SurNameForm;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label FatherNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FatherNameForm;
        private System.Windows.Forms.TextBox FirstNameForm;
        private System.Windows.Forms.Button SendButton;
    }
}