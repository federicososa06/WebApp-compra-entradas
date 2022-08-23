using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public enum TipoUsuario
    {
        cliente = 1,
        operador = 2
    }



    public class Usuario: IComparable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public string Contrasenia { get; set; }

        public string NombreUsuario { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public static int idAuto = 0;

        public TipoUsuario TipoUsuario { get; set; }

        public Usuario(string nom, string ape, string email, string user, string contra, DateTime nac, TipoUsuario usu)
        {
            Nombre = nom;
            Apellido = ape;
            Email = email;
            NombreUsuario = user;
            Contrasenia = contra;
            FechaNacimiento = nac;
            TipoUsuario = usu;

            idAuto++;
            Id = idAuto;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} || Apellido: {Apellido} || Email: {Email} || Fecha de nacimiento: {FechaNacimiento}";
        }



        public override bool Equals(object obj)
        {
            Usuario u = (Usuario)obj;
            return this.Email == u.Email;
        }


        public int CompareTo(object obj)
        {
            Usuario u = (Usuario)obj;

            if (this.Apellido.CompareTo(u.Apellido) > 0)
                return 1;
            else if (this.Apellido.CompareTo(u.Apellido) < 0)
                return -1;
            else
            {
                if (this.Nombre.CompareTo(u.Nombre) > 0)
                    return 1;
                else
                    return - 1;
            }
        }


    }


}
