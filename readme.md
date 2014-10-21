## MetroApp

A project will make your work more easier and for more in-depth unstanding WPF.
By the way, I need more developers to make it more powerful.
If your want it too,please contact me.
Thanks to Metro.Apps.

## Metro.Apps.
A toolkit for creating metro-style WPF applications. Lots of goodness out-of-the box.

CheckBox and RadioButton styles adapted from styles created by [Brian Lagunas of Infragistics](http://brianlagunas.com/free-metro-light-and-dark-themes-for-wpf-and-silverlight-microsoft-controls/).

### Documentation

Read it here: [http://mahapps.com](http://mahapps.com)

### Quick How To

```XML
<Application x:Class="MetroApp.Example.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:Themes="sunjianwen143@hotmail.com"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/MetroApp;component/Themes/Dark.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MetroApp;component/Themes/Controls.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

```XML
<MetroApp:MetroWindow x:Class="MetroApp.Example.MainWindow"
					  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
					  xmlns:MetroApp="sunjianwen143@hotmail.com"
					  GlowBrush="#CC119EDA"
					  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
					  xmlns:Themes="sunjianwen143@hotmail.com"
					  Title="MainWindow">
	<Grid.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="pack://application:,,,/MetroApp;component/Themes/Dark.xaml" />
				<ResourceDictionary Source="pack://application:,,,/MetroApp;component/Themes/Controls.xaml" />
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Grid.Resources>
	<Grid>
		<!-- now your content -->
  
	</Grid>
</MetroApp:MetroWindow>
```
OR
```XML
<MetroApp:MetroWindow x:Class="MetroApp.Example.MainWindow"
					  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
					  xmlns:MetroApp="sunjianwen143@hotmail.com"
					  GlowBrush="#CC119EDA"
					  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
					  xmlns:Themes="sunjianwen143@hotmail.com"
					  Themes:StyleManager.Theme="{x:Static Themes:Themes.Dark}"
					  Title="MainWindow">
	<Grid>
		<!-- now your content -->
  
	</Grid>
</MetroApp:MetroWindow>
```
```csharp
namespace MetroApp.Example
{
  public partial class MainWindow : MetroWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }
  }
}
```
```XML
<DataGrid Grid.Column="1" Grid.Row="1"
          Themes:StyleManager.Theme="{x:Static Themes:Themes.Dark}"
          RenderOptions.ClearTypeHint="Enabled"
          TextOptions.TextFormattingMode="Display"
          ItemsSource="{Binding Path=Albums}"
          AutoGenerateColumns="False">
    <DataGrid.Columns>
        <DataGridTextColumn Header="Title"
                        Binding="{Binding Title}" />
        <DataGridTextColumn Header="Artist"
                        Binding="{Binding Artist.Name}" />
        <DataGridTextColumn Header="Genre"
                        Binding="{Binding Genre.Name}" />
    </DataGrid.Columns>
</DataGrid>
```