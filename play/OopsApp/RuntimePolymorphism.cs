using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{

    public interface Iclone
    {
        public Shape Cloneobject { get; set; }
        Shape Clone();
    }
    public abstract class Shape
    {
       
       
        public int  NormalProperty  { get; set; }
        public abstract string Draw();
        //circle =shape class features +extras
        //Hence ,shape c=new circle(); {Base class =new Derived Class()}
        public virtual string GetStatus()
        {
            return "A sample shape status";
        }
    
    }
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Shape ClonedObject { get; set; }

        public Shape Clone()
        {
            ClonedObject = new Circle();
            ((Circle)ClonedObject).Radius = this.Radius;
            return ClonedObject;
        }





        public override string Draw()
        {
            NormalProperty = 100;
            return $"A circle is drawn with radius:{Radius}";
        }
        public override string GetStatus()
        {
            return base.GetStatus();
        }
    }

   

    //Triangle =Shape class+extras
    //Hence ,Shape t=new Triangle();
    public class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }
        public override string Draw()
        {
            return $"A triangle is drawn with base :{ Base} and Height :{Height}";
        }



    }




}
