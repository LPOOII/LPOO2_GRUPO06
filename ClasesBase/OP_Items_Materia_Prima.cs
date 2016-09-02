using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class OP_Items_Materia_Prima
    {
        private int op_Item_Mp_Id;

        public int Op_Item_Mp_Id
        {
            get { return op_Item_Mp_Id; }
            set { op_Item_Mp_Id = value; }
        }

        
        private int op_Id;

        public int Op_Id
        {
            get { return op_Id; }
            set { op_Id = value; }
        }

        
        private int art_Id;

        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }

       
        private decimal costo;

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        
        public OP_Items_Materia_Prima()
        {
        }
    }
}
