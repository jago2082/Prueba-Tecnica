using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Prueba_Tecnica.Consultas
{
    public class Conexion
    {
        public NpgsqlDataReader FindUser(string numdoc)
        {

            NpgsqlDataReader reader = null;

            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
                conexion.Open();
                NpgsqlCommand comand = new NpgsqlCommand("SELECT d.nombre,c.numerodocumento ,c.primerapellido || ' ' || c.segundoapellido as Apellidos, c.primernombre || ' ' || c.segundonombre as Nombres,c.idcontrato, ca.nombre, r.valor, c.fechainicio, " +
                " c.fechafin, c.salario"
                + " from contratoslaborales as c "
                + " inner join tipodocumento as d "
                + " on d.idtipodocumento = c.idtipodocumento "
                + " inner join cargos as ca "
                + " on ca.idcargo = c.idcargo "
                + " inner join arl as r "
                + " on r.idarl = c.idarl "
                + " where c.numerodocumento = " + numdoc + "", conexion);
                reader = comand.ExecuteReader();
                conexion.Close();
                
            }
            catch (Exception)
            {

                return reader;
            }

            return reader;
        }

    }
}