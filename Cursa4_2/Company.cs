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
   public class Company : Base
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public Company() : base()
        {
            TableName = "COMPANY";
            cmd.Parameters.Add("@NAME", FbDbType.VarChar, 50, "NAME");
            cmd.Parameters.Add("@CREATION_DATE", FbDbType.Date, 50, "CREATION_DATE");
        }



        protected override void FillFields()
        {
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@name"].Value = Name;
            cmd.Parameters["@creation_date"].Value = CreationDate;
        }

        protected override string InsertSQL()
        {
            return "insert into COMPANY(id,name,creation_date,id_department) values(@ID, @Name, @CreationDate, @Id_Department)";
               
        }

        protected override string UpdateSQL()
        {
            return "update COMPANY set name=@name, creation_date=@creation_date, where id=@id";
        }

        public override void FieldsFromReader(FbDataReader R)
        {
            ID = Guid.Parse(R["ID"].ToString());
            Name = R["Name"].ToString();
            CreationDate = DateTime.Parse(R["CREATION_DATE"].ToString());
        }
    }
}
