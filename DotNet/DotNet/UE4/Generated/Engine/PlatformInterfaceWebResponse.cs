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
    ///<summary>Platform Interface Web Response</summary>
    public unsafe partial class PlatformInterfaceWebResponse : UObject  {
         //TODO: string FString OriginalURL
        ///<summary>Result code from the response (200=OK, 404=Not Found, etc)</summary>
        public unsafe int ResponseCode {
            get {return PlatformInterfaceWebResponse_ptr->ResponseCode;}
            set {PlatformInterfaceWebResponse_ptr->ResponseCode = value;}
        }
        ///<summary>A user-specified tag specified with the request</summary>
        public unsafe int Tag {
            get {return PlatformInterfaceWebResponse_ptr->Tag;}
            set {PlatformInterfaceWebResponse_ptr->Tag = value;}
        }
         //TODO: string FString StringResponse
         //TODO: array not UObject TArray BinaryResponse
        static PlatformInterfaceWebResponse() {
            StaticClass = Main.GetClass("PlatformInterfaceWebResponse");
        }
        internal unsafe PlatformInterfaceWebResponse_fields* PlatformInterfaceWebResponse_ptr => (PlatformInterfaceWebResponse_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlatformInterfaceWebResponse(IntPtr p) => UObject.Make<PlatformInterfaceWebResponse>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlatformInterfaceWebResponse DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlatformInterfaceWebResponse New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
