namespace ButtonControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            start = new Button();
            picture = new Button();
            stop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(14, 107);
            start.Margin = new Padding(5, 4, 5, 4);
            start.Name = "start";
            start.Size = new Size(101, 36);
            start.TabIndex = 0;
            start.Text = "Старт";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // picture
            // 
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.Location = new Point(113, 13);
            picture.Margin = new Padding(5, 4, 5, 4);
            picture.Name = "picture";
            picture.Size = new Size(82, 86);
            picture.TabIndex = 2;
            picture.TabStop = false;
            picture.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            stop.Location = new Point(191, 107);
            stop.Margin = new Padding(5, 4, 5, 4);
            stop.Name = "stop";
            stop.Size = new Size(101, 36);
            stop.TabIndex = 3;
            stop.Text = "Стоп";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 145);
            Controls.Add(stop);
            Controls.Add(picture);
            Controls.Add(start);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Слайд-шоу";
            ResumeLayout(false);
        }

        #endregion

        private Button start;
        private Button picture;
        private Button stop;
        private System.Windows.Forms.Timer timer1;
    }
}