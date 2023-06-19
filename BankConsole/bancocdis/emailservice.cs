using MailKit.Net.Smtp;
using MimeKit;

namespace Bancocdis;

public static class emailservice
{
        public static void sendMail()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Christyna Martínez", "christynamtz17@gmail.com"));
            message.To.Add(new MailboxAddress("admin", "christynamtz@gmail.com"));
            message.Subject="BankConsole: Usuarios nuevos";

            message.Body = new TextPart("plain"){
                Text= GetEmailText()
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("christynamtz17@gmail.com", "hzyojcypepnxpnmk");
                client.Send(message);
                client.Disconnect(true);
            }
        }

        private static string GetEmailText()
        {
            List<User> newUsers = storage.GetNewUsers();

            if(newUsers.Count ==0)
                return "no hay usuarios nuevos.";

            string emailText = "Usuarios agregados hoy: \n";

            foreach (User user in newUsers)
                emailText += "\t" + user.ShowData() + "\n";
            
            return emailText;
           
        }
}