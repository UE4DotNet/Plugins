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
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>Creates raycast requests and delegates their result.</summary>
    public unsafe partial class RaycastComponent : ActorComponent  {

        ///<summary>Requests a raycast with the given query parameters.</summary>
        ///<remarks>
        ///@param RequestParams Parameters for the raycast query.
        ///@param ResultDelegate Delegate which will be called when the raycast result is ready.
        ///@returns True if the raycast request was successfully placed, false otherwise.
        ///</remarks>
        public bool RequestRaycast(RaycastQueryParams RequestParams, byte ResultDelegate /*TODO: delegate FRaycastResultDelegate */)  => 
            RaycastComponent_methods.RequestRaycast_method.Invoke(ObjPointer, RequestParams, ResultDelegate);
        static RaycastComponent() {
            StaticClass = Main.GetClass("RaycastComponent");
        }
        internal unsafe RaycastComponent_fields* RaycastComponent_ptr => (RaycastComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RaycastComponent(IntPtr p) => UObject.Make<RaycastComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RaycastComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RaycastComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
