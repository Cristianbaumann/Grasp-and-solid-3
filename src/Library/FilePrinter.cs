using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

public class FilePrinter : IPrinter
{
    public void PrintTicket(Recipe recipe)
    {
        File.WriteAllText("Ticket.txt", recipe.GetTextToPrint());
    }
}



}