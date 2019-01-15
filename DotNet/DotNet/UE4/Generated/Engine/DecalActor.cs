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
    ///<summary>DecalActor contains a DecalComponent which can be used to render material modifications on top of existing geometry.</summary>
    ///<remarks>
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Actors/DecalActor
    ///@see UDecalComponent
    ///</remarks>
    public unsafe partial class DecalActor : Actor  {

        ///<summary>Create Dynamic Material Instance</summary>
        public MaterialInstanceDynamic CreateDynamicMaterialInstance()  => 
            DecalActor_methods.CreateDynamicMaterialInstance_method.Invoke(ObjPointer);

        ///<summary>Get Decal Material</summary>
        public MaterialInterface GetDecalMaterial()  => 
            DecalActor_methods.GetDecalMaterial_method.Invoke(ObjPointer);

        ///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
        public void SetDecalMaterial(MaterialInterface NewDecalMaterial)  => 
            DecalActor_methods.SetDecalMaterial_method.Invoke(ObjPointer, NewDecalMaterial);
        ///<summary>The decal component for this decal actor</summary>
        public unsafe DecalComponent Decal {
            get {return DecalActor_ptr->Decal;}
        }
        ///<summary>Reference to the editor only arrow visualization component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return DecalActor_ptr->ArrowComponent;}
            set {DecalActor_ptr->ArrowComponent = value;}
        }
        ///<summary>Reference to the billboard component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return DecalActor_ptr->SpriteComponent;}
            set {DecalActor_ptr->SpriteComponent = value;}
        }
        static DecalActor() {
            StaticClass = Main.GetClass("DecalActor");
        }
        internal unsafe DecalActor_fields* DecalActor_ptr => (DecalActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DecalActor(IntPtr p) => UObject.Make<DecalActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DecalActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DecalActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
