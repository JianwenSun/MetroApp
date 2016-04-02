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
    public class White : Theme
    {
        public static White Instance
        {
            get
            {
                return new White();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="White"/> class.
        /// </summary>
        public White()
        {
            this.Name = "White";
        }
    }
}
