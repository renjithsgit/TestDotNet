using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class PublicAccessVerify
    {
        public int PublicInteger { get; set; }

        private int privateInt { get; set; }

        private string privateString { get; set; }
        public PublicAccessVerify()
        {
            privateString = "AAAA";
            privateInt = 10;
        }

    }
}
