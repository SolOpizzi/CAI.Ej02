using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Ej02
{
    internal class Ejercicio02Model
    {
        public string PrecioIngresado {  get; set; }
        public string AñoIngresado { get; set; }
        public string ModeloIngresado { get; set; }
        public string MarcaIngresada { get; set; }


        public string[] Marcas { get; } = new string[] {"Ford", "Fiat", "Chevrolet", "Audi"};

        //Funcion validar segundo apanich
        public string Validar()
        {


            //validar precio
            if(!decimal.TryParse(PrecioIngresado, out decimal precio))
            {
                return "El precio ingresado no es un valor decimal";
            }
            if (precio <= 0) //NO SE POR QUE ACA NO HACE ELSE IF - segun el porque mientras menos complicada la estructura, mejor
            {
                return "El precio debe ser mayor a cero";
            }

            //validar modelo 
            if (string.IsNullOrEmpty(ModeloIngresado))
            {
                return "El modelo es un dato que debe ser ingresado";
            }
            if(ModeloIngresado.Length > 30)
            {
                return "El modelo debe tener menos de 30 caracteres";
            }

            //validar año
            if(!int.TryParse(AñoIngresado, out int año))
            {
                return "El año ingresado no es un numero valido";
            }
            if(año < 2000 || año > 2021)
            {
                return "El año debe ser entre 2001 y 2021";
            }

            //validar marca (OJO QUE ES COMBO BOX)
            if (string.IsNullOrEmpty(MarcaIngresada)) //aca lo está validando desde el objeto creado y no del combo box
            {
                return "Debe seleccionar una marca";
            }

            return "Ok";
        }



        //mostrar nombre de usuario y fecha
        public string NombreUsuario { get; } = "kitty";
        public string NombreReal { get; } = "Sol Opizzi";

        public DateTime FechaActual { get; } = DateTime.Now;
    }

}
