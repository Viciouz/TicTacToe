using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shared
{
    public interface GameServerBridge
    {
        GameState GameState { get; set; }
        bool NewStateSince(DateTime date);
    }
}
