﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SprzedaneWebMVC.SprzedaneReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Przedmioty", Namespace="http://schemas.datacontract.org/2004/07/Sprzedane")]
    [System.SerializableAttribute()]
    public partial class Przedmioty : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataZakonczeniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WygrywajacyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WystawiajacyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Cena {
            get {
                return this.CenaField;
            }
            set {
                if ((this.CenaField.Equals(value) != true)) {
                    this.CenaField = value;
                    this.RaisePropertyChanged("Cena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataZakonczenia {
            get {
                return this.DataZakonczeniaField;
            }
            set {
                if ((this.DataZakonczeniaField.Equals(value) != true)) {
                    this.DataZakonczeniaField = value;
                    this.RaisePropertyChanged("DataZakonczenia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Kategoria {
            get {
                return this.KategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.KategoriaField, value) != true)) {
                    this.KategoriaField = value;
                    this.RaisePropertyChanged("Kategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazwa {
            get {
                return this.NazwaField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwaField, value) != true)) {
                    this.NazwaField = value;
                    this.RaisePropertyChanged("Nazwa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Opis {
            get {
                return this.OpisField;
            }
            set {
                if ((object.ReferenceEquals(this.OpisField, value) != true)) {
                    this.OpisField = value;
                    this.RaisePropertyChanged("Opis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Wygrywajacy {
            get {
                return this.WygrywajacyField;
            }
            set {
                if ((object.ReferenceEquals(this.WygrywajacyField, value) != true)) {
                    this.WygrywajacyField = value;
                    this.RaisePropertyChanged("Wygrywajacy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Wystawiajacy {
            get {
                return this.WystawiajacyField;
            }
            set {
                if ((object.ReferenceEquals(this.WystawiajacyField, value) != true)) {
                    this.WystawiajacyField = value;
                    this.RaisePropertyChanged("Wystawiajacy");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Portfele", Namespace="http://schemas.datacontract.org/2004/07/Sprzedane")]
    [System.SerializableAttribute()]
    public partial class Portfele : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AccountIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float SaldoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AccountID {
            get {
                return this.AccountIDField;
            }
            set {
                if ((this.AccountIDField.Equals(value) != true)) {
                    this.AccountIDField = value;
                    this.RaisePropertyChanged("AccountID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Saldo {
            get {
                return this.SaldoField;
            }
            set {
                if ((this.SaldoField.Equals(value) != true)) {
                    this.SaldoField = value;
                    this.RaisePropertyChanged("Saldo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SprzedaneReference.ISprzedaneService")]
    public interface ISprzedaneService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetPrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/GetPrzedmiotResponse")]
        SprzedaneWebMVC.SprzedaneReference.Przedmioty[] GetPrzedmiot(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetPrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/GetPrzedmiotResponse")]
        System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Przedmioty[]> GetPrzedmiotAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetAllPrzedmioty", ReplyAction="http://tempuri.org/ISprzedaneService/GetAllPrzedmiotyResponse")]
        SprzedaneWebMVC.SprzedaneReference.Przedmioty[] GetAllPrzedmioty();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetAllPrzedmioty", ReplyAction="http://tempuri.org/ISprzedaneService/GetAllPrzedmiotyResponse")]
        System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Przedmioty[]> GetAllPrzedmiotyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetPrzedmiotyBy", ReplyAction="http://tempuri.org/ISprzedaneService/GetPrzedmiotyByResponse")]
        SprzedaneWebMVC.SprzedaneReference.Przedmioty[] GetPrzedmiotyBy(string term, string by);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetPrzedmiotyBy", ReplyAction="http://tempuri.org/ISprzedaneService/GetPrzedmiotyByResponse")]
        System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Przedmioty[]> GetPrzedmiotyByAsync(string term, string by);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/AddPrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/AddPrzedmiotResponse")]
        void AddPrzedmiot(SprzedaneWebMVC.SprzedaneReference.Przedmioty p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/AddPrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/AddPrzedmiotResponse")]
        System.Threading.Tasks.Task AddPrzedmiotAsync(SprzedaneWebMVC.SprzedaneReference.Przedmioty p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/DeletePrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/DeletePrzedmiotResponse")]
        void DeletePrzedmiot(SprzedaneWebMVC.SprzedaneReference.Przedmioty p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/DeletePrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/DeletePrzedmiotResponse")]
        System.Threading.Tasks.Task DeletePrzedmiotAsync(SprzedaneWebMVC.SprzedaneReference.Przedmioty p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/EditPrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/EditPrzedmiotResponse")]
        void EditPrzedmiot(SprzedaneWebMVC.SprzedaneReference.Przedmioty p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/EditPrzedmiot", ReplyAction="http://tempuri.org/ISprzedaneService/EditPrzedmiotResponse")]
        System.Threading.Tasks.Task EditPrzedmiotAsync(SprzedaneWebMVC.SprzedaneReference.Przedmioty p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetPortfel", ReplyAction="http://tempuri.org/ISprzedaneService/GetPortfelResponse")]
        SprzedaneWebMVC.SprzedaneReference.Portfele GetPortfel(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetPortfel", ReplyAction="http://tempuri.org/ISprzedaneService/GetPortfelResponse")]
        System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Portfele> GetPortfelAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetAllPortfele", ReplyAction="http://tempuri.org/ISprzedaneService/GetAllPortfeleResponse")]
        SprzedaneWebMVC.SprzedaneReference.Portfele[] GetAllPortfele();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/GetAllPortfele", ReplyAction="http://tempuri.org/ISprzedaneService/GetAllPortfeleResponse")]
        System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Portfele[]> GetAllPortfeleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/AddPortfel", ReplyAction="http://tempuri.org/ISprzedaneService/AddPortfelResponse")]
        void AddPortfel(SprzedaneWebMVC.SprzedaneReference.Portfele p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/AddPortfel", ReplyAction="http://tempuri.org/ISprzedaneService/AddPortfelResponse")]
        System.Threading.Tasks.Task AddPortfelAsync(SprzedaneWebMVC.SprzedaneReference.Portfele p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/DeletePortfel", ReplyAction="http://tempuri.org/ISprzedaneService/DeletePortfelResponse")]
        void DeletePortfel(SprzedaneWebMVC.SprzedaneReference.Portfele p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/DeletePortfel", ReplyAction="http://tempuri.org/ISprzedaneService/DeletePortfelResponse")]
        System.Threading.Tasks.Task DeletePortfelAsync(SprzedaneWebMVC.SprzedaneReference.Portfele p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/SetSaldo", ReplyAction="http://tempuri.org/ISprzedaneService/SetSaldoResponse")]
        void SetSaldo(SprzedaneWebMVC.SprzedaneReference.Portfele p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprzedaneService/SetSaldo", ReplyAction="http://tempuri.org/ISprzedaneService/SetSaldoResponse")]
        System.Threading.Tasks.Task SetSaldoAsync(SprzedaneWebMVC.SprzedaneReference.Portfele p);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISprzedaneServiceChannel : SprzedaneWebMVC.SprzedaneReference.ISprzedaneService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SprzedaneServiceClient : System.ServiceModel.ClientBase<SprzedaneWebMVC.SprzedaneReference.ISprzedaneService>, SprzedaneWebMVC.SprzedaneReference.ISprzedaneService {
        
        public SprzedaneServiceClient() {
        }
        
        public SprzedaneServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SprzedaneServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprzedaneServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprzedaneServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SprzedaneWebMVC.SprzedaneReference.Przedmioty[] GetPrzedmiot(string id) {
            return base.Channel.GetPrzedmiot(id);
        }
        
        public System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Przedmioty[]> GetPrzedmiotAsync(string id) {
            return base.Channel.GetPrzedmiotAsync(id);
        }
        
        public SprzedaneWebMVC.SprzedaneReference.Przedmioty[] GetAllPrzedmioty() {
            return base.Channel.GetAllPrzedmioty();
        }
        
        public System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Przedmioty[]> GetAllPrzedmiotyAsync() {
            return base.Channel.GetAllPrzedmiotyAsync();
        }
        
        public SprzedaneWebMVC.SprzedaneReference.Przedmioty[] GetPrzedmiotyBy(string term, string by) {
            return base.Channel.GetPrzedmiotyBy(term, by);
        }
        
        public System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Przedmioty[]> GetPrzedmiotyByAsync(string term, string by) {
            return base.Channel.GetPrzedmiotyByAsync(term, by);
        }
        
        public void AddPrzedmiot(SprzedaneWebMVC.SprzedaneReference.Przedmioty p) {
            base.Channel.AddPrzedmiot(p);
        }
        
        public System.Threading.Tasks.Task AddPrzedmiotAsync(SprzedaneWebMVC.SprzedaneReference.Przedmioty p) {
            return base.Channel.AddPrzedmiotAsync(p);
        }
        
        public void DeletePrzedmiot(SprzedaneWebMVC.SprzedaneReference.Przedmioty p) {
            base.Channel.DeletePrzedmiot(p);
        }
        
        public System.Threading.Tasks.Task DeletePrzedmiotAsync(SprzedaneWebMVC.SprzedaneReference.Przedmioty p) {
            return base.Channel.DeletePrzedmiotAsync(p);
        }
        
        public void EditPrzedmiot(SprzedaneWebMVC.SprzedaneReference.Przedmioty p) {
            base.Channel.EditPrzedmiot(p);
        }
        
        public System.Threading.Tasks.Task EditPrzedmiotAsync(SprzedaneWebMVC.SprzedaneReference.Przedmioty p) {
            return base.Channel.EditPrzedmiotAsync(p);
        }
        
        public SprzedaneWebMVC.SprzedaneReference.Portfele GetPortfel(string id) {
            return base.Channel.GetPortfel(id);
        }
        
        public System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Portfele> GetPortfelAsync(string id) {
            return base.Channel.GetPortfelAsync(id);
        }
        
        public SprzedaneWebMVC.SprzedaneReference.Portfele[] GetAllPortfele() {
            return base.Channel.GetAllPortfele();
        }
        
        public System.Threading.Tasks.Task<SprzedaneWebMVC.SprzedaneReference.Portfele[]> GetAllPortfeleAsync() {
            return base.Channel.GetAllPortfeleAsync();
        }
        
        public void AddPortfel(SprzedaneWebMVC.SprzedaneReference.Portfele p) {
            base.Channel.AddPortfel(p);
        }
        
        public System.Threading.Tasks.Task AddPortfelAsync(SprzedaneWebMVC.SprzedaneReference.Portfele p) {
            return base.Channel.AddPortfelAsync(p);
        }
        
        public void DeletePortfel(SprzedaneWebMVC.SprzedaneReference.Portfele p) {
            base.Channel.DeletePortfel(p);
        }
        
        public System.Threading.Tasks.Task DeletePortfelAsync(SprzedaneWebMVC.SprzedaneReference.Portfele p) {
            return base.Channel.DeletePortfelAsync(p);
        }
        
        public void SetSaldo(SprzedaneWebMVC.SprzedaneReference.Portfele p) {
            base.Channel.SetSaldo(p);
        }
        
        public System.Threading.Tasks.Task SetSaldoAsync(SprzedaneWebMVC.SprzedaneReference.Portfele p) {
            return base.Channel.SetSaldoAsync(p);
        }
    }
}
