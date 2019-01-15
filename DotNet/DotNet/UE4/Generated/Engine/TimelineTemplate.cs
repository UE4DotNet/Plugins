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
    ///<summary>Timeline Template</summary>
    public unsafe partial class TimelineTemplate : UObject  {
        ///<summary>Length of this timeline</summary>
        public unsafe float TimelineLength {
            get {return TimelineTemplate_ptr->TimelineLength;}
            set {TimelineTemplate_ptr->TimelineLength = value;}
        }
        ///<summary>How we want the timeline to determine its own length (e.g. specified length, last keyframe)</summary>
        public unsafe byte LengthMode {
            get {return TimelineTemplate_ptr->LengthMode;}
            set {TimelineTemplate_ptr->LengthMode = value;}
        }
        public bool bAutoPlay {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoPlay"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoPlay", value); }
        }
        public bool bLoop {
            get {return Main.GetGetBoolPropertyByName(this, "bLoop"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoop", value); }
        }
        public bool bReplicated {
            get {return Main.GetGetBoolPropertyByName(this, "bReplicated"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplicated", value); }
        }
        public bool bValidatedAsWired {
            get {return Main.GetGetBoolPropertyByName(this, "bValidatedAsWired"); }
            set {Main.SetGetBoolPropertyByName(this, "bValidatedAsWired", value); }
        }
        public bool bIgnoreTimeDilation {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreTimeDilation"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreTimeDilation", value); }
        }
         //TODO: array not UObject TArray EventTracks
         //TODO: array not UObject TArray FloatTracks
         //TODO: array not UObject TArray VectorTracks
         //TODO: array not UObject TArray LinearColorTracks
         //TODO: array not UObject TArray MetaDataArray
        ///<summary>Timeline Guid</summary>
        public unsafe FGuid TimelineGuid {
            get {return TimelineTemplate_ptr->TimelineGuid;}
            set {TimelineTemplate_ptr->TimelineGuid = value;}
        }
        static TimelineTemplate() {
            StaticClass = Main.GetClass("TimelineTemplate");
        }
        internal unsafe TimelineTemplate_fields* TimelineTemplate_ptr => (TimelineTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TimelineTemplate(IntPtr p) => UObject.Make<TimelineTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TimelineTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TimelineTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
