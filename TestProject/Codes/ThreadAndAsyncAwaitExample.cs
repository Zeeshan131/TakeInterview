namespace TestProject.Codes;

/*
In C#, Thread is a low-level construct for executing code concurrently by running a method in its own
thread of execution. It's more resource-heavy and requires manual management
(like starting, stopping, and synchronizing threads).

async-await is a higher-level abstraction used for asynchronous programming.
It allows you to write non-blocking code, enabling methods to run asynchronously without
manually managing threads. async marks a method for asynchronous execution,
and await pauses the method execution until a task completes, without blocking the thread.

In short:

Thread = manual, resource-intensive concurrency.
async-await = simpler, non-blocking asynchronous operations.
*/

public class ThreadAndAsyncAwaitExample
{
    // Process data with thread
    public void ProcessData() {
        Thread thread = new Thread(
            () => {
                Thread.Sleep(2000);
                Console.WriteLine("Done!");
            }
        );
        thread.Start();
    }
    
    // Process data with async-await
    public async Task ProcessDataAsync() {
        await Task.Delay(2000);
        Console.WriteLine("Done!");
    }
}
