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
    ///<summary>Inheritable Component Handler</summary>
    public unsafe partial class InheritableComponentHandler : UObject  {
         //TODO: array not UObject TArray Records
        ///<summary>List of components that were marked unnecessary, need to keep these around so it doesn't regenerate them when a child asks for one</summary>
        public ObjectArrayField<ActorComponent> UnnecessaryComponents{ get {
            if(UnnecessaryComponents_store == null) UnnecessaryComponents_store = new ObjectArrayField<ActorComponent> (&InheritableComponentHandler_ptr->UnnecessaryComponents);
            return UnnecessaryComponents_store;
        } }
        private ObjectArrayField<ActorComponent> UnnecessaryComponents_store;

        static InheritableComponentHandler() {
            StaticClass = Main.GetClass("InheritableComponentHandler");
        }
        internal unsafe InheritableComponentHandler_fields* InheritableComponentHandler_ptr => (InheritableComponentHandler_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InheritableComponentHandler(IntPtr p) => UObject.Make<InheritableComponentHandler>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InheritableComponentHandler DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InheritableComponentHandler New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
