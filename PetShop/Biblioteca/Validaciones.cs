using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Entidades
{
    public class Validaciones
    {

        private static Dictionary<string, Usuario> acceso;


        /// <summary>
        /// Constructor sin parámetros de la clase Accesorio.
        /// </summary>
        static Validaciones()
        {
            acceso = PetShop.Usuario;
        }


        /// <summary>
        /// mensajes de validacion con exceociones
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>mensajes de validacion</returns>
        public static void SalidaMensajeValidacion(string usuario, string password)
        {
            if (!(acceso is null) && !(string.IsNullOrWhiteSpace(usuario)) && !(string.IsNullOrWhiteSpace(password)))
            {
                if (ValidacionUser(usuario))
                {
                    if (!(ValidacionPassword(password)))
                    {
                        UsuarioInvalidoException usuarioInvalidoException = new UsuarioInvalidoException(message: "Password Incorrecto!");
                        throw usuarioInvalidoException;
                    }
                }
                else
                {
                    UsuarioInvalidoException usuarioInvalidoException = new UsuarioInvalidoException(message: "Usuario Incorrecto");
                    throw usuarioInvalidoException;
                }
            }
            else
            {
                UsuarioInvalidoException usuarioInvalidoException = new UsuarioInvalidoException(message: "Error al ingresar usuario y/o password");
                throw usuarioInvalidoException;
            }
        }


        /// <summary>
        /// valida el uusario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>true o false</returns>
        public static bool ValidacionUser(string usuario)
        {
            foreach (var item in acceso)
            {
                if (item.Value.NameUsuario == usuario)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// devuelve en string el nombre del objeto pasado por parametro
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>Devuelve el nombre del objeto en string</returns>
        public static string ObtenerNombreObjeto(Object objeto)
        {
            string aux;
            Type type = objeto.GetType();
            aux = type.ToString();
            aux = aux.Substring(aux.IndexOf(".") + 1);
            return aux;
        }


        /// <summary>
        /// Valida password
        /// </summary>
        /// <param name="password"></param>
        /// <returns>true o false</returns>
        public static bool ValidacionPassword(string password)
        {
            foreach (var item in acceso)
            {
                if (item.Value.PassUsuario == password)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Valida si es numero
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true o false</returns>
        public static bool ValidateNumberCuit(string number)
        {
            number = number.Trim();
            number = number.Replace("-", string.Empty);
            if (number.Length != 11)
            {
                return false;
            }
            return ValidaCuit(number);
        }


        /// <summary>
        /// Calcula el digito para el cuit
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns>devuelve un nuemro</returns>
        public static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;
            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }


        /// <summary>
        /// Valida si el cuit tiene el formato correcto
        /// </summary>
        /// <param name="cuit"></param>
        /// <returns>true o false</returns>
        public static bool ValidaCuit(string cuit)
        {
            if (cuit == null)
            {
                return false;
            }
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }


        /// <summary>
        /// Obtiene el valor del objeto del tipo enumerado que se pasa por paramtro
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>devuelve en string el valor que enumerado</returns>
        public static string ObtenerValorEnumeradoDeObjeto(Object objeto)
        {
            Type type = objeto.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                if (!(propertyInfo.GetType().IsEnum))
                {
                    string lala = propertyInfo.GetValue(objeto).ToString();
                    return lala;
                }
            }
            return null;
        }


        /// <summary>
        /// Valida si es string
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>true o false</returns>
        public static bool ValidacionString(string nombre)
        {
            char[] arr;
            arr = nombre.ToCharArray();
            if (!(string.IsNullOrWhiteSpace(nombre)))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((arr[i] < 65 || arr[i] > 90) && (arr[i] < 97 || arr[i] > 122) && (arr[i] < 48 || arr[i] > 57))
                    {
                        return false;

                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Revisa si el string tiene un espacio en blanco
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Devuelve true si hay espacio en blanco, sino false</returns>
        public static bool EspacioEnBlancoOVacio(string nombre)
        {
            if (!(string.IsNullOrWhiteSpace(nombre)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Valida si el string es numeros
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Devuelve true si es numero, sino false</returns>
        public static bool ValidateNumber(string number)
        {
            char[] arr;
            arr = number.ToCharArray();
            if (!(string.IsNullOrWhiteSpace(number)))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 48 || arr[i] > 57)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// COnvierte un punto en una coma de un string es inetnta parsearlo a double
        /// </summary>
        /// <param name="strInt"></param>
        /// <returns>Devuelve un string</returns>
        public static string PuntoToComa(string strInt)
        {
            double numero;
            strInt = strInt.Trim();
            string str = strInt;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '.')
                {
                    arr[i] = ',';
                    break;
                }
            }
            if (double.TryParse(arr, out numero))
            {
                numero = numero / 1;
                return strInt = new string(numero.ToString());
            }
            strInt = new string(arr);
            return strInt;
        }


        /// <summary>
        /// Valida si es decimal por medio de un string que recibe por parametro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>devuele true si es decimal, sino false </returns>
        public static bool ValidarDecimal(string numero)
        {
            try
            {
                double d = Convert.ToDouble(numero);
                if (d >= 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// Valida si el saldo disponible es mayor o igual al saldo a pagar
        /// </summary>
        /// <param name="saldoAPagar"></param>
        /// <param name="dineroDisponible"></param>
        public static void ValidaSaldoAPagar(string saldoAPagar, string dineroDisponible)
        {
            if (!(string.IsNullOrWhiteSpace(saldoAPagar)) && !(string.IsNullOrWhiteSpace(dineroDisponible)))
            {
                if (!(double.Parse(dineroDisponible) >= double.Parse(saldoAPagar)))
                {
                    ClienteSinDineroExcepcion clienteSinDineroExcepcion = new ClienteSinDineroExcepcion(message: "Saldo insuficiente para pagar");
                    throw clienteSinDineroExcepcion;
                }
            }
            else
            {
                ClienteSinDineroExcepcion clienteSinDineroExcepcion = new ClienteSinDineroExcepcion(message: "Error en el monto a pagar y/o en el dinero disponible");
                throw clienteSinDineroExcepcion;
            }
        }

    }
}

