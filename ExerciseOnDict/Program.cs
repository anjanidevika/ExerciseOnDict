using System;
using System.Collections.Generic;
class program
{
    public static void Main()
    {

        // Create a new dictionary of
        // strings, with string keys.
        Dictionary<string, string> Names =
          new Dictionary<string, string> { };

        Names.Add("1", "Anjali");
        Names.Add("2", "Pradeep");
        Names.Add("3", "Sagar");
        Names.Add("4", "Shreekesh");
        Names.Add("5", "Devika");
        Names.Add("6", "AAA");
        Names.Add("7", "Anjani");

        Console.WriteLine("Total key/value pairs in Dictionary are : " + Names.Count);

        Dictionary<string, string>.ValueCollection Coll =
                                                Names.Values;

        foreach (string b in Coll)
        {
            Console.WriteLine(b);
        }
        Names.Remove("6");
        Names.Remove("7");

        Console.WriteLine("Total key/value pairs in Dictionary are : " + Names.Count);
        foreach (string b in Coll)
        {
            Console.WriteLine(b);
        }

    }
}