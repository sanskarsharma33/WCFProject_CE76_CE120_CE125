﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreelanceClient.ProjectRequestAllotedRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProjectRequestAllotedRef.IProjectRequestAlloted")]
    public interface IProjectRequestAlloted {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectRequestAlloted/AllotProjectRequest", ReplyAction="http://tempuri.org/IProjectRequestAlloted/AllotProjectRequestResponse")]
        string AllotProjectRequest(FreelanceService.ModelClasses.ProjectAlloatted projectAlloated);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectRequestAlloted/AllotProjectRequest", ReplyAction="http://tempuri.org/IProjectRequestAlloted/AllotProjectRequestResponse")]
        System.Threading.Tasks.Task<string> AllotProjectRequestAsync(FreelanceService.ModelClasses.ProjectAlloatted projectAlloated);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectRequestAlloted/RemoveAllottedRequest", ReplyAction="http://tempuri.org/IProjectRequestAlloted/RemoveAllottedRequestResponse")]
        string RemoveAllottedRequest(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectRequestAlloted/RemoveAllottedRequest", ReplyAction="http://tempuri.org/IProjectRequestAlloted/RemoveAllottedRequestResponse")]
        System.Threading.Tasks.Task<string> RemoveAllottedRequestAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProjectRequestAllotedChannel : FreelanceClient.ProjectRequestAllotedRef.IProjectRequestAlloted, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProjectRequestAllotedClient : System.ServiceModel.ClientBase<FreelanceClient.ProjectRequestAllotedRef.IProjectRequestAlloted>, FreelanceClient.ProjectRequestAllotedRef.IProjectRequestAlloted {
        
        public ProjectRequestAllotedClient() {
        }
        
        public ProjectRequestAllotedClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProjectRequestAllotedClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectRequestAllotedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectRequestAllotedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AllotProjectRequest(FreelanceService.ModelClasses.ProjectAlloatted projectAlloated) {
            return base.Channel.AllotProjectRequest(projectAlloated);
        }
        
        public System.Threading.Tasks.Task<string> AllotProjectRequestAsync(FreelanceService.ModelClasses.ProjectAlloatted projectAlloated) {
            return base.Channel.AllotProjectRequestAsync(projectAlloated);
        }
        
        public string RemoveAllottedRequest(int id) {
            return base.Channel.RemoveAllottedRequest(id);
        }
        
        public System.Threading.Tasks.Task<string> RemoveAllottedRequestAsync(int id) {
            return base.Channel.RemoveAllottedRequestAsync(id);
        }
    }
}
