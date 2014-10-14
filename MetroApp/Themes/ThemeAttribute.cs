using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp.Themes
{
    /// <summary>
    /// The ThemeLocation attribute decorates a Theme class and carries information about where the theme is hosted.
    /// If a theme does not have that attribute, it is treated as an external theme by default.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class ThemeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeAttribute"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        public ThemeAttribute()
        {
        }
    }
}
