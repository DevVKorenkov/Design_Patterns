using Composite.Example;
using Composite.Example.Abstraction;

public class Program
{
    public static void Main()
    {
        Component fileSystem = new Composite.Example.Directory("File system");
        Component diskC = new Composite.Example.Directory("Disk C");

        Component pngFile = new Composite.Example.File("1234.png");
        Component docxFile = new Composite.Example.File("Document.docx");
        
        diskC.Add(pngFile);
        diskC.Add(docxFile);
        
        fileSystem.Add(diskC);
        
        fileSystem.Print(); 

        Console.ReadKey();
        
        diskC.Remove(pngFile);
        
        Component docsFolder = new Composite.Example.Directory("My documents");
        
        Component txtFile = new Composite.Example.File("readme.txt");
        Component csFile = new Composite.Example.File("Program.cs");
        docsFolder.Add(txtFile);
        docsFolder.Add(csFile);
        diskC.Add(docsFolder);
         
        fileSystem.Print();
 
        Console.ReadKey();
    }
}