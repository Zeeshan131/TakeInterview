namespace PracticeDSA.Programs;

public static class Test
{
    public static bool IsRotated(string s1, string s2)
    {
        int l = s1.Length;
        string rs1 = RotateLeft(s1, 2);
        string rs2 = RotateLeft(s1, l - 2);
        Console.WriteLine("rs1:" + rs1);
        Console.WriteLine("rs2:" + rs2);
        if (s2 == rs1 || s2 == rs2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string RotateLeft(string str, int n)
    {
        char[] cs = str.ToCharArray();
        int l = cs.Length;
        n %= l;
        int s = 0, e = l - 1;
        Reverse(cs, s, e);
        Reverse(cs, s, n - 1);
        Reverse(cs, n, e);
        return new string(cs);
    }

    public static string RotateRight(string str, int n)
    {
        char[] cs = str.ToCharArray();
        int l = cs.Length;
        n %= l;
        int s = 0, e = l - 1;
        Reverse(cs, s, e);
        Reverse(cs, s, e - n);
        Reverse(cs, e - n + 1, e);
        return new string(cs);
    }

    public static void Reverse(char[] cs, int s, int e)
    {
        while (s < e)
        {
            char temp = cs[s];
            cs[s] = cs[e];
            cs[e] = temp;
            s++;
            e--;
        }
    }
}