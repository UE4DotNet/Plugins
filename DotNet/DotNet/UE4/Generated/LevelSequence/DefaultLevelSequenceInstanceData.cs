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
using UE4.LevelSequence.Native;
using UE4.Engine;

namespace UE4.LevelSequence {
    ///<summary>Default instance data class that level sequences understand. Implements IMovieSceneTransformOrigin.</summary>
    public unsafe partial class DefaultLevelSequenceInstanceData : UObject  {
        ///<summary>When set, this actor's world position will be used as the transform origin for all absolute transform sections</summary>
        public unsafe Actor TransformOriginActor {
            get {return DefaultLevelSequenceInstanceData_ptr->TransformOriginActor;}
            set {DefaultLevelSequenceInstanceData_ptr->TransformOriginActor = value;}
        }
        ///<summary>Specifies a transform from which all absolute transform sections inside the sequence should be added to. Scale is ignored.</summary>
        public unsafe Transform TransformOrigin {
            get {return DefaultLevelSequenceInstanceData_ptr->TransformOrigin;}
            set {DefaultLevelSequenceInstanceData_ptr->TransformOrigin = value;}
        }
        static DefaultLevelSequenceInstanceData() {
            StaticClass = Main.GetClass("DefaultLevelSequenceInstanceData");
        }
        internal unsafe DefaultLevelSequenceInstanceData_fields* DefaultLevelSequenceInstanceData_ptr => (DefaultLevelSequenceInstanceData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DefaultLevelSequenceInstanceData(IntPtr p) => UObject.Make<DefaultLevelSequenceInstanceData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DefaultLevelSequenceInstanceData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DefaultLevelSequenceInstanceData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
