using System;
using System.Text.RegularExpressions;

namespace fish_project {
    public class Fish {
        private          string _name;   //GetName
        private          double _weight; //GetWeight
        private          string _color;  //GetColor
        private readonly int    _speed;  //GetSpeed
        protected        bool   Habitat; //true se è di mare, false se è di fiume o lago      //isSea - isSoft
        protected        char   Style;   //GetStyle

        public Fish(string name, double weight, string color, int speed, bool habitat) {
            Style   = '.';
            _name   = name;
            _weight = weight;
            _color  = color;
            _speed  = speed;
            Habitat = habitat;
        }

        public virtual void Scare() {
            return;
        }

        public virtual void Calm() {
            return;
        }

        public Fish() : this("def_n", 0, "def_c", 0, false) {
        }

        public override string ToString() {
            return "Nome : "     + this._name                               + "\n" +
                   "Peso : "     + this._weight                             + "\n" +
                   "Colore : "   + this._color                              + "\n" +
                   "Velocità : " + this._speed                              + "\n" +
                   "Habitat : "  + (this.Habitat ? "Mare" : "Fiume - Lago") + "\n" +
                   "Stile"       + this.Style                               + "\n";
        }

        public bool IsSea  => Habitat;
        public bool IsSoft => !Habitat;

        public string GetName   => _name;
        public double GetWeight => _weight;
        public string GetColor  => _color;
        public int    GetSpeed  => _speed;
        public char   GetStyle  => Style;

        public virtual string GetSwim =>
            new string(this.GetStyle, 1 + (10 * this.GetSpeed / (int) Math.Floor((GetWeight + 2) / 2)));
    }
}