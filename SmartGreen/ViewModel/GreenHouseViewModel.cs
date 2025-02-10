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
        public string estadoFlujo { get; set; } = "Iniciar riego";
        public string HumedadPorcentaje { get; set; } = "45%"; // Ejemplo del porcentaje
        public IDrawable CircularProgressDrawable { get; set; } = new CircularProgressDrawable(1f);
        
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
            if (estadoFlujo == "Iniciar riego")
            {
                estadoFlujo = "Apagar riego";
                return;
            }
            estadoFlujo = "Iniciar riego";
        }

        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand EncenderFlujoCommand => new Command(TurnOnWaterFlow);
    }
}
