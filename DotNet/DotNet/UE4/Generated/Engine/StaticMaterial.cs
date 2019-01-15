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
        ///<summary>Static Material</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct StaticMaterial {
            [FieldOffset(0)] 
            private IntPtr  MaterialInterface_field;
            ///<summary>Material Interface</summary>
            public MaterialInterface MaterialInterface {
                get {return MaterialInterface_field;}
            }

            [FieldOffset(8)] public Name MaterialSlotName;

            [FieldOffset(20)] public Name ImportedMaterialSlotName;

            ///<summary>Data used for texture streaming relative to each UV channels.</summary>
            [FieldOffset(32)] MeshUVChannelInfo UVChannelData;

        }
}
