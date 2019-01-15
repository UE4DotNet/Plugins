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
using UE4.MagicLeapSecureStorage.Native;
using UE4.Engine;

namespace UE4.MagicLeapSecureStorage {
    ///<summary>Function library for the Magic Leap Secure Storage API.</summary>
    ///<remarks>
    ///Currently supports bool, uint8, int32, float, FString, FVector, FRotator and FTransform via Blueprints.
    ///Provides a template function for any non specialized types to be used via C++.
    ///TODO: Support TArray and a generic USTRUCT.
    ///</remarks>
    public unsafe partial class MagicLeapSecureStorage : BlueprintFunctionLibrary  {

        ///<summary>Deletes the data associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key of the data to delete.
        ///@return  True if the data was deleted successfully or did not exist altogether, false otherwise.
        ///</remarks>
        public static bool DeleteSecureData(string Key)  => 
            MagicLeapSecureStorage_methods.DeleteSecureData_method.Invoke(Key);

        ///<summary>Retrieves the boolean associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (bool, bool) GetSecureBool(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureBool_method.Invoke(Key);

        ///<summary>Retrieves the byte (uint8) associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (byte, bool) GetSecureByte(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureByte_method.Invoke(Key);

        ///<summary>Retrieves the float associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (float, bool) GetSecureFloat(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureFloat_method.Invoke(Key);

        ///<summary>Retrieves the integer (int32) associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (int, bool) GetSecureInt(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureInt_method.Invoke(Key);

        ///<summary>Retrieves the rotator associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (Rotator, bool) GetSecureRotator(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureRotator_method.Invoke(Key);

        ///<summary>Retrieves the string associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (string, bool) GetSecureString(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureString_method.Invoke(Key);

        ///<summary>Retrieves the transform associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (Transform, bool) GetSecureTransform(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureTransform_method.Invoke(Key);

        ///<summary>Retrieves the vector associated with the specified key.</summary>
        ///<remarks>
        ///@param   Key The string key to look for.
        ///@param   DataToRetrieve Reference to the variable that will be populated with the stored data.
        ///@return  True if the key was found and output parameter was successfully populated with the data, false otherwise.
        ///</remarks>
        public static (Vector, bool) GetSecureVector(string Key)  => 
            MagicLeapSecureStorage_methods.GetSecureVector_method.Invoke(Key);

        ///<summary>Stores the boolean under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureBool(string Key, bool DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureBool_method.Invoke(Key, DataToStore);

        ///<summary>Stores the byte (uint8) under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureByte(string Key, byte DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureByte_method.Invoke(Key, DataToStore);

        ///<summary>Stores the float under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureFloat(string Key, float DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureFloat_method.Invoke(Key, DataToStore);

        ///<summary>Stores the integer (int32) under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureInt(string Key, int DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureInt_method.Invoke(Key, DataToStore);

        ///<summary>Stores the rotator under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureRotator(string Key, Rotator DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureRotator_method.Invoke(Key, DataToStore);

        ///<summary>Stores the string under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureString(string Key, string DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureString_method.Invoke(Key, DataToStore);

        ///<summary>Stores the transform under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureTransform(string Key, Transform DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureTransform_method.Invoke(Key, DataToStore);

        ///<summary>Stores the vector under the specified key.</summary>
        ///<remarks>
        ///An existing key would be overwritten.
        ///@param   Key String key associated with the data.
        ///@param   DataToStore The data to store.
        ///@return  True if the data was stored successfully, false otherwise.
        ///</remarks>
        public static bool PutSecureVector(string Key, Vector DataToStore)  => 
            MagicLeapSecureStorage_methods.PutSecureVector_method.Invoke(Key, DataToStore);
        static MagicLeapSecureStorage() {
            StaticClass = Main.GetClass("MagicLeapSecureStorage");
        }
        internal unsafe MagicLeapSecureStorage_fields* MagicLeapSecureStorage_ptr => (MagicLeapSecureStorage_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapSecureStorage(IntPtr p) => UObject.Make<MagicLeapSecureStorage>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapSecureStorage DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapSecureStorage New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
