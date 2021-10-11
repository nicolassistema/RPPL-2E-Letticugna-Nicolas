﻿using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        #region "Atributos"
        int codigo;
        int codigoDos;
        string marca;
        string nombre;
        string descripcion;
        int cantidad;
        double precio;
        #endregion

        #region "Constructores"
        public Producto()
        {

        }

        public Producto(int codigoDos, string marca, string nombre, double precio) : this()
        {
            this.codigoDos = codigoDos;
            this.marca = marca;
            this.nombre = nombre;
            this.precio = precio;
        }

        public Producto(string marca, string nombre, string descripcion, double precio) : this()
        {

            this.Codigo = IdAutoIncremental();
            this.marca = marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }


        public Producto(string marca, string nombre, string descripcion, int cantidad, double precio) : this()
        {
            this.Codigo = IdAutoIncremental();
            this.marca = marca;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public Producto(string marca, string nombre, int cantidad, double precio) : this()
        {
            this.Codigo = IdAutoIncremental();
            this.nombre = nombre;
            this.marca = marca;
            this.cantidad = cantidad;
            this.precio = precio;
        }
        #endregion

        #region "Propiedades"


        /// <summary>
        /// Devuelve y setea el dato
        /// </summary>
        public int CodigoDos
        {
            get
            {
                return this.codigoDos;
            }
            set
            {
                this.codigoDos = value;
            }
        }

        /// <summary>
        /// Devuelve y setea el dato
        /// </summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        /// <summary>
        /// Devuelve y setea el dato
        /// </summary>
        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        /// <summary>
        /// Devuelve y setea el dato
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        /// <summary>
        /// Devuelve y setea el dato
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        /// <summary>
        /// Devuelve y setea el dato
        /// </summary>
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        /// <summary>
        /// Devuelve y setea el dato
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        #endregion

        #region "Operadores"
        /// <summary>
        ///  Verifica si el objeto  esta en la lista
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>devuelve verdadero en caso de que el objeto  este en la lista</returns>
        public static bool operator ==(List<Producto> productos, Producto producto)
        {
            foreach (Producto productoAux in productos)
            {
                if (producto == productoAux)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Verifica si el objeto no esta en la lista
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>devuelve verdadero en caso de que el objeto no este en la lista</returns>
        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }


        /// <summary>
        /// Agrega un objeto a la lista
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>Devueve la lista con el objeto agregado</returns>
        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            if (productos != producto)
            {
                productos.Add(producto);
                return productos;
            }
            else
            {
                return productos;
            }
        }

        /// <summary>
        /// Elimina el objeto de la lista
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>Devuelve la lista con el objeto eliminado</returns>
        public static List<Producto> operator -(List<Producto> productos, Producto producto)
        {
            if (productos == producto)
            {
                productos.Remove(producto);
                return productos;
            }
            else
            {
                return productos;
            }
        }
        #endregion

        #region "Utils"
        /// <summary>
        /// Muestra informacion del producto
        /// </summary>
        /// <returns>devuelve un striing con al informacion del prodcuto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($" {this.Nombre}             {this.Precio}");
            return sb.ToString();
        }


        /// <summary>
        /// genera un id autoincremenal
        /// </summary>
        /// <returns>devuelve el id autoincrementado</returns>
        public int IdAutoIncremental()
        {
         
                for (int i = 0; i <= PetShop.ObtenerPorductos().Count; i++)
                {
                    codigo = i + 1;
                }
          
            return codigo;
        }

        #endregion
    }
}
