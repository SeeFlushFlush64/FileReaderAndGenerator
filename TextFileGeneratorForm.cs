using System.ComponentModel.Design;

namespace GenerateTextFile
{
    public partial class TextFileGeneratorForm : Form
    {
        private string filePath;
        public TextFileGeneratorForm()
        {
            InitializeComponent();
            ShowInstructions();
        }
        private void ShowInstructions()
        { 
            //rTxtBoxInstruction.Text = "Enter text in the textbox and click 'Generate' button to generate the text file.";
            rTxtBoxInstruction.ReadOnly = true;
            rTxtBoxInstruction.SelectAll();
            //rTxtBoxInstruction.SelectionAlignment = HorizontalAlignment.Center;
            rTxtBoxInstruction.Enabled = false;
        }
        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            string[] inputArray = txtBoxUserInput.Text.Split(' ');
            string fileName = string.Join('-', inputArray.Take(3));
            if (btnGenerateFile.Text == "Generate")
            {
                filePath = @$"C:\Users\micha\source\repos\GenerateTextFile\GenerateTextFile\FileStorage\{fileName}.txt";
            }
            if (!File.Exists(filePath))
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.Write(txtBoxUserInput.Text);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult result;
                if (btnGenerateFile.Text == "Save")
                {
                    btnGenerateFile.Text = "Generate";
                    result = MessageBox.Show("Are you sure you want to overwrite the contents of the existing file?", "Warning", MessageBoxButtons.YesNo);
                }
                else
                { 
                    result = MessageBox.Show("File already exist, replace the previous file?", "Warning", MessageBoxButtons.YesNo);
                    
                }
                if (result == DialogResult.Yes)
                {
                    using (StreamWriter streamWriter = new StreamWriter(filePath))
                    {
                        streamWriter.Write(txtBoxUserInput.Text);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            txtBoxUserInput.Text = string.Empty;
        }
        private void picBoxUploadFile_MouseEnter(object sender, EventArgs e)
        {
            picBoxUploadFile.Cursor = Cursors.Hand;
        }
        private void picBoxUploadFile_MouseLeave(object sender, EventArgs e)
        {
            picBoxUploadFile.Cursor = Cursors.Arrow;
        }
        private void picBoxUploadFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
        

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        txtBoxUserInput.Text = fileContent;
                        btnGenerateFile.Text = "Save";
                    }

                }
            }
        }

        private void btnClearUserInput_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the textbox?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtBoxUserInput.Text = string.Empty;
            }
        }


    }
}
