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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>Env Query Generator Actors Of Class</summary>
    public unsafe partial class EnvQueryGenerator_ActorsOfClass : EnvQueryGenerator  {
        ///<summary>Searched Actor Class</summary>
        public unsafe SubclassOf<Actor> SearchedActorClass {
            get {return EnvQueryGenerator_ActorsOfClass_ptr->SearchedActorClass;}
            set {EnvQueryGenerator_ActorsOfClass_ptr->SearchedActorClass = value;}
        }
        ///<summary>If true, this will only returns actors of the specified class within the SearchRadius of the SearchCenter context.  If false, it will return ALL actors of the specified class in the world.</summary>
        public unsafe AIDataProviderBoolValue GenerateOnlyActorsInRadius {
            get {return EnvQueryGenerator_ActorsOfClass_ptr->GenerateOnlyActorsInRadius;}
            set {EnvQueryGenerator_ActorsOfClass_ptr->GenerateOnlyActorsInRadius = value;}
        }
        ///<summary>Max distance of path between point and context.</summary>
        ///<remarks>
        ///NOTE: Zero and negative values will never return any results if
        ///UseRadius is true.  "Within" requires Distance < Radius.  Actors ON the circle (Distance == Radius) are excluded.
        ///</remarks>
        public unsafe AIDataProviderFloatValue SearchRadius {
            get {return EnvQueryGenerator_ActorsOfClass_ptr->SearchRadius;}
            set {EnvQueryGenerator_ActorsOfClass_ptr->SearchRadius = value;}
        }
        ///<summary>context</summary>
        public unsafe SubclassOf<EnvQueryContext> SearchCenter {
            get {return EnvQueryGenerator_ActorsOfClass_ptr->SearchCenter;}
            set {EnvQueryGenerator_ActorsOfClass_ptr->SearchCenter = value;}
        }
        static EnvQueryGenerator_ActorsOfClass() {
            StaticClass = Main.GetClass("EnvQueryGenerator_ActorsOfClass");
        }
        internal unsafe EnvQueryGenerator_ActorsOfClass_fields* EnvQueryGenerator_ActorsOfClass_ptr => (EnvQueryGenerator_ActorsOfClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_ActorsOfClass(IntPtr p) => UObject.Make<EnvQueryGenerator_ActorsOfClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_ActorsOfClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_ActorsOfClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
