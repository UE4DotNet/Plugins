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
        ///<summary>This represents a baked transition</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct AnimationTransitionBetweenStates {
            [FieldOffset(12)] public int PreviousState;

            [FieldOffset(16)] public int NextState;

            [FieldOffset(20)] public float CrossfadeDuration;

            [FieldOffset(24)] public int StartNotify;

            [FieldOffset(28)] public int EndNotify;

            [FieldOffset(32)] public int InterruptNotify;

            [FieldOffset(36)] byte BlendMode; //TODO: enum EAlphaBlendOption BlendMode

            [FieldOffset(40)] 
            private IntPtr  CustomCurve_field;
            ///<summary>Custom Curve</summary>
            public CurveFloat CustomCurve {
                get {return CustomCurve_field;}
                set {CustomCurve_field = value;}
            }

            [FieldOffset(48)] 
            private IntPtr  BlendProfile_field;
            ///<summary>Blend Profile</summary>
            public BlendProfile BlendProfile {
                get {return BlendProfile_field;}
                set {BlendProfile_field = value;}
            }

            [FieldOffset(56)] public byte LogicType;

        }
}
