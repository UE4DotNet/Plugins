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
        ///<summary>RadialForce applies a force pulling or pushing away from a given world location to the target</summary>
        [StructLayout( LayoutKind.Explicit, Size=224 )]
        public unsafe struct RootMotionSource_RadialForce {
            ///<summary>Location</summary>
            [FieldOffset(152)] Vector Location;

            [FieldOffset(168)] 
            private IntPtr  LocationActor_field;
            ///<summary>Location Actor</summary>
            public Actor LocationActor {
                get {return LocationActor_field;}
                set {LocationActor_field = value;}
            }

            [FieldOffset(176)] public float Radius;

            [FieldOffset(180)] public float Strength;

            [FieldOffset(184)] public bool bIsPush;

            [FieldOffset(185)] public bool bNoZForce;

            [FieldOffset(192)] 
            private IntPtr  StrengthDistanceFalloff_field;
            ///<summary>Strength Distance Falloff</summary>
            public CurveFloat StrengthDistanceFalloff {
                get {return StrengthDistanceFalloff_field;}
                set {StrengthDistanceFalloff_field = value;}
            }

            [FieldOffset(200)] 
            private IntPtr  StrengthOverTime_field;
            ///<summary>Strength Over Time</summary>
            public CurveFloat StrengthOverTime {
                get {return StrengthOverTime_field;}
                set {StrengthOverTime_field = value;}
            }

            [FieldOffset(208)] public bool bUseFixedWorldDirection;

            ///<summary>Fixed World Direction</summary>
            [FieldOffset(212)] Rotator FixedWorldDirection;

        }
}
