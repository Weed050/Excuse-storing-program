namespace SavingCards
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
            createNGenerateDeckBtn = new Button();
            getDeckBtn = new Button();
            save3timesBtn = new Button();
            open3DecksBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            converdToHexBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            openFileBtn = new Button();
            saveFileBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // createNGenerateDeckBtn
            // 
            createNGenerateDeckBtn.Location = new Point(483, 196);
            createNGenerateDeckBtn.Name = "createNGenerateDeckBtn";
            createNGenerateDeckBtn.Size = new Size(216, 29);
            createNGenerateDeckBtn.TabIndex = 0;
            createNGenerateDeckBtn.Text = "wygeneruj i zapisz deck";
            createNGenerateDeckBtn.UseVisualStyleBackColor = true;
            createNGenerateDeckBtn.Click += createNGenerateDeckBtn_Click;
            // 
            // getDeckBtn
            // 
            getDeckBtn.Location = new Point(483, 231);
            getDeckBtn.Name = "getDeckBtn";
            getDeckBtn.Size = new Size(216, 29);
            getDeckBtn.TabIndex = 1;
            getDeckBtn.Text = "wczytaj deck";
            getDeckBtn.UseVisualStyleBackColor = true;
            getDeckBtn.Click += getDeckBtn_Click;
            // 
            // save3timesBtn
            // 
            save3timesBtn.Location = new Point(138, 196);
            save3timesBtn.Name = "save3timesBtn";
            save3timesBtn.Size = new Size(330, 29);
            save3timesBtn.TabIndex = 2;
            save3timesBtn.Text = "wygeneruj i zapisz deck 1 krotnie";
            save3timesBtn.UseVisualStyleBackColor = true;
            save3timesBtn.Click += save3timesBtn_Click;
            // 
            // open3DecksBtn
            // 
            open3DecksBtn.Location = new Point(138, 231);
            open3DecksBtn.Name = "open3DecksBtn";
            open3DecksBtn.Size = new Size(330, 29);
            open3DecksBtn.TabIndex = 3;
            open3DecksBtn.Text = "wczytaj decki";
            open3DecksBtn.UseVisualStyleBackColor = true;
            open3DecksBtn.Click += open3DecksBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(466, 32);
            button1.Name = "button1";
            button1.Size = new Size(192, 29);
            button1.TabIndex = 4;
            button1.Text = "utwórz 2 pliki z kartami";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 67);
            button2.Name = "button2";
            button2.Size = new Size(192, 29);
            button2.TabIndex = 5;
            button2.Text = "podmień karty";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // converdToHexBtn
            // 
            converdToHexBtn.Location = new Point(12, 82);
            converdToHexBtn.Name = "converdToHexBtn";
            converdToHexBtn.Size = new Size(238, 29);
            converdToHexBtn.TabIndex = 6;
            converdToHexBtn.Text = "Converd file to hex and save it";
            converdToHexBtn.UseVisualStyleBackColor = true;
            converdToHexBtn.Click += converdToHexBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileBtn
            // 
            openFileBtn.Location = new Point(12, 12);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(238, 29);
            openFileBtn.TabIndex = 7;
            openFileBtn.Text = "Choose file to convert";
            openFileBtn.UseVisualStyleBackColor = true;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // saveFileBtn
            // 
            saveFileBtn.Location = new Point(12, 47);
            saveFileBtn.Name = "saveFileBtn";
            saveFileBtn.Size = new Size(238, 29);
            saveFileBtn.TabIndex = 8;
            saveFileBtn.Text = "Save converted text to file";
            saveFileBtn.UseVisualStyleBackColor = true;
            saveFileBtn.Click += saveFileBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 86);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 9;
            label1.Text = "(default)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(saveFileBtn);
            Controls.Add(openFileBtn);
            Controls.Add(converdToHexBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(open3DecksBtn);
            Controls.Add(save3timesBtn);
            Controls.Add(getDeckBtn);
            Controls.Add(createNGenerateDeckBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createNGenerateDeckBtn;
        private Button getDeckBtn;
        private Button save3timesBtn;
        private Button open3DecksBtn;
        private Button button1;
        private Button button2;
        private Button converdToHexBtn;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button openFileBtn;
        private Button saveFileBtn;
        private Label label1;
    }
}