using System;

namespace Visit.Shared
{
    public static class ErrorException
    {
        public static void AddLog(this Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}