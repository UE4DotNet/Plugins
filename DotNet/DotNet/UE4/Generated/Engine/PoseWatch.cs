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
    ///<summary>Pose Watch</summary>
    public unsafe partial class PoseWatch : UObject  {
        ///<summary>Node that we are trying to watch</summary>
        public unsafe EdGraphNode Node {
            get {return PoseWatch_ptr->Node;}
            set {PoseWatch_ptr->Node = value;}
        }
        ///<summary>Pose Watch Colour</summary>
        public unsafe Color PoseWatchColour {
            get {return PoseWatch_ptr->PoseWatchColour;}
            set {PoseWatch_ptr->PoseWatchColour = value;}
        }
        static PoseWatch() {
            StaticClass = Main.GetClass("PoseWatch");
        }
        internal unsafe PoseWatch_fields* PoseWatch_ptr => (PoseWatch_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PoseWatch(IntPtr p) => UObject.Make<PoseWatch>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PoseWatch DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PoseWatch New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
