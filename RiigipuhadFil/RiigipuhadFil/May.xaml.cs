﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiigipuhadFil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class May : ContentPage
    {
        public May()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Май 2021", FontSize = 30 },
                new Rectangle(250, 20, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Дни в месяце", FontSize = 25 },
                new Rectangle(30, 100, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "В к алендаре: 31 день", FontSize = 15 },
                new Rectangle(30, 150, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Рабочие дни: 19 дней", FontSize = 15 },
                new Rectangle(30, 200, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Выходные и праздники: 12 дней", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Выходные и праздники", FontSize = 25 },
                new Rectangle(380, 100, 280, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "1-ого: Международный день трудящихся", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "Ёще", FontSize = 10, BackgroundColor = Color.FromHex("#00CCFF") },
                new Rectangle(315, 143, 60, 35)
           
            );
            btn1.Clicked += Btn1_Clicked;
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("International Workers' Day", "International Workers' Day, also known as Labour Day in some countries and often referred to as May Day, is a celebration of labourers and the working classes that is promoted by the international labour movement and occurs every year on May Day (1 May)." +
                " While it may belong to a tradition of spring festivals, the date was chosen in 1889 for political reasons by the Marxist International Socialist Congress, which met in Paris and established the Second International as a successor to the earlier International Workingmen's Association." +
                " They adopted a resolution for a" + "great international demonstration" + "in support of working-class demands for the eight-hour day." +
                " The date had been chosen by the American Federation of Labor to continue an earlier campaign for the eight-hour day in the United States, which had culminated in the Haymarket affair, which occurred in Chicago on 4 May 1886." +
                " May Day subsequently became an annual event." +
                " The 1904 Sixth Conference of the Second International, called on" + "all Social Democratic Party organisations and trade unions of all countries to demonstrate energetically on the First of May for the legal establishment of the eight-hour day, for the class demands of the proletariat, and for universal peace.", "OK");
        }
      
    }
}