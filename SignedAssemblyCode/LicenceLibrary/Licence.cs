using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LicenceLibrary
{
    public class Licence
    {
        public bool Validate(string key)
        {
            return key == "valid key";
        }            
    }
}
