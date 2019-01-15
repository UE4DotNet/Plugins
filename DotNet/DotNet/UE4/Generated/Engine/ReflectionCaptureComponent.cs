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
    ///<summary>-> will be exported to EngineDecalClasses.h</summary>
    public unsafe partial class ReflectionCaptureComponent : SceneComponent  {
        ///<summary>Capture Offset Component</summary>
        public unsafe BillboardComponent CaptureOffsetComponent {
            get {return ReflectionCaptureComponent_ptr->CaptureOffsetComponent;}
            set {ReflectionCaptureComponent_ptr->CaptureOffsetComponent = value;}
        }
         //TODO: enum EReflectionSourceType ReflectionSourceType
        ///<summary>Cubemap to use for reflection if ReflectionSourceType is set to RS_SpecifiedCubemap.</summary>
        public unsafe TextureCube Cubemap {
            get {return ReflectionCaptureComponent_ptr->Cubemap;}
        }
        ///<summary>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.</summary>
        public unsafe float SourceCubemapAngle {
            get {return ReflectionCaptureComponent_ptr->SourceCubemapAngle;}
        }
        ///<summary>A brightness control to scale the captured scene's reflection intensity.</summary>
        public unsafe float Brightness {
            get {return ReflectionCaptureComponent_ptr->Brightness;}
        }
        ///<summary>World space offset to apply before capturing.</summary>
        public unsafe Vector CaptureOffset {
            get {return ReflectionCaptureComponent_ptr->CaptureOffset;}
            set {ReflectionCaptureComponent_ptr->CaptureOffset = value;}
        }
        ///<summary>Guid for map build data</summary>
        public unsafe FGuid MapBuildDataId {
            get {return ReflectionCaptureComponent_ptr->MapBuildDataId;}
            set {ReflectionCaptureComponent_ptr->MapBuildDataId = value;}
        }
        static ReflectionCaptureComponent() {
            StaticClass = Main.GetClass("ReflectionCaptureComponent");
        }
        internal unsafe ReflectionCaptureComponent_fields* ReflectionCaptureComponent_ptr => (ReflectionCaptureComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReflectionCaptureComponent(IntPtr p) => UObject.Make<ReflectionCaptureComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReflectionCaptureComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReflectionCaptureComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
