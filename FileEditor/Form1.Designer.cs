namespace FileEditor
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            randomExcuseBtn = new Button();
            openBtn = new Button();
            saveBtn = new Button();
            directoryBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            excuseTextBox = new TextBox();
            resultTextBox = new TextBox();
            dataLabel = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lastUsed = new DateTimePicker();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // randomExcuseBtn
            // 
            randomExcuseBtn.Location = new Point(319, 156);
            randomExcuseBtn.Name = "randomExcuseBtn";
            randomExcuseBtn.Size = new Size(161, 29);
            randomExcuseBtn.TabIndex = 0;
            randomExcuseBtn.Text = "Losowa wymówka";
            randomExcuseBtn.UseVisualStyleBackColor = true;
            randomExcuseBtn.Click += randomExcuseBtn_Click;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(219, 156);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(94, 29);
            openBtn.TabIndex = 1;
            openBtn.Text = "Otwórz";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(119, 156);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Zapisz";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // directoryBtn
            // 
            directoryBtn.Location = new Point(19, 156);
            directoryBtn.Name = "directoryBtn";
            directoryBtn.Size = new Size(94, 29);
            directoryBtn.TabIndex = 3;
            directoryBtn.Text = "Folder";
            directoryBtn.UseVisualStyleBackColor = true;
            directoryBtn.Click += directoryBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "Wymówka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Wyniki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 6;
            label3.Text = "Ostatnio użyte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 123);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Data pliku";
            // 
            // excuseTextBox
            // 
            excuseTextBox.Location = new Point(119, 6);
            excuseTextBox.Name = "excuseTextBox";
            excuseTextBox.Size = new Size(379, 27);
            excuseTextBox.TabIndex = 8;
            excuseTextBox.TextChanged += excuseTextBox_TextChanged;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(119, 45);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(379, 27);
            resultTextBox.TabIndex = 9;
            resultTextBox.TextChanged += resultTextBox_TextChanged;
            // 
            // dataLabel
            // 
            dataLabel.BorderStyle = BorderStyle.Fixed3D;
            dataLabel.Location = new Point(119, 123);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(379, 25);
            dataLabel.TabIndex = 10;
            // 
            // lastUsed
            // 
            lastUsed.Location = new Point(133, 88);
            lastUsed.Name = "lastUsed";
            lastUsed.Size = new Size(365, 27);
            lastUsed.TabIndex = 11;
            lastUsed.ValueChanged += lastUsed_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 198);
            Controls.Add(lastUsed);
            Controls.Add(dataLabel);
            Controls.Add(resultTextBox);
            Controls.Add(excuseTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(directoryBtn);
            Controls.Add(saveBtn);
            Controls.Add(openBtn);
            Controls.Add(randomExcuseBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button randomExcuseBtn;
        private Button openBtn;
        private Button saveBtn;
        private Button directoryBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox excuseTextBox;
        private TextBox resultTextBox;
        private Label dataLabel;
        private FolderBrowserDialog folderBrowserDialog1;
        private DateTimePicker lastUsed;
    }
}