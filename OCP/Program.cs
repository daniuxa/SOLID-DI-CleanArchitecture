using OCP;

var order = new Order();

#region Problem
var printManager = new OCP.Problem.PrintManager();
printManager.PrintToTxt(order);
printManager.PrintToEmail(order);
printManager.PrintToConsole(order);
printManager.PrintToPdf(order);

#endregion

#region Solution
var printManagerSolution = new OCP.Solution.PrintManager();
var consoleWriter = new OCP.Solution.ConsoleWriter();
var emailWriter = new OCP.Solution.EmailWriter();
var pdfWriter = new OCP.Solution.PdfWriter();
var txtWriter = new OCP.Solution.TxtWriter();

printManagerSolution.Print(order, consoleWriter);
printManagerSolution.Print(order, emailWriter);
printManagerSolution.Print(order, pdfWriter);
printManagerSolution.Print(order, txtWriter);
#endregion