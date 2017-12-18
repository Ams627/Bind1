using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Threading;

namespace Bind1
{
    public class X
    {
        public string FullPath { get; set; }
    }
    public class ViewModel
    {
        public List<X> MyList { get; set; }
        public X MyItem { get; set; }
        public ViewModel()
        {
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            MyList = new List<X>
            {
                new X { FullPath = "q:\\temp\\x1.png"},
                new X { FullPath = "q:\\temp\\x2.png"}
            };
        }
    }
}
