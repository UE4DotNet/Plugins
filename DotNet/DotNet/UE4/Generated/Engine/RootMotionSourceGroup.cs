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
        ///<summary>Group of Root Motion Sources that are applied</summary>
        [StructLayout( LayoutKind.Explicit, Size=256 )]
        public unsafe struct RootMotionSourceGroup {
            [FieldOffset(232)] public bool bHasAdditiveSources;

            [FieldOffset(233)] public bool bHasOverrideSources;

            ///<summary>
            ///Saved off pre-additive-applied Velocity, used for being able to reliably add/remove additive
            ///velocity from currently computed Velocity (otherwise we would be removing additive velocity
            ///that no longer exists, like if you run into a wall and your Velocity becomes 0 - subtracting
            ///the velocity that we added heading into the wall last tick would make you go backwards.
            ///</summary>
            ///<remarks>
            ///With
            ///this method we override that resulting Velocity due to obstructions
            ///</remarks>
            [FieldOffset(236)] Vector_NetQuantize10 LastPreAdditiveVelocity;

            [FieldOffset(248)] public bool bIsAdditiveVelocityApplied;

            ///<summary>Aggregate Settings of the last group of accumulated sources</summary>
            [FieldOffset(249)] RootMotionSourceSettings LastAccumulatedSettings;

        }
}
