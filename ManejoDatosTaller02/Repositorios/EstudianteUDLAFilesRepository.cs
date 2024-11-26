using ManejoDatosTaller02.Interfaz;
using ManejoDatosTaller02.Models;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace ManejoDatosTaller02.Repositorios
{
    public class EstudianteUDLAFilesRepository : EstudianteUdlaRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");
        public bool ActualizarEstudianteUDLA(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUdla estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;

            }
            catch(Exception)
            {
                throw;
            }
            
            
        }

        public EstudianteUdla DevuelveInfoEstudiante(int id)
        {
            EstudianteUdla estudiante = new EstudianteUdla();
            try    
            {
                if (File.Exists(_fileName))
                {
                    string json_data=File.ReadAllText(_fileName);
                    estudiante = JsonConvert.DeserializeObject<EstudianteUdla>(json_data); 
                }

            } catch(Exception)
            {
                throw;
            }
            return estudiante;
        }

        public IEnumerable<EstudianteUdla> DevuelveÑistadoEstudiantesUDLA()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }
    }
}
