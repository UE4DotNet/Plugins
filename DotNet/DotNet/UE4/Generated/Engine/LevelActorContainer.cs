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
    ///<summary>Root object for all level actors</summary>
    public unsafe partial class LevelActorContainer : UObject  {
        ///<summary>Array of actors in a level</summary>
        public ObjectArrayField<Actor> Actors{ get {
            if(Actors_store == null) Actors_store = new ObjectArrayField<Actor> (&LevelActorContainer_ptr->Actors);
            return Actors_store;
        } }
        private ObjectArrayField<Actor> Actors_store;

        static LevelActorContainer() {
            StaticClass = Main.GetClass("LevelActorContainer");
        }
        internal unsafe LevelActorContainer_fields* LevelActorContainer_ptr => (LevelActorContainer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelActorContainer(IntPtr p) => UObject.Make<LevelActorContainer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelActorContainer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelActorContainer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
