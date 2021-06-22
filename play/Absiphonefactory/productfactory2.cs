using System;
using System.Collections.Generic;
using System.Text;

namespace Absiphonefactory
{

    public abstract class Watch
    {
        public abstract string GetDetails();
    }
    public class oneplusW : Watch
    {

        public override string GetDetails()
        {

            return "this is an oneplus smart  watch";
        }
    }

    public class AppleW : Watch
    {
        public override string GetDetails()
        {
            return "This is ans smart Watch from Apple";
        }

    }



}