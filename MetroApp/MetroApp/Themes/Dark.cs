using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetroApp.Themes
{
    /// <summary>
    /// Dark class represents the key to the Dark theme.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
    [Theme]
    public class Dark : Theme
    {
        public static Dark Instance 
        {
            get 
            {
                return new Dark();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dark"/> class.
        /// </summary>
        public Dark()
        {
            this.Name = "Dark";
        }
    }
}
