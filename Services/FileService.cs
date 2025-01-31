using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateTextFile.Services
{
    public class FileService
    {
        public bool SaveFile(string filePath, string content)
        {
            try
            {
                // Try to ensure that the directory exists
                var directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    throw new DirectoryNotFoundException($"The directory '{directory}' does not exist.");
                }

                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.Write(content);
                }
                return true;
            }
            catch (Exception)
            {
                // Catch all exceptions
                return false;
            }
        }
    }


}
