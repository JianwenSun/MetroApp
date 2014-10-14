using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetroApp.Themes
{
    /// <summary>
    /// DarkTheme class represents the key to the DarkTheme theme.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [Theme]
    public class DarkTheme : Theme
    {
        public static DarkTheme Instance 
        {
            get 
            {
                return new DarkTheme();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DarkTheme"/> class.
        /// </summary>
        public DarkTheme()
        {
            this.Name = "Dark";
        }
    }
}
