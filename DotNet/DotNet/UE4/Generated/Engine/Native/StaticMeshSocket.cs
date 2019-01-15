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
    [StructLayout( LayoutKind.Explicit, Size=160 )]
    internal unsafe struct StaticMeshSocket_fields {
        [FieldOffset(56)] public Name SocketName;
        [FieldOffset(68)] public Vector RelativeLocation;
        [FieldOffset(80)] public Rotator RelativeRotation;
        [FieldOffset(92)] public Vector RelativeScale;
        [FieldOffset(104)] byte Tag; //TODO: string FString Tag
        [FieldOffset(120)]  public IntPtr  PreviewStaticMesh;
        [FieldOffset(128)] public bool bSocketCreatedAtImport;
    }
    internal unsafe struct StaticMeshSocket_methods {
    }
    internal unsafe struct StaticMeshSocket_events {
    }
}
