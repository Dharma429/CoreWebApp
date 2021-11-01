using CoreWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Services
{
    public class Log: ILog
    {
        public void Info(String str)
        {
            Console.WriteLine(str);
        }
    }
}
