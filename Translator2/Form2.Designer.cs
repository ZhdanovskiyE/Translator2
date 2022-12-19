namespace Translator2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eng_text = new System.Windows.Forms.TextBox();
            this.Rus_text = new System.Windows.Forms.TextBox();
            this.Eng_list = new System.Windows.Forms.ListBox();
            this.Rus_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Английский";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Русский";
            // 
            // Eng_text
            // 
            this.Eng_text.Location = new System.Drawing.Point(224, 76);
            this.Eng_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eng_text.Name = "Eng_text";
            this.Eng_text.Size = new System.Drawing.Size(137, 27);
            this.Eng_text.TabIndex = 10;
            // 
            // Rus_text
            // 
            this.Rus_text.Location = new System.Drawing.Point(54, 77);
            this.Rus_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rus_text.Name = "Rus_text";
            this.Rus_text.Size = new System.Drawing.Size(137, 27);
            this.Rus_text.TabIndex = 9;
            // 
            // Eng_list
            // 
            this.Eng_list.FormattingEnabled = true;
            this.Eng_list.ItemHeight = 20;
            this.Eng_list.Location = new System.Drawing.Point(224, 130);
            this.Eng_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eng_list.Name = "Eng_list";
            this.Eng_list.Size = new System.Drawing.Size(137, 124);
            this.Eng_list.TabIndex = 8;
            // 
            // Rus_list
            // 
            this.Rus_list.FormattingEnabled = true;
            this.Rus_list.ItemHeight = 20;
            this.Rus_list.Location = new System.Drawing.Point(54, 131);
            this.Rus_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rus_list.Name = "Rus_list";
            this.Rus_list.Size = new System.Drawing.Size(137, 124);
            this.Rus_list.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eng_text);
            this.Controls.Add(this.Rus_text);
            this.Controls.Add(this.Eng_list);
            this.Controls.Add(this.Rus_list);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox Eng_text;
        private TextBox Rus_text;
        private ListBox Eng_list;
        private ListBox Rus_list;
    }
}