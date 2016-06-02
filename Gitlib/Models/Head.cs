using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLib
{
    public class Head
    {
        public string label { get; set; }
        public string @ref { get; set; }
        public string sha { get; set; }
        public User user { get; set; }
        public Repo repo { get; set; }
    }
}
