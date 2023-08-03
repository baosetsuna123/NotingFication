
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MimeKit;
using Microsoft.Data.SqlClient;
using Noting_Fication.Models;

namespace Noting_Fication
{
    internal static class Program
    {
        static String ConnectionString = "server =(local); database= NotingFication_2; uid=sa;pwd=123; TrustServerCertificate=True";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Note> expiredNotes = GetExpiredNotes();

            // Send email to each user with expired deadlines
            foreach (Note note in expiredNotes)
            {
                string recipientEmail = GetUserEmail(note.UserId);
                if (!string.IsNullOrEmpty(recipientEmail))
                {
                    string subject = "Note Deadline Expired";
                    string body = $"The note '{note.Name}''s deadline is about to expired. You might want to check it out!";

                    SendEmail(recipientEmail, subject, body);
                }
            }
          /*  string recipientEmail2 = "minhnhat0132@gmail.com";
            if (!string.IsNullOrEmpty(recipientEmail2))
            {
                string subject = "Note Deadline Expired";
                string body = "The deadline for the note '{note.Name}' has expired.";

                SendEmail(recipientEmail2, subject, body);
            }*/

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        //Get note hết hạn
        private static List<Note> GetExpiredNotes()
        {
            List<Note> expiredNotes = new List<Note>();

            // Perform database query to retrieve the expired notes
            // Replace with your actual database query code
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Note\r\nWHERE Deadline < DATEADD(day, 1, GETDATE()) \r\n  AND Deadline >= GETDATE() \r\n  AND Status = 1;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Note note = new Note
                    {
                        NoteId = Convert.ToInt32(reader["NoteID"]),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                        Name = reader["Name"].ToString(),
                        UserId = Convert.ToInt32(reader["UserID"]),
                        CategoryId = Convert.ToInt32(reader["CategoryID"]),
                        Status = Convert.ToBoolean(reader["Status"]),
                        Deadline = Convert.ToDateTime(reader["Deadline"]),
                        Content = reader["Content"].ToString()
                    };

                    expiredNotes.Add(note);
                }
                connection.Close();
            }

            return expiredNotes;
        }

        //Có expired note rồi thì get email
        private static string GetUserEmail(int userID)
        {
            string userEmail = string.Empty;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT Email FROM [User] WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);

                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && result != DBNull.Value)
                {
                    userEmail = result.ToString();
                }
            }

            return userEmail;
        }
        public static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var strConn = config["ConnectionStrings:NotingFicationDB"];

            return strConn;

        }
        static string[] Scopes = { GmailService.Scope.GmailCompose, GmailService.Scope.GmailSend };
        private static UserCredential GetUserCredential()
        {
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
        }


        //----------------------------------------------------------
        // Code liên quan tới mail
        private static void SendEmail(string to, string subject, string body)
        {
            UserCredential credential = GetUserCredential();

            //  Gmail API service
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "NotingFication"
            });

            //  email message
            var message = new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64UrlEncode(CreateEmail(to, subject, body))
            };

            // Send 
            service.Users.Messages.Send(message, "me").Execute();
        }
        private static MimeMessage CreateEmail(string to, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("NotingFication", "nhatpm0710.skillcetera@gmail.com"));
            email.To.Add(new MimeKit.MailboxAddress("Receiver Name",to));
            email.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = body;
            email.Body = bodyBuilder.ToMessageBody();

            return email;
        }

        private static string Base64UrlEncode(MimeMessage email)
        {
            using (var stream = new MemoryStream())
            {
                email.WriteTo(stream);
                return Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length)
                    .Replace('+', '-')
                    .Replace('/', '_')
                    .Replace("=", "");
            }
        }


    }


}