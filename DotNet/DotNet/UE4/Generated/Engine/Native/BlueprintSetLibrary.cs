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
    internal unsafe struct BlueprintSetLibrary_fields {
    }
    internal unsafe struct BlueprintSetLibrary_methods {
        internal struct Set_Add_method {
            static internal IntPtr Set_Add_ptr;
            static Set_Add_method() {
                Set_Add_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Add");
            }

            internal static unsafe void Invoke(byte TargetSet /*TODO: set TSet */, int NewItem) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet TargetSet
                *((int*)(b+80)) = NewItem;
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Add_ptr, new IntPtr(p)); ;
                 //TODO: set TSet TargetSet
            }
        }
        internal struct Set_AddItems_method {
            static internal IntPtr Set_AddItems_ptr;
            static Set_AddItems_method() {
                Set_AddItems_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_AddItems");
            }

            internal static unsafe void Invoke(byte TargetSet /*TODO: set TSet */, byte NewItems /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet TargetSet
                throw new NotImplementedException(); //TODO: array TArray NewItems
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_AddItems_ptr, new IntPtr(p)); ;
                 //TODO: set TSet TargetSet
                 //TODO: array TArray NewItems
            }
        }
        internal struct Set_Clear_method {
            static internal IntPtr Set_Clear_ptr;
            static Set_Clear_method() {
                Set_Clear_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Clear");
            }

            internal static unsafe void Invoke(byte TargetSet /*TODO: set TSet */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet TargetSet
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Clear_ptr, new IntPtr(p)); ;
                 //TODO: set TSet TargetSet
            }
        }
        internal struct Set_Contains_method {
            static internal IntPtr Set_Contains_ptr;
            static Set_Contains_method() {
                Set_Contains_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Contains");
            }

            internal static unsafe bool Invoke(byte TargetSet /*TODO: set TSet */, int ItemToFind) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet TargetSet
                *((int*)(b+80)) = ItemToFind;
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Contains_ptr, new IntPtr(p)); ;
                 //TODO: set TSet TargetSet
                return *((bool*)(b+84));
            }
        }
        internal struct Set_Difference_method {
            static internal IntPtr Set_Difference_ptr;
            static Set_Difference_method() {
                Set_Difference_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Difference");
            }

            internal static unsafe byte /*TODO: set TSet*/ Invoke(byte A /*TODO: set TSet */, byte B /*TODO: set TSet */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet A
                throw new NotImplementedException(); //TODO: set TSet B
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Difference_ptr, new IntPtr(p)); ;
                 //TODO: set TSet A
                 //TODO: set TSet B
                 //TODO: set TSet Result
                return UObject.NotImplemented<byte>() /*TODO: set TSet*/;
            }
        }
        internal struct Set_Intersection_method {
            static internal IntPtr Set_Intersection_ptr;
            static Set_Intersection_method() {
                Set_Intersection_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Intersection");
            }

            internal static unsafe byte /*TODO: set TSet*/ Invoke(byte A /*TODO: set TSet */, byte B /*TODO: set TSet */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet A
                throw new NotImplementedException(); //TODO: set TSet B
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Intersection_ptr, new IntPtr(p)); ;
                 //TODO: set TSet A
                 //TODO: set TSet B
                 //TODO: set TSet Result
                return UObject.NotImplemented<byte>() /*TODO: set TSet*/;
            }
        }
        internal struct Set_Length_method {
            static internal IntPtr Set_Length_ptr;
            static Set_Length_method() {
                Set_Length_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Length");
            }

            internal static unsafe int Invoke(byte TargetSet /*TODO: set TSet */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet TargetSet
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Length_ptr, new IntPtr(p)); ;
                 //TODO: set TSet TargetSet
                return *((int*)(b+80));
            }
        }
        internal struct Set_Remove_method {
            static internal IntPtr Set_Remove_ptr;
            static Set_Remove_method() {
                Set_Remove_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Remove");
            }

            internal static unsafe bool Invoke(byte TargetSet /*TODO: set TSet */, int Item) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet TargetSet
                *((int*)(b+80)) = Item;
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Remove_ptr, new IntPtr(p)); ;
                 //TODO: set TSet TargetSet
                return *((bool*)(b+84));
            }
        }
        internal struct Set_RemoveItems_method {
            static internal IntPtr Set_RemoveItems_ptr;
            static Set_RemoveItems_method() {
                Set_RemoveItems_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_RemoveItems");
            }

            internal static unsafe void Invoke(byte TargetSet /*TODO: set TSet */, byte Items /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet TargetSet
                throw new NotImplementedException(); //TODO: array TArray Items
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_RemoveItems_ptr, new IntPtr(p)); ;
                 //TODO: set TSet TargetSet
                 //TODO: array TArray Items
            }
        }
        internal struct Set_ToArray_method {
            static internal IntPtr Set_ToArray_ptr;
            static Set_ToArray_method() {
                Set_ToArray_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_ToArray");
            }

            internal static unsafe IReadOnlyCollection<int> Invoke(byte A /*TODO: set TSet */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet A
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_ToArray_ptr, new IntPtr(p)); ;
                 //TODO: set TSet A
                 //TODO: array TArray Result
                return UObject.ToUnmangedCollection<int>(b+80);
            }
        }
        internal struct Set_Union_method {
            static internal IntPtr Set_Union_ptr;
            static Set_Union_method() {
                Set_Union_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "Set_Union");
            }

            internal static unsafe byte /*TODO: set TSet*/ Invoke(byte A /*TODO: set TSet */, byte B /*TODO: set TSet */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: set TSet A
                throw new NotImplementedException(); //TODO: set TSet B
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, Set_Union_ptr, new IntPtr(p)); ;
                 //TODO: set TSet A
                 //TODO: set TSet B
                 //TODO: set TSet Result
                return UObject.NotImplemented<byte>() /*TODO: set TSet*/;
            }
        }
        internal struct SetSetPropertyByName_method {
            static internal IntPtr SetSetPropertyByName_ptr;
            static SetSetPropertyByName_method() {
                SetSetPropertyByName_ptr = Main.GetMethodUFunction(BlueprintSetLibrary.StaticClass, "SetSetPropertyByName");
            }

            internal static unsafe void Invoke(UObject UObject, Name PropertyName, byte Value /*TODO: set TSet */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UObject;
                *((Name*)(b+8)) = PropertyName;
                throw new NotImplementedException(); //TODO: set TSet Value
                Main.GetProcessEvent(BlueprintSetLibrary.DefaultObject, SetSetPropertyByName_ptr, new IntPtr(p)); ;
                 //TODO: set TSet Value
            }
        }
    }
    internal unsafe struct BlueprintSetLibrary_events {
    }
}
