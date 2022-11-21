using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cardio_em_dia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrmTelaDeLogin : ContentView
    {
        public FrmTelaDeLogin()
        {
            InitializeComponent();
        }

        private void LogarPeloGoogle(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}