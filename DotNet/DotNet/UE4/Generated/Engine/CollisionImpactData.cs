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
        ///<summary>Information about an overall collision, including contacts.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct CollisionImpactData {
            [FieldOffset(0)] byte ContactInfos; //TODO: array TArray ContactInfos

            ///<summary>the total impulse applied as the two objects push against each other</summary>
            [FieldOffset(16)] Vector TotalNormalImpulse;

            ///<summary>the total counterimpulse applied of the two objects sliding against each other</summary>
            [FieldOffset(28)] Vector TotalFrictionImpulse;

        }
}
