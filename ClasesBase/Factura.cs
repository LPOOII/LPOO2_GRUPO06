using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Factura
    {
        private int fac_id;

        public int Fac_id
        {
            get { return fac_id; }
            set { fac_id = value; }
        }
        private int ped_id;

        public int Ped_id
        {
            get { return ped_id; }
            set { ped_id = value; }
        }
        private int cli_id;

        public int Cli_id
        {
            get { return cli_id; }
            set { cli_id = value; }
        }
        private int fac_numero;

        public int Fac_numero
        {
            get { return fac_numero; }
            set { fac_numero = value; }
        }

        
        private DateTime fac_fecha;

        public DateTime Fac_fecha
        {
            get { return fac_fecha; }
            set { fac_fecha = value; }
        }
        private int fp_id;

        public int Fp_id
        {
            get { return fp_id; }
            set { fp_id = value; }
        }

        

        public Factura()
        {
            
        }
    }
}
