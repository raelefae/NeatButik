using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace ProductsLibrary
{
    public static class Database
    {
        public static List<Game> GetGames(string path)
        {
            var jsonData = File.ReadAllText("data/games.json");
            var result = JsonConvert.DeserializeObject<List<Game>>(jsonData);
            return result;
        }

        public static List<Guitar> GetGuitars(string path)
        {
            var jsonData = File.ReadAllText("data/guitars.json");
            var result = JsonConvert.DeserializeObject<List<Guitar>>(jsonData);
            return result;
        }

    }
}
