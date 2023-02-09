using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Erathosenes
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
        private List<Rectangle> list = new List<Rectangle>();
        private int arraySize = 15;
        private void createBoxes(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {

                    Rectangle rec = new Rectangle()
                    {
                        Width = 25,
                        Height = 25,
                        Margin = new Thickness(0, 0, 0, 0),
                        Fill = Brushes.Gray,
                        StrokeThickness = 2,
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Top
                    };

                    Label lab = new Label()
                    {
                        Width = 100,
                        Height = 100,
                        Margin = new Thickness(0, 0, 0, 0),
                        Content = "",
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Top
                    };

                    
                    rec.Margin = new Thickness(j*26,i*26,0,0);
                    lab.Margin = new Thickness(j * 26, i * 26, 0, 0);


                    lab.Content = (i * arraySize) + j + 1;
                    // Add to a canvas and list
                    list.Add(rec);

                    
                    MainGrid.Children.Add(rec);
                    MainGrid.Children.Add(lab);

                }

            }
        }

        private void doTheThing(object sender, RoutedEventArgs e)
        {
            for (int i = 3; i < arraySize * arraySize; i+=2)
            {
                if ((i+1) % 2 == 0)
                {
                    list[i].Fill = Brushes.Red;
                }
            }

            for (int i = 2; i < arraySize*arraySize; i+=3)
            {
                if ((i+1) % 3 == 0)
                {
                    list[i].Fill = Brushes.Yellow;
                }
            }

            for (int i = 9; i < arraySize * arraySize; i += 5)
            {
                if ((i + 1) % 5 == 0)
                {
                    list[i].Fill = Brushes.Blue;
                }
            }

            for (int i = 13; i < arraySize * arraySize; i += 7)
            {
                if ((i + 1) % 7 == 0)
                {
                    list[i].Fill = Brushes.Orange;
                }
            }
        }
    }
}
