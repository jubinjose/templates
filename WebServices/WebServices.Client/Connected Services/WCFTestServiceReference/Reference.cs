﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServices.Client.WCFTestServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WebServices")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFTestServiceReference.IWCFTestService")]
    public interface IWCFTestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestService/GetStudent", ReplyAction="http://tempuri.org/IWCFTestService/GetStudentResponse")]
        WebServices.Client.WCFTestServiceReference.Student GetStudent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestService/GetStudent", ReplyAction="http://tempuri.org/IWCFTestService/GetStudentResponse")]
        System.Threading.Tasks.Task<WebServices.Client.WCFTestServiceReference.Student> GetStudentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestService/GetStudentJSON", ReplyAction="http://tempuri.org/IWCFTestService/GetStudentJSONResponse")]
        string GetStudentJSON();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestService/GetStudentJSON", ReplyAction="http://tempuri.org/IWCFTestService/GetStudentJSONResponse")]
        System.Threading.Tasks.Task<string> GetStudentJSONAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestService/GetFullName", ReplyAction="http://tempuri.org/IWCFTestService/GetFullNameResponse")]
        string GetFullName(WebServices.Client.WCFTestServiceReference.Student s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestService/GetFullName", ReplyAction="http://tempuri.org/IWCFTestService/GetFullNameResponse")]
        System.Threading.Tasks.Task<string> GetFullNameAsync(WebServices.Client.WCFTestServiceReference.Student s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFTestServiceChannel : WebServices.Client.WCFTestServiceReference.IWCFTestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFTestServiceClient : System.ServiceModel.ClientBase<WebServices.Client.WCFTestServiceReference.IWCFTestService>, WebServices.Client.WCFTestServiceReference.IWCFTestService {
        
        public WCFTestServiceClient() {
        }
        
        public WCFTestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFTestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebServices.Client.WCFTestServiceReference.Student GetStudent() {
            return base.Channel.GetStudent();
        }
        
        public System.Threading.Tasks.Task<WebServices.Client.WCFTestServiceReference.Student> GetStudentAsync() {
            return base.Channel.GetStudentAsync();
        }
        
        public string GetStudentJSON() {
            return base.Channel.GetStudentJSON();
        }
        
        public System.Threading.Tasks.Task<string> GetStudentJSONAsync() {
            return base.Channel.GetStudentJSONAsync();
        }
        
        public string GetFullName(WebServices.Client.WCFTestServiceReference.Student s) {
            return base.Channel.GetFullName(s);
        }
        
        public System.Threading.Tasks.Task<string> GetFullNameAsync(WebServices.Client.WCFTestServiceReference.Student s) {
            return base.Channel.GetFullNameAsync(s);
        }
    }
}
