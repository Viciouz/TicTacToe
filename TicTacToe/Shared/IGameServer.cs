using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Shared
{
    [ServiceContract]
    public interface IGameServer
    {
        GameState GameState { [OperationContract] get; [OperationContract] set; }
        
        [OperationContract]
        bool NewStateSince(DateTime date);
        
        [OperationContract]
        Player StartNewGame();
        
    }
}
