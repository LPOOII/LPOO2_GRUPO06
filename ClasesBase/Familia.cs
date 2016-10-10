using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace ClasesBase
{
    public class Familia : INotifyPropertyChanged
    {
        private int fam_Id;

        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; notifyChange(fam_Id.ToString()); }
        }
        private string fam_Descrip;

        public string Fam_Descrip
        {
            get { return fam_Descrip; }
            set { fam_Descrip = value; notifyChange(fam_Descrip); }
        }
        //contructores
        public Familia() { }
        public Familia(int fam_Id, string fam_Descrip)
        {
            this.fam_Id = fam_Id;
            this.fam_Descrip = fam_Descrip;
        }

       

        public override string ToString()
        {
            return "Familia: " + Fam_Id + "\n" +
                "Descripcion: " + fam_Descrip;
        }




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
