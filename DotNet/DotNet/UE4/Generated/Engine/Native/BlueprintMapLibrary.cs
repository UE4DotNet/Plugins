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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct BlueprintMapLibrary_fields {
    }
    internal unsafe struct BlueprintMapLibrary_methods {
        internal struct Map_Add_method {
            static internal IntPtr Map_Add_ptr;
            static Map_Add_method() {
                Map_Add_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Add");
            }

            internal static unsafe void Invoke(byte TargetMap /*TODO: map TMap */, int Key, int Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                *((int*)(b+80)) = Key;
                *((int*)(b+84)) = Value;
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Add_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
            }
        }
        internal struct Map_Clear_method {
            static internal IntPtr Map_Clear_ptr;
            static Map_Clear_method() {
                Map_Clear_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Clear");
            }

            internal static unsafe void Invoke(byte TargetMap /*TODO: map TMap */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Clear_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
            }
        }
        internal struct Map_Contains_method {
            static internal IntPtr Map_Contains_ptr;
            static Map_Contains_method() {
                Map_Contains_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Contains");
            }

            internal static unsafe bool Invoke(byte TargetMap /*TODO: map TMap */, int Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                *((int*)(b+80)) = Key;
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Contains_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
                return *((bool*)(b+84));
            }
        }
        internal struct Map_Find_method {
            static internal IntPtr Map_Find_ptr;
            static Map_Find_method() {
                Map_Find_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Find");
            }

            internal static unsafe (int, bool) Invoke(byte TargetMap /*TODO: map TMap */, int Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                *((int*)(b+80)) = Key;
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Find_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
                return (*((int*)(b+84)),*((bool*)(b+88)));
            }
        }
        internal struct Map_Keys_method {
            static internal IntPtr Map_Keys_ptr;
            static Map_Keys_method() {
                Map_Keys_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Keys");
            }

            internal static unsafe IReadOnlyCollection<int> Invoke(byte TargetMap /*TODO: map TMap */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Keys_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
                 //TODO: array TArray Keys
                return UObject.ToUnmangedCollection<int>(b+80);
            }
        }
        internal struct Map_Length_method {
            static internal IntPtr Map_Length_ptr;
            static Map_Length_method() {
                Map_Length_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Length");
            }

            internal static unsafe int Invoke(byte TargetMap /*TODO: map TMap */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Length_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
                return *((int*)(b+80));
            }
        }
        internal struct Map_Remove_method {
            static internal IntPtr Map_Remove_ptr;
            static Map_Remove_method() {
                Map_Remove_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Remove");
            }

            internal static unsafe bool Invoke(byte TargetMap /*TODO: map TMap */, int Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                *((int*)(b+80)) = Key;
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Remove_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
                return *((bool*)(b+84));
            }
        }
        internal struct Map_Values_method {
            static internal IntPtr Map_Values_ptr;
            static Map_Values_method() {
                Map_Values_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "Map_Values");
            }

            internal static unsafe IReadOnlyCollection<int> Invoke(byte TargetMap /*TODO: map TMap */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: map TMap TargetMap
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, Map_Values_ptr, new IntPtr(p)); ;
                 //TODO: map TMap TargetMap
                 //TODO: array TArray Values
                return UObject.ToUnmangedCollection<int>(b+80);
            }
        }
        internal struct SetMapPropertyByName_method {
            static internal IntPtr SetMapPropertyByName_ptr;
            static SetMapPropertyByName_method() {
                SetMapPropertyByName_ptr = Main.GetMethodUFunction(BlueprintMapLibrary.StaticClass, "SetMapPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value /*TODO: map TMap */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                throw new NotImplementedException(); //TODO: map TMap Value
                Main.GetProcessEvent(BlueprintMapLibrary.DefaultObject, SetMapPropertyByName_ptr, new IntPtr(p)); ;
                 //TODO: map TMap Value
            }
        }
    }
    internal unsafe struct BlueprintMapLibrary_events {
    }
}
