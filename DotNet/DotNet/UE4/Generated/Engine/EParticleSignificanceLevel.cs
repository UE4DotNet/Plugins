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
    ///<summary>A level of significance for a particle system. Used by game code to enable/disable emitters progressively as they move away from the camera or are occluded/off screen.</summary>
    public enum EParticleSignificanceLevel {
        Low = 0x00000000, 
        Medium = 0x00000001, 
        High = 0x00000002, 
        Critical = 0x00000003, 
        Num = 0x00000004, 
        EParticleSignificanceLevel_MAX = 0x00000005
    }
}
