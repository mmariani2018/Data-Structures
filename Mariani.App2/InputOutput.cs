using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App2Design
{
    class InputOutput
    {
        public InputOutput() { }

        public void showMessage(String message)
        {
            Console.WriteLine(message);
        }

        public String getSomething(String message)
        {
            Console.Write(message + "  ");
            return Console.ReadLine();
        }

    }
}
