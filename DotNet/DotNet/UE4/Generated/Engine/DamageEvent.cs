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
        ///<summary>Damage Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct DamageEvent {
            ///<summary>Optional DamageType for this event.  If nullptr, UDamageType will be assumed.</summary>
            public SubclassOf<DamageType> DamageTypeClass {
                get {return DamageTypeClass_class; }
                set {DamageTypeClass_class = value; }
            }
            [FieldOffset(8)] private IntPtr DamageTypeClass_class;

        }
}
