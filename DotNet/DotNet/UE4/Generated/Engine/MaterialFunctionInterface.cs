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
    ///<summary>A Material Function is a collection of material expressions that can be reused in different materials</summary>
    public unsafe partial class MaterialFunctionInterface : UObject  {
        ///<summary>Used by materials using this function to know when to recompile.</summary>
        public unsafe FGuid StateId {
            get {return MaterialFunctionInterface_ptr->StateId;}
            set {MaterialFunctionInterface_ptr->StateId = value;}
        }
        ///<summary>The intended usage of this function, required for material layers.</summary>
        public unsafe byte MaterialFunctionUsage {
            get {return MaterialFunctionInterface_ptr->MaterialFunctionUsage;}
            set {MaterialFunctionInterface_ptr->MaterialFunctionUsage = value;}
        }
         //TODO: numeric uint32 CombinedInputTypes
         //TODO: numeric uint32 CombinedOutputTypes
        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return MaterialFunctionInterface_ptr->ThumbnailInfo;}
            set {MaterialFunctionInterface_ptr->ThumbnailInfo = value;}
        }
        static MaterialFunctionInterface() {
            StaticClass = Main.GetClass("MaterialFunctionInterface");
        }
        internal unsafe MaterialFunctionInterface_fields* MaterialFunctionInterface_ptr => (MaterialFunctionInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialFunctionInterface(IntPtr p) => UObject.Make<MaterialFunctionInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialFunctionInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialFunctionInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
