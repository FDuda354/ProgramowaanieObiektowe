namespace lab1.Services.lab5;

public class SomeClass
{
    public string Print(string text)
    {
        try
        {
            return text.Length.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new CustomEx.InvalidDepartmentException("filip jest xd"); // tutaj wyrzucam wyjątek

            return "0";
        }
        
    }
    
    
    
    
}