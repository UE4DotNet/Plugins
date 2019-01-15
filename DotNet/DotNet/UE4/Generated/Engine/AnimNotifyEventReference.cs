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
        ///<summary>Anim Notify Event Reference</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct AnimNotifyEventReference {
            [FieldOffset(8)] 
            private IntPtr  NotifySource_field;
            ///<summary>Notify Source</summary>
            public UObject NotifySource {
                get {return NotifySource_field;}
                set {NotifySource_field = value;}
            }

        }
}
