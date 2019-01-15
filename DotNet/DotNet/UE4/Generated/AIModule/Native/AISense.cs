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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct AISense_fields {
        [FieldOffset(56)] public float DefaultExpirationAge;
        [FieldOffset(60)] byte NotifyType; //TODO: enum EAISenseNotifyType NotifyType
        [FieldOffset(64)] public bool bWantsNewPawnNotification;
        [FieldOffset(64)] public bool bAutoRegisterAllPawnsAsSources;
        [FieldOffset(72)]  public IntPtr  PerceptionSystemInstance;
    }
    internal unsafe struct AISense_methods {
    }
    internal unsafe struct AISense_events {
    }
}
