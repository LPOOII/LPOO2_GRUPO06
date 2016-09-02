using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Unidad_Medida
    {
        private int um_Id;

        public int Um_Id
        {
            get { return um_Id; }
            set { um_Id = value; }
        }
        private string um_Descrip;

        public string Um_Descrip
        {
            get { return um_Descrip; }
            set { um_Descrip = value; }
        }
        private string um_Abrev;

        public string Um_Abrev
        {
            get { return um_Abrev; }
            set { um_Abrev = value; }
        }

        //contructores
        public Unidad_Medida() { }

        public Unidad_Medida(int um_Id, string um_Descrip, string um_Abrev)
        {
            this.um_Id = um_Id;
            this.um_Descrip = um_Descrip;
            this.um_Abrev = um_Abrev;


        }

    }
}
