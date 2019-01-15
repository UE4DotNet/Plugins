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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct FbxTestPlan_fields {
        [FieldOffset(56)] byte TestPlanName; //TODO: string FString TestPlanName
        [FieldOffset(72)] public byte Action;
        [FieldOffset(76)] public int LodIndex;
        [FieldOffset(80)] public bool bDeleteFolderAssets;
        [FieldOffset(88)] public NativeArray ExpectedResult;
        [FieldOffset(104)]  public IntPtr  ImportUI;
    }
    internal unsafe struct FbxTestPlan_methods {
    }
    internal unsafe struct FbxTestPlan_events {
    }
}
