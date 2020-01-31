using System;

namespace fish_project {
    public class PufferFish : Fish {
        public PufferFish(double weight, string color, int speed)
            : base("pesce palla", weight, color, speed, false) {
            IsScared    = false;
            base.Style = ')';
            base.Habitat = true;
        }

        public bool IsScared { get; private set; }

        public override void Scare() {
            this.IsScared = true;
        }
        

        public override void Calm() {
            this.IsScared = false;
        }

      

        public override string ToString() {
            return "Nome : "     + base.GetName                                  + "\n" +
                   "Peso : "     + base.GetWeight                                + "\n" +
                   "Colore : "   + base.GetColor                                 + "\n" +
                   "Velocità : " + base.GetSpeed                                 + "\n" +
                   "Habitat : "  + (base.IsSea ? "Mare" : "Fiume")               + "\n" +
                   "Stile : "    + base.GetStyle                                 + "\n" +
                   "Nuotata : "  + base.GetSwim                                  + "\n" +
                   "Stato : "    + (this.IsScared ? "Spaventato" : "Tranquillo") + "\n";
        }
    }
}