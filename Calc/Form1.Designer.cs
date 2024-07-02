namespace Calc
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
            button9 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button0 = new Button();
            button8 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            plus = new Button();
            minus = new Button();
            devide = new Button();
            multiply = new Button();
            result = new Button();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(328, 324);
            button9.Name = "button9";
            button9.Size = new Size(74, 51);
            button9.TabIndex = 0;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += MyClick;
            // 
            // button1
            // 
            button1.Location = new Point(95, 161);
            button1.Name = "button1";
            button1.Size = new Size(74, 51);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += MyClick;
            // 
            // button2
            // 
            button2.Location = new Point(215, 161);
            button2.Name = "button2";
            button2.Size = new Size(74, 51);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += MyClick;
            // 
            // button3
            // 
            button3.Location = new Point(328, 161);
            button3.Name = "button3";
            button3.Size = new Size(74, 51);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += MyClick;
            // 
            // button4
            // 
            button4.Location = new Point(95, 248);
            button4.Name = "button4";
            button4.Size = new Size(74, 51);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += MyClick;
            // 
            // button5
            // 
            button5.Location = new Point(215, 248);
            button5.Name = "button5";
            button5.Size = new Size(74, 51);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += MyClick;
            // 
            // button6
            // 
            button6.Location = new Point(328, 248);
            button6.Name = "button6";
            button6.Size = new Size(74, 51);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += MyClick;
            // 
            // button7
            // 
            button7.Location = new Point(95, 324);
            button7.Name = "button7";
            button7.Size = new Size(74, 51);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += MyClick;
            // 
            // button0
            // 
            button0.Location = new Point(95, 387);
            button0.Name = "button0";
            button0.Size = new Size(318, 51);
            button0.TabIndex = 8;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += MyClick;
            // 
            // button8
            // 
            button8.Location = new Point(215, 324);
            button8.Name = "button8";
            button8.Size = new Size(74, 51);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += MyClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBox1.Location = new Point(189, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 11;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(387, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 12;
            textBox2.Click += textBox2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(623, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 13;
            // 
            // plus
            // 
            plus.Location = new Point(463, 191);
            plus.Name = "plus";
            plus.Size = new Size(74, 51);
            plus.TabIndex = 14;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += Operator;
            // 
            // minus
            // 
            minus.Location = new Point(463, 248);
            minus.Name = "minus";
            minus.Size = new Size(74, 51);
            minus.TabIndex = 14;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += Operator;
            // 
            // devide
            // 
            devide.Location = new Point(463, 305);
            devide.Name = "devide";
            devide.Size = new Size(74, 51);
            devide.TabIndex = 14;
            devide.Text = "/";
            devide.UseVisualStyleBackColor = true;
            devide.Click += Operator;
            // 
            // multiply
            // 
            multiply.Location = new Point(463, 362);
            multiply.Name = "multiply";
            multiply.Size = new Size(74, 51);
            multiply.TabIndex = 14;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += Operator;
            // 
            // result
            // 
            result.Location = new Point(543, 64);
            result.Name = "result";
            result.Size = new Size(74, 51);
            result.TabIndex = 15;
            result.Text = "=";
            result.UseVisualStyleBackColor = true;
            result.Click += result_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(multiply);
            Controls.Add(devide);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button8);
            Controls.Add(button0);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button9);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button0;
        private Button button8;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button plus;
        private Button minus;
        private Button devide;
        private Button multiply;
        private Button result;
    }
}
