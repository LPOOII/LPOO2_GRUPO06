using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Items_Factura
    {
        private int item_fac_id;

        public int Item_fac_id
        {
            get { return item_fac_id; }
            set { item_fac_id = value; }
        }
        private int fac_id;

        public int Fac_id
        {
            get { return fac_id; }
            set { fac_id = value; }
        }
        private int art_id;

        public int Art_id
        {
            get { return art_id; }
            set { art_id = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
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

        public Items_Factura()
        {
          
        }
    }
}
