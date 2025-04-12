using OCP;

namespace OCP.Problem;

public class PrintManager
{
    private readonly TxtWriter _txtWriter = new();
    private readonly PdfWriter _pdfWriter = new();
    private readonly ConsoleWriter _consoleWriter = new();
    private readonly EmailWriter _emailWriter = new();

    public void PrintToTxt(Order order)
    {
        _txtWriter.Write(order.Id, order.OrderItemsList);
    }
    
    public void PrintToConsole(Order order)
    {
        _consoleWriter.Write(order.Id, order.OrderItemsList);
    }
    
    public void PrintToPdf(Order order)
    {
        _pdfWriter.Write(order.Id, order.OrderItemsList);
    }
    
    public void PrintToEmail(Order order)
    {
        _emailWriter.Write(order.Id, order.OrderItemsList);
    }
    
}