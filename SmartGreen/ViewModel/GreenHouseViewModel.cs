using SmartGreen.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartGreen.ViewModel
{
    public class GreenHouseViewModel : BaseViewModel
    {
        private string _estadoFlujo = "Iniciar riego";
        public string HumedadPorcentaje { get; set; } = "45%"; // Ejemplo del porcentaje
        public IDrawable CircularProgressDrawable { get; set; } = new CircularProgressDrawable(1f);

        public string EstadoFlujo
        {
            get { return _estadoFlujo; }
            set { SetValue(ref _estadoFlujo, value); }
        }
        
        public GreenHouseViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void TurnOnWaterFlow()
        {
            if (EstadoFlujo == "Iniciar riego")
            {
                EstadoFlujo = "Apagar riego";
                return;
            }
            EstadoFlujo = "Iniciar riego";
        }

        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand EncenderFlujoCommand => new Command(TurnOnWaterFlow);
    }
}
