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
using UE4.DatasmithContent.Native;
using UE4.Engine;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Area Light Actor</summary>
    public unsafe partial class DatasmithAreaLightActor : Actor  {
         //TODO: enum EDatasmithAreaLightActorShape LightShape
        ///<summary>Dimensions</summary>
        public unsafe Vector2D Dimensions {
            get {return DatasmithAreaLightActor_ptr->Dimensions;}
            set {DatasmithAreaLightActor_ptr->Dimensions = value;}
        }
        ///<summary>Color</summary>
        public unsafe LinearColor Color {
            get {return DatasmithAreaLightActor_ptr->Color;}
            set {DatasmithAreaLightActor_ptr->Color = value;}
        }
        ///<summary>Intensity</summary>
        public unsafe float Intensity {
            get {return DatasmithAreaLightActor_ptr->Intensity;}
            set {DatasmithAreaLightActor_ptr->Intensity = value;}
        }
        static DatasmithAreaLightActor() {
            StaticClass = Main.GetClass("DatasmithAreaLightActor");
        }
        internal unsafe DatasmithAreaLightActor_fields* DatasmithAreaLightActor_ptr => (DatasmithAreaLightActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithAreaLightActor(IntPtr p) => UObject.Make<DatasmithAreaLightActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithAreaLightActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithAreaLightActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
