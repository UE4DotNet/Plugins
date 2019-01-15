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
    ///<summary>Object Referencer</summary>
    public unsafe partial class ObjectReferencer : UObject  {
        ///<summary>Array of objects being referenced.</summary>
        public ObjectArrayField<UObject> ReferencedObjects{ get {
            if(ReferencedObjects_store == null) ReferencedObjects_store = new ObjectArrayField<UObject> (&ObjectReferencer_ptr->ReferencedObjects);
            return ReferencedObjects_store;
        } }
        private ObjectArrayField<UObject> ReferencedObjects_store;

        static ObjectReferencer() {
            StaticClass = Main.GetClass("ObjectReferencer");
        }
        internal unsafe ObjectReferencer_fields* ObjectReferencer_ptr => (ObjectReferencer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ObjectReferencer(IntPtr p) => UObject.Make<ObjectReferencer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ObjectReferencer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ObjectReferencer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
