using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace youtube_listener
{
    public partial class Profile : ContentPage
    {
        public Profile(string message)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
        }
    }
}
