using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProductFetchDemo
{
    public class Review
    {
        public string Content { get; set; }

        public Review(string content)
        {
            Content = content;
        }
    }
}
