﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebserviceTestingWebform.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.CalculatorWebServiceSoap")]
    public interface CalculatorWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        // CODEGEN: Generating message contract since element name GetcalResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getcal", ReplyAction="*")]
        WebserviceTestingWebform.ServiceReference1.GetcalResponse Getcal(WebserviceTestingWebform.ServiceReference1.GetcalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getcal", ReplyAction="*")]
        System.Threading.Tasks.Task<WebserviceTestingWebform.ServiceReference1.GetcalResponse> GetcalAsync(WebserviceTestingWebform.ServiceReference1.GetcalRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetcalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Getcal", Namespace="http://tempuri.org/", Order=0)]
        public WebserviceTestingWebform.ServiceReference1.GetcalRequestBody Body;
        
        public GetcalRequest() {
        }
        
        public GetcalRequest(WebserviceTestingWebform.ServiceReference1.GetcalRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetcalRequestBody {
        
        public GetcalRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetcalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetcalResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebserviceTestingWebform.ServiceReference1.GetcalResponseBody Body;
        
        public GetcalResponse() {
        }
        
        public GetcalResponse(WebserviceTestingWebform.ServiceReference1.GetcalResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetcalResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebserviceTestingWebform.ServiceReference1.ArrayOfString GetcalResult;
        
        public GetcalResponseBody() {
        }
        
        public GetcalResponseBody(WebserviceTestingWebform.ServiceReference1.ArrayOfString GetcalResult) {
            this.GetcalResult = GetcalResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWebServiceSoapChannel : WebserviceTestingWebform.ServiceReference1.CalculatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWebServiceSoapClient : System.ServiceModel.ClientBase<WebserviceTestingWebform.ServiceReference1.CalculatorWebServiceSoap>, WebserviceTestingWebform.ServiceReference1.CalculatorWebServiceSoap {
        
        public CalculatorWebServiceSoapClient() {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebserviceTestingWebform.ServiceReference1.GetcalResponse WebserviceTestingWebform.ServiceReference1.CalculatorWebServiceSoap.Getcal(WebserviceTestingWebform.ServiceReference1.GetcalRequest request) {
            return base.Channel.Getcal(request);
        }
        
        public WebserviceTestingWebform.ServiceReference1.ArrayOfString Getcal() {
            WebserviceTestingWebform.ServiceReference1.GetcalRequest inValue = new WebserviceTestingWebform.ServiceReference1.GetcalRequest();
            inValue.Body = new WebserviceTestingWebform.ServiceReference1.GetcalRequestBody();
            WebserviceTestingWebform.ServiceReference1.GetcalResponse retVal = ((WebserviceTestingWebform.ServiceReference1.CalculatorWebServiceSoap)(this)).Getcal(inValue);
            return retVal.Body.GetcalResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebserviceTestingWebform.ServiceReference1.GetcalResponse> WebserviceTestingWebform.ServiceReference1.CalculatorWebServiceSoap.GetcalAsync(WebserviceTestingWebform.ServiceReference1.GetcalRequest request) {
            return base.Channel.GetcalAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebserviceTestingWebform.ServiceReference1.GetcalResponse> GetcalAsync() {
            WebserviceTestingWebform.ServiceReference1.GetcalRequest inValue = new WebserviceTestingWebform.ServiceReference1.GetcalRequest();
            inValue.Body = new WebserviceTestingWebform.ServiceReference1.GetcalRequestBody();
            return ((WebserviceTestingWebform.ServiceReference1.CalculatorWebServiceSoap)(this)).GetcalAsync(inValue);
        }
    }
}