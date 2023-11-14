namespace GrDik
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
            button1 = new Button();
            richTextBoxResult = new RichTextBox();
            textBoxFileContent = new RichTextBox();
            buttonCreateFile = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(161, 538);
            button1.Name = "button1";
            button1.Size = new Size(381, 110);
            button1.TabIndex = 0;
            button1.Text = "Выбрать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnButtonSelectClick;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.ForeColor = Color.Black;
            richTextBoxResult.Location = new Point(82, 242);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(576, 246);
            richTextBoxResult.TabIndex = 1;
            richTextBoxResult.Text = "";
            // 
            // textBoxFileContent
            // 
            textBoxFileContent.ForeColor = Color.Black;
            textBoxFileContent.Location = new Point(781, 242);
            textBoxFileContent.Name = "textBoxFileContent";
            textBoxFileContent.Size = new Size(576, 246);
            textBoxFileContent.TabIndex = 2;
            textBoxFileContent.Text = "";
            // 
            // buttonCreateFile
            // 
            buttonCreateFile.Location = new Point(880, 538);
            buttonCreateFile.Name = "buttonCreateFile";
            buttonCreateFile.Size = new Size(381, 110);
            buttonCreateFile.TabIndex = 3;
            buttonCreateFile.Text = "Создать Файл";
            buttonCreateFile.UseVisualStyleBackColor = true;
            buttonCreateFile.Click += buttonCreateFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(781, 207);
            label1.Name = "label1";
            label1.Size = new Size(382, 32);
            label1.TabIndex = 4;
            label1.Text = "Введите данные и создайте файл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 207);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 5;
            label2.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 913);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCreateFile);
            Controls.Add(textBoxFileContent);
            Controls.Add(richTextBoxResult);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Подсчет частоты вхождения байтов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBoxResult;
        private RichTextBox textBoxFileContent;
        private Button buttonCreateFile;
        private Label label1;
        private Label label2;
    }
}