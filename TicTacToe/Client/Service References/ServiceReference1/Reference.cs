﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGameServer")]
    public interface IGameServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameServer/NewStateSince", ReplyAction="http://tempuri.org/IGameServer/NewStateSinceResponse")]
        bool NewStateSince(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameServer/StartNewGame", ReplyAction="http://tempuri.org/IGameServer/StartNewGameResponse")]
        Shared.Player StartNewGame();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameServerChannel : Client.ServiceReference1.IGameServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameServerClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IGameServer>, Client.ServiceReference1.IGameServer {
        
        public GameServerClient() {
        }
        
        public GameServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool NewStateSince(System.DateTime date) {
            return base.Channel.NewStateSince(date);
        }
        
        public Shared.Player StartNewGame() {
            return base.Channel.StartNewGame();
        }
    }
}
