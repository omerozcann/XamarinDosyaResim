using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFFotograf
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void fotocekBtn_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { SaveToAlbum = true });

            if (photo != null)
            {
                resimImg.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
            }
            fotografListele();
        }

        public void fotografListele()
        {
            var dizin = DependencyService.Get<dosyaErisim>().dosyaGetir();          
            flexLayout.Children.Clear();
            for (int i = 0; i < dizin.Length; i++)
            {
                var dosya = dizin[i];
                Image img = new Image
                {
                    Source = ImageSource.FromFile(dosya)
                };
                flexLayout.Children.Add(img);
            }
        }
    }
}
