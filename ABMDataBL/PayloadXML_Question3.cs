using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace ABMDataBL
{
    public class PayloadXML_Question3
    {

        /// <summary>
        /// a.	If the XML document is given here is passed then return a status of ‘0’ – which means the document was structured correctly.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public XDocument LoadValidateXMLFile(string file)
        {
            XDocument xDoc = null;
            
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(file);

                xDoc = XDocument.Parse(xmlDoc.InnerXml);
            }
            catch (Exception ex)
            {
                xDoc = null;
            }
            return xDoc;
        }

        /// <summary>
        /// b.	If the Declararation’s Command <> ‘DEFAULT’ then return ‘-1’ – which means invalid command specified.
        /// </summary>
        /// <param name="xDocument"></param>
        /// <param name="node"></param>
        /// <param name="siteValue"></param>
        /// <returns></returns>
        public string InvalidCommand(XDocument xDocument, string node, string siteValue)
        {
            var xElements = xDocument.Descendants(node);

            var declarationNode = xElements
                                .Select(s => s.Attribute("Command").Value != siteValue)//Check other than DEFAULT Command
                                .Where(x => x == true) //Any presence of command
                                .ToList();


            if (declarationNode.Count > 0)
                return "-1";
            else
                return "";
        }



        /// <summary>
        /// c.	If the SiteID <> ‘DUB’ then return ‘-2’ – invalid Site specified.
        /// </summary>
        /// <param name="xDocument"></param>
        /// <param name="node"></param>
        /// <param name="siteValue"></param>
        /// <returns></returns>
        public string InvalidSite(XDocument xDocument, string node, string siteValue)
        {
            var xElements = xDocument.Descendants(node);

            var declarationNode = xElements
                                .Select(s => s.Element("SiteID").Value != siteValue)//Check other than DUB SiteID
                                .Where(s => s == true) //Any presence
                                .ToList();


            if (declarationNode.Count > 0)
                return "-2";
            else
                return "";
        }
    }
}
