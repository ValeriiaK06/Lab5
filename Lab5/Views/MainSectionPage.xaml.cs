namespace Lab5.Views;

public partial class MainSectionPage : ContentPage
{
    public MainSectionPage()
    {
        InitializeComponent();
    }

    private async void OnDetailClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("detailpage");
    }

    private async void OnHelpClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("helppage");
    }
}