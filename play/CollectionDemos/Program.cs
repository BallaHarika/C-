using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;

namespace CollectionDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Mycollection .WithArrayList();
            Mycollection.WithList();
            Mycollection.withDictionary();
            Mycollection.WithNamevalueCollection();
            Mycollection.WithGenerics();

        }
    }
    class Mycollection
    {

        public static void WithGenerics()
        {

            //create a registry schools
            Institution<School> schoolRegistry = new Institution<School>();
            schoolRegistry.Register(new School() { Name="pragathi vidyanikethan"});
            schoolRegistry.Register(new School() { Name = "shubhodya vidyanikethan " });

          //  objschol.Name = "njsdnsndnlw";

            foreach(var item in  schoolRegistry.institutes)
            {

                Console.WriteLine($"{item.Name}");
            }


        }
        public static void WithArrayList()
        {
            ArrayList multitypeList = new ArrayList();
            multitypeList.Add(1000);
            multitypeList.Add("meena");
            multitypeList.Add(new Mycollection());
            multitypeList.Add(null);

            //int result = 0; //Add up all the items
            

            foreach (var item in multitypeList)
            {
            //  result += Convert.ToInt32(item);
                Console.WriteLine(item);
            }

        }

        public static void WithList()
        {
            List<string> lsString = new List<string>();
            List<int> lsInts = new List<int>();
            List<Person> lsPersons = new List<Person>();

            //adding items
            lsString.Add("Eena");
            lsString.Add("meena");
            lsString.Add("Deena");

            //remove item
            lsString.Remove("Eena");

            //Update item
            lsString.Remove("Eena");//doubt2


            //Print
               lsString.ForEach((str) =>
                {
                    Console.WriteLine(str);
                });


            //Adding persons
            //    Person p = new Person();
            //    p.Name = "Meena";

            //{<property>=<value>,<property>=<value>}

            //    new Person() { Name = "meena", Aadhar = "S456092465115", Age = 20 };

            lsPersons.Add(new Person() { Name = "Harika", Aadhar = "456063", Age = 23 });
            lsPersons.Add(new Person() { Name = "Haritha", Aadhar = "9k6063", Age = 22 });
            lsPersons.Add(new Person() { Name = "laxmi", Aadhar = "4hjo063", Age = 46 });


            //find& remove
            Person PersonsToRemove = lsPersons.Find((p) => p.Name == "laxmi");
            lsPersons.Remove(PersonsToRemove);


            //find&update
            Person PersonsToUpdate = lsPersons.Find((p) => p.Name == "Haritha");
            PersonsToUpdate.Name = "Harika";

            //print
            lsPersons.ForEach((p) =>
            {
                Console.WriteLine($"{ nameof(p.Name)}:{p.Name}" +
                                   $"|{nameof(p.Age)}:{p.Age}" +
                                   $"|{nameof(p.Aadhar)}:{p.Aadhar}");

            });

        }
            public static void withDictionary()
            {
              Dictionary<int, string> myDictionary = new Dictionary<int, string>();
              myDictionary.Add(1, "Name property");
              myDictionary.Add(2, "Age property");
              myDictionary.Add(3, "Aadhar property");


            //Find
            var result1 = myDictionary.Where((item) => item.Key == 1).ToList();// doubt1
          


           // Console.WriteLine("printing result1");
            //Console.WriteLine(result1);


            //Update
            myDictionary[1] = "Full Name Property";

            //delete
            myDictionary.Remove(3);

            //print
            foreach (var item in myDictionary)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");


            }



        }

        public static void WithNamevalueCollection()
        {

            NameValueCollection myNameValueCollection = new NameValueCollection();
            myNameValueCollection.Add("name", "Harika");
            myNameValueCollection.Add("no", "9030");
            myNameValueCollection.Add("ad", "Tds9030");


            //find


            //Update
            myNameValueCollection.Set("no","number");


            //delete
            myNameValueCollection.Remove("ad");


            foreach (var item in myNameValueCollection.AllKeys )
            {
                string[] data = myNameValueCollection.GetValues(item);
                foreach (var values in data)
                {
                    Console.WriteLine($"{item}-value is {values}");
                }

            }
            

        }
            
        
    }


}
