namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clearEverything = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lCurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seven.Location = new System.Drawing.Point(15, 190);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(62, 58);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.number_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eight.Location = new System.Drawing.Point(85, 190);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(62, 58);
            this.eight.TabIndex = 0;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.number_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nine.Location = new System.Drawing.Point(153, 190);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(62, 58);
            this.nine.TabIndex = 0;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.number_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(221, 190);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(62, 58);
            this.divide.TabIndex = 0;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.op_click);
            // 
            // clearEverything
            // 
            this.clearEverything.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearEverything.Location = new System.Drawing.Point(289, 190);
            this.clearEverything.Name = "clearEverything";
            this.clearEverything.Size = new System.Drawing.Size(62, 58);
            this.clearEverything.TabIndex = 0;
            this.clearEverything.Text = "CE";
            this.clearEverything.UseVisualStyleBackColor = true;
            this.clearEverything.Click += new System.EventHandler(this.clearEverything_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four.Location = new System.Drawing.Point(15, 251);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(62, 58);
            this.four.TabIndex = 0;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.number_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.five.Location = new System.Drawing.Point(85, 251);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(62, 58);
            this.five.TabIndex = 0;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.number_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.six.Location = new System.Drawing.Point(153, 251);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(62, 58);
            this.six.TabIndex = 0;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.number_Click);
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multi.Location = new System.Drawing.Point(221, 251);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(62, 58);
            this.multi.TabIndex = 0;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.op_click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(289, 251);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(62, 58);
            this.clear.TabIndex = 0;
            this.clear.Text = "c";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.one.Location = new System.Drawing.Point(15, 313);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(62, 58);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.number_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two.Location = new System.Drawing.Point(85, 313);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(62, 58);
            this.two.TabIndex = 0;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.number_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three.Location = new System.Drawing.Point(153, 313);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(62, 58);
            this.three.TabIndex = 0;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.number_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(221, 313);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(62, 58);
            this.minus.TabIndex = 0;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.op_click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(15, 373);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(132, 58);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.number_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(153, 373);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(62, 58);
            this.dot.TabIndex = 0;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.number_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(221, 373);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(62, 58);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.op_click);
            // 
            // equle
            // 
            this.equle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equle.Location = new System.Drawing.Point(289, 313);
            this.equle.Name = "equle";
            this.equle.Size = new System.Drawing.Size(62, 118);
            this.equle.TabIndex = 0;
            this.equle.Text = "=";
            this.equle.UseVisualStyleBackColor = true;
            this.equle.Click += new System.EventHandler(this.equle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(7, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 45);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lCurrentOp
            // 
            this.lCurrentOp.AutoSize = true;
            this.lCurrentOp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lCurrentOp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lCurrentOp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lCurrentOp.Location = new System.Drawing.Point(15, 37);
            this.lCurrentOp.Name = "lCurrentOp";
            this.lCurrentOp.Size = new System.Drawing.Size(0, 38);
            this.lCurrentOp.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 481);
            this.Controls.Add(this.lCurrentOp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.equle);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearEverything);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.six);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.two);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.five);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button seven;
        private Button eight;
        private Button nine;
        private Button divide;
        private Button clearEverything;
        private Button four;
        private Button five;
        private Button six;
        private Button multi;
        private Button clear;
        private Button one;
        private Button two;
        private Button three;
        private Button minus;
        private Button zero;
        private Button dot;
        private Button plus;
        private Button equle;
        private TextBox textBox1;
        private Label lCurrentOp;
    }
}