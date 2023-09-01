using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Inventory_App.UserControls;
using System.Windows.Forms;

namespace Inventory_App
{
    public class Email
    {
        public static async void SendEmail(Order order, Customer customer) //Skickar mailet med async och await så resten av koden i programmet kan köras under tiden när den väntar
        {
            string address = customer.Mail;
            string subject = $"Tack för din order {customer.Namn}!";
            string body = $"Hej {customer.Namn},\n\nTack så mycket för din order, här kommer några order detaljer:\n\n" +
              $"- Order ID: {order.Id}\n" +
              $"- Order Datum: {order.Datum}\n" +
              $"- Order Summa: {order.Summa:C}\n" +
              $"- Antal Produkter: {order.Produkter}\n\n" +
              "Här är en lista på produkterna i din beställning:\n\n ";

            foreach (OrderItem item in order.OrderList)
            {
                body += $"- Produkt: {item.Namn}\n" +
                        $"  Pris per enhet: {item.Pris:C}\n" +
                        $"  Antal beställda: {item.Kvantitet}\n" +
                        $"  Totalt pris: {item.Pris * item.Kvantitet:C}\n\n";
            }

            body += "Med vänliga hälsningar";

            try
            {
                await SendEmailAsync(address, subject, body);
                MessageBox.Show("Mailet har skickats!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mailet misslyckades på grund av : " + ex.Message);
            }
        }

        public static async Task SendEmailAsync(string address, string subject, string body)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.office365.com")) //Använder using då det blir effektivare och objektet inte behövs längre efter blocket och det kräver mycket resurser
            {
                //Inloggning och inställningar
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("noel.nevren@hotmail.com", "Noel-3395");
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress("noel.nevren@hotmail.com"); //Mail address som den mailet skickas från
                    mailMessage.To.Add(address);
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;

                    await smtpClient.SendMailAsync(mailMessage); //Skickar mailet med await
                }
            }
        }
    }
}
