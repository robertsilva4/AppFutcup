using System.ComponentModel;
using Xamarin.Forms;

namespace AppFutcup
{
    //by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private const string View = "https://www.ligafutcup.esportes.co/";
        public MainPage()
        {
            InitializeComponent();
            webview1.Source = View;
        }
    }
}
