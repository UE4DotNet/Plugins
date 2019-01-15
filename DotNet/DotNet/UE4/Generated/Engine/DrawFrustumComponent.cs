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
    ///<summary>Utility component for drawing a view frustum. Origin is at the component location, frustum points down position X axis.</summary>
    public unsafe partial class DrawFrustumComponent : PrimitiveComponent  {
        ///<summary>Color to draw the wireframe frustum.</summary>
        public unsafe Color FrustumColor {
            get {return DrawFrustumComponent_ptr->FrustumColor;}
            set {DrawFrustumComponent_ptr->FrustumColor = value;}
        }
        ///<summary>Angle of longest dimension of view shape.</summary>
        ///<remarks>If the angle is 0 then an orthographic projection is used</remarks>
        public unsafe float FrustumAngle {
            get {return DrawFrustumComponent_ptr->FrustumAngle;}
            set {DrawFrustumComponent_ptr->FrustumAngle = value;}
        }
        ///<summary>Ratio of horizontal size over vertical size.</summary>
        public unsafe float FrustumAspectRatio {
            get {return DrawFrustumComponent_ptr->FrustumAspectRatio;}
            set {DrawFrustumComponent_ptr->FrustumAspectRatio = value;}
        }
        ///<summary>Distance from origin to start drawing the frustum.</summary>
        public unsafe float FrustumStartDist {
            get {return DrawFrustumComponent_ptr->FrustumStartDist;}
            set {DrawFrustumComponent_ptr->FrustumStartDist = value;}
        }
        ///<summary>Distance from origin to stop drawing the frustum.</summary>
        public unsafe float FrustumEndDist {
            get {return DrawFrustumComponent_ptr->FrustumEndDist;}
            set {DrawFrustumComponent_ptr->FrustumEndDist = value;}
        }
        ///<summary>optional texture to show on the near plane</summary>
        public unsafe Texture Texture {
            get {return DrawFrustumComponent_ptr->Texture;}
            set {DrawFrustumComponent_ptr->Texture = value;}
        }
        static DrawFrustumComponent() {
            StaticClass = Main.GetClass("DrawFrustumComponent");
        }
        internal unsafe DrawFrustumComponent_fields* DrawFrustumComponent_ptr => (DrawFrustumComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DrawFrustumComponent(IntPtr p) => UObject.Make<DrawFrustumComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DrawFrustumComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DrawFrustumComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
