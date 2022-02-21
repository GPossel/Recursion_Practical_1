using CefSharp.Wpf;
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

namespace Triangles
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

        private void submitButton_OnClick(object sender, RoutedEventArgs e)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            var triangle = this.triangle;

            triangle.Height = 10;
            triangle.Points = // 
          //  DrawTriangle(e.Graphics, x, y,.);
        }


//

    }
}
