using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{
    class Person
    {
        //constructor overloading
     /*   public Person()
        {

        }
        //banking purposes
        public Person(string aadhar):this()
        {
            Aadhar = aadhar;
        }
        //purpose: filling a form
        public Person(string name,int age,string address)
             :this()
        {
            Name = name;
            Age = age;
            Address = address;
        }
        //filling a form for the bank or mobile connection
        public Person(string aadhar, string name,string gender, string address,int age)
             :this(name,age,address)
            
        {

            Address = address;
            Gender = gender;


        }*/






        public string Aadhar{ get; set; }
        public string  Name{ get; set; }
        public  int Age { get; set; }
        public string Gender { get; set; }
        public string  Address { get; set; }
        public string complexion{ get; set; }

        public bool Works(string pTask,out string msg)
        {
            msg=$"{Name} has completed the task :{pTask}";
            return true;
        }
        //function overloading.
        public bool Works(params string[] pTasks)
        {
            return true;
        }
            public string Eats()
            {
           
              return  $"{Name} has had a sumptuous meal";


            }
        public float sleep()
        {

            return 8f;
            
        }
        public string Speaks(string words)
        {

            switch(words.ToLower())
            {
                case "good day":
                    return $"{Name}:{words};Alexa:Good to you tool";
                

                case "how are you":
                    return $"{Name}:{words};Alexa:I'm doing good,how about you?";
                default:
                    return $"{Name}:{words};Alexa:Sorry,I couldn't get that";


            }

            
        }
        ~Person(){}

         
          



    }
}
