using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace swipeview_label_content_repro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            swipe1.Open(OpenSwipeItem.LeftItems);
            swipe2.Open(OpenSwipeItem.LeftItems);
        }
    }
}
