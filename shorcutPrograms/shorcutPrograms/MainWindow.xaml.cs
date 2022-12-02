using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void findMissingFiles(object sender, MouseButtonEventArgs e)
        {
            /*MessageBox.Show("test");
            if (FindMissingFilesTextBox1.Text == "filePath")
            {
                FindMissingFilesTextBox1.Text = "Please enter a file path";
            }
            else if (FindMissingFilesTextBox2.Text == "filePath")
            {
                FindMissingFilesTextBox2.Text = "Please enter a file path";
            }
            else
            {
                List<string> missingFiles = new List<string>();
                try
                {

                    // Get a list of all files
                    string[] fileNameList1 = Directory.GetFiles(FindMissingFilesTextBox1.Text);
                    string[] fileNameList2 = Directory.GetFiles(FindMissingFilesTextBox2.Text);

                    for (int i = 0; i < fileNameList1.Length; i++)//Loop through folder 1
                    {
                        bool fileFound = false;
                        for (int j = 0; j < fileNameList2.Length; j++)//Loop through folder 2
                        {
                            if (fileNameList1[i] == fileNameList2[i])
                            {
                                //File has been found, set found to true
                                fileFound = true;
                            }
                        }
                        if (fileFound == false)//Check if the file has been found, if not then add to missing list
                        {
                            //File not found, add to the file missing list
                            missingFiles.Add(fileNameList1[i]);
                        }
                    }
                    string missingFilesText = string.Join("\n", missingFiles);
                    MessageBox.Show(missingFilesText);
                }
                catch
                {
                    MessageBox.Show("There was an issue with the file path, please enter a valid file path");
                }
            }*/
        }

        private void findMissingFiles(object sender, RoutedEventArgs e)
        {
            
            if (FindMissingFilesTextBox1.Text == "filePath")
            {
                FindMissingFilesTextBox1.Text = "Please enter a file path";
            }
            else if (FindMissingFilesTextBox2.Text == "filePath")
            {
                FindMissingFilesTextBox2.Text = "Please enter a file path";
            }
            else
            {
                List<string> missingFiles = new List<string>();

                string[] fileNameList1;
                string[] fileNameList2;
                string errorMessage = "";
                try
                {
                    // Get a list of all files
                    errorMessage = "FilePath1";
                    fileNameList1 = Directory.GetFiles(FindMissingFilesTextBox1.Text);
                    errorMessage = "FilePath2";
                    fileNameList2 = Directory.GetFiles(FindMissingFilesTextBox2.Text);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show($"A directory of {errorMessage} does not exist");
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show($"The path entered in {errorMessage} is too long");
                }
                catch 
                {

                }

                for (int i = 0; i < fileNameList1.Length; i++)//Loop through folder 1
                {
                    bool fileFound = false;
                    for (int j = 0; j < fileNameList2.Length; j++)//Loop through folder 2
                    {
                        if (fileNameList1[i] == fileNameList2[i])
                        {
                            //File has been found, set found to true
                            fileFound = true;
                        }
                    }
                    if (fileFound == false)//Check if the file has been found, if not then add to missing list
                    {
                        //File not found, add to the file missing list
                        missingFiles.Add(fileNameList1[i]);
                    }
                }
                string missingFilesText = string.Join("\n", missingFiles);
                MessageBox.Show(missingFilesText);

            }
        }
    }
}
