using Microsoft.Maui.Controls;
using Pourfect.Models;
using Pourfect.Services;
using System.Collections.Generic;

namespace Pourfect.Views
{
    public partial class BrewListPage : ContentPage
    {
        private readonly PourfectDatabase _db;

        public BrewListPage(PourfectDatabase db)
        {
            InitializeComponent();
            _db = db;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            List<Brew> brews = await _db.GetBrewsAsync();
            brews.Reverse(); // Newest first
            BrewCollection.ItemsSource = brews;
        }
    }
}
