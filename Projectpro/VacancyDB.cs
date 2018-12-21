using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Projectpro
{
    public class VacancyDB
    {


        public int AddVacancy(Vacancy obj)
        {
            int ret = 0;

            SqlConnection connection = DataUtilities.getConnect();


            SqlCommand command;

            try
            {
                connection.Open();
                command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                // command.CommandText = "sp_addvacancy";
                command.CommandText = "sp_secondvacancy";
                command.Connection = connection;
                command.Parameters.AddWithValue("@Name", obj.Name);
                command.Parameters.AddWithValue("@Place", obj.Place);
                command.Parameters.AddWithValue("@Country", obj.Country);



                ret = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return (ret);
        }



        public List<Vacancy> fetchvacancy()
        {
            SqlConnection connection = DataUtilities.getConnect();
            List<Vacancy> sasi = new List<Vacancy>();

            SqlCommand command;
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_fetchvacancy";

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    string vaccname = Convert.ToString(reader[0]);
                    string place = Convert.ToString(reader[1]);
                    string country = Convert.ToString(reader[2]);

                    Vacancy thoori = new Vacancy(vaccname, place, country);
                    sasi.Add(thoori);


                }

                return sasi;

            }

            catch(Exception e)
            {
                throw e;
            }

            }

    }
}
