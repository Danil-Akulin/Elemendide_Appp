using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();

            Button Ent_btn = new Button()
            {
                Text = "Entry",
                BackgroundColor = Color.LightGreen,
            };

            Button Timer_btn = new Button()
            {
                Text = "Timer",
                BackgroundColor = Color.LightGreen,
            };
            Button cliker = new Button()
            {
                Text = "Clicker",
                BackgroundColor = Color.LightGreen,
            };
            Button Date_btn = new Button()
            {
                Text = "Date/Time",
                BackgroundColor = Color.LightGreen,
            };
            Button SS_btn = new Button()
            {
                Text = "Stepper/Slider",
                BackgroundColor = Color.LightGreen,
            };
            Button Frame_btn = new Button()
            {
                Text = "Frame",
                BackgroundColor = Color.LightGreen,
            };
            Button Image_btn = new Button()
            {
                Text = "Image",
                BackgroundColor = Color.LightGreen,
            };
            Button Valgusfoor_btn = new Button()
            {
                Text = "Valgusfoor",
                BackgroundColor = Color.LightGreen,
            };
            StackLayout st = new StackLayout()
            {
                Children = { Ent_btn , Timer_btn , cliker , Date_btn , SS_btn, Frame_btn, Image_btn, Valgusfoor_btn }
            };

            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            cliker.Clicked += Cliker_Clicked;
            Date_btn.Clicked += Date_btn_Clicked;
            SS_btn.Clicked += SS_btn_Clicked;
            Frame_btn.Clicked += Frame_btn_Clicked;
            Image_btn.Clicked += Image_btn_Clicked;
            Valgusfoor_btn.Clicked += Valgusfoor_btn_Clicked;
        }

        private async void SS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_page());
        }

        private async void Date_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Date_Time());
        }
        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_Page());
        }
        private async void Valgusfoor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor());         //page
        }
        private async void Frame_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frame_Page());
        }

        private async void Cliker_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new cliker());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimerPage());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ent_page());
        }
    }
    
}
