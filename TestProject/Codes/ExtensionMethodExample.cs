namespace TestProject.Codes;

/*
    An extension method allows you to add new methods to existing types without modifying their code.
    You define it in a static class, using the this keyword before the type you want to extend.
    It looks like a regular method call, but it's actually added externally.
*/
public static class StringExtensionMethodExample
{
    public static bool CheckIfPalindrom(this string str)
    {
        if (str == null) return false;
        string lowerStr = str.ToLower();
        int l = lowerStr.Length;
        int s = 0, e = l - 1;
        while (s < e)
        {
            if (lowerStr[s] == lowerStr[e])
            {
                s++;
                e--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}

public static class NumberExtensionMethodExample {
    public static string ToOrdinal(this int number) {
        if (number <= 0)
        {
            return number.ToString();   
        }
        string suffix = "th";
        if (number % 100 / 10 != 1) {
            switch (number % 10)
            {
                case 1: suffix = "st"; break;
                case 2: suffix = "nd"; break;
                case 3: suffix = "rd"; break;
            }
        }
        return number + suffix;
    }
}