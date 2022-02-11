using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        Frame fr;
        Label lb;
        Grid gr;
        public Valgusfoor()
        {
            lb = new Label()
            {
                Text = "Valgusfoor",
                TextColor = Color.Black
            };



            gr = new Grid
            {
                RowDefinitions =
                    {
                        new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},

                    },
                ColumnDefinitions =
                    {
                        new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    },
            };
            gr.Children.Add(new BoxView { Color = Color.DarkRed }, 0, 0);
            Thread.Sleep(500);
            gr.Children.Add(new BoxView { Color = Color.DarkOrange }, 0, 1);
            Thread.Sleep(500);
            gr.Children.Add(new BoxView { Color = Color.DarkGreen }, 0, 2);

            fr = new Frame
            {
                Content = gr,
                VerticalOptions = LayoutOptions.FillAndExpand
            };






            Button miss_see_on_btn = new Button()
            {
                Text = "Ready",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
            };
            Button Tagasi_btn = new Button()
            {
                Text = "Back",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
            };
            Button Koik_btn = new Button()
            {
                Text = "Exit",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
            };
            

            StackLayout st = new StackLayout()
            {
                Children = { lb, miss_see_on_btn, Tagasi_btn, fr, Koik_btn }
            };
            Content = st;

            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            Tagasi_btn.Clicked += Tagasi_btn_Clicked;
            miss_see_on_btn.Clicked += miss_see_on_btn_Clicked;
            Koik_btn.Clicked += Koik_btn_Clicked;



        }
        private async void miss_see_on_btn_Clicked(object sender, EventArgs e)
        {

            await Task.Delay(1000);
            gr.Children.Add(new BoxView { Color = Color.Red }, 0, 0);
            await Task.Delay(1000);
            gr.Children.Add(new BoxView { Color = Color.LightGray }, 0, 0);
            gr.Children.Add(new BoxView { Color = Color.Yellow }, 0, 1);
            await Task.Delay(1000);
            gr.Children.Add(new BoxView { Color = Color.LightGray }, 0, 1);
            gr.Children.Add(new BoxView { Color = Color.Green }, 0, 2);
            await Task.Delay(1000);
            gr.Children.Add(new BoxView { Color = Color.LightGray }, 0, 2);
        }

        private async void Tagasi_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void Koik_btn_Clicked(object sender, EventArgs e)
        {
            gr.Children.Add(new BoxView { Color = Color.LightGray }, 0, 0);
            gr.Children.Add(new BoxView { Color = Color.LightGray }, 0, 1);
            gr.Children.Add(new BoxView { Color = Color.LightGray }, 0, 2);
        }
    }
}