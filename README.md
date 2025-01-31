# 📂 FileReaderAndGenerator

A Windows Forms application that allows users to generate and save text files, as well as upload existing files for modification.

## 🛠 Features
- **Generate Text Files**: Create and save text files with user input.
- **Upload and Edit**: Open an existing text file and modify its contents.
- **Overwrite Confirmation**: Warns users before overwriting an existing file.
- **Intuitive UI**: Simple and user-friendly Windows Forms interface.

## 📸 Screenshots
### Main Interface  
![Main Interface](screenshots/main_interface.png)

### Upload File  
![Upload File](screenshots/upload_file.png)

### Overwrite Confirmation  
![Overwrite Confirmation](screenshots/overwrite_confirmation.png)

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
