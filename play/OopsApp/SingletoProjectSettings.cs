using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{
    public class SingletoProjectSettings
    {

        //readonly ensues thread-safty when many people try to access it
        //simultaneously 
        private static readonly SingletoProjectSettings _instance = new SingletoProjectSettings();
        private SingletoProjectSettings() { }

        //here return type of instance is Singletoprojectsettings
        public  static SingletoProjectSettings GetInstance()
        {
            return _instance;
        }


        public string AssemblyName { get; set; }

        public string DefaultNamespace { get; set; }

        public string TargetFramework { get; set; }

        public string OutputType { get; set; }

        class Test : SingletoProjectSettings { }

            
    }
}
