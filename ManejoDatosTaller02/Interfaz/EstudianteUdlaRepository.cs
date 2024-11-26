using ManejoDatosTaller02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatosTaller02.Interfaz
{
    public interface EstudianteUdlaRepository
    {
        bool CrearEstudianteUDLA(EstudianteUdla estudiante);
        bool ActualizarEstudianteUDLA(EstudianteUdla estudiante);
        bool EliminarEstudianteUDLA(int id);
        IEnumerable<EstudianteUdla> DevuelveÑistadoEstudiantesUDLA();
        EstudianteUdla DevuelveInfoEstudiante(int id);
    }
}
