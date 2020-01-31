using System.Collections.Generic;
using System.Linq;

namespace fish_project {
    public class Fishtank {
        private double     _capacity;
        private string     _type;
        private int        _maxFishes;
        private List<Fish> _fishes;

        public Fishtank(double capacity, string type) {
            _capacity = capacity;
            _type     = type;
        }

        public Fishtank() : this(0, "") {
        }

        public bool AddFish(Fish fish) {
            if (_fishes.Count == _maxFishes || _fishes.FindIndex(x => x.GetName == fish.GetName) != -1) return false;
            _fishes.Add(fish);
            return true;
        }

        public bool AddFish(List<Fish> fishes) {
            if (_fishes.Count + fishes.Count >= _maxFishes) return false;
            // var fishesToAdd = from fish in fishes
            //                   where _fishes.FindIndex(x => x.GetName == fish.GetName) == -1
            //                   select fish;
            _fishes.AddRange((from fish in fishes
                              where _fishes.FindIndex(x => x.GetName == fish.GetName) == -1
                              select fish).ToList());
            return true;
        }

        // public bool AddCasualFish() {
        //     _fishes.Add();
        // }

        public void ScareFishes() {
            _fishes.ForEach(x => x.Scare());
        }

        public double TotalWeight() {
            return _fishes.Sum(x => x.GetWeight);
        }

        public override string ToString() {
            return "Capacità acquario: "    + this._capacity + "\n" +
                   "Acqua: "                + _type          + "\n" +
                   "Numero pesci massimo: " + _maxFishes     + "\n" +
                   "Pesci: "                + "\n\n"         + _fishes.Select(x => x.ToString());
        }
    }
}