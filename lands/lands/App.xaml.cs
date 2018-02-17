
namespace lands
{
    using Views;
    using Xamarin.Forms;
    public partial class App : Application
	{
        #region Construtors
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage (new LoginPage()) ;
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion

    }
}
