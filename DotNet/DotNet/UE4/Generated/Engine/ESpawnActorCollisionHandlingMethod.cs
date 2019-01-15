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

namespace UE4.Engine {
    ///<summary>Defines available strategies for handling the case where an actor is spawned in such a way that it penetrates blocking collision.</summary>
    public enum ESpawnActorCollisionHandlingMethod {
        Undefined = 0x00000000, 
        AlwaysSpawn = 0x00000001, 
        AdjustIfPossibleButAlwaysSpawn = 0x00000002, 
        AdjustIfPossibleButDontSpawnIfColliding = 0x00000003, 
        DontSpawnIfColliding = 0x00000004, 
        ESpawnActorCollisionHandlingMethod_MAX = 0x00000005
    }
}
