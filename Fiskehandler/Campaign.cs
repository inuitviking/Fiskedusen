using System;
using System.Collections.Generic;

namespace Fiskehandler
{
    public class Campaign{
        public string Name {get;set;}
        public DateTime Start {get;private set;}
        public DateTime End {get;private set;}
        public double Rate {get;set;}
        public List<Category> Categories {get;set;}

        /// <summary>
        /// Creates a new campaign
        /// </summary>
        /// <param name="name"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="rate"></param>
        /// <param name="categories"></param>
        public Campaign(string name, DateTime start, DateTime end, double rate, List<Category> categories){
            this.Name = name;
            this.Start = start;
            this.End = end;
            this.Rate = rate;
            this.Categories = categories;
        }
    }
}