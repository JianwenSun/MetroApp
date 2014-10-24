using System;
using System.Net;
using System.Windows;
using System.Windows.Data;

namespace System.Windows
{
    /// <summary>
    /// Extensions of the FrameworkElement class.
    /// </summary>
    internal static class PropertyChangedRegistrar
    {
		public static DependencyProperty RegisterListener(
			string propertyPath,
			Type type,
			PropertyChangedCallback callback)
		{
			long index = DateTime.Now.Ticks;
			string typeName = type.Name.Replace('.', '_');
			string name = string.Format("Listener{0}{1}{2}",
				typeName,
				propertyPath,
				index);

			DependencyProperty prop = null;

			do
			{
				try
				{
					prop = DependencyProperty.RegisterAttached(
						name,
						typeof(object),
						type,
						new PropertyMetadata(callback));
					break;
				}
				catch
				{
					index = DateTime.Now.Ticks;
					name = string.Format("Listener{0}{1}{2}",
						typeName,
						propertyPath,
						index);
				}
			}
			while (true);

			return prop;
		}

		public static void RegisterForNotification(
			this FrameworkElement element,
			string propertyPath,
			DependencyProperty listener)
		{
			Binding binding = new Binding(propertyPath)
			{
				Mode = BindingMode.OneWay,
				Source = element
			};

			element.SetBinding(listener, binding);
		}
    }
}
