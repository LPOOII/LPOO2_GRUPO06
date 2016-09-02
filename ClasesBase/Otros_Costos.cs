using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Otros_Costos
    {
        private int oc_id;

        public int Oc_id
        {
            get { return oc_id; }
            set { oc_id = value; }
        }
        private string oc_descrip;

        public string Oc_descrip
        {
            get { return oc_descrip; }
            set { oc_descrip = value; }
        }
        private int um_id;

        public int Um_id
        {
            get { return um_id; }
            set { um_id = value; }
        }
        private decimal oc_costo;

        public decimal Oc_costo
        {
            get { return oc_costo; }
            set { oc_costo = value; }
        }
        private string oc_observaciones;

        public string Oc_observaciones
        {
            get { return oc_observaciones; }
            set { oc_observaciones = value; }
        }
    }
}
