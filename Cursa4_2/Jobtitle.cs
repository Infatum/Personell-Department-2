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
    public class Jobtitle : Base
    {
        public static BindingList<Jobtitle> data = new BindingList<Jobtitle>();
        public int Code { get; set; }
        public string Name { get; set; }
        public decimal Sallary { get; set; }
        public decimal Dollar_per_hour { get; set; }
        public Department Dep { get; set; }
       
        public Jobtitle()
            : base()
        {
            TableName = "JOB_TITLE";
            Name = "";
            Dep = new Department();
            cmd.Parameters.Add("@ID", FbDbType.Char, 38, "ID");
            cmd.Parameters.Add("@CODE", FbDbType.Integer, 50, "CODE");
            cmd.Parameters.Add("@NAME", FbDbType.VarChar, 50, "NAME");
            cmd.Parameters.Add("@SALLARY", FbDbType.Decimal, 15, "SALLARY");
            cmd.Parameters.Add("@DOLLAR_PER_HOUR", FbDbType.Decimal, 15, "DOLLAR_PER_HOUR");
            cmd.Parameters.Add("@DEP_ID", FbDbType.Char, 38, "DEP_ID");
        }

        public Jobtitle(FbDataReader R):this()
        {
            FieldsFromReader(R);
        }

        protected override void FillFields()
        {
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@code"].Value = Code;
            cmd.Parameters["@name"].Value = Name;
            cmd.Parameters["@sallary"].Value = Sallary;
            cmd.Parameters["@dollar_per_hour"].Value = Dollar_per_hour;
            cmd.Parameters["@dep_id"].Value = Dep.ID;
        }

        protected override string InsertSQL()
        {
            return "insert into JOB_TITLE(id,code,name,sallary,dollar_per_hour,dep_id) values(@ID, @Code, @Name, @Sallary, @Dollar_per_hour, @Dep_Id)";

        }
        
        protected override string UpdateSQL()
        {
            return "update JOB_TITLE set code=@Code,name=@Name,sallary=@Sallary,dollar_per_hour=@Dollar_per_hour,dep_id=@Dep_Id where id=@ID";
            ;
        }

        public override void FieldsFromReader(FbDataReader R)
        {
            ID = Guid.Parse(R["ID"].ToString());
            Code = Int32.Parse(R["Code"].ToString());
            Name = R["Name"].ToString();
            Sallary = Int32.Parse(R["Sallary"].ToString());
            Dollar_per_hour = Int32.Parse(R["Dollar_per_hour"].ToString());
            Dep.SelectOne(Guid.Parse(R["Dep_Id"].ToString()));
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", Code, Name);
        }

        public void Copy(Jobtitle Source)
        {
            ID = Source.ID;
            Code = Source.Code;
            Name = Source.Name;
            Sallary = Source.Sallary;
            Dollar_per_hour = Source.Dollar_per_hour;
            Dep = Source.Dep;
        }
    }
}
