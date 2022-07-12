using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea4.Views;
using Xamarin.Forms;

namespace tarea4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAddVideo_Clicked(object sender, EventArgs e)
        {
            var AddPage = new PhotosView();

            await Navigation.PushAsync(AddPage);
        }

        private async void btnViewVideos_Clicked(object sender, EventArgs e)
        {
            var ViewVideosPages = new ListVideoView();

            await Navigation.PushAsync(ViewVideosPages);

        }

        private void btnPlay_Clicked(object sender, EventArgs e)
        {

        }
    }
}
