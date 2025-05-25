using Pourfect.Models;
using Pourfect.Services;
using System;
using Microsoft.Maui.Controls;

namespace Pourfect.Views
{
    public partial class BrewEntryPage : ContentPage
    {
        private readonly PourfectDatabase _db;

        public BrewEntryPage(PourfectDatabase db)
        {
            InitializeComponent();
            _db = db;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoseEntry.Text) || string.IsNullOrWhiteSpace(WaterEntry.Text))
            {
                await DisplayAlert("Missing Info", "Please fill in at least dose and water", "OK");
                return;
            }

            var newBrew = new Brew
            {
                Date = DateTime.Now,
                Method = MethodPicker.SelectedItem?.ToString() ?? "Unknown",
                Dose = double.TryParse(DoseEntry.Text, out var dose) ? dose : 0,
                Water = double.TryParse(WaterEntry.Text, out var water) ? water : 0,
                BloomTime = int.TryParse(BloomEntry.Text, out var bloom) ? bloom : 0,
                TotalTime = int.TryParse(TotalTimeEntry.Text, out var total) ? total : 0,
                Notes = NotesEditor.Text
            };

            await _db.SaveBrewAsync(newBrew);
            await DisplayAlert("Saved", "Your brew has been logged.", "OK");

            // Optional: Clear fields after saving
            DoseEntry.Text = WaterEntry.Text = BloomEntry.Text = TotalTimeEntry.Text = "";
            NotesEditor.Text = "";
            MethodPicker.SelectedIndex = -1;
        }
    }
}
