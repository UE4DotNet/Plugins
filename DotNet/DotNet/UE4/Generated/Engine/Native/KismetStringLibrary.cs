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
    internal unsafe struct KismetStringLibrary_fields {
    }
    internal unsafe struct KismetStringLibrary_methods {
        internal struct BuildString_Bool_method {
            static internal IntPtr BuildString_Bool_ptr;
            static BuildString_Bool_method() {
                BuildString_Bool_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Bool");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, bool InBool, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((bool*)(b+32)) = InBool;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+40) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Bool_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+56);
            }
        }
        internal struct BuildString_Color_method {
            static internal IntPtr BuildString_Color_ptr;
            static BuildString_Color_method() {
                BuildString_Color_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Color");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, LinearColor InColor, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((LinearColor*)(b+32)) = InColor;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+48) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+48) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+48) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Color_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+64);
            }
        }
        internal struct BuildString_Float_method {
            static internal IntPtr BuildString_Float_ptr;
            static BuildString_Float_method() {
                BuildString_Float_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Float");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, float InFloat, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((float*)(b+32)) = InFloat;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+40) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Float_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+56);
            }
        }
        internal struct BuildString_Int_method {
            static internal IntPtr BuildString_Int_ptr;
            static BuildString_Int_method() {
                BuildString_Int_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Int");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, int InInt, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((int*)(b+32)) = InInt;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+40) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Int_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+56);
            }
        }
        internal struct BuildString_IntVector_method {
            static internal IntPtr BuildString_IntVector_ptr;
            static BuildString_IntVector_method() {
                BuildString_IntVector_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_IntVector");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, IntVector InIntVector, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((IntVector*)(b+32)) = InIntVector;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+48) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+48) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+48) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_IntVector_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+64);
            }
        }
        internal struct BuildString_Name_method {
            static internal IntPtr BuildString_Name_ptr;
            static BuildString_Name_method() {
                BuildString_Name_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Name");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, Name InName, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((Name*)(b+32)) = InName;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+48) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+48) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+48) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Name_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+64);
            }
        }
        internal struct BuildString_Object_method {
            static internal IntPtr BuildString_Object_ptr;
            static BuildString_Object_method() {
                BuildString_Object_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Object");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, UObject InObj, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((IntPtr*)(b+32)) = InObj;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+40) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Object_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+56);
            }
        }
        internal struct BuildString_Rotator_method {
            static internal IntPtr BuildString_Rotator_ptr;
            static BuildString_Rotator_method() {
                BuildString_Rotator_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Rotator");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, Rotator InRot, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((Rotator*)(b+32)) = InRot;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+48) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+48) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+48) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Rotator_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+64);
            }
        }
        internal struct BuildString_Vector_method {
            static internal IntPtr BuildString_Vector_ptr;
            static BuildString_Vector_method() {
                BuildString_Vector_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Vector");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, Vector InVector, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((Vector*)(b+32)) = InVector;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+48) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+48) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+48) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Vector_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+64);
            }
        }
        internal struct BuildString_Vector2d_method {
            static internal IntPtr BuildString_Vector2d_ptr;
            static BuildString_Vector2d_method() {
                BuildString_Vector2d_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "BuildString_Vector2d");
            }

            internal static unsafe string Invoke(string AppendTo, string Prefix, Vector2D InVector2d, string Suffix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var AppendTo_handle = GCHandle.Alloc(AppendTo, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = AppendTo_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = AppendTo.Length;
                *(int*)(b+IntPtr.Size+4+0) = AppendTo.Length;
                var Prefix_handle = GCHandle.Alloc(Prefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Prefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Prefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = Prefix.Length;
                *((Vector2D*)(b+32)) = InVector2d;
                var Suffix_handle = GCHandle.Alloc(Suffix, GCHandleType.Pinned);
                *(IntPtr*)(b+40) = Suffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+40) = Suffix.Length;
                *(int*)(b+IntPtr.Size+4+40) = Suffix.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, BuildString_Vector2d_ptr, new IntPtr(p)); ;
                AppendTo_handle.Free();
                Prefix_handle.Free();
                Suffix_handle.Free();
                return FString.Get(b+56);
            }
        }
        internal struct Concat_StrStr_method {
            static internal IntPtr Concat_StrStr_ptr;
            static Concat_StrStr_method() {
                Concat_StrStr_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Concat_StrStr");
            }

            internal static unsafe string Invoke(string A, string B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var A_handle = GCHandle.Alloc(A, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = A_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = A.Length;
                *(int*)(b+IntPtr.Size+4+0) = A.Length;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = B.Length;
                *(int*)(b+IntPtr.Size+4+16) = B.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Concat_StrStr_ptr, new IntPtr(p)); ;
                A_handle.Free();
                B_handle.Free();
                return FString.Get(b+32);
            }
        }
        internal struct Contains_method {
            static internal IntPtr Contains_ptr;
            static Contains_method() {
                Contains_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Contains");
            }

            internal static unsafe bool Invoke(string SearchIn, string Substring, bool bUseCase, bool bSearchFromEnd) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SearchIn_handle = GCHandle.Alloc(SearchIn, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SearchIn_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SearchIn.Length;
                *(int*)(b+IntPtr.Size+4+0) = SearchIn.Length;
                var Substring_handle = GCHandle.Alloc(Substring, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Substring_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Substring.Length;
                *(int*)(b+IntPtr.Size+4+16) = Substring.Length;
                *((bool*)(b+32)) = bUseCase;
                *((bool*)(b+33)) = bSearchFromEnd;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Contains_ptr, new IntPtr(p)); ;
                SearchIn_handle.Free();
                Substring_handle.Free();
                return *((bool*)(b+34));
            }
        }
        internal struct Conv_BoolToString_method {
            static internal IntPtr Conv_BoolToString_ptr;
            static Conv_BoolToString_method() {
                Conv_BoolToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_BoolToString");
            }

            internal static unsafe string Invoke(bool InBool) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InBool;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_BoolToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct Conv_ByteToString_method {
            static internal IntPtr Conv_ByteToString_ptr;
            static Conv_ByteToString_method() {
                Conv_ByteToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_ByteToString");
            }

            internal static unsafe string Invoke(byte InByte) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InByte;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_ByteToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct Conv_ColorToString_method {
            static internal IntPtr Conv_ColorToString_ptr;
            static Conv_ColorToString_method() {
                Conv_ColorToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_ColorToString");
            }

            internal static unsafe string Invoke(LinearColor InColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColor;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_ColorToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct Conv_FloatToString_method {
            static internal IntPtr Conv_FloatToString_ptr;
            static Conv_FloatToString_method() {
                Conv_FloatToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_FloatToString");
            }

            internal static unsafe string Invoke(float InFloat) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InFloat;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_FloatToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct Conv_IntToString_method {
            static internal IntPtr Conv_IntToString_ptr;
            static Conv_IntToString_method() {
                Conv_IntToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_IntToString");
            }

            internal static unsafe string Invoke(int InInt) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InInt;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_IntToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct Conv_IntVectorToString_method {
            static internal IntPtr Conv_IntVectorToString_ptr;
            static Conv_IntVectorToString_method() {
                Conv_IntVectorToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_IntVectorToString");
            }

            internal static unsafe string Invoke(IntVector InIntVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntVector*)(b+0)) = InIntVec;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_IntVectorToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct Conv_NameToString_method {
            static internal IntPtr Conv_NameToString_ptr;
            static Conv_NameToString_method() {
                Conv_NameToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_NameToString");
            }

            internal static unsafe string Invoke(Name InName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_NameToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct Conv_ObjectToString_method {
            static internal IntPtr Conv_ObjectToString_ptr;
            static Conv_ObjectToString_method() {
                Conv_ObjectToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_ObjectToString");
            }

            internal static unsafe string Invoke(UObject InObj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InObj;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_ObjectToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct Conv_RotatorToString_method {
            static internal IntPtr Conv_RotatorToString_ptr;
            static Conv_RotatorToString_method() {
                Conv_RotatorToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_RotatorToString");
            }

            internal static unsafe string Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_RotatorToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct Conv_StringToColor_method {
            static internal IntPtr Conv_StringToColor_ptr;
            static Conv_StringToColor_method() {
                Conv_StringToColor_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_StringToColor");
            }

            internal static unsafe (LinearColor, bool) Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_StringToColor_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                return (*((LinearColor*)(b+16)),*((bool*)(b+32)));
            }
        }
        internal struct Conv_StringToFloat_method {
            static internal IntPtr Conv_StringToFloat_ptr;
            static Conv_StringToFloat_method() {
                Conv_StringToFloat_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_StringToFloat");
            }

            internal static unsafe float Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_StringToFloat_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                return *((float*)(b+16));
            }
        }
        internal struct Conv_StringToInt_method {
            static internal IntPtr Conv_StringToInt_ptr;
            static Conv_StringToInt_method() {
                Conv_StringToInt_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_StringToInt");
            }

            internal static unsafe int Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_StringToInt_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                return *((int*)(b+16));
            }
        }
        internal struct Conv_StringToName_method {
            static internal IntPtr Conv_StringToName_ptr;
            static Conv_StringToName_method() {
                Conv_StringToName_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_StringToName");
            }

            internal static unsafe Name Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_StringToName_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                return *((Name*)(b+16));
            }
        }
        internal struct Conv_StringToRotator_method {
            static internal IntPtr Conv_StringToRotator_ptr;
            static Conv_StringToRotator_method() {
                Conv_StringToRotator_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_StringToRotator");
            }

            internal static unsafe (Rotator, bool) Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_StringToRotator_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                return (*((Rotator*)(b+16)),*((bool*)(b+28)));
            }
        }
        internal struct Conv_StringToVector_method {
            static internal IntPtr Conv_StringToVector_ptr;
            static Conv_StringToVector_method() {
                Conv_StringToVector_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_StringToVector");
            }

            internal static unsafe (Vector, bool) Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_StringToVector_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                return (*((Vector*)(b+16)),*((bool*)(b+28)));
            }
        }
        internal struct Conv_StringToVector2D_method {
            static internal IntPtr Conv_StringToVector2D_ptr;
            static Conv_StringToVector2D_method() {
                Conv_StringToVector2D_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_StringToVector2D");
            }

            internal static unsafe (Vector2D, bool) Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_StringToVector2D_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                return (*((Vector2D*)(b+16)),*((bool*)(b+24)));
            }
        }
        internal struct Conv_TransformToString_method {
            static internal IntPtr Conv_TransformToString_ptr;
            static Conv_TransformToString_method() {
                Conv_TransformToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_TransformToString");
            }

            internal static unsafe string Invoke(Transform InTrans) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = InTrans;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_TransformToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+48);
            }
        }
        internal struct Conv_Vector2dToString_method {
            static internal IntPtr Conv_Vector2dToString_ptr;
            static Conv_Vector2dToString_method() {
                Conv_Vector2dToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_Vector2dToString");
            }

            internal static unsafe string Invoke(Vector2D InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_Vector2dToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct Conv_VectorToString_method {
            static internal IntPtr Conv_VectorToString_ptr;
            static Conv_VectorToString_method() {
                Conv_VectorToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Conv_VectorToString");
            }

            internal static unsafe string Invoke(Vector InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Conv_VectorToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct CullArray_method {
            static internal IntPtr CullArray_ptr;
            static CullArray_method() {
                CullArray_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "CullArray");
            }

            internal static unsafe (IReadOnlyCollection<string>, int) Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, CullArray_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                 //TODO: array TArray InArray
                return (UObject.ToStringCollection(b+16),*((int*)(b+32)));
            }
        }
        internal struct EndsWith_method {
            static internal IntPtr EndsWith_ptr;
            static EndsWith_method() {
                EndsWith_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "EndsWith");
            }

            internal static unsafe bool Invoke(string SourceString, string InSuffix, byte SearchCase) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                var InSuffix_handle = GCHandle.Alloc(InSuffix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InSuffix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InSuffix.Length;
                *(int*)(b+IntPtr.Size+4+16) = InSuffix.Length;
                *(b+32) = SearchCase;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, EndsWith_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                InSuffix_handle.Free();
                return *((bool*)(b+33));
            }
        }
        internal struct EqualEqual_StriStri_method {
            static internal IntPtr EqualEqual_StriStri_ptr;
            static EqualEqual_StriStri_method() {
                EqualEqual_StriStri_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "EqualEqual_StriStri");
            }

            internal static unsafe bool Invoke(string A, string B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var A_handle = GCHandle.Alloc(A, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = A_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = A.Length;
                *(int*)(b+IntPtr.Size+4+0) = A.Length;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = B.Length;
                *(int*)(b+IntPtr.Size+4+16) = B.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, EqualEqual_StriStri_ptr, new IntPtr(p)); ;
                A_handle.Free();
                B_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct EqualEqual_StrStr_method {
            static internal IntPtr EqualEqual_StrStr_ptr;
            static EqualEqual_StrStr_method() {
                EqualEqual_StrStr_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "EqualEqual_StrStr");
            }

            internal static unsafe bool Invoke(string A, string B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var A_handle = GCHandle.Alloc(A, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = A_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = A.Length;
                *(int*)(b+IntPtr.Size+4+0) = A.Length;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = B.Length;
                *(int*)(b+IntPtr.Size+4+16) = B.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, EqualEqual_StrStr_ptr, new IntPtr(p)); ;
                A_handle.Free();
                B_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct FindSubstring_method {
            static internal IntPtr FindSubstring_ptr;
            static FindSubstring_method() {
                FindSubstring_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "FindSubstring");
            }

            internal static unsafe int Invoke(string SearchIn, string Substring, bool bUseCase, bool bSearchFromEnd, int StartPosition) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SearchIn_handle = GCHandle.Alloc(SearchIn, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SearchIn_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SearchIn.Length;
                *(int*)(b+IntPtr.Size+4+0) = SearchIn.Length;
                var Substring_handle = GCHandle.Alloc(Substring, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Substring_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Substring.Length;
                *(int*)(b+IntPtr.Size+4+16) = Substring.Length;
                *((bool*)(b+32)) = bUseCase;
                *((bool*)(b+33)) = bSearchFromEnd;
                *((int*)(b+36)) = StartPosition;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, FindSubstring_ptr, new IntPtr(p)); ;
                SearchIn_handle.Free();
                Substring_handle.Free();
                return *((int*)(b+40));
            }
        }
        internal struct GetCharacterArrayFromString_method {
            static internal IntPtr GetCharacterArrayFromString_ptr;
            static GetCharacterArrayFromString_method() {
                GetCharacterArrayFromString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "GetCharacterArrayFromString");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, GetCharacterArrayFromString_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                 //TODO: array TArray ReturnValue
                return UObject.ToStringCollection(b+16);
            }
        }
        internal struct GetCharacterAsNumber_method {
            static internal IntPtr GetCharacterAsNumber_ptr;
            static GetCharacterAsNumber_method() {
                GetCharacterAsNumber_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "GetCharacterAsNumber");
            }

            internal static unsafe int Invoke(string SourceString, int Index) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = Index;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, GetCharacterAsNumber_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return *((int*)(b+20));
            }
        }
        internal struct GetSubstring_method {
            static internal IntPtr GetSubstring_ptr;
            static GetSubstring_method() {
                GetSubstring_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "GetSubstring");
            }

            internal static unsafe string Invoke(string SourceString, int StartIndex, int Length) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = StartIndex;
                *((int*)(b+20)) = Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, GetSubstring_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct IsNumeric_method {
            static internal IntPtr IsNumeric_ptr;
            static IsNumeric_method() {
                IsNumeric_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "IsNumeric");
            }

            internal static unsafe bool Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, IsNumeric_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return *((bool*)(b+16));
            }
        }
        internal struct JoinStringArray_method {
            static internal IntPtr JoinStringArray_ptr;
            static JoinStringArray_method() {
                JoinStringArray_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "JoinStringArray");
            }

            internal static unsafe string Invoke(byte SourceArray /*TODO: array TArray */, string Separator) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray SourceArray
                var Separator_handle = GCHandle.Alloc(Separator, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Separator_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Separator.Length;
                *(int*)(b+IntPtr.Size+4+16) = Separator.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, JoinStringArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray SourceArray
                Separator_handle.Free();
                return FString.Get(b+32);
            }
        }
        internal struct Left_method {
            static internal IntPtr Left_ptr;
            static Left_method() {
                Left_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Left");
            }

            internal static unsafe string Invoke(string SourceString, int Count) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = Count;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Left_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct LeftChop_method {
            static internal IntPtr LeftChop_ptr;
            static LeftChop_method() {
                LeftChop_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "LeftChop");
            }

            internal static unsafe string Invoke(string SourceString, int Count) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = Count;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, LeftChop_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct LeftPad_method {
            static internal IntPtr LeftPad_ptr;
            static LeftPad_method() {
                LeftPad_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "LeftPad");
            }

            internal static unsafe string Invoke(string SourceString, int ChCount) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = ChCount;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, LeftPad_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct Len_method {
            static internal IntPtr Len_ptr;
            static Len_method() {
                Len_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Len");
            }

            internal static unsafe int Invoke(string S) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var S_handle = GCHandle.Alloc(S, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = S_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = S.Length;
                *(int*)(b+IntPtr.Size+4+0) = S.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Len_ptr, new IntPtr(p)); ;
                S_handle.Free();
                return *((int*)(b+16));
            }
        }
        internal struct MatchesWildcard_method {
            static internal IntPtr MatchesWildcard_ptr;
            static MatchesWildcard_method() {
                MatchesWildcard_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "MatchesWildcard");
            }

            internal static unsafe bool Invoke(string SourceString, string Wildcard, byte SearchCase) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                var Wildcard_handle = GCHandle.Alloc(Wildcard, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Wildcard_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Wildcard.Length;
                *(int*)(b+IntPtr.Size+4+16) = Wildcard.Length;
                *(b+32) = SearchCase;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, MatchesWildcard_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                Wildcard_handle.Free();
                return *((bool*)(b+33));
            }
        }
        internal struct Mid_method {
            static internal IntPtr Mid_ptr;
            static Mid_method() {
                Mid_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Mid");
            }

            internal static unsafe string Invoke(string SourceString, int Start, int Count) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = Start;
                *((int*)(b+20)) = Count;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Mid_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct NotEqual_StriStri_method {
            static internal IntPtr NotEqual_StriStri_ptr;
            static NotEqual_StriStri_method() {
                NotEqual_StriStri_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "NotEqual_StriStri");
            }

            internal static unsafe bool Invoke(string A, string B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var A_handle = GCHandle.Alloc(A, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = A_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = A.Length;
                *(int*)(b+IntPtr.Size+4+0) = A.Length;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = B.Length;
                *(int*)(b+IntPtr.Size+4+16) = B.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, NotEqual_StriStri_ptr, new IntPtr(p)); ;
                A_handle.Free();
                B_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct NotEqual_StrStr_method {
            static internal IntPtr NotEqual_StrStr_ptr;
            static NotEqual_StrStr_method() {
                NotEqual_StrStr_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "NotEqual_StrStr");
            }

            internal static unsafe bool Invoke(string A, string B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var A_handle = GCHandle.Alloc(A, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = A_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = A.Length;
                *(int*)(b+IntPtr.Size+4+0) = A.Length;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = B.Length;
                *(int*)(b+IntPtr.Size+4+16) = B.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, NotEqual_StrStr_ptr, new IntPtr(p)); ;
                A_handle.Free();
                B_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct ParseIntoArray_method {
            static internal IntPtr ParseIntoArray_ptr;
            static ParseIntoArray_method() {
                ParseIntoArray_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "ParseIntoArray");
            }

            internal static unsafe IReadOnlyCollection<string> Invoke(string SourceString, string Delimiter, bool CullEmptyStrings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                var Delimiter_handle = GCHandle.Alloc(Delimiter, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Delimiter_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Delimiter.Length;
                *(int*)(b+IntPtr.Size+4+16) = Delimiter.Length;
                *((bool*)(b+32)) = CullEmptyStrings;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, ParseIntoArray_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                Delimiter_handle.Free();
                 //TODO: array TArray ReturnValue
                return UObject.ToStringCollection(b+40);
            }
        }
        internal struct Replace_method {
            static internal IntPtr Replace_ptr;
            static Replace_method() {
                Replace_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Replace");
            }

            internal static unsafe string Invoke(string SourceString, string From, string To, byte SearchCase) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                var From_handle = GCHandle.Alloc(From, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = From_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = From.Length;
                *(int*)(b+IntPtr.Size+4+16) = From.Length;
                var To_handle = GCHandle.Alloc(To, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = To_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = To.Length;
                *(int*)(b+IntPtr.Size+4+32) = To.Length;
                *(b+48) = SearchCase;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Replace_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                From_handle.Free();
                To_handle.Free();
                return FString.Get(b+56);
            }
        }
        internal struct ReplaceInline_method {
            static internal IntPtr ReplaceInline_ptr;
            static ReplaceInline_method() {
                ReplaceInline_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "ReplaceInline");
            }

            internal static unsafe int Invoke(string SourceString, string SearchText, string ReplacementText, byte SearchCase) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                var SearchText_handle = GCHandle.Alloc(SearchText, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = SearchText_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = SearchText.Length;
                *(int*)(b+IntPtr.Size+4+16) = SearchText.Length;
                var ReplacementText_handle = GCHandle.Alloc(ReplacementText, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = ReplacementText_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = ReplacementText.Length;
                *(int*)(b+IntPtr.Size+4+32) = ReplacementText.Length;
                *(b+48) = SearchCase;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, ReplaceInline_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                SearchText_handle.Free();
                ReplacementText_handle.Free();
                return *((int*)(b+52));
            }
        }
        internal struct Reverse_method {
            static internal IntPtr Reverse_ptr;
            static Reverse_method() {
                Reverse_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Reverse");
            }

            internal static unsafe string Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Reverse_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct Right_method {
            static internal IntPtr Right_ptr;
            static Right_method() {
                Right_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Right");
            }

            internal static unsafe string Invoke(string SourceString, int Count) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = Count;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Right_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct RightChop_method {
            static internal IntPtr RightChop_ptr;
            static RightChop_method() {
                RightChop_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "RightChop");
            }

            internal static unsafe string Invoke(string SourceString, int Count) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = Count;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, RightChop_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct RightPad_method {
            static internal IntPtr RightPad_ptr;
            static RightPad_method() {
                RightPad_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "RightPad");
            }

            internal static unsafe string Invoke(string SourceString, int ChCount) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                *((int*)(b+16)) = ChCount;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, RightPad_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+24);
            }
        }
        internal struct Split_method {
            static internal IntPtr Split_ptr;
            static Split_method() {
                Split_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Split");
            }

            internal static unsafe (string, string, bool) Invoke(string SourceString, string InStr, byte SearchCase, byte SearchDir) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                var InStr_handle = GCHandle.Alloc(InStr, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InStr_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InStr.Length;
                *(int*)(b+IntPtr.Size+4+16) = InStr.Length;
                *(b+64) = SearchCase;
                *(b+65) = SearchDir;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Split_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                InStr_handle.Free();
                return (FString.Get(b+32),FString.Get(b+48),*((bool*)(b+66)));
            }
        }
        internal struct StartsWith_method {
            static internal IntPtr StartsWith_ptr;
            static StartsWith_method() {
                StartsWith_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "StartsWith");
            }

            internal static unsafe bool Invoke(string SourceString, string InPrefix, byte SearchCase) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                var InPrefix_handle = GCHandle.Alloc(InPrefix, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = InPrefix_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = InPrefix.Length;
                *(int*)(b+IntPtr.Size+4+16) = InPrefix.Length;
                *(b+32) = SearchCase;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, StartsWith_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                InPrefix_handle.Free();
                return *((bool*)(b+33));
            }
        }
        internal struct TimeSecondsToString_method {
            static internal IntPtr TimeSecondsToString_ptr;
            static TimeSecondsToString_method() {
                TimeSecondsToString_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "TimeSecondsToString");
            }

            internal static unsafe string Invoke(float InSeconds) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InSeconds;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, TimeSecondsToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+8);
            }
        }
        internal struct ToLower_method {
            static internal IntPtr ToLower_ptr;
            static ToLower_method() {
                ToLower_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "ToLower");
            }

            internal static unsafe string Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, ToLower_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct ToUpper_method {
            static internal IntPtr ToUpper_ptr;
            static ToUpper_method() {
                ToUpper_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "ToUpper");
            }

            internal static unsafe string Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, ToUpper_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct Trim_method {
            static internal IntPtr Trim_ptr;
            static Trim_method() {
                Trim_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "Trim");
            }

            internal static unsafe string Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, Trim_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+16);
            }
        }
        internal struct TrimTrailing_method {
            static internal IntPtr TrimTrailing_ptr;
            static TrimTrailing_method() {
                TrimTrailing_ptr = Main.GetMethodUFunction(KismetStringLibrary.StaticClass, "TrimTrailing");
            }

            internal static unsafe string Invoke(string SourceString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SourceString_handle = GCHandle.Alloc(SourceString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SourceString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SourceString.Length;
                *(int*)(b+IntPtr.Size+4+0) = SourceString.Length;
                Main.GetProcessEvent(KismetStringLibrary.DefaultObject, TrimTrailing_ptr, new IntPtr(p)); ;
                SourceString_handle.Free();
                return FString.Get(b+16);
            }
        }
    }
    internal unsafe struct KismetStringLibrary_events {
    }
}
