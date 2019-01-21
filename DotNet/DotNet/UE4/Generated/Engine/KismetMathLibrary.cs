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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Kismet Math Library</summary>
    public unsafe partial class KismetMathLibrary : BlueprintFunctionLibrary  {

        ///<summary>Returns the absolute (positive) value of A</summary>
        public static float Abs(float A)  => 
            KismetMathLibrary_methods.Abs_method.Invoke(A);

        ///<summary>Returns the absolute (positive) value of A</summary>
        public static int Abs_Int(int A)  => 
            KismetMathLibrary_methods.Abs_Int_method.Invoke(A);

        ///<summary>Returns the inverse cosine (arccos) of A (result is in Radians)</summary>
        public static float Acos(float A)  => 
            KismetMathLibrary_methods.Acos_method.Invoke(A);

        ///<summary>Addition (A + B)</summary>
        public static byte Add_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.Add_ByteByte_method.Invoke(A, B);

        ///<summary>Addition (A + B)</summary>
        public static FDateTime Add_DateTimeTimespan(FDateTime A, Timespan B)  => 
            KismetMathLibrary_methods.Add_DateTimeTimespan_method.Invoke(A, B);

        ///<summary>Addition (A + B)</summary>
        public static float Add_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.Add_FloatFloat_method.Invoke(A, B);

        ///<summary>Addition (A + B)</summary>
        public static int Add_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Add_IntInt_method.Invoke(A, B);

        ///<summary>Addition (A + B)</summary>
        public static Timespan Add_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.Add_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns Vector A added by B</summary>
        public static Vector2D Add_Vector2DFloat(Vector2D A, float B)  => 
            KismetMathLibrary_methods.Add_Vector2DFloat_method.Invoke(A, B);

        ///<summary>Returns addition of Vector A and Vector B (A + B)</summary>
        public static Vector2D Add_Vector2DVector2D(Vector2D A, Vector2D B)  => 
            KismetMathLibrary_methods.Add_Vector2DVector2D_method.Invoke(A, B);

        ///<summary>Adds a float to each component of a vector</summary>
        public static Vector Add_VectorFloat(Vector A, float B)  => 
            KismetMathLibrary_methods.Add_VectorFloat_method.Invoke(A, B);

        ///<summary>Adds an integer to each component of a vector</summary>
        public static Vector Add_VectorInt(Vector A, int B)  => 
            KismetMathLibrary_methods.Add_VectorInt_method.Invoke(A, B);

        ///<summary>Vector addition</summary>
        public static Vector Add_VectorVector(Vector A, Vector B)  => 
            KismetMathLibrary_methods.Add_VectorVector_method.Invoke(A, B);

        ///<summary>Bitwise AND (A & B)</summary>
        public static int And_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.And_IntInt_method.Invoke(A, B);

        ///<summary>Returns the inverse sine (arcsin) of A (result is in Radians)</summary>
        public static float Asin(float A)  => 
            KismetMathLibrary_methods.Asin_method.Invoke(A);

        ///<summary>Returns the inverse tan (atan) (result is in Radians)</summary>
        public static float Atan(float A)  => 
            KismetMathLibrary_methods.Atan_method.Invoke(A);

        ///<summary>Returns the inverse tan (atan2) of A/B (result is in Radians)</summary>
        public static float Atan2(float A, float B)  => 
            KismetMathLibrary_methods.Atan2_method.Invoke(A, B);

        ///<summary>Returns the maximum value of A and B</summary>
        public static byte BMax(byte A, byte B)  => 
            KismetMathLibrary_methods.BMax_method.Invoke(A, B);

        ///<summary>Returns the minimum value of A and B</summary>
        public static byte BMin(byte A, byte B)  => 
            KismetMathLibrary_methods.BMin_method.Invoke(A, B);

        ///<summary>Returns the logical AND of two values (A AND B)</summary>
        public static bool BooleanAND(bool A, bool B)  => 
            KismetMathLibrary_methods.BooleanAND_method.Invoke(A, B);

        ///<summary>Returns the logical NAND of two values (A AND B)</summary>
        public static bool BooleanNAND(bool A, bool B)  => 
            KismetMathLibrary_methods.BooleanNAND_method.Invoke(A, B);

        ///<summary>Returns the logical Not OR of two values (A NOR B)</summary>
        public static bool BooleanNOR(bool A, bool B)  => 
            KismetMathLibrary_methods.BooleanNOR_method.Invoke(A, B);

        ///<summary>Returns the logical OR of two values (A OR B)</summary>
        public static bool BooleanOR(bool A, bool B)  => 
            KismetMathLibrary_methods.BooleanOR_method.Invoke(A, B);

        ///<summary>Returns the logical eXclusive OR of two values (A XOR B)</summary>
        public static bool BooleanXOR(bool A, bool B)  => 
            KismetMathLibrary_methods.BooleanXOR_method.Invoke(A, B);

        ///<summary>Breaks apart a color into individual RGB components (as well as alpha)</summary>
        public static (float, float, float, float) BreakColor(LinearColor InColor)  => 
            KismetMathLibrary_methods.BreakColor_method.Invoke(InColor);

        ///<summary>Breaks a DateTime into its components</summary>
        public static (int, int, int, int, int, int, int) BreakDateTime(FDateTime InDateTime)  => 
            KismetMathLibrary_methods.BreakDateTime_method.Invoke(InDateTime);

        ///<summary>Breaks a FFrameRate into a numerator and denominator.</summary>
        public static (int, int) BreakFrameRate(FrameRate InFrameRate)  => 
            KismetMathLibrary_methods.BreakFrameRate_method.Invoke(InFrameRate);

        ///<summary>Breaks a FQualifiedFrameTime into its component parts again.</summary>
        public static (FrameNumber, FrameRate, float) BreakQualifiedFrameTime(QualifiedFrameTime InFrameTime)  => 
            KismetMathLibrary_methods.BreakQualifiedFrameTime_method.Invoke(InFrameTime);

        ///<summary>Breaks apart a random number generator</summary>
        public static int BreakRandomStream(RandomStream InRandomStream)  => 
            KismetMathLibrary_methods.BreakRandomStream_method.Invoke(InRandomStream);

        ///<summary>Breaks apart a rotator into {Roll, Pitch, Yaw} angles in degrees</summary>
        public static (float, float, float) BreakRotator(Rotator InRot)  => 
            KismetMathLibrary_methods.BreakRotator_method.Invoke(InRot);

        ///<summary>Breaks apart a rotator into its component axes</summary>
        public static (Vector, Vector, Vector) BreakRotIntoAxes(Rotator InRot)  => 
            KismetMathLibrary_methods.BreakRotIntoAxes_method.Invoke(InRot);

        ///<summary>Breaks a Timespan into its components</summary>
        public static (int, int, int, int, int) BreakTimespan(Timespan InTimespan)  => 
            KismetMathLibrary_methods.BreakTimespan_method.Invoke(InTimespan);

        ///<summary>Breaks a Timespan into its components</summary>
        public static (int, int, int, int, int) BreakTimespan2(Timespan InTimespan)  => 
            KismetMathLibrary_methods.BreakTimespan2_method.Invoke(InTimespan);

        ///<summary>Breaks apart a transform into location, rotation and scale</summary>
        public static (Vector, Rotator, Vector) BreakTransform(Transform InTransform)  => 
            KismetMathLibrary_methods.BreakTransform_method.Invoke(InTransform);

        ///<summary>Breaks a vector apart into X, Y, Z</summary>
        public static (float, float, float) BreakVector(Vector InVec)  => 
            KismetMathLibrary_methods.BreakVector_method.Invoke(InVec);

        ///<summary>Breaks a 2D vector apart into X, Y.</summary>
        public static (float, float) BreakVector2D(Vector2D InVec)  => 
            KismetMathLibrary_methods.BreakVector2D_method.Invoke(InVec);

        ///<summary>Interpolates towards a varying target color smoothly.</summary>
        ///<remarks>
        ///@param               Current                 Current Color
        ///@param               Target                  Target Color
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated Color
        ///</remarks>
        public static LinearColor CInterpTo(LinearColor Current, LinearColor Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.CInterpTo_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Returns Value clamped to be between A and B (inclusive)</summary>
        public static int Clamp(int Value, int Min, int Max)  => 
            KismetMathLibrary_methods.Clamp_method.Invoke(Value, Min, Max);

        ///<summary>Clamps an arbitrary angle to be between the given angles.</summary>
        ///<remarks>
        ///Will clamp to nearest boundary.
        ///
        ///@param MinAngleDegrees       "from" angle that defines the beginning of the range of valid angles (sweeping clockwise)
        ///@param MaxAngleDegrees       "to" angle that defines the end of the range of valid angles
        ///@return Returns clamped angle in the range -180..180.
        ///</remarks>
        public static float ClampAngle(float AngleDegrees, float MinAngleDegrees, float MaxAngleDegrees)  => 
            KismetMathLibrary_methods.ClampAngle_method.Invoke(AngleDegrees, MinAngleDegrees, MaxAngleDegrees);

        ///<summary>Clamps an angle to the range of [0, 360].</summary>
        ///<remarks>
        ///@param Angle The angle to clamp.
        ///@return The clamped angle.
        ///</remarks>
        public static float ClampAxis(float Angle)  => 
            KismetMathLibrary_methods.ClampAxis_method.Invoke(Angle);

        ///<summary>Clamp the vector size between a min and max length</summary>
        public static Vector ClampVectorSize(Vector A, float Min, float Max)  => 
            KismetMathLibrary_methods.ClampVectorSize_method.Invoke(A, Min, Max);

        ///<summary>Determine if a class is a child of another class.</summary>
        ///<remarks>
        ///@return      true if TestClass == ParentClass, or if TestClass is a child of ParentClass; false otherwise, or if either
        ///                     the value for either parameter is 'None'.
        ///</remarks>
        public static bool ClassIsChildOf(SubclassOf<UObject> TestClass, SubclassOf<UObject> ParentClass)  => 
            KismetMathLibrary_methods.ClassIsChildOf_method.Invoke(TestClass, ParentClass);

        ///<summary>Combine 2 rotations to give you the resulting rotation of first applying A, then B.</summary>
        public static Rotator ComposeRotators(Rotator A, Rotator B)  => 
            KismetMathLibrary_methods.ComposeRotators_method.Invoke(A, B);

        ///<summary>Compose two transforms in order: A * B.</summary>
        ///<remarks>
        ///Order matters when composing transforms:
        ///A * B will yield a transform that logically first applies A then B to any subsequent transformation.
        ///
        ///Example: LocalToWorld = ComposeTransforms(DeltaRotation, LocalToWorld) will change rotation in local space by DeltaRotation.
        ///Example: LocalToWorld = ComposeTransforms(LocalToWorld, DeltaRotation) will change rotation in world space by DeltaRotation.
        ///
        ///@return New transform: A * B
        ///</remarks>
        public static Transform ComposeTransforms(Transform A, Transform B)  => 
            KismetMathLibrary_methods.ComposeTransforms_method.Invoke(A, B);

        ///<summary>Converts a bool to a byte</summary>
        public static byte Conv_BoolToByte(bool InBool)  => 
            KismetMathLibrary_methods.Conv_BoolToByte_method.Invoke(InBool);

        ///<summary>Converts a bool to a float (0.0f or 1.0f)</summary>
        public static float Conv_BoolToFloat(bool InBool)  => 
            KismetMathLibrary_methods.Conv_BoolToFloat_method.Invoke(InBool);

        ///<summary>Converts a bool to an int</summary>
        public static int Conv_BoolToInt(bool InBool)  => 
            KismetMathLibrary_methods.Conv_BoolToInt_method.Invoke(InBool);

        ///<summary>Converts a byte to a float</summary>
        public static float Conv_ByteToFloat(byte InByte)  => 
            KismetMathLibrary_methods.Conv_ByteToFloat_method.Invoke(InByte);

        ///<summary>Converts a byte to an integer</summary>
        public static int Conv_ByteToInt(byte InByte)  => 
            KismetMathLibrary_methods.Conv_ByteToInt_method.Invoke(InByte);

        ///<summary>Converts a color to LinearColor</summary>
        public static LinearColor Conv_ColorToLinearColor(Color InColor)  => 
            KismetMathLibrary_methods.Conv_ColorToLinearColor_method.Invoke(InColor);

        ///<summary>Convert a float into a LinearColor, where each element is that float</summary>
        public static LinearColor Conv_FloatToLinearColor(float InFloat)  => 
            KismetMathLibrary_methods.Conv_FloatToLinearColor_method.Invoke(InFloat);

        ///<summary>Convert a float into a vector, where each element is that float</summary>
        public static Vector Conv_FloatToVector(float InFloat)  => 
            KismetMathLibrary_methods.Conv_FloatToVector_method.Invoke(InFloat);

        ///<summary>Converts a int to a bool</summary>
        public static bool Conv_IntToBool(int InInt)  => 
            KismetMathLibrary_methods.Conv_IntToBool_method.Invoke(InInt);

        ///<summary>Converts an integer to a byte (if the integer is too large, returns the low 8 bits)</summary>
        public static byte Conv_IntToByte(int InInt)  => 
            KismetMathLibrary_methods.Conv_IntToByte_method.Invoke(InInt);

        ///<summary>Converts an integer to a float</summary>
        public static float Conv_IntToFloat(int InInt)  => 
            KismetMathLibrary_methods.Conv_IntToFloat_method.Invoke(InInt);

        ///<summary>Converts an integer to an IntVector</summary>
        public static IntVector Conv_IntToIntVector(int InInt)  => 
            KismetMathLibrary_methods.Conv_IntToIntVector_method.Invoke(InInt);

        ///<summary>Convert an IntVector to a vector</summary>
        public static Vector Conv_IntVectorToVector(IntVector InIntVector)  => 
            KismetMathLibrary_methods.Conv_IntVectorToVector_method.Invoke(InIntVector);

        ///<summary>Converts a LinearColor to a color</summary>
        public static Color Conv_LinearColorToColor(LinearColor InLinearColor)  => 
            KismetMathLibrary_methods.Conv_LinearColorToColor_method.Invoke(InLinearColor);

        ///<summary>Converts a LinearColor to a vector</summary>
        public static Vector Conv_LinearColorToVector(LinearColor InLinearColor)  => 
            KismetMathLibrary_methods.Conv_LinearColorToVector_method.Invoke(InLinearColor);

        ///<summary>Convert a Matrix to a Rotator</summary>
        public static Rotator Conv_MatrixToRotator(Matrix InMatrix)  => 
            KismetMathLibrary_methods.Conv_MatrixToRotator_method.Invoke(InMatrix);

        ///<summary>Convert a Matrix to a Transform</summary>
        public static Transform Conv_MatrixToTransform(Matrix InMatrix)  => 
            KismetMathLibrary_methods.Conv_MatrixToTransform_method.Invoke(InMatrix);

        ///<summary>Convert Rotator to Transform</summary>
        public static Transform Conv_RotatorToTransform(Rotator InRotator)  => 
            KismetMathLibrary_methods.Conv_RotatorToTransform_method.Invoke(InRotator);

        ///<summary>Get the X direction vector after this rotation</summary>
        public static Vector Conv_RotatorToVector(Rotator InRot)  => 
            KismetMathLibrary_methods.Conv_RotatorToVector_method.Invoke(InRot);

        ///<summary>Convert a Vector2D to a Vector</summary>
        public static Vector Conv_Vector2DToVector(Vector2D InVector2D, float Z)  => 
            KismetMathLibrary_methods.Conv_Vector2DToVector_method.Invoke(InVector2D, Z);

        ///<summary>Converts a vector to LinearColor</summary>
        public static LinearColor Conv_VectorToLinearColor(Vector InVec)  => 
            KismetMathLibrary_methods.Conv_VectorToLinearColor_method.Invoke(InVec);

        ///<summary>Create a rotator which orients X along the supplied direction vector</summary>
        public static Rotator Conv_VectorToRotator(Vector InVec)  => 
            KismetMathLibrary_methods.Conv_VectorToRotator_method.Invoke(InVec);

        ///<summary>Convert a vector to a transform. Uses vector as location</summary>
        public static Transform Conv_VectorToTransform(Vector InLocation)  => 
            KismetMathLibrary_methods.Conv_VectorToTransform_method.Invoke(InLocation);

        ///<summary>Convert a Vector to a Vector2D</summary>
        public static Vector2D Conv_VectorToVector2D(Vector InVector)  => 
            KismetMathLibrary_methods.Conv_VectorToVector2D_method.Invoke(InVector);

        ///<summary>Returns the given transform, converted to be relative to the given ParentTransform.</summary>
        ///<remarks>
        ///Example: AToB = ConvertTransformToRelative(AToWorld, BToWorld) to compute A relative to B.
        ///
        ///@param               Transform               The transform you wish to convert
        ///@param               ParentTransform The transform the conversion is relative to (in the same space as Transform)
        ///@return              The new relative transform
        ///</remarks>
        public static Transform ConvertTransformToRelative(Transform Transform, Transform ParentTransform)  => 
            KismetMathLibrary_methods.ConvertTransformToRelative_method.Invoke(Transform, ParentTransform);

        ///<summary>Returns the cosine of A (expects Radians)</summary>
        public static float Cos(float A)  => 
            KismetMathLibrary_methods.Cos_method.Invoke(A);

        ///<summary>Creates a directional vector from rotation values {Pitch, Yaw} supplied in degrees with specified Length</summary>
        public static Vector CreateVectorFromYawPitch(float Yaw, float Pitch, float Length)  => 
            KismetMathLibrary_methods.CreateVectorFromYawPitch_method.Invoke(Yaw, Pitch, Length);

        ///<summary>Returns the cross product of two 3d vectors</summary>
        public static Vector Cross_VectorVector(Vector A, Vector B)  => 
            KismetMathLibrary_methods.Cross_VectorVector_method.Invoke(A, B);

        ///<summary>Returns the cross product of two 2d vectors</summary>
        public static float CrossProduct2D(Vector2D A, Vector2D B)  => 
            KismetMathLibrary_methods.CrossProduct2D_method.Invoke(A, B);

        ///<summary>Converts a date string in ISO-8601 format to a DateTime object</summary>
        public static (FDateTime, bool) DateTimeFromIsoString(string IsoString)  => 
            KismetMathLibrary_methods.DateTimeFromIsoString_method.Invoke(IsoString);

        ///<summary>Converts a date string to a DateTime object</summary>
        public static (FDateTime, bool) DateTimeFromString(string DateTimeString)  => 
            KismetMathLibrary_methods.DateTimeFromString_method.Invoke(DateTimeString);

        ///<summary>Returns the maximum date and time value</summary>
        public static FDateTime DateTimeMaxValue()  => 
            KismetMathLibrary_methods.DateTimeMaxValue_method.Invoke();

        ///<summary>Returns the minimum date and time value</summary>
        public static FDateTime DateTimeMinValue()  => 
            KismetMathLibrary_methods.DateTimeMinValue_method.Invoke();

        ///<summary>Returns the number of days in the given year and month</summary>
        public static int DaysInMonth(int Year, int Month)  => 
            KismetMathLibrary_methods.DaysInMonth_method.Invoke(Year, Month);

        ///<summary>Returns the number of days in the given year</summary>
        public static int DaysInYear(int Year)  => 
            KismetMathLibrary_methods.DaysInYear_method.Invoke(Year);

        ///<summary>Returns the inverse cos (arccos) of A (result is in Degrees)</summary>
        public static float DegAcos(float A)  => 
            KismetMathLibrary_methods.DegAcos_method.Invoke(A);

        ///<summary>Returns the inverse sin (arcsin) of A (result is in Degrees)</summary>
        public static float DegAsin(float A)  => 
            KismetMathLibrary_methods.DegAsin_method.Invoke(A);

        ///<summary>Returns the inverse tan (atan) (result is in Degrees)</summary>
        public static float DegAtan(float A)  => 
            KismetMathLibrary_methods.DegAtan_method.Invoke(A);

        ///<summary>Returns the inverse tan (atan2) of A/B (result is in Degrees)</summary>
        public static float DegAtan2(float A, float B)  => 
            KismetMathLibrary_methods.DegAtan2_method.Invoke(A, B);

        ///<summary>Returns the cos of A (expects Degrees)</summary>
        public static float DegCos(float A)  => 
            KismetMathLibrary_methods.DegCos_method.Invoke(A);

        ///<summary>Returns radians value based on the input degrees</summary>
        public static float DegreesToRadians(float A)  => 
            KismetMathLibrary_methods.DegreesToRadians_method.Invoke(A);

        ///<summary>Returns the sin of A (expects Degrees)</summary>
        public static float DegSin(float A)  => 
            KismetMathLibrary_methods.DegSin_method.Invoke(A);

        ///<summary>Returns the tan of A (expects Degrees)</summary>
        public static float DegTan(float A)  => 
            KismetMathLibrary_methods.DegTan_method.Invoke(A);

        ///<summary>Division (A / B)</summary>
        public static byte Divide_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.Divide_ByteByte_method.Invoke(A, B);

        ///<summary>Division (A / B)</summary>
        public static float Divide_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.Divide_FloatFloat_method.Invoke(A, B);

        ///<summary>Division (A / B)</summary>
        public static int Divide_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Divide_IntInt_method.Invoke(A, B);

        ///<summary>Scalar division (A * s)</summary>
        public static Timespan Divide_TimespanFloat(Timespan A, float Scalar)  => 
            KismetMathLibrary_methods.Divide_TimespanFloat_method.Invoke(A, Scalar);

        ///<summary>Returns Vector A divided by B</summary>
        public static Vector2D Divide_Vector2DFloat(Vector2D A, float B)  => 
            KismetMathLibrary_methods.Divide_Vector2DFloat_method.Invoke(A, B);

        ///<summary>Element-wise Vector divide (Result = {A.x/B.x, A.y/B.y})</summary>
        public static Vector2D Divide_Vector2DVector2D(Vector2D A, Vector2D B)  => 
            KismetMathLibrary_methods.Divide_Vector2DVector2D_method.Invoke(A, B);

        ///<summary>Vector divide by a float</summary>
        public static Vector Divide_VectorFloat(Vector A, float B)  => 
            KismetMathLibrary_methods.Divide_VectorFloat_method.Invoke(A, B);

        ///<summary>Vector divide by an integer</summary>
        public static Vector Divide_VectorInt(Vector A, int B)  => 
            KismetMathLibrary_methods.Divide_VectorInt_method.Invoke(A, B);

        ///<summary>Element-wise Vector division (Result = {A.x/B.x, A.y/B.y, A.z/B.z})</summary>
        public static Vector Divide_VectorVector(Vector A, Vector B)  => 
            KismetMathLibrary_methods.Divide_VectorVector_method.Invoke(A, B);

        ///<summary>Returns the dot product of two 3d vectors</summary>
        public static float Dot_VectorVector(Vector A, Vector B)  => 
            KismetMathLibrary_methods.Dot_VectorVector_method.Invoke(A, B);

        ///<summary>Returns the dot product of two 2d vectors</summary>
        public static float DotProduct2D(Vector2D A, Vector2D B)  => 
            KismetMathLibrary_methods.DotProduct2D_method.Invoke(A, B);

        ///<summary>Easeing  between A and B using a specified easing function</summary>
        public static float Ease(float A, float B, float Alpha, byte EasingFunc, float BlendExp, int Steps)  => 
            KismetMathLibrary_methods.Ease_method.Invoke(A, B, Alpha, EasingFunc, BlendExp, Steps);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_BoolBool(bool A, bool B)  => 
            KismetMathLibrary_methods.EqualEqual_BoolBool_method.Invoke(A, B);

        ///<summary>Returns true if A is equal to B (A == B)</summary>
        public static bool EqualEqual_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.EqualEqual_ByteByte_method.Invoke(A, B);

        ///<summary>Returns true if A and B are equal (A == B)</summary>
        public static bool EqualEqual_ClassClass(SubclassOf<UObject> A, SubclassOf<UObject> B)  => 
            KismetMathLibrary_methods.EqualEqual_ClassClass_method.Invoke(A, B);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_DateTimeDateTime(FDateTime A, FDateTime B)  => 
            KismetMathLibrary_methods.EqualEqual_DateTimeDateTime_method.Invoke(A, B);

        ///<summary>Returns true if A is exactly equal to B (A == B)</summary>
        public static bool EqualEqual_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.EqualEqual_FloatFloat_method.Invoke(A, B);

        ///<summary>Returns true if A is equal to B (A == B)</summary>
        public static bool EqualEqual_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.EqualEqual_IntInt_method.Invoke(A, B);

        ///<summary>Returns true if A and B are equal (A == B)</summary>
        public static bool EqualEqual_NameName(Name A, Name B)  => 
            KismetMathLibrary_methods.EqualEqual_NameName_method.Invoke(A, B);

        ///<summary>Returns true if A and B are equal (A == B)</summary>
        public static bool EqualEqual_ObjectObject(UObject A, UObject B)  => 
            KismetMathLibrary_methods.EqualEqual_ObjectObject_method.Invoke(A, B);

        ///<summary>Returns true if rotator A is equal to rotator B (A == B) within a specified error tolerance</summary>
        public static bool EqualEqual_RotatorRotator(Rotator A, Rotator B, float ErrorTolerance)  => 
            KismetMathLibrary_methods.EqualEqual_RotatorRotator_method.Invoke(A, B, ErrorTolerance);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.EqualEqual_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns true if transform A is equal to transform B</summary>
        public static bool EqualEqual_TransformTransform(Transform A, Transform B)  => 
            KismetMathLibrary_methods.EqualEqual_TransformTransform_method.Invoke(A, B);

        ///<summary>Returns true if vector2D A is equal to vector2D B (A == B) within a specified error tolerance</summary>
        public static bool EqualEqual_Vector2DVector2D(Vector2D A, Vector2D B, float ErrorTolerance)  => 
            KismetMathLibrary_methods.EqualEqual_Vector2DVector2D_method.Invoke(A, B, ErrorTolerance);

        ///<summary>Returns true if vector A is equal to vector B (A == B) within a specified error tolerance</summary>
        public static bool EqualEqual_VectorVector(Vector A, Vector B, float ErrorTolerance)  => 
            KismetMathLibrary_methods.EqualEqual_VectorVector_method.Invoke(A, B, ErrorTolerance);

        ///<summary>Returns exponential(e) to the power A (e^A)</summary>
        public static float Exp(float A)  => 
            KismetMathLibrary_methods.Exp_method.Invoke(A);

        ///<summary>Rounds A to the smallest following integer</summary>
        public static int FCeil(float A)  => 
            KismetMathLibrary_methods.FCeil_method.Invoke(A);

        ///<summary>Returns Value clamped between A and B (inclusive)</summary>
        public static float FClamp(float Value, float Min, float Max)  => 
            KismetMathLibrary_methods.FClamp_method.Invoke(Value, Min, Max);

        ///<summary>Rounds A to the largest previous integer</summary>
        public static int FFloor(float A)  => 
            KismetMathLibrary_methods.FFloor_method.Invoke(A);

        ///<summary>Find the closest point on an infinite line to a given point.</summary>
        ///<remarks>
        ///@param Point                 Point for which we find the closest point on the line.
        ///@param LineOrigin    Point of reference on the line.
        ///@param LineDirection Direction of the line. Not required to be normalized.
        ///@return The closest point on the line to the given point.
        ///</remarks>
        public static Vector FindClosestPointOnLine(Vector Point, Vector LineOrigin, Vector LineDirection)  => 
            KismetMathLibrary_methods.FindClosestPointOnLine_method.Invoke(Point, LineOrigin, LineDirection);

        ///<summary>Find the closest point on a segment to a given point.</summary>
        ///<remarks>
        ///@param Point                 Point for which we find the closest point on the segment.
        ///@param SegmentStart  Start of the segment.
        ///@param SegmentEnd    End of the segment.
        ///@return The closest point on the segment to the given point.
        ///</remarks>
        public static Vector FindClosestPointOnSegment(Vector Point, Vector SegmentStart, Vector SegmentEnd)  => 
            KismetMathLibrary_methods.FindClosestPointOnSegment_method.Invoke(Point, SegmentStart, SegmentEnd);

        ///<summary>Find a rotation for an object at Start location to point at Target location.</summary>
        public static Rotator FindLookAtRotation(Vector Start, Vector Target)  => 
            KismetMathLibrary_methods.FindLookAtRotation_method.Invoke(Start, Target);

        ///<summary>Find closest points between 2 segments.</summary>
        ///<remarks>
        ///@param       Segment1Start   Start of the 1st segment.
        ///@param       Segment1End             End of the 1st segment.
        ///@param       Segment2Start   Start of the 2nd segment.
        ///@param       Segment2End             End of the 2nd segment.
        ///@param       Segment1Point   Closest point on segment 1 to segment 2.
        ///@param       Segment2Point   Closest point on segment 2 to segment 1.
        ///</remarks>
        public static (Vector, Vector) FindNearestPointsOnLineSegments(Vector Segment1Start, Vector Segment1End, Vector Segment2Start, Vector Segment2End)  => 
            KismetMathLibrary_methods.FindNearestPointsOnLineSegments_method.Invoke(Segment1Start, Segment1End, Segment2Start, Segment2End);

        ///<summary>Interpolate between A and B, applying an ease in/out function.  Exp controls the degree of the curve.</summary>
        public static float FInterpEaseInOut(float A, float B, float Alpha, float Exponent)  => 
            KismetMathLibrary_methods.FInterpEaseInOut_method.Invoke(A, B, Alpha, Exponent);

        ///<summary>Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.</summary>
        ///<remarks>
        ///@param               Current                 Actual position
        ///@param               Target                  Target position
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static float FInterpTo(float Current, float Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.FInterpTo_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Tries to reach Target at a constant rate.</summary>
        ///<remarks>
        ///@param               Current                 Actual position
        ///@param               Target                  Target position
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static float FInterpTo_Constant(float Current, float Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.FInterpTo_Constant_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>
        ///Returns a new rotation component value
        ///@
        ///</summary>
        ///<remarks>
        ///param InCurrent is the current rotation value
        ///@param InDesired is the desired rotation value
        ///@param  is the rotation amount to apply
        ///
        ///@return a new rotation component value clamped in the range (-360,360)
        ///</remarks>
        public static float FixedTurn(float InCurrent, float InDesired, float InDeltaRate)  => 
            KismetMathLibrary_methods.FixedTurn_method.Invoke(InCurrent, InDesired, InDeltaRate);

        ///<summary>Uses a simple spring model to interpolate a float from Current to Target.</summary>
        ///<remarks>
        ///@param Current                               Current value
        ///@param Target                                Target value
        ///@param SpringState                   Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
        ///@param Stiffness                             How stiff the spring model is (more stiffness means more oscillation around the target value)
        ///@param CriticalDampingFactor How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
        ///@param Mass                                  Multiplier that acts like mass on a spring
        ///</remarks>
        public static float FloatSpringInterp(float Current, float Target, FloatSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass)  => 
            KismetMathLibrary_methods.FloatSpringInterp_method.Invoke(Current, Target, SpringState, Stiffness, CriticalDampingFactor, DeltaTime, Mass);

        ///<summary>Returns the maximum value of A and B</summary>
        public static float FMax(float A, float B)  => 
            KismetMathLibrary_methods.FMax_method.Invoke(A, B);

        ///<summary>Returns the minimum value of A and B</summary>
        public static float FMin(float A, float B)  => 
            KismetMathLibrary_methods.FMin_method.Invoke(A, B);

        ///<summary>Returns the number of times Divisor will go into Dividend (i.e., Dividend divided by Divisor), as well as the remainder</summary>
        public static (float, int) FMod(float Dividend, float Divisor)  => 
            KismetMathLibrary_methods.FMod_method.Invoke(Dividend, Divisor);

        ///<summary>Returns the fractional part of a float.</summary>
        public static float Fraction(float A)  => 
            KismetMathLibrary_methods.Fraction_method.Invoke(A);

        ///<summary>Returns a time span that represents the specified number of days</summary>
        public static Timespan FromDays(float Days)  => 
            KismetMathLibrary_methods.FromDays_method.Invoke(Days);

        ///<summary>Returns a time span that represents the specified number of hours</summary>
        public static Timespan FromHours(float Hours)  => 
            KismetMathLibrary_methods.FromHours_method.Invoke(Hours);

        ///<summary>Returns a time span that represents the specified number of milliseconds</summary>
        public static Timespan FromMilliseconds(float Milliseconds)  => 
            KismetMathLibrary_methods.FromMilliseconds_method.Invoke(Milliseconds);

        ///<summary>Returns a time span that represents the specified number of minutes</summary>
        public static Timespan FromMinutes(float Minutes)  => 
            KismetMathLibrary_methods.FromMinutes_method.Invoke(Minutes);

        ///<summary>Returns a time span that represents the specified number of seconds</summary>
        public static Timespan FromSeconds(float Seconds)  => 
            KismetMathLibrary_methods.FromSeconds_method.Invoke(Seconds);

        ///<summary>Rounds A to an integer with truncation towards zero.  (e.g. -1.7 truncated to -1, 2.8 truncated to 2)</summary>
        public static int FTrunc(float A)  => 
            KismetMathLibrary_methods.FTrunc_method.Invoke(A);

        ///<summary>Rounds A to an integer with truncation towards zero for each element in a vector.  (e.g. -1.7 truncated to -1, 2.8 truncated to 2)</summary>
        public static IntVector FTruncVector(Vector InVector)  => 
            KismetMathLibrary_methods.FTruncVector_method.Invoke(InVector);

        ///<summary>Get the reference frame direction vectors (axes) described by this rotation</summary>
        public static (Vector, Vector, Vector) GetAxes(Rotator A)  => 
            KismetMathLibrary_methods.GetAxes_method.Invoke(A);

        ///<summary>Breaks a direction vector apart into Azimuth (Yaw) and Elevation (Pitch) rotation values given in degrees.</summary>
        ///<remarks>
        ///(non-clamped)
        ///       Relative to the provided reference frame (an Actor's WorldTransform for example)
        ///</remarks>
        public static (float, float) GetAzimuthAndElevation(Vector InDirection, Transform ReferenceFrame)  => 
            KismetMathLibrary_methods.GetAzimuthAndElevation_method.Invoke(InDirection, ReferenceFrame);

        ///<summary>Returns the date component of A</summary>
        public static FDateTime GetDate(FDateTime A)  => 
            KismetMathLibrary_methods.GetDate_method.Invoke(A);

        ///<summary>Returns the day component of A (1 to 31)</summary>
        public static int GetDay(FDateTime A)  => 
            KismetMathLibrary_methods.GetDay_method.Invoke(A);

        ///<summary>Returns the day of year of A</summary>
        public static int GetDayOfYear(FDateTime A)  => 
            KismetMathLibrary_methods.GetDayOfYear_method.Invoke(A);

        ///<summary>Returns the days component of A</summary>
        public static int GetDays(Timespan A)  => 
            KismetMathLibrary_methods.GetDays_method.Invoke(A);

        ///<summary>Find the unit direction vector from one position to another.</summary>
        public static Vector GetDirectionUnitVector(Vector From, Vector To)  => 
            KismetMathLibrary_methods.GetDirectionUnitVector_method.Invoke(From, To);

        ///<summary>Returns the absolute value of A</summary>
        public static Timespan GetDuration(Timespan A)  => 
            KismetMathLibrary_methods.GetDuration_method.Invoke(A);

        ///<summary>Rotate the world forward vector by the given rotation</summary>
        public static Vector GetForwardVector(Rotator InRot)  => 
            KismetMathLibrary_methods.GetForwardVector_method.Invoke(InRot);

        ///<summary>Returns the hour component of A (24h format)</summary>
        public static int GetHour(FDateTime A)  => 
            KismetMathLibrary_methods.GetHour_method.Invoke(A);

        ///<summary>Returns the hour component of A (12h format)</summary>
        public static int GetHour12(FDateTime A)  => 
            KismetMathLibrary_methods.GetHour12_method.Invoke(A);

        ///<summary>Returns the hours component of A</summary>
        public static int GetHours(Timespan A)  => 
            KismetMathLibrary_methods.GetHours_method.Invoke(A);

        ///<summary>Find the maximum element (X, Y or Z) of a vector</summary>
        public static float GetMaxElement(Vector A)  => 
            KismetMathLibrary_methods.GetMaxElement_method.Invoke(A);

        ///<summary>Returns the millisecond component of A</summary>
        public static int GetMillisecond(FDateTime A)  => 
            KismetMathLibrary_methods.GetMillisecond_method.Invoke(A);

        ///<summary>Returns the milliseconds component of A</summary>
        public static int GetMilliseconds(Timespan A)  => 
            KismetMathLibrary_methods.GetMilliseconds_method.Invoke(A);

        ///<summary>Find the minimum element (X, Y or Z) of a vector</summary>
        public static float GetMinElement(Vector A)  => 
            KismetMathLibrary_methods.GetMinElement_method.Invoke(A);

        ///<summary>Returns the minute component of A</summary>
        public static int GetMinute(FDateTime A)  => 
            KismetMathLibrary_methods.GetMinute_method.Invoke(A);

        ///<summary>Returns the minutes component of A</summary>
        public static int GetMinutes(Timespan A)  => 
            KismetMathLibrary_methods.GetMinutes_method.Invoke(A);

        ///<summary>Returns the month component of A</summary>
        public static int GetMonth(FDateTime A)  => 
            KismetMathLibrary_methods.GetMonth_method.Invoke(A);

        ///<summary>Returns the value of PI</summary>
        public static float GetPI()  => 
            KismetMathLibrary_methods.GetPI_method.Invoke();

        ///<summary>Find the distance from a point to the closest point on an infinite line.</summary>
        ///<remarks>
        ///@param Point                  Point for which we find the distance to the closest point on the line.
        ///@param LineOrigin             Point of reference on the line.
        ///@param LineDirection  Direction of the line. Not required to be normalized.
        ///@return The distance from the given point to the closest point on the line.
        ///</remarks>
        public static float GetPointDistanceToLine(Vector Point, Vector LineOrigin, Vector LineDirection)  => 
            KismetMathLibrary_methods.GetPointDistanceToLine_method.Invoke(Point, LineOrigin, LineDirection);

        ///<summary>Find the distance from a point to the closest point on a segment.</summary>
        ///<remarks>
        ///@param Point                  Point for which we find the distance to the closest point on the segment.
        ///@param SegmentStart   Start of the segment.
        ///@param SegmentEnd             End of the segment.
        ///@return The distance from the given point to the closest point on the segment.
        ///</remarks>
        public static float GetPointDistanceToSegment(Vector Point, Vector SegmentStart, Vector SegmentEnd)  => 
            KismetMathLibrary_methods.GetPointDistanceToSegment_method.Invoke(Point, SegmentStart, SegmentEnd);

        ///<summary>Given a direction vector and a surface normal, returns the vector reflected across the surface normal.</summary>
        ///<remarks>
        ///Produces a result like shining a laser at a mirror!
        ///
        ///@param Direction Direction vector the ray is coming from.
        ///@param SurfaceNormal A normal of the surface the ray should be reflected on.
        ///
        ///@returns Reflected vector.
        ///</remarks>
        public static Vector GetReflectionVector(Vector Direction, Vector SurfaceNormal)  => 
            KismetMathLibrary_methods.GetReflectionVector_method.Invoke(Direction, SurfaceNormal);

        ///<summary>Rotate the world right vector by the given rotation</summary>
        public static Vector GetRightVector(Rotator InRot)  => 
            KismetMathLibrary_methods.GetRightVector_method.Invoke(InRot);

        ///<summary>Returns the second component of A</summary>
        public static int GetSecond(FDateTime A)  => 
            KismetMathLibrary_methods.GetSecond_method.Invoke(A);

        ///<summary>Returns the seconds component of A</summary>
        public static int GetSeconds(Timespan A)  => 
            KismetMathLibrary_methods.GetSeconds_method.Invoke(A);

        ///<summary>
        ///Returns Slope Pitch and Roll angles in degrees based on the following information:
        ///@
        ///</summary>
        ///<remarks>
        ///param        MyRightYAxis                            Right (Y) direction unit vector of Actor standing on Slope.
        ///@param        FloorNormal                                     Floor Normal (unit) vector.
        ///@param        UpVector                                        UpVector of reference frame.
        ///@outparam OutSlopePitchDegreeAngle    Slope Pitch angle (degrees)
        ///@outparam OutSlopeRollDegreeAngle             Slope Roll angle (degrees)
        ///</remarks>
        public static (float, float) GetSlopeDegreeAngles(Vector MyRightYAxis, Vector FloorNormal, Vector UpVector)  => 
            KismetMathLibrary_methods.GetSlopeDegreeAngles_method.Invoke(MyRightYAxis, FloorNormal, UpVector);

        ///<summary>Returns the value of TAU (= 2 * PI)</summary>
        public static float GetTAU()  => 
            KismetMathLibrary_methods.GetTAU_method.Invoke();

        ///<summary>Returns the time elapsed since midnight of A</summary>
        public static Timespan GetTimeOfDay(FDateTime A)  => 
            KismetMathLibrary_methods.GetTimeOfDay_method.Invoke(A);

        ///<summary>Returns the total number of days in A</summary>
        public static float GetTotalDays(Timespan A)  => 
            KismetMathLibrary_methods.GetTotalDays_method.Invoke(A);

        ///<summary>Returns the total number of hours in A</summary>
        public static float GetTotalHours(Timespan A)  => 
            KismetMathLibrary_methods.GetTotalHours_method.Invoke(A);

        ///<summary>Returns the total number of milliseconds in A</summary>
        public static float GetTotalMilliseconds(Timespan A)  => 
            KismetMathLibrary_methods.GetTotalMilliseconds_method.Invoke(A);

        ///<summary>Returns the total number of minutes in A</summary>
        public static float GetTotalMinutes(Timespan A)  => 
            KismetMathLibrary_methods.GetTotalMinutes_method.Invoke(A);

        ///<summary>Returns the total number of seconds in A</summary>
        public static float GetTotalSeconds(Timespan A)  => 
            KismetMathLibrary_methods.GetTotalSeconds_method.Invoke(A);

        ///<summary>Rotate the world up vector by the given rotation</summary>
        public static Vector GetUpVector(Rotator InRot)  => 
            KismetMathLibrary_methods.GetUpVector_method.Invoke(InRot);

        ///<summary>Find the average of an array of vectors</summary>
        public static Vector GetVectorArrayAverage(byte Vectors /*TODO: array TArray */)  => 
            KismetMathLibrary_methods.GetVectorArrayAverage_method.Invoke(Vectors);

        ///<summary>Breaks a vector apart into Yaw, Pitch rotation values given in degrees. (non-clamped)</summary>
        public static (float, float) GetYawPitchFromVector(Vector InVec)  => 
            KismetMathLibrary_methods.GetYawPitchFromVector_method.Invoke(InVec);

        ///<summary>Returns the year component of A</summary>
        public static int GetYear(FDateTime A)  => 
            KismetMathLibrary_methods.GetYear_method.Invoke(A);

        ///<summary>Returns true if A is greater than B (A > B)</summary>
        public static bool Greater_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.Greater_ByteByte_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than B (A > B)</summary>
        public static bool Greater_DateTimeDateTime(FDateTime A, FDateTime B)  => 
            KismetMathLibrary_methods.Greater_DateTimeDateTime_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than B (A > B)</summary>
        public static bool Greater_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.Greater_FloatFloat_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than B (A > B)</summary>
        public static bool Greater_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Greater_IntInt_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than B (A > B)</summary>
        public static bool Greater_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.Greater_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than or equal to B (A >= B)</summary>
        public static bool GreaterEqual_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.GreaterEqual_ByteByte_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than or equal to B (A >= B)</summary>
        public static bool GreaterEqual_DateTimeDateTime(FDateTime A, FDateTime B)  => 
            KismetMathLibrary_methods.GreaterEqual_DateTimeDateTime_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than or equal to B (A >= B)</summary>
        public static bool GreaterEqual_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.GreaterEqual_FloatFloat_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than or equal to B (A >= B)</summary>
        public static bool GreaterEqual_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.GreaterEqual_IntInt_method.Invoke(A, B);

        ///<summary>Returns true if A is greater than or equal to B (A >= B)</summary>
        public static bool GreaterEqual_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.GreaterEqual_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns result of vector A rotated by Rotator B</summary>
        public static Vector GreaterGreater_VectorRotator(Vector A, Rotator B)  => 
            KismetMathLibrary_methods.GreaterGreater_VectorRotator_method.Invoke(A, B);

        ///<summary>Snaps a value to the nearest grid multiple.</summary>
        ///<remarks>
        ///E.g.,
        ///            Location = 5.1, GridSize = 10.0 : return value = 10.0
        ///If GridSize is 0 Location is returned
        ///if GridSize is very small precision issues may occur.
        ///</remarks>
        public static float GridSnap_Float(float Location, float GridSize)  => 
            KismetMathLibrary_methods.GridSnap_Float_method.Invoke(Location, GridSize);

        ///<summary>Make a color from individual color components (HSV space; Hue is [0..360) while Saturation and Value are 0..1)</summary>
        public static LinearColor HSVToRGB(float H, float S, float V, float A)  => 
            KismetMathLibrary_methods.HSVToRGB_method.Invoke(H, S, V, A);

        ///<summary>Converts a HSV linear color (where H is in R (0..360), S is in G (0..1), and V is in B (0..1)) to RGB</summary>
        public static LinearColor HSVToRGB_Vector(LinearColor HSV)  => 
            KismetMathLibrary_methods.HSVToRGB_Vector_method.Invoke(HSV);

        ///<summary>Returns the hypotenuse of a right-angled triangle given the width and height.</summary>
        public static float Hypotenuse(float Width, float Height)  => 
            KismetMathLibrary_methods.Hypotenuse_method.Invoke(Width, Height);

        ///<summary>
        ///Returns true if value is between Min and Max (V >= Min && V <= Max)
        ///If InclusiveMin is true, value needs to be equal or larger than Min, else it needs to be larger
        ///</summary>
        ///<remarks>If InclusiveMax is true, value needs to be smaller or equal than Max, else it needs to be smaller</remarks>
        public static bool InRange_FloatFloat(float Value, float Min, float Max, bool InclusiveMin, bool InclusiveMax)  => 
            KismetMathLibrary_methods.InRange_FloatFloat_method.Invoke(Value, Min, Max, InclusiveMin, InclusiveMax);

        ///<summary>
        ///Returns true if value is between Min and Max (V >= Min && V <= Max)
        ///If InclusiveMin is true, value needs to be equal or larger than Min, else it needs to be larger
        ///</summary>
        ///<remarks>If InclusiveMax is true, value needs to be smaller or equal than Max, else it needs to be smaller</remarks>
        public static bool InRange_IntInt(int Value, int Min, int Max, bool InclusiveMin, bool InclusiveMax)  => 
            KismetMathLibrary_methods.InRange_IntInt_method.Invoke(Value, Min, Max, InclusiveMin, InclusiveMax);

        ///<summary>Transform a direction vector by the inverse of the supplied transform - will not change its length.</summary>
        ///<remarks>For example, if T was an object's transform, this would transform a direction from world space to local space.</remarks>
        public static Vector InverseTransformDirection(Transform T, Vector Direction)  => 
            KismetMathLibrary_methods.InverseTransformDirection_method.Invoke(T, Direction);

        ///<summary>Transform a position by the inverse of the supplied transform.</summary>
        ///<remarks>For example, if T was an object's transform, this would transform a position from world space to local space.</remarks>
        public static Vector InverseTransformLocation(Transform T, Vector Location)  => 
            KismetMathLibrary_methods.InverseTransformLocation_method.Invoke(T, Location);

        ///<summary>Transform a rotator by the inverse of the supplied transform.</summary>
        ///<remarks>For example, if T was an object's transform, this would transform a rotation from world space to local space.</remarks>
        public static Rotator InverseTransformRotation(Transform T, Rotator Rotation)  => 
            KismetMathLibrary_methods.InverseTransformRotation_method.Invoke(T, Rotation);

        ///<summary>Returns the inverse of the given transform T.</summary>
        ///<remarks>
        ///Example: Given a LocalToWorld transform, WorldToLocal will be returned.
        ///
        ///@param       T       The transform you wish to invert
        ///@return      The inverse of T.
        ///</remarks>
        public static Transform InvertTransform(Transform T)  => 
            KismetMathLibrary_methods.InvertTransform_method.Invoke(T);

        ///<summary>Returns whether A's time is in the afternoon</summary>
        public static bool IsAfternoon(FDateTime A)  => 
            KismetMathLibrary_methods.IsAfternoon_method.Invoke(A);

        ///<summary>Returns whether given year is a leap year</summary>
        public static bool IsLeapYear(int Year)  => 
            KismetMathLibrary_methods.IsLeapYear_method.Invoke(Year);

        ///<summary>Returns whether A's time is in the morning</summary>
        public static bool IsMorning(FDateTime A)  => 
            KismetMathLibrary_methods.IsMorning_method.Invoke(A);

        ///<summary>Determines whether the given point is in a box.</summary>
        ///<remarks>
        ///Includes points on the box.
        ///
        ///@param Point                 Point to test
        ///@param BoxOrigin             Origin of the box
        ///@param BoxExtent             Extents of the box (distance in each axis from origin)
        ///@return Whether the point is in the box.
        ///</remarks>
        public static bool IsPointInBox(Vector Point, Vector BoxOrigin, Vector BoxExtent)  => 
            KismetMathLibrary_methods.IsPointInBox_method.Invoke(Point, BoxOrigin, BoxExtent);

        ///<summary>Determines whether a given point is in a box with a given transform.</summary>
        ///<remarks>
        ///Includes points on the box.
        ///
        ///@param Point                          Point to test
        ///@param BoxWorldTransform      Component-to-World transform of the box.
        ///@param BoxExtent                      Extents of the box (distance in each axis from origin), in component space.
        ///@return Whether the point is in the box.
        ///</remarks>
        public static bool IsPointInBoxWithTransform(Vector Point, Transform BoxWorldTransform, Vector BoxExtent)  => 
            KismetMathLibrary_methods.IsPointInBoxWithTransform_method.Invoke(Point, BoxWorldTransform, BoxExtent);

        ///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
        public static float Lerp(float A, float B, float Alpha)  => 
            KismetMathLibrary_methods.Lerp_method.Invoke(A, B, Alpha);

        ///<summary>Returns true if A is less than B (A < B)</summary>
        public static bool Less_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.Less_ByteByte_method.Invoke(A, B);

        ///<summary>Returns true if A is less than B (A < B)</summary>
        public static bool Less_DateTimeDateTime(FDateTime A, FDateTime B)  => 
            KismetMathLibrary_methods.Less_DateTimeDateTime_method.Invoke(A, B);

        ///<summary>Returns true if A is Less than B (A < B)</summary>
        public static bool Less_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.Less_FloatFloat_method.Invoke(A, B);

        ///<summary>Returns true if A is less than B (A < B)</summary>
        public static bool Less_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Less_IntInt_method.Invoke(A, B);

        ///<summary>Returns true if A is less than B (A < B)</summary>
        public static bool Less_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.Less_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns true if A is less than or equal to B (A <= B)</summary>
        public static bool LessEqual_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.LessEqual_ByteByte_method.Invoke(A, B);

        ///<summary>Returns true if A is less than or equal to B (A <= B)</summary>
        public static bool LessEqual_DateTimeDateTime(FDateTime A, FDateTime B)  => 
            KismetMathLibrary_methods.LessEqual_DateTimeDateTime_method.Invoke(A, B);

        ///<summary>Returns true if A is Less than or equal to B (A <= B)</summary>
        public static bool LessEqual_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.LessEqual_FloatFloat_method.Invoke(A, B);

        ///<summary>Returns true if A is less than or equal to B (A <= B)</summary>
        public static bool LessEqual_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.LessEqual_IntInt_method.Invoke(A, B);

        ///<summary>Returns true if A is less than or equal to B (A <= B)</summary>
        public static bool LessEqual_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.LessEqual_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns result of vector A rotated by the inverse of Rotator B</summary>
        public static Vector LessLess_VectorRotator(Vector A, Rotator B)  => 
            KismetMathLibrary_methods.LessLess_VectorRotator_method.Invoke(A, B);

        ///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
        public static LinearColor LinearColorLerp(LinearColor A, LinearColor B, float Alpha)  => 
            KismetMathLibrary_methods.LinearColorLerp_method.Invoke(A, B, Alpha);

        ///<summary>Linearly interpolates between two colors by the specified Alpha amount (100% of A when Alpha=0 and 100% of B when Alpha=1).</summary>
        ///<remarks>
        ///The interpolation is performed in HSV color space taking the shortest path to the new color's hue.  This can give better results than a normal lerp, but is much more expensive.  The incoming colors are in RGB space, and the output color will be RGB.  The alpha value will also be interpolated.
        ///
        ///@param       A               The color and alpha to interpolate from as linear RGBA
        ///@param       B               The color and alpha to interpolate to as linear RGBA
        ///@param       Alpha   Scalar interpolation amount (usually between 0.0 and 1.0 inclusive)
        ///
        ///@return      The interpolated color in linear RGB space along with the interpolated alpha value
        ///</remarks>
        public static LinearColor LinearColorLerpUsingHSV(LinearColor A, LinearColor B, float Alpha)  => 
            KismetMathLibrary_methods.LinearColorLerpUsingHSV_method.Invoke(A, B, Alpha);

        ///<summary>Computes the intersection point between a line and a plane.</summary>
        ///<remarks>
        ///@param               T - The t of the intersection between the line and the plane
        ///@param               Intersection - The point of intersection between the line and the plane
        ///@return              True if the intersection test was successful.
        ///</remarks>
        public static (float, Vector, bool) LinePlaneIntersection(Vector LineStart, Vector LineEnd, Plane APlane)  => 
            KismetMathLibrary_methods.LinePlaneIntersection_method.Invoke(LineStart, LineEnd, APlane);

        ///<summary>Computes the intersection point between a line and a plane.</summary>
        ///<remarks>
        ///@param               T - The t of the intersection between the line and the plane
        ///@param               Intersection - The point of intersection between the line and the plane
        ///@return              True if the intersection test was successful.
        ///</remarks>
        public static (float, Vector, bool) LinePlaneIntersection_OriginNormal(Vector LineStart, Vector LineEnd, Vector PlaneOrigin, Vector PlaneNormal)  => 
            KismetMathLibrary_methods.LinePlaneIntersection_OriginNormal_method.Invoke(LineStart, LineEnd, PlaneOrigin, PlaneNormal);

        ///<summary>Returns log of A base B (if B^R == A, returns R)</summary>
        public static float Log(float A, float Base)  => 
            KismetMathLibrary_methods.Log_method.Invoke(A, Base);

        ///<summary>Returns natural log of A (if e^R == A, returns R)</summary>
        public static float Loge(float A)  => 
            KismetMathLibrary_methods.Loge_method.Invoke(A);

        ///<summary>Makes an FBox from Min and Max and sets IsValid to true</summary>
        public static Box MakeBox(Vector Min, Vector Max)  => 
            KismetMathLibrary_methods.MakeBox_method.Invoke(Min, Max);

        ///<summary>Makes an FBox2D from Min and Max and sets IsValid to true</summary>
        public static Box2D MakeBox2D(Vector2D Min, Vector2D Max)  => 
            KismetMathLibrary_methods.MakeBox2D_method.Invoke(Min, Max);

        ///<summary>Make a color from individual color components (RGB space)</summary>
        public static LinearColor MakeColor(float R, float G, float B, float A)  => 
            KismetMathLibrary_methods.MakeColor_method.Invoke(R, G, B, A);

        ///<summary>Makes a DateTime struct</summary>
        public static FDateTime MakeDateTime(int Year, int Month, int Day, int Hour, int Minute, int Second, int Millisecond)  => 
            KismetMathLibrary_methods.MakeDateTime_method.Invoke(Year, Month, Day, Hour, Minute, Second, Millisecond);

        ///<summary>Creates a FFrameRate from a Numerator and a Denominator. Enforces that the Denominator is at least one.</summary>
        public static FrameRate MakeFrameRate(int Numerator, int Denominator)  => 
            KismetMathLibrary_methods.MakeFrameRate_method.Invoke(Numerator, Denominator);

        ///<summary>
        ///Creates a plane with a facing direction of Normal at the given Point
        ///@
        ///</summary>
        ///<remarks>
        ///param Point  A point on the plane
        ///@param Normal  The Normal of the plane at Point
        ///@return Plane instance
        ///</remarks>
        public static Plane MakePlaneFromPointAndNormal(Vector Point, Vector Normal)  => 
            KismetMathLibrary_methods.MakePlaneFromPointAndNormal_method.Invoke(Point, Normal);

        ///<summary>
        ///Simple function to create a pulsating scalar value
        ///@
        ///</summary>
        ///<remarks>
        ///param  InCurrentTime  Current absolute time
        ///@param  InPulsesPerSecond  How many full pulses per second?
        ///@param  InPhase  Optional phase amount, between 0.0 and 1.0 (to synchronize pulses)
        ///
        ///@return  Pulsating value (0.0-1.0)
        ///</remarks>
        public static float MakePulsatingValue(float InCurrentTime, float InPulsesPerSecond, float InPhase)  => 
            KismetMathLibrary_methods.MakePulsatingValue_method.Invoke(InCurrentTime, InPulsesPerSecond, InPhase);

        ///<summary>Creates a FQualifiedFrameTime out of a frame number, frame rate, and optional 0-1 clamped subframe.</summary>
        public static QualifiedFrameTime MakeQualifiedFrameTime(FrameNumber Frame, FrameRate FrameRate, float SubFrame)  => 
            KismetMathLibrary_methods.MakeQualifiedFrameTime_method.Invoke(Frame, FrameRate, SubFrame);

        ///<summary>Makes a SRand-based random number generator</summary>
        public static RandomStream MakeRandomStream(int InitialSeed)  => 
            KismetMathLibrary_methods.MakeRandomStream_method.Invoke(InitialSeed);

        ///<summary>Build a reference frame from three axes</summary>
        public static Rotator MakeRotationFromAxes(Vector Forward, Vector Right, Vector Up)  => 
            KismetMathLibrary_methods.MakeRotationFromAxes_method.Invoke(Forward, Right, Up);

        ///<summary>Makes a rotator {Roll, Pitch, Yaw} from rotation values supplied in degrees</summary>
        public static Rotator MakeRotator(float Roll, float Pitch, float Yaw)  => 
            KismetMathLibrary_methods.MakeRotator_method.Invoke(Roll, Pitch, Yaw);

        ///<summary>Builds a rotator given only a XAxis. Y and Z are unspecified but will be orthonormal. XAxis need not be normalized.</summary>
        public static Rotator MakeRotFromX(Vector X)  => 
            KismetMathLibrary_methods.MakeRotFromX_method.Invoke(X);

        ///<summary>Builds a matrix with given X and Y axes. X will remain fixed, Y may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
        public static Rotator MakeRotFromXY(Vector X, Vector Y)  => 
            KismetMathLibrary_methods.MakeRotFromXY_method.Invoke(X, Y);

        ///<summary>Builds a matrix with given X and Z axes. X will remain fixed, Z may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
        public static Rotator MakeRotFromXZ(Vector X, Vector Z)  => 
            KismetMathLibrary_methods.MakeRotFromXZ_method.Invoke(X, Z);

        ///<summary>Builds a rotation matrix given only a YAxis. X and Z are unspecified but will be orthonormal. YAxis need not be normalized.</summary>
        public static Rotator MakeRotFromY(Vector Y)  => 
            KismetMathLibrary_methods.MakeRotFromY_method.Invoke(Y);

        ///<summary>Builds a matrix with given Y and X axes. Y will remain fixed, X may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
        public static Rotator MakeRotFromYX(Vector Y, Vector X)  => 
            KismetMathLibrary_methods.MakeRotFromYX_method.Invoke(Y, X);

        ///<summary>Builds a matrix with given Y and Z axes. Y will remain fixed, Z may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
        public static Rotator MakeRotFromYZ(Vector Y, Vector Z)  => 
            KismetMathLibrary_methods.MakeRotFromYZ_method.Invoke(Y, Z);

        ///<summary>Builds a rotation matrix given only a ZAxis. X and Y are unspecified but will be orthonormal. ZAxis need not be normalized.</summary>
        public static Rotator MakeRotFromZ(Vector Z)  => 
            KismetMathLibrary_methods.MakeRotFromZ_method.Invoke(Z);

        ///<summary>Builds a matrix with given Z and X axes. Z will remain fixed, X may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
        public static Rotator MakeRotFromZX(Vector Z, Vector X)  => 
            KismetMathLibrary_methods.MakeRotFromZX_method.Invoke(Z, X);

        ///<summary>Builds a matrix with given Z and Y axes. Z will remain fixed, Y may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
        public static Rotator MakeRotFromZY(Vector Z, Vector Y)  => 
            KismetMathLibrary_methods.MakeRotFromZY_method.Invoke(Z, Y);

        ///<summary>Makes a Timespan struct</summary>
        public static Timespan MakeTimespan(int Days, int Hours, int Minutes, int Seconds, int Milliseconds)  => 
            KismetMathLibrary_methods.MakeTimespan_method.Invoke(Days, Hours, Minutes, Seconds, Milliseconds);

        ///<summary>Makes a Timespan struct</summary>
        public static Timespan MakeTimespan2(int Days, int Hours, int Minutes, int Seconds, int FractionNano)  => 
            KismetMathLibrary_methods.MakeTimespan2_method.Invoke(Days, Hours, Minutes, Seconds, FractionNano);

        ///<summary>Make a transform from location, rotation and scale</summary>
        public static Transform MakeTransform(Vector Location, Rotator Rotation, Vector Scale)  => 
            KismetMathLibrary_methods.MakeTransform_method.Invoke(Location, Rotation, Scale);

        ///<summary>Makes a vector {X, Y, Z}</summary>
        public static Vector MakeVector(float X, float Y, float Z)  => 
            KismetMathLibrary_methods.MakeVector_method.Invoke(X, Y, Z);

        ///<summary>Makes a 2d vector {X, Y}</summary>
        public static Vector2D MakeVector2D(float X, float Y)  => 
            KismetMathLibrary_methods.MakeVector2D_method.Invoke(X, Y);

        ///<summary>Returns Value mapped from one range into another where the Value is clamped to the Input Range.  (e.g. 0.5 normalized from the range 0->1 to 0->50 would result in 25)</summary>
        public static float MapRangeClamped(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB)  => 
            KismetMathLibrary_methods.MapRangeClamped_method.Invoke(Value, InRangeA, InRangeB, OutRangeA, OutRangeB);

        ///<summary>Returns Value mapped from one range into another.  (e.g. 20 normalized from the range 10->50 to 20->40 would result in 25)</summary>
        public static float MapRangeUnclamped(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB)  => 
            KismetMathLibrary_methods.MapRangeUnclamped_method.Invoke(Value, InRangeA, InRangeB, OutRangeA, OutRangeB);

        ///<summary>
        ///Get the origin of the co-ordinate system
        ///@
        ///</summary>
        ///<remarks>return co-ordinate system origin</remarks>
        public static Vector Matrix_GetOrigin(Matrix InMatrix)  => 
            KismetMathLibrary_methods.Matrix_GetOrigin_method.Invoke(InMatrix);

        ///<summary>Returns the maximum value of A and B</summary>
        public static int Max(int A, int B)  => 
            KismetMathLibrary_methods.Max_method.Invoke(A, B);

        ///<summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
        public static (int, byte) MaxOfByteArray(byte ByteArray /*TODO: array TArray */)  => 
            KismetMathLibrary_methods.MaxOfByteArray_method.Invoke(ByteArray);

        ///<summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
        public static (int, float) MaxOfFloatArray(byte FloatArray /*TODO: array TArray */)  => 
            KismetMathLibrary_methods.MaxOfFloatArray_method.Invoke(FloatArray);

        ///<summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
        public static (int, int) MaxOfIntArray(byte IntArray /*TODO: array TArray */)  => 
            KismetMathLibrary_methods.MaxOfIntArray_method.Invoke(IntArray);

        ///<summary>Returns the minimum value of A and B</summary>
        public static int Min(int A, int B)  => 
            KismetMathLibrary_methods.Min_method.Invoke(A, B);

        ///<summary>
        ///Finds the minimum area rectangle that encloses all of the points in InVerts
        ///Uses algorithm found in http://www.
        ///</summary>
        ///<remarks>
        ///geometrictools.com/Documentation/MinimumAreaRectangle.pdf
        ///
        ///@param               InVerts - Points to enclose in the rectangle
        ///@outparam    OutRectCenter - Center of the enclosing rectangle
        ///@outparam    OutRectSideA - Vector oriented and sized to represent one edge of the enclosing rectangle, orthogonal to OutRectSideB
        ///@outparam    OutRectSideB - Vector oriented and sized to represent one edge of the enclosing rectangle, orthogonal to OutRectSideA
        ///</remarks>
        public static (Vector, Rotator, float, float) MinimumAreaRectangle(UObject WorldContextObject, byte InVerts /*TODO: array TArray */, Vector SampleSurfaceNormal, bool bDebugDraw)  => 
            KismetMathLibrary_methods.MinimumAreaRectangle_method.Invoke(WorldContextObject, InVerts, SampleSurfaceNormal, bDebugDraw);

        ///<summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
        public static (int, byte) MinOfByteArray(byte ByteArray /*TODO: array TArray */)  => 
            KismetMathLibrary_methods.MinOfByteArray_method.Invoke(ByteArray);

        ///<summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
        public static (int, float) MinOfFloatArray(byte FloatArray /*TODO: array TArray */)  => 
            KismetMathLibrary_methods.MinOfFloatArray_method.Invoke(FloatArray);

        ///<summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
        public static (int, int) MinOfIntArray(byte IntArray /*TODO: array TArray */)  => 
            KismetMathLibrary_methods.MinOfIntArray_method.Invoke(IntArray);

        ///<summary>Mirrors a vector by a normal</summary>
        public static Vector MirrorVectorByNormal(Vector InVect, Vector InNormal)  => 
            KismetMathLibrary_methods.MirrorVectorByNormal_method.Invoke(InVect, InNormal);

        ///<summary>Multiplication (A * B)</summary>
        public static byte Multiply_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.Multiply_ByteByte_method.Invoke(A, B);

        ///<summary>Multiplication (A * B)</summary>
        public static float Multiply_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.Multiply_FloatFloat_method.Invoke(A, B);

        ///<summary>Multiplication (A * B)</summary>
        public static float Multiply_IntFloat(int A, float B)  => 
            KismetMathLibrary_methods.Multiply_IntFloat_method.Invoke(A, B);

        ///<summary>Multiplication (A * B)</summary>
        public static int Multiply_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Multiply_IntInt_method.Invoke(A, B);

        ///<summary>Element-wise multiplication of a linear color by a float (F*R, F*G, F*B, F*A)</summary>
        public static LinearColor Multiply_LinearColorFloat(LinearColor A, float B)  => 
            KismetMathLibrary_methods.Multiply_LinearColorFloat_method.Invoke(A, B);

        ///<summary>Element-wise multiplication of two linear colors (R*R, G*G, B*B, A*A)</summary>
        public static LinearColor Multiply_LinearColorLinearColor(LinearColor A, LinearColor B)  => 
            KismetMathLibrary_methods.Multiply_LinearColorLinearColor_method.Invoke(A, B);

        ///<summary>Returns rotator representing rotator A scaled by B</summary>
        public static Rotator Multiply_RotatorFloat(Rotator A, float B)  => 
            KismetMathLibrary_methods.Multiply_RotatorFloat_method.Invoke(A, B);

        ///<summary>Returns rotator representing rotator A scaled by B</summary>
        public static Rotator Multiply_RotatorInt(Rotator A, int B)  => 
            KismetMathLibrary_methods.Multiply_RotatorInt_method.Invoke(A, B);

        ///<summary>Scalar multiplication (A * s)</summary>
        public static Timespan Multiply_TimespanFloat(Timespan A, float Scalar)  => 
            KismetMathLibrary_methods.Multiply_TimespanFloat_method.Invoke(A, Scalar);

        ///<summary>Returns Vector A scaled by B</summary>
        public static Vector2D Multiply_Vector2DFloat(Vector2D A, float B)  => 
            KismetMathLibrary_methods.Multiply_Vector2DFloat_method.Invoke(A, B);

        ///<summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y})</summary>
        public static Vector2D Multiply_Vector2DVector2D(Vector2D A, Vector2D B)  => 
            KismetMathLibrary_methods.Multiply_Vector2DVector2D_method.Invoke(A, B);

        ///<summary>Scales Vector A by B</summary>
        public static Vector Multiply_VectorFloat(Vector A, float B)  => 
            KismetMathLibrary_methods.Multiply_VectorFloat_method.Invoke(A, B);

        ///<summary>Scales Vector A by B</summary>
        public static Vector Multiply_VectorInt(Vector A, int B)  => 
            KismetMathLibrary_methods.Multiply_VectorInt_method.Invoke(A, B);

        ///<summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y, A.z*B.z})</summary>
        public static Vector Multiply_VectorVector(Vector A, Vector B)  => 
            KismetMathLibrary_methods.Multiply_VectorVector_method.Invoke(A, B);

        ///<summary>Multiplies the input value by pi.</summary>
        public static float MultiplyByPi(float Value)  => 
            KismetMathLibrary_methods.MultiplyByPi_method.Invoke(Value);

        ///<summary>Power (Base to the Exp-th power)</summary>
        public static float MultiplyMultiply_FloatFloat(float Base, float Exp)  => 
            KismetMathLibrary_methods.MultiplyMultiply_FloatFloat_method.Invoke(Base, Exp);

        ///<summary>Returns true if A is nearly equal to B (|A - B| < ErrorTolerance)</summary>
        public static bool NearlyEqual_FloatFloat(float A, float B, float ErrorTolerance)  => 
            KismetMathLibrary_methods.NearlyEqual_FloatFloat_method.Invoke(A, B, ErrorTolerance);

        ///<summary>
        ///Returns true if transform A is nearly equal to B
        ///@
        ///</summary>
        ///<remarks>
        ///param LocationTolerance        How close position of transforms need to be to be considered equal
        ///@param RotationTolerance        How close rotations of transforms need to be to be considered equal
        ///@param Scale3DTolerance         How close scale of transforms need to be to be considered equal
        ///</remarks>
        public static bool NearlyEqual_TransformTransform(Transform A, Transform B, float LocationTolerance, float RotationTolerance, float Scale3DTolerance)  => 
            KismetMathLibrary_methods.NearlyEqual_TransformTransform_method.Invoke(A, B, LocationTolerance, RotationTolerance, Scale3DTolerance);

        ///<summary>Negate a rotator</summary>
        public static Rotator NegateRotator(Rotator A)  => 
            KismetMathLibrary_methods.NegateRotator_method.Invoke(A);

        ///<summary>Negate a vector.</summary>
        public static Vector NegateVector(Vector A)  => 
            KismetMathLibrary_methods.NegateVector_method.Invoke(A);

        ///<summary>Returns a unit normal version of the FVector A</summary>
        public static Vector Normal(Vector A)  => 
            KismetMathLibrary_methods.Normal_method.Invoke(A);

        ///<summary>Returns a unit normal version of the vector2d A</summary>
        public static Vector2D Normal2D(Vector2D A)  => 
            KismetMathLibrary_methods.Normal2D_method.Invoke(A);

        ///<summary>Clamps an angle to the range of [-180, 180].</summary>
        ///<remarks>
        ///@param Angle The Angle to clamp.
        ///@return The clamped angle.
        ///</remarks>
        public static float NormalizeAxis(float Angle)  => 
            KismetMathLibrary_methods.NormalizeAxis_method.Invoke(Angle);

        ///<summary>Normalized A-B</summary>
        public static Rotator NormalizedDeltaRotator(Rotator A, Rotator B)  => 
            KismetMathLibrary_methods.NormalizedDeltaRotator_method.Invoke(A, B);

        ///<summary>Returns Value normalized to the given range.  (e.g. 20 normalized to the range 10->50 would result in 0.25)</summary>
        public static float NormalizeToRange(float Value, float RangeMin, float RangeMax)  => 
            KismetMathLibrary_methods.NormalizeToRange_method.Invoke(Value, RangeMin, RangeMax);

        ///<summary>Bitwise NOT (~A)</summary>
        public static int Not_Int(int A)  => 
            KismetMathLibrary_methods.Not_Int_method.Invoke(A);

        ///<summary>Returns the logical complement of the Boolean value (NOT A)</summary>
        public static bool Not_PreBool(bool A)  => 
            KismetMathLibrary_methods.Not_PreBool_method.Invoke(A);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_BoolBool(bool A, bool B)  => 
            KismetMathLibrary_methods.NotEqual_BoolBool_method.Invoke(A, B);

        ///<summary>Returns true if A is not equal to B (A != B)</summary>
        public static bool NotEqual_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.NotEqual_ByteByte_method.Invoke(A, B);

        ///<summary>Returns true if A and B are not equal (A != B)</summary>
        public static bool NotEqual_ClassClass(SubclassOf<UObject> A, SubclassOf<UObject> B)  => 
            KismetMathLibrary_methods.NotEqual_ClassClass_method.Invoke(A, B);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_DateTimeDateTime(FDateTime A, FDateTime B)  => 
            KismetMathLibrary_methods.NotEqual_DateTimeDateTime_method.Invoke(A, B);

        ///<summary>Returns true if A does not equal B (A != B)</summary>
        public static bool NotEqual_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.NotEqual_FloatFloat_method.Invoke(A, B);

        ///<summary>Returns true if A is not equal to B (A != B)</summary>
        public static bool NotEqual_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.NotEqual_IntInt_method.Invoke(A, B);

        ///<summary>Returns true if A and B are not equal (A != B)</summary>
        public static bool NotEqual_NameName(Name A, Name B)  => 
            KismetMathLibrary_methods.NotEqual_NameName_method.Invoke(A, B);

        ///<summary>Returns true if A and B are not equal (A != B)</summary>
        public static bool NotEqual_ObjectObject(UObject A, UObject B)  => 
            KismetMathLibrary_methods.NotEqual_ObjectObject_method.Invoke(A, B);

        ///<summary>Returns true if rotator A is not equal to rotator B (A != B) within a specified error tolerance</summary>
        public static bool NotEqual_RotatorRotator(Rotator A, Rotator B, float ErrorTolerance)  => 
            KismetMathLibrary_methods.NotEqual_RotatorRotator_method.Invoke(A, B, ErrorTolerance);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.NotEqual_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns true if vector2D A is not equal to vector2D B (A != B) within a specified error tolerance</summary>
        public static bool NotEqual_Vector2DVector2D(Vector2D A, Vector2D B, float ErrorTolerance)  => 
            KismetMathLibrary_methods.NotEqual_Vector2DVector2D_method.Invoke(A, B, ErrorTolerance);

        ///<summary>Returns true if vector A is not equal to vector B (A != B) within a specified error tolerance</summary>
        public static bool NotEqual_VectorVector(Vector A, Vector B, float ErrorTolerance)  => 
            KismetMathLibrary_methods.NotEqual_VectorVector_method.Invoke(A, B, ErrorTolerance);

        ///<summary>Returns the local date and time on this computer</summary>
        public static FDateTime Now()  => 
            KismetMathLibrary_methods.Now_method.Invoke();

        ///<summary>Bitwise OR (A | B)</summary>
        public static int Or_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Or_IntInt_method.Invoke(A, B);

        ///<summary>Modulo (A % B)</summary>
        public static byte Percent_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.Percent_ByteByte_method.Invoke(A, B);

        ///<summary>Modulo (A % B)</summary>
        public static float Percent_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.Percent_FloatFloat_method.Invoke(A, B);

        ///<summary>Modulo (A % B)</summary>
        public static int Percent_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Percent_IntInt_method.Invoke(A, B);

        ///<summary>Generates a 1D Perlin noise from the given value.</summary>
        ///<remarks>
        ///Returns a continuous random value between -1.0 and 1.0.
        ///
        ///@param       Value   The input value that Perlin noise will be generated from.  This is usually a steadily incrementing time value.
        ///
        ///@return      Perlin noise in the range of -1.0 to 1.0
        ///</remarks>
        public static float PerlinNoise1D(float Value)  => 
            KismetMathLibrary_methods.PerlinNoise1D_method.Invoke(Value);

        ///<summary>Determines whether a given set of points are coplanar, with a tolerance.</summary>
        ///<remarks>
        ///Any three points or less are always coplanar.
        ///
        ///@param Points - The set of points to determine coplanarity for.
        ///@param Tolerance - Larger numbers means more variance is allowed.
        ///
        ///@return Whether the points are relatively coplanar, based on the tolerance
        ///</remarks>
        public static bool PointsAreCoplanar(byte Points /*TODO: array TArray */, float Tolerance)  => 
            KismetMathLibrary_methods.PointsAreCoplanar_method.Invoke(Points, Tolerance);

        ///<summary>Projects a point onto a plane defined by a point on the plane and a plane normal.</summary>
        ///<remarks>
        ///@param  Point Point to project onto the plane.
        ///@param  PlaneBase A point on the plane.
        ///@param  PlaneNormal Normal of the plane.
        ///@return Point projected onto the plane.
        ///</remarks>
        public static Vector ProjectPointOnToPlane(Vector Point, Vector PlaneBase, Vector PlaneNormal)  => 
            KismetMathLibrary_methods.ProjectPointOnToPlane_method.Invoke(Point, PlaneBase, PlaneNormal);

        ///<summary>Projects a vector onto a plane defined by a normalized vector (PlaneNormal).</summary>
        ///<remarks>
        ///@param  V Vector to project onto the plane.
        ///@param  PlaneNormal Normal of the plane.
        ///@return Vector projected onto the plane.
        ///</remarks>
        public static Vector ProjectVectorOnToPlane(Vector V, Vector PlaneNormal)  => 
            KismetMathLibrary_methods.ProjectVectorOnToPlane_method.Invoke(V, PlaneNormal);

        ///<summary>Projects one vector (V) onto another (Target) and returns the projected vector.</summary>
        ///<remarks>
        ///If Target is nearly zero in length, returns the zero vector.
        ///
        ///@param  V Vector to project.
        ///@param  Target Vector on which we are projecting.
        ///@return V projected on to Target.
        ///</remarks>
        public static Vector ProjectVectorOnToVector(Vector V, Vector Target)  => 
            KismetMathLibrary_methods.ProjectVectorOnToVector_method.Invoke(V, Target);

        ///<summary>Returns degrees value based on the input radians</summary>
        public static float RadiansToDegrees(float A)  => 
            KismetMathLibrary_methods.RadiansToDegrees_method.Invoke(A);

        ///<summary>Returns a uniformly distributed random bool</summary>
        public static bool RandomBool()  => 
            KismetMathLibrary_methods.RandomBool_method.Invoke();

        ///<summary>Returns a random bool</summary>
        public static bool RandomBoolFromStream(RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomBoolFromStream_method.Invoke(Stream);

        ///<summary>Get a random chance with the specified weight.</summary>
        ///<remarks>
        ///Range of weight is 0.0 - 1.0 E.g.,
        ///             Weight = .6 return value = True 60% of the time
        ///</remarks>
        public static bool RandomBoolWithWeight(float Weight)  => 
            KismetMathLibrary_methods.RandomBoolWithWeight_method.Invoke(Weight);

        ///<summary>Get a random chance with the specified weight.</summary>
        ///<remarks>
        ///Range of weight is 0.0 - 1.0 E.g.,
        ///              Weight = .6 return value = True 60% of the time
        ///</remarks>
        public static bool RandomBoolWithWeightFromStream(float Weight, RandomStream RandomStream)  => 
            KismetMathLibrary_methods.RandomBoolWithWeightFromStream_method.Invoke(Weight, RandomStream);

        ///<summary>Returns a random float between 0 and 1</summary>
        public static float RandomFloat()  => 
            KismetMathLibrary_methods.RandomFloat_method.Invoke();

        ///<summary>Returns a random float between 0 and 1</summary>
        public static float RandomFloatFromStream(RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomFloatFromStream_method.Invoke(Stream);

        ///<summary>Generate a random number between Min and Max</summary>
        public static float RandomFloatInRange(float Min, float Max)  => 
            KismetMathLibrary_methods.RandomFloatInRange_method.Invoke(Min, Max);

        ///<summary>Generate a random number between Min and Max</summary>
        public static float RandomFloatInRangeFromStream(float Min, float Max, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomFloatInRangeFromStream_method.Invoke(Min, Max, Stream);

        ///<summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
        public static int RandomInteger(int Max)  => 
            KismetMathLibrary_methods.RandomInteger_method.Invoke(Max);

        ///<summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
        public static int RandomIntegerFromStream(int Max, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomIntegerFromStream_method.Invoke(Max, Stream);

        ///<summary>Return a random integer between Min and Max (>= Min and <= Max)</summary>
        public static int RandomIntegerInRange(int Min, int Max)  => 
            KismetMathLibrary_methods.RandomIntegerInRange_method.Invoke(Min, Max);

        ///<summary>Return a random integer between Min and Max (>= Min and <= Max)</summary>
        public static int RandomIntegerInRangeFromStream(int Min, int Max, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomIntegerInRangeFromStream_method.Invoke(Min, Max, Stream);

        ///<summary>Returns a random point within the specified bounding box</summary>
        public static Vector RandomPointInBoundingBox(Vector Origin, Vector BoxExtent)  => 
            KismetMathLibrary_methods.RandomPointInBoundingBox_method.Invoke(Origin, BoxExtent);

        ///<summary>Generates a random rotation, with optional random roll.</summary>
        public static Rotator RandomRotator(bool bRoll)  => 
            KismetMathLibrary_methods.RandomRotator_method.Invoke(bRoll);

        ///<summary>Create a random rotation</summary>
        public static Rotator RandomRotatorFromStream(bool bRoll, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomRotatorFromStream_method.Invoke(bRoll, Stream);

        ///<summary>Returns a random vector with length of 1</summary>
        public static Vector RandomUnitVector()  => 
            KismetMathLibrary_methods.RandomUnitVector_method.Invoke();

        ///<summary>Returns a random vector with length of 1.0</summary>
        public static Vector RandomUnitVectorFromStream(RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomUnitVectorFromStream_method.Invoke(Stream);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///@param ConeDir                                       The base "center" direction of the cone.
        ///@param ConeHalfAngleInDegrees        The half-angle of the cone (from ConeDir to edge), in degrees.
        ///</remarks>
        public static Vector RandomUnitVectorInConeInDegrees(Vector ConeDir, float ConeHalfAngleInDegrees)  => 
            KismetMathLibrary_methods.RandomUnitVectorInConeInDegrees_method.Invoke(ConeDir, ConeHalfAngleInDegrees);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///@param ConeDir                                       The base "center" direction of the cone.
        ///@param ConeHalfAngleInDegrees        The half-angle of the cone (from ConeDir to edge), in degrees.
        ///@param Stream                                        The random stream from which to obtain the vector.
        ///</remarks>
        public static Vector RandomUnitVectorInConeInDegreesFromStream(Vector ConeDir, float ConeHalfAngleInDegrees, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomUnitVectorInConeInDegreesFromStream_method.Invoke(ConeDir, ConeHalfAngleInDegrees, Stream);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///@param ConeDir                                       The base "center" direction of the cone.
        ///@param ConeHalfAngleInRadians        The half-angle of the cone (from ConeDir to edge), in radians.
        ///</remarks>
        public static Vector RandomUnitVectorInConeInRadians(Vector ConeDir, float ConeHalfAngleInRadians)  => 
            KismetMathLibrary_methods.RandomUnitVectorInConeInRadians_method.Invoke(ConeDir, ConeHalfAngleInRadians);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///@param ConeDir                                       The base "center" direction of the cone.
        ///@param ConeHalfAngleInRadians        The half-angle of the cone (from ConeDir to edge), in radians.
        ///@param Stream                                        The random stream from which to obtain the vector.
        ///</remarks>
        public static Vector RandomUnitVectorInConeInRadiansFromStream(Vector ConeDir, float ConeHalfAngleInRadians, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomUnitVectorInConeInRadiansFromStream_method.Invoke(ConeDir, ConeHalfAngleInRadians, Stream);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///The shape of the cone can be modified according to the yaw and pitch angles.
        ///
        ///@param MaxYawInDegrees        The yaw angle of the cone (from ConeDir to horizontal edge), in degrees.
        ///@param MaxPitchInDegrees      The pitch angle of the cone (from ConeDir to vertical edge), in degrees.
        ///</remarks>
        public static Vector RandomUnitVectorInEllipticalConeInDegrees(Vector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees)  => 
            KismetMathLibrary_methods.RandomUnitVectorInEllipticalConeInDegrees_method.Invoke(ConeDir, MaxYawInDegrees, MaxPitchInDegrees);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///The shape of the cone can be modified according to the yaw and pitch angles.
        ///
        ///@param MaxYawInDegrees        The yaw angle of the cone (from ConeDir to horizontal edge), in degrees.
        ///@param MaxPitchInDegrees      The pitch angle of the cone (from ConeDir to vertical edge), in degrees.
        ///@param Stream                         The random stream from which to obtain the vector.
        ///</remarks>
        public static Vector RandomUnitVectorInEllipticalConeInDegreesFromStream(Vector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomUnitVectorInEllipticalConeInDegreesFromStream_method.Invoke(ConeDir, MaxYawInDegrees, MaxPitchInDegrees, Stream);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///The shape of the cone can be modified according to the yaw and pitch angles.
        ///
        ///@param MaxYawInRadians        The yaw angle of the cone (from ConeDir to horizontal edge), in radians.
        ///@param MaxPitchInRadians      The pitch angle of the cone (from ConeDir to vertical edge), in radians.
        ///</remarks>
        public static Vector RandomUnitVectorInEllipticalConeInRadians(Vector ConeDir, float MaxYawInRadians, float MaxPitchInRadians)  => 
            KismetMathLibrary_methods.RandomUnitVectorInEllipticalConeInRadians_method.Invoke(ConeDir, MaxYawInRadians, MaxPitchInRadians);

        ///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
        ///<remarks>
        ///The shape of the cone can be modified according to the yaw and pitch angles.
        ///
        ///@param MaxYawInRadians        The yaw angle of the cone (from ConeDir to horizontal edge), in radians.
        ///@param MaxPitchInRadians      The pitch angle of the cone (from ConeDir to vertical edge), in radians.
        ///@param Stream                         The random stream from which to obtain the vector.
        ///</remarks>
        public static Vector RandomUnitVectorInEllipticalConeInRadiansFromStream(Vector ConeDir, float MaxYawInRadians, float MaxPitchInRadians, RandomStream Stream)  => 
            KismetMathLibrary_methods.RandomUnitVectorInEllipticalConeInRadiansFromStream_method.Invoke(ConeDir, MaxYawInRadians, MaxPitchInRadians, Stream);

        ///<summary>Easeing  between A and B using a specified easing function</summary>
        public static Rotator REase(Rotator A, Rotator B, float Alpha, bool bShortestPath, byte EasingFunc, float BlendExp, int Steps)  => 
            KismetMathLibrary_methods.REase_method.Invoke(A, B, Alpha, bShortestPath, EasingFunc, BlendExp, Steps);

        ///<summary>Resets the state of a given spring</summary>
        public static void ResetFloatSpringState(FloatSpringState SpringState)  => 
            KismetMathLibrary_methods.ResetFloatSpringState_method.Invoke(SpringState);

        ///<summary>Reset a random stream</summary>
        public static void ResetRandomStream(RandomStream Stream)  => 
            KismetMathLibrary_methods.ResetRandomStream_method.Invoke(Stream);

        ///<summary>Resets the state of a given spring</summary>
        public static void ResetVectorSpringState(VectorSpringState SpringState)  => 
            KismetMathLibrary_methods.ResetVectorSpringState_method.Invoke(SpringState);

        ///<summary>Breaks apart a color into individual HSV components (as well as alpha) (Hue is [0..360) while Saturation and Value are 0..1)</summary>
        public static (float, float, float, float) RGBToHSV(LinearColor InColor)  => 
            KismetMathLibrary_methods.RGBToHSV_method.Invoke(InColor);

        ///<summary>Converts a RGB linear color to HSV (where H is in R (0..360), S is in G (0..1), and V is in B (0..1))</summary>
        public static LinearColor RGBToHSV_Vector(LinearColor RGB)  => 
            KismetMathLibrary_methods.RGBToHSV_Vector_method.Invoke(RGB);

        ///<summary>Tries to reach Target rotation based on Current rotation, giving a nice smooth feeling when rotating to Target rotation.</summary>
        ///<remarks>
        ///@param               Current                 Actual rotation
        ///@param               Target                  Target rotation
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static Rotator RInterpTo(Rotator Current, Rotator Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.RInterpTo_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Tries to reach Target rotation at a constant rate.</summary>
        ///<remarks>
        ///@param               Current                 Actual rotation
        ///@param               Target                  Target rotation
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static Rotator RInterpTo_Constant(Rotator Current, Rotator Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.RInterpTo_Constant_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
        public static Rotator RLerp(Rotator A, Rotator B, float Alpha, bool bShortestPath)  => 
            KismetMathLibrary_methods.RLerp_method.Invoke(A, B, Alpha, bShortestPath);

        ///<summary>Returns result of vector A rotated by AngleDeg around Axis</summary>
        public static Vector RotateAngleAxis(Vector InVect, float AngleDeg, Vector Axis)  => 
            KismetMathLibrary_methods.RotateAngleAxis_method.Invoke(InVect, AngleDeg, Axis);

        ///<summary>Create a rotation from an axis and and angle (in degrees)</summary>
        public static Rotator RotatorFromAxisAndAngle(Vector Axis, float Angle)  => 
            KismetMathLibrary_methods.RotatorFromAxisAndAngle_method.Invoke(Axis, Angle);

        ///<summary>Rounds A to the nearest integer</summary>
        public static int Round(float A)  => 
            KismetMathLibrary_methods.Round_method.Invoke(A);

        ///<summary>Create a new random seed for a random stream</summary>
        public static void SeedRandomStream(RandomStream Stream)  => 
            KismetMathLibrary_methods.SeedRandomStream_method.Invoke(Stream);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static SubclassOf<UObject> SelectClass(SubclassOf<UObject> A, SubclassOf<UObject> B, bool bSelectA)  => 
            KismetMathLibrary_methods.SelectClass_method.Invoke(A, B, bSelectA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static LinearColor SelectColor(LinearColor A, LinearColor B, bool bPickA)  => 
            KismetMathLibrary_methods.SelectColor_method.Invoke(A, B, bPickA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static float SelectFloat(float A, float B, bool bPickA)  => 
            KismetMathLibrary_methods.SelectFloat_method.Invoke(A, B, bPickA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static int SelectInt(int A, int B, bool bPickA)  => 
            KismetMathLibrary_methods.SelectInt_method.Invoke(A, B, bPickA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static UObject SelectObject(UObject A, UObject B, bool bSelectA)  => 
            KismetMathLibrary_methods.SelectObject_method.Invoke(A, B, bSelectA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static Rotator SelectRotator(Rotator A, Rotator B, bool bPickA)  => 
            KismetMathLibrary_methods.SelectRotator_method.Invoke(A, B, bPickA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static string SelectString(string A, string B, bool bPickA)  => 
            KismetMathLibrary_methods.SelectString_method.Invoke(A, B, bPickA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static Transform SelectTransform(Transform A, Transform B, bool bPickA)  => 
            KismetMathLibrary_methods.SelectTransform_method.Invoke(A, B, bPickA);

        ///<summary>If bPickA is true, A is returned, otherwise B is</summary>
        public static Vector SelectVector(Vector A, Vector B, bool bPickA)  => 
            KismetMathLibrary_methods.SelectVector_method.Invoke(A, B, bPickA);

        ///<summary>Set the seed of a random stream to a specific number</summary>
        public static void SetRandomStreamSeed(RandomStream Stream, int NewSeed)  => 
            KismetMathLibrary_methods.SetRandomStreamSeed_method.Invoke(Stream, NewSeed);

        ///<summary>Sign (float, returns -1 if A < 0, 0 if A is zero, and +1 if A > 0)</summary>
        public static float SignOfFloat(float A)  => 
            KismetMathLibrary_methods.SignOfFloat_method.Invoke(A);

        ///<summary>Sign (integer, returns -1 if A < 0, 0 if A is zero, and +1 if A > 0)</summary>
        public static int SignOfInteger(int A)  => 
            KismetMathLibrary_methods.SignOfInteger_method.Invoke(A);

        ///<summary>Returns the sine of A (expects Radians)</summary>
        public static float Sin(float A)  => 
            KismetMathLibrary_methods.Sin_method.Invoke(A);

        ///<summary>Returns square root of A</summary>
        public static float Sqrt(float A)  => 
            KismetMathLibrary_methods.Sqrt_method.Invoke(A);

        ///<summary>Returns square of A (A*A)</summary>
        public static float Square(float A)  => 
            KismetMathLibrary_methods.Square_method.Invoke(A);

        ///<summary>Subtraction (A - B)</summary>
        public static byte Subtract_ByteByte(byte A, byte B)  => 
            KismetMathLibrary_methods.Subtract_ByteByte_method.Invoke(A, B);

        ///<summary>Subtraction (A - B)</summary>
        public static Timespan Subtract_DateTimeDateTime(FDateTime A, FDateTime B)  => 
            KismetMathLibrary_methods.Subtract_DateTimeDateTime_method.Invoke(A, B);

        ///<summary>Subtraction (A - B)</summary>
        public static FDateTime Subtract_DateTimeTimespan(FDateTime A, Timespan B)  => 
            KismetMathLibrary_methods.Subtract_DateTimeTimespan_method.Invoke(A, B);

        ///<summary>Subtraction (A - B)</summary>
        public static float Subtract_FloatFloat(float A, float B)  => 
            KismetMathLibrary_methods.Subtract_FloatFloat_method.Invoke(A, B);

        ///<summary>Subtraction (A - B)</summary>
        public static int Subtract_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Subtract_IntInt_method.Invoke(A, B);

        ///<summary>Subtraction (A - B)</summary>
        public static Timespan Subtract_TimespanTimespan(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.Subtract_TimespanTimespan_method.Invoke(A, B);

        ///<summary>Returns Vector A subtracted by B</summary>
        public static Vector2D Subtract_Vector2DFloat(Vector2D A, float B)  => 
            KismetMathLibrary_methods.Subtract_Vector2DFloat_method.Invoke(A, B);

        ///<summary>Returns subtraction of Vector B from Vector A (A - B)</summary>
        public static Vector2D Subtract_Vector2DVector2D(Vector2D A, Vector2D B)  => 
            KismetMathLibrary_methods.Subtract_Vector2DVector2D_method.Invoke(A, B);

        ///<summary>Subtracts a float from each component of a vector</summary>
        public static Vector Subtract_VectorFloat(Vector A, float B)  => 
            KismetMathLibrary_methods.Subtract_VectorFloat_method.Invoke(A, B);

        ///<summary>Subtracts an integer from each component of a vector</summary>
        public static Vector Subtract_VectorInt(Vector A, int B)  => 
            KismetMathLibrary_methods.Subtract_VectorInt_method.Invoke(A, B);

        ///<summary>Vector subtraction</summary>
        public static Vector Subtract_VectorVector(Vector A, Vector B)  => 
            KismetMathLibrary_methods.Subtract_VectorVector_method.Invoke(A, B);

        ///<summary>Returns the tan of A (expects Radians)</summary>
        public static float Tan(float A)  => 
            KismetMathLibrary_methods.Tan_method.Invoke(A);

        ///<summary>Ease between A and B using a specified easing function.</summary>
        public static Transform TEase(Transform A, Transform B, float Alpha, byte EasingFunc, float BlendExp, int Steps)  => 
            KismetMathLibrary_methods.TEase_method.Invoke(A, B, Alpha, EasingFunc, BlendExp, Steps);

        ///<summary>Converts a time span string to a Timespan object</summary>
        public static (Timespan, bool) TimespanFromString(string TimespanString)  => 
            KismetMathLibrary_methods.TimespanFromString_method.Invoke(TimespanString);

        ///<summary>Returns the maximum time span value</summary>
        public static Timespan TimespanMaxValue()  => 
            KismetMathLibrary_methods.TimespanMaxValue_method.Invoke();

        ///<summary>Returns the minimum time span value</summary>
        public static Timespan TimespanMinValue()  => 
            KismetMathLibrary_methods.TimespanMinValue_method.Invoke();

        ///<summary>Returns the ratio between two time spans (A / B), handles zero values</summary>
        public static float TimespanRatio(Timespan A, Timespan B)  => 
            KismetMathLibrary_methods.TimespanRatio_method.Invoke(A, B);

        ///<summary>Returns a zero time span value</summary>
        public static Timespan TimespanZeroValue()  => 
            KismetMathLibrary_methods.TimespanZeroValue_method.Invoke();

        ///<summary>Tries to reach a target transform.</summary>
        public static Transform TInterpTo(Transform Current, Transform Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.TInterpTo_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1).</summary>
        public static Transform TLerp(Transform A, Transform B, float Alpha, byte InterpMode)  => 
            KismetMathLibrary_methods.TLerp_method.Invoke(A, B, Alpha, InterpMode);

        ///<summary>Returns the local date on this computer</summary>
        public static FDateTime Today()  => 
            KismetMathLibrary_methods.Today_method.Invoke();

        ///<summary>Calculates the determinant of the transform (converts to FMatrix internally)</summary>
        public static float Transform_Determinant(Transform Transform)  => 
            KismetMathLibrary_methods.Transform_Determinant_method.Invoke(Transform);

        ///<summary>Transform a direction vector by the supplied transform - will not change its length.</summary>
        ///<remarks>For example, if T was an object's transform, this would transform a direction from local space to world space.</remarks>
        public static Vector TransformDirection(Transform T, Vector Direction)  => 
            KismetMathLibrary_methods.TransformDirection_method.Invoke(T, Direction);

        ///<summary>Transform a position by the supplied transform.</summary>
        ///<remarks>For example, if T was an object's transform, this would transform a position from local space to world space.</remarks>
        public static Vector TransformLocation(Transform T, Vector Location)  => 
            KismetMathLibrary_methods.TransformLocation_method.Invoke(T, Location);

        ///<summary>Transform a rotator by the supplied transform.</summary>
        ///<remarks>For example, if T was an object's transform, this would transform a rotation from local space to world space.</remarks>
        public static Rotator TransformRotation(Transform T, Rotator Rotation)  => 
            KismetMathLibrary_methods.TransformRotation_method.Invoke(T, Rotation);

        ///<summary>Returns the UTC date and time on this computer</summary>
        public static FDateTime UtcNow()  => 
            KismetMathLibrary_methods.UtcNow_method.Invoke();

        ///<summary>Easeing  between A and B using a specified easing function</summary>
        public static Vector VEase(Vector A, Vector B, float Alpha, byte EasingFunc, float BlendExp, int Steps)  => 
            KismetMathLibrary_methods.VEase_method.Invoke(A, B, Alpha, EasingFunc, BlendExp, Steps);

        ///<summary>Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.</summary>
        ///<remarks>
        ///@param               Current                 Actual position
        ///@param               Target                  Target position
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static Vector2D Vector2DInterpTo(Vector2D Current, Vector2D Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.Vector2DInterpTo_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Tries to reach Target at a constant rate.</summary>
        ///<remarks>
        ///@param               Current                 Actual position
        ///@param               Target                  Target position
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static Vector2D Vector2DInterpTo_Constant(Vector2D Current, Vector2D Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.Vector2DInterpTo_Constant_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Uses a simple spring model to interpolate a vector from Current to Target.</summary>
        ///<remarks>
        ///@param Current                                Current value
        ///@param Target                                 Target value
        ///@param SpringState                    Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
        ///@param Stiffness                              How stiff the spring model is (more stiffness means more oscillation around the target value)
        ///@param CriticalDampingFactor  How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
        ///@param Mass                                   Multiplier that acts like mass on a spring
        ///</remarks>
        public static Vector VectorSpringInterp(Vector Current, Vector Target, VectorSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass)  => 
            KismetMathLibrary_methods.VectorSpringInterp_method.Invoke(Current, Target, SpringState, Stiffness, CriticalDampingFactor, DeltaTime, Mass);

        ///<summary>Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.</summary>
        ///<remarks>
        ///@param               Current                 Actual position
        ///@param               Target                  Target position
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static Vector VInterpTo(Vector Current, Vector Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.VInterpTo_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Tries to reach Target at a constant rate.</summary>
        ///<remarks>
        ///@param               Current                 Actual position
        ///@param               Target                  Target position
        ///@param               DeltaTime               Time since last tick
        ///@param               InterpSpeed             Interpolation speed
        ///@return              New interpolated position
        ///</remarks>
        public static Vector VInterpTo_Constant(Vector Current, Vector Target, float DeltaTime, float InterpSpeed)  => 
            KismetMathLibrary_methods.VInterpTo_Constant_method.Invoke(Current, Target, DeltaTime, InterpSpeed);

        ///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
        public static Vector VLerp(Vector A, Vector B, float Alpha)  => 
            KismetMathLibrary_methods.VLerp_method.Invoke(A, B, Alpha);

        ///<summary>Returns the length of the FVector</summary>
        public static float VSize(Vector A)  => 
            KismetMathLibrary_methods.VSize_method.Invoke(A);

        ///<summary>Returns the length of a 2d FVector.</summary>
        public static float VSize2D(Vector2D A)  => 
            KismetMathLibrary_methods.VSize2D_method.Invoke(A);

        ///<summary>Returns the squared length of a 2d FVector.</summary>
        public static float VSize2DSquared(Vector2D A)  => 
            KismetMathLibrary_methods.VSize2DSquared_method.Invoke(A);

        ///<summary>Returns the squared length of the FVector</summary>
        public static float VSizeSquared(Vector A)  => 
            KismetMathLibrary_methods.VSizeSquared_method.Invoke(A);

        ///<summary>Returns the length of the FVector's in XY components.</summary>
        public static float VSizeXY(Vector A)  => 
            KismetMathLibrary_methods.VSizeXY_method.Invoke(A);

        ///<summary>Bitwise XOR (A ^ B)</summary>
        public static int Xor_IntInt(int A, int B)  => 
            KismetMathLibrary_methods.Xor_IntInt_method.Invoke(A, B);
        static KismetMathLibrary() {
            StaticClass = Main.GetClass("KismetMathLibrary");
        }
        internal unsafe KismetMathLibrary_fields* KismetMathLibrary_ptr => (KismetMathLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetMathLibrary(IntPtr p) => UObject.Make<KismetMathLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetMathLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetMathLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
