using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Orden_Pago
    {
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
        private int prov_Id;

        public int Prov_Id
        {
            get { return prov_Id; }
            set { prov_Id = value; }
        }
        private DateTime op_Fecha;

        public DateTime Op_Fecha
        {
            get { return op_Fecha; }
            set { op_Fecha = value; }
        }
        private decimal op_Importe;

        public decimal Op_Importe
        {
            get { return op_Importe; }
            set { op_Importe = value; }
        }

        public Orden_Pago() { }


    }
}
