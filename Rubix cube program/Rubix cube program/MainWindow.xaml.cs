using System;
using System.Collections.Generic;
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

namespace Rubix_cube_program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupCube();

        }
        public int[,,] faces = new int[6, 3, 3];
        
        public void SetupCube()
        {
            Random rnd = new Random();
            
            string[] colours = { "red", "green", "yellow", "white", "blue", "orange" };
            int[] colourcount = { 0, 0, 0, 0, 0, 0 };
            

            for (int i = 0; i < faces.GetLength(0); i++)
            {
                for (int j = 0; j < faces.GetLength(1); j++)
                {
                    for (int k = 0; k < faces.GetLength(2); k++)
                    {
                        int num = rnd.Next(0, 6);
                        while (colourcount[num] >= 9)
                        {
                            Console.WriteLine("Full colour, generating a new one");
                            num = rnd.Next(0, 6);
                            
                        }
                        colourcount[num] += 1;
                        faces[i, j, k] = num;
                        listboxShow.Items.Add(colours[num]);
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                listboxShow2.Items.Add("Colour: " + colours[i] + " With value of" + colourcount[i]);
            }
            
        }
    }
}
