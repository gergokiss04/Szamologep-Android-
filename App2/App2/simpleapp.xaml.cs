using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class simpleapp : ContentPage
    {
        public simpleapp()
        {
            InitializeComponent();

            
        }

        public async void osszeadas(object sender,EventArgs e)
        {

            try
            {
                if (Fnumber.Text == null && Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Üresek a bevételi mezők", "OK");
                }
                else if (Fnumber.Text == null || Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Valamelyik bevételi mező üres", "OK");
                }
                else
                {
                    Total.Text = (Convert.ToInt32(Fnumber.Text) + Convert.ToInt32(Snumber.Text)).ToString();
                    Retry.IsVisible = true;
                }
            }
            catch (System.FormatException)
            {

                Fnumber.Text = null;
                Snumber.Text = null;
                Total.Text = null;
            }


        }

        public void ujra(object sender,EventArgs e)
        {
            Fnumber.Text = "";
            Snumber.Text = "";
            Total.Text = "";
            Retry.IsVisible= false;
        }
        public async void kivonas(object sender, EventArgs e)
        {
            try
            {
                if (Fnumber.Text == null && Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Üresek a bevételi mezők", "OK");
                }
                else if (Fnumber.Text == null || Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Valamelyik bevételi mező üres", "OK");
                }
                else
                {
                    Total.Text = (Convert.ToInt32(Fnumber.Text) - Convert.ToInt32(Snumber.Text)).ToString();
                    Retry.IsVisible = true;
                }
            }
            catch (System.FormatException)
            {

                Fnumber.Text = null;
                Snumber.Text = null;
                Total.Text = null;
            }

        }
        public async void szorzas(object sender, EventArgs e)
        {

            try
            {
                if (Fnumber.Text == null && Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Üresek a bevételi mezők", "OK");
                }
                else if (Fnumber.Text == null || Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Valamelyik bevételi mező üres", "OK");
                }
                else
                {
                    Total.Text = (Convert.ToInt32(Fnumber.Text) * Convert.ToInt32(Snumber.Text)).ToString();
                    Retry.IsVisible = true;
                }
            }
            catch (System.FormatException)
            {

                Fnumber.Text = null;
                Snumber.Text = null;
                Total.Text = null;
            }

        }
        public async void osztas(object sender, EventArgs e)
        {
            try
            {
                if (Fnumber.Text == null && Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Üresek a bevételi mezők", "OK");
                }
                else if (Fnumber.Text == null || Snumber.Text == null)
                {
                    await DisplayAlert("Figyelmeztetés", "Valamelyik bevételi mező üres", "OK");
                }
                else
                {
                    Total.Text = (Convert.ToInt32(Fnumber.Text) / Convert.ToInt32(Snumber.Text)).ToString();
                    Retry.IsVisible = true;
                }
            }
            catch (System.FormatException)
            {

                Fnumber.Text= null;
                Snumber.Text= null;
                Total.Text= null;
            }
            
        }
    }
}