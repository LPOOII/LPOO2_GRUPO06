using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proveedor
    {
        private int prov_Id;

        public int Prov_Id
        {
            get { return prov_Id; }
            set { prov_Id = value; }
        }
        private string prov_Nombre;

        public string Prov_Nombre
        {
            get { return prov_Nombre; }
            set { prov_Nombre = value; }
        }
        private string prov_Domicilio;

        public string Prov_Domicilio
        {
            get { return prov_Domicilio; }
            set { prov_Domicilio = value; }
        }
        private string prov_Departamento;

        public string Prov_Departamento
        {
            get { return prov_Departamento; }
            set { prov_Departamento = value; }
        }
        private string prov_Codigo_Postal;

        public string Prov_Codigo_Postal
        {
            get { return prov_Codigo_Postal; }
            set { prov_Codigo_Postal = value; }
        }
        private string prov_Telefono;

        public string Prov_Telefono
        {
            get { return prov_Telefono; }
            set { prov_Telefono = value; }
        }
        private string prov_Email;

        public string Prov_Email
        {
            get { return prov_Email; }
            set { prov_Email = value; }
        }

        //contructores
        public Proveedor() { }
        public Proveedor(
            int prov_Id,
            string prov_Nombre,
            string prov_Domicilio,
            string prov_Departamento,
            string prov_Codigo_Postal,
            string prov_Telefono,
            string prov_Email)
        {

            this.prov_Id = prov_Id;
            this.prov_Nombre = prov_Nombre;
            this.prov_Domicilio = prov_Domicilio;
            this.prov_Departamento = prov_Departamento;
            this.prov_Codigo_Postal = prov_Codigo_Postal;
            this.prov_Telefono = prov_Telefono;
            this.prov_Email = prov_Email;
        }

    }
}
