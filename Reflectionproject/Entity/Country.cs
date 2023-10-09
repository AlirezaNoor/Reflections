using Reflectionproject.Framework;
using Reflectionproject.Interface;

namespace Reflectionproject.Entity;

public class Country : Frameworks, IFlag
{
    public string name { get; set; }
    public int code { get; set; }
}