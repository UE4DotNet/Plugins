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
        ///<summary>This defines one asset mapping</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct AssetMapping {
            [FieldOffset(0)] 
            private IntPtr  SourceAsset_field;
            ///<summary>source asset *</summary>
            public AnimationAsset SourceAsset {
                get {return SourceAsset_field;}
                set {SourceAsset_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  TargetAsset_field;
            ///<summary>source asset *</summary>
            public AnimationAsset TargetAsset {
                get {return TargetAsset_field;}
                set {TargetAsset_field = value;}
            }

        }
}
