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
    public unsafe partial class BoxReflectionCaptureComponent : ReflectionCaptureComponent  {
        ///<summary>Adjust capture transition distance</summary>
        public unsafe float BoxTransitionDistance {
            get {return BoxReflectionCaptureComponent_ptr->BoxTransitionDistance;}
            set {BoxReflectionCaptureComponent_ptr->BoxTransitionDistance = value;}
        }
        ///<summary>Preview Influence Box</summary>
        public unsafe BoxComponent PreviewInfluenceBox {
            get {return BoxReflectionCaptureComponent_ptr->PreviewInfluenceBox;}
            set {BoxReflectionCaptureComponent_ptr->PreviewInfluenceBox = value;}
        }
        ///<summary>Preview Capture Box</summary>
        public unsafe BoxComponent PreviewCaptureBox {
            get {return BoxReflectionCaptureComponent_ptr->PreviewCaptureBox;}
            set {BoxReflectionCaptureComponent_ptr->PreviewCaptureBox = value;}
        }
        static BoxReflectionCaptureComponent() {
            StaticClass = Main.GetClass("BoxReflectionCaptureComponent");
        }
        internal unsafe BoxReflectionCaptureComponent_fields* BoxReflectionCaptureComponent_ptr => (BoxReflectionCaptureComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BoxReflectionCaptureComponent(IntPtr p) => UObject.Make<BoxReflectionCaptureComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BoxReflectionCaptureComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BoxReflectionCaptureComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
