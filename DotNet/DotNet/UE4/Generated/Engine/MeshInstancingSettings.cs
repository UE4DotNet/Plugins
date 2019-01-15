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


namespace UE4.Engine{
        ///<summary>Mesh instance-replacement settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct MeshInstancingSettings {
            ///<summary>The actor class to attach new instance static mesh components to</summary>
            public SubclassOf<Actor> ActorClassToUse {
                get {return ActorClassToUse_class; }
                set {ActorClassToUse_class = value; }
            }
            [FieldOffset(0)] private IntPtr ActorClassToUse_class;

            [FieldOffset(8)] public int InstanceReplacementThreshold;

            [FieldOffset(12)] byte MeshReplacementMethod; //TODO: enum EMeshInstancingReplacementMethod MeshReplacementMethod

            [FieldOffset(16)] public bool bSkipMeshesWithVertexColors;

            [FieldOffset(17)] public bool bUseHLODVolumes;

        }
}
