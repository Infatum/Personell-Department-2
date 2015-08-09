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
    public class Employers : Base
    {
        public static BindingList<Employers> data = new BindingList<Employers>();
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Contract { get; set; }
        public DateTime Date_of_assigment { get; set; }
        public DateTime Date_of_dismissal { get; set; }
        public Jobtitle JT { get; set; }
        public string Skills { get; set; }

        public Employers()
            : base()
        {
            TableName = "EMPLOYERS";
            Birthday = DateTime.Now.AddYears(-18);
            Date_of_assigment = Date_of_dismissal = DateTime.Now;
            Gender = "ч";
            JT = new Jobtitle();
            cmd.Parameters.Add("@CODE", FbDbType.Integer, 50, "CODE");
            cmd.Parameters.Add("@NAME", FbDbType.VarChar, 50, "NAME");
            cmd.Parameters.Add("@BIRTHDAY", FbDbType.Date, 8, "BIRTHDAY");
            cmd.Parameters.Add("@GENDER", FbDbType.Char, 1, "GENDER");
            cmd.Parameters.Add("@CONTRACT", FbDbType.VarChar, 300, "CONTRACT");
            cmd.Parameters.Add("@DATE_OF_ASSIGMENT", FbDbType.Date, 8, "DATE_OF_ASSIGMENT");
            cmd.Parameters.Add("@DATE_OF_DISMISSAL", FbDbType.Date, 8, "DATE_OF_DISMISSAL");
            cmd.Parameters.Add("@ID_JOBTITLE", FbDbType.Char, 38, "ID_JOBTITLE");
            cmd.Parameters.Add("@SKILLS", FbDbType.VarChar, 200, "SKILLS");
        }

        public Employers(FbDataReader R):this()
        {
            FieldsFromReader(R);
        }

        protected override void FillFields()
        {
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@code"].Value = Code;
            cmd.Parameters["@name"].Value = Name;
            cmd.Parameters["@birthday"].Value = Birthday;
            cmd.Parameters["@gender"].Value = Gender;
            cmd.Parameters["@contract"].Value = Contract;
            cmd.Parameters["@date_of_assigment"].Value = Date_of_assigment;
            cmd.Parameters["@date_of_dismissal"].Value = Date_of_dismissal;
            cmd.Parameters["@id_jobtitle"].Value = JT.ID;//Id_Jobtitle
            cmd.Parameters["@skills"].Value = Skills;
        }

        protected override string InsertSQL()
        {
            return "     into EMPLOYERS(id,code,name,birthday,gender,contract,date_of_assigment,date_of_dismissal,id_jobtitle,skills) values(@ID,@Code, @Name, @Birthday, @Gender, @Contract, @Date_of_assigment, @Date_of_dismissal, @Id_Jobtitle, @Skills)";

        }

        protected override string UpdateSQL()
        {
            return "update EMPLOYERS set code=@code,name=@name,birthday=@Birthday,gender= @Gender,contract=@Contract,date_of_assigment= @Date_of_assigment,date_of_dismissal=@Date_of_dismissal,id_jobtitle=@Id_Jobtitle,skills=@Skills where id=@id";
        }

        public override void FieldsFromReader(FbDataReader R)
        {
            ID = Guid.Parse(R["ID"].ToString());
            Code = Int32.Parse(R["Code"].ToString());
            Name = R["Name"].ToString();
            Birthday = DateTime.Parse(R["Birthday"].ToString());
            Gender = R["Gender"].ToString();
            Contract = R["Contract"].ToString();
            Date_of_assigment = DateTime.Parse(R["Date_of_assigment"].ToString());
            Date_of_dismissal = DateTime.Parse(R["Date_of_dismissal"].ToString());
            JT.SelectOne(Guid.Parse(R["Id_Jobtitle"].ToString()));
            Skills = R["Skills"].ToString();
        }
    }
}


