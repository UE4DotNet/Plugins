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
    ///<summary>
    ///Node Mapping Container Class
    ///* This saves source items, and target items, and mapping between
    ///* Used by Retargeting, Control Rig mapping.
    ///</summary>
    ///<remarks>Will need to improve interface better</remarks>
    public unsafe partial class NodeMappingContainer : UObject  {
         //TODO: map TMap SourceItems
         //TODO: map TMap TargetItems
         //TODO: map TMap SourceToTarget
         //TODO: soft object TSoftObjectPtr<UObject> SourceAsset
         //TODO: soft object TSoftObjectPtr<UObject> TargetAsset
        static NodeMappingContainer() {
            StaticClass = Main.GetClass("NodeMappingContainer");
        }
        internal unsafe NodeMappingContainer_fields* NodeMappingContainer_ptr => (NodeMappingContainer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NodeMappingContainer(IntPtr p) => UObject.Make<NodeMappingContainer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NodeMappingContainer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NodeMappingContainer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
