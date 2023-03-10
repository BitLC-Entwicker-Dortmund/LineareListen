using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareListen {
    internal class Knoten {
        private int info;
        private Knoten next;

        public void SetInfo(int z) {
            info = z;
        }
        public int GetInfo() {
            return info;
        }
        public void SetNext(Knoten k) {
            next = k;
        }
        public Knoten GetNext() {
            return next;
        }
        // Konstruktoren
        public Knoten() { }
        public Knoten(int z) {
            info = z;
        }
        public Knoten(int z, Knoten k) {
            info = z;
            next = k;
        }
    }
}
