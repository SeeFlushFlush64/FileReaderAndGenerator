using GenerateTextFile.Services;
using System.ComponentModel.Design;

namespace GenerateTextFile
{
    public partial class TextFileGeneratorForm : Form
    {
        private string filePath;
        private FileService fileService;

        public TextFileGeneratorForm()
        {
            InitializeComponent();
            fileService = new FileService();  // Inject FileService
            ShowInstructions();
        }

        private void ShowInstructions()
        {
            rTxtBoxInstruction.ReadOnly = true;
            rTxtBoxInstruction.Text = "Enter text in the textbox and click 'Generate' to create or overwrite a file.";
            rTxtBoxInstruction.Enabled = false;
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            string content = txtBoxUserInput.Text;

            // Check if a file has been uploaded (filePath is not null or empty)
            if (!string.IsNullOrEmpty(filePath))
            {
                // If a file is uploaded, show a confirmation dialog before overwriting
                DialogResult result = MessageBox.Show("Are you sure you want to overwrite the existing file?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // If user chooses 'Yes', overwrite the file
                    if (fileService.SaveFile(filePath, content))
                    {
                        btnGenerateFile.Text = "Generate"; // Change the button text to "Save"
                        MessageBox.Show("File overwritten successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // If no file is uploaded, generate a new file
                string[] inputArray = content.Split(' ');
                string fileName = string.Join('-', inputArray.Take(3));
                filePath = @$"C:\Users\micha\source\repos\GenerateTextFile\GenerateTextFile\FileStorage\{fileName}.txt";

                if (fileService.SaveFile(filePath, content))
                {
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Clear the text box after the operation
            txtBoxUserInput.Text = string.Empty;
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
                    // Get the path of the selected file
                    filePath = openFileDialog.FileName;

                    // Read the contents of the file and load it into the textbox
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        txtBoxUserInput.Text = fileContent;

                        // Change the button text to "Save", indicating an existing file
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

        private void picBoxUploadFile_MouseEnter(object sender, EventArgs e)
        {
            picBoxUploadFile.Cursor = Cursors.Hand; // Example: Change background color on hover
        }

        private void picBoxUploadFile_MouseLeave(object sender, EventArgs e)
        {
            picBoxUploadFile.Cursor = Cursors.Arrow; // Restore original background color
        }

    }


}
