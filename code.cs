using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Document
  {
    string Name;
    string Author;
    string Tags;
    string Topic;
    string PathToFile;

    public virtual void GetInfo() {
      Console.WriteLine("введите Имя, Автора, Ключевые слова, Тему, Путь к файлу: ");
      Name = Convert.ToString(Console.ReadLine());
      Author = Convert.ToString(Console.ReadLine());
      Tags = Convert.ToString(Console.ReadLine());
      Topic = Convert.ToString(Console.ReadLine());
      PathToFile = Convert.ToString(Console.ReadLine());
    }

    public virtual void Display()
    {
      Console.WriteLine(Name + " " + Author + " " + Tags + " " + Topic + " " + PathToFile);
    }
  }

  class WordDocument : Document
  {
    int WordsCount;

    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine("укажите количество слов: ");
      WordsCount = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
      base.Display();
      Console.WriteLine(" " + WordsCount);
    }
  }

  class PDFDocument : Document
  {
    int PagesCount;

    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine("укажите количество страниц: ");
      PagesCount = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
      base.Display();
      Console.WriteLine(" " + PagesCount);
    }
  }

  class ExcelDocument : Document
  {
    int LineCount, ColumnCount;

    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine("укажите количество сток и столбцов: ");
      LineCount = Convert.ToInt32(Console.ReadLine());
      ColumnCount = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
      base.Display();
      Console.WriteLine(" " + LineCount + " " + ColumnCount);
    }
  }

  class TXTDocument : Document
  {
    int SymbolsCount;

    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine("укажите количество сток и столбцов: ");
      SymbolsCount = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
      base.Display();
      Console.WriteLine(" " + SymbolsCount);
    }
  }

  class HTMLDocument : Document
  {
    int webPageTitle;

    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine("укажите количество сток и столбцов: ");
      webPageTitle = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
      base.Display();
      Console.WriteLine(" " + webPageTitle);
    }
  }

  public class Singleton
  {
    public static Singleton Instance
    {
      get
      {
        if (instance == null) instance = new Singleton();
        return instance;
      }
    }

    public void DocumentOutputMethod() 
    {
      string DocumentType;

      Console.WriteLine("укажите необходимый тип документа(Doc, Excel): ");
      DocumentType = Convert.ToString(Console.ReadLine());

      switch (DocumentType)
      {
        case ("Doc"):
          Document Doc = new Document();
          Doc.GetInfo();
          Doc.Display();
          break;
        case ("Excel"):
          ExcelDocument ExcelDoc = new ExcelDocument();
          ExcelDoc.GetInfo();
          ExcelDoc.Display();
          break;
        default:
          Console.WriteLine("неверный тип документа");
          break;
      }
    }
    private Singleton() { }
    private static Singleton instance;
  }

  class Program
  {
    static void Main(string[] args)
    {
      Singleton.Instance.DocumentOutputMethod();
      Console.ReadKey();
    }
  }
}
