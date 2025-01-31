namespace GenerateTextFile
{
    partial class TextFileGeneratorForm
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
            btnGenerateFile = new Button();
            txtBoxUserInput = new TextBox();
            lblFormTitle = new Label();
            rTxtBoxInstruction = new RichTextBox();
            picBoxUploadFile = new PictureBox();
            btnClearUserInput = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUploadFile).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateFile
            // 
            btnGenerateFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateFile.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerateFile.Location = new Point(293, 441);
            btnGenerateFile.Name = "btnGenerateFile";
            btnGenerateFile.Size = new Size(100, 40);
            btnGenerateFile.TabIndex = 0;
            btnGenerateFile.Text = "Generate";
            btnGenerateFile.UseVisualStyleBackColor = true;
            btnGenerateFile.Click += btnGenerateFile_Click;
            // 
            // txtBoxUserInput
            // 
            txtBoxUserInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUserInput.Location = new Point(12, 148);
            txtBoxUserInput.Multiline = true;
            txtBoxUserInput.Name = "txtBoxUserInput";
            txtBoxUserInput.Size = new Size(460, 276);
            txtBoxUserInput.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.Location = new Point(12, 27);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(229, 32);
            lblFormTitle.TabIndex = 2;
            lblFormTitle.Text = "Text File Generator";
            // 
            // rTxtBoxInstruction
            // 
            rTxtBoxInstruction.BackColor = SystemColors.Control;
            rTxtBoxInstruction.BorderStyle = BorderStyle.None;
            rTxtBoxInstruction.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rTxtBoxInstruction.Location = new Point(12, 87);
            rTxtBoxInstruction.Name = "rTxtBoxInstruction";
            rTxtBoxInstruction.Size = new Size(460, 43);
            rTxtBoxInstruction.TabIndex = 3;
            rTxtBoxInstruction.Text = "Instruction: Enter text in the textbox and click 'Generate' button to generate a text file. Click the arrow to upload a file.";
            // 
            // picBoxUploadFile
            // 
            picBoxUploadFile.Image = Properties.Resources.upload_icon;
            picBoxUploadFile.Location = new Point(432, 27);
            picBoxUploadFile.Name = "picBoxUploadFile";
            picBoxUploadFile.Size = new Size(40, 40);
            picBoxUploadFile.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUploadFile.TabIndex = 4;
            picBoxUploadFile.TabStop = false;
            picBoxUploadFile.Click += picBoxUploadFile_Click;
            picBoxUploadFile.MouseEnter += picBoxUploadFile_MouseEnter;
            picBoxUploadFile.MouseLeave += picBoxUploadFile_MouseLeave;
            // 
            // btnClearUserInput
            // 
            btnClearUserInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearUserInput.ForeColor = SystemColors.ActiveCaptionText;
            btnClearUserInput.Location = new Point(100, 441);
            btnClearUserInput.Name = "btnClearUserInput";
            btnClearUserInput.Size = new Size(100, 40);
            btnClearUserInput.TabIndex = 5;
            btnClearUserInput.Text = "Clear";
            btnClearUserInput.UseVisualStyleBackColor = true;
            btnClearUserInput.Click += this.btnClearUserInput_Click;
            // 
            // TextFileGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 511);
            Controls.Add(btnClearUserInput);
            Controls.Add(picBoxUploadFile);
            Controls.Add(rTxtBoxInstruction);
            Controls.Add(lblFormTitle);
            Controls.Add(txtBoxUserInput);
            Controls.Add(btnGenerateFile);
            Name = "TextFileGeneratorForm";
            Text = "Text File Generator";
            ((System.ComponentModel.ISupportInitialize)picBoxUploadFile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateFile;
        private TextBox txtBoxUserInput;
        private Label lblFormTitle;
        private RichTextBox rTxtBoxInstruction;
        private PictureBox picBoxUploadFile;
        private Button btnClearUserInput;
    }
}
