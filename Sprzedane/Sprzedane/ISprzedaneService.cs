using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Sprzedane
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISprzedaneService" in both code and config file together.
    [ServiceContract]
    public interface ISprzedaneService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "przedmioty/{id}")]
        IList<Przedmioty> GetPrzedmiot(string id);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "przedmioty/1")]
        IList<Przedmioty> GetAllPrzedmioty();

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "przedmioty/{term}/{by}/1")]
        IList<Przedmioty> GetPrzedmiotyBy(string term, string by);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "przedmioty/2")]
        IList<Przedmioty> GetAllPrzedmioty2();

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "przedmioty/{term}/{by}/2")]
        IList<Przedmioty> GetPrzedmiotyBy2(string term, string by);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "POST", UriTemplate = "przedmioty/add")]
        void AddPrzedmiot(Przedmioty p);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "DELETE", UriTemplate = "przedmioty/delete")]
        void DeletePrzedmiot(Przedmioty p);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "PUT", UriTemplate = "przedmioty/edit")]
        void EditPrzedmiot(Przedmioty p);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
    Method = "PUT", UriTemplate = "przedmioty/bid")]
        void BidPrzedmiot(Przedmioty p);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "portfele/{id}")]
        Portfele GetPortfel(string id);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "portfele")]
        IList<Portfele> GetAllPortfele();

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "POST", UriTemplate = "portfele/add")]
        void AddPortfel(Portfele p);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "POST", UriTemplate = "portfele/delete")]
        void DeletePortfel(Portfele p);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "POST", UriTemplate = "portfele/set")]
        void SetSaldo(Portfele p);
    }
}
