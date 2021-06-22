using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Car
    {
        public abstract string Purchase();

    }
    public class Maruti : Car
    {
        public int price { get; set; }
        public override string Purchase()
        {
            return $"A Maruti car purchased and price is:{price}";
        }
    }


    //Triangle =Shape class+extras
    //Hence ,Shape t=new Triangle();
    public class Benz : Car
    {

        public int price { get; set; }
        public override string Purchase()
        {
            return $"A ferrari car  purchased and price is :{price}";
        }



    }

    public class Ferrari : Car
    {

        public int price { get; set; }
        public override string Purchase()
        {
            return $"A Ferrari purchased and price is:{price}";
        }



    }


}
