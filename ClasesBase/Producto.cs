using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
        private int pro_Id;

        public int Pro_Id
        {
            get { return pro_Id; }
            set { pro_Id = value; }
        }

        private decimal total_Materia_Prima;

        public decimal Total_Materia_Prima
        {
            get { return total_Materia_Prima; }
            set { total_Materia_Prima = value; }
        }

       

        private decimal total_Otros_Costos;

        public decimal Total_Otros_Costos
        {
            get { return total_Otros_Costos; }
            set { total_Otros_Costos = value; }
        }
        private decimal costo_Final;

        public decimal Costo_Final
        {
            get { return costo_Final; }
            set { costo_Final = value; }
        }

        private int art_Id;

        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }
        public Producto() { }


    }
}
