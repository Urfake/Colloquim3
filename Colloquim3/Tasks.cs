using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Tasks
{
    public Tasks() { }
    public DataTable getTable(string data)
    {
        String constring = "Server=localhost;database = Furniture; port=5432; username=postgres; password=postgres";
        NpgsqlConnection conDataBase = new NpgsqlConnection(constring);
        conDataBase.Open();
        var query = "SELECT \"Id\" as Номер, \"Name\" as Имя, \"Description\" as Описание, \"Price\" as Цена FROM public.\"" + data+"\"";

        NpgsqlDataAdapter sda = new NpgsqlDataAdapter(query, conDataBase);

        DataTable dt = new DataTable();
        sda.Fill(dt);

        return dt;
    }
}
