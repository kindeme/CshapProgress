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
                int methodCount = 0;
                //  loop through all types in the assembly
                foreach(var t in a.DefinedTypes){
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                    // output the count of types and their methods
                    Console.WriteLine(
                        "{0:N0} types with {1:N0} methods in {2} asssembly.", 
                        arg0: a.DefinedTypes.Count(),
                        arg1: methodCount,
                        arg2: r.Name
                    );
                }
            }
        }
    }
}
