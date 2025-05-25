using Microsoft.Maui.Controls;

namespace Pourfect.Views
{
    public partial class RecipePage : ContentPage
    {
        public RecipePage()
        {
            InitializeComponent();
        }

        private void OnMethodChanged(object sender, EventArgs e)
        {
            string selectedMethod = MethodPicker.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedMethod))
                return;

            switch (selectedMethod)
            {
                case "V60":
                    SetRecipe(16, 30, 94, "• Rinse filter\n• Add coffee\n• Bloom 30s\n• Pulse pour until 250g in 2:30");
                    break;
                case "Kalita":
                    SetRecipe(15, 40, 92, "• Rinse filter\n• Add grounds\n• Bloom 40s\n• Fill gradually to 300g in 2:45");
                    break;
                case "Aeropress":
                    SetRecipe(12, 20, 85, "• Add coffee\n• Bloom 20s\n• Stir, steep 1:00\n• Press gently over 30s");
                    break;
            }
        }

        private void SetRecipe(double ratio, int bloomTime, double temp, string steps)
        {
            RatioLabel.Text = ratio.ToString("0.0");
            BloomTimeLabel.Text = bloomTime.ToString() + " seconds";
            TempLabel.Text = temp + " °C";
            StepsLabel.Text = steps;
        }
    }
}
