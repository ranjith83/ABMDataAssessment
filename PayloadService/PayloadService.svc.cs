using ABMDataBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PayloadService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PayloadService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PayloadService.svc or PayloadService.svc.cs at the Solution Explorer and start debugging.
    public class PayloadService : IPayloadService
    {
        public PayloadContract PostPayloadXML(string xmlData)
        {

            PayloadContract payloadModel = new PayloadContract();

            try
            {
                PayloadXML_Question3 payloadXML_Question3 = new PayloadXML_Question3();

                var xDocument = payloadXML_Question3.LoadValidateXMLFile(xmlData);
                payloadModel.ValidXML = (xDocument != null) ? true : false;

                //Command Status Code
                payloadModel.CommandStatus = payloadXML_Question3.InvalidCommand(xDocument, ABMConstants.DECLARATION, "DEFAULT");

                //Site ID status code
                payloadModel.SiteStatus = payloadXML_Question3.InvalidSite(xDocument, ABMConstants.DECLARATIONHEADER, "DUB");

                return payloadModel;

            }
            catch (Exception ex)
            {
            }

            return payloadModel;
        }
    }
}
