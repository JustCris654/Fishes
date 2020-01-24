namespace fish_project {
    public class PufferFish : Fish {
        private bool _scared;
        public PufferFish(double weight, string color, int speed)
            : base("pesce palla", weight, color, speed, false) {
            _scared = false;
            base._style = ')';
        }

        public bool IsScared => this._scared;

        public void Scare() {
            _scared = true;
        }

        public void Calm() {
            _scared = false;
        }
        
        
        
    }
}