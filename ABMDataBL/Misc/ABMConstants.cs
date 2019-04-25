using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMDataBL
{
    public class ABMConstants
    {
        public const string InputFilePath = @"C:\Users\Ranjith\source\repos\ABMDataAssessment\EDIFACTApp\InputFile\";
        public static List<string> RefCodes = new List<string>() { "MWB", "TRV", "CAR" };

        public const string XMLFileName = "EDIFACT_XMLDoc.xml";
        public const string REFERENCE = "Reference";
        public const string REFCODE = "RefCode";
        public const string REFTEXT = "RefText";
        public const string DECLARATION = "Declaration";
        public const string DECLARATIONHEADER = "DeclarationHeader";

    }
}
