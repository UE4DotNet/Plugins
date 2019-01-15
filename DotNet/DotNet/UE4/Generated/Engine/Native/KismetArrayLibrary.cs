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
    internal unsafe struct KismetArrayLibrary_fields {
    }
    internal unsafe struct KismetArrayLibrary_methods {
        internal struct Array_Add_method {
            static internal IntPtr Array_Add_ptr;
            static Array_Add_method() {
                Array_Add_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Add");
            }

            internal static unsafe int Invoke(byte TargetArray /*TODO: array TArray */, int NewItem) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = NewItem;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Add_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((int*)(b+20));
            }
        }
        internal struct Array_AddUnique_method {
            static internal IntPtr Array_AddUnique_ptr;
            static Array_AddUnique_method() {
                Array_AddUnique_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_AddUnique");
            }

            internal static unsafe int Invoke(byte TargetArray /*TODO: array TArray */, int NewItem) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = NewItem;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_AddUnique_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((int*)(b+20));
            }
        }
        internal struct Array_Append_method {
            static internal IntPtr Array_Append_ptr;
            static Array_Append_method() {
                Array_Append_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Append");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */, byte SourceArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                throw new NotImplementedException(); //TODO: array TArray SourceArray
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Append_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                 //TODO: array TArray SourceArray
            }
        }
        internal struct Array_Clear_method {
            static internal IntPtr Array_Clear_ptr;
            static Array_Clear_method() {
                Array_Clear_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Clear");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Clear_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
            }
        }
        internal struct Array_Contains_method {
            static internal IntPtr Array_Contains_ptr;
            static Array_Contains_method() {
                Array_Contains_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Contains");
            }

            internal static unsafe bool Invoke(byte TargetArray /*TODO: array TArray */, int ItemToFind) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = ItemToFind;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Contains_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((bool*)(b+20));
            }
        }
        internal struct Array_Find_method {
            static internal IntPtr Array_Find_ptr;
            static Array_Find_method() {
                Array_Find_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Find");
            }

            internal static unsafe int Invoke(byte TargetArray /*TODO: array TArray */, int ItemToFind) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = ItemToFind;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Find_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((int*)(b+20));
            }
        }
        internal struct Array_Get_method {
            static internal IntPtr Array_Get_ptr;
            static Array_Get_method() {
                Array_Get_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Get");
            }

            internal static unsafe int Invoke(byte TargetArray /*TODO: array TArray */, int Index) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = Index;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Get_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((int*)(b+20));
            }
        }
        internal struct Array_Insert_method {
            static internal IntPtr Array_Insert_ptr;
            static Array_Insert_method() {
                Array_Insert_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Insert");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */, int NewItem, int Index) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = NewItem;
                *((int*)(b+20)) = Index;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Insert_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
            }
        }
        internal struct Array_IsValidIndex_method {
            static internal IntPtr Array_IsValidIndex_ptr;
            static Array_IsValidIndex_method() {
                Array_IsValidIndex_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_IsValidIndex");
            }

            internal static unsafe bool Invoke(byte TargetArray /*TODO: array TArray */, int IndexToTest) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = IndexToTest;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_IsValidIndex_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((bool*)(b+20));
            }
        }
        internal struct Array_LastIndex_method {
            static internal IntPtr Array_LastIndex_ptr;
            static Array_LastIndex_method() {
                Array_LastIndex_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_LastIndex");
            }

            internal static unsafe int Invoke(byte TargetArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_LastIndex_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((int*)(b+16));
            }
        }
        internal struct Array_Length_method {
            static internal IntPtr Array_Length_ptr;
            static Array_Length_method() {
                Array_Length_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Length");
            }

            internal static unsafe int Invoke(byte TargetArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Length_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((int*)(b+16));
            }
        }
        internal struct Array_Remove_method {
            static internal IntPtr Array_Remove_ptr;
            static Array_Remove_method() {
                Array_Remove_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Remove");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */, int IndexToRemove) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = IndexToRemove;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Remove_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
            }
        }
        internal struct Array_RemoveItem_method {
            static internal IntPtr Array_RemoveItem_ptr;
            static Array_RemoveItem_method() {
                Array_RemoveItem_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_RemoveItem");
            }

            internal static unsafe bool Invoke(byte TargetArray /*TODO: array TArray */, int Item) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = Item;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_RemoveItem_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                return *((bool*)(b+20));
            }
        }
        internal struct Array_Resize_method {
            static internal IntPtr Array_Resize_ptr;
            static Array_Resize_method() {
                Array_Resize_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Resize");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */, int Size) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = Size;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Resize_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
            }
        }
        internal struct Array_Set_method {
            static internal IntPtr Array_Set_ptr;
            static Array_Set_method() {
                Array_Set_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Set");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */, int Index, int Item, bool bSizeToFit) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = Index;
                *((int*)(b+20)) = Item;
                *((bool*)(b+24)) = bSizeToFit;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Set_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
            }
        }
        internal struct Array_Shuffle_method {
            static internal IntPtr Array_Shuffle_ptr;
            static Array_Shuffle_method() {
                Array_Shuffle_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Shuffle");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Shuffle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
            }
        }
        internal struct Array_Swap_method {
            static internal IntPtr Array_Swap_ptr;
            static Array_Swap_method() {
                Array_Swap_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "Array_Swap");
            }

            internal static unsafe void Invoke(byte TargetArray /*TODO: array TArray */, int FirstIndex, int SecondIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((int*)(b+16)) = FirstIndex;
                *((int*)(b+20)) = SecondIndex;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, Array_Swap_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
            }
        }
        internal struct FilterArray_method {
            static internal IntPtr FilterArray_ptr;
            static FilterArray_method() {
                FilterArray_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "FilterArray");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(byte TargetArray /*TODO: array TArray */, SubclassOf<Actor> FilterClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray TargetArray
                *((IntPtr*)(b+16)) = FilterClass;
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, FilterArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray TargetArray
                 //TODO: array TArray FilteredArray
                return UObject.ToUObjectCollection<Actor>(b+24);
            }
        }
        internal struct SetArrayPropertyByName_method {
            static internal IntPtr SetArrayPropertyByName_ptr;
            static SetArrayPropertyByName_method() {
                SetArrayPropertyByName_ptr = Main.GetMethodUFunction(KismetArrayLibrary.StaticClass, "SetArrayPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                throw new NotImplementedException(); //TODO: array TArray Value
                Main.GetProcessEvent(KismetArrayLibrary.DefaultObject, SetArrayPropertyByName_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Value
            }
        }
    }
    internal unsafe struct KismetArrayLibrary_events {
    }
}
