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
    ///<summary>Blueprint Set Library</summary>
    public unsafe partial class BlueprintSetLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Adds item to set
        ///@
        ///</summary>
        ///<remarks>
        ///param       TargetSet               The set to add item to
        ///@param       NewItem                 The item to add to the set
        ///</remarks>
        public static void Set_Add(byte TargetSet /*TODO: set TSet */, int NewItem)  => 
            BlueprintSetLibrary_methods.Set_Add_method.Invoke(TargetSet, NewItem);

        ///<summary>
        ///Adds all elements from an Array to a Set
        ///@
        ///</summary>
        ///<remarks>
        ///param       TargetSet               The set to search for the item
        ///@param       NewItems                The items to add to the set
        ///</remarks>
        public static void Set_AddItems(byte TargetSet /*TODO: set TSet */, byte NewItems /*TODO: array TArray */)  => 
            BlueprintSetLibrary_methods.Set_AddItems_method.Invoke(TargetSet, NewItems);

        ///<summary>Clear a set, removes all content.</summary>
        ///<remarks>
        ///@param       TargetSet               The set to clear
        ///</remarks>
        public static void Set_Clear(byte TargetSet /*TODO: set TSet */)  => 
            BlueprintSetLibrary_methods.Set_Clear_method.Invoke(TargetSet);

        ///<summary>Returns true if the set contains the given item.</summary>
        ///<remarks>
        ///@param       TargetSet               The set to search for the item
        ///@param       ItemToFind              The item to look for
        ///@return      True if the item was found within the set
        ///</remarks>
        public static bool Set_Contains(byte TargetSet /*TODO: set TSet */, int ItemToFind)  => 
            BlueprintSetLibrary_methods.Set_Contains_method.Invoke(TargetSet, ItemToFind);

        ///<summary>Assigns Result to the relative difference of two sets, A and B.</summary>
        ///<remarks>
        ///That is, Result will
        ///contain  all elements that are in Set A but are not found in Set B. Note that the
        ///difference between two sets  is not commutative. The Set whose elements you wish to
        ///preserve should be the first (top) parameter. Also called the relative complement.
        ///
        ///@param               A               Starting set
        ///@param               B               Set of elements to remove from set A
        ///@param               Result  Set containing all elements in A that are not found in B
        ///</remarks>
        public static byte /*TODO: set TSet*/ Set_Difference(byte A /*TODO: set TSet */, byte B /*TODO: set TSet */)  => 
            BlueprintSetLibrary_methods.Set_Difference_method.Invoke(A, B);

        ///<summary>Assigns Result to the intersection of Set A and Set B.</summary>
        ///<remarks>
        ///That is, Result will contain
        ///all elements that are in both Set A and Set B. To intersect with the empty set use
        ///Clear.
        ///
        ///@param               A               One set to intersect
        ///@param               B               Another set to intersect
        ///@param               Result  Set to store results in
        ///</remarks>
        public static byte /*TODO: set TSet*/ Set_Intersection(byte A /*TODO: set TSet */, byte B /*TODO: set TSet */)  => 
            BlueprintSetLibrary_methods.Set_Intersection_method.Invoke(A, B);

        ///<summary>Get the number of items in a set.</summary>
        ///<remarks>
        ///@param       TargetSet               The set to get the length of
        ///@return      The length of the set
        ///</remarks>
        public static int Set_Length(byte TargetSet /*TODO: set TSet */)  => 
            BlueprintSetLibrary_methods.Set_Length_method.Invoke(TargetSet);

        ///<summary>Remove item from set.</summary>
        ///<remarks>
        ///Output value indicates if something was actually removed. False
        ///indicates no equivalent item was found.
        ///
        ///@param       TargetSet               The set to remove from
        ///@param       Item                    The item to remove from the set
        ///@return      True if an item was removed (False indicates no equivalent item was present)
        ///</remarks>
        public static bool Set_Remove(byte TargetSet /*TODO: set TSet */, int Item)  => 
            BlueprintSetLibrary_methods.Set_Remove_method.Invoke(TargetSet, Item);

        ///<summary>Removes all elements in an Array from a set.</summary>
        ///<remarks>
        ///@param       TargetSet               The set to remove from
        ///@param       Items                   The items to remove from the set
        ///</remarks>
        public static void Set_RemoveItems(byte TargetSet /*TODO: set TSet */, byte Items /*TODO: array TArray */)  => 
            BlueprintSetLibrary_methods.Set_RemoveItems_method.Invoke(TargetSet, Items);

        ///<summary>Outputs an Array containing copies of the entries of a Set.</summary>
        ///<remarks>
        ///@param               A               Set
        ///@param               Result  Array
        ///</remarks>
        public static IReadOnlyCollection<int> Set_ToArray(byte A /*TODO: set TSet */)  => 
            BlueprintSetLibrary_methods.Set_ToArray_method.Invoke(A);

        ///<summary>Assigns Result to the union of two sets, A and B.</summary>
        ///<remarks>
        ///That is, Result will contain
        ///all elements that are in Set A and in addition all elements in Set B. Note that
        ///a Set is a collection of unique elements, so duplicates will be eliminated.
        ///
        ///@param               A               One set to union
        ///@param               B               Another set to union
        ///@param               Result  Set to store results in
        ///</remarks>
        public static byte /*TODO: set TSet*/ Set_Union(byte A /*TODO: set TSet */, byte B /*TODO: set TSet */)  => 
            BlueprintSetLibrary_methods.Set_Union_method.Invoke(A, B);

        ///<summary>Not exposed to users. Supports setting a set property on an object by name.</summary>
        public static void SetSetPropertyByName(UObject UObject, Name PropertyName, byte Value /*TODO: set TSet */)  => 
            BlueprintSetLibrary_methods.SetSetPropertyByName_method.Invoke(UObject, PropertyName, Value);
        static BlueprintSetLibrary() {
            StaticClass = Main.GetClass("BlueprintSetLibrary");
        }
        internal unsafe BlueprintSetLibrary_fields* BlueprintSetLibrary_ptr => (BlueprintSetLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintSetLibrary(IntPtr p) => UObject.Make<BlueprintSetLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintSetLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintSetLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
