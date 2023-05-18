using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Artist
    {
        private String artisticName { get; set; }
        private String name { get; set; }
        private String lastName { get; set; }

        public Artist(String artisticName, String name, String lastName)
        {
            this.artisticName = artisticName;
            this.name = name;
            this.lastName = lastName;
        }
    }
}
