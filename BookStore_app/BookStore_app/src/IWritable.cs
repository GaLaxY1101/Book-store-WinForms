using BookStore_app;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_app
{
    internal interface IWritable
    {
        public void WriteToFile(string path);
    }
}
