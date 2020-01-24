using System;
using System.Buffers.Text;

namespace fish_project {
    public class CatFish : Fish {
        public CatFish(double weight, string color, int speed)
            : base("pesce gatto", weight, color, speed, false) {
            base._style = '>';
        }

        public override string GetSwim => new string(this.GetStyle,
                                                     (1 + (10 * this.GetSpeed /
                                                           (int) Math.Floor((GetWeight + 2) / 2))) * 2);

        public override string ToString() {
            return "Nome : "     + base.GetName                    + "\n" +
                   "Peso : "     + base.GetWeight                  + "\n" +
                   "Colore : "   + base.GetColor                   + "\n" +
                   "Velocità : " + base.GetSpeed                   + "\n" +
                   "Habitat : "  + (base.IsSea ? "Mare" : "Fiume") + "\n" +
                   "Stile : "    + base.GetStyle                   + "\n" +
                   "Nuotata : "  + base.GetSwim                    + "\n";
        }
    }
}