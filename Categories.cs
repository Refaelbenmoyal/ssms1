using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMS1
{
    class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override int GetHashCode()
        {
            return (int)Id;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Categories other = obj as Categories;
            if (other == null)
                return false;

            return this.Id == other.Id;
        }
    }
}
