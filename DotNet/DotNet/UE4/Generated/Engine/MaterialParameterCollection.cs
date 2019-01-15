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
    ///<summary>Asset class that contains a list of parameter names and their default values.</summary>
    ///<remarks>Any number of materials can reference these parameters and get new values when the parameter values are changed.</remarks>
    public unsafe partial class MaterialParameterCollection : UObject  {
        ///<summary>Used by materials using this collection to know when to recompile.</summary>
        public unsafe FGuid StateId {
            get {return MaterialParameterCollection_ptr->StateId;}
            set {MaterialParameterCollection_ptr->StateId = value;}
        }
         //TODO: array not UObject TArray ScalarParameters
         //TODO: array not UObject TArray VectorParameters
        static MaterialParameterCollection() {
            StaticClass = Main.GetClass("MaterialParameterCollection");
        }
        internal unsafe MaterialParameterCollection_fields* MaterialParameterCollection_ptr => (MaterialParameterCollection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialParameterCollection(IntPtr p) => UObject.Make<MaterialParameterCollection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialParameterCollection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialParameterCollection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
