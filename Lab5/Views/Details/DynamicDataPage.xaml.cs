using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Views.Details
{
    [QueryProperty(nameof(SourceData), "source_data")]
    public partial class DynamicDataPage : ContentPage
    {
        public string SourceData
        {
            set { InfoLabel.Text = $"Сторінку відкрито з: {Uri.UnescapeDataString(value)}"; }
        }

        public DynamicDataPage()
        {
            InitializeComponent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
