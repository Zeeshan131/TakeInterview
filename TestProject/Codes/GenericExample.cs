namespace TestProject.Codes;

/*
In C#, generics allow you to define classes, methods, and data structures with a placeholder for data types,
making your code more flexible and reusable while maintaining type safety.
*/

public class GenericExample
{
    public static T Identity<T>(T value) {
        return value;
    }
}
