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
        ///<summary>Point Damage Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct PointDamageEvent {
            [FieldOffset(16)] public float Damage;

            ///<summary>Direction the shot came from. Should be normalized.</summary>
            [FieldOffset(20)] Vector_NetQuantizeNormal ShotDirection;

            ///<summary>Hit Info</summary>
            [FieldOffset(32)] HitResult HitInfo;

        }
}
