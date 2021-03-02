using System;
using Xamarin.Forms;

namespace Rocca_Janula_QR.ViewModels
{
    class HomePageViewModel : BaseViewModel
    {
        private string qr_value;
        private DateTime dt;
        public string qr_Value
        {
            get { return qr_value; }
            set
            {
                qr_value = value;
                OnPropertyChanged();
            }
        }

        public Command OnGenerate { get; }


        public HomePageViewModel()
        {
            OnGenerate = new Command(GenerateQR);
            
        }

        private void GenerateQR(object obj)
        {
            qr_Value = "https://localhost/wordpress";
 


        }
    }
}
