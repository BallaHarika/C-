using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
namespace JsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFile();
            Post mypost = new Post()
            { 
                userid=1,
                id=1,
                title= "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                body= "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"


            };
            //Serialize above object .c# to join

            string serializedpost = JsonConvert.SerializeObject(mypost);
            Console.WriteLine(serializedpost);

            //now ,deserialize it back to post object
            Post resultpost = JsonConvert.DeserializeObject<Post>(serializedpost);

            Console.WriteLine("### deserialized post object ####");
            Console.WriteLine($"resultPost.userid:{resultpost.userid}");

            Console.WriteLine($"resulPost.id:{resultpost.id}");
            Console.WriteLine($"resultPost.title:{resultpost.title}");

            Console.WriteLine($"resultPost.body:{resultpost.body}");
        }

        static void CreateFile()
        {

            FileStream fs = new FileStream(@"C:\Users\admin\Documents\sampleFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite,FileShare.None);
            string text= "Hello ,I look different when converted to byte?";
            byte[] textsbytes  =Encoding.UTF8.GetBytes(text);
            fs.Write(textsbytes,0,textsbytes.Length);

            fs.Close();
        }




    }

    public class Post
     {
        public  int  userid { get; set; }
        public int id { get; set; }
        public string  title { get; set; }
        public string body{ get; set; }
     }
}
