namespace Translator2
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
            this.Rus_list = new System.Windows.Forms.ListBox();
            this.Eng_list = new System.Windows.Forms.ListBox();
            this.Rus_text = new System.Windows.Forms.TextBox();
            this.Eng_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lable3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rus_list
            // 
            this.Rus_list.FormattingEnabled = true;
            this.Rus_list.ItemHeight = 20;
            this.Rus_list.Location = new System.Drawing.Point(571, 161);
            this.Rus_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rus_list.Name = "Rus_list";
            this.Rus_list.Size = new System.Drawing.Size(137, 124);
            this.Rus_list.TabIndex = 0;
            this.Rus_list.SelectedIndexChanged += new System.EventHandler(this.Rus_list_SelectedIndexChanged);
            // 
            // Eng_list
            // 
            this.Eng_list.FormattingEnabled = true;
            this.Eng_list.ItemHeight = 20;
            this.Eng_list.Location = new System.Drawing.Point(741, 160);
            this.Eng_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eng_list.Name = "Eng_list";
            this.Eng_list.Size = new System.Drawing.Size(137, 124);
            this.Eng_list.TabIndex = 1;
            this.Eng_list.SelectedIndexChanged += new System.EventHandler(this.Eng_list_SelectedIndexChanged);
            // 
            // Rus_text
            // 
            this.Rus_text.Location = new System.Drawing.Point(571, 107);
            this.Rus_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rus_text.Name = "Rus_text";
            this.Rus_text.Size = new System.Drawing.Size(137, 27);
            this.Rus_text.TabIndex = 2;
            this.Rus_text.TextChanged += new System.EventHandler(this.Rus_text_TextChanged);
            // 
            // Eng_text
            // 
            this.Eng_text.Location = new System.Drawing.Point(741, 106);
            this.Eng_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eng_text.Name = "Eng_text";
            this.Eng_text.Size = new System.Drawing.Size(137, 27);
            this.Eng_text.TabIndex = 3;
            this.Eng_text.TextChanged += new System.EventHandler(this.Eng_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Русский";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Английский";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 616);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 27);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(61, 74);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(113, 20);
            this.lable3.TabIndex = 10;
            this.lable3.Text = "Введите слово:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Перевод:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 616);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eng_text);
            this.Controls.Add(this.Rus_text);
            this.Controls.Add(this.Eng_list);
            this.Controls.Add(this.Rus_list);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Rus_list;
        private ListBox Eng_list;
        private TextBox Rus_text;
        private TextBox Eng_text;
        private Label label1;
        private Label label2;
        private Button button1;
        private Splitter splitter1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lable3;
        private Label label3;
        private Button button2;
    }
}