using System;

namespace WriteToBottom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {         
        
        static void Main()
        {
            BufferClass b = new BufferClass();
            b.AddToBuffer("Velkommen til buffer testing");

            while (true)
            {
                b.WriteFromBuffer();                
                Console.Write("Prompt: ");
                string prompt = Console.ReadLine();
                if (prompt == "exit")
                {
                    Environment.Exit(1);
                }
                b.AddToBuffer(prompt);
            }
        }


        

    }
}