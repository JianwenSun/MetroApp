using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp.Themes
{
    /// <summary>
    /// LightTheme class represents the key to the LightTheme theme.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]

    [Theme]
    public class LightTheme : Theme
    {
        public static LightTheme Instance
        {
            get
            {
                return new LightTheme();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LightTheme"/> class.
        /// </summary>
        public LightTheme()
        {
            this.Name = "Light";
        }
    }
}
