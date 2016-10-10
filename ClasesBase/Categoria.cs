using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Categoria : INotifyPropertyChanged
    {
        private int cat_Id;

        public int Cat_Id
        {
            get { return cat_Id; }
            set { cat_Id = value; notifyChange(cat_Id.ToString()); }
        }

        private String cat_Descrip;

        public String Cat_Descrip
        {
            get { return cat_Descrip; }
            set { cat_Descrip = value; notifyChange(cat_Descrip); }
        }
        public Categoria()
        { }
        public Categoria(int cat_Id, String cat_Descrip)
        {
            this.cat_Id = cat_Id;
            this.cat_Descrip = cat_Descrip;            
        }

        public override string ToString()
        {
            return "Categoria: " + cat_Id + "\n" +
                "Descripcion: " + cat_Descrip;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void notifyChange(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
