using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalThiago.Classes
{
    public class Log
    {
        int id;
        string description;
        DateTime date;
        string type;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Log()
        {

        }

        public Log(string description, DateTime date, string type)
        {
            this.Description = description;
            this.Date = date;
            this.Type = type;
        }

        public Log(int id, string description, DateTime date, string type)
        {
            this.Id = id;
            this.Description = description;
            this.Date = date;
            this.Type = type;
        }

		public static void SaveLog(string description, DateTime date, string type)
		{
			string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

			SqlConnection sqlConnect = new SqlConnection(connectionString);

			//Conectar
			sqlConnect.Open();
			string sql = "INSERT INTO LOG (DESCRIPTION, DATE, TYPE) VALUES (@description, @date, @type)";

			SqlCommand cmd = new SqlCommand(sql, sqlConnect);

			cmd.Parameters.Add(new SqlParameter("@description", description));
			cmd.Parameters.Add(new SqlParameter("@date", date));
			cmd.Parameters.Add(new SqlParameter("@type", type));

			cmd.ExecuteNonQuery();

		}
	}
}
