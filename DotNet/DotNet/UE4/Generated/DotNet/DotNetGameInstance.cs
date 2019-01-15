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
using UE4.DotNet.Native;
using UE4.Engine;

namespace UE4.DotNet {
    ///<summary>Dot Net Game Instance</summary>
    public unsafe partial class DotNetGameInstance : GameInstance  {

        ///<summary>Set Game Mode Base</summary>
        public event SetGameModeBase_delegate SetGameModeBase;
        public delegate void SetGameModeBase_delegate(GameModeBase gameModeBase, string mapURL);
        internal void on_SetGameModeBase(GameModeBase gameModeBase, string mapURL) =>
            SetGameModeBase?.Invoke(gameModeBase, mapURL);

        ///<summary>Axis Bindings</summary>
        public ObjectArrayField<DotNetAxisBinding> AxisBindings{ get {
            if(AxisBindings_store == null) AxisBindings_store = new ObjectArrayField<DotNetAxisBinding> (&DotNetGameInstance_ptr->AxisBindings);
            return AxisBindings_store;
        } }
        private ObjectArrayField<DotNetAxisBinding> AxisBindings_store;

        ///<summary>Action Bindings</summary>
        public ObjectArrayField<DotNetActionBinding> ActionBindings{ get {
            if(ActionBindings_store == null) ActionBindings_store = new ObjectArrayField<DotNetActionBinding> (&DotNetGameInstance_ptr->ActionBindings);
            return ActionBindings_store;
        } }
        private ObjectArrayField<DotNetActionBinding> ActionBindings_store;

        ///<summary>Objects Shared with Dot Net</summary>
        public ObjectArrayField<UObject> ObjectsSharedWithDotNet{ get {
            if(ObjectsSharedWithDotNet_store == null) ObjectsSharedWithDotNet_store = new ObjectArrayField<UObject> (&DotNetGameInstance_ptr->ObjectsSharedWithDotNet);
            return ObjectsSharedWithDotNet_store;
        } }
        private ObjectArrayField<UObject> ObjectsSharedWithDotNet_store;

        ///<summary>First Free Shared</summary>
        public unsafe int FirstFreeShared {
            get {return DotNetGameInstance_ptr->FirstFreeShared;}
            set {DotNetGameInstance_ptr->FirstFreeShared = value;}
        }
        static DotNetGameInstance() {
            StaticClass = Main.GetClass("DotNetGameInstance");
            DotNetGameInstance_events.SetGameModeBase_event.Setup();
        }
        internal unsafe DotNetGameInstance_fields* DotNetGameInstance_ptr => (DotNetGameInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DotNetGameInstance(IntPtr p) => UObject.Make<DotNetGameInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DotNetGameInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DotNetGameInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
