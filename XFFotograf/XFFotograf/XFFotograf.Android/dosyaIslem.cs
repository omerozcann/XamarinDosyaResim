using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XFFotograf.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(dosyaIslem))]
namespace XFFotograf.Droid
{
    class dosyaIslem:dosyaErisim
    {
        [Obsolete]
        public String[] dosyaGetir()
        {
            var dizi = Directory.GetFiles(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures).AbsolutePath, "*.jpg", SearchOption.AllDirectories);
            return dizi;
        }
    }
}