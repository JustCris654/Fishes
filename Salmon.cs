namespace fish_project {
    public class Salmon : Fish {
        private string _river;

        public Salmon(double weight, string color, int speed, string river)
            : base("salmone", weight, color, speed, false) {
            this._river = river;
            base._style = '/';
        }

        public string GetRiver => _river;

        public override string ToString() {
            return "Nome : "            + base.GetName                    + "\n" +
                   "Peso : "            + base.GetWeight                  + "\n" +
                   "Colore : "          + base.GetColor                   + "\n" +
                   "Velocità : "        + base.GetSpeed                   + "\n" +
                   "Habitat : "         + (base.IsSea ? "Mare" : "Fiume") + "\n" +
                   "Stile : "           + base.GetStyle                   + "\n" +
                   "Nuotata : "         + base.GetSwim                    + "\n" +
                   "Fiume d'origine : " + this._river                     + "\n";
        }
    }
}