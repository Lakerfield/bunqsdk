using System;
using System.Collections.Generic;
using System.Text;

namespace Lakerfield.BunqSdk.Model
{
  [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
  public sealed class BunqObjectAttribute : Attribute
  {
    public string Name { get; set; }

    // See the attribute guidelines at 
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    public BunqObjectAttribute(string name)
    {
      Name = name;
    }
  }
}
