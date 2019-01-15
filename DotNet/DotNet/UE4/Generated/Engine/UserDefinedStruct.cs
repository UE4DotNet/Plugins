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
    ///<summary>User Defined Struct</summary>
    public unsafe partial class UserDefinedStruct : ScriptStruct  {
         //TODO: weak object TWeakObjectPtr<UUserDefinedStruct> PrimaryStruct
         //TODO: string FString ErrorMessage
        ///<summary>Editor Data</summary>
        public unsafe UObject EditorData {
            get {return UserDefinedStruct_ptr->EditorData;}
            set {UserDefinedStruct_ptr->EditorData = value;}
        }
        ///<summary>Status of this struct, outside of the editor it is assumed to always be UpToDate</summary>
        public unsafe byte Status {
            get {return UserDefinedStruct_ptr->Status;}
            set {UserDefinedStruct_ptr->Status = value;}
        }
        ///<summary>Uniquely identifies this specific user struct</summary>
        public unsafe FGuid FGuid {
            get {return UserDefinedStruct_ptr->FGuid;}
            set {UserDefinedStruct_ptr->FGuid = value;}
        }
        static UserDefinedStruct() {
            StaticClass = Main.GetClass("UserDefinedStruct");
        }
        internal unsafe UserDefinedStruct_fields* UserDefinedStruct_ptr => (UserDefinedStruct_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserDefinedStruct(IntPtr p) => UObject.Make<UserDefinedStruct>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserDefinedStruct DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserDefinedStruct New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
