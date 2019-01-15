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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Actor Factory</summary>
    public unsafe partial class ActorFactory : UObject  {
         //TODO: text FText DisplayName
        ///<summary>Indicates how far up the menu item should be. The higher the number, the higher up the list.</summary>
        public unsafe int MenuPriority {
            get {return ActorFactory_ptr->MenuPriority;}
            set {ActorFactory_ptr->MenuPriority = value;}
        }
         //TODO: string FString NewActorClassName
        ///<summary>AActor  subclass this ActorFactory creates.</summary>
        public unsafe SubclassOf<Actor> NewActorClass {
            get {return ActorFactory_ptr->NewActorClass;}
            set {ActorFactory_ptr->NewActorClass = value;}
        }
        public bool bShowInEditorQuickMenu {
            get {return Main.GetGetBoolPropertyByName(this, "bShowInEditorQuickMenu"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowInEditorQuickMenu", value); }
        }
        public bool bUseSurfaceOrientation {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSurfaceOrientation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSurfaceOrientation", value); }
        }
        ///<summary>Translation applied to the spawn position.</summary>
        public unsafe Vector SpawnPositionOffset {
            get {return ActorFactory_ptr->SpawnPositionOffset;}
            set {ActorFactory_ptr->SpawnPositionOffset = value;}
        }
        static ActorFactory() {
            StaticClass = Main.GetClass("ActorFactory");
        }
        internal unsafe ActorFactory_fields* ActorFactory_ptr => (ActorFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorFactory(IntPtr p) => UObject.Make<ActorFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
