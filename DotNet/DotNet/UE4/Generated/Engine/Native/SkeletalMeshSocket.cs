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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct SkeletalMeshSocket_fields {
        [FieldOffset(56)] public Name SocketName;
        [FieldOffset(68)] public Name BoneName;
        [FieldOffset(80)] public Vector RelativeLocation;
        [FieldOffset(92)] public Rotator RelativeRotation;
        [FieldOffset(104)] public Vector RelativeScale;
        [FieldOffset(116)] public bool bForceAlwaysAnimated;
    }
    internal unsafe struct SkeletalMeshSocket_methods {
        internal struct GetSocketLocation_method {
            static internal IntPtr GetSocketLocation_ptr;
            static GetSocketLocation_method() {
                GetSocketLocation_ptr = Main.GetMethodUFunction(SkeletalMeshSocket.StaticClass, "GetSocketLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj, SkeletalMeshComponent SkelComp) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SkelComp;
                Main.GetProcessEvent(obj, GetSocketLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct InitializeSocketFromLocation_method {
            static internal IntPtr InitializeSocketFromLocation_ptr;
            static InitializeSocketFromLocation_method() {
                InitializeSocketFromLocation_ptr = Main.GetMethodUFunction(SkeletalMeshSocket.StaticClass, "InitializeSocketFromLocation");
            }

            internal static unsafe void Invoke(IntPtr obj, SkeletalMeshComponent SkelComp, Vector WorldLocation, Vector WorldNormal) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SkelComp;
                *((Vector*)(b+8)) = WorldLocation;
                *((Vector*)(b+20)) = WorldNormal;
                Main.GetProcessEvent(obj, InitializeSocketFromLocation_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SkeletalMeshSocket_events {
    }
}
