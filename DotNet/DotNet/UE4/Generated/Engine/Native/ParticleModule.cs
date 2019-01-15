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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=72 )]
    internal unsafe struct ParticleModule_fields {
        [FieldOffset(56)] public bool bSpawnModule;
        [FieldOffset(56)] public bool bUpdateModule;
        [FieldOffset(56)] public bool bFinalUpdateModule;
        [FieldOffset(56)] public bool bUpdateForGPUEmitter;
        [FieldOffset(56)] public bool bCurvesAsColor;
        [FieldOffset(56)] public bool b3DDrawMode;
        [FieldOffset(56)] public bool bSupported3DDrawMode;
        [FieldOffset(56)] public bool bEnabled;
        [FieldOffset(57)] public bool bEditable;
        [FieldOffset(57)] public bool LODDuplicate;
        [FieldOffset(57)] public bool bSupportsRandomSeed;
        [FieldOffset(57)] public bool bRequiresLoopingNotification;
        [FieldOffset(60)] public byte LODValidity;
        [FieldOffset(64)] public Color ModuleEditorColor;
    }
    internal unsafe struct ParticleModule_methods {
    }
    internal unsafe struct ParticleModule_events {
    }
}
