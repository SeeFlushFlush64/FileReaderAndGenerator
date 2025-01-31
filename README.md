FileReaderAndGenerator

Overview

FileReaderAndGenerator is a Windows Forms application that allows users to create and edit text files. Users can input text, save it as a file, and upload an existing file to modify its content. The application ensures efficient file handling with overwrite warnings and user-friendly UI elements.

Features

Text File Generation: Users can input text and generate a .txt file.

File Upload & Editing: Users can upload an existing text file and modify its content.

Overwrite Confirmation: Provides a warning before overwriting an existing file.

Clear Input: Option to clear the text input field.

Instructions Display: Read-only RichTextBox to guide users.

Technologies Used

C# (Windows Forms)

.NET 9.0

StreamWriter & StreamReader for file operations

NUnit for unit testing

How to Use

Generate a New File:

Enter text in the input box.

Click the "Generate" button to save the file.

Upload and Edit a File:

Click the upload icon to select a text file.

Modify the content.

Click "Save" to overwrite the file (confirmation required).

Clear Text Input:

Click the "Clear" button to reset the input field.

Screenshots

(Screenshots should be added below this section)




Installation

Clone the repository:

git clone https://github.com/yourusername/FileReaderAndGenerator.git

Open the solution in Visual Studio.

Build and run the project.

Testing

Run unit tests using NUnit:

dotnet test

License

MIT License. See LICENSE file for details.
