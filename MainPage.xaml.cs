using RegistrationFormDone.Pages;

namespace RegistrationFormDone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnNext_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync (new RegistrationForm2());
        }
    }
}