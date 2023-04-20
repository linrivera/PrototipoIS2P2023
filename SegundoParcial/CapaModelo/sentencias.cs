using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    class sentencias
    {
        public class Sentencias
        {
            conexion con = new conexion();
            public OdbcDataAdapter llenarcomboproducto(string tabla)
            {
                string sql = "select  *  from " + tabla + " ;";
                OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.Conexion());

                return datatable;
            }
        }
    }
