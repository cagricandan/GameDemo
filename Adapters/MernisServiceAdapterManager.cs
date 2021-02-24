using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using GameDemo.Entities;

namespace GameDemo.Adapters
{
    class MernisServiceAdapterManager : IRealIfPerson
    {
        public bool IfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.BirthYear.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
