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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct NavLocalGridManager_fields {
    }
    internal unsafe struct NavLocalGridManager_methods {
        internal struct AddLocalNavigationGridForBox_method {
            static internal IntPtr AddLocalNavigationGridForBox_ptr;
            static AddLocalNavigationGridForBox_method() {
                AddLocalNavigationGridForBox_ptr = Main.GetMethodUFunction(NavLocalGridManager.StaticClass, "AddLocalNavigationGridForBox");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, Vector Location, Vector Extent, Rotator Rotation, int Radius2D, float Height, bool bRebuildGrids) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Location;
                *((Vector*)(b+20)) = Extent;
                *((Rotator*)(b+32)) = Rotation;
                *((int*)(b+44)) = Radius2D;
                *((float*)(b+48)) = Height;
                *((bool*)(b+52)) = bRebuildGrids;
                Main.GetProcessEvent(NavLocalGridManager.DefaultObject, AddLocalNavigationGridForBox_ptr, new IntPtr(p)); ;
                return *((int*)(b+56));
            }
        }
        internal struct AddLocalNavigationGridForCapsule_method {
            static internal IntPtr AddLocalNavigationGridForCapsule_ptr;
            static AddLocalNavigationGridForCapsule_method() {
                AddLocalNavigationGridForCapsule_ptr = Main.GetMethodUFunction(NavLocalGridManager.StaticClass, "AddLocalNavigationGridForCapsule");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, Vector Location, float CapsuleRadius, float CapsuleHalfHeight, int Radius2D, float Height, bool bRebuildGrids) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Location;
                *((float*)(b+20)) = CapsuleRadius;
                *((float*)(b+24)) = CapsuleHalfHeight;
                *((int*)(b+28)) = Radius2D;
                *((float*)(b+32)) = Height;
                *((bool*)(b+36)) = bRebuildGrids;
                Main.GetProcessEvent(NavLocalGridManager.DefaultObject, AddLocalNavigationGridForCapsule_ptr, new IntPtr(p)); ;
                return *((int*)(b+40));
            }
        }
        internal struct AddLocalNavigationGridForPoint_method {
            static internal IntPtr AddLocalNavigationGridForPoint_ptr;
            static AddLocalNavigationGridForPoint_method() {
                AddLocalNavigationGridForPoint_ptr = Main.GetMethodUFunction(NavLocalGridManager.StaticClass, "AddLocalNavigationGridForPoint");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, Vector Location, int Radius2D, float Height, bool bRebuildGrids) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Location;
                *((int*)(b+20)) = Radius2D;
                *((float*)(b+24)) = Height;
                *((bool*)(b+28)) = bRebuildGrids;
                Main.GetProcessEvent(NavLocalGridManager.DefaultObject, AddLocalNavigationGridForPoint_ptr, new IntPtr(p)); ;
                return *((int*)(b+32));
            }
        }
        internal struct AddLocalNavigationGridForPoints_method {
            static internal IntPtr AddLocalNavigationGridForPoints_ptr;
            static AddLocalNavigationGridForPoints_method() {
                AddLocalNavigationGridForPoints_ptr = Main.GetMethodUFunction(NavLocalGridManager.StaticClass, "AddLocalNavigationGridForPoints");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, byte Locations /*TODO: array TArray */, int Radius2D, float Height, bool bRebuildGrids) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: array TArray Locations
                *((int*)(b+24)) = Radius2D;
                *((float*)(b+28)) = Height;
                *((bool*)(b+32)) = bRebuildGrids;
                Main.GetProcessEvent(NavLocalGridManager.DefaultObject, AddLocalNavigationGridForPoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Locations
                return *((int*)(b+36));
            }
        }
        internal struct FindLocalNavigationGridPath_method {
            static internal IntPtr FindLocalNavigationGridPath_ptr;
            static FindLocalNavigationGridPath_method() {
                FindLocalNavigationGridPath_ptr = Main.GetMethodUFunction(NavLocalGridManager.StaticClass, "FindLocalNavigationGridPath");
            }

            internal static unsafe (IReadOnlyCollection<Vector>, bool) Invoke(UObject WorldContextObject, Vector Start, Vector End) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((Vector*)(b+8)) = Start;
                *((Vector*)(b+20)) = End;
                Main.GetProcessEvent(NavLocalGridManager.DefaultObject, FindLocalNavigationGridPath_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PathPoints
                return (UObject.ToUnmangedCollection<Vector>(b+32),*((bool*)(b+48)));
            }
        }
        internal struct RemoveLocalNavigationGrid_method {
            static internal IntPtr RemoveLocalNavigationGrid_ptr;
            static RemoveLocalNavigationGrid_method() {
                RemoveLocalNavigationGrid_ptr = Main.GetMethodUFunction(NavLocalGridManager.StaticClass, "RemoveLocalNavigationGrid");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, int GridId, bool bRebuildGrids) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((int*)(b+8)) = GridId;
                *((bool*)(b+12)) = bRebuildGrids;
                Main.GetProcessEvent(NavLocalGridManager.DefaultObject, RemoveLocalNavigationGrid_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLocalNavigationGridDensity_method {
            static internal IntPtr SetLocalNavigationGridDensity_ptr;
            static SetLocalNavigationGridDensity_method() {
                SetLocalNavigationGridDensity_ptr = Main.GetMethodUFunction(NavLocalGridManager.StaticClass, "SetLocalNavigationGridDensity");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, float CellSize) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((float*)(b+8)) = CellSize;
                Main.GetProcessEvent(NavLocalGridManager.DefaultObject, SetLocalNavigationGridDensity_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
    }
    internal unsafe struct NavLocalGridManager_events {
    }
}
