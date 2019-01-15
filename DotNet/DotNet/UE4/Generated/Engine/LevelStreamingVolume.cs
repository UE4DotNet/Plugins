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
    ///<summary>Level Streaming Volume</summary>
    public unsafe partial class LevelStreamingVolume : Volume  {
         //TODO: array not UObject TArray StreamingLevelNames
        public bool bEditorPreVisOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bEditorPreVisOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditorPreVisOnly", value); }
        }
        public bool bDisabled {
            get {return Main.GetGetBoolPropertyByName(this, "bDisabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisabled", value); }
        }
        ///<summary>Determines what this volume is used for, e.g. whether to control loading, loading and visibility or just visibilty (blocking on load)</summary>
        public unsafe byte StreamingUsage {
            get {return LevelStreamingVolume_ptr->StreamingUsage;}
            set {LevelStreamingVolume_ptr->StreamingUsage = value;}
        }
        static LevelStreamingVolume() {
            StaticClass = Main.GetClass("LevelStreamingVolume");
        }
        internal unsafe LevelStreamingVolume_fields* LevelStreamingVolume_ptr => (LevelStreamingVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelStreamingVolume(IntPtr p) => UObject.Make<LevelStreamingVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelStreamingVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelStreamingVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
