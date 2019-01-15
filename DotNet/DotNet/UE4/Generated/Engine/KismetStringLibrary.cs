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
    ///<summary>Kismet String Library</summary>
    public unsafe partial class KismetStringLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Converts a boolean->string, creating a new string in the form AppendTo+Prefix+InBool+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InBool - The bool value to convert. Will add "true" or "false" to the conversion string
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Bool(string AppendTo, string Prefix, bool InBool, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Bool_method.Invoke(AppendTo, Prefix, InBool, Suffix);

        ///<summary>
        ///Converts a color->string, creating a new string in the form AppendTo+Prefix+InColor+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InColor - The linear color value to convert. Uses the standard ToString conversion
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Color(string AppendTo, string Prefix, LinearColor InColor, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Color_method.Invoke(AppendTo, Prefix, InColor, Suffix);

        ///<summary>
        ///Converts a float->string, create a new string in the form AppendTo+Prefix+InFloat+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InFloat - The float value to convert
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Float(string AppendTo, string Prefix, float InFloat, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Float_method.Invoke(AppendTo, Prefix, InFloat, Suffix);

        ///<summary>
        ///Converts a int->string, creating a new string in the form AppendTo+Prefix+InInt+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InInt - The int value to convert
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Int(string AppendTo, string Prefix, int InInt, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Int_method.Invoke(AppendTo, Prefix, InInt, Suffix);

        ///<summary>
        ///Converts an IntVector->string, creating a new string in the form AppendTo+Prefix+InIntVector+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InIntVector - The intVector value to convert. Uses the standard FVector::ToString conversion
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_IntVector(string AppendTo, string Prefix, IntVector InIntVector, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_IntVector_method.Invoke(AppendTo, Prefix, InIntVector, Suffix);

        ///<summary>
        ///Converts a color->string, creating a new string in the form AppendTo+Prefix+InName+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InName - The name value to convert
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Name(string AppendTo, string Prefix, Name InName, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Name_method.Invoke(AppendTo, Prefix, InName, Suffix);

        ///<summary>
        ///Converts a object->string, creating a new string in the form AppendTo+Prefix+object name+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InObj - The object to convert. Will insert the name of the object into the conversion string
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Object(string AppendTo, string Prefix, UObject InObj, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Object_method.Invoke(AppendTo, Prefix, InObj, Suffix);

        ///<summary>
        ///Converts a rotator->string, creating a new string in the form AppendTo+Prefix+InRot+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InRot - The rotator value to convert. Uses the standard ToString conversion
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Rotator(string AppendTo, string Prefix, Rotator InRot, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Rotator_method.Invoke(AppendTo, Prefix, InRot, Suffix);

        ///<summary>
        ///Converts a vector->string, creating a new string in the form AppendTo+Prefix+InVector+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InVector - The vector value to convert. Uses the standard FVector::ToString conversion
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Vector(string AppendTo, string Prefix, Vector InVector, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Vector_method.Invoke(AppendTo, Prefix, InVector, Suffix);

        ///<summary>
        ///Converts a vector2d->string, creating a new string in the form AppendTo+Prefix+InVector2d+Suffix
        ///@
        ///</summary>
        ///<remarks>
        ///param AppendTo - An existing string to use as the start of the conversion string
        ///@param Prefix - A string to use as a prefix, after the AppendTo string
        ///@param InVector2d - The vector2d value to convert. Uses the standard FVector2D::ToString conversion
        ///@param Suffix - A suffix to append to the end of the conversion string
        ///@return A new string built from the passed parameters
        ///</remarks>
        public static string BuildString_Vector2d(string AppendTo, string Prefix, Vector2D InVector2d, string Suffix)  => 
            KismetStringLibrary_methods.BuildString_Vector2d_method.Invoke(AppendTo, Prefix, InVector2d, Suffix);

        ///<summary>
        ///Concatenates two strings together to make a new string
        ///@
        ///</summary>
        ///<remarks>
        ///param A - The original string
        ///@param B - The string to append to A
        ///@returns A new string which is the concatenation of A+B
        ///</remarks>
        public static string Concat_StrStr(string A, string B)  => 
            KismetStringLibrary_methods.Concat_StrStr_method.Invoke(A, B);

        ///<summary>Returns whether this string contains the specified substring.</summary>
        ///<remarks>
        ///@param SubStr                 Find to search for
        ///@param SearchCase             Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
        ///@param SearchDir                      Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
        ///@return                                       Returns whether the string contains the substring
        ///</remarks>
        public static bool Contains(string SearchIn, string Substring, bool bUseCase, bool bSearchFromEnd)  => 
            KismetStringLibrary_methods.Contains_method.Invoke(SearchIn, Substring, bUseCase, bSearchFromEnd);

        ///<summary>Converts a boolean value to a string, either 'true' or 'false'</summary>
        public static string Conv_BoolToString(bool InBool)  => 
            KismetStringLibrary_methods.Conv_BoolToString_method.Invoke(InBool);

        ///<summary>Converts a byte value to a string</summary>
        public static string Conv_ByteToString(byte InByte)  => 
            KismetStringLibrary_methods.Conv_ByteToString_method.Invoke(InByte);

        ///<summary>Converts a linear color value to a string, in the form '(R=,G=,B=,A=)'</summary>
        public static string Conv_ColorToString(LinearColor InColor)  => 
            KismetStringLibrary_methods.Conv_ColorToString_method.Invoke(InColor);

        ///<summary>Converts a float value to a string</summary>
        public static string Conv_FloatToString(float InFloat)  => 
            KismetStringLibrary_methods.Conv_FloatToString_method.Invoke(InFloat);

        ///<summary>Converts an integer value to a string</summary>
        public static string Conv_IntToString(int InInt)  => 
            KismetStringLibrary_methods.Conv_IntToString_method.Invoke(InInt);

        ///<summary>Converts an IntVector value to a string, in the form 'X= Y= Z='</summary>
        public static string Conv_IntVectorToString(IntVector InIntVec)  => 
            KismetStringLibrary_methods.Conv_IntVectorToString_method.Invoke(InIntVec);

        ///<summary>Converts a name value to a string</summary>
        public static string Conv_NameToString(Name InName)  => 
            KismetStringLibrary_methods.Conv_NameToString_method.Invoke(InName);

        ///<summary>Converts a UObject value to a string by calling the object's GetName method</summary>
        public static string Conv_ObjectToString(UObject InObj)  => 
            KismetStringLibrary_methods.Conv_ObjectToString_method.Invoke(InObj);

        ///<summary>Converts a rotator value to a string, in the form 'P= Y= R='</summary>
        public static string Conv_RotatorToString(Rotator InRot)  => 
            KismetStringLibrary_methods.Conv_RotatorToString_method.Invoke(InRot);

        ///<summary>Convert String Back To Color. IsValid indicates whether or not the string could be successfully converted.</summary>
        public static (LinearColor, bool) Conv_StringToColor(string InString)  => 
            KismetStringLibrary_methods.Conv_StringToColor_method.Invoke(InString);

        ///<summary>Converts a string to a float value</summary>
        public static float Conv_StringToFloat(string InString)  => 
            KismetStringLibrary_methods.Conv_StringToFloat_method.Invoke(InString);

        ///<summary>Converts a string to a int value</summary>
        public static int Conv_StringToInt(string InString)  => 
            KismetStringLibrary_methods.Conv_StringToInt_method.Invoke(InString);

        ///<summary>Converts a string to a name value</summary>
        public static Name Conv_StringToName(string InString)  => 
            KismetStringLibrary_methods.Conv_StringToName_method.Invoke(InString);

        ///<summary>Convert String Back To Rotator. IsValid indicates whether or not the string could be successfully converted.</summary>
        public static (Rotator, bool) Conv_StringToRotator(string InString)  => 
            KismetStringLibrary_methods.Conv_StringToRotator_method.Invoke(InString);

        ///<summary>Convert String Back To Vector. IsValid indicates whether or not the string could be successfully converted.</summary>
        public static (Vector, bool) Conv_StringToVector(string InString)  => 
            KismetStringLibrary_methods.Conv_StringToVector_method.Invoke(InString);

        ///<summary>Convert String Back To Vector2D. IsValid indicates whether or not the string could be successfully converted.</summary>
        public static (Vector2D, bool) Conv_StringToVector2D(string InString)  => 
            KismetStringLibrary_methods.Conv_StringToVector2D_method.Invoke(InString);

        ///<summary>Converts a transform value to a string, in the form 'Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z='</summary>
        public static string Conv_TransformToString(Transform InTrans)  => 
            KismetStringLibrary_methods.Conv_TransformToString_method.Invoke(InTrans);

        ///<summary>Converts a vector2d value to a string, in the form 'X= Y='</summary>
        public static string Conv_Vector2dToString(Vector2D InVec)  => 
            KismetStringLibrary_methods.Conv_Vector2dToString_method.Invoke(InVec);

        ///<summary>Converts a vector value to a string, in the form 'X= Y= Z='</summary>
        public static string Conv_VectorToString(Vector InVec)  => 
            KismetStringLibrary_methods.Conv_VectorToString_method.Invoke(InVec);

        ///<summary>Takes an array of strings and removes any zero length entries.</summary>
        ///<remarks>
        ///@param       InArray The array to cull
        ///
        ///@return      The number of elements left in InArray
        ///</remarks>
        public static (IReadOnlyCollection<string>, int) CullArray(string SourceString)  => 
            KismetStringLibrary_methods.CullArray_method.Invoke(SourceString);

        ///<summary>Test whether this string ends with given string.</summary>
        ///<remarks>
        ///@param SearchCase            Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
        ///@return true if this string ends with specified text, false otherwise
        ///</remarks>
        public static bool EndsWith(string SourceString, string InSuffix, byte SearchCase)  => 
            KismetStringLibrary_methods.EndsWith_method.Invoke(SourceString, InSuffix, SearchCase);

        ///<summary>
        ///Test if the input strings are equal (A == B), ignoring case
        ///@
        ///</summary>
        ///<remarks>
        ///param A - The string to compare against
        ///@param B - The string to compare
        ///@returns True if the strings are equal, false otherwise
        ///</remarks>
        public static bool EqualEqual_StriStri(string A, string B)  => 
            KismetStringLibrary_methods.EqualEqual_StriStri_method.Invoke(A, B);

        ///<summary>
        ///Test if the input strings are equal (A == B)
        ///@
        ///</summary>
        ///<remarks>
        ///param A - The string to compare against
        ///@param B - The string to compare
        ///@returns True if the strings are equal, false otherwise
        ///</remarks>
        public static bool EqualEqual_StrStr(string A, string B)  => 
            KismetStringLibrary_methods.EqualEqual_StrStr_method.Invoke(A, B);

        ///<summary>
        ///Finds the starting index of a substring in the a specified string
        ///@
        ///</summary>
        ///<remarks>
        ///param SearchIn The string to search within
        ///@param Substring The string to look for in the SearchIn string
        ///@param bUseCase Whether or not to be case-sensitive
        ///@param bSearchFromEnd Whether or not to start the search from the end of the string instead of the beginning
        ///@param StartPosition The position to start the search from
        ///@return The index (starting from 0 if bSearchFromEnd is false) of the first occurence of the substring
        ///</remarks>
        public static int FindSubstring(string SearchIn, string Substring, bool bUseCase, bool bSearchFromEnd, int StartPosition)  => 
            KismetStringLibrary_methods.FindSubstring_method.Invoke(SearchIn, Substring, bUseCase, bSearchFromEnd, StartPosition);

        ///<summary>
        ///Returns an array that contains one entry for each character in SourceString
        ///@
        ///</summary>
        ///<remarks>
        ///param        SourceString    The string to break apart into characters
        ///@return       An array containing one entry for each character in SourceString
        ///</remarks>
        public static IReadOnlyCollection<string> GetCharacterArrayFromString(string SourceString)  => 
            KismetStringLibrary_methods.GetCharacterArrayFromString_method.Invoke(SourceString);

        ///<summary>
        ///Gets a single character from the string (as an integer)
        ///@
        ///</summary>
        ///<remarks>
        ///param SourceString - The string to convert
        ///@param Index - Location of the character whose value is required
        ///@return The integer value of the character or 0 if index is out of range
        ///</remarks>
        public static int GetCharacterAsNumber(string SourceString, int Index)  => 
            KismetStringLibrary_methods.GetCharacterAsNumber_method.Invoke(SourceString, Index);

        ///<summary>
        ///Returns a substring from the string starting at the specified position
        ///@
        ///</summary>
        ///<remarks>
        ///param SourceString - The string to get the substring from
        ///@param StartIndex - The location in SourceString to use as the start of the substring
        ///@param Length The length of the requested substring
        ///
        ///@return The requested substring
        ///</remarks>
        public static string GetSubstring(string SourceString, int StartIndex, int Length)  => 
            KismetStringLibrary_methods.GetSubstring_method.Invoke(SourceString, StartIndex, Length);

        ///<summary>
        ///* Checks if a string contains only numeric characters
        ///* @
        ///</summary>
        ///<remarks>
        ///param       SourceString    The string to check
        ///* @return true if the string only contains numeric characters
        ///</remarks>
        public static bool IsNumeric(string SourceString)  => 
            KismetStringLibrary_methods.IsNumeric_method.Invoke(SourceString);

        ///<summary>Concatenates an array of strings into a single string.</summary>
        ///<remarks>
        ///@param SourceArray - The array of strings to concatenate.
        ///@param Separator - The string used to separate each element.
        ///@return The final, joined, separated string.
        ///</remarks>
        public static string JoinStringArray(byte SourceArray /*TODO: array TArray */, string Separator)  => 
            KismetStringLibrary_methods.JoinStringArray_method.Invoke(SourceArray, Separator);

        ///<summary>@return the left most given number of characters</summary>
        public static string Left(string SourceString, int Count)  => 
            KismetStringLibrary_methods.Left_method.Invoke(SourceString, Count);

        ///<summary>@return the left most characters from the string chopping the given number of characters from the end</summary>
        public static string LeftChop(string SourceString, int Count)  => 
            KismetStringLibrary_methods.LeftChop_method.Invoke(SourceString, Count);

        ///<summary>
        ///* Pad the left of this string for a specified number of characters
        ///* @
        ///</summary>
        ///<remarks>
        ///param       SourceString    The string to pad
        ///* @param       ChCount                 Amount of padding required
        ///* @return      The padded string
        ///</remarks>
        public static string LeftPad(string SourceString, int ChCount)  => 
            KismetStringLibrary_methods.LeftPad_method.Invoke(SourceString, ChCount);

        ///<summary>
        ///Returns the number of characters in the string
        ///@
        ///</summary>
        ///<remarks>
        ///param SourceString - The string to measure
        ///@return The number of chars in the string
        ///</remarks>
        public static int Len(string S)  => 
            KismetStringLibrary_methods.Len_method.Invoke(S);

        ///<summary>
        ///Searches this string for a given wild card
        ///@
        ///</summary>
        ///<remarks>
        ///param Wildcard              *?-type wildcard
        ///@param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
        ///@return true if this string matches the *?-type wildcard given.
        ///@warning This is a simple, SLOW routine. Use with caution
        ///</remarks>
        public static bool MatchesWildcard(string SourceString, string Wildcard, byte SearchCase)  => 
            KismetStringLibrary_methods.MatchesWildcard_method.Invoke(SourceString, Wildcard, SearchCase);

        ///<summary>@return the substring from Start position for Count characters.</summary>
        public static string Mid(string SourceString, int Start, int Count)  => 
            KismetStringLibrary_methods.Mid_method.Invoke(SourceString, Start, Count);

        ///<summary>
        ///Test if the input string are not equal (A != B), ignoring case differences
        ///@
        ///</summary>
        ///<remarks>
        ///param A - The string to compare against
        ///@param B - The string to compare
        ///@return Returns true if the input strings are not equal, false if they are equal
        ///</remarks>
        public static bool NotEqual_StriStri(string A, string B)  => 
            KismetStringLibrary_methods.NotEqual_StriStri_method.Invoke(A, B);

        ///<summary>
        ///Test if the input string are not equal (A != B)
        ///@
        ///</summary>
        ///<remarks>
        ///param A - The string to compare against
        ///@param B - The string to compare
        ///@return Returns true if the input strings are not equal, false if they are equal
        ///</remarks>
        public static bool NotEqual_StrStr(string A, string B)  => 
            KismetStringLibrary_methods.NotEqual_StrStr_method.Invoke(A, B);

        ///<summary>Gets an array of strings from a source string divided up by a separator and empty strings can optionally be culled.</summary>
        ///<remarks>
        ///@param SourceString - The string to chop up
        ///@param Delimiter - The string to delimit on
        ///@param CullEmptyStrings = true - Cull (true) empty strings or add them to the array (false)
        ///@return The array of string that have been separated
        ///</remarks>
        public static IReadOnlyCollection<string> ParseIntoArray(string SourceString, string Delimiter, bool CullEmptyStrings)  => 
            KismetStringLibrary_methods.ParseIntoArray_method.Invoke(SourceString, Delimiter, CullEmptyStrings);

        ///<summary>
        ///Replace all occurrences of a substring in this string
        ///@
        ///</summary>
        ///<remarks>
        ///param From substring to replace
        ///@param To substring to replace From with
        ///@param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
        ///@return a copy of this string with the replacement made
        ///</remarks>
        public static string Replace(string SourceString, string From, string To, byte SearchCase)  => 
            KismetStringLibrary_methods.Replace_method.Invoke(SourceString, From, To, SearchCase);

        ///<summary>Replace all occurrences of SearchText with ReplacementText in this string.</summary>
        ///<remarks>
        ///@param       SearchText      the text that should be removed from this string
        ///@param       ReplacementText         the text to insert in its place
        ///@param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
        ///
        ///@return      the number of occurrences of SearchText that were replaced.
        ///</remarks>
        public static int ReplaceInline(string SourceString, string SearchText, string ReplacementText, byte SearchCase)  => 
            KismetStringLibrary_methods.ReplaceInline_method.Invoke(SourceString, SearchText, ReplacementText, SearchCase);

        ///<summary>Returns a copy of this string, with the characters in reverse order</summary>
        public static string Reverse(string SourceString)  => 
            KismetStringLibrary_methods.Reverse_method.Invoke(SourceString);

        ///<summary>@return the string to the right of the specified location, counting back from the right (end of the word).</summary>
        public static string Right(string SourceString, int Count)  => 
            KismetStringLibrary_methods.Right_method.Invoke(SourceString, Count);

        ///<summary>@return the string to the right of the specified location, counting forward from the left (from the beginning of the word).</summary>
        public static string RightChop(string SourceString, int Count)  => 
            KismetStringLibrary_methods.RightChop_method.Invoke(SourceString, Count);

        ///<summary>
        ///* Pad the right of this string for a specified number of characters
        ///* @
        ///</summary>
        ///<remarks>
        ///param       SourceString    The string to pad
        ///* @param       ChCount                 Amount of padding required
        ///* @return      The padded string
        ///</remarks>
        public static string RightPad(string SourceString, int ChCount)  => 
            KismetStringLibrary_methods.RightPad_method.Invoke(SourceString, ChCount);

        ///<summary>Splits this string at given string position case sensitive.</summary>
        ///<remarks>
        ///@param InStr The string to search and split at
        ///@param LeftS out the string to the left of InStr, not updated if return is false
        ///@param RightS out the string to the right of InStr, not updated if return is false
        ///@param SearchCase             Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
        ///@param SearchDir                      Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
        ///@return true if string is split, otherwise false
        ///</remarks>
        public static (string, string, bool) Split(string SourceString, string InStr, byte SearchCase, byte SearchDir)  => 
            KismetStringLibrary_methods.Split_method.Invoke(SourceString, InStr, SearchCase, SearchDir);

        ///<summary>Test whether this string starts with given string.</summary>
        ///<remarks>
        ///@param SearchCase            Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
        ///@return true if this string begins with specified text, false otherwise
        ///</remarks>
        public static bool StartsWith(string SourceString, string InPrefix, byte SearchCase)  => 
            KismetStringLibrary_methods.StartsWith_method.Invoke(SourceString, InPrefix, SearchCase);

        ///<summary>Convert a number of seconds into minutes:seconds.milliseconds format string</summary>
        public static string TimeSecondsToString(float InSeconds)  => 
            KismetStringLibrary_methods.TimeSecondsToString_method.Invoke(InSeconds);

        ///<summary>
        ///Returns a string converted to Lower case
        ///@
        ///</summary>
        ///<remarks>
        ///param        SourceString    The string to convert
        ///@return       The string in lower case
        ///</remarks>
        public static string ToLower(string SourceString)  => 
            KismetStringLibrary_methods.ToLower_method.Invoke(SourceString);

        ///<summary>
        ///Returns a string converted to Upper case
        ///@
        ///</summary>
        ///<remarks>
        ///param       SourceString    The string to convert
        ///@return      The string in upper case
        ///</remarks>
        public static string ToUpper(string SourceString)  => 
            KismetStringLibrary_methods.ToUpper_method.Invoke(SourceString);

        ///<summary>Removes whitespace characters from the front of this string.</summary>
        public static string Trim(string SourceString)  => 
            KismetStringLibrary_methods.Trim_method.Invoke(SourceString);

        ///<summary>Removes trailing whitespace characters</summary>
        public static string TrimTrailing(string SourceString)  => 
            KismetStringLibrary_methods.TrimTrailing_method.Invoke(SourceString);
        static KismetStringLibrary() {
            StaticClass = Main.GetClass("KismetStringLibrary");
        }
        internal unsafe KismetStringLibrary_fields* KismetStringLibrary_ptr => (KismetStringLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetStringLibrary(IntPtr p) => UObject.Make<KismetStringLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetStringLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetStringLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
