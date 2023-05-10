using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp8.Core;

namespace WpfApp8.View.Pages;
/// <summary>
/// Логика взаимодействия для SpPage.xaml
/// </summary>
public partial class SpPage : Page
{
    public SpPage()
    {
        InitializeComponent();

    }

    private void Page_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ClickCount == 1)
        {
            MyCoreClass.MyFrameCore?.Navigate(new SpTestPage());
        }

    }
}

 
