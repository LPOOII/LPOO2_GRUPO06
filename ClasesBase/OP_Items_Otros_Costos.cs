using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class OP_Items_Otros_Costos
    {
        private int op_Item_oc_id;

        public int Op_Item_oc_id
        {
            get { return op_Item_oc_id; }
            set { op_Item_oc_id = value; }
        }
        private int op_Id;

        public int Op_Id
        {
            get { return op_Id; }
            set { op_Id = value; }
        }
        private int oc_Id;

        public int Oc_Id
        {
            get { return oc_Id; }
            set { oc_Id = value; }
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
        public OP_Items_Otros_Costos()
        { }

    }
}
