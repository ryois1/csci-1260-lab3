using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Character : IComparable
    {
        public string _name { get; private set; }
        public string _game { get; private set; }
        public string _alignment { get; private set; }

        public static string[] Headers = { "Name", "Game", "Alignment" };

        public Character(string name, string game, string alignment)
        {
            _name = name;
            _game = game;
            _alignment = alignment;
        }


        public override string ToString()
        {
            return $"{_name} is from game \"${_game} with alignment ${_alignment}";
        }

        public int CompareTo(Object? obj)
        {
            Character? other = obj as Character;
            return _name.CompareTo(other._name);
        }
    }
}
