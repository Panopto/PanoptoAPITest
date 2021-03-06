﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PanoptoAPITest.Auth {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Auth.IAuth")]
    public interface IAuth {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/LogOnWithPassword", ReplyAction="http://tempuri.org/IAuth/LogOnWithPasswordResponse")]
        bool LogOnWithPassword(string userKey, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/LogOnWithExternalProvider", ReplyAction="http://tempuri.org/IAuth/LogOnWithExternalProviderResponse")]
        bool LogOnWithExternalProvider(string userKey, string authCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuth/GetServerVersion", ReplyAction="http://tempuri.org/IAuth/GetServerVersionResponse")]
        string GetServerVersion();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthChannel : PanoptoAPITest.Auth.IAuth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthClient : System.ServiceModel.ClientBase<PanoptoAPITest.Auth.IAuth>, PanoptoAPITest.Auth.IAuth {
        
        public AuthClient() {
        }
        
        public AuthClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool LogOnWithPassword(string userKey, string password) {
            return base.Channel.LogOnWithPassword(userKey, password);
        }
        
        public bool LogOnWithExternalProvider(string userKey, string authCode) {
            return base.Channel.LogOnWithExternalProvider(userKey, authCode);
        }
        
        public string GetServerVersion() {
            return base.Channel.GetServerVersion();
        }
    }
}
