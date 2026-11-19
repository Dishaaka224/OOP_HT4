using System;
namespace OOP_HT4;

class Notification
{
    private string Title;

    public string title {get; set;}
    public Notification(string title)
    {
        Title = title;

    }

    class EmailNotification : Notification
{
    public string EmailAddress { get; set; }

    public EmailNotification(string title, string emailAddress) : base(title)
    {
        EmailAddress = emailAddress;
    }
}

    class SmsNotification : Notification
{
    public string PhoneNumber { get; set; }

    public SmsNotification(string title, string phoneNumber) : base(title)
    {
        PhoneNumber = phoneNumber;
    }
}
}
