using System;
using System.Collections.Generic;
using System.Text;

namespace Frequency_Var_2.Models
{
    public class Magazine
    {
        private string Name;
        private FrequencyEnum Frequency;
        private DateTime ReleaseDate;
        private int Circulation;
        private List<Article> Articles;
        public string name { get { return this.Name; } set { this.Name = value; } }
        public FrequencyEnum frequency { get { return this.Frequency; } set { this.Frequency = value; } }
        public DateTime releaseDate { get { return this.ReleaseDate; } set { this.ReleaseDate = value; } }
        public int circulation { get { return this.Circulation; } set { this.Circulation = value; } }
        public List<Article> articles { get { return this.Articles; } set { this.Articles = value; } }

        public double AverageRating 
        { 
            get 
            {
                double averageRating = 0;
                foreach ( var article in this.Articles)
                {
                    averageRating += article.Rating;
                }
                return averageRating / this.Articles.Count;
            }
        }
        public FrequencyEnum frequencyOb { get; private set; }
        public Boolean this[FrequencyEnum frequency]
        {
            get { return frequency == frequencyOb; }
        }
        
        public Magazine(string name, FrequencyEnum frequency, DateTime releaseDate, int circulation, List<Article> articles)
        {
            Name = name;
            Frequency = frequency;
            ReleaseDate = releaseDate;
            Circulation = circulation;
            Articles = articles;
        }
        public Magazine()
        {
            Name = "Nature";
            Frequency = FrequencyEnum.Monthly;
            ReleaseDate = new DateTime(2021,1,29);
            Circulation = 2;
            Articles = new List<Article>(){ new Article() };
        }

        public void AddArticles(Article article)
        {
            this.Articles.Add(article);
        }
        public override string ToString()
        {
            return "Magazine: \n" + "\tName: " + this.Name + "\n\tCirculation: " +
                this.Circulation.ToString() + "\n\tReleaseDate: " + this.ReleaseDate.ToString() +
                "\n\tFrequency: " + this.Frequency.ToString() + "\n\tArticles: " + string.Join(",", this.Articles) + "\n";
        }
        public virtual string ToShortString()
        {
            return "Magazine: \n" + "\tName: " + this.Name + "\n\tCirculation: " +
                this.Circulation.ToString() + "\n\tReleaseDate: " + this.ReleaseDate.ToString() +
                "\n\tFrequency: " + this.Frequency.ToString() + "\n\tAverageRating: " + this.AverageRating.ToString();
        }
    }
}
