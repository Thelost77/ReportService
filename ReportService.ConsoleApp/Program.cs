using Cipher;
using EmailSender;
using ReportService.Core;
using ReportService.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportService.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var stringCipher = new StringCipher("1");
            var encryptedPassword = stringCipher.Encrypt("hasło");
            var decryptedPassword = stringCipher.Decrypt(encryptedPassword);

            Console.WriteLine(encryptedPassword);
            Console.WriteLine(decryptedPassword);



            /*var _emailReceiver = "";
            var _htmlEmail = new GenerateHtmlEmail();

            var email = new Email(new EmailParams
            {
                HostSmtp = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                SenderName = "",
                SenderEmail = "",
                SenderEmailPassword = ""
            });

            var report = new Report
            {
                Id = 1,
                Title = "R/1/2020",
                Date = new DateTime(2020, 1, 1, 12, 0, 0),
                Positions = new List<ReportPosition>
                {
                    new ReportPosition
                    {
                        Id = 1,
                        ReportId = 1,
                        Title = "Position 1",
                        Description = "Description 1",
                        Value = 4311m,
                    },

                    new ReportPosition
                    {
                        Id = 2,
                        ReportId = 2,
                        Title = "Position 2",
                        Description = "Description 2",
                        Value = 432m,
                    },

                    new ReportPosition
                    {
                        Id = 3,
                        ReportId = 3,
                        Title = "Position 3",
                        Description = "Description 3",
                        Value = 69m,
                    }
                }
            };

            var errors = new List<Error>
            {
                new Error {Message = "Błąd testowy", Date = DateTime.Now},
                new Error {Message = "Błąd testowy 2", Date = DateTime.Now}
            };

            Console.WriteLine("Wysyłanie e-mail (Błędy w aplikacji)");

            email.Send("Błędy w aplikacji", _htmlEmail.GenerateErrors(errors, 10), _emailReceiver).Wait();

            Console.WriteLine("Wysłano e-mail (Błędy w aplikacji)");

            Console.WriteLine("Wysyłanie e-mail (Raport dobowy)");

            email.Send("Raport dobowy", _htmlEmail.GenerateReport(report), _emailReceiver).Wait();

            Console.WriteLine("Wysłano e-mail(Błędy w aplikacji)"); 
            */
        }
    }

}
