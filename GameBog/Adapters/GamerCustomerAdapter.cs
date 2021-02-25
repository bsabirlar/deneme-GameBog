using GameBog.Abstract;
using GameBog.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Adapters
{
    public class GamerCustomerAdapter : IGamerCustomerCheckService
    {
        public bool IfNationalId(GamerCustomer gamerCustomer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamerCustomer.NationalityId), gamerCustomer.FirstName.ToUpper(), gamerCustomer.LastName.ToUpper(), gamerCustomer.DateTimeBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
