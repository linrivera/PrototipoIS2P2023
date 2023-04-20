﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CapaModelo_Alumnod;

namespace CapaControlador_Alumnos
{
    public class controlador
    {
        CapaModelo_Alumnod.Sentencias sn = new CapaModelo_Alumnod.Sentencias();

        public void ast(TextBox[] textBoxs, string fun)
        {
            string sql = string.Empty;
            string colTemp = "";
            string valTemp = "";
            foreach (TextBox textBox in textBoxs)
            {
                string columna = textBox.Tag.ToString();
                string valor = textBox.Text;
                switch (fun)
                {
                    case "insert":
                        colTemp = colTemp + columna + ",";
                        valTemp = valTemp + "'" + valor + "',";
                        break;

                    case "delete":
                        break;

                    case "update":
                        sql += columna + " = '" + valor + "', ";
                        break;
                }
            }
            if (!string.IsNullOrEmpty(sql))
            {
                sql = sql.Substring(0, sql.Length - 2);
            }

            if (!string.IsNullOrEmpty(colTemp))
            {
                colTemp = colTemp.Substring(0, colTemp.Length - 1);
                valTemp = valTemp.Substring(0, valTemp.Length - 1);
            }
            switch (fun)
            {
                case "insert":
                    sql = "insert into usuarios (" + colTemp + ") values(" + valTemp + ");";
                    sn.ejecutarSentecias(sql);
                    break;

                case "delete":
                    sql = "DELETE FROM usuarios WHERE id = '" + textBoxs[0].Text + "';";
                    sn.ejecutarSentecias(sql);
                    break;

                case "update":
                    sql = "UPDATE INTO usuarios SET " + sql + " WHERE id='" + textBoxs[0].Text + "';";
                    sn.ejecutarSentecias(sql);
                    break;
            }
        }
    }
}
