namespace lab1.Services.lab3;

public abstract class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    
    public int GetArea()
    {
        return Width * Height;
    }
     public int GetArea(int x)
    {
        return Width * Height * x;
    }
    
    public virtual int GetShorterSize()
    {
        return new List<int>(){Width, Height}.Min();
    }
    
    public int GetLongerSize()
    {
        return new List<int>(){Width, Height}.Max();
    }
    
    public int GetPerimeter()
    {
        return (Width + Height) * 2;
    }
    
    
}