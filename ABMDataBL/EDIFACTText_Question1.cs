using ABMDataBL.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ABMDataBL
{
    public class EDIFACTText_Question1
    {
        public List<EDIFACT_Message> GetEDITFACTCode(string filePath)
        {
            var textFile = ReadFile(filePath);

            return ParseMsg(textFile);
        }
        private string[] ReadFile(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            return lines;
        }

        private List<EDIFACT_Message> ParseMsg(string[] lines)
        {
            List<EDIFACT_Message> eDIFACT_MessagesList = new List<EDIFACT_Message>();

            foreach (var line in lines)
            {
                string[] arrSegment = line.Split('+');

                var firstSegment = Regex.Replace(arrSegment.FirstOrDefault(), @"[^A-Z]+", String.Empty);

                if (firstSegment == "LOC")
                {
                    string[] fillVal = new string[2];
                    EDIFACT_Message eDIFACT_Messages = new EDIFACT_Message();

                    int count = 0;
                    foreach (var segment in arrSegment.Skip(1))
                    {
                        if (count == 0)
                            eDIFACT_Messages.secondSegment = segment;
                        else if (count == 1)
                            eDIFACT_Messages.thirdSegment = segment;

                        count++;
                    }
                    eDIFACT_MessagesList.Add(eDIFACT_Messages);
                }
                
            }
            return eDIFACT_MessagesList;
        }
    }
}
