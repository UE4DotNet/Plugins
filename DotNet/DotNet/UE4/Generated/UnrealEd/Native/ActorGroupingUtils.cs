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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct ActorGroupingUtils_fields {
    }
    internal unsafe struct ActorGroupingUtils_methods {
        internal struct AddSelectedToGroup_method {
            static internal IntPtr AddSelectedToGroup_ptr;
            static AddSelectedToGroup_method() {
                AddSelectedToGroup_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "AddSelectedToGroup");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, AddSelectedToGroup_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Get_method {
            static internal IntPtr Get_ptr;
            static Get_method() {
                Get_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "Get");
            }

            internal static unsafe ActorGroupingUtils Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(ActorGroupingUtils.DefaultObject, Get_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GroupActors_method {
            static internal IntPtr GroupActors_ptr;
            static GroupActors_method() {
                GroupActors_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "GroupActors");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ActorsToGroup /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ActorsToGroup
                Main.GetProcessEvent(obj, GroupActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToGroup
            }
        }
        internal struct GroupSelected_method {
            static internal IntPtr GroupSelected_ptr;
            static GroupSelected_method() {
                GroupSelected_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "GroupSelected");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GroupSelected_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsGroupingActive_method {
            static internal IntPtr IsGroupingActive_ptr;
            static IsGroupingActive_method() {
                IsGroupingActive_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "IsGroupingActive");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(ActorGroupingUtils.DefaultObject, IsGroupingActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct LockSelectedGroups_method {
            static internal IntPtr LockSelectedGroups_ptr;
            static LockSelectedGroups_method() {
                LockSelectedGroups_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "LockSelectedGroups");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, LockSelectedGroups_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveSelectedFromGroup_method {
            static internal IntPtr RemoveSelectedFromGroup_ptr;
            static RemoveSelectedFromGroup_method() {
                RemoveSelectedFromGroup_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "RemoveSelectedFromGroup");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RemoveSelectedFromGroup_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGroupingActive_method {
            static internal IntPtr SetGroupingActive_ptr;
            static SetGroupingActive_method() {
                SetGroupingActive_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "SetGroupingActive");
            }

            internal static unsafe void Invoke(bool bInGroupingActive) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInGroupingActive;
                Main.GetProcessEvent(ActorGroupingUtils.DefaultObject, SetGroupingActive_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UngroupActors_method {
            static internal IntPtr UngroupActors_ptr;
            static UngroupActors_method() {
                UngroupActors_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "UngroupActors");
            }

            internal static unsafe void Invoke(IntPtr obj, byte ActorsToUngroup /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ActorsToUngroup
                Main.GetProcessEvent(obj, UngroupActors_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ActorsToUngroup
            }
        }
        internal struct UngroupSelected_method {
            static internal IntPtr UngroupSelected_ptr;
            static UngroupSelected_method() {
                UngroupSelected_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "UngroupSelected");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UngroupSelected_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnlockSelectedGroups_method {
            static internal IntPtr UnlockSelectedGroups_ptr;
            static UnlockSelectedGroups_method() {
                UnlockSelectedGroups_ptr = Main.GetMethodUFunction(ActorGroupingUtils.StaticClass, "UnlockSelectedGroups");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UnlockSelectedGroups_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ActorGroupingUtils_events {
    }
}
