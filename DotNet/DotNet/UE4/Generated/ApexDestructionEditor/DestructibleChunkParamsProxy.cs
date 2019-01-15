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
using UE4.ApexDestructionEditor.Native;
using UE4.ApexDestruction;

namespace UE4.ApexDestructionEditor {
    ///<summary>Destructible Chunk Params Proxy</summary>
    public unsafe partial class DestructibleChunkParamsProxy : UObject  {
        ///<summary>Destructible Mesh</summary>
        public unsafe DestructibleMesh DestructibleMesh {
            get {return DestructibleChunkParamsProxy_ptr->DestructibleMesh;}
            set {DestructibleChunkParamsProxy_ptr->DestructibleMesh = value;}
        }
        ///<summary>Chunk Index</summary>
        public unsafe int ChunkIndex {
            get {return DestructibleChunkParamsProxy_ptr->ChunkIndex;}
            set {DestructibleChunkParamsProxy_ptr->ChunkIndex = value;}
        }
        ///<summary>Chunk Params</summary>
        public unsafe DestructibleChunkParameters ChunkParams {
            get {return DestructibleChunkParamsProxy_ptr->ChunkParams;}
            set {DestructibleChunkParamsProxy_ptr->ChunkParams = value;}
        }
        static DestructibleChunkParamsProxy() {
            StaticClass = Main.GetClass("DestructibleChunkParamsProxy");
        }
        internal unsafe DestructibleChunkParamsProxy_fields* DestructibleChunkParamsProxy_ptr => (DestructibleChunkParamsProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DestructibleChunkParamsProxy(IntPtr p) => UObject.Make<DestructibleChunkParamsProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DestructibleChunkParamsProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DestructibleChunkParamsProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
