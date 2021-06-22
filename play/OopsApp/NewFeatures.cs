using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{
    public class NewFeatures
    {

        #region Tuples
        public Tuple<int,string,bool> GetValues123_v1()
        {
            Tuple<int, string, bool> result =new Tuple<int, string, bool> (100, "Meena", true);
            return result;
        }

        public (int, string, bool) GetValues123_v2()
        {

            return (100,"Meena", true);
        }

        public (int rValue,string name,bool isTrue) GetValue123_v3()
        {
            return (100,"Meena",true);
        }
        #endregion Tuples

        #region     Pattern Matching

        public void TestShapes(Shape s)
        {

            switch (s)
            {
                case Circle c when c.Radius == 0:

                    break;
                case Triangle t when t.Base == 0 || t.Height == 0:
                    Console.WriteLine("please specify dimension");
                    break;
                default:
                    break;
            }



        }
        #endregion  Pattern Matching



    }
}
