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


namespace UE4.Foliage{
        ///<summary>A wrapper struct used to allow the use of either FoliageType assets or FoliageType blueprint classes</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct FoliageTypeObject {
            [FieldOffset(0)] 
            private IntPtr  FoliageTypeObject__field;
            ///<summary>The foliage type that will be spawned by the procedural foliage simulation</summary>
            public UObject FoliageTypeObject_ {
                get {return FoliageTypeObject__field;}
                set {FoliageTypeObject__field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  TypeInstance_field;
            ///<summary>The actual instance of the foliage type that is used for spawning</summary>
            public FoliageType_InstancedStaticMesh TypeInstance {
                get {return TypeInstance_field;}
                set {TypeInstance_field = value;}
            }

            [FieldOffset(16)] public bool bIsAsset;

        }
}
