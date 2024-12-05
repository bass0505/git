using Proyecto_ENE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ENE.DataAccess
{
    public class UsuarioService
    {
        private UsuarioRepository usuarioReposiroty = UsuarioRepository.ObtenerInstancia();
        public void AgregarUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.usuario) || string.IsNullOrEmpty(usuario.clave) || string.IsNullOrEmpty(usuario.tipo))
            {
                throw new System.ArgumentException("Todos los campos deben tener valores");
            }
            usuarioReposiroty.GuardarUsuario(usuario);
        }
        
        public List<Usuario> ObtenerTodosUsuarios()
        {
            return usuarioReposiroty.ObtenerTodosUsuarios();
        }
        public Usuario ObtenerUsuarioPorUsuario(string ParametroUsuario)
        {
            return usuarioReposiroty.ObtenerUsuarioPorUsuario(ParametroUsuario);
        }
    }
}
