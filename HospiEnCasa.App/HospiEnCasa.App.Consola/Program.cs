using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using System.Collections.Generic;

namespace HospiEnCasa.App.Consola
{
    class Program {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());

        static void Main(string[] args) {
            Console.WriteLine("Hello World Entity Framework!");

            //AddPaciente();
            BuscarPaciente(1);
        }

        private static void AddPaciente() {

            var paciente = new Paciente {
                Nombre = "Nicolás",
                Apellidos = "Perez",
                Genero = Genero.Masculino,
                NumeroTelefono = "3153203625",
                Direccion = "Calle 30 # 13-20",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };

            _repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente) {

            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }
    }
}
