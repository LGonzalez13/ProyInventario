using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyControlInv
{
    class Inventario
    {
        private Producto[] inventario;
        private int numProductos;
        
        public Inventario()
        {
            inventario = new Producto[20];
            for (int i = 0; i < 20; i++)
                inventario[i] = null;
            numProductos = 0;
        }

        public void agregar(Producto p)
        {
            if(numProductos<20)
                inventario[numProductos++] = p;
        }

        public Producto buscar(string nombre)
        {
            Producto p = inventario[0];
            for(int i=0;i<numProductos;i++)
                if(nombre==inventario[i].nombre)
                {
                    p = inventario[i];
                    break;
                }
                else
                {
                    p = null;
                }
            return p;
            
                    
        }

        public void eliminar(string nombre)
        {
            for (int i = 0; i < numProductos; i++)
                if (nombre == inventario[i].nombre)
                {
                    for (int j = i + 1; j < numProductos; j++)
                    {
                        inventario[i - 1] = inventario[i];
                    }
                    inventario[numProductos--] = null;

                    break;
                }
        }

        public string reporte()
        {
            string reporte = "";
            for(int i=0;i<numProductos;i++)
            {
                reporte += inventario[i].ToString() + Environment.NewLine + Environment.NewLine;
            }
            return reporte;
        }



        public override string ToString()
        {
            return numProductos.ToString();
        }
    }
}
