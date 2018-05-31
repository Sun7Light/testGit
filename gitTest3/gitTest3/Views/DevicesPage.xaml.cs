using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ntChat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DevicesPage : ContentPage
    {
        public ObservableCollection<string> Devices { get; set; } = new ObservableCollection<string>();
        public DevicesPage()
        {
            InitializeComponent();
            Devices.Add("Sumsung galaxy s2");
            Devices.Add("Sumsung galaxy s 6");
            Devices.Add("Iphone 8");
            this.BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            Devices.Add("new devices");
            listView1.IsRefreshing = false;
        }
    }

    public class Device
    {
        public string Title { get; set; }
    }
}