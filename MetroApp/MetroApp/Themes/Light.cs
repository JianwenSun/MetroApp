using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp.Themes
{
    /// <summary>
    /// Light class represents the key to the Light theme.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]

    [Theme]
    public class Light : Theme
    {
        public static Light Instance
        {
            get
            {
                return new Light();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Light"/> class.
        /// </summary>
        public Light()
        {
            this.Name = "Light";
        }
    }
}
