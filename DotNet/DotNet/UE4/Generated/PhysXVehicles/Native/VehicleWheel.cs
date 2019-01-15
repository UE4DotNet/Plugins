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


namespace UE4.PhysXVehicles.Native {
    [StructLayout( LayoutKind.Explicit, Size=256 )]
    internal unsafe struct VehicleWheel_fields {
        [FieldOffset(56)]  public IntPtr  CollisionMesh;
        [FieldOffset(64)] public bool bDontCreateShape;
        [FieldOffset(65)] public bool bAutoAdjustCollisionSize;
        [FieldOffset(68)] public Vector Offset;
        [FieldOffset(80)] public float ShapeRadius;
        [FieldOffset(84)] public float ShapeWidth;
        [FieldOffset(88)] public float Mass;
        [FieldOffset(92)] public float DampingRate;
        [FieldOffset(96)] public float SteerAngle;
        [FieldOffset(100)] public bool bAffectedByHandbrake;
        [FieldOffset(104)]  public IntPtr  TireType;
        [FieldOffset(112)]  public IntPtr  TireConfig;
        [FieldOffset(120)] public float LatStiffMaxLoad;
        [FieldOffset(124)] public float LatStiffValue;
        [FieldOffset(128)] public float LongStiffValue;
        [FieldOffset(132)] public float SuspensionForceOffset;
        [FieldOffset(136)] public float SuspensionMaxRaise;
        [FieldOffset(140)] public float SuspensionMaxDrop;
        [FieldOffset(144)] public float SuspensionNaturalFrequency;
        [FieldOffset(148)] public float SuspensionDampingRatio;
        [FieldOffset(152)] public byte SweepType;
        [FieldOffset(156)] public float MaxBrakeTorque;
        [FieldOffset(160)] public float MaxHandBrakeTorque;
        [FieldOffset(168)]  public IntPtr  VehicleSim;
        [FieldOffset(176)] public int WheelIndex;
        [FieldOffset(180)] public float DebugLongSlip;
        [FieldOffset(184)] public float DebugLatSlip;
        [FieldOffset(188)] public float DebugNormalizedTireLoad;
        [FieldOffset(196)] public float DebugWheelTorque;
        [FieldOffset(200)] public float DebugLongForce;
        [FieldOffset(204)] public float DebugLatForce;
        [FieldOffset(208)] public Vector Location;
        [FieldOffset(220)] public Vector OldLocation;
        [FieldOffset(232)] public Vector Velocity;
    }
    internal unsafe struct VehicleWheel_methods {
        internal struct GetRotationAngle_method {
            static internal IntPtr GetRotationAngle_ptr;
            static GetRotationAngle_method() {
                GetRotationAngle_ptr = Main.GetMethodUFunction(VehicleWheel.StaticClass, "GetRotationAngle");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRotationAngle_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetSteerAngle_method {
            static internal IntPtr GetSteerAngle_ptr;
            static GetSteerAngle_method() {
                GetSteerAngle_ptr = Main.GetMethodUFunction(VehicleWheel.StaticClass, "GetSteerAngle");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSteerAngle_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetSuspensionOffset_method {
            static internal IntPtr GetSuspensionOffset_ptr;
            static GetSuspensionOffset_method() {
                GetSuspensionOffset_ptr = Main.GetMethodUFunction(VehicleWheel.StaticClass, "GetSuspensionOffset");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSuspensionOffset_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsInAir_method {
            static internal IntPtr IsInAir_ptr;
            static IsInAir_method() {
                IsInAir_ptr = Main.GetMethodUFunction(VehicleWheel.StaticClass, "IsInAir");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsInAir_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct VehicleWheel_events {
    }
}
