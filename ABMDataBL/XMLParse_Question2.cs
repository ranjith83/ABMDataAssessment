using ABMDataBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ABMDataBL
{
    public class XMLParse_Question2 : IXMLParser
    {
        public XDocument LoadXML(string file)
        {
            var edifactXML = XDocument.Load(file);

            return edifactXML;
        }

        public List<String> GetReferences(XDocument xDocument, string node, List<string> refCodes)
        {
            var xElements = xDocument.Descendants(node);

            var refText = xElements.Where(refCode => refCodes.Contains(refCode.Attribute(ABMConstants.REFCODE).Value))
                                .Select(s => s.Element(ABMConstants.REFTEXT).Value)
                                .ToList();

            return refText;
        }


    }
}
