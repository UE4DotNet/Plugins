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

namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene Material Parameter Collection Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct MovieSceneMaterialParameterCollectionTemplate {
            [FieldOffset(80)] 
            private IntPtr  MPC_field;
            ///<summary>MPC</summary>
            public MaterialParameterCollection MPC {
                get {return MPC_field;}
                set {MPC_field = value;}
            }

        }
}
