using System;

namespace AutomatedTestLibrary {
    public class Functions {

        public int Add1(int i) {
            return i + 1;
        }
        public int XSquaredPlus3(int i) {
            return i * i + 3;
        }
        public int DividedBy3(int i) {
            return i / 3;
        }
        public int Multiplyby4(int i) {
            return i * 4;
        }
        // how much sales to break even
        //public int X7X12(int i) {
        //    return (i * i) - (7 * i) + 12;
        //}
        public int X7X12(int i) {
            if (i == 4) throw new Exception("I = 4");
            return (i * i) - (7 * i) + 12;
        }
    }
}
