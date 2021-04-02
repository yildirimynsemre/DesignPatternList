﻿using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomOperation customOperation = new CustomOperation(new CustomSerializerAdapter());
            string serializedObject = customOperation.SerializeObject(new object());

            Console.WriteLine(serializedObject);
        }
    }
}
