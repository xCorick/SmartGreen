using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartGreen.ViewModel
{
    internal class VMAgregarVivero : BaseViewModel
    {
        public VMAgregarVivero(INavigation navigation) 
        {
            Navigation = navigation;
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public ICommand VolverCommand => new Command(async () => await Volver());
    }
}
