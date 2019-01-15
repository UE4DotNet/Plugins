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
    ///<summary>Kismet Node Helper Library</summary>
    public unsafe partial class KismetNodeHelperLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Returns whether the bit at index "Index" is set or not in the data
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The integer containing the bits that are being tested against
        ///@param Index - The bit index into the Data that we are inquiring
        ///@return  - Whether the bit at index "Index" is set or not
        ///</remarks>
        public static bool BitIsMarked(int Data, int Index)  => 
            KismetNodeHelperLibrary_methods.BitIsMarked_method.Invoke(Data, Index);

        ///<summary>
        ///Clears all of the bit in the data
        ///@
        ///</summary>
        ///<remarks>param Data - The integer containing the bits that are being cleared</remarks>
        public static int ClearAllBits()  => 
            KismetNodeHelperLibrary_methods.ClearAllBits_method.Invoke();

        ///<summary>
        ///Clears the bit at index "Index" in the data
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The integer containing the bits that are being cleared
        ///@param Index - The bit index into the Data that we are clearing
        ///</remarks>
        public static int ClearBit(int Index)  => 
            KismetNodeHelperLibrary_methods.ClearBit_method.Invoke(Index);

        ///<summary>Gets enumerator name.</summary>
        ///<remarks>
        ///@param Enum - Enumeration
        ///@param EnumeratorValue - Value of searched enumeration
        ///@return - name of the searched enumerator, or NAME_None
        ///</remarks>
        public static Name GetEnumeratorName(UEnum UEnum, byte EnumeratorValue)  => 
            KismetNodeHelperLibrary_methods.GetEnumeratorName_method.Invoke(UEnum, EnumeratorValue);

        ///<summary>Gets enumerator name as FString.</summary>
        ///<remarks>
        ///Use DeisplayName when possible.
        ///
        ///@param Enum - Enumeration
        ///@param EnumeratorValue - Value of searched enumeration
        ///@return - name of the searched enumerator, or NAME_None
        ///</remarks>
        public static string GetEnumeratorUserFriendlyName(UEnum UEnum, byte EnumeratorValue)  => 
            KismetNodeHelperLibrary_methods.GetEnumeratorUserFriendlyName_method.Invoke(UEnum, EnumeratorValue);

        ///<summary>@</summary>
        ///<remarks>
        ///param Enum - Enumeration
        ///@param EnumeratorIndex - Input index
        ///@return - The value of the enumerator, or INDEX_NONE
        ///</remarks>
        public static byte GetEnumeratorValueFromIndex(UEnum UEnum, byte EnumeratorIndex)  => 
            KismetNodeHelperLibrary_methods.GetEnumeratorValueFromIndex_method.Invoke(UEnum, EnumeratorIndex);

        ///<summary>
        ///Gets the first index not already marked starting from a specific index and returns the bit index selected
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The integer containing the bits that are being set
        ///@param StartIdx - The index to start looking for an available index from
        ///@param NumBits - The logical number of bits we want to track
        ///@return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
        ///</remarks>
        public static int GetFirstUnmarkedBit(int Data, int StartIdx, int NumBits)  => 
            KismetNodeHelperLibrary_methods.GetFirstUnmarkedBit_method.Invoke(Data, StartIdx, NumBits);

        ///<summary>
        ///Gets a random not already marked bit and returns the bit index selected
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The integer containing the bits that are being set
        ///@param NumBits - The logical number of bits we want to track
        ///@return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
        ///</remarks>
        public static int GetRandomUnmarkedBit(int Data, int StartIdx, int NumBits)  => 
            KismetNodeHelperLibrary_methods.GetRandomUnmarkedBit_method.Invoke(Data, StartIdx, NumBits);

        ///<summary>
        ///Gets an already unmarked bit and returns the bit index selected
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The integer containing the bits that are being set
        ///@param StartIdx - The index to start with when determining the selection'
        ///@param NumBits - The logical number of bits we want to track
        ///@param bRandom - Whether to select a random index or not
        ///@return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
        ///</remarks>
        public static int GetUnmarkedBit(int Data, int StartIdx, int NumBits, bool bRandom)  => 
            KismetNodeHelperLibrary_methods.GetUnmarkedBit_method.Invoke(Data, StartIdx, NumBits, bRandom);

        ///<summary>@</summary>
        ///<remarks>
        ///param Enum - Enumeration
        ///@param EnumeratorIndex - Input value
        ///@return - if EnumeratorIndex is valid return EnumeratorIndex, otherwise return MAX value of Enum
        ///</remarks>
        public static byte GetValidValue(UEnum UEnum, byte EnumeratorValue)  => 
            KismetNodeHelperLibrary_methods.GetValidValue_method.Invoke(UEnum, EnumeratorValue);

        ///<summary>
        ///Returns whether there exists a marked bit in the data
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The data being tested against
        ///@param NumBits - The logical number of bits we want to track
        ///@return - Whether there is a bit marked in the data
        ///</remarks>
        public static bool HasMarkedBit(int Data, int NumBits)  => 
            KismetNodeHelperLibrary_methods.HasMarkedBit_method.Invoke(Data, NumBits);

        ///<summary>
        ///Returns whether there exists an unmarked bit in the data
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The data being tested against
        ///@param NumBits - The logical number of bits we want to track
        ///@return - Whether there is a bit not marked in the data
        ///</remarks>
        public static bool HasUnmarkedBit(int Data, int NumBits)  => 
            KismetNodeHelperLibrary_methods.HasUnmarkedBit_method.Invoke(Data, NumBits);

        ///<summary>
        ///Sets the bit at index "Index" in the data
        ///@
        ///</summary>
        ///<remarks>
        ///param Data - The integer containing the bits that are being set
        ///@param Index - The bit index into the Data that we are setting
        ///</remarks>
        public static int MarkBit(int Index)  => 
            KismetNodeHelperLibrary_methods.MarkBit_method.Invoke(Index);
        static KismetNodeHelperLibrary() {
            StaticClass = Main.GetClass("KismetNodeHelperLibrary");
        }
        internal unsafe KismetNodeHelperLibrary_fields* KismetNodeHelperLibrary_ptr => (KismetNodeHelperLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetNodeHelperLibrary(IntPtr p) => UObject.Make<KismetNodeHelperLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetNodeHelperLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetNodeHelperLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
