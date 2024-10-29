using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BiblioteczkaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKontekstBiblioteczki" in both code and config file together.
    [ServiceContract]
    public interface IKontekstBiblioteczki
    {
        // TODO: Add your service operations here
        [OperationContract]
        void Dodaj(string tytul, string autor, int iloscStron);
        [OperationContract]
        void Edytuj(int id, string tytul, string autor, int iloscStron);
        [OperationContract]
        void Usun(int id);
        [OperationContract]
        Ksiazka Pobierz(int id);
        [OperationContract]
        List<Ksiazka> PobierzWszystkie();
        [OperationContract]
        Ksiazka GetKsiazkaById(int id);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
