using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyNateSharpDisasm
{
  public static class ManagedEntryPoint
  {
    public static string EntryTypeName { get { return "CrazyNateSharpDisasm.ManagedEntryPoint"; } }
    public static string EntryMethodName { get { return "Enter"; } }
    public static string EntryArgument { get { return "hello"; } }

    public static int Enter(string arg)
    {
      // This method doesn't really need to do anything on load
      return 1;
    }
  }
}
