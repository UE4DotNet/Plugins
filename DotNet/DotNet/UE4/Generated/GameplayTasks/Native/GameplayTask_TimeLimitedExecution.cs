// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.GameplayTasks.Native {
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct GameplayTask_TimeLimitedExecution_fields {
        [FieldOffset(136)] byte OnFinished; //TODO: multicast delegate FTaskFinishDelegate OnFinished
        [FieldOffset(152)] byte OnTimeExpired; //TODO: multicast delegate FTaskFinishDelegate OnTimeExpired
    }
    internal unsafe struct GameplayTask_TimeLimitedExecution_methods {
    }
    internal unsafe struct GameplayTask_TimeLimitedExecution_events {
    }
}
