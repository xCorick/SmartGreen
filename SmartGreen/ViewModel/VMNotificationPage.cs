
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SmartGreen.Model;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.VisualBasic;

namespace SmartGreen.ViewModel
{
    internal class VMNotificationPage : BaseViewModel
    {
        public ObservableCollection<NotificationModel> Notificaciones { get; set; }

        public VMNotificationPage(INavigation navigation)
        {
            Navigation = navigation;
            // Simulación de datos; aquí conectarías con tu base de datos
            Notificaciones = new ObservableCollection<NotificationModel>
            {
            new NotificationModel { Titulo = "Invernadero Squish", Mensaje = "¡Alerta! Humedad baja.", Hora = "07:53 PM" },
            new NotificationModel { Titulo = "Invernadero Orquidea", Mensaje = "Humedad: 60%", Hora = "07:53 PM" },
            new NotificationModel { Titulo = "Invernadero Squish", Mensaje = "¡Alerta! Humedad baja.", Hora = "07:53 PM" },
            };
        }

        public async Task Home()
        {
            await Navigation.PushAsync(new NavigationPage(new MainMenu()));
        }

        public ICommand HomeCommand => new Command(async () => await Home());
    }
}
