using System;
using System.Collections.Generic;
using System.Text;

namespace Absiphonefactory
{
    public interface IAppleFranchise
    {
        Phone GetPhone(string name);
        Watch GetWatch(string name);
    }
    public class ApplePune : IAppleFranchise
    {
        public Phone GetPhone(string name)
        {
            switch(name.ToLower())
            {
                case"iphone":
                        return new IPhone();
                case "oneplus":
                         return new oneplus();
                default:
                        throw new Exception("phone not found");
            }

        }

        public Watch GetWatch(string name)
        {
            switch (name.ToLower())
            {
                case "iphone":
                    return new AppleW(); 
                case "oneplus":
                    return new oneplusW();
                default:
                    throw new Exception("phone not found");
            }
        }
    }
        public class ApplePcmc : IAppleFranchise
        {


            public Phone GetPhone(string name)
            {
            switch (name.ToLower())
            {
                case "iphone":
                    return new IPhone();
                case "oneplus":
                    return new oneplus();
                default:
                    throw new Exception("phone not found");
            }

            }
            public Watch GetWatch(string name)
            {

            switch (name.ToLower())
            {
                case "iphone":
                    return new AppleW();
                case "oneplus":
                    return new  oneplusW();
                default:
                    throw new Exception("phone not found");
            }
        }


        }



  



   
}
