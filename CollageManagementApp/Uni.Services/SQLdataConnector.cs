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
            const string SqlExpression = "sp_allCourses";
            List<Courses> result = new List<Courses>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(SqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Courses
                            {
                                CourseID = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                TeacherID = reader.GetInt32(2),
                            });
                        }
                    }
                }
                catch (SqlException)
                {

                    throw;
                }
                finally { connection.Close(); }
            }
            return result;

        }

        public List<Teacher> GetAllLecturers()
        {
            const string SqlExpression = "sp_allLecturers";
            List<Teacher> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(SqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Teacher
                            {
                                TeacherID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Email= reader.GetString(3),
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
            }
            return result;
        }

        public List<Student> GetAllStudents()
        {
            const string SqlExpression = "sp_allStudents";
            List<Student> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(SqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Student
                            {
                                StudentId= reader.GetInt32(0),
                                FirstName= reader.GetString(1),
                                LastName= reader.GetString(2),
                                Email= reader.GetString(3),
                                PhoneNumber= reader.GetString(4),
                                Enrolldate= reader.GetDateTime(5),
                                Undergrad= reader.GetBoolean(6),
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
            }
            return result;
        }

        public List<Take> GetAllTakes()
        {
            const string SqlExpression = "sp_allTakes";
            List<Take> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(SqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Take
                            {
                                StudentID= reader.GetInt32(0),
                                CourseID= reader.GetInt32(1),
                                Grade= reader.GetInt32(2), 
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
            }
            return result;
        }
    }
}
