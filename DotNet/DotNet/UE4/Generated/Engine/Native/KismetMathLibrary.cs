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
    internal unsafe struct KismetMathLibrary_fields {
    }
    internal unsafe struct KismetMathLibrary_methods {
        internal struct Abs_method {
            static internal IntPtr Abs_ptr;
            static Abs_method() {
                Abs_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Abs");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Abs_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Abs_Int_method {
            static internal IntPtr Abs_Int_ptr;
            static Abs_Int_method() {
                Abs_Int_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Abs_Int");
            }

            internal static unsafe int Invoke(int A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Abs_Int_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct Acos_method {
            static internal IntPtr Acos_ptr;
            static Acos_method() {
                Acos_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Acos");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Acos_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Add_ByteByte_method {
            static internal IntPtr Add_ByteByte_ptr;
            static Add_ByteByte_method() {
                Add_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_ByteByte");
            }

            internal static unsafe byte Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_ByteByte_ptr, new IntPtr(p)); ;
                return *(b+2);
            }
        }
        internal struct Add_DateTimeTimespan_method {
            static internal IntPtr Add_DateTimeTimespan_ptr;
            static Add_DateTimeTimespan_method() {
                Add_DateTimeTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_DateTimeTimespan");
            }

            internal static unsafe FDateTime Invoke(FDateTime A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_DateTimeTimespan_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+16));
            }
        }
        internal struct Add_FloatFloat_method {
            static internal IntPtr Add_FloatFloat_ptr;
            static Add_FloatFloat_method() {
                Add_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_FloatFloat");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_FloatFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Add_IntInt_method {
            static internal IntPtr Add_IntInt_ptr;
            static Add_IntInt_method() {
                Add_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct Add_TimespanTimespan_method {
            static internal IntPtr Add_TimespanTimespan_ptr;
            static Add_TimespanTimespan_method() {
                Add_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_TimespanTimespan");
            }

            internal static unsafe Timespan Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+16));
            }
        }
        internal struct Add_Vector2DFloat_method {
            static internal IntPtr Add_Vector2DFloat_ptr;
            static Add_Vector2DFloat_method() {
                Add_Vector2DFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_Vector2DFloat");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((float*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_Vector2DFloat_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+12));
            }
        }
        internal struct Add_Vector2DVector2D_method {
            static internal IntPtr Add_Vector2DVector2D_ptr;
            static Add_Vector2DVector2D_method() {
                Add_Vector2DVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_Vector2DVector2D");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, Vector2D B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_Vector2DVector2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+16));
            }
        }
        internal struct Add_VectorFloat_method {
            static internal IntPtr Add_VectorFloat_ptr;
            static Add_VectorFloat_method() {
                Add_VectorFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_VectorFloat");
            }

            internal static unsafe Vector Invoke(Vector A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((float*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_VectorFloat_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Add_VectorInt_method {
            static internal IntPtr Add_VectorInt_ptr;
            static Add_VectorInt_method() {
                Add_VectorInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_VectorInt");
            }

            internal static unsafe Vector Invoke(Vector A, int B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((int*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_VectorInt_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Add_VectorVector_method {
            static internal IntPtr Add_VectorVector_ptr;
            static Add_VectorVector_method() {
                Add_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Add_VectorVector");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Add_VectorVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct And_IntInt_method {
            static internal IntPtr And_IntInt_ptr;
            static And_IntInt_method() {
                And_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "And_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, And_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct Asin_method {
            static internal IntPtr Asin_ptr;
            static Asin_method() {
                Asin_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Asin");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Asin_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Atan_method {
            static internal IntPtr Atan_ptr;
            static Atan_method() {
                Atan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Atan");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Atan_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Atan2_method {
            static internal IntPtr Atan2_ptr;
            static Atan2_method() {
                Atan2_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Atan2");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Atan2_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct BMax_method {
            static internal IntPtr BMax_ptr;
            static BMax_method() {
                BMax_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BMax");
            }

            internal static unsafe byte Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BMax_ptr, new IntPtr(p)); ;
                return *(b+2);
            }
        }
        internal struct BMin_method {
            static internal IntPtr BMin_ptr;
            static BMin_method() {
                BMin_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BMin");
            }

            internal static unsafe byte Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BMin_ptr, new IntPtr(p)); ;
                return *(b+2);
            }
        }
        internal struct BooleanAND_method {
            static internal IntPtr BooleanAND_ptr;
            static BooleanAND_method() {
                BooleanAND_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BooleanAND");
            }

            internal static unsafe bool Invoke(bool A, bool B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                *((bool*)(b+1)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BooleanAND_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct BooleanNAND_method {
            static internal IntPtr BooleanNAND_ptr;
            static BooleanNAND_method() {
                BooleanNAND_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BooleanNAND");
            }

            internal static unsafe bool Invoke(bool A, bool B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                *((bool*)(b+1)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BooleanNAND_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct BooleanNOR_method {
            static internal IntPtr BooleanNOR_ptr;
            static BooleanNOR_method() {
                BooleanNOR_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BooleanNOR");
            }

            internal static unsafe bool Invoke(bool A, bool B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                *((bool*)(b+1)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BooleanNOR_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct BooleanOR_method {
            static internal IntPtr BooleanOR_ptr;
            static BooleanOR_method() {
                BooleanOR_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BooleanOR");
            }

            internal static unsafe bool Invoke(bool A, bool B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                *((bool*)(b+1)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BooleanOR_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct BooleanXOR_method {
            static internal IntPtr BooleanXOR_ptr;
            static BooleanXOR_method() {
                BooleanXOR_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BooleanXOR");
            }

            internal static unsafe bool Invoke(bool A, bool B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                *((bool*)(b+1)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BooleanXOR_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct BreakColor_method {
            static internal IntPtr BreakColor_ptr;
            static BreakColor_method() {
                BreakColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakColor");
            }

            internal static unsafe (float, float, float, float) Invoke(LinearColor InColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColor;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakColor_ptr, new IntPtr(p)); ;
                return (*((float*)(b+16)),*((float*)(b+20)),*((float*)(b+24)),*((float*)(b+28)));
            }
        }
        internal struct BreakDateTime_method {
            static internal IntPtr BreakDateTime_ptr;
            static BreakDateTime_method() {
                BreakDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakDateTime");
            }

            internal static unsafe (int, int, int, int, int, int, int) Invoke(FDateTime InDateTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = InDateTime;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakDateTime_ptr, new IntPtr(p)); ;
                return (*((int*)(b+8)),*((int*)(b+12)),*((int*)(b+16)),*((int*)(b+20)),*((int*)(b+24)),*((int*)(b+28)),*((int*)(b+32)));
            }
        }
        internal struct BreakFrameRate_method {
            static internal IntPtr BreakFrameRate_ptr;
            static BreakFrameRate_method() {
                BreakFrameRate_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakFrameRate");
            }

            internal static unsafe (int, int) Invoke(FrameRate InFrameRate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameRate*)(b+0)) = InFrameRate;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakFrameRate_ptr, new IntPtr(p)); ;
                return (*((int*)(b+8)),*((int*)(b+12)));
            }
        }
        internal struct BreakQualifiedFrameTime_method {
            static internal IntPtr BreakQualifiedFrameTime_ptr;
            static BreakQualifiedFrameTime_method() {
                BreakQualifiedFrameTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakQualifiedFrameTime");
            }

            internal static unsafe (FrameNumber, FrameRate, float) Invoke(QualifiedFrameTime InFrameTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((QualifiedFrameTime*)(b+0)) = InFrameTime;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakQualifiedFrameTime_ptr, new IntPtr(p)); ;
                return (*((FrameNumber*)(b+16)),*((FrameRate*)(b+20)),*((float*)(b+28)));
            }
        }
        internal struct BreakRandomStream_method {
            static internal IntPtr BreakRandomStream_ptr;
            static BreakRandomStream_method() {
                BreakRandomStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakRandomStream");
            }

            internal static unsafe int Invoke(RandomStream InRandomStream) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((RandomStream*)(b+0)) = InRandomStream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakRandomStream_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct BreakRotator_method {
            static internal IntPtr BreakRotator_ptr;
            static BreakRotator_method() {
                BreakRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakRotator");
            }

            internal static unsafe (float, float, float) Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakRotator_ptr, new IntPtr(p)); ;
                return (*((float*)(b+12)),*((float*)(b+16)),*((float*)(b+20)));
            }
        }
        internal struct BreakRotIntoAxes_method {
            static internal IntPtr BreakRotIntoAxes_ptr;
            static BreakRotIntoAxes_method() {
                BreakRotIntoAxes_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakRotIntoAxes");
            }

            internal static unsafe (Vector, Vector, Vector) Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakRotIntoAxes_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+12)),*((Vector*)(b+24)),*((Vector*)(b+36)));
            }
        }
        internal struct BreakTimespan_method {
            static internal IntPtr BreakTimespan_ptr;
            static BreakTimespan_method() {
                BreakTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakTimespan");
            }

            internal static unsafe (int, int, int, int, int) Invoke(Timespan InTimespan) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = InTimespan;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakTimespan_ptr, new IntPtr(p)); ;
                return (*((int*)(b+8)),*((int*)(b+12)),*((int*)(b+16)),*((int*)(b+20)),*((int*)(b+24)));
            }
        }
        internal struct BreakTimespan2_method {
            static internal IntPtr BreakTimespan2_ptr;
            static BreakTimespan2_method() {
                BreakTimespan2_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakTimespan2");
            }

            internal static unsafe (int, int, int, int, int) Invoke(Timespan InTimespan) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = InTimespan;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakTimespan2_ptr, new IntPtr(p)); ;
                return (*((int*)(b+8)),*((int*)(b+12)),*((int*)(b+16)),*((int*)(b+20)),*((int*)(b+24)));
            }
        }
        internal struct BreakTransform_method {
            static internal IntPtr BreakTransform_ptr;
            static BreakTransform_method() {
                BreakTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakTransform");
            }

            internal static unsafe (Vector, Rotator, Vector) Invoke(Transform InTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = InTransform;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakTransform_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+48)),*((Rotator*)(b+60)),*((Vector*)(b+72)));
            }
        }
        internal struct BreakVector_method {
            static internal IntPtr BreakVector_ptr;
            static BreakVector_method() {
                BreakVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakVector");
            }

            internal static unsafe (float, float, float) Invoke(Vector InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakVector_ptr, new IntPtr(p)); ;
                return (*((float*)(b+12)),*((float*)(b+16)),*((float*)(b+20)));
            }
        }
        internal struct BreakVector2D_method {
            static internal IntPtr BreakVector2D_ptr;
            static BreakVector2D_method() {
                BreakVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "BreakVector2D");
            }

            internal static unsafe (float, float) Invoke(Vector2D InVec) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, BreakVector2D_ptr, new IntPtr(p)); ;
                return (*((float*)(b+8)),*((float*)(b+12)));
            }
        }
        internal struct CInterpTo_method {
            static internal IntPtr CInterpTo_ptr;
            static CInterpTo_method() {
                CInterpTo_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "CInterpTo");
            }

            internal static unsafe LinearColor Invoke(LinearColor Current, LinearColor Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = Current;
                *((LinearColor*)(b+16)) = Target;
                *((float*)(b+32)) = DeltaTime;
                *((float*)(b+36)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, CInterpTo_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+40));
            }
        }
        internal struct Clamp_method {
            static internal IntPtr Clamp_ptr;
            static Clamp_method() {
                Clamp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Clamp");
            }

            internal static unsafe int Invoke(int Value, int Min, int Max) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                *((int*)(b+4)) = Min;
                *((int*)(b+8)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Clamp_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct ClampAngle_method {
            static internal IntPtr ClampAngle_ptr;
            static ClampAngle_method() {
                ClampAngle_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ClampAngle");
            }

            internal static unsafe float Invoke(float AngleDegrees, float MinAngleDegrees, float MaxAngleDegrees) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = AngleDegrees;
                *((float*)(b+4)) = MinAngleDegrees;
                *((float*)(b+8)) = MaxAngleDegrees;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ClampAngle_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct ClampAxis_method {
            static internal IntPtr ClampAxis_ptr;
            static ClampAxis_method() {
                ClampAxis_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ClampAxis");
            }

            internal static unsafe float Invoke(float Angle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Angle;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ClampAxis_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct ClampVectorSize_method {
            static internal IntPtr ClampVectorSize_ptr;
            static ClampVectorSize_method() {
                ClampVectorSize_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ClampVectorSize");
            }

            internal static unsafe Vector Invoke(Vector A, float Min, float Max) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((float*)(b+12)) = Min;
                *((float*)(b+16)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ClampVectorSize_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+20));
            }
        }
        internal struct ClassIsChildOf_method {
            static internal IntPtr ClassIsChildOf_ptr;
            static ClassIsChildOf_method() {
                ClassIsChildOf_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ClassIsChildOf");
            }

            internal static unsafe bool Invoke(SubclassOf<UObject> TestClass, SubclassOf<UObject> ParentClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = TestClass;
                *((IntPtr*)(b+8)) = ParentClass;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ClassIsChildOf_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct ComposeRotators_method {
            static internal IntPtr ComposeRotators_ptr;
            static ComposeRotators_method() {
                ComposeRotators_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ComposeRotators");
            }

            internal static unsafe Rotator Invoke(Rotator A, Rotator B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ComposeRotators_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct ComposeTransforms_method {
            static internal IntPtr ComposeTransforms_ptr;
            static ComposeTransforms_method() {
                ComposeTransforms_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ComposeTransforms");
            }

            internal static unsafe Transform Invoke(Transform A, Transform B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = A;
                *((Transform*)(b+48)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ComposeTransforms_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+96));
            }
        }
        internal struct Conv_BoolToByte_method {
            static internal IntPtr Conv_BoolToByte_ptr;
            static Conv_BoolToByte_method() {
                Conv_BoolToByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_BoolToByte");
            }

            internal static unsafe byte Invoke(bool InBool) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InBool;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_BoolToByte_ptr, new IntPtr(p)); ;
                return *(b+1);
            }
        }
        internal struct Conv_BoolToFloat_method {
            static internal IntPtr Conv_BoolToFloat_ptr;
            static Conv_BoolToFloat_method() {
                Conv_BoolToFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_BoolToFloat");
            }

            internal static unsafe float Invoke(bool InBool) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InBool;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_BoolToFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Conv_BoolToInt_method {
            static internal IntPtr Conv_BoolToInt_ptr;
            static Conv_BoolToInt_method() {
                Conv_BoolToInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_BoolToInt");
            }

            internal static unsafe int Invoke(bool InBool) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InBool;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_BoolToInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct Conv_ByteToFloat_method {
            static internal IntPtr Conv_ByteToFloat_ptr;
            static Conv_ByteToFloat_method() {
                Conv_ByteToFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_ByteToFloat");
            }

            internal static unsafe float Invoke(byte InByte) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InByte;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_ByteToFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Conv_ByteToInt_method {
            static internal IntPtr Conv_ByteToInt_ptr;
            static Conv_ByteToInt_method() {
                Conv_ByteToInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_ByteToInt");
            }

            internal static unsafe int Invoke(byte InByte) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InByte;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_ByteToInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct Conv_ColorToLinearColor_method {
            static internal IntPtr Conv_ColorToLinearColor_ptr;
            static Conv_ColorToLinearColor_method() {
                Conv_ColorToLinearColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_ColorToLinearColor");
            }

            internal static unsafe LinearColor Invoke(Color InColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Color*)(b+0)) = InColor;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_ColorToLinearColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+4));
            }
        }
        internal struct Conv_FloatToLinearColor_method {
            static internal IntPtr Conv_FloatToLinearColor_ptr;
            static Conv_FloatToLinearColor_method() {
                Conv_FloatToLinearColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_FloatToLinearColor");
            }

            internal static unsafe LinearColor Invoke(float InFloat) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InFloat;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_FloatToLinearColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+4));
            }
        }
        internal struct Conv_FloatToVector_method {
            static internal IntPtr Conv_FloatToVector_ptr;
            static Conv_FloatToVector_method() {
                Conv_FloatToVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_FloatToVector");
            }

            internal static unsafe Vector Invoke(float InFloat) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InFloat;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_FloatToVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct Conv_IntToBool_method {
            static internal IntPtr Conv_IntToBool_ptr;
            static Conv_IntToBool_method() {
                Conv_IntToBool_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_IntToBool");
            }

            internal static unsafe bool Invoke(int InInt) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InInt;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_IntToBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct Conv_IntToByte_method {
            static internal IntPtr Conv_IntToByte_ptr;
            static Conv_IntToByte_method() {
                Conv_IntToByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_IntToByte");
            }

            internal static unsafe byte Invoke(int InInt) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InInt;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_IntToByte_ptr, new IntPtr(p)); ;
                return *(b+4);
            }
        }
        internal struct Conv_IntToFloat_method {
            static internal IntPtr Conv_IntToFloat_ptr;
            static Conv_IntToFloat_method() {
                Conv_IntToFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_IntToFloat");
            }

            internal static unsafe float Invoke(int InInt) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InInt;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_IntToFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Conv_IntToIntVector_method {
            static internal IntPtr Conv_IntToIntVector_ptr;
            static Conv_IntToIntVector_method() {
                Conv_IntToIntVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_IntToIntVector");
            }

            internal static unsafe IntVector Invoke(int InInt) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InInt;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_IntToIntVector_ptr, new IntPtr(p)); ;
                return *((IntVector*)(b+4));
            }
        }
        internal struct Conv_IntVectorToVector_method {
            static internal IntPtr Conv_IntVectorToVector_ptr;
            static Conv_IntVectorToVector_method() {
                Conv_IntVectorToVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_IntVectorToVector");
            }

            internal static unsafe Vector Invoke(IntVector InIntVector) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntVector*)(b+0)) = InIntVector;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_IntVectorToVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct Conv_LinearColorToColor_method {
            static internal IntPtr Conv_LinearColorToColor_ptr;
            static Conv_LinearColorToColor_method() {
                Conv_LinearColorToColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_LinearColorToColor");
            }

            internal static unsafe Color Invoke(LinearColor InLinearColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InLinearColor;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_LinearColorToColor_ptr, new IntPtr(p)); ;
                return *((Color*)(b+16));
            }
        }
        internal struct Conv_LinearColorToVector_method {
            static internal IntPtr Conv_LinearColorToVector_ptr;
            static Conv_LinearColorToVector_method() {
                Conv_LinearColorToVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_LinearColorToVector");
            }

            internal static unsafe Vector Invoke(LinearColor InLinearColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InLinearColor;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_LinearColorToVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Conv_MatrixToRotator_method {
            static internal IntPtr Conv_MatrixToRotator_ptr;
            static Conv_MatrixToRotator_method() {
                Conv_MatrixToRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_MatrixToRotator");
            }

            internal static unsafe Rotator Invoke(Matrix InMatrix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Matrix*)(b+0)) = InMatrix;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_MatrixToRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+64));
            }
        }
        internal struct Conv_MatrixToTransform_method {
            static internal IntPtr Conv_MatrixToTransform_ptr;
            static Conv_MatrixToTransform_method() {
                Conv_MatrixToTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_MatrixToTransform");
            }

            internal static unsafe Transform Invoke(Matrix InMatrix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Matrix*)(b+0)) = InMatrix;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_MatrixToTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+64));
            }
        }
        internal struct Conv_RotatorToTransform_method {
            static internal IntPtr Conv_RotatorToTransform_ptr;
            static Conv_RotatorToTransform_method() {
                Conv_RotatorToTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_RotatorToTransform");
            }

            internal static unsafe Transform Invoke(Rotator InRotator) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRotator;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_RotatorToTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct Conv_RotatorToVector_method {
            static internal IntPtr Conv_RotatorToVector_ptr;
            static Conv_RotatorToVector_method() {
                Conv_RotatorToVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_RotatorToVector");
            }

            internal static unsafe Vector Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_RotatorToVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct Conv_Vector2DToVector_method {
            static internal IntPtr Conv_Vector2DToVector_ptr;
            static Conv_Vector2DToVector_method() {
                Conv_Vector2DToVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_Vector2DToVector");
            }

            internal static unsafe Vector Invoke(Vector2D InVector2D, float Z) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = InVector2D;
                *((float*)(b+8)) = Z;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_Vector2DToVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct Conv_VectorToLinearColor_method {
            static internal IntPtr Conv_VectorToLinearColor_ptr;
            static Conv_VectorToLinearColor_method() {
                Conv_VectorToLinearColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_VectorToLinearColor");
            }

            internal static unsafe LinearColor Invoke(Vector InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_VectorToLinearColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+12));
            }
        }
        internal struct Conv_VectorToRotator_method {
            static internal IntPtr Conv_VectorToRotator_ptr;
            static Conv_VectorToRotator_method() {
                Conv_VectorToRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_VectorToRotator");
            }

            internal static unsafe Rotator Invoke(Vector InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_VectorToRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct Conv_VectorToTransform_method {
            static internal IntPtr Conv_VectorToTransform_ptr;
            static Conv_VectorToTransform_method() {
                Conv_VectorToTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_VectorToTransform");
            }

            internal static unsafe Transform Invoke(Vector InLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InLocation;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_VectorToTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct Conv_VectorToVector2D_method {
            static internal IntPtr Conv_VectorToVector2D_ptr;
            static Conv_VectorToVector2D_method() {
                Conv_VectorToVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Conv_VectorToVector2D");
            }

            internal static unsafe Vector2D Invoke(Vector InVector) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVector;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Conv_VectorToVector2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+12));
            }
        }
        internal struct ConvertTransformToRelative_method {
            static internal IntPtr ConvertTransformToRelative_ptr;
            static ConvertTransformToRelative_method() {
                ConvertTransformToRelative_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ConvertTransformToRelative");
            }

            internal static unsafe Transform Invoke(Transform Transform, Transform ParentTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = Transform;
                *((Transform*)(b+48)) = ParentTransform;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ConvertTransformToRelative_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+96));
            }
        }
        internal struct Cos_method {
            static internal IntPtr Cos_ptr;
            static Cos_method() {
                Cos_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Cos");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Cos_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct CreateVectorFromYawPitch_method {
            static internal IntPtr CreateVectorFromYawPitch_ptr;
            static CreateVectorFromYawPitch_method() {
                CreateVectorFromYawPitch_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "CreateVectorFromYawPitch");
            }

            internal static unsafe Vector Invoke(float Yaw, float Pitch, float Length) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Yaw;
                *((float*)(b+4)) = Pitch;
                *((float*)(b+8)) = Length;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, CreateVectorFromYawPitch_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct Cross_VectorVector_method {
            static internal IntPtr Cross_VectorVector_ptr;
            static Cross_VectorVector_method() {
                Cross_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Cross_VectorVector");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Cross_VectorVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct CrossProduct2D_method {
            static internal IntPtr CrossProduct2D_ptr;
            static CrossProduct2D_method() {
                CrossProduct2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "CrossProduct2D");
            }

            internal static unsafe float Invoke(Vector2D A, Vector2D B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, CrossProduct2D_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct DateTimeFromIsoString_method {
            static internal IntPtr DateTimeFromIsoString_ptr;
            static DateTimeFromIsoString_method() {
                DateTimeFromIsoString_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DateTimeFromIsoString");
            }

            internal static unsafe (FDateTime, bool) Invoke(string IsoString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var IsoString_handle = GCHandle.Alloc(IsoString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = IsoString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = IsoString.Length;
                *(int*)(b+IntPtr.Size+4+0) = IsoString.Length;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DateTimeFromIsoString_ptr, new IntPtr(p)); ;
                IsoString_handle.Free();
                return (*((FDateTime*)(b+16)),*((bool*)(b+24)));
            }
        }
        internal struct DateTimeFromString_method {
            static internal IntPtr DateTimeFromString_ptr;
            static DateTimeFromString_method() {
                DateTimeFromString_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DateTimeFromString");
            }

            internal static unsafe (FDateTime, bool) Invoke(string DateTimeString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var DateTimeString_handle = GCHandle.Alloc(DateTimeString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = DateTimeString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = DateTimeString.Length;
                *(int*)(b+IntPtr.Size+4+0) = DateTimeString.Length;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DateTimeFromString_ptr, new IntPtr(p)); ;
                DateTimeString_handle.Free();
                return (*((FDateTime*)(b+16)),*((bool*)(b+24)));
            }
        }
        internal struct DateTimeMaxValue_method {
            static internal IntPtr DateTimeMaxValue_ptr;
            static DateTimeMaxValue_method() {
                DateTimeMaxValue_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DateTimeMaxValue");
            }

            internal static unsafe FDateTime Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DateTimeMaxValue_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+0));
            }
        }
        internal struct DateTimeMinValue_method {
            static internal IntPtr DateTimeMinValue_ptr;
            static DateTimeMinValue_method() {
                DateTimeMinValue_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DateTimeMinValue");
            }

            internal static unsafe FDateTime Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DateTimeMinValue_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+0));
            }
        }
        internal struct DaysInMonth_method {
            static internal IntPtr DaysInMonth_ptr;
            static DaysInMonth_method() {
                DaysInMonth_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DaysInMonth");
            }

            internal static unsafe int Invoke(int Year, int Month) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Year;
                *((int*)(b+4)) = Month;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DaysInMonth_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct DaysInYear_method {
            static internal IntPtr DaysInYear_ptr;
            static DaysInYear_method() {
                DaysInYear_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DaysInYear");
            }

            internal static unsafe int Invoke(int Year) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Year;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DaysInYear_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct DegAcos_method {
            static internal IntPtr DegAcos_ptr;
            static DegAcos_method() {
                DegAcos_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegAcos");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegAcos_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct DegAsin_method {
            static internal IntPtr DegAsin_ptr;
            static DegAsin_method() {
                DegAsin_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegAsin");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegAsin_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct DegAtan_method {
            static internal IntPtr DegAtan_ptr;
            static DegAtan_method() {
                DegAtan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegAtan");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegAtan_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct DegAtan2_method {
            static internal IntPtr DegAtan2_ptr;
            static DegAtan2_method() {
                DegAtan2_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegAtan2");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegAtan2_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct DegCos_method {
            static internal IntPtr DegCos_ptr;
            static DegCos_method() {
                DegCos_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegCos");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegCos_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct DegreesToRadians_method {
            static internal IntPtr DegreesToRadians_ptr;
            static DegreesToRadians_method() {
                DegreesToRadians_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegreesToRadians");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegreesToRadians_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct DegSin_method {
            static internal IntPtr DegSin_ptr;
            static DegSin_method() {
                DegSin_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegSin");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegSin_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct DegTan_method {
            static internal IntPtr DegTan_ptr;
            static DegTan_method() {
                DegTan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DegTan");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DegTan_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Divide_ByteByte_method {
            static internal IntPtr Divide_ByteByte_ptr;
            static Divide_ByteByte_method() {
                Divide_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_ByteByte");
            }

            internal static unsafe byte Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_ByteByte_ptr, new IntPtr(p)); ;
                return *(b+2);
            }
        }
        internal struct Divide_FloatFloat_method {
            static internal IntPtr Divide_FloatFloat_ptr;
            static Divide_FloatFloat_method() {
                Divide_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_FloatFloat");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_FloatFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Divide_IntInt_method {
            static internal IntPtr Divide_IntInt_ptr;
            static Divide_IntInt_method() {
                Divide_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct Divide_TimespanFloat_method {
            static internal IntPtr Divide_TimespanFloat_ptr;
            static Divide_TimespanFloat_method() {
                Divide_TimespanFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_TimespanFloat");
            }

            internal static unsafe Timespan Invoke(Timespan A, float Scalar) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((float*)(b+8)) = Scalar;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_TimespanFloat_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+16));
            }
        }
        internal struct Divide_Vector2DFloat_method {
            static internal IntPtr Divide_Vector2DFloat_ptr;
            static Divide_Vector2DFloat_method() {
                Divide_Vector2DFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_Vector2DFloat");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((float*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_Vector2DFloat_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+12));
            }
        }
        internal struct Divide_Vector2DVector2D_method {
            static internal IntPtr Divide_Vector2DVector2D_ptr;
            static Divide_Vector2DVector2D_method() {
                Divide_Vector2DVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_Vector2DVector2D");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, Vector2D B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_Vector2DVector2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+16));
            }
        }
        internal struct Divide_VectorFloat_method {
            static internal IntPtr Divide_VectorFloat_ptr;
            static Divide_VectorFloat_method() {
                Divide_VectorFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_VectorFloat");
            }

            internal static unsafe Vector Invoke(Vector A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((float*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_VectorFloat_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Divide_VectorInt_method {
            static internal IntPtr Divide_VectorInt_ptr;
            static Divide_VectorInt_method() {
                Divide_VectorInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_VectorInt");
            }

            internal static unsafe Vector Invoke(Vector A, int B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((int*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_VectorInt_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Divide_VectorVector_method {
            static internal IntPtr Divide_VectorVector_ptr;
            static Divide_VectorVector_method() {
                Divide_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Divide_VectorVector");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Divide_VectorVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct Dot_VectorVector_method {
            static internal IntPtr Dot_VectorVector_ptr;
            static Dot_VectorVector_method() {
                Dot_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Dot_VectorVector");
            }

            internal static unsafe float Invoke(Vector A, Vector B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Dot_VectorVector_ptr, new IntPtr(p)); ;
                return *((float*)(b+24));
            }
        }
        internal struct DotProduct2D_method {
            static internal IntPtr DotProduct2D_ptr;
            static DotProduct2D_method() {
                DotProduct2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "DotProduct2D");
            }

            internal static unsafe float Invoke(Vector2D A, Vector2D B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, DotProduct2D_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct Ease_method {
            static internal IntPtr Ease_ptr;
            static Ease_method() {
                Ease_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Ease");
            }

            internal static unsafe float Invoke(float A, float B, float Alpha, byte EasingFunc, float BlendExp, int Steps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                *((float*)(b+8)) = Alpha;
                *(b+12) = EasingFunc;
                *((float*)(b+16)) = BlendExp;
                *((int*)(b+20)) = Steps;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Ease_ptr, new IntPtr(p)); ;
                return *((float*)(b+24));
            }
        }
        internal struct EqualEqual_BoolBool_method {
            static internal IntPtr EqualEqual_BoolBool_ptr;
            static EqualEqual_BoolBool_method() {
                EqualEqual_BoolBool_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_BoolBool");
            }

            internal static unsafe bool Invoke(bool A, bool B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                *((bool*)(b+1)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_BoolBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct EqualEqual_ByteByte_method {
            static internal IntPtr EqualEqual_ByteByte_ptr;
            static EqualEqual_ByteByte_method() {
                EqualEqual_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_ByteByte");
            }

            internal static unsafe bool Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_ByteByte_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct EqualEqual_ClassClass_method {
            static internal IntPtr EqualEqual_ClassClass_ptr;
            static EqualEqual_ClassClass_method() {
                EqualEqual_ClassClass_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_ClassClass");
            }

            internal static unsafe bool Invoke(SubclassOf<UObject> A, SubclassOf<UObject> B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = A;
                *((IntPtr*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_ClassClass_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct EqualEqual_DateTimeDateTime_method {
            static internal IntPtr EqualEqual_DateTimeDateTime_ptr;
            static EqualEqual_DateTimeDateTime_method() {
                EqualEqual_DateTimeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_DateTimeDateTime");
            }

            internal static unsafe bool Invoke(FDateTime A, FDateTime B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((FDateTime*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_DateTimeDateTime_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct EqualEqual_FloatFloat_method {
            static internal IntPtr EqualEqual_FloatFloat_ptr;
            static EqualEqual_FloatFloat_method() {
                EqualEqual_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_FloatFloat");
            }

            internal static unsafe bool Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct EqualEqual_IntInt_method {
            static internal IntPtr EqualEqual_IntInt_ptr;
            static EqualEqual_IntInt_method() {
                EqualEqual_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_IntInt");
            }

            internal static unsafe bool Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_IntInt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct EqualEqual_NameName_method {
            static internal IntPtr EqualEqual_NameName_ptr;
            static EqualEqual_NameName_method() {
                EqualEqual_NameName_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_NameName");
            }

            internal static unsafe bool Invoke(Name A, Name B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = A;
                *((Name*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_NameName_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct EqualEqual_ObjectObject_method {
            static internal IntPtr EqualEqual_ObjectObject_ptr;
            static EqualEqual_ObjectObject_method() {
                EqualEqual_ObjectObject_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_ObjectObject");
            }

            internal static unsafe bool Invoke(UObject A, UObject B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = A;
                *((IntPtr*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_ObjectObject_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct EqualEqual_RotatorRotator_method {
            static internal IntPtr EqualEqual_RotatorRotator_ptr;
            static EqualEqual_RotatorRotator_method() {
                EqualEqual_RotatorRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_RotatorRotator");
            }

            internal static unsafe bool Invoke(Rotator A, Rotator B, float ErrorTolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                *((float*)(b+24)) = ErrorTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_RotatorRotator_ptr, new IntPtr(p)); ;
                return *((bool*)(b+28));
            }
        }
        internal struct EqualEqual_TimespanTimespan_method {
            static internal IntPtr EqualEqual_TimespanTimespan_ptr;
            static EqualEqual_TimespanTimespan_method() {
                EqualEqual_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_TimespanTimespan");
            }

            internal static unsafe bool Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct EqualEqual_TransformTransform_method {
            static internal IntPtr EqualEqual_TransformTransform_ptr;
            static EqualEqual_TransformTransform_method() {
                EqualEqual_TransformTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_TransformTransform");
            }

            internal static unsafe bool Invoke(Transform A, Transform B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = A;
                *((Transform*)(b+48)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_TransformTransform_ptr, new IntPtr(p)); ;
                return *((bool*)(b+96));
            }
        }
        internal struct EqualEqual_Vector2DVector2D_method {
            static internal IntPtr EqualEqual_Vector2DVector2D_ptr;
            static EqualEqual_Vector2DVector2D_method() {
                EqualEqual_Vector2DVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_Vector2DVector2D");
            }

            internal static unsafe bool Invoke(Vector2D A, Vector2D B, float ErrorTolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                *((float*)(b+16)) = ErrorTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_Vector2DVector2D_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct EqualEqual_VectorVector_method {
            static internal IntPtr EqualEqual_VectorVector_ptr;
            static EqualEqual_VectorVector_method() {
                EqualEqual_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "EqualEqual_VectorVector");
            }

            internal static unsafe bool Invoke(Vector A, Vector B, float ErrorTolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                *((float*)(b+24)) = ErrorTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, EqualEqual_VectorVector_ptr, new IntPtr(p)); ;
                return *((bool*)(b+28));
            }
        }
        internal struct Exp_method {
            static internal IntPtr Exp_ptr;
            static Exp_method() {
                Exp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Exp");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Exp_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct FCeil_method {
            static internal IntPtr FCeil_ptr;
            static FCeil_method() {
                FCeil_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FCeil");
            }

            internal static unsafe int Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FCeil_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct FClamp_method {
            static internal IntPtr FClamp_ptr;
            static FClamp_method() {
                FClamp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FClamp");
            }

            internal static unsafe float Invoke(float Value, float Min, float Max) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *((float*)(b+4)) = Min;
                *((float*)(b+8)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FClamp_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct FFloor_method {
            static internal IntPtr FFloor_ptr;
            static FFloor_method() {
                FFloor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FFloor");
            }

            internal static unsafe int Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FFloor_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct FindClosestPointOnLine_method {
            static internal IntPtr FindClosestPointOnLine_ptr;
            static FindClosestPointOnLine_method() {
                FindClosestPointOnLine_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FindClosestPointOnLine");
            }

            internal static unsafe Vector Invoke(Vector Point, Vector LineOrigin, Vector LineDirection) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Vector*)(b+12)) = LineOrigin;
                *((Vector*)(b+24)) = LineDirection;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FindClosestPointOnLine_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+36));
            }
        }
        internal struct FindClosestPointOnSegment_method {
            static internal IntPtr FindClosestPointOnSegment_ptr;
            static FindClosestPointOnSegment_method() {
                FindClosestPointOnSegment_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FindClosestPointOnSegment");
            }

            internal static unsafe Vector Invoke(Vector Point, Vector SegmentStart, Vector SegmentEnd) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Vector*)(b+12)) = SegmentStart;
                *((Vector*)(b+24)) = SegmentEnd;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FindClosestPointOnSegment_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+36));
            }
        }
        internal struct FindLookAtRotation_method {
            static internal IntPtr FindLookAtRotation_ptr;
            static FindLookAtRotation_method() {
                FindLookAtRotation_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FindLookAtRotation");
            }

            internal static unsafe Rotator Invoke(Vector Start, Vector Target) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Start;
                *((Vector*)(b+12)) = Target;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FindLookAtRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct FindNearestPointsOnLineSegments_method {
            static internal IntPtr FindNearestPointsOnLineSegments_ptr;
            static FindNearestPointsOnLineSegments_method() {
                FindNearestPointsOnLineSegments_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FindNearestPointsOnLineSegments");
            }

            internal static unsafe (Vector, Vector) Invoke(Vector Segment1Start, Vector Segment1End, Vector Segment2Start, Vector Segment2End) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Segment1Start;
                *((Vector*)(b+12)) = Segment1End;
                *((Vector*)(b+24)) = Segment2Start;
                *((Vector*)(b+36)) = Segment2End;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FindNearestPointsOnLineSegments_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+48)),*((Vector*)(b+60)));
            }
        }
        internal struct FInterpEaseInOut_method {
            static internal IntPtr FInterpEaseInOut_ptr;
            static FInterpEaseInOut_method() {
                FInterpEaseInOut_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FInterpEaseInOut");
            }

            internal static unsafe float Invoke(float A, float B, float Alpha, float Exponent) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                *((float*)(b+8)) = Alpha;
                *((float*)(b+12)) = Exponent;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FInterpEaseInOut_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct FInterpTo_method {
            static internal IntPtr FInterpTo_ptr;
            static FInterpTo_method() {
                FInterpTo_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FInterpTo");
            }

            internal static unsafe float Invoke(float Current, float Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Current;
                *((float*)(b+4)) = Target;
                *((float*)(b+8)) = DeltaTime;
                *((float*)(b+12)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FInterpTo_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct FInterpTo_Constant_method {
            static internal IntPtr FInterpTo_Constant_ptr;
            static FInterpTo_Constant_method() {
                FInterpTo_Constant_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FInterpTo_Constant");
            }

            internal static unsafe float Invoke(float Current, float Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Current;
                *((float*)(b+4)) = Target;
                *((float*)(b+8)) = DeltaTime;
                *((float*)(b+12)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FInterpTo_Constant_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct FixedTurn_method {
            static internal IntPtr FixedTurn_ptr;
            static FixedTurn_method() {
                FixedTurn_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FixedTurn");
            }

            internal static unsafe float Invoke(float InCurrent, float InDesired, float InDeltaRate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InCurrent;
                *((float*)(b+4)) = InDesired;
                *((float*)(b+8)) = InDeltaRate;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FixedTurn_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct FloatSpringInterp_method {
            static internal IntPtr FloatSpringInterp_ptr;
            static FloatSpringInterp_method() {
                FloatSpringInterp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FloatSpringInterp");
            }

            internal static unsafe float Invoke(float Current, float Target, FloatSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Current;
                *((float*)(b+4)) = Target;
                *((FloatSpringState*)(b+8)) = SpringState;
                *((float*)(b+16)) = Stiffness;
                *((float*)(b+20)) = CriticalDampingFactor;
                *((float*)(b+24)) = DeltaTime;
                *((float*)(b+28)) = Mass;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FloatSpringInterp_ptr, new IntPtr(p)); ;
                return *((float*)(b+32));
            }
        }
        internal struct FMax_method {
            static internal IntPtr FMax_ptr;
            static FMax_method() {
                FMax_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FMax");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FMax_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct FMin_method {
            static internal IntPtr FMin_ptr;
            static FMin_method() {
                FMin_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FMin");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FMin_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct FMod_method {
            static internal IntPtr FMod_ptr;
            static FMod_method() {
                FMod_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FMod");
            }

            internal static unsafe (float, int) Invoke(float Dividend, float Divisor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Dividend;
                *((float*)(b+4)) = Divisor;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FMod_ptr, new IntPtr(p)); ;
                return (*((float*)(b+8)),*((int*)(b+12)));
            }
        }
        internal struct Fraction_method {
            static internal IntPtr Fraction_ptr;
            static Fraction_method() {
                Fraction_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Fraction");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Fraction_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct FromDays_method {
            static internal IntPtr FromDays_ptr;
            static FromDays_method() {
                FromDays_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FromDays");
            }

            internal static unsafe Timespan Invoke(float Days) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Days;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FromDays_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+8));
            }
        }
        internal struct FromHours_method {
            static internal IntPtr FromHours_ptr;
            static FromHours_method() {
                FromHours_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FromHours");
            }

            internal static unsafe Timespan Invoke(float Hours) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Hours;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FromHours_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+8));
            }
        }
        internal struct FromMilliseconds_method {
            static internal IntPtr FromMilliseconds_ptr;
            static FromMilliseconds_method() {
                FromMilliseconds_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FromMilliseconds");
            }

            internal static unsafe Timespan Invoke(float Milliseconds) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Milliseconds;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FromMilliseconds_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+8));
            }
        }
        internal struct FromMinutes_method {
            static internal IntPtr FromMinutes_ptr;
            static FromMinutes_method() {
                FromMinutes_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FromMinutes");
            }

            internal static unsafe Timespan Invoke(float Minutes) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Minutes;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FromMinutes_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+8));
            }
        }
        internal struct FromSeconds_method {
            static internal IntPtr FromSeconds_ptr;
            static FromSeconds_method() {
                FromSeconds_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FromSeconds");
            }

            internal static unsafe Timespan Invoke(float Seconds) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Seconds;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FromSeconds_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+8));
            }
        }
        internal struct FTrunc_method {
            static internal IntPtr FTrunc_ptr;
            static FTrunc_method() {
                FTrunc_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FTrunc");
            }

            internal static unsafe int Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FTrunc_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct FTruncVector_method {
            static internal IntPtr FTruncVector_ptr;
            static FTruncVector_method() {
                FTruncVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "FTruncVector");
            }

            internal static unsafe IntVector Invoke(Vector InVector) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVector;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, FTruncVector_ptr, new IntPtr(p)); ;
                return *((IntVector*)(b+12));
            }
        }
        internal struct GetAxes_method {
            static internal IntPtr GetAxes_ptr;
            static GetAxes_method() {
                GetAxes_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetAxes");
            }

            internal static unsafe (Vector, Vector, Vector) Invoke(Rotator A) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetAxes_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+12)),*((Vector*)(b+24)),*((Vector*)(b+36)));
            }
        }
        internal struct GetAzimuthAndElevation_method {
            static internal IntPtr GetAzimuthAndElevation_ptr;
            static GetAzimuthAndElevation_method() {
                GetAzimuthAndElevation_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetAzimuthAndElevation");
            }

            internal static unsafe (float, float) Invoke(Vector InDirection, Transform ReferenceFrame) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InDirection;
                *((Transform*)(b+16)) = ReferenceFrame;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetAzimuthAndElevation_ptr, new IntPtr(p)); ;
                return (*((float*)(b+64)),*((float*)(b+68)));
            }
        }
        internal struct GetDate_method {
            static internal IntPtr GetDate_ptr;
            static GetDate_method() {
                GetDate_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetDate");
            }

            internal static unsafe FDateTime Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetDate_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+8));
            }
        }
        internal struct GetDay_method {
            static internal IntPtr GetDay_ptr;
            static GetDay_method() {
                GetDay_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetDay");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetDay_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetDayOfYear_method {
            static internal IntPtr GetDayOfYear_ptr;
            static GetDayOfYear_method() {
                GetDayOfYear_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetDayOfYear");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetDayOfYear_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetDays_method {
            static internal IntPtr GetDays_ptr;
            static GetDays_method() {
                GetDays_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetDays");
            }

            internal static unsafe int Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetDays_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetDirectionUnitVector_method {
            static internal IntPtr GetDirectionUnitVector_ptr;
            static GetDirectionUnitVector_method() {
                GetDirectionUnitVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetDirectionUnitVector");
            }

            internal static unsafe Vector Invoke(Vector From, Vector To) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = From;
                *((Vector*)(b+12)) = To;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetDirectionUnitVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct GetDuration_method {
            static internal IntPtr GetDuration_ptr;
            static GetDuration_method() {
                GetDuration_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetDuration");
            }

            internal static unsafe Timespan Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetDuration_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+8));
            }
        }
        internal struct GetForwardVector_method {
            static internal IntPtr GetForwardVector_ptr;
            static GetForwardVector_method() {
                GetForwardVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetForwardVector");
            }

            internal static unsafe Vector Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetForwardVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetHour_method {
            static internal IntPtr GetHour_ptr;
            static GetHour_method() {
                GetHour_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetHour");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetHour_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetHour12_method {
            static internal IntPtr GetHour12_ptr;
            static GetHour12_method() {
                GetHour12_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetHour12");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetHour12_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetHours_method {
            static internal IntPtr GetHours_ptr;
            static GetHours_method() {
                GetHours_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetHours");
            }

            internal static unsafe int Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetHours_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetMaxElement_method {
            static internal IntPtr GetMaxElement_ptr;
            static GetMaxElement_method() {
                GetMaxElement_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetMaxElement");
            }

            internal static unsafe float Invoke(Vector A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetMaxElement_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetMillisecond_method {
            static internal IntPtr GetMillisecond_ptr;
            static GetMillisecond_method() {
                GetMillisecond_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetMillisecond");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetMillisecond_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetMilliseconds_method {
            static internal IntPtr GetMilliseconds_ptr;
            static GetMilliseconds_method() {
                GetMilliseconds_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetMilliseconds");
            }

            internal static unsafe int Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetMilliseconds_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetMinElement_method {
            static internal IntPtr GetMinElement_ptr;
            static GetMinElement_method() {
                GetMinElement_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetMinElement");
            }

            internal static unsafe float Invoke(Vector A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetMinElement_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetMinute_method {
            static internal IntPtr GetMinute_ptr;
            static GetMinute_method() {
                GetMinute_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetMinute");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetMinute_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetMinutes_method {
            static internal IntPtr GetMinutes_ptr;
            static GetMinutes_method() {
                GetMinutes_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetMinutes");
            }

            internal static unsafe int Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetMinutes_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetMonth_method {
            static internal IntPtr GetMonth_ptr;
            static GetMonth_method() {
                GetMonth_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetMonth");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetMonth_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetPI_method {
            static internal IntPtr GetPI_ptr;
            static GetPI_method() {
                GetPI_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetPI");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetPI_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPointDistanceToLine_method {
            static internal IntPtr GetPointDistanceToLine_ptr;
            static GetPointDistanceToLine_method() {
                GetPointDistanceToLine_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetPointDistanceToLine");
            }

            internal static unsafe float Invoke(Vector Point, Vector LineOrigin, Vector LineDirection) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Vector*)(b+12)) = LineOrigin;
                *((Vector*)(b+24)) = LineDirection;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetPointDistanceToLine_ptr, new IntPtr(p)); ;
                return *((float*)(b+36));
            }
        }
        internal struct GetPointDistanceToSegment_method {
            static internal IntPtr GetPointDistanceToSegment_ptr;
            static GetPointDistanceToSegment_method() {
                GetPointDistanceToSegment_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetPointDistanceToSegment");
            }

            internal static unsafe float Invoke(Vector Point, Vector SegmentStart, Vector SegmentEnd) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Vector*)(b+12)) = SegmentStart;
                *((Vector*)(b+24)) = SegmentEnd;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetPointDistanceToSegment_ptr, new IntPtr(p)); ;
                return *((float*)(b+36));
            }
        }
        internal struct GetReflectionVector_method {
            static internal IntPtr GetReflectionVector_ptr;
            static GetReflectionVector_method() {
                GetReflectionVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetReflectionVector");
            }

            internal static unsafe Vector Invoke(Vector Direction, Vector SurfaceNormal) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Direction;
                *((Vector*)(b+12)) = SurfaceNormal;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetReflectionVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct GetRightVector_method {
            static internal IntPtr GetRightVector_ptr;
            static GetRightVector_method() {
                GetRightVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetRightVector");
            }

            internal static unsafe Vector Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetRightVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetSecond_method {
            static internal IntPtr GetSecond_ptr;
            static GetSecond_method() {
                GetSecond_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetSecond");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetSecond_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetSeconds_method {
            static internal IntPtr GetSeconds_ptr;
            static GetSeconds_method() {
                GetSeconds_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetSeconds");
            }

            internal static unsafe int Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetSeconds_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetSlopeDegreeAngles_method {
            static internal IntPtr GetSlopeDegreeAngles_ptr;
            static GetSlopeDegreeAngles_method() {
                GetSlopeDegreeAngles_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetSlopeDegreeAngles");
            }

            internal static unsafe (float, float) Invoke(Vector MyRightYAxis, Vector FloorNormal, Vector UpVector) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = MyRightYAxis;
                *((Vector*)(b+12)) = FloorNormal;
                *((Vector*)(b+24)) = UpVector;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetSlopeDegreeAngles_ptr, new IntPtr(p)); ;
                return (*((float*)(b+36)),*((float*)(b+40)));
            }
        }
        internal struct GetTAU_method {
            static internal IntPtr GetTAU_ptr;
            static GetTAU_method() {
                GetTAU_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetTAU");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetTAU_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetTimeOfDay_method {
            static internal IntPtr GetTimeOfDay_ptr;
            static GetTimeOfDay_method() {
                GetTimeOfDay_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetTimeOfDay");
            }

            internal static unsafe Timespan Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetTimeOfDay_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+8));
            }
        }
        internal struct GetTotalDays_method {
            static internal IntPtr GetTotalDays_ptr;
            static GetTotalDays_method() {
                GetTotalDays_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetTotalDays");
            }

            internal static unsafe float Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetTotalDays_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetTotalHours_method {
            static internal IntPtr GetTotalHours_ptr;
            static GetTotalHours_method() {
                GetTotalHours_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetTotalHours");
            }

            internal static unsafe float Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetTotalHours_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetTotalMilliseconds_method {
            static internal IntPtr GetTotalMilliseconds_ptr;
            static GetTotalMilliseconds_method() {
                GetTotalMilliseconds_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetTotalMilliseconds");
            }

            internal static unsafe float Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetTotalMilliseconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetTotalMinutes_method {
            static internal IntPtr GetTotalMinutes_ptr;
            static GetTotalMinutes_method() {
                GetTotalMinutes_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetTotalMinutes");
            }

            internal static unsafe float Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetTotalMinutes_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetTotalSeconds_method {
            static internal IntPtr GetTotalSeconds_ptr;
            static GetTotalSeconds_method() {
                GetTotalSeconds_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetTotalSeconds");
            }

            internal static unsafe float Invoke(Timespan A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetTotalSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetUpVector_method {
            static internal IntPtr GetUpVector_ptr;
            static GetUpVector_method() {
                GetUpVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetUpVector");
            }

            internal static unsafe Vector Invoke(Rotator InRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = InRot;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetUpVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct GetVectorArrayAverage_method {
            static internal IntPtr GetVectorArrayAverage_ptr;
            static GetVectorArrayAverage_method() {
                GetVectorArrayAverage_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetVectorArrayAverage");
            }

            internal static unsafe Vector Invoke(byte Vectors /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Vectors
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetVectorArrayAverage_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Vectors
                return *((Vector*)(b+16));
            }
        }
        internal struct GetYawPitchFromVector_method {
            static internal IntPtr GetYawPitchFromVector_ptr;
            static GetYawPitchFromVector_method() {
                GetYawPitchFromVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetYawPitchFromVector");
            }

            internal static unsafe (float, float) Invoke(Vector InVec) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVec;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetYawPitchFromVector_ptr, new IntPtr(p)); ;
                return (*((float*)(b+12)),*((float*)(b+16)));
            }
        }
        internal struct GetYear_method {
            static internal IntPtr GetYear_ptr;
            static GetYear_method() {
                GetYear_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GetYear");
            }

            internal static unsafe int Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GetYear_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct Greater_ByteByte_method {
            static internal IntPtr Greater_ByteByte_ptr;
            static Greater_ByteByte_method() {
                Greater_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Greater_ByteByte");
            }

            internal static unsafe bool Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Greater_ByteByte_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct Greater_DateTimeDateTime_method {
            static internal IntPtr Greater_DateTimeDateTime_ptr;
            static Greater_DateTimeDateTime_method() {
                Greater_DateTimeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Greater_DateTimeDateTime");
            }

            internal static unsafe bool Invoke(FDateTime A, FDateTime B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((FDateTime*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Greater_DateTimeDateTime_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct Greater_FloatFloat_method {
            static internal IntPtr Greater_FloatFloat_ptr;
            static Greater_FloatFloat_method() {
                Greater_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Greater_FloatFloat");
            }

            internal static unsafe bool Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Greater_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct Greater_IntInt_method {
            static internal IntPtr Greater_IntInt_ptr;
            static Greater_IntInt_method() {
                Greater_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Greater_IntInt");
            }

            internal static unsafe bool Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Greater_IntInt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct Greater_TimespanTimespan_method {
            static internal IntPtr Greater_TimespanTimespan_ptr;
            static Greater_TimespanTimespan_method() {
                Greater_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Greater_TimespanTimespan");
            }

            internal static unsafe bool Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Greater_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct GreaterEqual_ByteByte_method {
            static internal IntPtr GreaterEqual_ByteByte_ptr;
            static GreaterEqual_ByteByte_method() {
                GreaterEqual_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GreaterEqual_ByteByte");
            }

            internal static unsafe bool Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GreaterEqual_ByteByte_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct GreaterEqual_DateTimeDateTime_method {
            static internal IntPtr GreaterEqual_DateTimeDateTime_ptr;
            static GreaterEqual_DateTimeDateTime_method() {
                GreaterEqual_DateTimeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GreaterEqual_DateTimeDateTime");
            }

            internal static unsafe bool Invoke(FDateTime A, FDateTime B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((FDateTime*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GreaterEqual_DateTimeDateTime_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct GreaterEqual_FloatFloat_method {
            static internal IntPtr GreaterEqual_FloatFloat_ptr;
            static GreaterEqual_FloatFloat_method() {
                GreaterEqual_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GreaterEqual_FloatFloat");
            }

            internal static unsafe bool Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GreaterEqual_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct GreaterEqual_IntInt_method {
            static internal IntPtr GreaterEqual_IntInt_ptr;
            static GreaterEqual_IntInt_method() {
                GreaterEqual_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GreaterEqual_IntInt");
            }

            internal static unsafe bool Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GreaterEqual_IntInt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct GreaterEqual_TimespanTimespan_method {
            static internal IntPtr GreaterEqual_TimespanTimespan_ptr;
            static GreaterEqual_TimespanTimespan_method() {
                GreaterEqual_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GreaterEqual_TimespanTimespan");
            }

            internal static unsafe bool Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GreaterEqual_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct GreaterGreater_VectorRotator_method {
            static internal IntPtr GreaterGreater_VectorRotator_ptr;
            static GreaterGreater_VectorRotator_method() {
                GreaterGreater_VectorRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GreaterGreater_VectorRotator");
            }

            internal static unsafe Vector Invoke(Vector A, Rotator B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GreaterGreater_VectorRotator_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct GridSnap_Float_method {
            static internal IntPtr GridSnap_Float_ptr;
            static GridSnap_Float_method() {
                GridSnap_Float_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "GridSnap_Float");
            }

            internal static unsafe float Invoke(float Location, float GridSize) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Location;
                *((float*)(b+4)) = GridSize;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, GridSnap_Float_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct HSVToRGB_method {
            static internal IntPtr HSVToRGB_ptr;
            static HSVToRGB_method() {
                HSVToRGB_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "HSVToRGB");
            }

            internal static unsafe LinearColor Invoke(float H, float S, float V, float A) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = H;
                *((float*)(b+4)) = S;
                *((float*)(b+8)) = V;
                *((float*)(b+12)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, HSVToRGB_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+16));
            }
        }
        internal struct HSVToRGB_Vector_method {
            static internal IntPtr HSVToRGB_Vector_ptr;
            static HSVToRGB_Vector_method() {
                HSVToRGB_Vector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "HSVToRGB_Vector");
            }

            internal static unsafe LinearColor Invoke(LinearColor HSV) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = HSV;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, HSVToRGB_Vector_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+16));
            }
        }
        internal struct Hypotenuse_method {
            static internal IntPtr Hypotenuse_ptr;
            static Hypotenuse_method() {
                Hypotenuse_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Hypotenuse");
            }

            internal static unsafe float Invoke(float Width, float Height) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Width;
                *((float*)(b+4)) = Height;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Hypotenuse_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct InRange_FloatFloat_method {
            static internal IntPtr InRange_FloatFloat_ptr;
            static InRange_FloatFloat_method() {
                InRange_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "InRange_FloatFloat");
            }

            internal static unsafe bool Invoke(float Value, float Min, float Max, bool InclusiveMin, bool InclusiveMax) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *((float*)(b+4)) = Min;
                *((float*)(b+8)) = Max;
                *((bool*)(b+12)) = InclusiveMin;
                *((bool*)(b+13)) = InclusiveMax;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, InRange_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+14));
            }
        }
        internal struct InRange_IntInt_method {
            static internal IntPtr InRange_IntInt_ptr;
            static InRange_IntInt_method() {
                InRange_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "InRange_IntInt");
            }

            internal static unsafe bool Invoke(int Value, int Min, int Max, bool InclusiveMin, bool InclusiveMax) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                *((int*)(b+4)) = Min;
                *((int*)(b+8)) = Max;
                *((bool*)(b+12)) = InclusiveMin;
                *((bool*)(b+13)) = InclusiveMax;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, InRange_IntInt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+14));
            }
        }
        internal struct InverseTransformDirection_method {
            static internal IntPtr InverseTransformDirection_ptr;
            static InverseTransformDirection_method() {
                InverseTransformDirection_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "InverseTransformDirection");
            }

            internal static unsafe Vector Invoke(Transform T, Vector Direction) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = T;
                *((Vector*)(b+48)) = Direction;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, InverseTransformDirection_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+60));
            }
        }
        internal struct InverseTransformLocation_method {
            static internal IntPtr InverseTransformLocation_ptr;
            static InverseTransformLocation_method() {
                InverseTransformLocation_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "InverseTransformLocation");
            }

            internal static unsafe Vector Invoke(Transform T, Vector Location) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = T;
                *((Vector*)(b+48)) = Location;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, InverseTransformLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+60));
            }
        }
        internal struct InverseTransformRotation_method {
            static internal IntPtr InverseTransformRotation_ptr;
            static InverseTransformRotation_method() {
                InverseTransformRotation_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "InverseTransformRotation");
            }

            internal static unsafe Rotator Invoke(Transform T, Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = T;
                *((Rotator*)(b+48)) = Rotation;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, InverseTransformRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+60));
            }
        }
        internal struct InvertTransform_method {
            static internal IntPtr InvertTransform_ptr;
            static InvertTransform_method() {
                InvertTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "InvertTransform");
            }

            internal static unsafe Transform Invoke(Transform T) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = T;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, InvertTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+48));
            }
        }
        internal struct IsAfternoon_method {
            static internal IntPtr IsAfternoon_ptr;
            static IsAfternoon_method() {
                IsAfternoon_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "IsAfternoon");
            }

            internal static unsafe bool Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, IsAfternoon_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsLeapYear_method {
            static internal IntPtr IsLeapYear_ptr;
            static IsLeapYear_method() {
                IsLeapYear_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "IsLeapYear");
            }

            internal static unsafe bool Invoke(int Year) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Year;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, IsLeapYear_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct IsMorning_method {
            static internal IntPtr IsMorning_ptr;
            static IsMorning_method() {
                IsMorning_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "IsMorning");
            }

            internal static unsafe bool Invoke(FDateTime A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, IsMorning_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsPointInBox_method {
            static internal IntPtr IsPointInBox_ptr;
            static IsPointInBox_method() {
                IsPointInBox_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "IsPointInBox");
            }

            internal static unsafe bool Invoke(Vector Point, Vector BoxOrigin, Vector BoxExtent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Vector*)(b+12)) = BoxOrigin;
                *((Vector*)(b+24)) = BoxExtent;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, IsPointInBox_ptr, new IntPtr(p)); ;
                return *((bool*)(b+36));
            }
        }
        internal struct IsPointInBoxWithTransform_method {
            static internal IntPtr IsPointInBoxWithTransform_ptr;
            static IsPointInBoxWithTransform_method() {
                IsPointInBoxWithTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "IsPointInBoxWithTransform");
            }

            internal static unsafe bool Invoke(Vector Point, Transform BoxWorldTransform, Vector BoxExtent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Transform*)(b+16)) = BoxWorldTransform;
                *((Vector*)(b+64)) = BoxExtent;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, IsPointInBoxWithTransform_ptr, new IntPtr(p)); ;
                return *((bool*)(b+76));
            }
        }
        internal struct Lerp_method {
            static internal IntPtr Lerp_ptr;
            static Lerp_method() {
                Lerp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Lerp");
            }

            internal static unsafe float Invoke(float A, float B, float Alpha) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                *((float*)(b+8)) = Alpha;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Lerp_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct Less_ByteByte_method {
            static internal IntPtr Less_ByteByte_ptr;
            static Less_ByteByte_method() {
                Less_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Less_ByteByte");
            }

            internal static unsafe bool Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Less_ByteByte_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct Less_DateTimeDateTime_method {
            static internal IntPtr Less_DateTimeDateTime_ptr;
            static Less_DateTimeDateTime_method() {
                Less_DateTimeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Less_DateTimeDateTime");
            }

            internal static unsafe bool Invoke(FDateTime A, FDateTime B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((FDateTime*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Less_DateTimeDateTime_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct Less_FloatFloat_method {
            static internal IntPtr Less_FloatFloat_ptr;
            static Less_FloatFloat_method() {
                Less_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Less_FloatFloat");
            }

            internal static unsafe bool Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Less_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct Less_IntInt_method {
            static internal IntPtr Less_IntInt_ptr;
            static Less_IntInt_method() {
                Less_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Less_IntInt");
            }

            internal static unsafe bool Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Less_IntInt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct Less_TimespanTimespan_method {
            static internal IntPtr Less_TimespanTimespan_ptr;
            static Less_TimespanTimespan_method() {
                Less_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Less_TimespanTimespan");
            }

            internal static unsafe bool Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Less_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct LessEqual_ByteByte_method {
            static internal IntPtr LessEqual_ByteByte_ptr;
            static LessEqual_ByteByte_method() {
                LessEqual_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LessEqual_ByteByte");
            }

            internal static unsafe bool Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LessEqual_ByteByte_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct LessEqual_DateTimeDateTime_method {
            static internal IntPtr LessEqual_DateTimeDateTime_ptr;
            static LessEqual_DateTimeDateTime_method() {
                LessEqual_DateTimeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LessEqual_DateTimeDateTime");
            }

            internal static unsafe bool Invoke(FDateTime A, FDateTime B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((FDateTime*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LessEqual_DateTimeDateTime_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct LessEqual_FloatFloat_method {
            static internal IntPtr LessEqual_FloatFloat_ptr;
            static LessEqual_FloatFloat_method() {
                LessEqual_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LessEqual_FloatFloat");
            }

            internal static unsafe bool Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LessEqual_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct LessEqual_IntInt_method {
            static internal IntPtr LessEqual_IntInt_ptr;
            static LessEqual_IntInt_method() {
                LessEqual_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LessEqual_IntInt");
            }

            internal static unsafe bool Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LessEqual_IntInt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct LessEqual_TimespanTimespan_method {
            static internal IntPtr LessEqual_TimespanTimespan_ptr;
            static LessEqual_TimespanTimespan_method() {
                LessEqual_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LessEqual_TimespanTimespan");
            }

            internal static unsafe bool Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LessEqual_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct LessLess_VectorRotator_method {
            static internal IntPtr LessLess_VectorRotator_ptr;
            static LessLess_VectorRotator_method() {
                LessLess_VectorRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LessLess_VectorRotator");
            }

            internal static unsafe Vector Invoke(Vector A, Rotator B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LessLess_VectorRotator_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct LinearColorLerp_method {
            static internal IntPtr LinearColorLerp_ptr;
            static LinearColorLerp_method() {
                LinearColorLerp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LinearColorLerp");
            }

            internal static unsafe LinearColor Invoke(LinearColor A, LinearColor B, float Alpha) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = A;
                *((LinearColor*)(b+16)) = B;
                *((float*)(b+32)) = Alpha;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LinearColorLerp_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+36));
            }
        }
        internal struct LinearColorLerpUsingHSV_method {
            static internal IntPtr LinearColorLerpUsingHSV_ptr;
            static LinearColorLerpUsingHSV_method() {
                LinearColorLerpUsingHSV_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LinearColorLerpUsingHSV");
            }

            internal static unsafe LinearColor Invoke(LinearColor A, LinearColor B, float Alpha) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = A;
                *((LinearColor*)(b+16)) = B;
                *((float*)(b+32)) = Alpha;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LinearColorLerpUsingHSV_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+36));
            }
        }
        internal struct LinePlaneIntersection_method {
            static internal IntPtr LinePlaneIntersection_ptr;
            static LinePlaneIntersection_method() {
                LinePlaneIntersection_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LinePlaneIntersection");
            }

            internal static unsafe (float, Vector, bool) Invoke(Vector LineStart, Vector LineEnd, Plane APlane) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = LineStart;
                *((Vector*)(b+12)) = LineEnd;
                *((Plane*)(b+32)) = APlane;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LinePlaneIntersection_ptr, new IntPtr(p)); ;
                return (*((float*)(b+48)),*((Vector*)(b+52)),*((bool*)(b+64)));
            }
        }
        internal struct LinePlaneIntersection_OriginNormal_method {
            static internal IntPtr LinePlaneIntersection_OriginNormal_ptr;
            static LinePlaneIntersection_OriginNormal_method() {
                LinePlaneIntersection_OriginNormal_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "LinePlaneIntersection_OriginNormal");
            }

            internal static unsafe (float, Vector, bool) Invoke(Vector LineStart, Vector LineEnd, Vector PlaneOrigin, Vector PlaneNormal) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = LineStart;
                *((Vector*)(b+12)) = LineEnd;
                *((Vector*)(b+24)) = PlaneOrigin;
                *((Vector*)(b+36)) = PlaneNormal;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, LinePlaneIntersection_OriginNormal_ptr, new IntPtr(p)); ;
                return (*((float*)(b+48)),*((Vector*)(b+52)),*((bool*)(b+64)));
            }
        }
        internal struct Log_method {
            static internal IntPtr Log_ptr;
            static Log_method() {
                Log_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Log");
            }

            internal static unsafe float Invoke(float A, float Base) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = Base;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Log_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Loge_method {
            static internal IntPtr Loge_ptr;
            static Loge_method() {
                Loge_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Loge");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Loge_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct MakeBox_method {
            static internal IntPtr MakeBox_ptr;
            static MakeBox_method() {
                MakeBox_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeBox");
            }

            internal static unsafe Box Invoke(Vector Min, Vector Max) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Min;
                *((Vector*)(b+12)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeBox_ptr, new IntPtr(p)); ;
                return *((Box*)(b+24));
            }
        }
        internal struct MakeBox2D_method {
            static internal IntPtr MakeBox2D_ptr;
            static MakeBox2D_method() {
                MakeBox2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeBox2D");
            }

            internal static unsafe Box2D Invoke(Vector2D Min, Vector2D Max) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Min;
                *((Vector2D*)(b+8)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeBox2D_ptr, new IntPtr(p)); ;
                return *((Box2D*)(b+16));
            }
        }
        internal struct MakeColor_method {
            static internal IntPtr MakeColor_ptr;
            static MakeColor_method() {
                MakeColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeColor");
            }

            internal static unsafe LinearColor Invoke(float R, float G, float B, float A) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = R;
                *((float*)(b+4)) = G;
                *((float*)(b+8)) = B;
                *((float*)(b+12)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+16));
            }
        }
        internal struct MakeDateTime_method {
            static internal IntPtr MakeDateTime_ptr;
            static MakeDateTime_method() {
                MakeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeDateTime");
            }

            internal static unsafe FDateTime Invoke(int Year, int Month, int Day, int Hour, int Minute, int Second, int Millisecond) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Year;
                *((int*)(b+4)) = Month;
                *((int*)(b+8)) = Day;
                *((int*)(b+12)) = Hour;
                *((int*)(b+16)) = Minute;
                *((int*)(b+20)) = Second;
                *((int*)(b+24)) = Millisecond;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeDateTime_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+32));
            }
        }
        internal struct MakeFrameRate_method {
            static internal IntPtr MakeFrameRate_ptr;
            static MakeFrameRate_method() {
                MakeFrameRate_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeFrameRate");
            }

            internal static unsafe FrameRate Invoke(int Numerator, int Denominator) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Numerator;
                *((int*)(b+4)) = Denominator;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeFrameRate_ptr, new IntPtr(p)); ;
                return *((FrameRate*)(b+8));
            }
        }
        internal struct MakePlaneFromPointAndNormal_method {
            static internal IntPtr MakePlaneFromPointAndNormal_ptr;
            static MakePlaneFromPointAndNormal_method() {
                MakePlaneFromPointAndNormal_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakePlaneFromPointAndNormal");
            }

            internal static unsafe Plane Invoke(Vector Point, Vector Normal) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Vector*)(b+12)) = Normal;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakePlaneFromPointAndNormal_ptr, new IntPtr(p)); ;
                return *((Plane*)(b+32));
            }
        }
        internal struct MakePulsatingValue_method {
            static internal IntPtr MakePulsatingValue_ptr;
            static MakePulsatingValue_method() {
                MakePulsatingValue_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakePulsatingValue");
            }

            internal static unsafe float Invoke(float InCurrentTime, float InPulsesPerSecond, float InPhase) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InCurrentTime;
                *((float*)(b+4)) = InPulsesPerSecond;
                *((float*)(b+8)) = InPhase;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakePulsatingValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct MakeQualifiedFrameTime_method {
            static internal IntPtr MakeQualifiedFrameTime_ptr;
            static MakeQualifiedFrameTime_method() {
                MakeQualifiedFrameTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeQualifiedFrameTime");
            }

            internal static unsafe QualifiedFrameTime Invoke(FrameNumber Frame, FrameRate FrameRate, float SubFrame) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = Frame;
                *((FrameRate*)(b+4)) = FrameRate;
                *((float*)(b+12)) = SubFrame;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeQualifiedFrameTime_ptr, new IntPtr(p)); ;
                return *((QualifiedFrameTime*)(b+16));
            }
        }
        internal struct MakeRandomStream_method {
            static internal IntPtr MakeRandomStream_ptr;
            static MakeRandomStream_method() {
                MakeRandomStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRandomStream");
            }

            internal static unsafe RandomStream Invoke(int InitialSeed) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InitialSeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRandomStream_ptr, new IntPtr(p)); ;
                return *((RandomStream*)(b+4));
            }
        }
        internal struct MakeRotationFromAxes_method {
            static internal IntPtr MakeRotationFromAxes_ptr;
            static MakeRotationFromAxes_method() {
                MakeRotationFromAxes_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotationFromAxes");
            }

            internal static unsafe Rotator Invoke(Vector Forward, Vector Right, Vector Up) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Forward;
                *((Vector*)(b+12)) = Right;
                *((Vector*)(b+24)) = Up;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotationFromAxes_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+36));
            }
        }
        internal struct MakeRotator_method {
            static internal IntPtr MakeRotator_ptr;
            static MakeRotator_method() {
                MakeRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotator");
            }

            internal static unsafe Rotator Invoke(float Roll, float Pitch, float Yaw) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Roll;
                *((float*)(b+4)) = Pitch;
                *((float*)(b+8)) = Yaw;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct MakeRotFromX_method {
            static internal IntPtr MakeRotFromX_ptr;
            static MakeRotFromX_method() {
                MakeRotFromX_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromX");
            }

            internal static unsafe Rotator Invoke(Vector X) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = X;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromX_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct MakeRotFromXY_method {
            static internal IntPtr MakeRotFromXY_ptr;
            static MakeRotFromXY_method() {
                MakeRotFromXY_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromXY");
            }

            internal static unsafe Rotator Invoke(Vector X, Vector Y) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = X;
                *((Vector*)(b+12)) = Y;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromXY_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct MakeRotFromXZ_method {
            static internal IntPtr MakeRotFromXZ_ptr;
            static MakeRotFromXZ_method() {
                MakeRotFromXZ_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromXZ");
            }

            internal static unsafe Rotator Invoke(Vector X, Vector Z) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = X;
                *((Vector*)(b+12)) = Z;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromXZ_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct MakeRotFromY_method {
            static internal IntPtr MakeRotFromY_ptr;
            static MakeRotFromY_method() {
                MakeRotFromY_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromY");
            }

            internal static unsafe Rotator Invoke(Vector Y) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Y;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromY_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct MakeRotFromYX_method {
            static internal IntPtr MakeRotFromYX_ptr;
            static MakeRotFromYX_method() {
                MakeRotFromYX_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromYX");
            }

            internal static unsafe Rotator Invoke(Vector Y, Vector X) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Y;
                *((Vector*)(b+12)) = X;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromYX_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct MakeRotFromYZ_method {
            static internal IntPtr MakeRotFromYZ_ptr;
            static MakeRotFromYZ_method() {
                MakeRotFromYZ_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromYZ");
            }

            internal static unsafe Rotator Invoke(Vector Y, Vector Z) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Y;
                *((Vector*)(b+12)) = Z;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromYZ_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct MakeRotFromZ_method {
            static internal IntPtr MakeRotFromZ_ptr;
            static MakeRotFromZ_method() {
                MakeRotFromZ_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromZ");
            }

            internal static unsafe Rotator Invoke(Vector Z) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Z;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromZ_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct MakeRotFromZX_method {
            static internal IntPtr MakeRotFromZX_ptr;
            static MakeRotFromZX_method() {
                MakeRotFromZX_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromZX");
            }

            internal static unsafe Rotator Invoke(Vector Z, Vector X) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Z;
                *((Vector*)(b+12)) = X;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromZX_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct MakeRotFromZY_method {
            static internal IntPtr MakeRotFromZY_ptr;
            static MakeRotFromZY_method() {
                MakeRotFromZY_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeRotFromZY");
            }

            internal static unsafe Rotator Invoke(Vector Z, Vector Y) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Z;
                *((Vector*)(b+12)) = Y;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeRotFromZY_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct MakeTimespan_method {
            static internal IntPtr MakeTimespan_ptr;
            static MakeTimespan_method() {
                MakeTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeTimespan");
            }

            internal static unsafe Timespan Invoke(int Days, int Hours, int Minutes, int Seconds, int Milliseconds) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Days;
                *((int*)(b+4)) = Hours;
                *((int*)(b+8)) = Minutes;
                *((int*)(b+12)) = Seconds;
                *((int*)(b+16)) = Milliseconds;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeTimespan_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+24));
            }
        }
        internal struct MakeTimespan2_method {
            static internal IntPtr MakeTimespan2_ptr;
            static MakeTimespan2_method() {
                MakeTimespan2_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeTimespan2");
            }

            internal static unsafe Timespan Invoke(int Days, int Hours, int Minutes, int Seconds, int FractionNano) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Days;
                *((int*)(b+4)) = Hours;
                *((int*)(b+8)) = Minutes;
                *((int*)(b+12)) = Seconds;
                *((int*)(b+16)) = FractionNano;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeTimespan2_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+24));
            }
        }
        internal struct MakeTransform_method {
            static internal IntPtr MakeTransform_ptr;
            static MakeTransform_method() {
                MakeTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeTransform");
            }

            internal static unsafe Transform Invoke(Vector Location, Rotator Rotation, Vector Scale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Location;
                *((Rotator*)(b+12)) = Rotation;
                *((Vector*)(b+24)) = Scale;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+48));
            }
        }
        internal struct MakeVector_method {
            static internal IntPtr MakeVector_ptr;
            static MakeVector_method() {
                MakeVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeVector");
            }

            internal static unsafe Vector Invoke(float X, float Y, float Z) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = X;
                *((float*)(b+4)) = Y;
                *((float*)(b+8)) = Z;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct MakeVector2D_method {
            static internal IntPtr MakeVector2D_ptr;
            static MakeVector2D_method() {
                MakeVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MakeVector2D");
            }

            internal static unsafe Vector2D Invoke(float X, float Y) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = X;
                *((float*)(b+4)) = Y;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MakeVector2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+8));
            }
        }
        internal struct MapRangeClamped_method {
            static internal IntPtr MapRangeClamped_ptr;
            static MapRangeClamped_method() {
                MapRangeClamped_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MapRangeClamped");
            }

            internal static unsafe float Invoke(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *((float*)(b+4)) = InRangeA;
                *((float*)(b+8)) = InRangeB;
                *((float*)(b+12)) = OutRangeA;
                *((float*)(b+16)) = OutRangeB;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MapRangeClamped_ptr, new IntPtr(p)); ;
                return *((float*)(b+20));
            }
        }
        internal struct MapRangeUnclamped_method {
            static internal IntPtr MapRangeUnclamped_ptr;
            static MapRangeUnclamped_method() {
                MapRangeUnclamped_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MapRangeUnclamped");
            }

            internal static unsafe float Invoke(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *((float*)(b+4)) = InRangeA;
                *((float*)(b+8)) = InRangeB;
                *((float*)(b+12)) = OutRangeA;
                *((float*)(b+16)) = OutRangeB;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MapRangeUnclamped_ptr, new IntPtr(p)); ;
                return *((float*)(b+20));
            }
        }
        internal struct Matrix_GetOrigin_method {
            static internal IntPtr Matrix_GetOrigin_ptr;
            static Matrix_GetOrigin_method() {
                Matrix_GetOrigin_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Matrix_GetOrigin");
            }

            internal static unsafe Vector Invoke(Matrix InMatrix) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Matrix*)(b+0)) = InMatrix;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Matrix_GetOrigin_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+64));
            }
        }
        internal struct Max_method {
            static internal IntPtr Max_ptr;
            static Max_method() {
                Max_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Max");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Max_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct MaxOfByteArray_method {
            static internal IntPtr MaxOfByteArray_ptr;
            static MaxOfByteArray_method() {
                MaxOfByteArray_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MaxOfByteArray");
            }

            internal static unsafe (int, byte) Invoke(byte ByteArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ByteArray
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MaxOfByteArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ByteArray
                return (*((int*)(b+16)),*(b+20));
            }
        }
        internal struct MaxOfFloatArray_method {
            static internal IntPtr MaxOfFloatArray_ptr;
            static MaxOfFloatArray_method() {
                MaxOfFloatArray_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MaxOfFloatArray");
            }

            internal static unsafe (int, float) Invoke(byte FloatArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray FloatArray
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MaxOfFloatArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray FloatArray
                return (*((int*)(b+16)),*((float*)(b+20)));
            }
        }
        internal struct MaxOfIntArray_method {
            static internal IntPtr MaxOfIntArray_ptr;
            static MaxOfIntArray_method() {
                MaxOfIntArray_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MaxOfIntArray");
            }

            internal static unsafe (int, int) Invoke(byte IntArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray IntArray
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MaxOfIntArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray IntArray
                return (*((int*)(b+16)),*((int*)(b+20)));
            }
        }
        internal struct Min_method {
            static internal IntPtr Min_ptr;
            static Min_method() {
                Min_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Min");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Min_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct MinimumAreaRectangle_method {
            static internal IntPtr MinimumAreaRectangle_ptr;
            static MinimumAreaRectangle_method() {
                MinimumAreaRectangle_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MinimumAreaRectangle");
            }

            internal static unsafe (Vector, Rotator, float, float) Invoke(UObject WorldContextObject, byte InVerts /*TODO: array TArray */, Vector SampleSurfaceNormal, bool bDebugDraw) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: array TArray InVerts
                *((Vector*)(b+24)) = SampleSurfaceNormal;
                *((bool*)(b+68)) = bDebugDraw;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MinimumAreaRectangle_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InVerts
                return (*((Vector*)(b+36)),*((Rotator*)(b+48)),*((float*)(b+60)),*((float*)(b+64)));
            }
        }
        internal struct MinOfByteArray_method {
            static internal IntPtr MinOfByteArray_ptr;
            static MinOfByteArray_method() {
                MinOfByteArray_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MinOfByteArray");
            }

            internal static unsafe (int, byte) Invoke(byte ByteArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ByteArray
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MinOfByteArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ByteArray
                return (*((int*)(b+16)),*(b+20));
            }
        }
        internal struct MinOfFloatArray_method {
            static internal IntPtr MinOfFloatArray_ptr;
            static MinOfFloatArray_method() {
                MinOfFloatArray_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MinOfFloatArray");
            }

            internal static unsafe (int, float) Invoke(byte FloatArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray FloatArray
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MinOfFloatArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray FloatArray
                return (*((int*)(b+16)),*((float*)(b+20)));
            }
        }
        internal struct MinOfIntArray_method {
            static internal IntPtr MinOfIntArray_ptr;
            static MinOfIntArray_method() {
                MinOfIntArray_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MinOfIntArray");
            }

            internal static unsafe (int, int) Invoke(byte IntArray /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray IntArray
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MinOfIntArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray IntArray
                return (*((int*)(b+16)),*((int*)(b+20)));
            }
        }
        internal struct MirrorVectorByNormal_method {
            static internal IntPtr MirrorVectorByNormal_ptr;
            static MirrorVectorByNormal_method() {
                MirrorVectorByNormal_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MirrorVectorByNormal");
            }

            internal static unsafe Vector Invoke(Vector InVect, Vector InNormal) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVect;
                *((Vector*)(b+12)) = InNormal;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MirrorVectorByNormal_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct Multiply_ByteByte_method {
            static internal IntPtr Multiply_ByteByte_ptr;
            static Multiply_ByteByte_method() {
                Multiply_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_ByteByte");
            }

            internal static unsafe byte Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_ByteByte_ptr, new IntPtr(p)); ;
                return *(b+2);
            }
        }
        internal struct Multiply_FloatFloat_method {
            static internal IntPtr Multiply_FloatFloat_ptr;
            static Multiply_FloatFloat_method() {
                Multiply_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_FloatFloat");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_FloatFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Multiply_IntFloat_method {
            static internal IntPtr Multiply_IntFloat_ptr;
            static Multiply_IntFloat_method() {
                Multiply_IntFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_IntFloat");
            }

            internal static unsafe float Invoke(int A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_IntFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Multiply_IntInt_method {
            static internal IntPtr Multiply_IntInt_ptr;
            static Multiply_IntInt_method() {
                Multiply_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct Multiply_LinearColorFloat_method {
            static internal IntPtr Multiply_LinearColorFloat_ptr;
            static Multiply_LinearColorFloat_method() {
                Multiply_LinearColorFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_LinearColorFloat");
            }

            internal static unsafe LinearColor Invoke(LinearColor A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = A;
                *((float*)(b+16)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_LinearColorFloat_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+20));
            }
        }
        internal struct Multiply_LinearColorLinearColor_method {
            static internal IntPtr Multiply_LinearColorLinearColor_ptr;
            static Multiply_LinearColorLinearColor_method() {
                Multiply_LinearColorLinearColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_LinearColorLinearColor");
            }

            internal static unsafe LinearColor Invoke(LinearColor A, LinearColor B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = A;
                *((LinearColor*)(b+16)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_LinearColorLinearColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+32));
            }
        }
        internal struct Multiply_RotatorFloat_method {
            static internal IntPtr Multiply_RotatorFloat_ptr;
            static Multiply_RotatorFloat_method() {
                Multiply_RotatorFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_RotatorFloat");
            }

            internal static unsafe Rotator Invoke(Rotator A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((float*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_RotatorFloat_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+16));
            }
        }
        internal struct Multiply_RotatorInt_method {
            static internal IntPtr Multiply_RotatorInt_ptr;
            static Multiply_RotatorInt_method() {
                Multiply_RotatorInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_RotatorInt");
            }

            internal static unsafe Rotator Invoke(Rotator A, int B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((int*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_RotatorInt_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+16));
            }
        }
        internal struct Multiply_TimespanFloat_method {
            static internal IntPtr Multiply_TimespanFloat_ptr;
            static Multiply_TimespanFloat_method() {
                Multiply_TimespanFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_TimespanFloat");
            }

            internal static unsafe Timespan Invoke(Timespan A, float Scalar) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((float*)(b+8)) = Scalar;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_TimespanFloat_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+16));
            }
        }
        internal struct Multiply_Vector2DFloat_method {
            static internal IntPtr Multiply_Vector2DFloat_ptr;
            static Multiply_Vector2DFloat_method() {
                Multiply_Vector2DFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_Vector2DFloat");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((float*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_Vector2DFloat_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+12));
            }
        }
        internal struct Multiply_Vector2DVector2D_method {
            static internal IntPtr Multiply_Vector2DVector2D_ptr;
            static Multiply_Vector2DVector2D_method() {
                Multiply_Vector2DVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_Vector2DVector2D");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, Vector2D B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_Vector2DVector2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+16));
            }
        }
        internal struct Multiply_VectorFloat_method {
            static internal IntPtr Multiply_VectorFloat_ptr;
            static Multiply_VectorFloat_method() {
                Multiply_VectorFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_VectorFloat");
            }

            internal static unsafe Vector Invoke(Vector A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((float*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_VectorFloat_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Multiply_VectorInt_method {
            static internal IntPtr Multiply_VectorInt_ptr;
            static Multiply_VectorInt_method() {
                Multiply_VectorInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_VectorInt");
            }

            internal static unsafe Vector Invoke(Vector A, int B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((int*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_VectorInt_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Multiply_VectorVector_method {
            static internal IntPtr Multiply_VectorVector_ptr;
            static Multiply_VectorVector_method() {
                Multiply_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Multiply_VectorVector");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Multiply_VectorVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct MultiplyByPi_method {
            static internal IntPtr MultiplyByPi_ptr;
            static MultiplyByPi_method() {
                MultiplyByPi_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MultiplyByPi");
            }

            internal static unsafe float Invoke(float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MultiplyByPi_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct MultiplyMultiply_FloatFloat_method {
            static internal IntPtr MultiplyMultiply_FloatFloat_ptr;
            static MultiplyMultiply_FloatFloat_method() {
                MultiplyMultiply_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "MultiplyMultiply_FloatFloat");
            }

            internal static unsafe float Invoke(float Base, float Exp) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Base;
                *((float*)(b+4)) = Exp;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, MultiplyMultiply_FloatFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct NearlyEqual_FloatFloat_method {
            static internal IntPtr NearlyEqual_FloatFloat_ptr;
            static NearlyEqual_FloatFloat_method() {
                NearlyEqual_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NearlyEqual_FloatFloat");
            }

            internal static unsafe bool Invoke(float A, float B, float ErrorTolerance) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                *((float*)(b+8)) = ErrorTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NearlyEqual_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct NearlyEqual_TransformTransform_method {
            static internal IntPtr NearlyEqual_TransformTransform_ptr;
            static NearlyEqual_TransformTransform_method() {
                NearlyEqual_TransformTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NearlyEqual_TransformTransform");
            }

            internal static unsafe bool Invoke(Transform A, Transform B, float LocationTolerance, float RotationTolerance, float Scale3DTolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = A;
                *((Transform*)(b+48)) = B;
                *((float*)(b+96)) = LocationTolerance;
                *((float*)(b+100)) = RotationTolerance;
                *((float*)(b+104)) = Scale3DTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NearlyEqual_TransformTransform_ptr, new IntPtr(p)); ;
                return *((bool*)(b+108));
            }
        }
        internal struct NegateRotator_method {
            static internal IntPtr NegateRotator_ptr;
            static NegateRotator_method() {
                NegateRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NegateRotator");
            }

            internal static unsafe Rotator Invoke(Rotator A) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NegateRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct NegateVector_method {
            static internal IntPtr NegateVector_ptr;
            static NegateVector_method() {
                NegateVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NegateVector");
            }

            internal static unsafe Vector Invoke(Vector A) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NegateVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct Normal_method {
            static internal IntPtr Normal_ptr;
            static Normal_method() {
                Normal_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Normal");
            }

            internal static unsafe Vector Invoke(Vector A) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Normal_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct Normal2D_method {
            static internal IntPtr Normal2D_ptr;
            static Normal2D_method() {
                Normal2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Normal2D");
            }

            internal static unsafe Vector2D Invoke(Vector2D A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Normal2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+8));
            }
        }
        internal struct NormalizeAxis_method {
            static internal IntPtr NormalizeAxis_ptr;
            static NormalizeAxis_method() {
                NormalizeAxis_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NormalizeAxis");
            }

            internal static unsafe float Invoke(float Angle) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Angle;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NormalizeAxis_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct NormalizedDeltaRotator_method {
            static internal IntPtr NormalizedDeltaRotator_ptr;
            static NormalizedDeltaRotator_method() {
                NormalizedDeltaRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NormalizedDeltaRotator");
            }

            internal static unsafe Rotator Invoke(Rotator A, Rotator B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NormalizedDeltaRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+24));
            }
        }
        internal struct NormalizeToRange_method {
            static internal IntPtr NormalizeToRange_ptr;
            static NormalizeToRange_method() {
                NormalizeToRange_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NormalizeToRange");
            }

            internal static unsafe float Invoke(float Value, float RangeMin, float RangeMax) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                *((float*)(b+4)) = RangeMin;
                *((float*)(b+8)) = RangeMax;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NormalizeToRange_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct Not_Int_method {
            static internal IntPtr Not_Int_ptr;
            static Not_Int_method() {
                Not_Int_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Not_Int");
            }

            internal static unsafe int Invoke(int A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Not_Int_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct Not_PreBool_method {
            static internal IntPtr Not_PreBool_ptr;
            static Not_PreBool_method() {
                Not_PreBool_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Not_PreBool");
            }

            internal static unsafe bool Invoke(bool A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Not_PreBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct NotEqual_BoolBool_method {
            static internal IntPtr NotEqual_BoolBool_ptr;
            static NotEqual_BoolBool_method() {
                NotEqual_BoolBool_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_BoolBool");
            }

            internal static unsafe bool Invoke(bool A, bool B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = A;
                *((bool*)(b+1)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_BoolBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct NotEqual_ByteByte_method {
            static internal IntPtr NotEqual_ByteByte_ptr;
            static NotEqual_ByteByte_method() {
                NotEqual_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_ByteByte");
            }

            internal static unsafe bool Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_ByteByte_ptr, new IntPtr(p)); ;
                return *((bool*)(b+2));
            }
        }
        internal struct NotEqual_ClassClass_method {
            static internal IntPtr NotEqual_ClassClass_ptr;
            static NotEqual_ClassClass_method() {
                NotEqual_ClassClass_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_ClassClass");
            }

            internal static unsafe bool Invoke(SubclassOf<UObject> A, SubclassOf<UObject> B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = A;
                *((IntPtr*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_ClassClass_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct NotEqual_DateTimeDateTime_method {
            static internal IntPtr NotEqual_DateTimeDateTime_ptr;
            static NotEqual_DateTimeDateTime_method() {
                NotEqual_DateTimeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_DateTimeDateTime");
            }

            internal static unsafe bool Invoke(FDateTime A, FDateTime B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((FDateTime*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_DateTimeDateTime_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct NotEqual_FloatFloat_method {
            static internal IntPtr NotEqual_FloatFloat_ptr;
            static NotEqual_FloatFloat_method() {
                NotEqual_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_FloatFloat");
            }

            internal static unsafe bool Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_FloatFloat_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct NotEqual_IntInt_method {
            static internal IntPtr NotEqual_IntInt_ptr;
            static NotEqual_IntInt_method() {
                NotEqual_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_IntInt");
            }

            internal static unsafe bool Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_IntInt_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct NotEqual_NameName_method {
            static internal IntPtr NotEqual_NameName_ptr;
            static NotEqual_NameName_method() {
                NotEqual_NameName_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_NameName");
            }

            internal static unsafe bool Invoke(Name A, Name B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = A;
                *((Name*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_NameName_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct NotEqual_ObjectObject_method {
            static internal IntPtr NotEqual_ObjectObject_ptr;
            static NotEqual_ObjectObject_method() {
                NotEqual_ObjectObject_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_ObjectObject");
            }

            internal static unsafe bool Invoke(UObject A, UObject B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = A;
                *((IntPtr*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_ObjectObject_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct NotEqual_RotatorRotator_method {
            static internal IntPtr NotEqual_RotatorRotator_ptr;
            static NotEqual_RotatorRotator_method() {
                NotEqual_RotatorRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_RotatorRotator");
            }

            internal static unsafe bool Invoke(Rotator A, Rotator B, float ErrorTolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                *((float*)(b+24)) = ErrorTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_RotatorRotator_ptr, new IntPtr(p)); ;
                return *((bool*)(b+28));
            }
        }
        internal struct NotEqual_TimespanTimespan_method {
            static internal IntPtr NotEqual_TimespanTimespan_ptr;
            static NotEqual_TimespanTimespan_method() {
                NotEqual_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_TimespanTimespan");
            }

            internal static unsafe bool Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct NotEqual_Vector2DVector2D_method {
            static internal IntPtr NotEqual_Vector2DVector2D_ptr;
            static NotEqual_Vector2DVector2D_method() {
                NotEqual_Vector2DVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_Vector2DVector2D");
            }

            internal static unsafe bool Invoke(Vector2D A, Vector2D B, float ErrorTolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                *((float*)(b+16)) = ErrorTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_Vector2DVector2D_ptr, new IntPtr(p)); ;
                return *((bool*)(b+20));
            }
        }
        internal struct NotEqual_VectorVector_method {
            static internal IntPtr NotEqual_VectorVector_ptr;
            static NotEqual_VectorVector_method() {
                NotEqual_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "NotEqual_VectorVector");
            }

            internal static unsafe bool Invoke(Vector A, Vector B, float ErrorTolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                *((float*)(b+24)) = ErrorTolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, NotEqual_VectorVector_ptr, new IntPtr(p)); ;
                return *((bool*)(b+28));
            }
        }
        internal struct Now_method {
            static internal IntPtr Now_ptr;
            static Now_method() {
                Now_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Now");
            }

            internal static unsafe FDateTime Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Now_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+0));
            }
        }
        internal struct Or_IntInt_method {
            static internal IntPtr Or_IntInt_ptr;
            static Or_IntInt_method() {
                Or_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Or_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Or_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct Percent_ByteByte_method {
            static internal IntPtr Percent_ByteByte_ptr;
            static Percent_ByteByte_method() {
                Percent_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Percent_ByteByte");
            }

            internal static unsafe byte Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Percent_ByteByte_ptr, new IntPtr(p)); ;
                return *(b+2);
            }
        }
        internal struct Percent_FloatFloat_method {
            static internal IntPtr Percent_FloatFloat_ptr;
            static Percent_FloatFloat_method() {
                Percent_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Percent_FloatFloat");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Percent_FloatFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Percent_IntInt_method {
            static internal IntPtr Percent_IntInt_ptr;
            static Percent_IntInt_method() {
                Percent_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Percent_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Percent_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct PerlinNoise1D_method {
            static internal IntPtr PerlinNoise1D_ptr;
            static PerlinNoise1D_method() {
                PerlinNoise1D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "PerlinNoise1D");
            }

            internal static unsafe float Invoke(float Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Value;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, PerlinNoise1D_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct PointsAreCoplanar_method {
            static internal IntPtr PointsAreCoplanar_ptr;
            static PointsAreCoplanar_method() {
                PointsAreCoplanar_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "PointsAreCoplanar");
            }

            internal static unsafe bool Invoke(byte Points /*TODO: array TArray */, float Tolerance) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray Points
                *((float*)(b+16)) = Tolerance;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, PointsAreCoplanar_ptr, new IntPtr(p)); ;
                 //TODO: array TArray Points
                return *((bool*)(b+20));
            }
        }
        internal struct ProjectPointOnToPlane_method {
            static internal IntPtr ProjectPointOnToPlane_ptr;
            static ProjectPointOnToPlane_method() {
                ProjectPointOnToPlane_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ProjectPointOnToPlane");
            }

            internal static unsafe Vector Invoke(Vector Point, Vector PlaneBase, Vector PlaneNormal) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *((Vector*)(b+12)) = PlaneBase;
                *((Vector*)(b+24)) = PlaneNormal;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ProjectPointOnToPlane_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+36));
            }
        }
        internal struct ProjectVectorOnToPlane_method {
            static internal IntPtr ProjectVectorOnToPlane_ptr;
            static ProjectVectorOnToPlane_method() {
                ProjectVectorOnToPlane_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ProjectVectorOnToPlane");
            }

            internal static unsafe Vector Invoke(Vector V, Vector PlaneNormal) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = V;
                *((Vector*)(b+12)) = PlaneNormal;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ProjectVectorOnToPlane_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct ProjectVectorOnToVector_method {
            static internal IntPtr ProjectVectorOnToVector_ptr;
            static ProjectVectorOnToVector_method() {
                ProjectVectorOnToVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ProjectVectorOnToVector");
            }

            internal static unsafe Vector Invoke(Vector V, Vector Target) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = V;
                *((Vector*)(b+12)) = Target;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ProjectVectorOnToVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct RadiansToDegrees_method {
            static internal IntPtr RadiansToDegrees_ptr;
            static RadiansToDegrees_method() {
                RadiansToDegrees_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RadiansToDegrees");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RadiansToDegrees_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct RandomBool_method {
            static internal IntPtr RandomBool_ptr;
            static RandomBool_method() {
                RandomBool_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomBool");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct RandomBoolFromStream_method {
            static internal IntPtr RandomBoolFromStream_ptr;
            static RandomBoolFromStream_method() {
                RandomBoolFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomBoolFromStream");
            }

            internal static unsafe bool Invoke(RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((RandomStream*)(b+0)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomBoolFromStream_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct RandomBoolWithWeight_method {
            static internal IntPtr RandomBoolWithWeight_ptr;
            static RandomBoolWithWeight_method() {
                RandomBoolWithWeight_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomBoolWithWeight");
            }

            internal static unsafe bool Invoke(float Weight) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Weight;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomBoolWithWeight_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct RandomBoolWithWeightFromStream_method {
            static internal IntPtr RandomBoolWithWeightFromStream_ptr;
            static RandomBoolWithWeightFromStream_method() {
                RandomBoolWithWeightFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomBoolWithWeightFromStream");
            }

            internal static unsafe bool Invoke(float Weight, RandomStream RandomStream) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Weight;
                *((RandomStream*)(b+4)) = RandomStream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomBoolWithWeightFromStream_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct RandomFloat_method {
            static internal IntPtr RandomFloat_ptr;
            static RandomFloat_method() {
                RandomFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomFloat");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct RandomFloatFromStream_method {
            static internal IntPtr RandomFloatFromStream_ptr;
            static RandomFloatFromStream_method() {
                RandomFloatFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomFloatFromStream");
            }

            internal static unsafe float Invoke(RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((RandomStream*)(b+0)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomFloatFromStream_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct RandomFloatInRange_method {
            static internal IntPtr RandomFloatInRange_ptr;
            static RandomFloatInRange_method() {
                RandomFloatInRange_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomFloatInRange");
            }

            internal static unsafe float Invoke(float Min, float Max) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Min;
                *((float*)(b+4)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomFloatInRange_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct RandomFloatInRangeFromStream_method {
            static internal IntPtr RandomFloatInRangeFromStream_ptr;
            static RandomFloatInRangeFromStream_method() {
                RandomFloatInRangeFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomFloatInRangeFromStream");
            }

            internal static unsafe float Invoke(float Min, float Max, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Min;
                *((float*)(b+4)) = Max;
                *((RandomStream*)(b+8)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomFloatInRangeFromStream_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct RandomInteger_method {
            static internal IntPtr RandomInteger_ptr;
            static RandomInteger_method() {
                RandomInteger_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomInteger");
            }

            internal static unsafe int Invoke(int Max) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomInteger_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct RandomIntegerFromStream_method {
            static internal IntPtr RandomIntegerFromStream_ptr;
            static RandomIntegerFromStream_method() {
                RandomIntegerFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomIntegerFromStream");
            }

            internal static unsafe int Invoke(int Max, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Max;
                *((RandomStream*)(b+4)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomIntegerFromStream_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct RandomIntegerInRange_method {
            static internal IntPtr RandomIntegerInRange_ptr;
            static RandomIntegerInRange_method() {
                RandomIntegerInRange_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomIntegerInRange");
            }

            internal static unsafe int Invoke(int Min, int Max) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Min;
                *((int*)(b+4)) = Max;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomIntegerInRange_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct RandomIntegerInRangeFromStream_method {
            static internal IntPtr RandomIntegerInRangeFromStream_ptr;
            static RandomIntegerInRangeFromStream_method() {
                RandomIntegerInRangeFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomIntegerInRangeFromStream");
            }

            internal static unsafe int Invoke(int Min, int Max, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Min;
                *((int*)(b+4)) = Max;
                *((RandomStream*)(b+8)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomIntegerInRangeFromStream_ptr, new IntPtr(p)); ;
                return *((int*)(b+16));
            }
        }
        internal struct RandomPointInBoundingBox_method {
            static internal IntPtr RandomPointInBoundingBox_ptr;
            static RandomPointInBoundingBox_method() {
                RandomPointInBoundingBox_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomPointInBoundingBox");
            }

            internal static unsafe Vector Invoke(Vector Origin, Vector BoxExtent) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Origin;
                *((Vector*)(b+12)) = BoxExtent;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomPointInBoundingBox_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct RandomRotator_method {
            static internal IntPtr RandomRotator_ptr;
            static RandomRotator_method() {
                RandomRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomRotator");
            }

            internal static unsafe Rotator Invoke(bool bRoll) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bRoll;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+4));
            }
        }
        internal struct RandomRotatorFromStream_method {
            static internal IntPtr RandomRotatorFromStream_ptr;
            static RandomRotatorFromStream_method() {
                RandomRotatorFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomRotatorFromStream");
            }

            internal static unsafe Rotator Invoke(bool bRoll, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bRoll;
                *((RandomStream*)(b+4)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomRotatorFromStream_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct RandomUnitVector_method {
            static internal IntPtr RandomUnitVector_ptr;
            static RandomUnitVector_method() {
                RandomUnitVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVector");
            }

            internal static unsafe Vector Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct RandomUnitVectorFromStream_method {
            static internal IntPtr RandomUnitVectorFromStream_ptr;
            static RandomUnitVectorFromStream_method() {
                RandomUnitVectorFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorFromStream");
            }

            internal static unsafe Vector Invoke(RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((RandomStream*)(b+0)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorFromStream_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct RandomUnitVectorInConeInDegrees_method {
            static internal IntPtr RandomUnitVectorInConeInDegrees_ptr;
            static RandomUnitVectorInConeInDegrees_method() {
                RandomUnitVectorInConeInDegrees_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInConeInDegrees");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float ConeHalfAngleInDegrees) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = ConeHalfAngleInDegrees;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInConeInDegrees_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct RandomUnitVectorInConeInDegreesFromStream_method {
            static internal IntPtr RandomUnitVectorInConeInDegreesFromStream_ptr;
            static RandomUnitVectorInConeInDegreesFromStream_method() {
                RandomUnitVectorInConeInDegreesFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInConeInDegreesFromStream");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float ConeHalfAngleInDegrees, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = ConeHalfAngleInDegrees;
                *((RandomStream*)(b+16)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInConeInDegreesFromStream_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct RandomUnitVectorInConeInRadians_method {
            static internal IntPtr RandomUnitVectorInConeInRadians_ptr;
            static RandomUnitVectorInConeInRadians_method() {
                RandomUnitVectorInConeInRadians_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInConeInRadians");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float ConeHalfAngleInRadians) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = ConeHalfAngleInRadians;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInConeInRadians_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct RandomUnitVectorInConeInRadiansFromStream_method {
            static internal IntPtr RandomUnitVectorInConeInRadiansFromStream_ptr;
            static RandomUnitVectorInConeInRadiansFromStream_method() {
                RandomUnitVectorInConeInRadiansFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInConeInRadiansFromStream");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float ConeHalfAngleInRadians, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = ConeHalfAngleInRadians;
                *((RandomStream*)(b+16)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInConeInRadiansFromStream_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct RandomUnitVectorInEllipticalConeInDegrees_method {
            static internal IntPtr RandomUnitVectorInEllipticalConeInDegrees_ptr;
            static RandomUnitVectorInEllipticalConeInDegrees_method() {
                RandomUnitVectorInEllipticalConeInDegrees_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInEllipticalConeInDegrees");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = MaxYawInDegrees;
                *((float*)(b+16)) = MaxPitchInDegrees;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInEllipticalConeInDegrees_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+20));
            }
        }
        internal struct RandomUnitVectorInEllipticalConeInDegreesFromStream_method {
            static internal IntPtr RandomUnitVectorInEllipticalConeInDegreesFromStream_ptr;
            static RandomUnitVectorInEllipticalConeInDegreesFromStream_method() {
                RandomUnitVectorInEllipticalConeInDegreesFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInEllipticalConeInDegreesFromStream");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = MaxYawInDegrees;
                *((float*)(b+16)) = MaxPitchInDegrees;
                *((RandomStream*)(b+20)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInEllipticalConeInDegreesFromStream_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+28));
            }
        }
        internal struct RandomUnitVectorInEllipticalConeInRadians_method {
            static internal IntPtr RandomUnitVectorInEllipticalConeInRadians_ptr;
            static RandomUnitVectorInEllipticalConeInRadians_method() {
                RandomUnitVectorInEllipticalConeInRadians_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInEllipticalConeInRadians");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float MaxYawInRadians, float MaxPitchInRadians) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = MaxYawInRadians;
                *((float*)(b+16)) = MaxPitchInRadians;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInEllipticalConeInRadians_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+20));
            }
        }
        internal struct RandomUnitVectorInEllipticalConeInRadiansFromStream_method {
            static internal IntPtr RandomUnitVectorInEllipticalConeInRadiansFromStream_ptr;
            static RandomUnitVectorInEllipticalConeInRadiansFromStream_method() {
                RandomUnitVectorInEllipticalConeInRadiansFromStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RandomUnitVectorInEllipticalConeInRadiansFromStream");
            }

            internal static unsafe Vector Invoke(Vector ConeDir, float MaxYawInRadians, float MaxPitchInRadians, RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = ConeDir;
                *((float*)(b+12)) = MaxYawInRadians;
                *((float*)(b+16)) = MaxPitchInRadians;
                *((RandomStream*)(b+20)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RandomUnitVectorInEllipticalConeInRadiansFromStream_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+28));
            }
        }
        internal struct REase_method {
            static internal IntPtr REase_ptr;
            static REase_method() {
                REase_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "REase");
            }

            internal static unsafe Rotator Invoke(Rotator A, Rotator B, float Alpha, bool bShortestPath, byte EasingFunc, float BlendExp, int Steps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                *((float*)(b+24)) = Alpha;
                *((bool*)(b+28)) = bShortestPath;
                *(b+29) = EasingFunc;
                *((float*)(b+32)) = BlendExp;
                *((int*)(b+36)) = Steps;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, REase_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+40));
            }
        }
        internal struct ResetFloatSpringState_method {
            static internal IntPtr ResetFloatSpringState_ptr;
            static ResetFloatSpringState_method() {
                ResetFloatSpringState_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ResetFloatSpringState");
            }

            internal static unsafe void Invoke(FloatSpringState SpringState) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((FloatSpringState*)(b+0)) = SpringState;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ResetFloatSpringState_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetRandomStream_method {
            static internal IntPtr ResetRandomStream_ptr;
            static ResetRandomStream_method() {
                ResetRandomStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ResetRandomStream");
            }

            internal static unsafe void Invoke(RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((RandomStream*)(b+0)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ResetRandomStream_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetVectorSpringState_method {
            static internal IntPtr ResetVectorSpringState_ptr;
            static ResetVectorSpringState_method() {
                ResetVectorSpringState_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "ResetVectorSpringState");
            }

            internal static unsafe void Invoke(VectorSpringState SpringState) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((VectorSpringState*)(b+0)) = SpringState;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, ResetVectorSpringState_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RGBToHSV_method {
            static internal IntPtr RGBToHSV_ptr;
            static RGBToHSV_method() {
                RGBToHSV_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RGBToHSV");
            }

            internal static unsafe (float, float, float, float) Invoke(LinearColor InColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColor;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RGBToHSV_ptr, new IntPtr(p)); ;
                return (*((float*)(b+16)),*((float*)(b+20)),*((float*)(b+24)),*((float*)(b+28)));
            }
        }
        internal struct RGBToHSV_Vector_method {
            static internal IntPtr RGBToHSV_Vector_ptr;
            static RGBToHSV_Vector_method() {
                RGBToHSV_Vector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RGBToHSV_Vector");
            }

            internal static unsafe LinearColor Invoke(LinearColor RGB) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = RGB;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RGBToHSV_Vector_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+16));
            }
        }
        internal struct RInterpTo_method {
            static internal IntPtr RInterpTo_ptr;
            static RInterpTo_method() {
                RInterpTo_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RInterpTo");
            }

            internal static unsafe Rotator Invoke(Rotator Current, Rotator Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Current;
                *((Rotator*)(b+12)) = Target;
                *((float*)(b+24)) = DeltaTime;
                *((float*)(b+28)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RInterpTo_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+32));
            }
        }
        internal struct RInterpTo_Constant_method {
            static internal IntPtr RInterpTo_Constant_ptr;
            static RInterpTo_Constant_method() {
                RInterpTo_Constant_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RInterpTo_Constant");
            }

            internal static unsafe Rotator Invoke(Rotator Current, Rotator Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Current;
                *((Rotator*)(b+12)) = Target;
                *((float*)(b+24)) = DeltaTime;
                *((float*)(b+28)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RInterpTo_Constant_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+32));
            }
        }
        internal struct RLerp_method {
            static internal IntPtr RLerp_ptr;
            static RLerp_method() {
                RLerp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RLerp");
            }

            internal static unsafe Rotator Invoke(Rotator A, Rotator B, float Alpha, bool bShortestPath) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                *((float*)(b+24)) = Alpha;
                *((bool*)(b+28)) = bShortestPath;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RLerp_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+32));
            }
        }
        internal struct RotateAngleAxis_method {
            static internal IntPtr RotateAngleAxis_ptr;
            static RotateAngleAxis_method() {
                RotateAngleAxis_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RotateAngleAxis");
            }

            internal static unsafe Vector Invoke(Vector InVect, float AngleDeg, Vector Axis) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVect;
                *((float*)(b+12)) = AngleDeg;
                *((Vector*)(b+16)) = Axis;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RotateAngleAxis_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+28));
            }
        }
        internal struct RotatorFromAxisAndAngle_method {
            static internal IntPtr RotatorFromAxisAndAngle_ptr;
            static RotatorFromAxisAndAngle_method() {
                RotatorFromAxisAndAngle_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "RotatorFromAxisAndAngle");
            }

            internal static unsafe Rotator Invoke(Vector Axis, float Angle) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Axis;
                *((float*)(b+12)) = Angle;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, RotatorFromAxisAndAngle_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+16));
            }
        }
        internal struct Round_method {
            static internal IntPtr Round_ptr;
            static Round_method() {
                Round_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Round");
            }

            internal static unsafe int Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Round_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct SeedRandomStream_method {
            static internal IntPtr SeedRandomStream_ptr;
            static SeedRandomStream_method() {
                SeedRandomStream_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SeedRandomStream");
            }

            internal static unsafe void Invoke(RandomStream Stream) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((RandomStream*)(b+0)) = Stream;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SeedRandomStream_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SelectClass_method {
            static internal IntPtr SelectClass_ptr;
            static SelectClass_method() {
                SelectClass_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectClass");
            }

            internal static unsafe SubclassOf<UObject> Invoke(SubclassOf<UObject> A, SubclassOf<UObject> B, bool bSelectA) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = A;
                *((IntPtr*)(b+8)) = B;
                *((bool*)(b+16)) = bSelectA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct SelectColor_method {
            static internal IntPtr SelectColor_ptr;
            static SelectColor_method() {
                SelectColor_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectColor");
            }

            internal static unsafe LinearColor Invoke(LinearColor A, LinearColor B, bool bPickA) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = A;
                *((LinearColor*)(b+16)) = B;
                *((bool*)(b+32)) = bPickA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+36));
            }
        }
        internal struct SelectFloat_method {
            static internal IntPtr SelectFloat_ptr;
            static SelectFloat_method() {
                SelectFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectFloat");
            }

            internal static unsafe float Invoke(float A, float B, bool bPickA) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                *((bool*)(b+8)) = bPickA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct SelectInt_method {
            static internal IntPtr SelectInt_ptr;
            static SelectInt_method() {
                SelectInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectInt");
            }

            internal static unsafe int Invoke(int A, int B, bool bPickA) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                *((bool*)(b+8)) = bPickA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct SelectObject_method {
            static internal IntPtr SelectObject_ptr;
            static SelectObject_method() {
                SelectObject_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectObject");
            }

            internal static unsafe UObject Invoke(UObject A, UObject B, bool bSelectA) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = A;
                *((IntPtr*)(b+8)) = B;
                *((bool*)(b+16)) = bSelectA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct SelectRotator_method {
            static internal IntPtr SelectRotator_ptr;
            static SelectRotator_method() {
                SelectRotator_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectRotator");
            }

            internal static unsafe Rotator Invoke(Rotator A, Rotator B, bool bPickA) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = A;
                *((Rotator*)(b+12)) = B;
                *((bool*)(b+24)) = bPickA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+28));
            }
        }
        internal struct SelectString_method {
            static internal IntPtr SelectString_ptr;
            static SelectString_method() {
                SelectString_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectString");
            }

            internal static unsafe string Invoke(string A, string B, bool bPickA) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var A_handle = GCHandle.Alloc(A, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = A_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = A.Length;
                *(int*)(b+IntPtr.Size+4+0) = A.Length;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = B.Length;
                *(int*)(b+IntPtr.Size+4+16) = B.Length;
                *((bool*)(b+32)) = bPickA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectString_ptr, new IntPtr(p)); ;
                A_handle.Free();
                B_handle.Free();
                return FString.Get(b+40);
            }
        }
        internal struct SelectTransform_method {
            static internal IntPtr SelectTransform_ptr;
            static SelectTransform_method() {
                SelectTransform_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectTransform");
            }

            internal static unsafe Transform Invoke(Transform A, Transform B, bool bPickA) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = A;
                *((Transform*)(b+48)) = B;
                *((bool*)(b+96)) = bPickA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+112));
            }
        }
        internal struct SelectVector_method {
            static internal IntPtr SelectVector_ptr;
            static SelectVector_method() {
                SelectVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SelectVector");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B, bool bPickA) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                *((bool*)(b+24)) = bPickA;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SelectVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+28));
            }
        }
        internal struct SetRandomStreamSeed_method {
            static internal IntPtr SetRandomStreamSeed_ptr;
            static SetRandomStreamSeed_method() {
                SetRandomStreamSeed_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SetRandomStreamSeed");
            }

            internal static unsafe void Invoke(RandomStream Stream, int NewSeed) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((RandomStream*)(b+0)) = Stream;
                *((int*)(b+8)) = NewSeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SetRandomStreamSeed_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SignOfFloat_method {
            static internal IntPtr SignOfFloat_ptr;
            static SignOfFloat_method() {
                SignOfFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SignOfFloat");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SignOfFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct SignOfInteger_method {
            static internal IntPtr SignOfInteger_ptr;
            static SignOfInteger_method() {
                SignOfInteger_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "SignOfInteger");
            }

            internal static unsafe int Invoke(int A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, SignOfInteger_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
        internal struct Sin_method {
            static internal IntPtr Sin_ptr;
            static Sin_method() {
                Sin_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Sin");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Sin_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Sqrt_method {
            static internal IntPtr Sqrt_ptr;
            static Sqrt_method() {
                Sqrt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Sqrt");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Sqrt_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Square_method {
            static internal IntPtr Square_ptr;
            static Square_method() {
                Square_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Square");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Square_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct Subtract_ByteByte_method {
            static internal IntPtr Subtract_ByteByte_ptr;
            static Subtract_ByteByte_method() {
                Subtract_ByteByte_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_ByteByte");
            }

            internal static unsafe byte Invoke(byte A, byte B) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = A;
                *(b+1) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_ByteByte_ptr, new IntPtr(p)); ;
                return *(b+2);
            }
        }
        internal struct Subtract_DateTimeDateTime_method {
            static internal IntPtr Subtract_DateTimeDateTime_ptr;
            static Subtract_DateTimeDateTime_method() {
                Subtract_DateTimeDateTime_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_DateTimeDateTime");
            }

            internal static unsafe Timespan Invoke(FDateTime A, FDateTime B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((FDateTime*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_DateTimeDateTime_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+16));
            }
        }
        internal struct Subtract_DateTimeTimespan_method {
            static internal IntPtr Subtract_DateTimeTimespan_ptr;
            static Subtract_DateTimeTimespan_method() {
                Subtract_DateTimeTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_DateTimeTimespan");
            }

            internal static unsafe FDateTime Invoke(FDateTime A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FDateTime*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_DateTimeTimespan_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+16));
            }
        }
        internal struct Subtract_FloatFloat_method {
            static internal IntPtr Subtract_FloatFloat_ptr;
            static Subtract_FloatFloat_method() {
                Subtract_FloatFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_FloatFloat");
            }

            internal static unsafe float Invoke(float A, float B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                *((float*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_FloatFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Subtract_IntInt_method {
            static internal IntPtr Subtract_IntInt_ptr;
            static Subtract_IntInt_method() {
                Subtract_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct Subtract_TimespanTimespan_method {
            static internal IntPtr Subtract_TimespanTimespan_ptr;
            static Subtract_TimespanTimespan_method() {
                Subtract_TimespanTimespan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_TimespanTimespan");
            }

            internal static unsafe Timespan Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_TimespanTimespan_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+16));
            }
        }
        internal struct Subtract_Vector2DFloat_method {
            static internal IntPtr Subtract_Vector2DFloat_ptr;
            static Subtract_Vector2DFloat_method() {
                Subtract_Vector2DFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_Vector2DFloat");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((float*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_Vector2DFloat_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+12));
            }
        }
        internal struct Subtract_Vector2DVector2D_method {
            static internal IntPtr Subtract_Vector2DVector2D_ptr;
            static Subtract_Vector2DVector2D_method() {
                Subtract_Vector2DVector2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_Vector2DVector2D");
            }

            internal static unsafe Vector2D Invoke(Vector2D A, Vector2D B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                *((Vector2D*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_Vector2DVector2D_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+16));
            }
        }
        internal struct Subtract_VectorFloat_method {
            static internal IntPtr Subtract_VectorFloat_ptr;
            static Subtract_VectorFloat_method() {
                Subtract_VectorFloat_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_VectorFloat");
            }

            internal static unsafe Vector Invoke(Vector A, float B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((float*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_VectorFloat_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Subtract_VectorInt_method {
            static internal IntPtr Subtract_VectorInt_ptr;
            static Subtract_VectorInt_method() {
                Subtract_VectorInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_VectorInt");
            }

            internal static unsafe Vector Invoke(Vector A, int B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((int*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_VectorInt_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+16));
            }
        }
        internal struct Subtract_VectorVector_method {
            static internal IntPtr Subtract_VectorVector_ptr;
            static Subtract_VectorVector_method() {
                Subtract_VectorVector_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Subtract_VectorVector");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Subtract_VectorVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+24));
            }
        }
        internal struct Tan_method {
            static internal IntPtr Tan_ptr;
            static Tan_method() {
                Tan_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Tan");
            }

            internal static unsafe float Invoke(float A) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Tan_ptr, new IntPtr(p)); ;
                return *((float*)(b+4));
            }
        }
        internal struct TEase_method {
            static internal IntPtr TEase_ptr;
            static TEase_method() {
                TEase_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TEase");
            }

            internal static unsafe Transform Invoke(Transform A, Transform B, float Alpha, byte EasingFunc, float BlendExp, int Steps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = A;
                *((Transform*)(b+48)) = B;
                *((float*)(b+96)) = Alpha;
                *(b+100) = EasingFunc;
                *((float*)(b+104)) = BlendExp;
                *((int*)(b+108)) = Steps;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TEase_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+112));
            }
        }
        internal struct TimespanFromString_method {
            static internal IntPtr TimespanFromString_ptr;
            static TimespanFromString_method() {
                TimespanFromString_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TimespanFromString");
            }

            internal static unsafe (Timespan, bool) Invoke(string TimespanString) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var TimespanString_handle = GCHandle.Alloc(TimespanString, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = TimespanString_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = TimespanString.Length;
                *(int*)(b+IntPtr.Size+4+0) = TimespanString.Length;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TimespanFromString_ptr, new IntPtr(p)); ;
                TimespanString_handle.Free();
                return (*((Timespan*)(b+16)),*((bool*)(b+24)));
            }
        }
        internal struct TimespanMaxValue_method {
            static internal IntPtr TimespanMaxValue_ptr;
            static TimespanMaxValue_method() {
                TimespanMaxValue_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TimespanMaxValue");
            }

            internal static unsafe Timespan Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TimespanMaxValue_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+0));
            }
        }
        internal struct TimespanMinValue_method {
            static internal IntPtr TimespanMinValue_ptr;
            static TimespanMinValue_method() {
                TimespanMinValue_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TimespanMinValue");
            }

            internal static unsafe Timespan Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TimespanMinValue_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+0));
            }
        }
        internal struct TimespanRatio_method {
            static internal IntPtr TimespanRatio_ptr;
            static TimespanRatio_method() {
                TimespanRatio_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TimespanRatio");
            }

            internal static unsafe float Invoke(Timespan A, Timespan B) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timespan*)(b+0)) = A;
                *((Timespan*)(b+8)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TimespanRatio_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct TimespanZeroValue_method {
            static internal IntPtr TimespanZeroValue_ptr;
            static TimespanZeroValue_method() {
                TimespanZeroValue_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TimespanZeroValue");
            }

            internal static unsafe Timespan Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TimespanZeroValue_ptr, new IntPtr(p)); ;
                return *((Timespan*)(b+0));
            }
        }
        internal struct TInterpTo_method {
            static internal IntPtr TInterpTo_ptr;
            static TInterpTo_method() {
                TInterpTo_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TInterpTo");
            }

            internal static unsafe Transform Invoke(Transform Current, Transform Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = Current;
                *((Transform*)(b+48)) = Target;
                *((float*)(b+96)) = DeltaTime;
                *((float*)(b+100)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TInterpTo_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+112));
            }
        }
        internal struct TLerp_method {
            static internal IntPtr TLerp_ptr;
            static TLerp_method() {
                TLerp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TLerp");
            }

            internal static unsafe Transform Invoke(Transform A, Transform B, float Alpha, byte InterpMode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = A;
                *((Transform*)(b+48)) = B;
                *((float*)(b+96)) = Alpha;
                *(b+100) = InterpMode;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TLerp_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+112));
            }
        }
        internal struct Today_method {
            static internal IntPtr Today_ptr;
            static Today_method() {
                Today_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Today");
            }

            internal static unsafe FDateTime Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Today_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+0));
            }
        }
        internal struct Transform_Determinant_method {
            static internal IntPtr Transform_Determinant_ptr;
            static Transform_Determinant_method() {
                Transform_Determinant_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Transform_Determinant");
            }

            internal static unsafe float Invoke(Transform Transform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = Transform;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Transform_Determinant_ptr, new IntPtr(p)); ;
                return *((float*)(b+48));
            }
        }
        internal struct TransformDirection_method {
            static internal IntPtr TransformDirection_ptr;
            static TransformDirection_method() {
                TransformDirection_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TransformDirection");
            }

            internal static unsafe Vector Invoke(Transform T, Vector Direction) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = T;
                *((Vector*)(b+48)) = Direction;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TransformDirection_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+60));
            }
        }
        internal struct TransformLocation_method {
            static internal IntPtr TransformLocation_ptr;
            static TransformLocation_method() {
                TransformLocation_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TransformLocation");
            }

            internal static unsafe Vector Invoke(Transform T, Vector Location) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = T;
                *((Vector*)(b+48)) = Location;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TransformLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+60));
            }
        }
        internal struct TransformRotation_method {
            static internal IntPtr TransformRotation_ptr;
            static TransformRotation_method() {
                TransformRotation_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "TransformRotation");
            }

            internal static unsafe Rotator Invoke(Transform T, Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = T;
                *((Rotator*)(b+48)) = Rotation;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, TransformRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+60));
            }
        }
        internal struct UtcNow_method {
            static internal IntPtr UtcNow_ptr;
            static UtcNow_method() {
                UtcNow_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "UtcNow");
            }

            internal static unsafe FDateTime Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, UtcNow_ptr, new IntPtr(p)); ;
                return *((FDateTime*)(b+0));
            }
        }
        internal struct VEase_method {
            static internal IntPtr VEase_ptr;
            static VEase_method() {
                VEase_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VEase");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B, float Alpha, byte EasingFunc, float BlendExp, int Steps) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                *((float*)(b+24)) = Alpha;
                *(b+28) = EasingFunc;
                *((float*)(b+32)) = BlendExp;
                *((int*)(b+36)) = Steps;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VEase_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+40));
            }
        }
        internal struct Vector2DInterpTo_method {
            static internal IntPtr Vector2DInterpTo_ptr;
            static Vector2DInterpTo_method() {
                Vector2DInterpTo_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Vector2DInterpTo");
            }

            internal static unsafe Vector2D Invoke(Vector2D Current, Vector2D Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Current;
                *((Vector2D*)(b+8)) = Target;
                *((float*)(b+16)) = DeltaTime;
                *((float*)(b+20)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Vector2DInterpTo_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+24));
            }
        }
        internal struct Vector2DInterpTo_Constant_method {
            static internal IntPtr Vector2DInterpTo_Constant_ptr;
            static Vector2DInterpTo_Constant_method() {
                Vector2DInterpTo_Constant_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Vector2DInterpTo_Constant");
            }

            internal static unsafe Vector2D Invoke(Vector2D Current, Vector2D Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Current;
                *((Vector2D*)(b+8)) = Target;
                *((float*)(b+16)) = DeltaTime;
                *((float*)(b+20)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Vector2DInterpTo_Constant_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+24));
            }
        }
        internal struct VectorSpringInterp_method {
            static internal IntPtr VectorSpringInterp_ptr;
            static VectorSpringInterp_method() {
                VectorSpringInterp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VectorSpringInterp");
            }

            internal static unsafe Vector Invoke(Vector Current, Vector Target, VectorSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Current;
                *((Vector*)(b+12)) = Target;
                *((VectorSpringState*)(b+24)) = SpringState;
                *((float*)(b+48)) = Stiffness;
                *((float*)(b+52)) = CriticalDampingFactor;
                *((float*)(b+56)) = DeltaTime;
                *((float*)(b+60)) = Mass;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VectorSpringInterp_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+64));
            }
        }
        internal struct VInterpTo_method {
            static internal IntPtr VInterpTo_ptr;
            static VInterpTo_method() {
                VInterpTo_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VInterpTo");
            }

            internal static unsafe Vector Invoke(Vector Current, Vector Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Current;
                *((Vector*)(b+12)) = Target;
                *((float*)(b+24)) = DeltaTime;
                *((float*)(b+28)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VInterpTo_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+32));
            }
        }
        internal struct VInterpTo_Constant_method {
            static internal IntPtr VInterpTo_Constant_ptr;
            static VInterpTo_Constant_method() {
                VInterpTo_Constant_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VInterpTo_Constant");
            }

            internal static unsafe Vector Invoke(Vector Current, Vector Target, float DeltaTime, float InterpSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Current;
                *((Vector*)(b+12)) = Target;
                *((float*)(b+24)) = DeltaTime;
                *((float*)(b+28)) = InterpSpeed;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VInterpTo_Constant_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+32));
            }
        }
        internal struct VLerp_method {
            static internal IntPtr VLerp_ptr;
            static VLerp_method() {
                VLerp_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VLerp");
            }

            internal static unsafe Vector Invoke(Vector A, Vector B, float Alpha) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                *((Vector*)(b+12)) = B;
                *((float*)(b+24)) = Alpha;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VLerp_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+28));
            }
        }
        internal struct VSize_method {
            static internal IntPtr VSize_ptr;
            static VSize_method() {
                VSize_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VSize");
            }

            internal static unsafe float Invoke(Vector A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VSize_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct VSize2D_method {
            static internal IntPtr VSize2D_ptr;
            static VSize2D_method() {
                VSize2D_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VSize2D");
            }

            internal static unsafe float Invoke(Vector2D A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VSize2D_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct VSize2DSquared_method {
            static internal IntPtr VSize2DSquared_ptr;
            static VSize2DSquared_method() {
                VSize2DSquared_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VSize2DSquared");
            }

            internal static unsafe float Invoke(Vector2D A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VSize2DSquared_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct VSizeSquared_method {
            static internal IntPtr VSizeSquared_ptr;
            static VSizeSquared_method() {
                VSizeSquared_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VSizeSquared");
            }

            internal static unsafe float Invoke(Vector A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VSizeSquared_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct VSizeXY_method {
            static internal IntPtr VSizeXY_ptr;
            static VSizeXY_method() {
                VSizeXY_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "VSizeXY");
            }

            internal static unsafe float Invoke(Vector A) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = A;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, VSizeXY_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct Xor_IntInt_method {
            static internal IntPtr Xor_IntInt_ptr;
            static Xor_IntInt_method() {
                Xor_IntInt_ptr = Main.GetMethodUFunction(KismetMathLibrary.StaticClass, "Xor_IntInt");
            }

            internal static unsafe int Invoke(int A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(KismetMathLibrary.DefaultObject, Xor_IntInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
    }
    internal unsafe struct KismetMathLibrary_events {
    }
}
