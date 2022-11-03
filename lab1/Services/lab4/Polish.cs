namespace lab1.Services.lab4;

public class Polish : Language, ILanguage
{ 
    public string name { get; set; }
    
    public Polish(string name)
    {
        this.name = name;
    }
    public override string GetLang()
    {
        return "pl";
    }
    
    public string GetLanguageName()
    {
       return this.name;
    }
}