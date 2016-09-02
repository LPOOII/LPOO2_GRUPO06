using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Familia
    {
        private int fam_Id;

        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }
        private string fam_Descrip;

        public string Fam_Descrip
        {
            get { return fam_Descrip; }
            set { fam_Descrip = value; }
        }
        //contructores
        public Familia() { }
        public Familia(int fam_Id, string fam_Descrip)
        {
            this.fam_Id = fam_Id;
            this.fam_Descrip = fam_Descrip;
        }

    }
}
