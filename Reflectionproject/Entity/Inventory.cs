using Reflectionproject.Framework;
using Reflectionproject.Interface;

namespace Reflectionproject.Entity;

public class Inventory:Frameworks,IFlag
{
    public string voucher { get; set; }
    public string suppliers { get; set; }
    public string phone { get; set; }
}