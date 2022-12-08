using System.Collections.Generic;
using System.IO;
using System.Windows;


namespace shorcutPrograms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void findMissingFiles(object sender, RoutedEventArgs e)
        {
            int folder1Length;
            int folder2Length;
            try //Try to get a count of the files in the folders
            {
                folder1Length =  Directory.GetFiles(FindMissingFilesTextBox1.Text).Length;
                folder2Length = Directory.GetFiles(FindMissingFilesTextBox2.Text).Length;
            }
            catch//If the folder is not accessible then set the length to 0 so it will be caught by the error catcher
            {
                folder1Length = 0;
                folder2Length = 0;
            }


            string[] fileNameList1 = new string[folder1Length];//Create array with length of the files in the folders
            string[] fileNameList2 = new string[folder2Length];

            if (folder1Length == 0 || folder2Length == 0)//Check to see if there is an issue with the folders/filePath
            {
                MessageBox.Show("Something went wrong, please check the file paths","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                List<string> missingFiles = new List<string>();

                fileNameList1 = Directory.GetFiles(FindMissingFilesTextBox1.Text);//Get all the files in the folder, we know this works because of the 
                fileNameList2 = Directory.GetFiles(FindMissingFilesTextBox2.Text);//try catch before, so no error handling is required

                for (int i = 0; i < fileNameList1.Length; i++)//Loop through folder 1
                {
                    bool fileFound = false;
                    for (int j = 0; j < fileNameList2.Length; j++)//Loop through folder 2
                    {
                        if (System.IO.Path.GetFileName(fileNameList1[i]) == System.IO.Path.GetFileName(fileNameList2[j]))//Check if the name of the file is the same, not the whole filepath
                        {
                            //File has been found, set found to true
                            fileFound = true;
                        }
                    }
                    if (fileFound == false)//Check if the file has been found, if not then add to missing list
                    {
                        //File not found, add to the file missing list
                        missingFiles.Add(System.IO.Path.GetFileName(fileNameList1[i]));
                    }
                }

                if (missingFiles.Count <= 0)//There are no missing files as the missing files array is empty
                {
                    if (fileNameList2.Length > fileNameList1.Length - missingFiles.Count)//Check to see if there are stray files
                    {
                        MessageBox.Show("No missing files, however there are stray files");
                    }
                    else
                    {
                        MessageBox.Show("No missing files");
                    }
                }
                else//Missing files
                {
                    string missingFilesText = string.Join("\n", missingFiles);
                    if (fileNameList2.Length > fileNameList1.Length - missingFiles.Count)//Check for stray files
                    {
                        MessageBox.Show($"There are missing files: \n{missingFilesText}\n and there are also stray files");//Print list of missing files and print stray files
                    }
                    else
                    {
                        MessageBox.Show($"Missing files: \n" + missingFilesText);//Show missing files
                    }
                }
            }
        }





    }
}
