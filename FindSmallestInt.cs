namespace Greeting
{
    // using System require in codewars for System.Array
    using System;
    class FindSmallestInt
    {
        public static int ByArraySort(int[] args)
        {
            Array.Sort(args);
            return args[0];
        }

        public static int ByLoop(int[] args)
        {
            int smallest = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                if (smallest > args[i])
                {
                    smallest = args[i];
                }
            }

            return smallest;
        }
    }
}