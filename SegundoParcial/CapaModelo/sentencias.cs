﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Alumnod
{
    public class Sentencias
    {
        conexion con = new conexion();

        public OdbcDataAdapter DisplayAlumnos()
        {
            string sql = "SELECT * FROM alumnos ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, con.Conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla Alumnos");
            }
            return dataTable;
        }
        public void ejecutarSentecias(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.Conexion());
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("error con la setencias" + sql + "\n" + e);
            }
        }
    }
}

