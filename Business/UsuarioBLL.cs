using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;
using Entidades;

namespace Business
{
    public class UsuarioBLL
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public List<Usuario> getUsuarios()
        {
            try
            {
                return usuarioDAO.getUsuarios();
            } catch (Exception ex) { throw; }
        }

        public Usuario validarLogin(int DNI, string password)
        {
            try
            {
                password = Encriptar.GenerateSHA256(password);
                return usuarioDAO.validarLogin(DNI, password);
            }
            catch (Exception ex) { throw; }
        }
    }
}
