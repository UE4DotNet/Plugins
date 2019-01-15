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
using UE4.DatasmithContent.Native;
using UE4.Engine;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Content Blueprint Library</summary>
    public unsafe partial class DatasmithContentBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Find all Datasmith User Data of loaded objects of the given type.</summary>
        ///<remarks>
        ///This is a slow operation, so editor only.
        ///@param  ObjectClass             Class of the object on which to filter, if specificed; otherwise there's no filtering
        ///@param  OutUserData             Output array of Datasmith User Data.
        ///</remarks>
        public static IReadOnlyCollection<DatasmithAssetUserData> GetAllDatasmithUserData(SubclassOf<UObject> ObjectClass)  => 
            DatasmithContentBlueprintLibrary_methods.GetAllDatasmithUserData_method.Invoke(ObjectClass);

        ///<summary>Find all loaded objects of the given type that have a Datasmith User Data that contains the given key and their associated values.</summary>
        ///<remarks>
        ///This is a slow operation, so editor only.
        ///@param  Key                     The key to find in the Datasmith User Data.
        ///@param  ObjectClass     Class of the object on which to filter, if specificed; otherwise there's no filtering
        ///@param  OutObjects      Output array of objects for which the Datasmith User Data match the given key.
        ///@param  OutValues       Output array of values associated with each object in OutObjects.
        ///</remarks>
        public static (IReadOnlyCollection<UObject>, IReadOnlyCollection<string>) GetAllObjectsAndValuesForKey(Name Key, SubclassOf<UObject> ObjectClass)  => 
            DatasmithContentBlueprintLibrary_methods.GetAllObjectsAndValuesForKey_method.Invoke(Key, ObjectClass);

        ///<summary>
        ///Get the Datasmith User Data of a given object
        ///@
        ///</summary>
        ///<remarks>
        ///param       Object  The Object from which to retrieve the Datasmith User Data.
        ///@return                      The Datasmith User Data if it exists; nullptr, otherwise
        ///</remarks>
        public static DatasmithAssetUserData GetDatasmithUserData(UObject UObject)  => 
            DatasmithContentBlueprintLibrary_methods.GetDatasmithUserData_method.Invoke(UObject);

        ///<summary>Get the keys and values for which the associated value contains the string to match for the Datasmith User Data of the given object.</summary>
        ///<remarks>
        ///@param       Object                  The Object from which to retrieve the Datasmith User Data.
        ///@param       StringToMatch   The string to match in the values.
        ///@param       OutKeys                 Output array of keys for which the associated values contain the string to match.
        ///@param       OutValues               Output array of values associated to the keys.
        ///</remarks>
        public static (IReadOnlyCollection<Name>, IReadOnlyCollection<string>) GetDatasmithUserDataKeysAndValuesForValue(UObject UObject, string StringToMatch)  => 
            DatasmithContentBlueprintLibrary_methods.GetDatasmithUserDataKeysAndValuesForValue_method.Invoke(UObject, StringToMatch);

        ///<summary>Get the value of the given key for the Datasmith User Data of the given object.</summary>
        ///<remarks>
        ///@param       Object  The Object from which to retrieve the Datasmith User Data.
        ///@param       Key             The key to find in the Datasmith User Data.
        ///@return                      The string value associated with the given key
        ///</remarks>
        public static string GetDatasmithUserDataValueForKey(UObject UObject, Name Key)  => 
            DatasmithContentBlueprintLibrary_methods.GetDatasmithUserDataValueForKey_method.Invoke(UObject, Key);
        static DatasmithContentBlueprintLibrary() {
            StaticClass = Main.GetClass("DatasmithContentBlueprintLibrary");
        }
        internal unsafe DatasmithContentBlueprintLibrary_fields* DatasmithContentBlueprintLibrary_ptr => (DatasmithContentBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithContentBlueprintLibrary(IntPtr p) => UObject.Make<DatasmithContentBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithContentBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithContentBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
