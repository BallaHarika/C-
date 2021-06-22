using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace Usingreflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".GetType());
            Console.WriteLine($"fully qualified name for type 'program':{typeof(haha)}");

          //  GetPropsAndMethods();

            JsonParsing();
            //create instance dynamically
          //   Instatiate();
         //   VarVsDynamic();
            /*
             * {
             * "a":1
             * "b":"1"
             * 
             * }
             * 
             */


        }
        static void VarVsDynamic()
        {
            dynamic sampleObject = new ExpandoObject();
            Console.WriteLine(sampleObject);
            sampleObject.Prop = "This property is created in dynamic object";
            Console.WriteLine($"Value of prop:{sampleObject.Prop}");

            sampleObject.Increment = new Action<int>((i) => Console.WriteLine(i + 1));

            sampleObject.Increment(10);


            /*
             * JSON :javascript object Notation
             * {
             *   aadhar:"Dgahja",name:"meena"
             * }
             */

        }
        static void JsonParsing()
        {

            /*Json object
             * {
             * "a":"Robert"
             *  "b":{"b1":100,
             *        "b2":'abc'}
             * }
             * 
             * */

      //var is used when you want to decide the datatype based on the RHS value
      //var a=10;-----INT32
      //Real application:
      //var result=new Func<int,person>((i)=>new person());


            //var dynobj=JsonConvert.DeserializeObject<ExpandoObject>("{\"a\":1,\"b\":\"1"}") as dynamic;
            

            dynamic json = JsonConvert.DeserializeObject<ExpandoObject>("{\"a\":\"Robert\",\"b\":{\"b1\":100,\"b2\":\'abc\'}}");

          //  Console.WriteLine($"dynObj.a={dynObj?.a.GetType()}");
            Console.WriteLine($"json.b={json?.b.b1},type of{json?.b.b1.GetType()}");


        }




     public   static void GetPropsAndMethods()
        { 
            //Get properties of a type
            Type datatype = "hello".GetType(); //System.String
            foreach(var property in datatype.GetProperties())
            {
                Console.WriteLine($"propertyName:{property.Name}"); //nameof()
            }
            foreach(var method in datatype.GetMethods())
            {
                Console.WriteLine($"MethodName:{method.Name}");
            }


        }

       public static void Instatiate()
        {
            Console.WriteLine("Give us a type & we will instatite it!");
            string s = Console.ReadLine();

            //Discover the real datatype
            Type t = Type.GetType(s);

            //Instatiate it
            var Instance = Activator.CreateInstance(t);

            GetMembersByType(t);
        }
      public  static void GetMembersByType(Type o)
        {

            foreach (var property in o.GetProperties())
            {
                Console.WriteLine($"propertyName:{property.Name}"); //nameof()
            }
            foreach (var method in o.GetMethods())
            {
                Console.WriteLine($"MethodName:{method.Name}");
            }
        }
    }
   public class haha {
        public int  Id { get; set; }
        public string Sound { get; set; }

        public int TimesOfHaha { get; set; }
    }

}
