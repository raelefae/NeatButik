using System;
using System.Collections.Generic;

namespace ProductsLibrary
{
    public class Game : Thing
    {
        /*
        * This is the game's PEGI/maturity rating.
        * Most of the ratings are ages (3, 7, 12, 16, 18),
        * so it could be an integer, but there's also the ! rating.
        * That's why I've made it a string.
        */
        public string Pegi { get; set; }
        public string Genre { get; set; }
    }
}
