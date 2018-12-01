using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalThiago.Classes
{
    public static class UserHelper
    {
        public static string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public static string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        public static User SelectByName(string name)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            User user = new User();

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE NAME = @name", sqlConnect);
                cmd.Parameters.Add(new SqlParameter("@name", name));//-----

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Id = Int32.Parse(reader["ID"].ToString());
                        user.Name = reader["NAME"].ToString();
                        user.Active = bool.Parse(reader["ACTIVE"].ToString());
                        user.Email = reader["EMAIL"].ToString();
                        user.Password = reader["PASSWORD"].ToString();
                        user.UserProfile = new UserProfile
                        {
                            Id = Int32.Parse(reader["FK_USER_PROFILE"].ToString())
                        };
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnect.Close();
            }

            return user;
        }
    }
}
