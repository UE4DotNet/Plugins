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

using UE4.Engine;

namespace UE4.UnrealEd{
        ///<summary>Editor World Extension Actor Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct EditorWorldExtensionActorData {
            [FieldOffset(0)] 
            private IntPtr  Actor_field;
            ///<summary>Actor</summary>
            public Actor Actor {
                get {return Actor_field;}
                set {Actor_field = value;}
            }

            [FieldOffset(8)] public bool bValidForPIE;

        }
}
