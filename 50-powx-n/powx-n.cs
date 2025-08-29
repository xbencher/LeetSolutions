public class Solution {
    public double MyPow(double x, int n) {
       long power = n;
    if (power < 0) {
        x = 1 / x;
        power = -power;  // safe because we use long
    }

    double res = 1;
    while (power > 0) {
        if ((power & 1) == 1) { // if odd
            res *= x;
        }
        x *= x;      // square the base
        power >>= 1; // divide exponent by 2
    }

    return res;
    }
}