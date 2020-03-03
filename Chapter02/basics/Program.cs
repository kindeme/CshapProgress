using System;
using System.Linq;
using System.Reflection;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop through the asssemblies that this app references
            foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies()){
                var a = Assembly.Load(new AssemblyName(r.FullName));
                // declare a varaible to count the number of methods
                int methodCOunt = 0;
                //  loop through all types in the assembly
                foreach(var t in a.DefinedTypes){
                    // add up the counts of methods
                    methodCOunt += t.GetMethods().Count();
                    // 
                }
            }
        }
    }
}
