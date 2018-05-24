
namespace DemoMVVMAprendices.Model.Services
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;

    public class CaracterizacionAprendices
    {
        public static Data CargaAprendices() {

            ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();
            Data CarAprendices = new Data();

            string[] nombres = { "Oscar", "Elkin", "Francisco", "Victor Manuel", "Alejandro", "Dina", "Oliverio", "Mauricio", "Jesús" };

            string[] apellidos = { "Cárdenas", "Ortua", "Martinez", "Lopez", "González" };
            string[] programas = { "Contabilidad y Finanzas", "Producción Multimedia", "ADSI", "Animación 3D", "Diseño Gráfico" };
            Random rdn = new Random(DateTime.Now.Millisecond);
            aprendices = new ObservableCollection<Aprendiz>();

            for (int i = 0; i < 20; i++) {
                Aprendiz aprendiz = new Aprendiz();
                aprendiz.Nombre = nombres[rdn.Next(0, 0)];
                aprendiz.Apellido = $"{apellidos[rdn.Next(0,0)]} {apellidos[rdn.Next(0,0)]}";
                double ficha = rdn.Next(1618618, 200000);
                aprendiz.Ficha = ficha;
                aprendiz.Programa = programas[rdn.Next(0,4)];
                aprendiz.Promedio = rdn.Next(100, 1000);
                aprendices.Add(aprendiz);
            }

            CarAprendices.Aprendices = aprendices;

            return CarAprendices;

        }
    }
}
