using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Cursach.Patterns;

namespace Cursach
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public string Text;
        [DataMember]
        public bool IsRead;
        [DataMember]
        public string Theme;
        [DataMember]
        public DateTime date;

        public Message (string text, string theme)
        {
            Text = text;
            Theme = theme;
            IsRead = false;
            date = DateTime.Now;
        }

        public void Read()
        {
            IsRead = true;
        }
    }

    [DataContract]
    public class User
    {
        [DataMember]
        private string _cardNumber;
        [DataMember]
        private int _cardSum;
        [DataMember]
        private string _login;
        [DataMember]
        private string _password;
        [DataMember]
        private List<Ticket> _tickets;
        [DataMember]
        private List<Message> _messages;
        [DataMember]
        private double _discount;

        public User(string cardNumber, string login, string password)
        {
            _cardNumber = cardNumber;
            _cardSum = 1000;
            _login = login;
            _password = password;
            _discount = 1;
            _tickets = new List<Ticket>();
            _messages = new List<Message>();
        }

        public string Login
        {
            get { return _login; }
        }
        public string Password
        {
            get { return _password; }
        }
        public double Discount
        {
            get { return _discount; }
        }
        public string CardNumber
        {
            get { return _cardNumber; }
        }
        public int CardSum
        {
            get { return _cardSum; }
            set { _cardSum = value; }
        }
        public List<Ticket> Tickets
        {
            get { return _tickets; }
        }
        public List<Message> Messages
        {
            get { return _messages; }
        }

        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
            if (_tickets.Count == 5)
            {
                _discount = 0.95;
                _messages.Add(new Message("You became our regular customer! Now you got sale 5%", "Discount"));
            }
            if (_tickets.Count == 10)
            {
                _discount = 0.9;
                _messages.Add(new Message("New discount! Now you got sale 10%. Our cinema loves you:)", "Discount"));
            }
        }

        public void SendMessage(Message message)
        {
            _messages.Add(message);
        }

        public string GetPersonalInfo()
        {
            return $"Login: {_login}\nCard number: {_cardNumber}\nCard sum: {_cardSum}";
        }
    }
}
