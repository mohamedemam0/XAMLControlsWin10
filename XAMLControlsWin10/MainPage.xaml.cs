using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XAMLControlsWin10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Class1> persons = new List<Class1>();
        public MainPage()
        {
            this.InitializeComponent();

            Class1 p1 = new Class1();
            p1.Image = "ms-appx:///Assets/IMG_0802.JPG";
            p1.Name = "Mohamed Emam";
            p1.Occupation = "Developer";
            p1.Age = 21;
            persons.Add(p1);

            Class1 p2 = new Class1();
            p2.Image = "ms-appx:///Assets/IMG_0802.JPG";
            p2.Name = "Mohamed Emam";
            p2.Occupation = "Developer";
            p2.Age = 21;
            persons.Add(p2);

            myList.ItemsSource = persons;
        }

        public class Class1
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Image { get; set; }
            public int Age { get; set; }
        }

        private void myList_ItemClick(object sender, ItemClickEventArgs e)
        {
            new MessageDialog((e.ClickedItem as Class1).Name,"Title").ShowAsync();
        }       
    }
}
