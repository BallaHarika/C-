using System;

namespace CoreLogicLayer
{
    internal class TestAccess
    {
        public int TAProp { get; set; }


        Test.TestAcrossNamespace obj = new Test.TestAcrossNamespace();    //Field
        public IAminternal objInternal { get; set; }
        private class IAmPrivate
        {
            public int IAPProp { get; set; }
        }
        internal class IAminternal
        {
            public int IAINProp { get; set; }
        }


    }

    public class IAmpublic
    {
        public int IAPUrop { get; set; }

    }
}
namespace Test
{
    public class TestAcrossNamespace
    {
        internal int DifferentNameSpaceProp { get; set; }

    }

}

