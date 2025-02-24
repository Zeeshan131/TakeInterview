using System.Diagnostics;

namespace TestProject.Codes;

// public class DelegatesExample1
// {
//     // Delegate with return type void and no parameter
//     public delegate void TestDelegate();

//     private TestDelegate testDelegateFunction;

//     public void start()
//     {
//         // testDelegateFunction = MyTestDelegateFunction;
//         // testDelegateFunction();

//         // testDelegateFunction = MySecondTestDelegateFunction;
//         // testDelegateFunction();

//         // Same result with multicast
//         testDelegateFunction = MyTestDelegateFunction;
//         testDelegateFunction += MySecondTestDelegateFunction;
//         testDelegateFunction();
//         testDelegateFunction -= MySecondTestDelegateFunction;
//         testDelegateFunction();
//     }

//     private void MyTestDelegateFunction()
//     {
//         Console.WriteLine("MyTestDelegateFunction");
//     }

//     private void MySecondTestDelegateFunction()
//     {
//         Console.WriteLine("MySecondTestDelegateFunction");
//     }
// }

public class DelegatesExample2
{
    // Delegate with return type bool and one int type parameter
    public delegate bool TestBoolDelegate(int i);

    private TestBoolDelegate testBoolDelegateFunction;

    public void start()
    {
        testBoolDelegateFunction = MyTestBoolDelegateFunction;
        testBoolDelegateFunction += (int i) => {return i < 10;};
        bool res = testBoolDelegateFunction(7);
        Console.WriteLine(res);
    }

    private bool MyTestBoolDelegateFunction(int i)
    {
        return i < 5;
    }
}
