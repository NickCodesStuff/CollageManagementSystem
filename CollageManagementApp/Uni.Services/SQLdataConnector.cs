using Microsoft.Data.SqlClient;
using Uni.Services.Interfaces;
using UniManagement.Library;
using System.Data;

namespace Uni.Services
{
    public class SQLdataConnector : IDataConnection
    {
        public List<Admin> GetAllAdmins()
        {
            const string SqlExpression = "sp_allAdmins";
            List<Admin> result = new List<Admin>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command= new(SqlExpression,connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) 
                    {
                        while (reader.Read())
                        {
                            result.Add(
                                new Admin
                                {
                                AdminID = reader.GetInt32(0),
                                Email = reader.GetString(1),
                                Password = reader.GetString(2),
                                }
                            );
                        }
                    }
                }
                catch (SqlException)
                {

                    throw;
                }
                finally { connection.Close(); } 

                return result;
            }
        }

        public List<Courses> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAllLecturers()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public List<Take> GetAllTakes()
        {
            throw new NotImplementedException();
        }
    }
}
