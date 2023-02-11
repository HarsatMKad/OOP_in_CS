using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
  class Document {
    string Name;
    string Author;
    string Tags;
    string Topic;
    string PathToFile;
    public void Read(string ReadName, string ReadAuthor, string ReadTags, string ReadTopic, string ReadPathToFile) {
      Name = ReadName;
      Author = ReadAuthor;
      Tags = ReadTags;
      Topic = ReadTopic;
      PathToFile = ReadPathToFile;
    }
    public void Display() {
      Console.WriteLine(Name + " " + Author + " " + Tags + " " + Topic + " " + PathToFile);
    }
  }

class Program {
      static void Main(string[] args) {

        Document NewDocument = new Document();
        string RN, RA, RTa, RTo, RP;

        Console.WriteLine("введите Имя, Автора, Ключевые слова, Тему, Путь к файлу: ");
        RN = Convert.ToString(Console.ReadLine());
        RA = Convert.ToString(Console.ReadLine());
        RTa = Convert.ToString(Console.ReadLine());
        RTo = Convert.ToString(Console.ReadLine());
        RP = Convert.ToString(Console.ReadLine());

        NewDocument.Read(RN, RA, RTa, RTo, RP);
        NewDocument.Display();

		Console.ReadKey();
	  }
   }
}
