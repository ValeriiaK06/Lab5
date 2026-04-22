using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Views
{
    public partial class SectionPage1 : ContentPage
    {
        public SectionPage1()
        {
            InitializeComponent();
        }
        private async void OnHelpClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("helppage");
        }
    }
}
