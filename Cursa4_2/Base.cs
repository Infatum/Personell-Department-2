using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Cursa4_2
{
    public delegate void WorkData(FbDataReader Data);

    abstract public class Base
    {
        protected string TableName;
        public Guid ID{ get; set; }
        protected FbCommand cmd;

        protected abstract void FillFields();
        protected abstract string InsertSQL();
        protected abstract string UpdateSQL();
        public abstract void FieldsFromReader(FbDataReader R);

        public static string ConnectionString;

        public Base()
        {
            ID = Guid.Empty;
            cmd = new FbCommand();
            cmd.Parameters.Add("@id", FbDbType.Char, 36);
        }

        public void Modify()
        {
            if (ID == Guid.Empty)
            {
                ID = Guid.NewGuid();
                cmd.CommandText = InsertSQL();
            }
            else
                cmd.CommandText = UpdateSQL();
            FillFields();
            using (cmd.Connection = new FbConnection(ConnectionString))
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete()
        {
            cmd.CommandText = DeleteSQL();
            using (cmd.Connection = new FbConnection(ConnectionString))
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        
        public string DeleteSQL()
        {
            return string.Format("delete from {0} where id={1}", TableName, ID);
        }
        
        public void SelectOne(Guid id)
        {
            ID = id;
            cmd.CommandText = string.Format("select * from {0} where id = '{1}'", TableName, ID);//cmd.CommandText = $"(select * from {TableName} where id = '{ID}')"
            using (cmd.Connection = new FbConnection(ConnectionString))
            {
                cmd.Connection.Open();
                FbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                FieldsFromReader(dr);
            }
        }

        static public void Select(string SQL, WorkData WD)
        {
            FbCommand cmd = new FbCommand(SQL);
            using (cmd.Connection = new FbConnection(ConnectionString))
            {
                cmd.Connection.Open();
                FbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    WD(dr);
                }
            }
        }
}
}