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
    ///<summary>Kismet Array Library</summary>
    public unsafe partial class KismetArrayLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Add item to array
        ///@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to add item to
        ///@param        NewItem                 The item to add to the array
        ///@return       The index of the newly added item
        ///</remarks>
        public static int Array_Add(byte TargetArray /*TODO: array TArray */, int NewItem)  => 
            KismetArrayLibrary_methods.Array_Add_method.Invoke(TargetArray, NewItem);

        ///<summary>
        ///Add item to array (unique)
        ///@
        ///</summary>
        ///<remarks>
        ///param         TargetArray             The array to add item to
        ///@param         NewItem                 The item to add to the array
        ///@return        The index of the newly added item, or INDEX_NONE if the item is already present in the array
        ///</remarks>
        public static int Array_AddUnique(byte TargetArray /*TODO: array TArray */, int NewItem)  => 
            KismetArrayLibrary_methods.Array_AddUnique_method.Invoke(TargetArray, NewItem);

        ///<summary>
        ///Append an array to another array
        ///@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to add the source array to
        ///@param        SourceArray             The array to add to the target array
        ///</remarks>
        public static void Array_Append(byte TargetArray /*TODO: array TArray */, byte SourceArray /*TODO: array TArray */)  => 
            KismetArrayLibrary_methods.Array_Append_method.Invoke(TargetArray, SourceArray);

        ///<summary>
        ///*Clear an array, removes all content
        ///*
        ///*@
        ///</summary>
        ///<remarks>param        TargetArray             The array to clear</remarks>
        public static void Array_Clear(byte TargetArray /*TODO: array TArray */)  => 
            KismetArrayLibrary_methods.Array_Clear_method.Invoke(TargetArray);

        ///<summary>
        ///*Returns true if the array contains the given item
        ///*
        ///*@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to search for the item
        ///*@param        ItemToFind              The item to look for
        ///*@return       True if the item was found within the array
        ///</remarks>
        public static bool Array_Contains(byte TargetArray /*TODO: array TArray */, int ItemToFind)  => 
            KismetArrayLibrary_methods.Array_Contains_method.Invoke(TargetArray, ItemToFind);

        ///<summary>
        ///*Finds the index of the first instance of the item within the array
        ///*
        ///*@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to search for the item
        ///*@param        ItemToFind              The item to look for
        ///*@return       The index the item was found at, or -1 if not found
        ///</remarks>
        public static int Array_Find(byte TargetArray /*TODO: array TArray */, int ItemToFind)  => 
            KismetArrayLibrary_methods.Array_Find_method.Invoke(TargetArray, ItemToFind);

        ///<summary>
        ///*Given an array and an index, returns a copy of the item found at that index
        ///*
        ///*@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to get an item from
        ///*@param        Index                   The index in the array to get an item from
        ///*@return       A copy of the item stored at the index
        ///</remarks>
        public static int Array_Get(byte TargetArray /*TODO: array TArray */, int Index)  => 
            KismetArrayLibrary_methods.Array_Get_method.Invoke(TargetArray, Index);

        ///<summary>*Insert item at the given index into the array.</summary>
        ///<remarks>
        ///*
        ///*@param        TargetArray             The array to insert into
        ///*@param        NewItem                 The item to insert into the array
        ///*@param        Index                   The index at which to insert the item into the array
        ///</remarks>
        public static void Array_Insert(byte TargetArray /*TODO: array TArray */, int NewItem, int Index)  => 
            KismetArrayLibrary_methods.Array_Insert_method.Invoke(TargetArray, NewItem, Index);

        ///<summary>*Tests if IndexToTest is valid, i.</summary>
        ///<remarks>
        ///e. greater than or equal to zero, and less than the number of elements in TargetArray.
        ///*
        ///*@param        TargetArray             Array to use for the IsValidIndex test
        ///*@param        IndexToTest             The Index, that we want to test for being valid
        ///*@return       True if the Index is Valid, i.e. greater than or equal to zero, and less than the number of elements in TargetArray.
        ///</remarks>
        public static bool Array_IsValidIndex(byte TargetArray /*TODO: array TArray */, int IndexToTest)  => 
            KismetArrayLibrary_methods.Array_IsValidIndex_method.Invoke(TargetArray, IndexToTest);

        ///<summary>
        ///*Get the last valid index into an array
        ///*
        ///*@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to perform the operation on
        ///*@return       The last valid index of the array
        ///</remarks>
        public static int Array_LastIndex(byte TargetArray /*TODO: array TArray */)  => 
            KismetArrayLibrary_methods.Array_LastIndex_method.Invoke(TargetArray);

        ///<summary>
        ///*Get the number of items in an array
        ///*
        ///*@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to get the length of
        ///*@return       The length of the array
        ///</remarks>
        public static int Array_Length(byte TargetArray /*TODO: array TArray */)  => 
            KismetArrayLibrary_methods.Array_Length_method.Invoke(TargetArray);

        ///<summary>*Remove item at the given index from the array.</summary>
        ///<remarks>
        ///*
        ///*@param        TargetArray             The array to remove from
        ///*@param        IndexToRemove   The index into the array to remove from
        ///</remarks>
        public static void Array_Remove(byte TargetArray /*TODO: array TArray */, int IndexToRemove)  => 
            KismetArrayLibrary_methods.Array_Remove_method.Invoke(TargetArray, IndexToRemove);

        ///<summary>*Remove all instances of item from array.</summary>
        ///<remarks>
        ///*
        ///*@param        TargetArray             The array to remove from
        ///*@param        Item                    The item to remove from the array
        ///*@return       True if one or more items were removed
        ///</remarks>
        public static bool Array_RemoveItem(byte TargetArray /*TODO: array TArray */, int Item)  => 
            KismetArrayLibrary_methods.Array_RemoveItem_method.Invoke(TargetArray, Item);

        ///<summary>*Resize Array to specified size.</summary>
        ///<remarks>
        ///*
        ///*@param        TargetArray             The array to resize
        ///*@param        Size                    The new size of the array
        ///</remarks>
        public static void Array_Resize(byte TargetArray /*TODO: array TArray */, int Size)  => 
            KismetArrayLibrary_methods.Array_Resize_method.Invoke(TargetArray, Size);

        ///<summary>
        ///*Given an array and an index, assigns the item to that array element
        ///*
        ///*@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to perform the operation on
        ///*@param        Index                   The index to assign the item to
        ///*@param        Item                    The item to assign to the index of the array
        ///*@param        bSizeToFit              If true, the array will expand if Index is greater than the current size of the array
        ///</remarks>
        public static void Array_Set(byte TargetArray /*TODO: array TArray */, int Index, int Item, bool bSizeToFit)  => 
            KismetArrayLibrary_methods.Array_Set_method.Invoke(TargetArray, Index, Item, bSizeToFit);

        ///<summary>
        ///Shuffle (randomize) the elements of an array
        ///@
        ///</summary>
        ///<remarks>param        TargetArray             The array to shuffle</remarks>
        public static void Array_Shuffle(byte TargetArray /*TODO: array TArray */)  => 
            KismetArrayLibrary_methods.Array_Shuffle_method.Invoke(TargetArray);

        ///<summary>
        ///*Swaps the elements at the specified positions in the specified array
        ///*If the specified positions are equal, invoking this method leaves the array unchanged
        ///*
        ///*@
        ///</summary>
        ///<remarks>
        ///param        TargetArray             The array to perform the operation on
        ///*@param    FirstIndex      The index of one element to be swapped
        ///*@param    SecondIndex     The index of the other element to be swapped
        ///</remarks>
        public static void Array_Swap(byte TargetArray /*TODO: array TArray */, int FirstIndex, int SecondIndex)  => 
            KismetArrayLibrary_methods.Array_Swap_method.Invoke(TargetArray, FirstIndex, SecondIndex);

        ///<summary>*Filter an array based on a Class derived from Actor.</summary>
        ///<remarks>
        ///*
        ///*@param        TargetArray             The array to filter from
        ///*@param        FilterClass             The Actor sub-class type that acts as the filter, only objects derived from it will be returned.
        ///*@return       An array containing only those objects which are derived from the class specified.
        ///</remarks>
        public static IReadOnlyCollection<Actor> FilterArray(byte TargetArray /*TODO: array TArray */, SubclassOf<Actor> FilterClass)  => 
            KismetArrayLibrary_methods.FilterArray_method.Invoke(TargetArray, FilterClass);

        ///<summary>Not exposed to users. Supports setting an array property on an object by name.</summary>
        public static void SetArrayPropertyByName(UObject UObject, Name PropertyName, byte Value /*TODO: array TArray */)  => 
            KismetArrayLibrary_methods.SetArrayPropertyByName_method.Invoke(UObject, PropertyName, Value);
        static KismetArrayLibrary() {
            StaticClass = Main.GetClass("KismetArrayLibrary");
        }
        internal unsafe KismetArrayLibrary_fields* KismetArrayLibrary_ptr => (KismetArrayLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetArrayLibrary(IntPtr p) => UObject.Make<KismetArrayLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetArrayLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetArrayLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
