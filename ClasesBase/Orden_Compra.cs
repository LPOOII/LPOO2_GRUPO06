using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Orden_Compra
    {
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
        private DateTime oc_fecha;

        public DateTime Oc_fecha
        {
            get { return oc_fecha; }
            set { oc_fecha = value; }
        }
        private Boolean pagada;

        public Boolean Pagada
        {
            get { return pagada; }
            set { pagada = value; }
        }

        public Orden_Compra()
        { }
    }
}
