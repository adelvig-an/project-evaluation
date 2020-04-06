using System.Collections.Generic;

namespace _01_Eva
{
    class Category
    {
        public string Name { get; set; }
        public List<object> Items { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
