using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ABMDataBL.Interfaces
{
    interface IXMLParser
    {
        XDocument LoadXML(string file);

        List<String> GetReferences(XDocument xDocument, string node, List<string> refCodes);
    }
}
