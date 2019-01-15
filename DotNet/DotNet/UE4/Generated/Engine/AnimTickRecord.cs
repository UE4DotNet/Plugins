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
        ///<summary>Information about an animation asset that needs to be ticked</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct AnimTickRecord {
            [FieldOffset(0)] 
            private IntPtr  SourceAsset_field;
            ///<summary>Source Asset</summary>
            public AnimationAsset SourceAsset {
                get {return SourceAsset_field;}
                set {SourceAsset_field = value;}
            }

        }
}
