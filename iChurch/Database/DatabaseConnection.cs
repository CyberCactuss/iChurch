using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSystem.Database
{
    public class DatabaseConnection
    {

        private string? connectionString;
        private SQLiteConnection connection;

        public DatabaseConnection(string dbFileName)
        {
            string? directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (!string.IsNullOrEmpty(directory))
            {              
                string dbFilePath = Path.Combine(directory, dbFileName);

                
                connectionString = $"Data Source={dbFilePath};Version=3;";

                
                connection = new SQLiteConnection(connectionString);
            }
            else
            {
                
                throw new Exception("Unable to determine the directory path of the executable.");
            }
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connection opened.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Database connection closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
        }

        public bool CheckCredentials(string username, string password)
        {
            
            bool isValid = false;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        isValid = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error checking credentials: {ex.Message}");
            }

            return isValid;
        }

        public void InsertMemberDetails(MemberDetails memberDetails)
        {
            try
            {
                string query = "INSERT INTO Members (Name, Email, Age, Sex, Contact, [Date/Time], Birthday, Address) " +
                               "VALUES (@Name, @Email, @Age, @Sex, @Contact, @DateTime, @Birthday, @Address)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", memberDetails.Name);
                    command.Parameters.AddWithValue("@Email", memberDetails.Email);
                    command.Parameters.AddWithValue("@Age", memberDetails.Age);
                    command.Parameters.AddWithValue("@Sex", memberDetails.Sex);
                    command.Parameters.AddWithValue("@Contact", memberDetails.Contact);
                    command.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    command.Parameters.AddWithValue("@Birthday", memberDetails.Birthday);
                    command.Parameters.AddWithValue("@Address", memberDetails.Address);

                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Member details inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting member details: {ex.Message}");
            }
        }

        public void LoadMembersIntoDataGridView(DataGridView dataGridView)
        {
            try
            {

                
                string query = "SELECT Name, Email, Sex FROM Members";

                
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                        
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        
                        adapter.Fill(dataTable);

                        
                        dataGridView.DataSource = dataTable;
                    }
                }

                
                DataGridViewButtonColumn viewInfoColumn = new DataGridViewButtonColumn();
                viewInfoColumn.Name = "View Info";
                viewInfoColumn.Text = "View Info";
                viewInfoColumn.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(viewInfoColumn);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading members into DataGridView: {ex.Message}");
            }
        }

        public void DeleteMemberDetails(string name, string email, string sex)
        {
            try
            {
                string query = "DELETE FROM Members WHERE Name = @Name AND Email = @Email AND Sex = @Sex";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Sex", sex);

                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Record deleted from database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting record from the database: {ex.Message}");
            }
        }


        public void DeleteMember(int memberId)
        {
            try
            {
                string query = "DELETE FROM Members WHERE [Member ID] = @MemberId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberId", memberId);

                    command.ExecuteNonQuery();
                }

                Console.WriteLine($"Member with ID {memberId} deleted from database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting member from the database: {ex.Message}");
            }
        }




    }

}



