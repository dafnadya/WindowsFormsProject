using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Cursach;

namespace Cursach.Patterns
{
    [DataContract]
    public enum FilmType
    {
        [EnumMember]
        Ordinary,
        [EnumMember]
        Premiere,
        [EnumMember]
        StudentSale
    }
    
    [DataContract]
    public abstract class AbstractMovie
    {
        [DataMember]
        protected string name;
        [DataMember]
        protected string genre;
        [DataMember]
        protected int minPrice;
        [DataMember]
        protected int minAge;
        [DataMember]
        protected FilmType type;
        [DataMember]
        protected List<Seance> seances;
        [DataMember]
        protected string imagePath;

        public abstract int GetPrice();
        public abstract string GetExtraInfo();
        public abstract Image GetImage();

        public AbstractMovie() { }
        public string Name
        {
            get { return name; }
        }
        public string Genre
        {
            get { return genre; }
        }
        public int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }
        public FilmType Type
        {
            get { return type; }
            set { type = value; }
        }
        public string ImagePath
        {
            get { return imagePath; }
            set {
                this.imagePath = value;
            }
        }
        public List<Seance> Seances
        {
            get { return seances; }
        }
    }

    [DataContract]
    public class Movie : AbstractMovie
    {
        public Movie(string name, string genre, int minPrice, string imagePath, FilmType type)
        {
            this.name = name;
            this.genre = genre;
            this.minPrice = minPrice;
            this.minAge = 0;
            this.imagePath = imagePath;
            this.type = type;
        }
        public Movie(string name, string genre, int price, int minAge, string imagePath, FilmType type, List<Seance> seances)
        {
            this.name = name;
            this.genre = genre;
            this.minPrice = price;
            this.minAge = minAge;
            this.imagePath = imagePath;
            this.type = type;
            this.seances = seances;
        }
        public override int GetPrice()
        {
            return minPrice;
        }
        public override string GetExtraInfo()
        {
            return "";
        }
        public override Image GetImage()
        {
            if (!string.IsNullOrEmpty(this.imagePath))
            {
                if (File.Exists(this.imagePath))
                {
                    return Image.FromFile(this.imagePath);
                }
            }
            return null;
        }
    }

    abstract class Decorator : AbstractMovie
    {
        protected AbstractMovie Movie;
        public Decorator(AbstractMovie movie)
        {
            this.Movie = movie;
        }
        public override int GetPrice()
        {
            if (Movie != null) return Movie.GetPrice();
            else return 0;
        }
        public override Image GetImage()
        {
            if (!string.IsNullOrEmpty(Movie.ImagePath))
            {
                if (File.Exists(Movie.ImagePath))
                {
                    return Image.FromFile(Movie.ImagePath);
                }
            }
            return null;
        }
    }

    class PremiereMarkup : Decorator
    {
        public PremiereMarkup(Movie movie) : base(movie) { }
        public override int GetPrice()
        {
            return base.GetPrice() + 20;
        }
        public override string GetExtraInfo()
        {
            return "Premiere!";
        }
    }

    class StudentSale : Decorator
    {
        public StudentSale(Movie movie) : base(movie) { }
        public override int GetPrice()
        {
            return (int)(base.GetPrice() * 0.8);
        }
        public override string GetExtraInfo()
        {
            return "Student sale 20%";
        }
    }
}
