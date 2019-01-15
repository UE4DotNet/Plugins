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


namespace UE4.PluginBrowser.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct NewPluginDescriptorData_fields {
        [FieldOffset(56)] byte CreatedBy; //TODO: string FString CreatedBy
        [FieldOffset(72)] byte CreatedByURL; //TODO: string FString CreatedByURL
        [FieldOffset(88)] byte Description; //TODO: string FString Description
        [FieldOffset(104)] public bool bIsBetaVersion;
    }
    internal unsafe struct NewPluginDescriptorData_methods {
    }
    internal unsafe struct NewPluginDescriptorData_events {
    }
}
