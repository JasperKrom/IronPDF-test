// See https://aka.ms/new-console-template for more information
using TestConsole.PDF;

var ironEngine = new IronPDFEngine();

ironEngine.StampPDF();
ironEngine.LockPDF();

Console.WriteLine("Done");
Console.ReadLine();