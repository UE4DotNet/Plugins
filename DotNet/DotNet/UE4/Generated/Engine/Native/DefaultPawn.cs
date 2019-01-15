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
    [StructLayout( LayoutKind.Explicit, Size=1144 )]
    internal unsafe struct DefaultPawn_fields {
        [FieldOffset(1104)] public float BaseTurnRate;
        [FieldOffset(1108)] public float BaseLookUpRate;
        [FieldOffset(1112)]  public IntPtr  MovementComponent;
        [FieldOffset(1120)]  public IntPtr  CollisionComponent;
        [FieldOffset(1128)]  public IntPtr  MeshComponent;
        [FieldOffset(1136)] public bool bAddDefaultMovementBindings;
    }
    internal unsafe struct DefaultPawn_methods {
        internal struct LookUpAtRate_method {
            static internal IntPtr LookUpAtRate_ptr;
            static LookUpAtRate_method() {
                LookUpAtRate_ptr = Main.GetMethodUFunction(DefaultPawn.StaticClass, "LookUpAtRate");
            }

            internal static unsafe void Invoke(IntPtr obj, float Rate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Rate;
                Main.GetProcessEvent(obj, LookUpAtRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MoveForward_method {
            static internal IntPtr MoveForward_ptr;
            static MoveForward_method() {
                MoveForward_ptr = Main.GetMethodUFunction(DefaultPawn.StaticClass, "MoveForward");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, MoveForward_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MoveRight_method {
            static internal IntPtr MoveRight_ptr;
            static MoveRight_method() {
                MoveRight_ptr = Main.GetMethodUFunction(DefaultPawn.StaticClass, "MoveRight");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, MoveRight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct MoveUp_World_method {
            static internal IntPtr MoveUp_World_ptr;
            static MoveUp_World_method() {
                MoveUp_World_ptr = Main.GetMethodUFunction(DefaultPawn.StaticClass, "MoveUp_World");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, MoveUp_World_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TurnAtRate_method {
            static internal IntPtr TurnAtRate_ptr;
            static TurnAtRate_method() {
                TurnAtRate_ptr = Main.GetMethodUFunction(DefaultPawn.StaticClass, "TurnAtRate");
            }

            internal static unsafe void Invoke(IntPtr obj, float Rate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Rate;
                Main.GetProcessEvent(obj, TurnAtRate_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct DefaultPawn_events {
    }
}
