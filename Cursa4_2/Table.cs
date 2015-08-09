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
    public class Table : Base
    {  
        public int Code { get; set; }
        public DateTime Day_Start { get; set; }
        public DateTime Day_End { get; set; }
        public string Working_days { get; set; }
        public string Weekends { get; set; }
        public Employers Id_Employers { get; set; }
       
        public Table() : base()
        {
            Id_Employers = new Employers();
            TableName = "TABLE";
            cmd.Parameters.Add("@ID", FbDbType.Char, 38, "ID");
            cmd.Parameters.Add("@CODE", FbDbType.Integer, 50, "CODE");
            cmd.Parameters.Add("@DAY_START", FbDbType.Date, 16, "DAY_START");
            cmd.Parameters.Add("@DAY_END", FbDbType.Date, 16, "DAY_END");
            cmd.Parameters.Add("@WORKING_DAYS", FbDbType.Decimal, 16, "WORKING_DAYS");
            cmd.Parameters["@ID_EMPLOYERS"].Value = Id_Employers.ID;
        }
        protected override void FillFields()
        {
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@code"].Value = Code;
            cmd.Parameters["@day_start"].Value = Day_Start;
            cmd.Parameters["@day_end"].Value = Day_End;
            cmd.Parameters["@working_days"].Value = Working_days;
            cmd.Parameters["@weekends"].Value = Weekends;
            cmd.Parameters["@id_employers"].Value = Id_Employers.ID;
        }

        protected override string InsertSQL()
        {
            return "insert into COMPANY(id,code,day_start,day_end,working_days,weekends,id_employers) values(@ID, @Code, @Day_Start, @Day_End, @Working_days, @Weekends, @Id_Employers)";

        }

        protected override string UpdateSQL()
        {
            return "update TABLE set code=@code, day_start=@day_start, day_end=@day_end, working_days=@working_days,id_employers=@id_employers,where id=@id";
        }

        public override void FieldsFromReader(FbDataReader R)
        {
            ID = Guid.Parse(R["ID"].ToString());
            Code = Int32.Parse(R["Code"].ToString());
            Day_Start = DateTime.Parse(R["Day_Start"].ToString());
            Day_End = DateTime.Parse(R["Day_End"].ToString());
            Working_days = R["Working_days"].ToString();
            Id_Employers.SelectOne(Guid.Parse(R["Id_Employers"].ToString()));
        }

        public void FieldsFromRaw(DataRow row)
        {
            if (row.RowState == DataRowState.Modified)
            {
                ID = Guid.Parse(row["ID"].ToString());
                Code = Int32.Parse(row["Code"].ToString());
                Day_Start = DateTime.Parse(row["Day_Start"].ToString());
                Day_End = DateTime.Parse(row["Day_End"].ToString());
                Working_days = row["Working_days"].ToString();
            }
        }
    }
}
