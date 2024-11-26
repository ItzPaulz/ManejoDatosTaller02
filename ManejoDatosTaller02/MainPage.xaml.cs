using ManejoDatosTaller02.Interfaz;
using ManejoDatosTaller02.Models;
using ManejoDatosTaller02.Repositorios;

namespace ManejoDatosTaller02
{
    public partial class MainPage : ContentPage
    {
        public EstudianteUdlaRepository _estudianteUdlaRepository;
        public EstudianteUdla estudiante = new EstudianteUdla();
        public MainPage()
        {
            InitializeComponent();
            _estudianteUdlaRepository = new EstudianteUDLAFilesRepository();

            estudiante = _estudianteUdlaRepository.DevuelveInfoEstudiante(1);

            BindingContext = estudiante;

        }
       

        private async void btn_guardar_Clicked(object sender, EventArgs e)
        {
            EstudianteUdla estudiante = new EstudianteUdla
            {
                Id =Int32.Parse (editor_id.Text),
                Nombre = editor_nombre.Text,
                Carrera = editor_carrera.Text
            };
            bool guardar = _estudianteUdlaRepository.CrearEstudianteUDLA(estudiante);
            if (guardar)
            {
                await DisplayAlert("Guardadocorrectamente", "Guuardar codigo", "ok");
            } else
            {
                await DisplayAlert("Alerta", "Error al guardar", "Aceptar");
            }
            Navigation.PushAsync(new MainPage());

        }

       
    }

}
