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
    ///<summary>Kismet Text Library</summary>
    public unsafe partial class KismetTextLibrary : BlueprintFunctionLibrary  {

        ///<summary>Converts a passed in float to a text formatted as a currency</summary>
        public static byte /*TODO: text FText*/ AsCurrency_Float(float Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits, string CurrencyCode)  => 
            KismetTextLibrary_methods.AsCurrency_Float_method.Invoke(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits, CurrencyCode);

        ///<summary>Converts a passed in integer to a text formatted as a currency</summary>
        public static byte /*TODO: text FText*/ AsCurrency_Integer(int Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits, string CurrencyCode)  => 
            KismetTextLibrary_methods.AsCurrency_Integer_method.Invoke(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits, CurrencyCode);

        ///<summary>Generate an FText that represents the passed number as currency in the current culture.</summary>
        ///<remarks>
        ///BaseVal is specified in the smallest fractional value of the currency and will be converted for formatting according to the selected culture.
        ///Keep in mind the CurrencyCode is completely independent of the culture it's displayed in (and they do not imply one another).
        ///For example: FText::AsCurrencyBase(650, TEXT("EUR")); would return an FText of "<EUR>6.50" in most English cultures (en_US/en_UK) and "6,50<EUR>" in Spanish (es_ES) (where <EUR> is U+20AC)
        ///</remarks>
        public static byte /*TODO: text FText*/ AsCurrencyBase(int BaseValue, string CurrencyCode)  => 
            KismetTextLibrary_methods.AsCurrencyBase_method.Invoke(BaseValue, CurrencyCode);

        ///<summary>Converts a passed in date & time to a text, formatted as a date using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
        public static byte /*TODO: text FText*/ AsDate_DateTime(FDateTime InDateTime)  => 
            KismetTextLibrary_methods.AsDate_DateTime_method.Invoke(InDateTime);

        ///<summary>Converts a passed in date & time to a text, formatted as a date & time using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
        public static byte /*TODO: text FText*/ AsDateTime_DateTime(FDateTime In)  => 
            KismetTextLibrary_methods.AsDateTime_DateTime_method.Invoke(In);

        ///<summary>Converts a passed in float to a text, formatted as a percent</summary>
        public static byte /*TODO: text FText*/ AsPercent_Float(float Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits)  => 
            KismetTextLibrary_methods.AsPercent_Float_method.Invoke(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits);

        ///<summary>Converts a passed in date & time to a text, formatted as a time using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
        public static byte /*TODO: text FText*/ AsTime_DateTime(FDateTime In)  => 
            KismetTextLibrary_methods.AsTime_DateTime_method.Invoke(In);

        ///<summary>Converts a passed in time span to a text, formatted as a time span</summary>
        public static byte /*TODO: text FText*/ AsTimespan_Timespan(Timespan InTimespan)  => 
            KismetTextLibrary_methods.AsTimespan_Timespan_method.Invoke(InTimespan);

        ///<summary>Converts a passed in date & time to a text, formatted as a date using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
        public static byte /*TODO: text FText*/ AsTimeZoneDate_DateTime(FDateTime InDateTime, string InTimeZone)  => 
            KismetTextLibrary_methods.AsTimeZoneDate_DateTime_method.Invoke(InDateTime, InTimeZone);

        ///<summary>Converts a passed in date & time to a text, formatted as a date & time using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
        public static byte /*TODO: text FText*/ AsTimeZoneDateTime_DateTime(FDateTime InDateTime, string InTimeZone)  => 
            KismetTextLibrary_methods.AsTimeZoneDateTime_DateTime_method.Invoke(InDateTime, InTimeZone);

        ///<summary>Converts a passed in date & time to a text, formatted as a time using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
        public static byte /*TODO: text FText*/ AsTimeZoneTime_DateTime(FDateTime InDateTime, string InTimeZone)  => 
            KismetTextLibrary_methods.AsTimeZoneTime_DateTime_method.Invoke(InDateTime, InTimeZone);

        ///<summary>Converts a boolean value to formatted text, either 'true' or 'false'</summary>
        public static byte /*TODO: text FText*/ Conv_BoolToText(bool InBool)  => 
            KismetTextLibrary_methods.Conv_BoolToText_method.Invoke(InBool);

        ///<summary>Converts a byte value to formatted text</summary>
        public static byte /*TODO: text FText*/ Conv_ByteToText(byte Value)  => 
            KismetTextLibrary_methods.Conv_ByteToText_method.Invoke(Value);

        ///<summary>Converts a linear color value to localized formatted text, in the form '(R=,G=,B=,A=)'</summary>
        public static byte /*TODO: text FText*/ Conv_ColorToText(LinearColor InColor)  => 
            KismetTextLibrary_methods.Conv_ColorToText_method.Invoke(InColor);

        ///<summary>Converts a passed in float to text based on formatting options</summary>
        public static byte /*TODO: text FText*/ Conv_FloatToText(float Value, byte RoundingMode, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits, int MinimumFractionalDigits, int MaximumFractionalDigits)  => 
            KismetTextLibrary_methods.Conv_FloatToText_method.Invoke(Value, RoundingMode, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits, MinimumFractionalDigits, MaximumFractionalDigits);

        ///<summary>Converts a passed in integer to text based on formatting options</summary>
        public static byte /*TODO: text FText*/ Conv_IntToText(int Value, bool bAlwaysSign, bool bUseGrouping, int MinimumIntegralDigits, int MaximumIntegralDigits)  => 
            KismetTextLibrary_methods.Conv_IntToText_method.Invoke(Value, bAlwaysSign, bUseGrouping, MinimumIntegralDigits, MaximumIntegralDigits);

        ///<summary>Converts Name to culture invariant text</summary>
        public static byte /*TODO: text FText*/ Conv_NameToText(Name InName)  => 
            KismetTextLibrary_methods.Conv_NameToText_method.Invoke(InName);

        ///<summary>Converts a UObject value to culture invariant text by calling the object's GetName method</summary>
        public static byte /*TODO: text FText*/ Conv_ObjectToText(UObject InObj)  => 
            KismetTextLibrary_methods.Conv_ObjectToText_method.Invoke(InObj);

        ///<summary>Converts a rotator value to localized formatted text, in the form 'P= Y= R='</summary>
        public static byte /*TODO: text FText*/ Conv_RotatorToText(Rotator InRot)  => 
            KismetTextLibrary_methods.Conv_RotatorToText_method.Invoke(InRot);

        ///<summary>Converts string to culture invariant text. Use Format or Make Literal Text to create localizable text</summary>
        public static byte /*TODO: text FText*/ Conv_StringToText(string InString)  => 
            KismetTextLibrary_methods.Conv_StringToText_method.Invoke(InString);

        ///<summary>Converts localizable text to the string</summary>
        public static string Conv_TextToString(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.Conv_TextToString_method.Invoke(InText);

        ///<summary>Converts a transform value to localized formatted text, in the form 'Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z='</summary>
        public static byte /*TODO: text FText*/ Conv_TransformToText(Transform InTrans)  => 
            KismetTextLibrary_methods.Conv_TransformToText_method.Invoke(InTrans);

        ///<summary>Converts a vector2d value to localized formatted text, in the form 'X= Y='</summary>
        public static byte /*TODO: text FText*/ Conv_Vector2dToText(Vector2D InVec)  => 
            KismetTextLibrary_methods.Conv_Vector2dToText_method.Invoke(InVec);

        ///<summary>Converts a vector value to localized formatted text, in the form 'X= Y= Z='</summary>
        public static byte /*TODO: text FText*/ Conv_VectorToText(Vector InVec)  => 
            KismetTextLibrary_methods.Conv_VectorToText_method.Invoke(InVec);

        ///<summary>Returns true if A and B are linguistically equal (A == B), ignoring case.</summary>
        public static bool EqualEqual_IgnoreCase_TextText(byte A /*TODO: text FText */, byte B /*TODO: text FText */)  => 
            KismetTextLibrary_methods.EqualEqual_IgnoreCase_TextText_method.Invoke(A, B);

        ///<summary>Returns true if A and B are linguistically equal (A == B).</summary>
        public static bool EqualEqual_TextText(byte A /*TODO: text FText */, byte B /*TODO: text FText */)  => 
            KismetTextLibrary_methods.EqualEqual_TextText_method.Invoke(A, B);

        ///<summary>Attempts to find existing Text using the representation found in the loc tables for the specified namespace and key.</summary>
        public static (byte /*TODO: text FText*/, bool) FindTextInLocalizationTable(string Namespace, string Key)  => 
            KismetTextLibrary_methods.FindTextInLocalizationTable_method.Invoke(Namespace, Key);

        ///<summary>Used for formatting text using the FText::Format function and utilized by the UK2Node_FormatText</summary>
        public static byte /*TODO: text FText*/ Format(byte InPattern /*TODO: text FText */, byte InArgs /*TODO: array TArray */)  => 
            KismetTextLibrary_methods.Format_method.Invoke(InPattern, InArgs);

        ///<summary>Returns an empty piece of text.</summary>
        public static byte /*TODO: text FText*/ GetEmptyText()  => 
            KismetTextLibrary_methods.GetEmptyText_method.Invoke();

        ///<summary>Check whether the given polyglot data is valid.</summary>
        ///<remarks>
        ///@return True if the polyglot data is valid, false otherwise. ErrorMessage will be filled in if the the data is invalid.
        ///</remarks>
        public static (bool, byte /*TODO: text FText*/) IsPolyglotDataValid(PolyglotTextData PolyglotData)  => 
            KismetTextLibrary_methods.IsPolyglotDataValid_method.Invoke(PolyglotData);

        ///<summary>Returns true if A and B are linguistically not equal (A != B), ignoring case.</summary>
        public static bool NotEqual_IgnoreCase_TextText(byte A /*TODO: text FText */, byte B /*TODO: text FText */)  => 
            KismetTextLibrary_methods.NotEqual_IgnoreCase_TextText_method.Invoke(A, B);

        ///<summary>Returns true if A and B are linguistically not equal (A != B).</summary>
        public static bool NotEqual_TextText(byte A /*TODO: text FText */, byte B /*TODO: text FText */)  => 
            KismetTextLibrary_methods.NotEqual_TextText_method.Invoke(A, B);

        ///<summary>Get the text instance created from this polyglot data.</summary>
        ///<remarks>
        ///@return The text instance, or an empty text if the data is invalid.
        ///</remarks>
        public static byte /*TODO: text FText*/ PolyglotDataToText(PolyglotTextData PolyglotData)  => 
            KismetTextLibrary_methods.PolyglotDataToText_method.Invoke(PolyglotData);

        ///<summary>Attempts to find the String Table ID and key used by the given text.</summary>
        ///<remarks>
        ///@return True if the String Table ID and key were found, false otherwise.
        ///</remarks>
        public static (Name, string, bool) StringTableIdAndKeyFromText(byte Text /*TODO: text FText */)  => 
            KismetTextLibrary_methods.StringTableIdAndKeyFromText_method.Invoke(Text);

        ///<summary>Attempts to create a text instance from a string table ID and key.</summary>
        ///<remarks>
        ///@note This exists to allow programmatic look-up of a string table entry from dynamic content - you should favor setting your string table reference on a text property or pin wherever possible as it is significantly more robust (see "Make Literal Text").
        ///@return The found text, or a dummy text if the entry could not be found.
        ///</remarks>
        public static byte /*TODO: text FText*/ TextFromStringTable(Name TableId, string Key)  => 
            KismetTextLibrary_methods.TextFromStringTable_method.Invoke(TableId, Key);

        ///<summary>Returns true if text is culture invariant.</summary>
        public static bool TextIsCultureInvariant(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextIsCultureInvariant_method.Invoke(InText);

        ///<summary>Returns true if text is empty.</summary>
        public static bool TextIsEmpty(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextIsEmpty_method.Invoke(InText);

        ///<summary>Returns true if the given text is referencing a string table.</summary>
        public static bool TextIsFromStringTable(byte Text /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextIsFromStringTable_method.Invoke(Text);

        ///<summary>Returns true if text is transient.</summary>
        public static bool TextIsTransient(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextIsTransient_method.Invoke(InText);

        ///<summary>Transforms the text to lowercase in a culture correct way.</summary>
        ///<remarks>
        ///@note The returned instance is linked to the original and will be rebuilt if the active culture is changed.
        ///</remarks>
        public static byte /*TODO: text FText*/ TextToLower(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextToLower_method.Invoke(InText);

        ///<summary>Transforms the text to uppercase in a culture correct way.</summary>
        ///<remarks>
        ///@note The returned instance is linked to the original and will be rebuilt if the active culture is changed.
        ///</remarks>
        public static byte /*TODO: text FText*/ TextToUpper(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextToUpper_method.Invoke(InText);

        ///<summary>Removes whitespace characters from the front of the text.</summary>
        public static byte /*TODO: text FText*/ TextTrimPreceding(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextTrimPreceding_method.Invoke(InText);

        ///<summary>Removes whitespace characters from the front and end of the text.</summary>
        public static byte /*TODO: text FText*/ TextTrimPrecedingAndTrailing(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextTrimPrecedingAndTrailing_method.Invoke(InText);

        ///<summary>Removes trailing whitespace characters.</summary>
        public static byte /*TODO: text FText*/ TextTrimTrailing(byte InText /*TODO: text FText */)  => 
            KismetTextLibrary_methods.TextTrimTrailing_method.Invoke(InText);
        static KismetTextLibrary() {
            StaticClass = Main.GetClass("KismetTextLibrary");
        }
        internal unsafe KismetTextLibrary_fields* KismetTextLibrary_ptr => (KismetTextLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetTextLibrary(IntPtr p) => UObject.Make<KismetTextLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetTextLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetTextLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
