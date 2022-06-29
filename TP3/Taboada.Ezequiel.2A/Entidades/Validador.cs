using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {
        /// <summary>
        /// valida que la cadena recibida sea numerica y del tipo UINT.
        /// </summary>
        /// <param name="strNumero"></param> cadena a verificar.
        /// <returns></returns> true si es numerica y del tipo UINT o false en caso contrario.
        public static bool EsUInt(string strNumero)
        {
            bool UInt = true;

            foreach (char item in strNumero)
            {

                if (!char.IsDigit(item))
                {
                    UInt = false;
                    break;
                }

            }
            return UInt;
        }

        /// <summary>
        /// Recibe una cadena y devuelve una copia con formato upperCamelCase
        /// </summary>
        /// <param name="texto"> cadena a formatear </param>
        /// <returns> Una copia de la cadena con formato upperCamelCase </returns>
        public static string FormatoNombre(string texto)
        {
            StringBuilder formato = new StringBuilder(texto.ToLower());

            for (int i = 0; i < formato.Length; i++)
            {
                if (i == 0)
                {
                    formato[i] = char.ToUpper(formato[i]);
                }
                if (formato[i] == ' ')
                {
                    i++;
                    formato[i] = char.ToUpper(formato[i]);
                }

            }
            return formato.ToString();
        }

        public static bool Es_DNI_Telefono(string dato)
        {
            bool valido = false;
            if (dato.Length == 8 && Validador.EsUInt(dato))
            {
                valido = true;
            }
            return valido;
        }
    }
}

