﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWCAT.WSDB {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSDB.WSControlHombresSoap")]
    public interface WSControlHombresSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getdata", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Getdata();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Getdata", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetdataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSControlHombresSoapChannel : SWCAT.WSDB.WSControlHombresSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSControlHombresSoapClient : System.ServiceModel.ClientBase<SWCAT.WSDB.WSControlHombresSoap>, SWCAT.WSDB.WSControlHombresSoap {
        
        public WSControlHombresSoapClient() {
        }
        
        public WSControlHombresSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSControlHombresSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSControlHombresSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSControlHombresSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Getdata() {
            return base.Channel.Getdata();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetdataAsync() {
            return base.Channel.GetdataAsync();
        }
    }
}
