using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

// Un conjunto de firmas de encabezados de los métodos pero no tienen implementación 
namespace HospiEnCasa.App.Persistencia {
    public interface IRepositorioPaciente {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
    }
}