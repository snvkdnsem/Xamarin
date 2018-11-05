using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listView.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                var emp = e.SelectedItem as Emp;

                //await DisplayAlert("Tapped!", e.SelectedItem + " was tapped.", "OK");
                var nextPage = new NextPage();
                nextPage.BindingContext = emp;
                await Navigation.PushAsync(nextPage);
            };
        }
    }
}