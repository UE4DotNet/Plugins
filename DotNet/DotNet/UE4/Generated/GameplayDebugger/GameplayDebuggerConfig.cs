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
using UE4.GameplayDebugger.Native;
using UE4.InputCore;

namespace UE4.GameplayDebugger {
    ///<summary>Gameplay Debugger Config</summary>
    public unsafe partial class GameplayDebuggerConfig : UObject  {
        ///<summary>key used to activate visual debugger tool</summary>
        public unsafe Key ActivationKey {
            get {return GameplayDebuggerConfig_ptr->ActivationKey;}
            set {GameplayDebuggerConfig_ptr->ActivationKey = value;}
        }
        ///<summary>select next category row</summary>
        public unsafe Key CategoryRowNextKey {
            get {return GameplayDebuggerConfig_ptr->CategoryRowNextKey;}
            set {GameplayDebuggerConfig_ptr->CategoryRowNextKey = value;}
        }
        ///<summary>select previous category row</summary>
        public unsafe Key CategoryRowPrevKey {
            get {return GameplayDebuggerConfig_ptr->CategoryRowPrevKey;}
            set {GameplayDebuggerConfig_ptr->CategoryRowPrevKey = value;}
        }
        ///<summary>select category slot 0</summary>
        public unsafe Key CategorySlot0 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot0;}
            set {GameplayDebuggerConfig_ptr->CategorySlot0 = value;}
        }
        ///<summary>select category slot 1</summary>
        public unsafe Key CategorySlot1 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot1;}
            set {GameplayDebuggerConfig_ptr->CategorySlot1 = value;}
        }
        ///<summary>select category slot 2</summary>
        public unsafe Key CategorySlot2 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot2;}
            set {GameplayDebuggerConfig_ptr->CategorySlot2 = value;}
        }
        ///<summary>select category slot 3</summary>
        public unsafe Key CategorySlot3 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot3;}
            set {GameplayDebuggerConfig_ptr->CategorySlot3 = value;}
        }
        ///<summary>select category slot 4</summary>
        public unsafe Key CategorySlot4 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot4;}
            set {GameplayDebuggerConfig_ptr->CategorySlot4 = value;}
        }
        ///<summary>select category slot 5</summary>
        public unsafe Key CategorySlot5 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot5;}
            set {GameplayDebuggerConfig_ptr->CategorySlot5 = value;}
        }
        ///<summary>select category slot 6</summary>
        public unsafe Key CategorySlot6 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot6;}
            set {GameplayDebuggerConfig_ptr->CategorySlot6 = value;}
        }
        ///<summary>select category slot 7</summary>
        public unsafe Key CategorySlot7 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot7;}
            set {GameplayDebuggerConfig_ptr->CategorySlot7 = value;}
        }
        ///<summary>select category slot 8</summary>
        public unsafe Key CategorySlot8 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot8;}
            set {GameplayDebuggerConfig_ptr->CategorySlot8 = value;}
        }
        ///<summary>select category slot 9</summary>
        public unsafe Key CategorySlot9 {
            get {return GameplayDebuggerConfig_ptr->CategorySlot9;}
            set {GameplayDebuggerConfig_ptr->CategorySlot9 = value;}
        }
        ///<summary>additional canvas padding: left</summary>
        public unsafe float DebugCanvasPaddingLeft {
            get {return GameplayDebuggerConfig_ptr->DebugCanvasPaddingLeft;}
            set {GameplayDebuggerConfig_ptr->DebugCanvasPaddingLeft = value;}
        }
        ///<summary>additional canvas padding: right</summary>
        public unsafe float DebugCanvasPaddingRight {
            get {return GameplayDebuggerConfig_ptr->DebugCanvasPaddingRight;}
            set {GameplayDebuggerConfig_ptr->DebugCanvasPaddingRight = value;}
        }
        ///<summary>additional canvas padding: top</summary>
        public unsafe float DebugCanvasPaddingTop {
            get {return GameplayDebuggerConfig_ptr->DebugCanvasPaddingTop;}
            set {GameplayDebuggerConfig_ptr->DebugCanvasPaddingTop = value;}
        }
        ///<summary>additional canvas padding: bottom</summary>
        public unsafe float DebugCanvasPaddingBottom {
            get {return GameplayDebuggerConfig_ptr->DebugCanvasPaddingBottom;}
            set {GameplayDebuggerConfig_ptr->DebugCanvasPaddingBottom = value;}
        }
         //TODO: array not UObject TArray Categories
         //TODO: array not UObject TArray Extensions
        static GameplayDebuggerConfig() {
            StaticClass = Main.GetClass("GameplayDebuggerConfig");
        }
        internal unsafe GameplayDebuggerConfig_fields* GameplayDebuggerConfig_ptr => (GameplayDebuggerConfig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayDebuggerConfig(IntPtr p) => UObject.Make<GameplayDebuggerConfig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayDebuggerConfig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayDebuggerConfig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
