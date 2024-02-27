using AplicacaoClassLibrary.Dados;
using AplicacaoClassLibrary.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoClassLibrary.Negocios
{
    public class UsuarioNegocios
    {
        public int Exemplo() 
        {
            Usuario usuario = new Usuario();
            return new UsuarioDados().CriaUsuario(usuario);        
        }
    }
}
