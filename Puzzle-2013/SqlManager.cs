using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace Puzzle_2013
{
    public class SqlManager
    {
        public static void InsertUser(User toInsert)
        {
            string connectionString = Properties.Settings.Default.oti2013ConnectionString;

            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string query = "Insert into Users (Name, Surname, Username, Password, Type) Values (" + 
                    "'" + toInsert.name + "', '" + toInsert.surname + "', '" + toInsert.username + "', '" + 
                    toInsert.password + "', '" + toInsert.userType + "')";

                connection.Open();

                SqlCeCommand command = new SqlCeCommand(query, connection);

                try
                {
                    int affectedRows = command.ExecuteNonQuery();
                }
                catch (SqlCeException)
                {
                    Console.WriteLine("Exception raised when inserting a user into the database");
                }

                connection.Close();
            }
        }

        public static void InsertScore(Score toInsert)
        {
            string connectionString = Properties.Settings.Default.oti2013ConnectionString;

            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string query = "Insert into Scores (ID, Time, Moves, Pieces) Values (" + "'" + toInsert.ID +
                    "', '" + toInsert.time + "', '" + toInsert.moves + "', '" + toInsert.items + ")";

                connection.Open();

                SqlCeCommand command = new SqlCeCommand(query, connection);

                try
                {
                    int affectedRows = command.ExecuteNonQuery();
                }
                catch (SqlCeException)
                {
                    Console.WriteLine("Exeception was raised when inserting a new score into the database");
                }

                connection.Close();
            }
        }

        public static List<User> GetUsersFromDatabase()
        {
            List<User> toReturn = new List<User> { };

            string connectionString = Properties.Settings.Default.oti2013ConnectionString;

            using (SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string query = "Select * from Users";

                SqlCeCommand command = new SqlCeCommand(query, connection);

                SqlCeDataReader reader = null;

                try
                {
                    reader = command.ExecuteReader();
                }
                catch (SqlCeException)
                {
                    Console.WriteLine("Exception was raised when getting users!");
                }
                finally
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            toReturn.Add (new User 
                            {
                                ID = reader.GetInt16(0),
                                name = reader.GetString(1),
                                surname = reader.GetString(2),
                                username = reader.GetString(3),
                                password = reader.GetString(4),
                                userType = reader.GetInt16(5)
                            });
                        }
                    }
                }
            }

            return toReturn;
        }

        public static List<Score> GetScoresFromDatabase()
        {
            
        }
    }
}
