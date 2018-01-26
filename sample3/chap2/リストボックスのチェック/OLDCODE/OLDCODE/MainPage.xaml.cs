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

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace OLDCODE
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyResult.Text = MyListBox.SelectedIndex >= 0 ? (string)MyListBox.Items[MyListBox.SelectedIndex] : "not selected";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyListBox.Items.Add("alpha");
            MyListBox.Items.Add("beta");
            MyListBox.Items.Add("gamma");
            MyListBox.SelectedIndex = 0;
        }

        private void MyUnselect_Click(object sender, RoutedEventArgs e)
        {
            MyListBox.SelectedIndex = -1;
        }
    }
}
