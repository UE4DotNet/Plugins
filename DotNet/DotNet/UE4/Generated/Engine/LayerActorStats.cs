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
        ///<summary>Layer Actor Stats</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct LayerActorStats {
            ///<summary>A Type of Actor currently associated with the Layer</summary>
            public SubclassOf<UObject> Type {
                get {return Type_class; }
                set {Type_class = value; }
            }
            [FieldOffset(0)] private IntPtr Type_class;

            [FieldOffset(8)] public int Total;

        }
}
