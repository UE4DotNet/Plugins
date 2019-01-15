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


namespace UE4.AIModule{
        ///<summary>cache of instances with sorted tests</summary>
        [StructLayout( LayoutKind.Explicit, Size=504 )]
        public unsafe struct EnvQueryInstanceCache {
            [FieldOffset(0)] 
            private IntPtr  Template_field;
            ///<summary>query template, duplicated in manager's world</summary>
            public EnvQuery Template {
                get {return Template_field;}
                set {Template_field = value;}
            }

        }
}
