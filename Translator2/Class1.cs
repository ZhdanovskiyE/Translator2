using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator2
{
    public partial class Class1
    {
        string[] ru = new string[File.ReadAllLines("ru.txt").Length];
        string[] en = new string[File.ReadAllLines("en.txt").Length];
    }
}
