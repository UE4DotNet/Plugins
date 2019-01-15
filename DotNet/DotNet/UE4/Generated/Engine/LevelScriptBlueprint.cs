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
    ///<summary>A level blueprint is a specialized type of blueprint.</summary>
    ///<remarks>
    ///It is used to house
    ///global, level-wide logic. In a level blueprint, you can operate on specific
    ///level-actor instances through blueprint's node-based interface. UE3 users
    ///should be familiar with this concept, as it is very similar to Kismet.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Blueprints/UserGuide/Types/LevelBlueprint/index.html
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Blueprints/index.html
    ///@see UBlueprint
    ///@see ALevelScriptActor
    ///</remarks>
    public unsafe partial class LevelScriptBlueprint : Blueprint  {
         //TODO: string FString FriendlyName
        static LevelScriptBlueprint() {
            StaticClass = Main.GetClass("LevelScriptBlueprint");
        }
        internal unsafe LevelScriptBlueprint_fields* LevelScriptBlueprint_ptr => (LevelScriptBlueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelScriptBlueprint(IntPtr p) => UObject.Make<LevelScriptBlueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelScriptBlueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelScriptBlueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
