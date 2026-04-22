namespace Lab5.Views.Details
{
    [QueryProperty(nameof(SourceData), "source_data")]
    public partial class DynamicDataPage : ContentPage
    {
        public string SourceData
        {
            set
            {
                var source = Uri.UnescapeDataString(value);
                InfoLabel.Text = $"Відкрито з розділу: {source}";

                DynamicContent.Text = source switch
                {
                    "Тренажери - Розділу 2" => "У нашому залі понад 120 одиниць сучасного обладнання від провідних брендів Technogym та Life Fitness. Щорічно ми оновлюємо парк тренажерів та розширюємо кардіозону.",
                    "Абонементи - Розділу 3" => "Усі абонементи включають безлімітний доступ до душових та роздягалень. При купівлі абонементу на 3 місяці - знижка 15%. На 6 місяців - знижка 25%.",
                    _ => "Ласкаво просимо до PowerZone - місця, де народжуються чемпіони!"
                };
            }
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