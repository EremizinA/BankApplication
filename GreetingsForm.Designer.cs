namespace MyVisualApplication
{
    partial class GreetingsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreetingsForm));
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.SigninButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.GreetingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GreetingsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreetingsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingsLabel.Location = new System.Drawing.Point(112, 41);
            this.GreetingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(450, 122);
            this.GreetingsLabel.TabIndex = 0;
            this.GreetingsLabel.Text = "Welcome, dear client!";
            this.GreetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SigninButton
            // 
            this.SigninButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SigninButton.Location = new System.Drawing.Point(112, 197);
            this.SigninButton.Margin = new System.Windows.Forms.Padding(2);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(450, 65);
            this.SigninButton.TabIndex = 1;
            this.SigninButton.Text = "Sign In";
            this.SigninButton.UseVisualStyleBackColor = true;
            this.SigninButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(112, 301);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(450, 65);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(112, 406);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(450, 65);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // GreetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 531);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SigninButton);
            this.Controls.Add(this.GreetingsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GreetingsForm";
            this.Text = "GreetingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

