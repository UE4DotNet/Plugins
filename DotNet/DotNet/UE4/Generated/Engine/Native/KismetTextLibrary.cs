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
    internal unsafe struct KismetTextLibrary_fields {
    }
    internal unsafe struct KismetTextLibrary_methods {
        internal struct AsCurrency_Float_method {
            static internal IntPtr AsCurrency_Float_ptr;
            static AsCurrency_Float_method() {
                AsCurrency_Float_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsCurrency_Float");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(float Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits, string CurrencyCode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *(b+4) = RoundingMode;
                *((bool*)(b+5)) = bAlwaysSign;
                *((bool*)(b+6)) = bUseGrouping;
                *((int*)(b+8)) = MinimumIntegralDigits;
                *((int*)(b+12)) = MaximumIntegralDigits;
                *((int*)(b+16)) = MinimumFractionalDigits;
                *((int*)(b+20)) = MaximumFractionalDigits;
                var CurrencyCode_handle = GCHandle.Alloc(CurrencyCode, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = CurrencyCode_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = CurrencyCode.Length;
                *(int*)(b+IntPtr.Size+4+24) = CurrencyCode.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsCurrency_Float_ptr, new IntPtr(p)); ;
                CurrencyCode_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsCurrency_Integer_method {
            static internal IntPtr AsCurrency_Integer_ptr;
            static AsCurrency_Integer_method() {
                AsCurrency_Integer_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsCurrency_Integer");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(int Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits, string CurrencyCode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                *(b+4) = RoundingMode;
                *((bool*)(b+5)) = bAlwaysSign;
                *((bool*)(b+6)) = bUseGrouping;
                *((int*)(b+8)) = MinimumIntegralDigits;
                *((int*)(b+12)) = MaximumIntegralDigits;
                *((int*)(b+16)) = MinimumFractionalDigits;
                *((int*)(b+20)) = MaximumFractionalDigits;
                var CurrencyCode_handle = GCHandle.Alloc(CurrencyCode, GCHandleType.Pinned);
                *(IntPtr*)(b+24) = CurrencyCode_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+24) = CurrencyCode.Length;
                *(int*)(b+IntPtr.Size+4+24) = CurrencyCode.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsCurrency_Integer_ptr, new IntPtr(p)); ;
                CurrencyCode_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsCurrencyBase_method {
            static internal IntPtr AsCurrencyBase_ptr;
            static AsCurrencyBase_method() {
                AsCurrencyBase_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsCurrencyBase");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(int BaseValue, string CurrencyCode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = BaseValue;
                var CurrencyCode_handle = GCHandle.Alloc(CurrencyCode, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = CurrencyCode_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = CurrencyCode.Length;
                *(int*)(b+IntPtr.Size+4+8) = CurrencyCode.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsCurrencyBase_ptr, new IntPtr(p)); ;
                CurrencyCode_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsDate_DateTime_method {
            static internal IntPtr AsDate_DateTime_ptr;
            static AsDate_DateTime_method() {
                AsDate_DateTime_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsDate_DateTime");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(FDateTime InDateTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = InDateTime;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsDate_DateTime_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsDateTime_DateTime_method {
            static internal IntPtr AsDateTime_DateTime_ptr;
            static AsDateTime_DateTime_method() {
                AsDateTime_DateTime_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsDateTime_DateTime");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(FDateTime In) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = In;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsDateTime_DateTime_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsPercent_Float_method {
            static internal IntPtr AsPercent_Float_ptr;
            static AsPercent_Float_method() {
                AsPercent_Float_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsPercent_Float");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(float Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *(b+4) = RoundingMode;
                *((bool*)(b+5)) = bAlwaysSign;
                *((bool*)(b+6)) = bUseGrouping;
                *((int*)(b+8)) = MinimumIntegralDigits;
                *((int*)(b+12)) = MaximumIntegralDigits;
                *((int*)(b+16)) = MinimumFractionalDigits;
                *((int*)(b+20)) = MaximumFractionalDigits;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsPercent_Float_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsTime_DateTime_method {
            static internal IntPtr AsTime_DateTime_ptr;
            static AsTime_DateTime_method() {
                AsTime_DateTime_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsTime_DateTime");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(FDateTime In) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = In;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsTime_DateTime_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsTimespan_Timespan_method {
            static internal IntPtr AsTimespan_Timespan_ptr;
            static AsTimespan_Timespan_method() {
                AsTimespan_Timespan_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsTimespan_Timespan");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Timespan InTimespan) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = InTimespan;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsTimespan_Timespan_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsTimeZoneDate_DateTime_method {
            static internal IntPtr AsTimeZoneDate_DateTime_ptr;
            static AsTimeZoneDate_DateTime_method() {
                AsTimeZoneDate_DateTime_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsTimeZoneDate_DateTime");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(FDateTime InDateTime, string InTimeZone) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = InDateTime;
                var InTimeZone_handle = GCHandle.Alloc(InTimeZone, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = InTimeZone_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = InTimeZone.Length;
                *(int*)(b+IntPtr.Size+4+8) = InTimeZone.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsTimeZoneDate_DateTime_ptr, new IntPtr(p)); ;
                InTimeZone_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsTimeZoneDateTime_DateTime_method {
            static internal IntPtr AsTimeZoneDateTime_DateTime_ptr;
            static AsTimeZoneDateTime_DateTime_method() {
                AsTimeZoneDateTime_DateTime_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsTimeZoneDateTime_DateTime");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(FDateTime InDateTime, string InTimeZone) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = InDateTime;
                var InTimeZone_handle = GCHandle.Alloc(InTimeZone, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = InTimeZone_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = InTimeZone.Length;
                *(int*)(b+IntPtr.Size+4+8) = InTimeZone.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsTimeZoneDateTime_DateTime_ptr, new IntPtr(p)); ;
                InTimeZone_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct AsTimeZoneTime_DateTime_method {
            static internal IntPtr AsTimeZoneTime_DateTime_ptr;
            static AsTimeZoneTime_DateTime_method() {
                AsTimeZoneTime_DateTime_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "AsTimeZoneTime_DateTime");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(FDateTime InDateTime, string InTimeZone) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = InDateTime;
                var InTimeZone_handle = GCHandle.Alloc(InTimeZone, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = InTimeZone_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = InTimeZone.Length;
                *(int*)(b+IntPtr.Size+4+8) = InTimeZone.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, AsTimeZoneTime_DateTime_ptr, new IntPtr(p)); ;
                InTimeZone_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_BoolToText_method {
            static internal IntPtr Conv_BoolToText_ptr;
            static Conv_BoolToText_method() {
                Conv_BoolToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_BoolToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(bool InBool) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InBool;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_BoolToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_ByteToText_method {
            static internal IntPtr Conv_ByteToText_ptr;
            static Conv_ByteToText_method() {
                Conv_ByteToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_ByteToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Value;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_ByteToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_ColorToText_method {
            static internal IntPtr Conv_ColorToText_ptr;
            static Conv_ColorToText_method() {
                Conv_ColorToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_ColorToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(LinearColor InColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColor;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_ColorToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_FloatToText_method {
            static internal IntPtr Conv_FloatToText_ptr;
            static Conv_FloatToText_method() {
                Conv_FloatToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_FloatToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(float Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *(b+4) = RoundingMode;
                *((bool*)(b+5)) = bAlwaysSign;
                *((bool*)(b+6)) = bUseGrouping;
                *((int*)(b+8)) = MinimumIntegralDigits;
                *((int*)(b+12)) = MaximumIntegralDigits;
                *((int*)(b+16)) = MinimumFractionalDigits;
                *((int*)(b+20)) = MaximumFractionalDigits;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_FloatToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_IntToText_method {
            static internal IntPtr Conv_IntToText_ptr;
            static Conv_IntToText_method() {
                Conv_IntToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_IntToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(int Value, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                *((bool*)(b+4)) = bAlwaysSign;
                *((bool*)(b+5)) = bUseGrouping;
                *((int*)(b+8)) = MinimumIntegralDigits;
                *((int*)(b+12)) = MaximumIntegralDigits;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_IntToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_NameToText_method {
            static internal IntPtr Conv_NameToText_ptr;
            static Conv_NameToText_method() {
                Conv_NameToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_NameToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Name InName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_NameToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_ObjectToText_method {
            static internal IntPtr Conv_ObjectToText_ptr;
            static Conv_ObjectToText_method() {
                Conv_ObjectToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_ObjectToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(UObject InObj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InObj;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_ObjectToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_RotatorToText_method {
            static internal IntPtr Conv_RotatorToText_ptr;
            static Conv_RotatorToText_method() {
                Conv_RotatorToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_RotatorToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_RotatorToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_StringToText_method {
            static internal IntPtr Conv_StringToText_ptr;
            static Conv_StringToText_method() {
                Conv_StringToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_StringToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(string InString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var InString_handle = GCHandle.Alloc(InString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = InString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = InString.Length;
                *(int*)(b+IntPtr.Size+4+0) = InString.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_StringToText_ptr, new IntPtr(p)); ;
                InString_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_TextToString_method {
            static internal IntPtr Conv_TextToString_ptr;
            static Conv_TextToString_method() {
                Conv_TextToString_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_TextToString");
            }

            internal static unsafe string Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_TextToString_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                return FString.Get(b+24);
            }
        }
        internal struct Conv_TransformToText_method {
            static internal IntPtr Conv_TransformToText_ptr;
            static Conv_TransformToText_method() {
                Conv_TransformToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_TransformToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Transform InTrans) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = InTrans;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_TransformToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_Vector2dToText_method {
            static internal IntPtr Conv_Vector2dToText_ptr;
            static Conv_Vector2dToText_method() {
                Conv_Vector2dToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_Vector2dToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Vector2D InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_Vector2dToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct Conv_VectorToText_method {
            static internal IntPtr Conv_VectorToText_ptr;
            static Conv_VectorToText_method() {
                Conv_VectorToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Conv_VectorToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Vector InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Conv_VectorToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct EqualEqual_IgnoreCase_TextText_method {
            static internal IntPtr EqualEqual_IgnoreCase_TextText_ptr;
            static EqualEqual_IgnoreCase_TextText_method() {
                EqualEqual_IgnoreCase_TextText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "EqualEqual_IgnoreCase_TextText");
            }

            internal static unsafe bool Invoke(byte A /*TODO: text FText */, byte B /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText A
                throw new NotImplementedException(); //TODO: text FText B
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, EqualEqual_IgnoreCase_TextText_ptr, new IntPtr(p)); ;
                 //TODO: text FText A
                 //TODO: text FText B
                return *((bool*)(b+48));
            }
        }
        internal struct EqualEqual_TextText_method {
            static internal IntPtr EqualEqual_TextText_ptr;
            static EqualEqual_TextText_method() {
                EqualEqual_TextText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "EqualEqual_TextText");
            }

            internal static unsafe bool Invoke(byte A /*TODO: text FText */, byte B /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText A
                throw new NotImplementedException(); //TODO: text FText B
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, EqualEqual_TextText_ptr, new IntPtr(p)); ;
                 //TODO: text FText A
                 //TODO: text FText B
                return *((bool*)(b+48));
            }
        }
        internal struct FindTextInLocalizationTable_method {
            static internal IntPtr FindTextInLocalizationTable_ptr;
            static FindTextInLocalizationTable_method() {
                FindTextInLocalizationTable_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "FindTextInLocalizationTable");
            }

            internal static unsafe (byte /*TODO: text FText*/, bool) Invoke(string Namespace, string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Namespace_handle = GCHandle.Alloc(Namespace, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Namespace_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Namespace.Length;
                *(int*)(b+IntPtr.Size+4+0) = Namespace.Length;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, FindTextInLocalizationTable_ptr, new IntPtr(p)); ;
                Namespace_handle.Free();
                Key_handle.Free();
                 //TODO: text FText OutText
                return (UObject.NotImplemented<byte>() /*TODO: text FText*/,*((bool*)(b+56)));
            }
        }
        internal struct Format_method {
            static internal IntPtr Format_ptr;
            static Format_method() {
                Format_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "Format");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte InPattern /*TODO: text FText */, byte InArgs /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InPattern
                throw new NotImplementedException(); //TODO: array TArray InArgs
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, Format_ptr, new IntPtr(p)); ;
                 //TODO: text FText InPattern
                 //TODO: array TArray InArgs
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct GetEmptyText_method {
            static internal IntPtr GetEmptyText_ptr;
            static GetEmptyText_method() {
                GetEmptyText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "GetEmptyText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, GetEmptyText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct IsPolyglotDataValid_method {
            static internal IntPtr IsPolyglotDataValid_ptr;
            static IsPolyglotDataValid_method() {
                IsPolyglotDataValid_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "IsPolyglotDataValid");
            }

            internal static unsafe (bool, byte /*TODO: text FText*/) Invoke(PolyglotTextData PolyglotData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolyglotTextData*)(b+0)) = PolyglotData;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, IsPolyglotDataValid_ptr, new IntPtr(p)); ;
                 //TODO: text FText ErrorMessage
                return (*((bool*)(b+176)),UObject.NotImplemented<byte>() /*TODO: text FText*/);
            }
        }
        internal struct NotEqual_IgnoreCase_TextText_method {
            static internal IntPtr NotEqual_IgnoreCase_TextText_ptr;
            static NotEqual_IgnoreCase_TextText_method() {
                NotEqual_IgnoreCase_TextText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "NotEqual_IgnoreCase_TextText");
            }

            internal static unsafe bool Invoke(byte A /*TODO: text FText */, byte B /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText A
                throw new NotImplementedException(); //TODO: text FText B
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, NotEqual_IgnoreCase_TextText_ptr, new IntPtr(p)); ;
                 //TODO: text FText A
                 //TODO: text FText B
                return *((bool*)(b+48));
            }
        }
        internal struct NotEqual_TextText_method {
            static internal IntPtr NotEqual_TextText_ptr;
            static NotEqual_TextText_method() {
                NotEqual_TextText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "NotEqual_TextText");
            }

            internal static unsafe bool Invoke(byte A /*TODO: text FText */, byte B /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText A
                throw new NotImplementedException(); //TODO: text FText B
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, NotEqual_TextText_ptr, new IntPtr(p)); ;
                 //TODO: text FText A
                 //TODO: text FText B
                return *((bool*)(b+48));
            }
        }
        internal struct PolyglotDataToText_method {
            static internal IntPtr PolyglotDataToText_ptr;
            static PolyglotDataToText_method() {
                PolyglotDataToText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "PolyglotDataToText");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(PolyglotTextData PolyglotData) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((PolyglotTextData*)(b+0)) = PolyglotData;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, PolyglotDataToText_ptr, new IntPtr(p)); ;
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct StringTableIdAndKeyFromText_method {
            static internal IntPtr StringTableIdAndKeyFromText_ptr;
            static StringTableIdAndKeyFromText_method() {
                StringTableIdAndKeyFromText_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "StringTableIdAndKeyFromText");
            }

            internal static unsafe (Name, string, bool) Invoke(byte Text /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText Text
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, StringTableIdAndKeyFromText_ptr, new IntPtr(p)); ;
                 //TODO: text FText Text
                return (*((Name*)(b+24)),FString.Get(b+40),*((bool*)(b+56)));
            }
        }
        internal struct TextFromStringTable_method {
            static internal IntPtr TextFromStringTable_ptr;
            static TextFromStringTable_method() {
                TextFromStringTable_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextFromStringTable");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(Name TableId, string Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TableId;
                var Key_handle = GCHandle.Alloc(Key, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = Key_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = Key.Length;
                *(int*)(b+IntPtr.Size+4+16) = Key.Length;
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextFromStringTable_ptr, new IntPtr(p)); ;
                Key_handle.Free();
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct TextIsCultureInvariant_method {
            static internal IntPtr TextIsCultureInvariant_ptr;
            static TextIsCultureInvariant_method() {
                TextIsCultureInvariant_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextIsCultureInvariant");
            }

            internal static unsafe bool Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextIsCultureInvariant_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                return *((bool*)(b+24));
            }
        }
        internal struct TextIsEmpty_method {
            static internal IntPtr TextIsEmpty_ptr;
            static TextIsEmpty_method() {
                TextIsEmpty_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextIsEmpty");
            }

            internal static unsafe bool Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextIsEmpty_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                return *((bool*)(b+24));
            }
        }
        internal struct TextIsFromStringTable_method {
            static internal IntPtr TextIsFromStringTable_ptr;
            static TextIsFromStringTable_method() {
                TextIsFromStringTable_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextIsFromStringTable");
            }

            internal static unsafe bool Invoke(byte Text /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText Text
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextIsFromStringTable_ptr, new IntPtr(p)); ;
                 //TODO: text FText Text
                return *((bool*)(b+24));
            }
        }
        internal struct TextIsTransient_method {
            static internal IntPtr TextIsTransient_ptr;
            static TextIsTransient_method() {
                TextIsTransient_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextIsTransient");
            }

            internal static unsafe bool Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextIsTransient_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                return *((bool*)(b+24));
            }
        }
        internal struct TextToLower_method {
            static internal IntPtr TextToLower_ptr;
            static TextToLower_method() {
                TextToLower_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextToLower");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextToLower_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct TextToUpper_method {
            static internal IntPtr TextToUpper_ptr;
            static TextToUpper_method() {
                TextToUpper_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextToUpper");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextToUpper_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct TextTrimPreceding_method {
            static internal IntPtr TextTrimPreceding_ptr;
            static TextTrimPreceding_method() {
                TextTrimPreceding_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextTrimPreceding");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextTrimPreceding_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct TextTrimPrecedingAndTrailing_method {
            static internal IntPtr TextTrimPrecedingAndTrailing_ptr;
            static TextTrimPrecedingAndTrailing_method() {
                TextTrimPrecedingAndTrailing_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextTrimPrecedingAndTrailing");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextTrimPrecedingAndTrailing_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
        internal struct TextTrimTrailing_method {
            static internal IntPtr TextTrimTrailing_ptr;
            static TextTrimTrailing_method() {
                TextTrimTrailing_ptr = Main.GetMethodUFunction(KismetTextLibrary.StaticClass, "TextTrimTrailing");
            }

            internal static unsafe byte /*TODO: text FText*/ Invoke(byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(KismetTextLibrary.DefaultObject, TextTrimTrailing_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
                 //TODO: text FText ReturnValue
                return UObject.NotImplemented<byte>() /*TODO: text FText*/;
            }
        }
    }
    internal unsafe struct KismetTextLibrary_events {
    }
}
