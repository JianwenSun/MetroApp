namespace MetroApp.Example
{
    using MetroApp.Controls;
    using MetroApp.Themes;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Theme_click(object sender, RoutedEventArgs e)
        {
            Theme theme = this.GetValue(StyleManager.ThemeProperty) as Theme;
            if (theme is Light)
            {
                this.SetValue(StyleManager.ThemeProperty, Dark.Instance);
            }
            else
            {
                this.SetValue(StyleManager.ThemeProperty, Light.Instance);
            }
        }

        private void VS_click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void Flipper_click(object sender, RoutedEventArgs e)
        {
            FlipperExample window = new FlipperExample();
            window.Show();
        }
    }
}
