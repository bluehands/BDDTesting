namespace BddTesting
{
    using System;

    public static class TestLogger
    {
        public static void Log(object message)
        {
            Console.WriteLine($@"{DateTime.Now:HH:mm:ss fff}: {message}");
        }
    }
}