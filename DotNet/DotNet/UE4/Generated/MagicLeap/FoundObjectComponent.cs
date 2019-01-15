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
    ///<summary>Creates requests to find objects and delegates their result.</summary>
    public unsafe partial class FoundObjectComponent : SceneComponent  {

        ///<summary>Query for objects with the current values of the component members.</summary>
        ///<remarks>
        ///@param QueryID Can be used to identify the results.
        ///@param ResultDelegate Delegate which will be called when the found object result is ready.
        ///@returns True if the found object query was successfully placed, false otherwise.
        ///</remarks>
        public (int, bool) SubmitQuery(byte ResultDelegate /*TODO: delegate FFoundObjectResultDelegate */)  => 
            FoundObjectComponent_methods.SubmitQuery_method.Invoke(ObjPointer, ResultDelegate);
         //TODO: string FString QueryObjectID
         //TODO: array not UObject TArray QueryLabels
         //TODO: array not UObject TArray QueryTypes
         //TODO: array not UObject TArray QueryProperties
        ///<summary>The maximum number of objects that should be returned in the result.</summary>
        public unsafe int MaxResults {
            get {return FoundObjectComponent_ptr->MaxResults;}
            set {FoundObjectComponent_ptr->MaxResults = value;}
        }
        ///<summary>Bounding box for searching the objects in.</summary>
        public unsafe BoxComponent SearchVolume {
            get {return FoundObjectComponent_ptr->SearchVolume;}
            set {FoundObjectComponent_ptr->SearchVolume = value;}
        }
        static FoundObjectComponent() {
            StaticClass = Main.GetClass("FoundObjectComponent");
        }
        internal unsafe FoundObjectComponent_fields* FoundObjectComponent_ptr => (FoundObjectComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FoundObjectComponent(IntPtr p) => UObject.Make<FoundObjectComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FoundObjectComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FoundObjectComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
