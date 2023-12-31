using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramFollowersApp.Utilities
{
    public static class FileOperation
    {
        public async static Task<string> getFileData(string path)
        {
            var content = string.Empty;
            try
            {
                using (var sr = new StreamReader(path))
                {
                    content = await sr.ReadToEndAsync();
                }
                string filename = File.ReadAllText(path);
            }catch(IOException e)
            {
                content = e.Message;
            }

            return content;
        }
        public static string getFilePath()
        {
            var selectedFilePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C://Desktop";
                //Box dialog title
                openFileDialog.Title = "Select file to upload";
                //Filter
                openFileDialog.Filter = "Seleccione un documento válido |*.json";
                // Show the file dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    selectedFilePath = openFileDialog.FileName;

                }
            }

            return selectedFilePath;
        }
        public static string readFileContent(string path)
        {
            var content = string.Empty;

            try
            {
                content = File.ReadAllText(path);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            return content;

        }
    }
}
