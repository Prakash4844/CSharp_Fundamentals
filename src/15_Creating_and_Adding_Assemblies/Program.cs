using MyCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingReferenceToAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Clear Console
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Adding Reference To Assemblies")); //Prints in the middle on console

            /*Learn about .NET assemblies: code libraries and executables, debug and release versions of assemblies. 
             * Plus, see how to reference assemblies, utilize NuGet, and create references to custom libraries.*/

            /*
             The .Net Class Library is devided in different assemblies and namespaces that are referenced to use
                the features that they provides. Some of the most common assemblies are automatically referenced, 
                but if you want to use other functionality that are not part of these already referenced assemblies.

            Then You would need to referenced them.

            Commonely There are Three Type of Library that are used.
            1 .NET Class Library(Provided by MS)
            2 Open Soured library(Community created, Common Feature, Freely available)(Available through NuGet GUI or CLI)
            3 User created(Created by you)
             */

            /*PHASE-1   (Referencing Assemblies that are part of .NET Class Library):
             * 
            if you want to reference other assemblies that are part of .NET CLass Libraryl, Follow These Steps:
            1. Select the project in the Solution Explorer.
            2. Select Project»Add Reference to launch the Add Reference dialog box.
            3. (Visual Studio 2012 and later) Click the Assemblies item and select Extensions. 
                                Select TestStand <Version> Utilities from the list of components.
            4. Click OK to close the Add Reference dialog box.
             */

            /*PHASE-2 (Using NuGet)
            1. In Solution Explorer, right-click References and choose Manage NuGet Packages.
            2. Manage NuGet Packages command for project References
            3. Choose "nuget.org" as the Package source, select the Browse tab, search for Newtonsoft.Json, select that package in the list, and select Install:
            4. Locating Newtonsoft.Json package
            5. If you want more information on the NuGet Package Manager, see Install and manage packages using Visual Studio.
            6. Accept any license prompts.
            7. (Visual Studio 2017 only) If prompted to select a package management format, select PackageReference in project file:
            8.0Selecting a package management format

            9. If prompted to review changes, select OK.             
             */

            /*PHASE-3 (Using User Created Library)
             * 1. Select the project in the Solution Explorer.
               2. Select Project»Add Reference to launch the Add Reference dialog box.
               3. Click Browse to Browse to Your Library Select it and click OK.
               4. Now add Correct Using Statement in Your code to use the functionality of your Library
             
             */
              
             Scrape MyScrape = new Scrape();
            string value = MyScrape.ScrapeWebpage("https://Google.com");
            Console.WriteLine(value);

        }
    }
}