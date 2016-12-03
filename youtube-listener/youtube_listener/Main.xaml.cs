using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace youtube_listener
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();

            this.btnLogar.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new Login());
            };
        }
    }
}
