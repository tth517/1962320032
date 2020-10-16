using System;

namespace Test
{
    public class Class1
    {
        public Class1(int A,int B,int X)
        {
            A = a;B = b;X = x;
            if (A > 1 && B == 0)
            {
                X = X / A;
            }
            if (A == 2 || X > 1)
            {
                X = X + 1;
            }
        }
        private int a,b,x;
    }
}
