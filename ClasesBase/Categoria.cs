using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Categoria
    {
        private int cat_id;

        public int Cat_id
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
        private String cat_descrip;

        public String Cat_descrip
        {
            get { return cat_descrip; }
            set { cat_descrip = value; }
        }

        public Categoria(int cat_id, String cat_descrip)
        {
            this.cat_descrip = cat_descrip;
            this.cat_id = cat_id;
        }

    }
}
