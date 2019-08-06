using System;

namespace Fiskehandler
{
    public class Category{
        public string Name {get;set;}

        /// <summary>
        /// Creates a new category
        /// </summary>
        /// <param name="name"></param>
        public Category(string name){
            this.Name = name;
        }
    }
}