# 📂 FileReaderAndGenerator

A Windows Forms application that allows users to generate and save text files, as well as upload existing files for modification.

## 🛠 Features
- **Generate Text Files**: Create and save text files with user input.
- **Upload and Edit**: Open an existing text file and modify its contents.
- **Overwrite Confirmation**: Warns users before overwriting an existing file.
- **Intuitive UI**: Simple and user-friendly Windows Forms interface.

## 📸 Screenshots
### Main Interface  
<p align="center">
  <img src="https://github.com/user-attachments/assets/dd99312b-c95e-40c4-812f-b9334d8416a3" alt="Main Interface">
</p>

### Upload File  
<p align="center">
  <img src="https://github.com/user-attachments/assets/23ece0f9-b950-4682-829c-c9252d77cecf" alt="Upload File">
</p>

### Overwrite Confirmation  
<p align="center">
  <img src="https://github.com/user-attachments/assets/cf502313-2c96-458a-9996-0f5af4f1211a" alt="Overwrite Confirmation">
</p>



## 🚀 How to Use
1. **Enter text** into the textbox.
2. Click **"Generate"** to save it as a text file.
3. Click the **upload icon** to open an existing file.
4. Modify the text and click **"Save"** to overwrite.
5. A confirmation message will appear before overwriting.

## 🏗 Technologies Used
- **C# .NET (Windows Forms)**
- **StreamWriter & StreamReader** for file handling
- **NUnit** for unit testing

## 📝 Installation & Setup
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/FileReaderAndGenerator.git
2. Open the project in **Visual Studio**.
3. Restore NuGet packages if required.
4. Build and run the application.

## ✅ Running Unit Tests
This project includes **unit tests** using NUnit. To run the tests, use the following command:
  ```sh
  dotnet test

## 🧪 Unit Tests

This project includes unit tests for the `FileService` class. The following methods and their purposes are tested:

### `SaveFile_ShouldReturnTrue_WhenFileIsSavedSuccessfully`

- **Purpose**: This test ensures that the `SaveFile` method correctly saves a text file to the specified path when provided with valid input.
- **Test Description**: It attempts to save a text file with the content `"Hello, world!"` to a valid file path and verifies that the file is created and the content matches the input.

### `SaveFile_ShouldReturnFalse_WhenExceptionOccurs`

- **Purpose**: This test checks that the `SaveFile` method returns `false` when an exception occurs due to an invalid file path.
- **Test Description**: It tries to save a file to an invalid path (`C:\InvalidPath\`) and asserts that the result is `false`.

### `SaveFile_ShouldReturnFalse_WhenFolderIsRestricted`

- **Purpose**: This test verifies that the `SaveFile` method returns `false` when attempting to write to a folder with restricted access (e.g., needing administrator rights).
- **Test Description**: It attempts to save a file to a restricted folder (`C:\Temp\`) and confirms that the result is `false`.

### Cleanup

After each test, the test cleans up by deleting the created file (if it exists) to ensure that the tests do not affect one another and that the file system remains clean.

```csharp
[TearDown]
public void Cleanup()
{
    // Delete the file after each test
    string filePath = @"C:\Users\micha\OneDrive\Desktop\GenerateTextFileTestDump\testFile.txt";
    if (File.Exists(filePath))
    {
        File.Delete(filePath);
    }
}
