using System;
using System.Configuration;

namespace ABMDataBL.Misc
{
    public class ReadConfigData
    {

        private static volatile ReadConfigData instance;
        private static object syncRoot = new Object();

        private ReadConfigData() { }

        public static ReadConfigData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ReadConfigData();
                    }
                }

                return instance;
            }
        }

        public string  GetInputFilePath()
        {
            return ConfigurationManager.AppSettings["FilePath"];
        }

        public string GetEDIFACTFileName()
        {
            return ConfigurationManager.AppSettings["EDIFACTFileName"];
        }

        public string GetXMLFileName()
        {
            return ConfigurationManager.AppSettings["XMLFileName"];
        }

        public string GetPayloadXMLFileName()
        {
            return ConfigurationManager.AppSettings["PayloadXMLFileName"];
        }
    }
}
