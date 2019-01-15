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
    ///<summary>Static Mesh Socket</summary>
    public unsafe partial class StaticMeshSocket : UObject  {
        ///<summary>Defines a named attachment location on the UStaticMesh.</summary>
        ///<remarks>
        ///These are set up in editor and used as a shortcut instead of specifying
        ///everything explicitly to AttachComponent in the StaticMeshComponent.
        ///The Outer of a StaticMeshSocket should always be the UStaticMesh.
        ///</remarks>
        public unsafe Name SocketName {
            get {return StaticMeshSocket_ptr->SocketName;}
        }
        ///<summary>Relative Location</summary>
        public unsafe Vector RelativeLocation {
            get {return StaticMeshSocket_ptr->RelativeLocation;}
            set {StaticMeshSocket_ptr->RelativeLocation = value;}
        }
        ///<summary>Relative Rotation</summary>
        public unsafe Rotator RelativeRotation {
            get {return StaticMeshSocket_ptr->RelativeRotation;}
            set {StaticMeshSocket_ptr->RelativeRotation = value;}
        }
        ///<summary>Relative Scale</summary>
        public unsafe Vector RelativeScale {
            get {return StaticMeshSocket_ptr->RelativeScale;}
            set {StaticMeshSocket_ptr->RelativeScale = value;}
        }
         //TODO: string FString Tag
        ///<summary>Preview Static Mesh</summary>
        public unsafe StaticMesh PreviewStaticMesh {
            get {return StaticMeshSocket_ptr->PreviewStaticMesh;}
            set {StaticMeshSocket_ptr->PreviewStaticMesh = value;}
        }
        public bool bSocketCreatedAtImport {
            get {return Main.GetGetBoolPropertyByName(this, "bSocketCreatedAtImport"); }
            set {Main.SetGetBoolPropertyByName(this, "bSocketCreatedAtImport", value); }
        }
        static StaticMeshSocket() {
            StaticClass = Main.GetClass("StaticMeshSocket");
        }
        internal unsafe StaticMeshSocket_fields* StaticMeshSocket_ptr => (StaticMeshSocket_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StaticMeshSocket(IntPtr p) => UObject.Make<StaticMeshSocket>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StaticMeshSocket DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StaticMeshSocket New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
