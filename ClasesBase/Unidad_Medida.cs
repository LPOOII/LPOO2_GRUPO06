using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Unidad_Medida : INotifyPropertyChanged
    {
        private int um_Id;

        public int Um_Id
        {
            get { return um_Id; }
            set { um_Id = value; notifyChange(um_Id.ToString()); }
        }
        private string um_Descrip;

        public string Um_Descrip
        {
            get { return um_Descrip; }
            set { um_Descrip = value; notifyChange(um_Descrip); }
        }
        private string um_Abrev;

        public string Um_Abrev
        {
            get { return um_Abrev; }
            set { um_Abrev = value; notifyChange(um_Abrev); }
        }

        //contructores
        public Unidad_Medida() { }

        public Unidad_Medida(int um_Id, string um_Descrip, string um_Abrev)
        {
            this.um_Id = um_Id;
            this.um_Descrip = um_Descrip;
            this.um_Abrev = um_Abrev;


        }

        public override string ToString()
        {
            return "Unidad de medida: " + Um_Id + "\n" +
                "Descripcion: " + Um_Descrip + "\n" +
                "Abreviatura: " + Um_Abrev;
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
