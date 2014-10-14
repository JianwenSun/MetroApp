using System;
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

namespace MetroApp.Example
{
    using MetroApp.Controls;
    using MetroApp.Themes;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Theme theme = this.GetValue(StyleManager.ThemeProperty) as Theme;
            if(theme is LightTheme)
            {
                this.SetValue(StyleManager.ThemeProperty, DarkTheme.Instance);
            }
            else
            {
                this.SetValue(StyleManager.ThemeProperty, LightTheme.Instance);
            }
        }
    }
}
