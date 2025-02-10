using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SmartGreen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartGreen.ViewModel;

internal class VMinvernaderos : BaseViewModel
{
    public ObservableCollection<ViveroModel> Invernaderos { get; set; }

    public VMinvernaderos(INavigation navigation)
    {
        Navigation = navigation;
        // Simulación de datos; aquí conectarías con tu base de datos
        Invernaderos = new ObservableCollection<ViveroModel>
    {
    new ViveroModel { Nombre = "Invernadero Squish" },
    new ViveroModel { Nombre = "Invernadero Orquidea"},
    
    };
    }
}