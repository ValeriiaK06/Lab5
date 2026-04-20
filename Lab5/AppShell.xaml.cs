using Lab5.Views;
using Lab5.Views.Details;

namespace Lab5
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Реєстрація додаткових маршрутів (Вимоги 5, 9 та 10):

            // Сторінка деталей (DetailPage1)
            Routing.RegisterRoute("detailpage", typeof(DetailPage1));

            // Службова сторінка довідки (HelpPage)
            Routing.RegisterRoute("helppage", typeof(HelpPage));

            // Сторінка для відображення динамічних даних (DynamicDataPage)
            Routing.RegisterRoute("dynamicpage", typeof(DynamicDataPage));
        }
    }
}