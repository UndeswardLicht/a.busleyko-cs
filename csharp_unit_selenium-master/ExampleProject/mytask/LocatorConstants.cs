using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask
{
    public class LocatorConstants
    {
        public const string PreciseTextLocator = "//*[text()='{0}']";
        public const string PartialTextLocator = "//*[contains(text(),'{0}')]";
        public const string PreciseClassLocator = "//*[@class='{0}')]";
    }
}
