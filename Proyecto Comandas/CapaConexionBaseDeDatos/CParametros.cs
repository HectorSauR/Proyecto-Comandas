using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaConexionBaseDeDatos
{
    class CParametros
    {
        //-- ** Atributos de un Parametro
        private String _Nom;
        private Object _Val;
        private SqlDbType _TDato;
        private Int32 _Tam;
        private ParameterDirection _Dir;

        //-- ** Propiedades (Caracteristicas que todo Parametro Contiene)

        public string Nom { get => _Nom; set => _Nom = value; }
        public object Val { get => _Val; set => _Val = value; }
        public SqlDbType TDato { get => _TDato; set => _TDato = value; }
        public int Tam { get => _Tam; set => _Tam = value; }
        public ParameterDirection Dir { get => _Dir; set => _Dir = value; }

        //-- ** Contructores

        // Constructor de Entrada
        public listParam(string ObjNom, Object ObjVal)
        {
            Nom = ObjNom;
            Val = ObjVal;
            Dir = ParameterDirection.Input;
        }
        // Constructor de salida
        public listParam(String ObjNom, SqlDbType ObjTDato, Int32 Objtam)
        {
            Nom = ObjNom;
            TDato = ObjTDato;
            Tam = Objtam;
            Dir = ParameterDirection.Output;
        }
    }
}
