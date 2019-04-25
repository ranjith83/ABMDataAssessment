using ABMDataBL;
using ABMDataBL.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EDIFACTApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEDIFACT_Click(object sender, EventArgs e)
        {
            EDIFACTMsgParse();
        }

        private void btRefText_Click(object sender, EventArgs e)
        {
            ExtractRefValues();
        }



        private void btPayloadXML_Click(object sender, EventArgs e)
        {
            PostXMLToWCF();
        }

        #region SubMethods

        private void EDIFACTMsgParse()
        {
            var inputFile = ReadConfigData.Instance.GetInputFilePath();
            var edifactFile = ReadConfigData.Instance.GetEDIFACTFileName();

            EDIFACTText_Question1 eDIFACTText = new EDIFACTText_Question1();
            var retValue = eDIFACTText.GetEDITFACTCode(inputFile + edifactFile);
            string outputMsg = string.Empty;

            foreach (var msg in retValue)
            {
                outputMsg += msg.secondSegment + "," + msg.thirdSegment + Environment.NewLine;
            }

            MessageBox.Show("Output Path" + Environment.NewLine +
                "Segment 2 and 3 : " + outputMsg
                );

        }
        
        private void ExtractRefValues()
        {
            var inputFile = ReadConfigData.Instance.GetInputFilePath();
            var fileName = ReadConfigData.Instance.GetXMLFileName();

            XMLParse_Question2 objXMLParse = new XMLParse_Question2();
            XDocument xDocument = objXMLParse.LoadXML(inputFile + fileName);

            var refValues = objXMLParse.GetReferences(xDocument, ABMConstants.REFERENCE, ABMConstants.RefCodes);

            MessageBox.Show($"Output of XML Document Values" + Environment.NewLine +
                            "RefText Values :" + String.Join(",", refValues) );


        }

        private void PostXMLToWCF()
        {
            PayloadServiceReference.PayloadServiceClient payloadService = new PayloadServiceReference.PayloadServiceClient();

            var inputFile = ReadConfigData.Instance.GetInputFilePath();
            var payloadFileName = ReadConfigData.Instance.GetPayloadXMLFileName();
            string xmlString = System.IO.File.ReadAllText(inputFile + payloadFileName);


            var xml = payloadService.PostPayloadXML(xmlString);

            MessageBox.Show($"Output of WCF Call" + Environment.NewLine +
                            "Valid XML :" + xml.ValidXML + Environment.NewLine
                            + "Command Status Code :" + ((xml.CommandStatus == String.Empty) ? "No code" : xml.CommandStatus) + Environment.NewLine
                            + "Site Status :" + ((xml.SiteStatus == String.Empty) ? "No code" : xml.SiteStatus));

        }

        #endregion SubMethods
    }
}
