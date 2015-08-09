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
    public class Department : Base
    {
        public static BindingList<Department> data = new BindingList<Department>();
        public string Name { get; set; }
        public int Code { get; set; }
        public Company Company { get; set; }

        public Department() : base()
        {
            TableName = "DEPARTMENT";
            cmd.Parameters.Add("@NAME", FbDbType.VarChar, 20, "NAME");
            cmd.Parameters.Add("@CODE", FbDbType.SmallInt, 50, "CODE");
            cmd.Parameters.Add("@ID_COMPANY", FbDbType.Char, 38, "ID_COMPANY");
        }
        
        public Department(FbDataReader R):this()
        {
            FieldsFromReader(R);
        }

        protected override void FillFields()
        {
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@name"].Value = Name;
            cmd.Parameters["@code"].Value = Code;
            cmd.Parameters["@ID_COMPANY"].Value = Company.ID;
        }

        protected override string InsertSQL()
        {
            return "insert into DEPARTMENT(id,name,Code,ID_COMPANY) values(@ID, @Name, @Code,@ID_COMPANY)";
        }

        protected override string UpdateSQL()
        {
            return "update DEPARTMENT set name=@NAME,Code=@CODE, ID_COMPANY=@ID_COMPANY where id=@ID";
        }

        public override void FieldsFromReader(FbDataReader R)
        {
            ID = Guid.Parse(R["ID"].ToString());
            Code = Int32.Parse(R["Code"].ToString());
            Name = R["Name"].ToString();
        }

        public override string ToString()
        {
            return Code.ToString() + "-" + Name;
        }
    }
}

