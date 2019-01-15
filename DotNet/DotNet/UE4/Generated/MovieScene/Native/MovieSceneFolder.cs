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


namespace UE4.MovieScene.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct MovieSceneFolder_fields {
        [FieldOffset(56)] public Name FolderName;
        [FieldOffset(72)] public NativeArray ChildFolders;
        [FieldOffset(88)] public NativeArray ChildMasterTracks;
        [FieldOffset(104)] public NativeArray ChildObjectBindingStrings;
        [FieldOffset(120)] public Color FolderColor;
        [FieldOffset(124)] public int SortingOrder;
    }
    internal unsafe struct MovieSceneFolder_methods {
    }
    internal unsafe struct MovieSceneFolder_events {
    }
}
