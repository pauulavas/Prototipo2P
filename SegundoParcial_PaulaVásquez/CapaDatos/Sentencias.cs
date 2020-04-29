using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Sentencias
    {

        Conexion cn = new Conexion();
        OdbcCommand comm;
        //----------------------------------------------------INSERTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar1(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into maestros values(" + uno + ", '" + dos + "' ,'" + tres + "','" + cuatro + "' ,'" + cinco + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- MODIFICAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar1(string uno, string dos, string tres, string cuatro, string cinco, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE maestros set nombre_maestro='" + dos + "',direccion_maestro='" + tres + "',telefono_maestro='" + cuatro + "',email_maestro='" + cinco + "',estatus_maestro='" + sestado + "' where codigo_maestro='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- ELIMINAR UNO -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar1(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE maestros set estatus_maestro ='0' where codigo_maestro='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------- CONSULTAR UNO ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta1(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from maestros;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //----------------------------------------------------INSERTAR DOS ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar2(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into aulas values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR DOS ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar2(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE aulas set nombre_aula='" + dos + "',estatus_aula='" + sestado + "' where codigo_aula='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- ELIMINAR DOS -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar2(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE aulas set estatus_aula ='0' where codigo_aula='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- CONSULTAR DOS ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta2(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from aulas  where estatus_aula = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //----------------------------------------------------INSERTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar3(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into cursos values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar3(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE cursos set nombre_curso='" + dos + "',estatus_curso='" + sestado + "' where codigo_curso='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- ELIMINAR TRES -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar3(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE cusos set estatus_curso ='0' where codigo_curso='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- CONSULTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta3(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from cursos where estatus_curso = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
            //------------------------------------------------------------------------------------------------------------------------------------------------------------
            //CUATRO
            //----------------------------------------------------INSERTAR TRES ------------------------------------------------------------------------------------------
            public OdbcDataReader guardar4(string uno, string dos, string sestado)
            {
                try
                {
                    cn.conexionbd();
                    string consulta = "insert into facultades values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                    comm = new OdbcCommand(consulta, cn.conexionbd());
                    OdbcDataReader mostrar = comm.ExecuteReader();
                    return mostrar;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return null;
                }
            }

            //--------------------------------------------------- MODIFICAR TRES ------------------------------------------------------------------------------------------
            public OdbcDataReader modificar4(string uno, string dos, string sestado)
            {
                try
                {
                    cn.conexionbd();
                    string consulta = "UPDATE facultades set nombre_facultad='" + dos + "',estatus_facultad='" + sestado + "' where codigo_facultad='" + uno + "';";
                    comm = new OdbcCommand(consulta, cn.conexionbd());
                    OdbcDataReader mostrar = comm.ExecuteReader();
                    return mostrar;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return null;
                }
            }

            //--------------------------------------------------- ELIMINAR TRES -------------------------------------------------------------------------------------------
            public OdbcDataReader eliminar4(string uno)
            {
                try
                {
                    cn.conexionbd();
                    string consulta = "UPDATE facultades set estatus_facultad ='0' where codigo_facultad='" + uno + "';";
                    comm = new OdbcCommand(consulta, cn.conexionbd());
                    OdbcDataReader mostrar = comm.ExecuteReader();
                    return mostrar;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return null;
                }
            }

        //--------------------------------------------------- CONSULTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta4(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from facultades where estatus_facultad = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //CCINCO
        //----------------------------------------------------INSERTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar5(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into jornadas values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar5(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE jornadas set nombre_jornada='" + dos + "',estatus_jornada='" + sestado + "' where codigo_jornada='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- ELIMINAR TRES -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar5(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE jornadas set estatus_jornada ='0' where codigo_jornada='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- CONSULTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta5(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from jornadas where estatus_jornada = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //SEIS
        //----------------------------------------------------INSERTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar6(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into secciones values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar6(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE secciones set nombre_seccion='" + dos + "',estatus_seccion='" + sestado + "' where codigo_seccion='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- ELIMINAR TRES -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar6(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE secciones set estatus_seccion ='0' where codigo_seccion='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- CONSULTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta6(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from secciones where estatus_seccion = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //SIETE
        //----------------------------------------------------INSERTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader guardar7(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into sedes values(" + uno + ", '" + dos + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- MODIFICAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader modificar7(string uno, string dos, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sedes set nombre_sede='" + dos + "',estatus_sede='" + sestado + "' where codigo_sede='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- ELIMINAR TRES -------------------------------------------------------------------------------------------
        public OdbcDataReader eliminar7(string uno)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sedes set estatus_sede ='0' where codigo_sede='" + uno + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------- CONSULTAR TRES ------------------------------------------------------------------------------------------
        public OdbcDataReader consulta7(string uno)
        {


            try
            {
                cn.conexionbd();
                string consulta = "select * from sedes where estatus_sede = '1';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------



    }
}


