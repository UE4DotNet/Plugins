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
        ///<summary>A mesh proxy entry</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct HLODProxyMesh {
            [FieldOffset(0)] byte LODActor; //TODO: lazy_object TLazyObjectPtr<ALODActor> LODActor

            [FieldOffset(32)] 
            private IntPtr  StaticMesh_field;
            ///<summary>The mesh used to display this proxy</summary>
            public StaticMesh StaticMesh {
                get {return StaticMesh_field;}
                set {StaticMesh_field = value;}
            }

            [FieldOffset(40)] public Name Key;

        }
}
