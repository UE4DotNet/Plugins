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
        ///<summary>Stores information about a parameter collection that this material references, used to know when the material needs to be recompiled.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct MaterialParameterCollectionInfo {
            ///<summary>Id that the collection had when this material was last compiled.</summary>
            [FieldOffset(0)] FGuid StateId;

            [FieldOffset(16)] 
            private IntPtr  ParameterCollection_field;
            ///<summary>The collection which this material has a dependency on.</summary>
            public MaterialParameterCollection ParameterCollection {
                get {return ParameterCollection_field;}
                set {ParameterCollection_field = value;}
            }

        }
}
