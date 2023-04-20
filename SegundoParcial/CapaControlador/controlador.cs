using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Forms;
//using CapaModelo;

namespace CapaControlador
{
    class controlador
    {
        //sentencias sn = new sentencias();
        //public void ast(TextBox[] textBoxs, string funcion)
        //{
        //    string sql = string.Empty;
        //    string colTemp = "";
        //    string valTemp = "";
        //    foreach (TextBox textBox in textBoxs)
        //    {
        //        string columna = textBox.Tag.ToString();
        //        string valor = textBox.Text;
        //        switch (func)
        //        {
        //            case "insert":
        //                colTemp = colTemp + columna + ",";
        //                valTemp = valTemp + "'" + valor + "',";
        //                break;

        //            case "delete":
        //                break;

        //            case "update":
        //                sql += columna + " = '" + valor + "', ";
        //                break;
        //        }
        //    }
        //    if (!string.IsNullOrEmpty(sql))
        //    {
        //        sql = sql.Substring(0, sql.Length - 2);
        //    }

        //    if (!string.IsNullOrEmpty(columnasTemp))
        //    {
        //        colTemp = colTemp.Substring(0, colTemp.Length - 1);
        //        valTemp = valTemp.Substring(0, valTemp.Length - 1);
        //    }
        //    switch (funcion)
        //    {
        //        case "insert":
        //            sql = "insert into usuarios (" + colTemp + ") values(" + valTemp + ");";
        //            sentencias.ejecutarSentecias(sql);
        //            break;

        //        case "delete":
        //            sql = "DELETE FROM usuarios WHERE id = '" + textBoxs[0].Text + "';";
        //            sentencias.ejecutarSentecias(sql);
        //            break;

        //        case "update":
        //            sql = "UPDATE INTO usuarios SET " + sql + " WHERE id='" + textBoxs[0].Text + "';";
        //            sentencias.ejecutarSentecias(sql);
        //            break;
    }
}
