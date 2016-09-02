using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Items_Orden_Compra
    {
        private int item_oc_id;

        public int Item_oc_id
        {
            get { return item_oc_id; }
            set { item_oc_id = value; }
        }
        private int oc_id;

        public int Oc_id
        {
            get { return oc_id; }
            set { oc_id = value; }
        }
        private int art_id;

        public int Art_id
        {
            get { return art_id; }
            set { art_id = value; }
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

        public Items_Orden_Compra()
        {
 
        }

    }
}
