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
        ///<summary>Anim Parent Node Asset Override</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct AnimParentNodeAssetOverride {
            [FieldOffset(0)] 
            private IntPtr  NewAsset_field;
            ///<summary>New Asset</summary>
            public AnimationAsset NewAsset {
                get {return NewAsset_field;}
                set {NewAsset_field = value;}
            }

            ///<summary>Parent Node Guid</summary>
            [FieldOffset(8)] FGuid ParentNodeGuid;

        }
}
