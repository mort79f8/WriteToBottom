using System;
using System.Collections.Generic;
using System.Text;

namespace WriteToBottom
{
    public class BufferClass
    {
        private List<string> buffer;

        public BufferClass()
        {
            buffer = new List<string>();
        }

        public List<string> Buffer
        {
            get { return buffer; }
            set{ buffer = value; }
        }

        public void AddToBuffer(string str)
        {
            CheckBuffer();
            Buffer.Add(str);
        }

        public void WriteFromBuffer()
        {
            Console.Clear();
            for (int i = 0; i < Buffer.Count; i++)
            {
                WriteOnBottomLine(Buffer[i]);
            }
        }

        private void WriteOnBottomLine(string text)
        {
            Console.CursorTop = Console.WindowTop + Console.WindowHeight - 2;
            Console.CursorLeft = Console.WindowLeft;
            Console.WriteLine(text);
            Console.WriteLine();
        }
        private void CheckBuffer()
        {
            int maxLenght = Console.WindowHeight / 3;
            if (buffer.Count != 0)
            {
                if (buffer.Count >= maxLenght)
                {
                    buffer.RemoveAt(0);               
                }
            }
        }
    }
}
