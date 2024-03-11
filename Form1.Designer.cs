namespace Square_Calculator
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
            btn_Calculate = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_LowerLimit = new TextBox();
            txt_UpperLimit = new TextBox();
            listBox1 = new ListBox();
            label3 = new Label();
            txt_CountBy = new TextBox();
            SuspendLayout();
            // 
            // btn_Calculate
            // 
            btn_Calculate.Location = new Point(12, 12);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(132, 56);
            btn_Calculate.TabIndex = 0;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = true;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Lower Limit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 48);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Upper Limit:";
            // 
            // txt_LowerLimit
            // 
            txt_LowerLimit.Location = new Point(273, 9);
            txt_LowerLimit.Name = "txt_LowerLimit";
            txt_LowerLimit.Size = new Size(125, 27);
            txt_LowerLimit.TabIndex = 3;
            txt_LowerLimit.Text = "3";
            // 
            // txt_UpperLimit
            // 
            txt_UpperLimit.Location = new Point(273, 48);
            txt_UpperLimit.Name = "txt_UpperLimit";
            txt_UpperLimit.Size = new Size(125, 27);
            txt_UpperLimit.TabIndex = 4;
            txt_UpperLimit.Text = "12";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(386, 464);
            listBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 12);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Count by:";
            // 
            // txt_CountBy
            // 
            txt_CountBy.Location = new Point(491, 9);
            txt_CountBy.Name = "txt_CountBy";
            txt_CountBy.Size = new Size(125, 27);
            txt_CountBy.TabIndex = 7;
            txt_CountBy.Text = "3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 569);
            Controls.Add(txt_CountBy);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(txt_UpperLimit);
            Controls.Add(txt_LowerLimit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Calculate);
            Name = "Form1";
            Text = "Squares Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calculate;
        private Label label1;
        private Label label2;
        private TextBox txt_LowerLimit;
        private TextBox txt_UpperLimit;
        private ListBox listBox1;
        private Label label3;
        private TextBox txt_CountBy;
    }
}
