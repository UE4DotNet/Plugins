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
    ///<summary>This class acts as a base class for a save game object that can be used to save state about the game.</summary>
    ///<remarks>
    ///When you create your own save game subclass, you would add member variables for the information that you want to save.
    ///Then when you want to save a game, create an instance of this object using CreateSaveGameObject, fill in the data, and use SaveGameToSlot, providing a slot name.
    ///To load the game you then just use LoadGameFromSlot, and read the data from the resulting object.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/SaveGame
    ///</remarks>
    public unsafe partial class SaveGame : UObject  {
        static SaveGame() {
            StaticClass = Main.GetClass("SaveGame");
        }
        internal unsafe SaveGame_fields* SaveGame_ptr => (SaveGame_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SaveGame(IntPtr p) => UObject.Make<SaveGame>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SaveGame DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SaveGame New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
