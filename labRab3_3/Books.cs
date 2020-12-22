using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRab3_3
{
    public static class Books
    {
        static public string[,] books = new string[3, 100];

        static public int rows = books.GetUpperBound(1) + 1;
        static public int columns = books.Length / rows;
    }
}
