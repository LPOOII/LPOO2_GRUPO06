using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Articulo
    {
        private int art_Id;

        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }
        private string art_Descrip;

        public string Art_Descrip
        {
            get { return art_Descrip; }
            set { art_Descrip = value; }
        }
        private int fam_Id;//

        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }
        private int um_Id;//

        public int Um_Id
        {
            get { return um_Id; }
            set { um_Id = value; }
        }
        private decimal art_Costo;

        public decimal Art_Costo
        {
            get { return art_Costo; }
            set { art_Costo = value; }
        }
        private decimal art_Margen_Beneficio;

        public decimal Art_Margen_Beneficio
        {
            get { return art_Margen_Beneficio; }
            set { art_Margen_Beneficio = value; }
        }
        private decimal art_Precio;

        public decimal Art_Precio
        {
            get { return art_Precio; }
            set { art_Precio = value; }
        }
        private decimal art_Stock_Min;

        public decimal Art_Stock_Min
        {
            get { return art_Stock_Min; }
            set { art_Stock_Min = value; }
        }
        private decimal art_Stock_Max;

        public decimal Art_Stock_Max
        {
            get { return art_Stock_Max; }
            set { art_Stock_Max = value; }
        }
        private decimal art_Stock_Reposicion;

        public decimal Art_Stock_Reposicion
        {
            get { return art_Stock_Reposicion; }
            set { art_Stock_Reposicion = value; }
        }
        private decimal art_Stock_Actual;

        public decimal Art_Stock_Actual
        {
            get { return art_Stock_Actual; }
            set { art_Stock_Actual = value; }
        }
        private Boolean art_Maneja_Stock;

        public Boolean Art_Maneja_Stock
        {
            get { return art_Maneja_Stock; }
            set { art_Maneja_Stock = value; }
        }

        //contructores
        public Articulo() { }
        public Articulo(int art_Id, int fam_Id, int um_Id, decimal art_Costo, decimal art_Margen_Beneficio, decimal art_Precio, decimal art_Stock_Min,
                         decimal art_Stock_Reposicion, decimal art_Stock_Actual, Boolean art_Maneja_Stock)
        {
            this.art_Id = art_Id;
            this.fam_Id = fam_Id;
            this.um_Id = um_Id;
            this.art_Costo = art_Costo;
            this.art_Margen_Beneficio = art_Margen_Beneficio;
            this.art_Precio = art_Precio;
            this.art_Stock_Min = art_Stock_Min;
            this.art_Stock_Reposicion = art_Stock_Reposicion;
            this.art_Stock_Actual = art_Stock_Actual;
            this.art_Maneja_Stock = art_Maneja_Stock;
        }

        //con 12 argumentos , item orden d compra
        public Articulo(int art_Id, int fam_Id, int um_Id, decimal art_Costo, decimal art_Margen_Beneficio, decimal art_Precio, decimal art_Stock_Min,
                         decimal art_Stock_Reposicion, decimal art_Stock_Actual, Boolean art_Maneja_Stock, string art_Descrip, decimal art_Stock_Max)
        {
            this.Art_Id = art_Id;
            this.Fam_Id = fam_Id;
            this.Um_Id = um_Id;
            this.Art_Costo = art_Costo;
            this.Art_Margen_Beneficio = art_Margen_Beneficio;
            this.Art_Precio = art_Precio;
            this.Art_Stock_Min = art_Stock_Min;
            this.Art_Stock_Reposicion = art_Stock_Reposicion;
            this.Art_Stock_Actual = art_Stock_Actual;
            this.Art_Maneja_Stock = art_Maneja_Stock;
            this.Art_Descrip = art_Descrip;
            this.Art_Stock_Max = art_Stock_Max;
        }

    }
}
