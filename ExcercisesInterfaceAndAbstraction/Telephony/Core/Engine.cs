using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Classes;

namespace Telephony.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] phoneNum = Console.ReadLine().Split();
            string[] urlData = Console.ReadLine().Split();
            var temp = new Smartphone();

            foreach (var phoneNumbers in phoneNum)
            {
                Console.WriteLine(temp.Call(phoneNumbers));
            }
            foreach (var url in urlData)
            {
                Console.WriteLine(temp.Browsing(url));
            }
        }
    }
}
