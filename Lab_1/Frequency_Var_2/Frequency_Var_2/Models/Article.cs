using System;
using System.Collections.Generic;
using System.Text;

namespace Frequency_Var_2.Models
{
    public class Article
    {
        public Person  AuthorInfo { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public Article(Person authorInfo, string articleName, double articleRating)
        {
            AuthorInfo = authorInfo;
            Name = articleName;
            Rating = articleRating;
        }
        public Article()
        {
            AuthorInfo = new Person( "Roman", "Zagul", new DateTime(2001,12,3) );
            Name = "Save environment";
            Rating = 3.5;
        }
        public override string ToString()
        {
            return "Article:\n\tname: " + Name + "\n\trating: " + Rating.ToString() + "\n" + "\nauthorInfo: " + AuthorInfo.ToString();
        }
    }
}
