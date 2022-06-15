using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR
{
    

    public class ClassDetalle
    {

        private string numFactura;
        private string nombreProducto;
        private int cantidad;
        private float precio;
        private float subTotal = 0;
        int idPlatillo;


        public ClassDetalle()
        {
            nombreProducto = "";
            cantidad=0;
            precio = 0;
            subTotal = 0;
            idPlatillo = 0;
        }

     

        public string NumFactura { get { return numFactura; } set {numFactura = value;} }
        public string NombreProducto { get { return nombreProducto; } set { nombreProducto = value; } } 
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public float Precio { get { return precio; } set { precio = value; } }
        public int IdPlatillo { get { return idPlatillo; } set { idPlatillo = value; } }
        public float SubTotal { get { return subTotal; } set { subTotal=value; } }
        
        public void calcularSub()
        {
            SubTotal = Cantidad * Precio;
        }

    }

    
}
