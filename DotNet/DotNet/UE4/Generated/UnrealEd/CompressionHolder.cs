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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Compression Holder</summary>
    public unsafe partial class CompressionHolder : UObject  {
        ///<summary>Compression</summary>
        public unsafe AnimCompress Compression {
            get {return CompressionHolder_ptr->Compression;}
            set {CompressionHolder_ptr->Compression = value;}
        }
        static CompressionHolder() {
            StaticClass = Main.GetClass("CompressionHolder");
        }
        internal unsafe CompressionHolder_fields* CompressionHolder_ptr => (CompressionHolder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CompressionHolder(IntPtr p) => UObject.Make<CompressionHolder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CompressionHolder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CompressionHolder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
