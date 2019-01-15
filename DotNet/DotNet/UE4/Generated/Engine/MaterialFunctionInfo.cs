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
        ///<summary>Stores information about a function that this material references, used to know when the material needs to be recompiled.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct MaterialFunctionInfo {
            ///<summary>Id that the function had when this material was last compiled.</summary>
            [FieldOffset(0)] FGuid StateId;

            [FieldOffset(16)] 
            private IntPtr  Function_field;
            ///<summary>The function which this material has a dependency on.</summary>
            public MaterialFunctionInterface Function {
                get {return Function_field;}
                set {Function_field = value;}
            }

        }
}
