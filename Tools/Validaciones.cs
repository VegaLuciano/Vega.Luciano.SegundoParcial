using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tools
{
    public static class Validaciones
    {
        public static bool ValidarCampo(string nombre)
        {
            bool retorno = true;

            if (!Validaciones.ValidarString(nombre))
            {
                retorno = false;
            }

            if (!nombre.All(letra => char.IsLetter(letra)))
            {
                retorno =  false;
            }

            return retorno;
        }
        /// <summary>
        /// Valida los atributos de un imput para un nombre o un mail
        /// </summary>
        /// <param name="campo"></param> atributo que se quiera validar
        /// <param name="caso"></param> caso que indica si es nombre o mail
        /// <returns> Retorna true si el campo esta bien, sino false</returns>
        public static bool ValidarAtributos(string campo, int caso)
        {
            bool retorno = true;

            if (caso == 1)
            {
                if (!Validaciones.ValidarCampo(campo))
                {
                    retorno = false;
                }
            }
            else
            {
                if (!Validaciones.ValidarCampo(campo, '@'))
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public static bool ValidarCampo(string email, char caracter) 
        {
            bool retorno = true;
            if (!Validaciones.ValidarString(email)) 
            {
                retorno = false;
            }
            if (!email.All(letra => char.IsLetter(letra) || letra == caracter || letra == '.'))
            {
                retorno = false;
            }

            return retorno;
           
        }
        public static bool EsFormtatoAlturaValido(string input)
        {

            string patron = @"^\d+,\d$";

            return Regex.IsMatch(input, patron);
        }

        private static bool ValidarString(string cadena) 
        {
            bool retorno = true;

            if (cadena.Length > 25)
            {
                retorno = false;
            }

            if (string.IsNullOrEmpty(cadena))
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
