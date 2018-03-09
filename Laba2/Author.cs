using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Author
    {
        string fullName;
        string country;
        bool isMan;

        public Author() { }

        public Author(string fullName, string country, bool isMan)
        {
            this.fullName = fullName;
            this.country = country;
            this.isMan = isMan;
        }
        #region Properties
        public string FullName { get => fullName; set => fullName = value; }
        public string Country { get => country; set => country = value; }
        public bool IsMan { get => isMan; set => isMan = value; }
        #endregion

        public override string ToString()
        {
            if(IsMan)
                return $"{FullName}, {Country}, мужчина";
            else
                return $"{FullName}, {Country}, женщина";
        }
    }
}
