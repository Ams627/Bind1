using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Threading;
using System.IO;

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
            var fileList = new[]
            {
                "x1.png",
                "x2.png",
                "x3.png"
            };

            var dir = Directory.GetCurrentDirectory();
            MyList = fileList.Select(x => new X { FullPath = Path.Combine(dir, "Images", x) }).ToList();
        }
    }
}
