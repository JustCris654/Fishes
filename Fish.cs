using System;
using System.Text.RegularExpressions;

namespace fish_project {
    public class Fish {
        private   string _name;    //GetName
        private   double _weight;  //GetWeight
        private   string _color;   //GetColor
        private   int    _speed;   //GetSpeed
        private   bool   _habitat; //true se è di mare, false se è di fiume o lago      //isSea - isSoft
        protected char   _style;   //GetStyle

        public Fish(string name, double weight, string color, int speed, bool habitat) {
            _style   = '.';
            _name    = name;
            _weight  = weight;
            _color   = color;
            _speed   = speed;
            _habitat = habitat;
        }

        public Fish() : this("def_n", 0, "def_c", 0, false) {
        }

        public override string ToString() {
            return "Nome : "     + this._name                                + "\n" +
                   "Peso : "     + this._weight                              + "\n" +
                   "Colore : "   + this._color                               + "\n" +
                   "Velocità : " + this._speed                               + "\n" +
                   "Habitat : "  + (this._habitat ? "Mare" : "Fiume - Lago") + "\n" +
                   "Stile"       + this._style                               + "\n";
        }

        public bool IsSea  => _habitat;
        public bool IsSoft => !_habitat;

        public string GetName   => _name;
        public double GetWeight => _weight;
        public string GetColor  => _color;
        public int    GetSpeed  => _speed;
        public char   GetStyle  => _style;

        public virtual string GetSwim =>
            new string(this.GetStyle, 1 + (10 * this.GetSpeed / (int) Math.Floor((GetWeight + 2) / 2)));
    }
}