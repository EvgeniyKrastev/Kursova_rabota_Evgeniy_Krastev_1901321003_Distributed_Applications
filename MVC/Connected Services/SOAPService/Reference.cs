﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.SOAPService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CarDTO", Namespace="http://schemas.datacontract.org/2004/07/ApplicationService.DTOs")]
    [System.SerializableAttribute()]
    public partial class CarDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DoorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MinfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime YearField;
        
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
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Doors {
            get {
                return this.DoorsField;
            }
            set {
                if ((this.DoorsField.Equals(value) != true)) {
                    this.DoorsField = value;
                    this.RaisePropertyChanged("Doors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Minfo {
            get {
                return this.MinfoField;
            }
            set {
                if ((object.ReferenceEquals(this.MinfoField, value) != true)) {
                    this.MinfoField = value;
                    this.RaisePropertyChanged("Minfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BuyerDTO", Namespace="http://schemas.datacontract.org/2004/07/ApplicationService.DTOs")]
    [System.SerializableAttribute()]
    public partial class BuyerDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FName {
            get {
                return this.FNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FNameField, value) != true)) {
                    this.FNameField = value;
                    this.RaisePropertyChanged("FName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LName {
            get {
                return this.LNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LNameField, value) != true)) {
                    this.LNameField = value;
                    this.RaisePropertyChanged("LName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((this.PhoneNumberField.Equals(value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex {
            get {
                return this.SexField;
            }
            set {
                if ((object.ReferenceEquals(this.SexField, value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDTO", Namespace="http://schemas.datacontract.org/2004/07/ApplicationService.DTOs")]
    [System.SerializableAttribute()]
    public partial class OrderDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaOfRegistrationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVC.SOAPService.BuyerDTO BuyerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BuyerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVC.SOAPService.CarDTO CarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateOfPurchaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceOfPurchaseField;
        
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
        public string AreaOfRegistration {
            get {
                return this.AreaOfRegistrationField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaOfRegistrationField, value) != true)) {
                    this.AreaOfRegistrationField = value;
                    this.RaisePropertyChanged("AreaOfRegistration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVC.SOAPService.BuyerDTO Buyer {
            get {
                return this.BuyerField;
            }
            set {
                if ((object.ReferenceEquals(this.BuyerField, value) != true)) {
                    this.BuyerField = value;
                    this.RaisePropertyChanged("Buyer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BuyerId {
            get {
                return this.BuyerIdField;
            }
            set {
                if ((this.BuyerIdField.Equals(value) != true)) {
                    this.BuyerIdField = value;
                    this.RaisePropertyChanged("BuyerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVC.SOAPService.CarDTO Car {
            get {
                return this.CarField;
            }
            set {
                if ((object.ReferenceEquals(this.CarField, value) != true)) {
                    this.CarField = value;
                    this.RaisePropertyChanged("Car");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarId {
            get {
                return this.CarIdField;
            }
            set {
                if ((this.CarIdField.Equals(value) != true)) {
                    this.CarIdField = value;
                    this.RaisePropertyChanged("CarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateOfPurchase {
            get {
                return this.DateOfPurchaseField;
            }
            set {
                if ((this.DateOfPurchaseField.Equals(value) != true)) {
                    this.DateOfPurchaseField = value;
                    this.RaisePropertyChanged("DateOfPurchase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PriceOfPurchase {
            get {
                return this.PriceOfPurchaseField;
            }
            set {
                if ((this.PriceOfPurchaseField.Equals(value) != true)) {
                    this.PriceOfPurchaseField = value;
                    this.RaisePropertyChanged("PriceOfPurchase");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MVC.SOAPService.CompositeType GetDataUsingDataContract(MVC.SOAPService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MVC.SOAPService.CompositeType> GetDataUsingDataContractAsync(MVC.SOAPService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCars", ReplyAction="http://tempuri.org/IService1/GetCarsResponse")]
        MVC.SOAPService.CarDTO[] GetCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCars", ReplyAction="http://tempuri.org/IService1/GetCarsResponse")]
        System.Threading.Tasks.Task<MVC.SOAPService.CarDTO[]> GetCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostCar", ReplyAction="http://tempuri.org/IService1/PostCarResponse")]
        string PostCar(MVC.SOAPService.CarDTO CarDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostCar", ReplyAction="http://tempuri.org/IService1/PostCarResponse")]
        System.Threading.Tasks.Task<string> PostCarAsync(MVC.SOAPService.CarDTO CarDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCar", ReplyAction="http://tempuri.org/IService1/DeleteCarResponse")]
        string DeleteCar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCar", ReplyAction="http://tempuri.org/IService1/DeleteCarResponse")]
        System.Threading.Tasks.Task<string> DeleteCarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBuyers", ReplyAction="http://tempuri.org/IService1/GetBuyersResponse")]
        MVC.SOAPService.BuyerDTO[] GetBuyers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBuyers", ReplyAction="http://tempuri.org/IService1/GetBuyersResponse")]
        System.Threading.Tasks.Task<MVC.SOAPService.BuyerDTO[]> GetBuyersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostBuyer", ReplyAction="http://tempuri.org/IService1/PostBuyerResponse")]
        string PostBuyer(MVC.SOAPService.BuyerDTO buyerDTOs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostBuyer", ReplyAction="http://tempuri.org/IService1/PostBuyerResponse")]
        System.Threading.Tasks.Task<string> PostBuyerAsync(MVC.SOAPService.BuyerDTO buyerDTOs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBuyerById", ReplyAction="http://tempuri.org/IService1/GetBuyerByIdResponse")]
        MVC.SOAPService.BuyerDTO GetBuyerById(int id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetCarById", ReplyAction = "http://tempuri.org/IService1/GetCarByIdResponse")]

        MVC.SOAPService.CarDTO GetCarById(int id);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBuyerById", ReplyAction="http://tempuri.org/IService1/GetBuyerByIdResponse")]
        System.Threading.Tasks.Task<MVC.SOAPService.BuyerDTO> GetBuyerByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBuyer", ReplyAction="http://tempuri.org/IService1/DeleteBuyerResponse")]
        string DeleteBuyer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBuyer", ReplyAction="http://tempuri.org/IService1/DeleteBuyerResponse")]
        System.Threading.Tasks.Task<string> DeleteBuyerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        MVC.SOAPService.OrderDTO[] GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        System.Threading.Tasks.Task<MVC.SOAPService.OrderDTO[]> GetOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostOrder", ReplyAction="http://tempuri.org/IService1/PostOrderResponse")]
        string PostOrder(MVC.SOAPService.OrderDTO orderDTOs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostOrder", ReplyAction="http://tempuri.org/IService1/PostOrderResponse")]
        System.Threading.Tasks.Task<string> PostOrderAsync(MVC.SOAPService.OrderDTO orderDTOs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderById", ReplyAction="http://tempuri.org/IService1/GetOrderByIdResponse")]
        MVC.SOAPService.OrderDTO GetOrderById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderById", ReplyAction="http://tempuri.org/IService1/GetOrderByIdResponse")]
        System.Threading.Tasks.Task<MVC.SOAPService.OrderDTO> GetOrderByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        string DeleteOrder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        System.Threading.Tasks.Task<string> DeleteOrderAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVC.SOAPService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVC.SOAPService.IService1>, MVC.SOAPService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public MVC.SOAPService.CompositeType GetDataUsingDataContract(MVC.SOAPService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MVC.SOAPService.CompositeType> GetDataUsingDataContractAsync(MVC.SOAPService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public MVC.SOAPService.CarDTO[] GetCars() {
            return base.Channel.GetCars();
        }
        
        public System.Threading.Tasks.Task<MVC.SOAPService.CarDTO[]> GetCarsAsync() {
            return base.Channel.GetCarsAsync();
        }
        
        public string PostCar(MVC.SOAPService.CarDTO CarDto) {
            return base.Channel.PostCar(CarDto);
        }
        
        public System.Threading.Tasks.Task<string> PostCarAsync(MVC.SOAPService.CarDTO CarDto) {
            return base.Channel.PostCarAsync(CarDto);
        }
        
        public string DeleteCar(int id) {
            return base.Channel.DeleteCar(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteCarAsync(int id) {
            return base.Channel.DeleteCarAsync(id);
        }
        
        public MVC.SOAPService.BuyerDTO[] GetBuyers() {
            return base.Channel.GetBuyers();
        }
        
        public System.Threading.Tasks.Task<MVC.SOAPService.BuyerDTO[]> GetBuyersAsync() {
            return base.Channel.GetBuyersAsync();
        }
        
        public string PostBuyer(MVC.SOAPService.BuyerDTO buyerDTOs) {
            return base.Channel.PostBuyer(buyerDTOs);
        }
        
        public System.Threading.Tasks.Task<string> PostBuyerAsync(MVC.SOAPService.BuyerDTO buyerDTOs) {
            return base.Channel.PostBuyerAsync(buyerDTOs);
        }
        
        public MVC.SOAPService.BuyerDTO GetBuyerById(int id) {
            return base.Channel.GetBuyerById(id);
        }

        public MVC.SOAPService.CarDTO GetCarById(int id)
        {
            return base.Channel.GetCarById(id);
        }

        public System.Threading.Tasks.Task<MVC.SOAPService.BuyerDTO> GetBuyerByIdAsync(int id) {
            return base.Channel.GetBuyerByIdAsync(id);
        }
        
        public string DeleteBuyer(int id) {
            return base.Channel.DeleteBuyer(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBuyerAsync(int id) {
            return base.Channel.DeleteBuyerAsync(id);
        }
        
        public MVC.SOAPService.OrderDTO[] GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<MVC.SOAPService.OrderDTO[]> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
        
        public string PostOrder(MVC.SOAPService.OrderDTO orderDTOs) {
            return base.Channel.PostOrder(orderDTOs);
        }
        
        public System.Threading.Tasks.Task<string> PostOrderAsync(MVC.SOAPService.OrderDTO orderDTOs) {
            return base.Channel.PostOrderAsync(orderDTOs);
        }
        
        public MVC.SOAPService.OrderDTO GetOrderById(int id) {
            return base.Channel.GetOrderById(id);
        }
        
        public System.Threading.Tasks.Task<MVC.SOAPService.OrderDTO> GetOrderByIdAsync(int id) {
            return base.Channel.GetOrderByIdAsync(id);
        }
        
        public string DeleteOrder(int id) {
            return base.Channel.DeleteOrder(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteOrderAsync(int id) {
            return base.Channel.DeleteOrderAsync(id);
        }
    }
}