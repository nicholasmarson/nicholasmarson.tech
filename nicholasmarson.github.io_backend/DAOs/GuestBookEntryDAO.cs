using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace nicholasmarson.github.io_backend.DAOs
{
    public class GuestBookEntryDAO : IGuestBookEntryDAO
    {

        public GuestBookEntryDAO() 
        {

        }
        private readonly string connectionString;

        public GuestBookEntryDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<List<GuestBookEntry>> GetGuestBookEntries()
        {
            List<GuestBookEntry> guestBookEntries = new List<GuestBookEntry>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM GuestBookEntries", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            GuestBookEntry guestBookEntry = new GuestBookEntry
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Message = reader.GetString(2),
                                Date = reader.GetDateTime(3)
                            };

                            guestBookEntries.Add(guestBookEntry);
                        }
                    }
                }
            }
            return guestBookEntries;
        }

        public async Task GetGuestBookEntriesByName(string name) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 

            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM GuestBookEntries WHERE Name = @Name", connection))
                {
                    command.Parameters.AddWithValue("@Name", name);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            GuestBookEntry guestBookEntry = new GuestBookEntry
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Message = reader.GetString(2),
                                Date = reader.GetDateTime(3)
                            };

                            Console.WriteLine(guestBookEntry);
                        }
                    }
                }
            }
        }

        public async Task AddGuestBookEntry(GuestBookEntry guestBookEntry)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("INSERT INTO GuestBookEntries (Name, Message, Date) VALUES (@Name, @Message, @Date)", connection))
                {
                    command.Parameters.AddWithValue("@Name", guestBookEntry.Name);
                    command.Parameters.AddWithValue("@Message", guestBookEntry.Message);
                    command.Parameters.AddWithValue("@Date", guestBookEntry.Date);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
