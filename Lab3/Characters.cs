using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3
{
    internal class Characters
    { 
        public List<Character> characters = new List<Character>();

        public Characters() {
            string rootFolder = GetRoot.rootFolder;
            string file = "characters.csv";
            string fullPath = Path.Combine(rootFolder, file);
            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string? line = sr.ReadLine();
                    string[]? data = line.Split(',');
                    characters.Add(new Character(data[0], data[1], data[2]));

                }
            }
        }
        public Characters(List<Character> characters) {

            this.characters = characters;

        }

        public List<Character> GetCharacters() { return characters; }

        public Character GetCharacter(int index) { return characters[index]; }

        public Character GetCharacter(string name)
        {
            var reponse = characters.Find(r => r._name == name);
            return reponse;
        }

        public List<Character> Sort()
        {
            var newList = characters.OrderBy(x => x._name).ToList();
            return newList;
        }

        public List<Character> FilterByGame(string game)
        {
            var newList = characters.FindAll(x => x._game.ToUpper() == game.ToUpper());
            newList.Sort();
            return newList;
        }

        public List<Character> FilterByAlignment(string alignment)
        {
            var newList = characters.FindAll(x => x._alignment.ToUpper() == alignment.ToUpper());
            newList.Sort();
            return newList;
        }

    }
}
