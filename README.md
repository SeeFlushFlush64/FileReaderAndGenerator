# 📂 FileReaderAndGenerator

A Windows Forms application that allows users to generate and save text files, as well as upload existing files for modification.

## 🛠 Features
- **Generate Text Files**: Create and save text files with user input.
- **Upload and Edit**: Open an existing text file and modify its contents.
- **Overwrite Confirmation**: Warns users before overwriting an existing file.
- **Intuitive UI**: Simple and user-friendly Windows Forms interface.

## 📸 Screenshots
### Main Interface  
![generatetextfile_main_interface](https://github.com/user-attachments/assets/dd99312b-c95e-40c4-812f-b9334d8416a3)


### Upload File  
![generatetextfile_upload_file](https://github.com/user-attachments/assets/23ece0f9-b950-4682-829c-c9252d77cecf)


### Overwrite Confirmation  
![generatetextfile_confirm_overwrite](https://github.com/user-attachments/assets/cf502313-2c96-458a-9996-0f5af4f1211a)


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
