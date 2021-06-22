using System;
using System.Collections.Generic;
using System.Text;

namespace Absiphonefactory
{
    //Think of this like a webpage ,where you a textbox and serach button.In the textnox,you will provide
    //shop ,product you are looking for.
   public class MobileClient
    {
        Phone appplePhone;
        string  Name;
        public MobileClient(IAppleFranchise shop,string name)
        {
            appplePhone = shop.GetPhone(name);

        }

        public string GetPhoneDetails()
        {
            return appplePhone.GetDetails();
        }

    }
}
