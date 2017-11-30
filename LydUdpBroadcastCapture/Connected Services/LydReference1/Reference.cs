﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LydUdpBroadcastCapture.LydReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lyd", Namespace="http://schemas.datacontract.org/2004/07/LydSemesterModtagBroadcast")]
    [System.SerializableAttribute()]
    public partial class Lyd : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LydeField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
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
        public string Lyde {
            get {
                return this.LydeField;
            }
            set {
                if ((object.ReferenceEquals(this.LydeField, value) != true)) {
                    this.LydeField = value;
                    this.RaisePropertyChanged("Lyde");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LydReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostLydToList", ReplyAction="http://tempuri.org/IService1/PostLydToListResponse")]
        int PostLydToList(string lyd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostLydToList", ReplyAction="http://tempuri.org/IService1/PostLydToListResponse")]
        System.Threading.Tasks.Task<int> PostLydToListAsync(string lyd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllLyd", ReplyAction="http://tempuri.org/IService1/GetAllLydResponse")]
        LydUdpBroadcastCapture.LydReference1.Lyd[] GetAllLyd();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllLyd", ReplyAction="http://tempuri.org/IService1/GetAllLydResponse")]
        System.Threading.Tasks.Task<LydUdpBroadcastCapture.LydReference1.Lyd[]> GetAllLydAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TjekStatus", ReplyAction="http://tempuri.org/IService1/TjekStatusResponse")]
        bool TjekStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TjekStatus", ReplyAction="http://tempuri.org/IService1/TjekStatusResponse")]
        System.Threading.Tasks.Task<bool> TjekStatusAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : LydUdpBroadcastCapture.LydReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<LydUdpBroadcastCapture.LydReference1.IService1>, LydUdpBroadcastCapture.LydReference1.IService1 {
        
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
        
        public int PostLydToList(string lyd) {
            return base.Channel.PostLydToList(lyd);
        }
        
        public System.Threading.Tasks.Task<int> PostLydToListAsync(string lyd) {
            return base.Channel.PostLydToListAsync(lyd);
        }
        
        public LydUdpBroadcastCapture.LydReference1.Lyd[] GetAllLyd() {
            return base.Channel.GetAllLyd();
        }
        
        public System.Threading.Tasks.Task<LydUdpBroadcastCapture.LydReference1.Lyd[]> GetAllLydAsync() {
            return base.Channel.GetAllLydAsync();
        }
        
        public bool TjekStatus() {
            return base.Channel.TjekStatus();
        }
        
        public System.Threading.Tasks.Task<bool> TjekStatusAsync() {
            return base.Channel.TjekStatusAsync();
        }
    }
}
