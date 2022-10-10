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

namespace GUI_Manipulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            createWindows();
        }

        private void dragWindow(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void closeWindow(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void windowMinimise(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void createWindows()
        {            
            for (int i = 0; i < 5; i++)
            {
                Rectangle rec = new Rectangle()
                {
                    Width = 20,
                    Height = 20,
                    Fill = Brushes.Green,
                    Stroke = Brushes.Red,
                    StrokeThickness = 2,
                    Name = "rectangle" + i,
                    Margin = new Thickness(0, i * 40, 0, 0)
                };
                mainWindowGrid.Children.Add(rec);
            }
        }

        private void openSettingsMenu(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
