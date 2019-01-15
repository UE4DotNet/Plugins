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
    internal unsafe struct KismetNodeHelperLibrary_fields {
    }
    internal unsafe struct KismetNodeHelperLibrary_methods {
        internal struct BitIsMarked_method {
            static internal IntPtr BitIsMarked_ptr;
            static BitIsMarked_method() {
                BitIsMarked_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "BitIsMarked");
            }

            internal static unsafe bool Invoke(int Data, int Index) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Data;
                *((int*)(b+4)) = Index;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, BitIsMarked_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct ClearAllBits_method {
            static internal IntPtr ClearAllBits_ptr;
            static ClearAllBits_method() {
                ClearAllBits_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "ClearAllBits");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, ClearAllBits_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct ClearBit_method {
            static internal IntPtr ClearBit_ptr;
            static ClearBit_method() {
                ClearBit_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "ClearBit");
            }

            internal static unsafe int Invoke(int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+4)) = Index;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, ClearBit_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetEnumeratorName_method {
            static internal IntPtr GetEnumeratorName_ptr;
            static GetEnumeratorName_method() {
                GetEnumeratorName_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "GetEnumeratorName");
            }

            internal static unsafe Name Invoke(UEnum UEnum, byte EnumeratorValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UEnum;
                *(b+8) = EnumeratorValue;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, GetEnumeratorName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+12));
            }
        }
        internal struct GetEnumeratorUserFriendlyName_method {
            static internal IntPtr GetEnumeratorUserFriendlyName_ptr;
            static GetEnumeratorUserFriendlyName_method() {
                GetEnumeratorUserFriendlyName_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "GetEnumeratorUserFriendlyName");
            }

            internal static unsafe string Invoke(UEnum UEnum, byte EnumeratorValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UEnum;
                *(b+8) = EnumeratorValue;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, GetEnumeratorUserFriendlyName_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct GetEnumeratorValueFromIndex_method {
            static internal IntPtr GetEnumeratorValueFromIndex_ptr;
            static GetEnumeratorValueFromIndex_method() {
                GetEnumeratorValueFromIndex_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "GetEnumeratorValueFromIndex");
            }

            internal static unsafe byte Invoke(UEnum UEnum, byte EnumeratorIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UEnum;
                *(b+8) = EnumeratorIndex;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, GetEnumeratorValueFromIndex_ptr, new IntPtr(p)); ;
                return *(b+9);
            }
        }
        internal struct GetFirstUnmarkedBit_method {
            static internal IntPtr GetFirstUnmarkedBit_ptr;
            static GetFirstUnmarkedBit_method() {
                GetFirstUnmarkedBit_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "GetFirstUnmarkedBit");
            }

            internal static unsafe int Invoke(int Data, int StartIdx, int NumBits) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Data;
                *((int*)(b+4)) = StartIdx;
                *((int*)(b+8)) = NumBits;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, GetFirstUnmarkedBit_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct GetRandomUnmarkedBit_method {
            static internal IntPtr GetRandomUnmarkedBit_ptr;
            static GetRandomUnmarkedBit_method() {
                GetRandomUnmarkedBit_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "GetRandomUnmarkedBit");
            }

            internal static unsafe int Invoke(int Data, int StartIdx, int NumBits) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Data;
                *((int*)(b+4)) = StartIdx;
                *((int*)(b+8)) = NumBits;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, GetRandomUnmarkedBit_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct GetUnmarkedBit_method {
            static internal IntPtr GetUnmarkedBit_ptr;
            static GetUnmarkedBit_method() {
                GetUnmarkedBit_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "GetUnmarkedBit");
            }

            internal static unsafe int Invoke(int Data, int StartIdx, int NumBits, bool bRandom) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Data;
                *((int*)(b+4)) = StartIdx;
                *((int*)(b+8)) = NumBits;
                *((bool*)(b+12)) = bRandom;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, GetUnmarkedBit_ptr, new IntPtr(p)); ;
                return *((int*)(b+16));
            }
        }
        internal struct GetValidValue_method {
            static internal IntPtr GetValidValue_ptr;
            static GetValidValue_method() {
                GetValidValue_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "GetValidValue");
            }

            internal static unsafe byte Invoke(UEnum UEnum, byte EnumeratorValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = UEnum;
                *(b+8) = EnumeratorValue;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, GetValidValue_ptr, new IntPtr(p)); ;
                return *(b+9);
            }
        }
        internal struct HasMarkedBit_method {
            static internal IntPtr HasMarkedBit_ptr;
            static HasMarkedBit_method() {
                HasMarkedBit_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "HasMarkedBit");
            }

            internal static unsafe bool Invoke(int Data, int NumBits) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Data;
                *((int*)(b+4)) = NumBits;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, HasMarkedBit_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct HasUnmarkedBit_method {
            static internal IntPtr HasUnmarkedBit_ptr;
            static HasUnmarkedBit_method() {
                HasUnmarkedBit_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "HasUnmarkedBit");
            }

            internal static unsafe bool Invoke(int Data, int NumBits) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Data;
                *((int*)(b+4)) = NumBits;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, HasUnmarkedBit_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct MarkBit_method {
            static internal IntPtr MarkBit_ptr;
            static MarkBit_method() {
                MarkBit_ptr = Main.GetMethodUFunction(KismetNodeHelperLibrary.StaticClass, "MarkBit");
            }

            internal static unsafe int Invoke(int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+4)) = Index;
                Main.GetProcessEvent(KismetNodeHelperLibrary.DefaultObject, MarkBit_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
    }
    internal unsafe struct KismetNodeHelperLibrary_events {
    }
}
