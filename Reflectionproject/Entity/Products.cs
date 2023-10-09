using Reflectionproject.Framework;
using Reflectionproject.Interface;

namespace Reflectionproject.Entity;

public class Products:Frameworks,IFlag
{
    public string name { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    
}