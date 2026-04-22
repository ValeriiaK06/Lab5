using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Views
{
    public partial class SectionPage3 : ContentPage
    {
        public SectionPage3()
        {
            InitializeComponent();
        }

        private async void OnDynamicPageClicked(object sender, EventArgs e)
        {
            var parameters = new Dictionary<string, object> { { "source_data", "Абонементи - Розділу 3" } };
            await Shell.Current.GoToAsync("dynamicpage", parameters);
        }

        private async void OnHelpClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("helppage");
        }


    }
}
