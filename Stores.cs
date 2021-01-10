using System;

namespace SSMS1
{
    public class Stores
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public int Category_ID { get; set; }

        public override int GetHashCode()
        {
            return (int)Id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Floor} {Category_ID}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Stores other = obj as Stores;
            if (other == null)
                return false;

            return this.Id == other.Id;
        }
    }
}