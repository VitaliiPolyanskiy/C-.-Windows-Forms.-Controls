namespace MaskedTextBoxControl
{
    partial class Form1
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
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(15, 40);
            maskedTextBox1.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(317, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(15, 114);
            maskedTextBox2.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(317, 27);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 2;
            label1.Text = "Номер телефона:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Время:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 5;
            label3.Text = "Фамилия и инициалы:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(15, 195);
            maskedTextBox3.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox3.Mask = "L.L.L?????????";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(317, 27);
            maskedTextBox3.TabIndex = 4;
            maskedTextBox3.TextChanged += maskedTextBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 249);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 274);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Пароль:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 299);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(317, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 368);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(317, 104);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 339);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(233, 20);
            label6.TabIndex = 9;
            label6.Text = "Многострочное текстовое поле:";
            // 
            // textBox3
            // 
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox3.Location = new Point(15, 508);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 27);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 483);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(246, 20);
            label7.TabIndex = 11;
            label7.Text = "Автозаполнение текстового поля:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 546);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Текстовые поля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
    }
}