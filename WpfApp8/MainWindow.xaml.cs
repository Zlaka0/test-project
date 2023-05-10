using System.Windows;
using WpfApp8.Core;
using WpfApp8.View.Pages;

namespace WpfApp8;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        MyCoreClass.MyFrameCore = MainFrame;

        MainFrame.Navigate(new SpPage());
    }
}
