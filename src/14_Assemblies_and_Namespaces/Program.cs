using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth/2 + "}", "Assemblies And Namespaces")); //Prints in the middle on console

            /*

            Assemblies:-
            In the Microsoft .NET framework, an assembly is a partially compiled code library for use in deployment, versioning and security.

            An assembly is the compiled output of your code, typically a DLL, but your EXE is also an assembly. 
            It's the smallest unit of deployment for any .NET project.

            The assembly typically contains .NET code in MSIL (Microsoft Intermediate language) that will be compiled to native code 
            ("JITted" - compiled by the Just-In-Time compiler) the first time it is executed on a given machine. 
            That compiled code will also be stored in the assembly and reused on subsequent calls.

            The assembly can also contain resources like icons, bitmaps, string tables and so on. Furthermore, 
            the assembly also contains metadata in the assembly manifest - information like version number, strong name, culture, 
            referenced assemblies and so forth.

            In 99% of your cases, one assembly equals a physical file on disk

            In a multifile assembly there would still be only one assembly manifest in a DLL or EXE and the MSIL code in multiple netmodule files.
            */
            // =======================================================================================================================================

            /*Namespaces:-
            A namespace is designed for providing a way to keep one set of names separate from another. 
            The class names declared in one namespace does not conflict with the same class names declared in another.
            
            Within a namespace, you can declare zero or more of the following types:

            class
            interface
            struct
            enum
            delegate

            nested namespaces can be declared except in file scoped namespace declarations
            The compiler adds a default namespace. This unnamed namespace, sometimes referred to as the global namespace, is present in every file. It contains declarations not included in a declared namespace. Any identifier in the global namespace is available for use in a named namespace.

            Namespaces implicitly have public access. 


            A namespace definition begins with the keyword namespace followed by the namespace name as follows −

            namespace namespace_name 
            {
                // code declarations
            }

            To call the namespace-enabled version of either function or variable, prepend the namespace name as follows −

            namespace_name.item_name;

            The using keyword states that the program is using the names in the given namespace.
            You can also avoid prepending of namespaces with the using namespace directive. 
            This directive tells the compiler that the subsequent code is making use of names in the specified namespace.

            */

            //We can use Different functionality of Dotnet Class Library by referencing and Using it in our code 
            //Here's a Example of How to write a string to a FILE using Dotnet class Library's System.IO

            string PokemonJourneyTheme =  @"ねえ、まだまだまだ？急いで！
出かける準備はできたかい？
キミに見せたい不思議の世界
見送りならいらない

たとえ火の中　水の中
手さぐりで見えない今日の中
１秒先だってまだ知らないけど 
いつも思い出はどれも
全部ボールの中に  

１・２・３で飛び込め！
いつか描いた未来がボクのポケットにあるから
はじめましてはいつだって初めてさ
ためらうことなどナイ！（ナイ！）トライ！（トライ！）
Let's have a fight!

１．バトルをしたなら
２．笑うか泣いたって
３. で仲間になろうよ

あの日だって　この日だって　いつだってそうしていた
先も見えない　果ても知らない世界がそこにあるけど

レッツゴー　転んですりむいて
レッツゴー　何度も歩き出す隣
キミにきめた！";

            //System.IO.File.WriteAllText(@"D:\Users\Zaphkil!\Documents\VS Code\C#\NEWER\CSharp_Fundamentals\src\14_Assemblies_and_Namespaces\Pokemon.txt", PokemonJourneyTheme);
                        //we are giving Full Namespace System.IO we can also use "Using System.IO" to avoid prepending it each time. 
                        //we use a method of this namespace

            File.WriteAllText(@"D:\Users\Zaphkil!\Documents\VS Code\C#\NEWER\CSharp_Fundamentals\src\14_Assemblies_and_Namespaces\Pokemon.txt", PokemonJourneyTheme);
            //Like This

            // System.Net.WebClient client = new System.Net.WebClient(); //We can Use System.Net Each time or Use a "Using System.Net" Statement
            WebClient client = new WebClient(); 
            string reply = client.DownloadString("https://google.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"D:\Users\Zaphkil!\Documents\VS Code\C#\NEWER\CSharp_Fundamentals\src\14_Assemblies_and_Namespaces\Google.html", reply);

        }
    }
}

