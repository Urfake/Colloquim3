namespace Colloquim3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            password_input = new TextBox();
            email_input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(250, 277);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 0;
            button1.Text = "Завершить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password_input
            // 
            password_input.Location = new Point(250, 244);
            password_input.Name = "password_input";
            password_input.Size = new Size(300, 27);
            password_input.TabIndex = 1;
            // 
            // email_input
            // 
            email_input.Location = new Point(250, 172);
            email_input.Name = "email_input";
            email_input.Size = new Size(300, 27);
            email_input.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 140);
            label1.Name = "label1";
            label1.Size = new Size(78, 29);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(250, 212);
            label2.Name = "label2";
            label2.Size = new Size(88, 29);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(400, 277);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 0;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(219, 9);
            label3.Name = "label3";
            label3.Size = new Size(362, 68);
            label3.TabIndex = 5;
            label3.Text = "Регистрация";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(782, 553);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(email_input);
            Controls.Add(password_input);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox password_input;
        private TextBox email_input;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}