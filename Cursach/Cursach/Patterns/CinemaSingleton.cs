using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cursach.Patterns
{
    [DataContract]
    public class Cinema
    {
        private static Cinema _instance;
        [DataMember]
        private string _name;
        [DataMember]
        private List<Movie> _movies;
        [DataMember]
        private List<CinemaHall> _halls;
        [DataMember]
        private List<User> _users;
        private int _curUserIndex;
        
        private static object syncLock = new object();
        
        protected Cinema(string name, List<Movie> movies, List<CinemaHall> halls, List<User> users)
        {
            _name = name;
            _movies = movies;
            _halls = halls;
            _users = users;
            _curUserIndex = -1;
        }
        public static Cinema GetCinema()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = CreateDefaultCinema();
                    }
                }
            }
            return _instance;
        }

        public string Name
        {
            get { return _name; }
        }
        public List<Movie> Movies
        {
            get { return _movies; }
        }
        public List<CinemaHall> Halls
        {
            get { return _halls; }
        }
        public List<User> Users
        {
            get { return _users; }
        }
        public int CurUserIndex
        {
            set { _curUserIndex = value; }
            get { return _curUserIndex; }
        }
        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
            if (movie.Type == FilmType.Premiere)
            {
                foreach (User user in _users)
                {
                    user.SendMessage(new Message("Premiere of film \"" + movie.Name + "\"!", "Premiere!"));
                }
            }
        }
        
        public static User CurUser
        {
            get {
                if (_instance.CurUserIndex == -1) return null;
                return  _instance.Users[_instance.CurUserIndex];
            }
        }

        public static void AddUser(User user)
        {
            _instance.Users.Add(user);
        }

        public static bool EnterCinema(string login, string password)
        {
            _instance.CurUserIndex = _instance.Users.FindIndex(x => x.Login == login && x.Password == password);
            if (_instance.CurUserIndex == -1) return false;
            return true;
        }
        public static void ExitCinema()
        {
            _instance.CurUserIndex = -1;
        }

        public static void SerializeJSON()
        {

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Cinema));
            MemoryStream stream = new MemoryStream();
            js.WriteObject(stream, _instance);
            stream.Position = 0;

            StreamReader sr = new StreamReader(stream);

            string json = sr.ReadToEnd();

            sr.Close();
            stream.Close();
            File.WriteAllText(@"C:\Users\dafna\Desktop\Labs\Cursach\data.json", json);
        }
        
        public static Cinema DeserializeJSON()
        {
            string json = File.ReadAllText(@"C:\Users\dafna\Desktop\Labs\Cursach\data.json");
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Cinema));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            Cinema cinema = ser.ReadObject(stream) as Cinema;
            stream.Close();
            _instance = cinema;
            _instance.CurUserIndex = -1;
            return cinema;
        }

        private static Cinema CreateDefaultCinema()
        {
            List<CinemaHall> halls = new List<CinemaHall>();
            CinemaHall hall1 = new CinemaHall(1, new ThreeDimentionalHall());
            hall1.AddRow();
            hall1.AddRow();
            hall1.AddRow();
            hall1.AddRow();
            hall1.AddRow();
            halls.Add(hall1);
            CinemaHall hall2 = new CinemaHall(2, new TwoDimentionalHall());
            hall2.AddRow();
            hall2.AddRow();
            hall2.AddRow();
            hall2.AddRow();
            halls.Add(hall2);
            CinemaHall hall3 = new CinemaHall(3, new TwoDimentionalHall());
            hall3.AddRow();
            hall3.AddRow();
            hall3.AddRow();
            hall3.AddRow();
            halls.Add(hall3);

            List<User> users = new List<User>();
            User user1 = new User("234342", "me", "me");
            users.Add(user1);
            User user2 = new User("234342", "you", "you");
            users.Add(user2);

            Cinema cinema = new Cinema("Kievskaya Rus'", new List<Movie>(), halls, users);

            List<Seance> seances1 = new List<Seance>();
            seances1.Add(new Seance(new DateTime(2019, 1, 1, 13, 0, 0), hall1.Clone() as CinemaHall));
            seances1.Add(new Seance(new DateTime(2019, 1, 1, 18, 0, 0), hall1.Clone() as CinemaHall));
            List<Seance> seances2 = new List<Seance>();
            seances2.Add(new Seance(new DateTime(2019, 1, 1, 12, 00, 0), hall2.Clone() as CinemaHall));
            seances2.Add(new Seance(new DateTime(2019, 1, 1, 23, 00, 0), hall2.Clone() as CinemaHall));
            List<Seance> seances3 = new List<Seance>();
            seances3.Add(new Seance(new DateTime(2019, 1, 1, 8, 00, 0), hall3.Clone() as CinemaHall));
            seances3.Add(new Seance(new DateTime(2019, 1, 1, 19, 00, 0), hall3.Clone() as CinemaHall));
            Movie movie1 = new Movie("Shazam", "fantactic", 80, 16, @"C:\Users\dafna\Desktop\Labs\Cursach\1.jpg", FilmType.Premiere, seances1);
            Movie movie2 = new Movie("The theory of everything", "biography", 70, 16, @"C:\Users\dafna\Desktop\Labs\Cursach\3.jpg", FilmType.Ordinary, seances2);
            Movie movie3 = new Movie("Happy death day", "comedy", 60, 18, @"C:\Users\dafna\Desktop\Labs\Cursach\2.jpg", FilmType.StudentSale, seances3);
            cinema.AddMovie(movie1);
            cinema.AddMovie(movie2);
            cinema.AddMovie(movie3);

            return cinema;
        }
    }
}
