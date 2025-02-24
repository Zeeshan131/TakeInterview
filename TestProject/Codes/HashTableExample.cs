using System.Collections;

namespace TestProject.Codes;
public class HashTableExample
{
    public static void HashTableEx()
    {
        Hashtable my_hash = new Hashtable();
        my_hash.Add(1, "Value 1");
        my_hash.Add(2, "Value 2");
        my_hash.Add(3, "Value 3");
        my_hash.Add(4, "Value 4");

        foreach (DictionaryEntry elm in my_hash)
        {
            Console.WriteLine("Key: {0}. Value: {1}", elm.Key, elm.Value);
        }
    }
}
