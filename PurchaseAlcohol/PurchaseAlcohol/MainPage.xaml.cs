using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PurchaseAlcohol
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            int legalAge = 21;
            var today = DateTime.Today;
            var birthdate = pickedAge.Date;

            var age = today.Year - birthdate.Year;

            var countryName = picker.SelectedItem;
            Console.WriteLine(countryName);

            if (countryName.Equals("United States") || countryName.Equals("Turkmenistan") || countryName.Equals("Indonesia"))
            {
                legalAge = 21;

                if (age >= legalAge)
                {
                    Lbl_Years.Text = $"You are {age} years old, you can get hammered!. Legal age in {countryName} is {legalAge}. ";
                }
                else
                {
                    Lbl_Years.Text = $"You are {age} years old, you CAN'T get hammered!. Legal age in {countryName} is {legalAge}. ";

                }
            }
            else if (countryName.Equals("U.K.") || countryName.Equals("France") || countryName.Equals("Bolivia") || countryName.Equals("Armenia") || countryName.Equals("Estonia") || countryName.Equals("Greece") || countryName.Equals("Ireland"))
            {
                legalAge = 18;

                if (age >= legalAge)
                {
                    Lbl_Years.Text = $"You are {age} years old, you can get hammered!. Legal age in {countryName} is {legalAge}. ";
                }
                else
                {
                    Lbl_Years.Text = $"You are {age} years old, you CAN'T get hammered!. Legal age in {countryName} is {legalAge}. ";

                }
            }

        }
    }
}
