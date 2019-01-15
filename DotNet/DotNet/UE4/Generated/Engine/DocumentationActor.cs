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
    ///<summary>Documentation Actor</summary>
    public unsafe partial class DocumentationActor : Actor  {
         //TODO: string FString DocumentLink
        ///<summary>Billboard</summary>
        public unsafe MaterialBillboardComponent Billboard {
            get {return DocumentationActor_ptr->Billboard;}
        }
        static DocumentationActor() {
            StaticClass = Main.GetClass("DocumentationActor");
        }
        internal unsafe DocumentationActor_fields* DocumentationActor_ptr => (DocumentationActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DocumentationActor(IntPtr p) => UObject.Make<DocumentationActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DocumentationActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DocumentationActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
