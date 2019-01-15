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
    ///<summary>Interp Track Director</summary>
    public unsafe partial class InterpTrackDirector : InterpTrack  {
         //TODO: array not UObject TArray CutTrack
        public bool bSimulateCameraCutsOnClients {
            get {return Main.GetGetBoolPropertyByName(this, "bSimulateCameraCutsOnClients"); }
            set {Main.SetGetBoolPropertyByName(this, "bSimulateCameraCutsOnClients", value); }
        }
        ///<summary>The camera actor which the track is currently focused on. Only valid if this track or it's group is selected</summary>
        public unsafe CameraActor PreviewCamera {
            get {return InterpTrackDirector_ptr->PreviewCamera;}
            set {InterpTrackDirector_ptr->PreviewCamera = value;}
        }
        static InterpTrackDirector() {
            StaticClass = Main.GetClass("InterpTrackDirector");
        }
        internal unsafe InterpTrackDirector_fields* InterpTrackDirector_ptr => (InterpTrackDirector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackDirector(IntPtr p) => UObject.Make<InterpTrackDirector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackDirector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackDirector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
