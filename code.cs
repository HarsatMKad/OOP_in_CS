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
    public virtual void GetInfo()
    {
      Console.WriteLine("введите: Имя, Автора, Ключевые слова, Тему, Путь к файлу : ");
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
      Console.WriteLine("Документ типа Word.");
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
      Console.WriteLine("Документ типа PDF.");
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
    int LinesCount;
    int ColumnsCount;
    public override void GetInfo()
    {
      Console.WriteLine("Документ типа Excel.");
      base.GetInfo();
      Console.WriteLine("укажите количество строк и столбцов: ");
      LinesCount = Convert.ToInt32(Console.ReadLine());
      ColumnsCount = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
      base.Display();
      Console.WriteLine(" " + LinesCount + " " + ColumnsCount);
    }
  }

  class TXTDocument : Document
  {
    int SymbolsCount;
    public override void GetInfo()
    {
      Console.WriteLine("Документ типа TXT.");
      base.GetInfo();
      Console.WriteLine("укажите количество символов: ");
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
    string WebPageTitle;
    public override void GetInfo()
    {
      Console.WriteLine("Документ типа HTML.");
      base.GetInfo();
      Console.WriteLine("введите название сайта: ");
      WebPageTitle = Convert.ToString(Console.ReadLine());
    }
    public override void Display()
    {
      base.Display();
      Console.WriteLine(" " + WebPageTitle);
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
      Console.WriteLine("укажите необходимый тип документа(Doc, Word, PDF, Excel, TXT, HTML):");
      DocumentType = Convert.ToString(Console.ReadLine());

      switch (DocumentType)
      {
        case "Doc":
          Document Doc = new Document();
          Doc.GetInfo();
          Doc.Display();
          break;

        case "Word":
          WordDocument WordDoc = new WordDocument();
          WordDoc.GetInfo();
          WordDoc.Display();
          break;

        case "PDF":
          PDFDocument PDFDoc = new PDFDocument();
          PDFDoc.GetInfo();
          PDFDoc.Display();
          break;

        case "Excel":
          ExcelDocument ExcelDoc = new ExcelDocument();
          ExcelDoc.GetInfo();
          ExcelDoc.Display();
          break;

        case "TXT":
          TXTDocument TXTDoc = new TXTDocument();
          TXTDoc.GetInfo();
          TXTDoc.Display();
          break;

        case "HTML":
          HTMLDocument HTMLDoc = new HTMLDocument();
          HTMLDoc.GetInfo();
          HTMLDoc.Display();
          break;

        default:
          Console.WriteLine("введен некорректный тип документа");
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
