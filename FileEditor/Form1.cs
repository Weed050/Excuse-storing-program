namespace FileEditor
{
    public partial class Form1 : Form
    {
        Excuse currentExcuse;
        Random random = new Random();
        private bool formChanged = false;
        private string selectedFolder = "";
        public Form1()
        {
            InitializeComponent();
            currentExcuse = new Excuse();
            saveBtn.Enabled = false;
            openBtn.Enabled = false;
            randomExcuseBtn.Enabled = false;
            currentExcuse.LastUsed = lastUsed.Value;
            formChanged = false;
        }
        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("Bierz¹dza wymówka nie zosta³a zapisana, czy kontynuowaæ?", "Ostrze¿enie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.excuseTextBox.Text = currentExcuse.Description;
                this.lastUsed.Value = currentExcuse.LastUsed;
                this.resultTextBox.Text = currentExcuse.Result;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    dataLabel.Text = "Program do zarz¹dzania wymówkami.";
                }
            }
            else
                this.Text = "Program do zarz¹dzania wymówkami.";
            this.formChanged = changed;


        }
        private void directoryBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                saveBtn.Enabled = true;
                openBtn.Enabled = true;
                randomExcuseBtn.Enabled = true;
                selectedFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(resultTextBox.Text) || string.IsNullOrEmpty(excuseTextBox.Text))
            {
                MessageBox.Show("Musisz podaæ wymówkê i rezultat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Plik tekstowy (*.txt)|*.txt|" +
                "Wszystkie formaty (*.*)|*.*";
            saveFileDialog1.FileName = currentExcuse.Description + ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana.");
            }
        }

        private void excuseTextBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = excuseTextBox.Text;
            UpdateForm(true);
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Result = resultTextBox.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Plik tekstowy (*.txt)|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }

            }
        }

        private void randomExcuseBtn_Click(object sender, EventArgs e)
        {

            if (CheckChanged())
            {
                currentExcuse = new Excuse(random,selectedFolder);
                UpdateForm(false);
            }
        }
    }
}