## MetroApp

A project will make your work more easier and for more in-depth unstanding WPF.
By the way, I need more developers to make it more powerful.
If your want it too,please join me.
Thanks to Metro.Apps.

## Metro.Apps.
A toolkit for creating metro-style WPF applications. Lots of goodness out-of-the box.

CheckBox and RadioButton styles adapted from styles created by [Brian Lagunas of Infragistics](http://brianlagunas.com/free-metro-light-and-dark-themes-for-wpf-and-silverlight-microsoft-controls/).

### Documentation

Read it here: [http://mahapps.com](http://mahapps.com)

### Quick How To

## Base Controls
![image](https://github.com/JianwenSun/MetroApp/blob/master/MetroApp/Resources/basecontrol.png)

## DataGrid
![image](https://github.com/JianwenSun/MetroApp/blob/master/MetroApp/Resources/datagrid.png)

```csharp

 <Helpers:DataGridPopupHelper.Controller>
         <Helpers:DataGridPopupController PopupView="{StaticResource AzurePopupView}" IsDelay="False" IsStay="False" Target="DataGrid" StayTime="0:0:2"/>
 </Helpers:DataGridPopupHelper.Controller>
```
## DataGrid Target To Window
![image](https://github.com/JianwenSun/MetroApp/blob/master/MetroApp/Resources/popup_window_delay.png)

You can use DataGridPopupHelper to add the popup view and give it delay or stay time,
and target it to the owner control or window,
alos it can extend to any ohter controls.

## Selections Controls
![image](https://github.com/JianwenSun/MetroApp/blob/master/MetroApp/Resources/selections.png)

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
The StyleManager make the things more easier, and you can add your own theme by adding the color xaml.

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