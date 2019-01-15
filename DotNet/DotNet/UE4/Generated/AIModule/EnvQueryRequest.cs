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

namespace UE4.AIModule{
        ///<summary>wrapper for easy query execution</summary>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct EnvQueryRequest {
            [FieldOffset(0)] 
            private IntPtr  QueryTemplate_field;
            ///<summary>query to run</summary>
            public EnvQuery QueryTemplate {
                get {return QueryTemplate_field;}
                set {QueryTemplate_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  Owner_field;
            ///<summary>querier</summary>
            public UObject Owner {
                get {return Owner_field;}
                set {Owner_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  World_field;
            ///<summary>world</summary>
            public World World {
                get {return World_field;}
                set {World_field = value;}
            }

        }
}
