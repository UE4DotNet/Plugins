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
    ///<summary>Blueprint Map Library</summary>
    public unsafe partial class BlueprintMapLibrary : BlueprintFunctionLibrary  {

        ///<summary>Adds a key and value to the map.</summary>
        ///<remarks>
        ///If something already uses the provided key it will be overwritten with the new value.
        ///After calling Key is guaranteed to be associated with Value until a subsequent mutation of the Map.
        ///
        ///@param       TargetMap               The map to add the key and value to
        ///@param       Key                             The key that will be used to look the value up
        ///@param       Value                   The value to be retrieved later
        ///</remarks>
        public static void Map_Add(byte TargetMap /*TODO: map TMap */, int Key, int Value)  => 
            BlueprintMapLibrary_methods.Map_Add_method.Invoke(TargetMap, Key, Value);

        ///<summary>
        ///Clears a map of all entries, resetting it to empty
        ///@
        ///</summary>
        ///<remarks>param       TargetMap               The map to clear</remarks>
        public static void Map_Clear(byte TargetMap /*TODO: map TMap */)  => 
            BlueprintMapLibrary_methods.Map_Clear_method.Invoke(TargetMap);

        ///<summary>
        ///Checks whether key is in a provided Map
        ///@
        ///</summary>
        ///<remarks>
        ///param       TargetMap               The map to perform the lookup on
        ///@param       Key                             The key that will be used to lookup
        ///@return      True if an item was found (False indicates nothing in the map uses the provided key)
        ///</remarks>
        public static bool Map_Contains(byte TargetMap /*TODO: map TMap */, int Key)  => 
            BlueprintMapLibrary_methods.Map_Contains_method.Invoke(TargetMap, Key);

        ///<summary>
        ///Finds the value associated with the provided Key
        ///@
        ///</summary>
        ///<remarks>
        ///param       TargetMap               The map to perform the lookup on
        ///@param       Key                             The key that will be used to look the value up
        ///@param       Value                   The value associated with the key, default constructed if key was not found
        ///@return      True if an item was found (False indicates nothing in the map uses the provided key)
        ///</remarks>
        public static (int, bool) Map_Find(byte TargetMap /*TODO: map TMap */, int Key)  => 
            BlueprintMapLibrary_methods.Map_Find_method.Invoke(TargetMap, Key);

        ///<summary>
        ///Outputs an array of all keys present in the map
        ///@
        ///</summary>
        ///<remarks>
        ///param       TargetMap               The map to get the list of keys from
        ///@param       Keys                    All keys present in the map
        ///</remarks>
        public static IReadOnlyCollection<int> Map_Keys(byte TargetMap /*TODO: map TMap */)  => 
            BlueprintMapLibrary_methods.Map_Keys_method.Invoke(TargetMap);

        ///<summary>
        ///Determines the number of entries in a provided Map
        ///@
        ///</summary>
        ///<remarks>
        ///param       TargetMap               The map in question
        ///@return      The number of entries in the map
        ///</remarks>
        public static int Map_Length(byte TargetMap /*TODO: map TMap */)  => 
            BlueprintMapLibrary_methods.Map_Length_method.Invoke(TargetMap);

        ///<summary>Removes a key and its associated value from the map.</summary>
        ///<remarks>
        ///@param       TargetMap               The map to remove the key and its associated value from
        ///@param       Key                             The key that will be used to look the value up
        ///@return      True if an item was removed (False indicates nothing in the map uses the provided key)
        ///</remarks>
        public static bool Map_Remove(byte TargetMap /*TODO: map TMap */, int Key)  => 
            BlueprintMapLibrary_methods.Map_Remove_method.Invoke(TargetMap, Key);

        ///<summary>
        ///Outputs an array of all values present in the map
        ///@
        ///</summary>
        ///<remarks>
        ///param       TargetMap               The map to get the list of values from
        ///@param       Values                  All values present in the map
        ///</remarks>
        public static IReadOnlyCollection<int> Map_Values(byte TargetMap /*TODO: map TMap */)  => 
            BlueprintMapLibrary_methods.Map_Values_method.Invoke(TargetMap);

        ///<summary>Not exposed to users. Supports setting a map property on an object by name.</summary>
        public static void SetMapPropertyByName(UObject UObject, Name PropertyName, byte Value /*TODO: map TMap */)  => 
            BlueprintMapLibrary_methods.SetMapPropertyByName_method.Invoke(UObject, PropertyName, Value);
        static BlueprintMapLibrary() {
            StaticClass = Main.GetClass("BlueprintMapLibrary");
        }
        internal unsafe BlueprintMapLibrary_fields* BlueprintMapLibrary_ptr => (BlueprintMapLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintMapLibrary(IntPtr p) => UObject.Make<BlueprintMapLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintMapLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintMapLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
