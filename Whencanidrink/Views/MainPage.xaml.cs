using System.Net.Mime;
using System.Reflection;



namespace Whencanidrink.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;
        public DateTime birthDate;
        public DateTime RightNow;
        public DateTime yrsLeft;
        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }
        
         

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
            RightNow = DateTime.Now;
            birthDate = AgeInput.Date;
            // MainAge.Text = age.ToString();
            var yr = RightNow.Date.Subtract(birthDate.Date);
            var AgeDif = 21 - (yr.Days / 365) ;
            if (AgeDif > 0)
            {
                MainAge.Text = $"You have {AgeDif } years left";
            }
            else
            {
                MainAge.Text = $"Here is your booze";
            }
            
            _count++;
        }
    }
}