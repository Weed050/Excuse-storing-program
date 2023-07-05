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
            save3timesBtn.Text = "wygeneruj i zapisz deck 3 krotnie";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(open3DecksBtn);
            Controls.Add(save3timesBtn);
            Controls.Add(getDeckBtn);
            Controls.Add(createNGenerateDeckBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button createNGenerateDeckBtn;
        private Button getDeckBtn;
        private Button save3timesBtn;
        private Button open3DecksBtn;
    }
}