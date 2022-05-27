using AuthApp.Models;

namespace AuthApp.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuario()
        {
            return new List<Usuario>
            {
                new Usuario{ Nombre="jose", Correo="administrador@gmail.com", Clave="123", Roles=new List<string>{"Administrador"} },
                new Usuario{ Nombre="maria", Correo="supervisor@gmail.com", Clave="123", Roles=new List<string>{"Supervisor"} },
                new Usuario{ Nombre="juan", Correo="empleado@gmail.com", Clave="123", Roles=new List<string>{"Empleado"} },
                new Usuario{ Nombre="oscar", Correo="superempleado@gmail.com", Clave="123", Roles=new List<string>{"Suversiro", "Empleado"} }
            };
        }

        public Usuario ValidaUsuario(string _correo, string _clave)
        {
            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
        }
    }
}
