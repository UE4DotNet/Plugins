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

namespace UE4.DatasmithContent{
        ///<summary>Datasmith Static Material Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct DatasmithStaticMaterialTemplate {
            [FieldOffset(0)] public Name MaterialSlotName;

            [FieldOffset(16)] 
            private IntPtr  MaterialInterface_field;
            ///<summary>Material Interface</summary>
            public MaterialInterface MaterialInterface {
                get {return MaterialInterface_field;}
                set {MaterialInterface_field = value;}
            }

        }
}
