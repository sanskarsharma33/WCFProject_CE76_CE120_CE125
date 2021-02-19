﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreelanceClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateUser", ReplyAction="http://tempuri.org/IUserService/CreateUserResponse")]
        string CreateUser(FreelanceService.ModelClasses.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateUser", ReplyAction="http://tempuri.org/IUserService/CreateUserResponse")]
        System.Threading.Tasks.Task<string> CreateUserAsync(FreelanceService.ModelClasses.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ViewUser", ReplyAction="http://tempuri.org/IUserService/ViewUserResponse")]
        System.Data.DataSet ViewUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/ViewUser", ReplyAction="http://tempuri.org/IUserService/ViewUserResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ViewUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AllUsers", ReplyAction="http://tempuri.org/IUserService/AllUsersResponse")]
        System.Data.DataSet AllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AllUsers", ReplyAction="http://tempuri.org/IUserService/AllUsersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> AllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Login", ReplyAction="http://tempuri.org/IUserService/LoginResponse")]
        FreelanceService.ModelClasses.User Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Login", ReplyAction="http://tempuri.org/IUserService/LoginResponse")]
        System.Threading.Tasks.Task<FreelanceService.ModelClasses.User> LoginAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : FreelanceClient.ServiceReference1.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<FreelanceClient.ServiceReference1.IUserService>, FreelanceClient.ServiceReference1.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreateUser(FreelanceService.ModelClasses.User user) {
            return base.Channel.CreateUser(user);
        }
        
        public System.Threading.Tasks.Task<string> CreateUserAsync(FreelanceService.ModelClasses.User user) {
            return base.Channel.CreateUserAsync(user);
        }
        
        public System.Data.DataSet ViewUser(int id) {
            return base.Channel.ViewUser(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ViewUserAsync(int id) {
            return base.Channel.ViewUserAsync(id);
        }
        
        public System.Data.DataSet AllUsers() {
            return base.Channel.AllUsers();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> AllUsersAsync() {
            return base.Channel.AllUsersAsync();
        }
        
        public FreelanceService.ModelClasses.User Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<FreelanceService.ModelClasses.User> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
    }
}
