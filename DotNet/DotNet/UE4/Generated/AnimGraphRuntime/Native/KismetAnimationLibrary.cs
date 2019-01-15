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


namespace UE4.AnimGraphRuntime.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct KismetAnimationLibrary_fields {
    }
    internal unsafe struct KismetAnimationLibrary_methods {
        internal struct K2_LookAt_method {
            static internal IntPtr K2_LookAt_ptr;
            static K2_LookAt_method() {
                K2_LookAt_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_LookAt");
            }

            internal static unsafe Transform Invoke(Transform CurrentTransform, Vector TargetPosition, Vector LookAtVector, bool bUseUpVector, Vector UpVector, float ClampConeInDegree) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = CurrentTransform;
                *((Vector*)(b+48)) = TargetPosition;
                *((Vector*)(b+60)) = LookAtVector;
                *((bool*)(b+72)) = bUseUpVector;
                *((Vector*)(b+76)) = UpVector;
                *((float*)(b+88)) = ClampConeInDegree;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_LookAt_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+96));
            }
        }
        internal struct K2_TwoBoneIK_method {
            static internal IntPtr K2_TwoBoneIK_ptr;
            static K2_TwoBoneIK_method() {
                K2_TwoBoneIK_ptr = Main.GetMethodUFunction(KismetAnimationLibrary.StaticClass, "K2_TwoBoneIK");
            }

            internal static unsafe (Vector, Vector) Invoke(Vector RootPos, Vector JointPos, Vector EndPos, Vector JointTarget, Vector Effector, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = RootPos;
                *((Vector*)(b+12)) = JointPos;
                *((Vector*)(b+24)) = EndPos;
                *((Vector*)(b+36)) = JointTarget;
                *((Vector*)(b+48)) = Effector;
                *((bool*)(b+84)) = bAllowStretching;
                *((float*)(b+88)) = StartStretchRatio;
                *((float*)(b+92)) = MaxStretchScale;
                Main.GetProcessEvent(KismetAnimationLibrary.DefaultObject, K2_TwoBoneIK_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+60)),*((Vector*)(b+72)));
            }
        }
    }
    internal unsafe struct KismetAnimationLibrary_events {
    }
}
