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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Gizmo Actor</summary>
    public unsafe partial class LandscapeGizmoActor : Actor  {
        ///<summary>Width</summary>
        public unsafe float Width {
            get {return LandscapeGizmoActor_ptr->Width;}
            set {LandscapeGizmoActor_ptr->Width = value;}
        }
        ///<summary>Height</summary>
        public unsafe float Height {
            get {return LandscapeGizmoActor_ptr->Height;}
            set {LandscapeGizmoActor_ptr->Height = value;}
        }
        ///<summary>Length Z</summary>
        public unsafe float LengthZ {
            get {return LandscapeGizmoActor_ptr->LengthZ;}
            set {LandscapeGizmoActor_ptr->LengthZ = value;}
        }
        ///<summary>Margin Z</summary>
        public unsafe float MarginZ {
            get {return LandscapeGizmoActor_ptr->MarginZ;}
            set {LandscapeGizmoActor_ptr->MarginZ = value;}
        }
        ///<summary>Min Relative Z</summary>
        public unsafe float MinRelativeZ {
            get {return LandscapeGizmoActor_ptr->MinRelativeZ;}
            set {LandscapeGizmoActor_ptr->MinRelativeZ = value;}
        }
        ///<summary>Relative Scale Z</summary>
        public unsafe float RelativeScaleZ {
            get {return LandscapeGizmoActor_ptr->RelativeScaleZ;}
            set {LandscapeGizmoActor_ptr->RelativeScaleZ = value;}
        }
        ///<summary>Target Landscape Info</summary>
        public unsafe LandscapeInfo TargetLandscapeInfo {
            get {return LandscapeGizmoActor_ptr->TargetLandscapeInfo;}
            set {LandscapeGizmoActor_ptr->TargetLandscapeInfo = value;}
        }
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return LandscapeGizmoActor_ptr->SpriteComponent;}
            set {LandscapeGizmoActor_ptr->SpriteComponent = value;}
        }
        static LandscapeGizmoActor() {
            StaticClass = Main.GetClass("LandscapeGizmoActor");
        }
        internal unsafe LandscapeGizmoActor_fields* LandscapeGizmoActor_ptr => (LandscapeGizmoActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeGizmoActor(IntPtr p) => UObject.Make<LandscapeGizmoActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeGizmoActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeGizmoActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
