namespace AuthApp.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public List<string> Roles { get; set; }
    }
}
