using System;
using System.Collections.Generic;
using System.Text;

namespace Absiphonefactory
{
    public abstract class Phone
    {

        public abstract string GetDetails();

    }
    public class IPhone : Phone
    {
        public override string GetDetails()
        {
            return "this is an iphone 12pro Max";
        }



    }
    public class oneplus : Phone
    {
        public override string GetDetails()
        {
            return "This is oneplus smart phone from BBK Electronic";
        }

    }









    
}


