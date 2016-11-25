using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Actividad2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BTN1_Click(object sender, RoutedEventArgs e)
        {
            string s1 = TXT1.Text;
            string s2 = TXT2.Text;
            int nro1 = int.Parse(s1);
            int nro2 = int.Parse(s2);
            ComboBoxItem item = (ComboBoxItem)CBO1.SelectedItem;
            if (item.Content.ToString()=="10%")
            {
                int porc10 = (nro1 * 10/100) / nro2;
                TB1.Text = "" + porc10;
            }
            if (item.Content.ToString()=="15%")
            {
                int porc2 = (nro1 * 15 / 100) / nro2;
                TB1.Text = "" + porc2;
            }

        }
    }
}
