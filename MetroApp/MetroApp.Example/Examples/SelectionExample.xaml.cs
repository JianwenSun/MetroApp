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

namespace MetroApp.Example
{
    /// <summary>
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class SelectionExample : UserControl
    {
        public SelectionExample()
        {
            Albums = SampleData.Albums;
            Artists = SampleData.Artists;

            CollectionViewSource.GetDefaultView(Albums).GroupDescriptions.Clear();
            CollectionViewSource.GetDefaultView(Albums).GroupDescriptions.Add(new PropertyGroupDescription("Artist"));

            this.DataContext = this;

            InitializeComponent();
        }

        public List<Album> Albums { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
