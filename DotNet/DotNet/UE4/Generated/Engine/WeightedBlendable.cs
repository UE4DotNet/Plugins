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
        ///<summary>Weighted Blendable</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct WeightedBlendable {
            [FieldOffset(0)] public float Weight;

            [FieldOffset(8)] 
            private IntPtr  UObject_field;
            ///<summary>should be of the IBlendableInterface* type but UProperties cannot express that</summary>
            public UObject UObject {
                get {return UObject_field;}
                set {UObject_field = value;}
            }

        }
}
