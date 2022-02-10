using System;

namespace AdvancedMathLibrary {
    
    public static class Math {
        // Adding new functions
        public const int Zero = 0;

        public static int AbsoluteValue(int x) {
            return (x < 0) ? -x : x; // The -x says reverse the sign if negative
            /* Terery statement is above and is simpler way of the if statement below
            if (x < 0; {
                return -x;
            } else {
                return x;
            }
             */
        }
        // 4 Arthemetic operators in separate methods
        public static int Add(int x, int y) {
            return x + y;
        }
        public static int Subtract(int x, int y) {
            return x - y;
        }
        public static int Multiply(int x, int y) {
            return x * y;
        }
        public static int Divide(int x, int y) {
            return x / y;
            //// This would cause the TestDivideByZero() to fail
            //if (y == 0)
            //{
            //    return 0;
            //}
        }
    }
}
