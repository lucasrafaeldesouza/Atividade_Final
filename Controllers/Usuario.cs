using System;
using System.Linq;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class UsuarioController
    {
        public static Usuario IncluirUsuario(
            string Nome,
            string Email,
            string Senha
        )
        {
            if (String.IsNullOrEmpty(Nome))
            {
                throw new Exception("Nome inválido");
            }

            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("Email inválido");
            }

            if (String.IsNullOrEmpty(Senha))
            {
                throw new Exception("Senha inválida");
            }

            int minChar = 8;
            bool invalidPass = Senha.Length < minChar;
            if (invalidPass)
            {
                throw new Exception("A senha deve possuir no mínimo 8 caracteres.");
            }

            else
            {
                Senha = BCrypt.Net.BCrypt.HashPassword(Senha);
            }

            return new Usuario(Nome, Email, Senha);
        }

        public static Usuario AlterarUsuario(
            int Id,
            string Nome,
            string Email,
            string Senha
        )
        {
            Usuario usuario = GetUsuario(Id);

            if (!String.IsNullOrEmpty(Nome))
            {

            }

            if (!String.IsNullOrEmpty(Email))
            {

            }

            if (!String.IsNullOrEmpty(Senha) && !BCrypt.Net.BCrypt.Equals(Senha, usuario.Senha))
            {
                Senha = usuario.Senha;
                Senha = BCrypt.Net.BCrypt.HashPassword(Senha);
            }

            Usuario.AlterarUsuario(Id, Nome, Email, Senha);

            return usuario;
        }

        public static Usuario RemoverUsuario(
            int Id
        )
        {
            Usuario usuario = GetUsuario(Id);
            Usuario.RemoverUsuario(usuario);
            return usuario;
        }

        public static Usuario GetUsuario(
            int Id
        )
        {
            Usuario usuario = (
                from Usuario in Usuario.GetUsuarios()
                where Usuario.Id == Id
                select Usuario
            ).First();

            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            return usuario;
        }

        public static IEnumerable<Usuario> VisualizarUsuario()
        {
            return Usuario.GetUsuarios();
        }

        public static void Auth(
            string Email,
            string Senha
        )
        {
            Usuario.Auth(Email, Senha);
        }
    }
}