using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Articulo : INotifyPropertyChanged
    {
        private int art_Id;
        private string art_Descrip;
        private Familia fam_Id;
        private Unidad_Medida um_Id;
        private Categoria categoria;
        private decimal art_Costo;
        private decimal art_Margen_Beneficio;
        private decimal art_Precio;
        private decimal art_Stock_Min;
        private decimal art_Stock_Max;
        private decimal art_Stock_Reposicion;
        private decimal art_Stock_Actual;
        private Boolean art_Maneja_Stock;

        public Categoria Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
                notifyChange("categoria");
            }
        }

        public Unidad_Medida Unidad_Medida
        {
            get
            {
                return um_Id;
            }
            set
            {
                um_Id = value;
                notifyChange("um_Id");
            }
        }

        public Familia Familia
        {
            get
            {
                return fam_Id;
            }
            set
            {
                fam_Id = value;
                notifyChange("fam_Id");
            }
        }

        public int Art_Id
        {
            get { return art_Id; }
            set 
            { 
                art_Id = value;
                notifyChange(art_Id.ToString());
            }
        }        

        public string Art_Descrip
        {
            get { return art_Descrip; }
            set 
            {
                art_Descrip = value;
                notifyChange(art_Descrip);
            }
        }        
                
        public decimal Art_Costo
        {
            get { return art_Costo; }
            set 
            {
                art_Costo = value;
                notifyChange(art_Costo.ToString());
            }
        }        

        public decimal Art_Margen_Beneficio
        {
            get { return art_Margen_Beneficio; }
            set 
            {
                art_Margen_Beneficio = value;
                notifyChange(art_Margen_Beneficio.ToString());
            }
        }        

        public decimal Art_Precio
        {
            get { return art_Precio; }
            set
            { 
                art_Precio = value;
                notifyChange(art_Precio.ToString());
            }
        }        
        
        public decimal Art_Stock_Min
        {
            get { return art_Stock_Min; }
            set 
            {
                art_Stock_Min = value;
                notifyChange(art_Stock_Min.ToString());
            }
        }        

        public decimal Art_Stock_Max
        {
            get { return art_Stock_Max; }
            set 
            { 
                art_Stock_Max = value;
                notifyChange(art_Stock_Max.ToString());
            }
        }        

        public decimal Art_Stock_Reposicion
        {
            get { return art_Stock_Reposicion; }
            set 
            {
                art_Stock_Reposicion = value;
                notifyChange(art_Stock_Reposicion.ToString());
            }
        }        

        public decimal Art_Stock_Actual
        {
            get { return art_Stock_Actual; }
            set 
            { 
                art_Stock_Actual = value;
                notifyChange(art_Stock_Actual.ToString());
            }
        }        

        public Boolean Art_Maneja_Stock
        {
            get { return art_Maneja_Stock; }
            set 
            {
                art_Maneja_Stock = value;
                notifyChange(art_Maneja_Stock.ToString());
            }
        }

        //contructores
        public Articulo() { }
        public Articulo(int art_Id, Familia fam_Id, Unidad_Medida um_Id, decimal art_Costo, decimal art_Margen_Beneficio, decimal art_Precio, decimal art_Stock_Min,
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
        public Articulo(int art_Id, Familia fam_Id, Unidad_Medida um_Id, decimal art_Costo, decimal art_Margen_Beneficio, decimal art_Precio, decimal art_Stock_Min,
                         decimal art_Stock_Reposicion, decimal art_Stock_Actual, Boolean art_Maneja_Stock, string art_Descrip, decimal art_Stock_Max)
        {
            this.Art_Id = art_Id;
            this.Familia = fam_Id;
            this.Unidad_Medida = um_Id;
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

        public override string ToString()
        {
            return "Articulo: " + Art_Id + "\n" +
                "Descripcion: "+ Art_Descrip +  "\n" +
                "Costo: " + Art_Costo;
        }

        /// <summary>
        /// Interfaz para controlar cambios de estado del objeto.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Metodo encargado de controlar los cambios de propiedades
        /// </summary>
        /// <param name="property"></param>
        public void notifyChange(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

       

    }
}
