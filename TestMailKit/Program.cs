// See https://aka.ms/new-console-template for more information
using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;
using TestMailKit;

await SendMessageAsync();

await RetrieveMailsAsync();

async Task SendMessageAsync()
{
    EmailService emailService = new EmailService();
    await emailService.SendMailAsync("kosyuska@yandex.ru", "haha", "It is body");    

}

async Task RetrieveMailsAsync()
{
    EmailService emailService = new EmailService();
    await emailService.RetrieveMailAsync();

}