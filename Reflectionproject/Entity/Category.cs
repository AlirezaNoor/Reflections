using Reflectionproject.Framework;
using Reflectionproject.Interface;

namespace Reflectionproject.Entity;

public class Category: Frameworks,IFlag
{
    public string   title { get; set; }
    public string subcategory { get; set; }
    
}