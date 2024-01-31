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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            sumBtn = new Button();
            btnSubstract = new Button();
            btnMultiple = new Button();
            btnDivision = new Button();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(167, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.CausesValidation = false;
            textBox2.Location = new Point(333, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // sumBtn
            // 
            sumBtn.BackColor = SystemColors.Highlight;
            sumBtn.ForeColor = SystemColors.ButtonHighlight;
            sumBtn.Location = new Point(169, 96);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(45, 23);
            sumBtn.TabIndex = 1;
            sumBtn.Text = "+";
            sumBtn.UseMnemonic = false;
            sumBtn.UseVisualStyleBackColor = false;
            sumBtn.Click += sumBtn_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.BackColor = SystemColors.Highlight;
            btnSubstract.ForeColor = SystemColors.ButtonHighlight;
            btnSubstract.Location = new Point(230, 96);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(37, 23);
            btnSubstract.TabIndex = 1;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = false;
            btnSubstract.Click += btnSubstract_Click;
            // 
            // btnMultiple
            // 
            btnMultiple.BackColor = SystemColors.Highlight;
            btnMultiple.ForeColor = SystemColors.ButtonHighlight;
            btnMultiple.Location = new Point(341, 96);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(38, 23);
            btnMultiple.TabIndex = 1;
            btnMultiple.Text = "*";
            btnMultiple.UseVisualStyleBackColor = false;
            btnMultiple.Click += btnMultiple_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = SystemColors.Highlight;
            btnDivision.ForeColor = SystemColors.ButtonHighlight;
            btnDivision.Location = new Point(393, 96);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(40, 23);
            btnDivision.TabIndex = 1;
            btnDivision.Text = "%";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(171, 169);
            resultBox.Name = "resultBox";
            resultBox.PlaceholderText = "Check your result";
            resultBox.Size = new Size(100, 23);
            resultBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultBox);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiple);
            Controls.Add(btnSubstract);
            Controls.Add(sumBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button sumBtn;
        private Button btnSubstract;
        private Button btnMultiple;
        private Button btnDivision;
        private TextBox resultBox;
    }
}
