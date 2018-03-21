using System;

namespace ProductsLibrary
{
    public class Thing
        //Thing is a class inherited by all products, regardless of category.
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Brand { get; set; }
    }
}
