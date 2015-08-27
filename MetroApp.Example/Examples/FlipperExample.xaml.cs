using MetroApp.Controls;
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
using System.Windows.Shapes;

namespace MetroApp.Example
{
    /// <summary>
    /// Interaction logic for FlipperExample.xaml
    /// </summary>
    public partial class FlipperExample : Window
    {
        public FlipperExample()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Type type = e.OriginalSource.GetType();

            
        }
    }
}
