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
using UE4.UMG.Native;
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>Viewport</summary>
    public unsafe partial class Viewport : ContentWidget  {

        ///<summary>Get View Location</summary>
        public Vector GetViewLocation()  => 
            Viewport_methods.GetViewLocation_method.Invoke(ObjPointer);

        ///<summary>Get Viewport World</summary>
        public World GetViewportWorld()  => 
            Viewport_methods.GetViewportWorld_method.Invoke(ObjPointer);

        ///<summary>Get View Rotation</summary>
        public Rotator GetViewRotation()  => 
            Viewport_methods.GetViewRotation_method.Invoke(ObjPointer);

        ///<summary>Set View Location</summary>
        public void SetViewLocation(Vector Location)  => 
            Viewport_methods.SetViewLocation_method.Invoke(ObjPointer, Location);

        ///<summary>Set View Rotation</summary>
        public void SetViewRotation(Rotator Rotation)  => 
            Viewport_methods.SetViewRotation_method.Invoke(ObjPointer, Rotation);

        ///<summary>Spawn</summary>
        public Actor Spawn(SubclassOf<Actor> ActorClass)  => 
            Viewport_methods.Spawn_method.Invoke(ObjPointer, ActorClass);
        ///<summary>Background Color</summary>
        public unsafe LinearColor BackgroundColor {
            get {return Viewport_ptr->BackgroundColor;}
            set {Viewport_ptr->BackgroundColor = value;}
        }
        static Viewport() {
            StaticClass = Main.GetClass("Viewport");
        }
        internal unsafe Viewport_fields* Viewport_ptr => (Viewport_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Viewport(IntPtr p) => UObject.Make<Viewport>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Viewport DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Viewport New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
