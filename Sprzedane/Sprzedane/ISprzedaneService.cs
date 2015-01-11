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
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "przedmioty/{term}")]
        IList<Przedmioty> GetPrzedmioty(string term);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "przedmioty")]
        IList<Przedmioty> GetAllPrzedmioty();

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "POST", UriTemplate = "przedmioty/add")]
        void AddPrzedmiot(Przedmioty p);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "DELETE", UriTemplate = "przedmioty/delete")]
        void DeletePrzedmiot(Przedmioty p);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "PUT", UriTemplate = "przedmioty/edit")]
        void EditPrzedmiot(Przedmioty p);
    }
}
