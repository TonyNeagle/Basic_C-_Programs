using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino;
using Casino.TwentyOne;
using Microsoft.IdentityModel.Tokens;







namespace TwentyOne
{
    class Program
    {


        public static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}! Lets start by telling me your name", casinoName);
            string playerName = Console.ReadLine() ?? string.Empty;
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity>  Exceptions = ReadExceptions();
                foreach ( var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;

            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now ", playerName);
            string answer = (Console.ReadLine() ?? string.Empty).ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Console Application Assignment.txt"), true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();

                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithExeception(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured please contact your system administrator" + ex.Message);
                        UpdateDbWithExeception(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }

        [Obsolete]
        private static void UpdateDbWithExeception(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@ExceptionType", ex.GetType().ToString());
                    command.Parameters.AddWithValue("@ExceptionMessage", ex.Message);
                    command.Parameters.AddWithValue("@TimeStamp", DateTime.Now);

                    command.Parameters["@ExceptionType"].SqlDbType = SqlDbType.VarChar;
                    command.Parameters["@ExceptionMessage"].SqlDbType = SqlDbType.VarChar;
                    command.Parameters["@TimeStamp"].SqlDbType = SqlDbType.DateTime;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;";
            var exceptions = new List<ExceptionEntity>();
            string queryString = "SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> exceptionEntities = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryString, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        ExceptionEntity exception = new ExceptionEntity();
                        exception.Id = Convert.ToInt32(reader["Id"]);
                        exception.ExceptionType = reader["ExceptionType"].ToString();
                        exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                        exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                        exceptions.Add(exception);
                    }
                    connection.Close();
                }
                return exceptions;
            }

            return exceptions;
        }
    }

}   
                

            
  
      
   





