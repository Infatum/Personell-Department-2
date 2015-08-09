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
   public class Tasks : Base
    {
       public static BindingList<Tasks> data = new BindingList<Tasks>();
        public int Code { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Deadline { get; set; }
        public Guid Id_Employers { get; set; }
       
        public Tasks() : base()
        {
            TableName = "TASKS";
            Start_Date = Deadline = DateTime.Now;
            cmd.Parameters.Add("@CODE", FbDbType.Integer, 50, "CODE");
            cmd.Parameters.Add("@NAME", FbDbType.VarChar, 50, "NAME");
            cmd.Parameters.Add("@TASK", FbDbType.VarChar, 50, "TASK");
            cmd.Parameters.Add("@Start_Date", FbDbType.Date, 16, "Start_Date");
            cmd.Parameters.Add("@Deadline", FbDbType.Date, 16, "Deadline");
            cmd.Parameters.Add("@ID_EMPLOYER", FbDbType.Char, 38, "ID_EMPLOYER");
        }

       public Tasks(FbDataReader R): this()
        {
            FieldsFromReader(R);
        }

        protected override void FillFields()
        {
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@code"].Value = Code;
            cmd.Parameters["@name"].Value = Name;
            cmd.Parameters["@TASK"].Value = Task;
            cmd.Parameters["@start_date"].Value = Start_Date;
            cmd.Parameters["@deadline"].Value = Deadline;
            cmd.Parameters["@ID_EMPLOYER"].Value = Id_Employers;
        }

        protected override string InsertSQL()
        {
            return "insert into TASKS(id,code,name,task,start_date,deadline,ID_EMPLOYER) values(@ID, @Code, @Name,@TASK, @Start_Date, @Deadline, @ID_EMPLOYER)";

        }

        protected override string UpdateSQL()
        {
            return "update TASKS set code=@code,name=@name,task=@task,start_date=@start_date,deadline=@deadline,ID_EMPLOYER=@ID_EMPLOYER where id=@id";
        }

        public override void FieldsFromReader(FbDataReader R)
        {
            ID = Guid.Parse(R["ID"].ToString());
            Code = Int32.Parse(R["Code"].ToString());
            Name = R["Name"].ToString();
            Task = R["TASK"].ToString();
            Start_Date = DateTime.Parse(R["START_DATE"].ToString());
            Deadline = DateTime.Parse(R["DEADLINE"].ToString());
        }
    }
}
