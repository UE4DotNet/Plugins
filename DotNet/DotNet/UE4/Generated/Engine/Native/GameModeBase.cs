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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1176 )]
    internal unsafe struct GameModeBase_fields {
        [FieldOffset(1016)] byte OptionsString; //TODO: string FString OptionsString
        [FieldOffset(1032)] public IntPtr GameSessionClass;
        [FieldOffset(1040)] public IntPtr GameStateClass;
        [FieldOffset(1048)] public IntPtr PlayerControllerClass;
        [FieldOffset(1056)] public IntPtr PlayerStateClass;
        [FieldOffset(1064)] public IntPtr HUDClass;
        [FieldOffset(1072)] public IntPtr DefaultPawnClass;
        [FieldOffset(1080)] public IntPtr SpectatorClass;
        [FieldOffset(1088)] public IntPtr ReplaySpectatorPlayerControllerClass;
        [FieldOffset(1096)] public IntPtr ServerStatReplicatorClass;
        [FieldOffset(1104)]  public IntPtr  GameSession;
        [FieldOffset(1112)]  public IntPtr  GameState;
        [FieldOffset(1120)]  public IntPtr  ServerStatReplicator;
        [FieldOffset(1128)] byte DefaultPlayerName; //TODO: text FText DefaultPlayerName
        [FieldOffset(1152)] public bool bUseSeamlessTravel;
        [FieldOffset(1152)] public bool bStartPlayersAsSpectators;
        [FieldOffset(1152)] public bool bPauseable;
    }
    internal unsafe struct GameModeBase_methods {
        internal struct ChangeName_method {
            static internal IntPtr ChangeName_ptr;
            static ChangeName_method() {
                ChangeName_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "ChangeName");
            }

            internal static unsafe void Invoke(IntPtr obj, Controller Controller, string NewName, bool bNameChange) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Controller;
                var NewName_handle = GCHandle.Alloc(NewName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = NewName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = NewName.Length;
                *(int*)(b+IntPtr.Size+4+8) = NewName.Length;
                *((bool*)(b+24)) = bNameChange;
                Main.GetProcessEvent(obj, ChangeName_ptr, new IntPtr(p)); ;
                NewName_handle.Free();
            }
        }
        internal struct GetNumPlayers_method {
            static internal IntPtr GetNumPlayers_ptr;
            static GetNumPlayers_method() {
                GetNumPlayers_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "GetNumPlayers");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumPlayers_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetNumSpectators_method {
            static internal IntPtr GetNumSpectators_ptr;
            static GetNumSpectators_method() {
                GetNumSpectators_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "GetNumSpectators");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumSpectators_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct HasMatchStarted_method {
            static internal IntPtr HasMatchStarted_ptr;
            static HasMatchStarted_method() {
                HasMatchStarted_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "HasMatchStarted");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, HasMatchStarted_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_FindPlayerStart_method {
            static internal IntPtr K2_FindPlayerStart_ptr;
            static K2_FindPlayerStart_method() {
                K2_FindPlayerStart_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "K2_FindPlayerStart");
            }

            internal static unsafe Actor Invoke(IntPtr obj, Controller Player, string IncomingName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Player;
                var IncomingName_handle = GCHandle.Alloc(IncomingName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = IncomingName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = IncomingName.Length;
                *(int*)(b+IntPtr.Size+4+8) = IncomingName.Length;
                Main.GetProcessEvent(obj, K2_FindPlayerStart_ptr, new IntPtr(p)); ;
                IncomingName_handle.Free();
                return *((IntPtr*)(b+24));
            }
        }
        internal struct ResetLevel_method {
            static internal IntPtr ResetLevel_ptr;
            static ResetLevel_method() {
                ResetLevel_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "ResetLevel");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetLevel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RestartPlayer_method {
            static internal IntPtr RestartPlayer_ptr;
            static RestartPlayer_method() {
                RestartPlayer_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "RestartPlayer");
            }

            internal static unsafe void Invoke(IntPtr obj, Controller NewPlayer) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewPlayer;
                Main.GetProcessEvent(obj, RestartPlayer_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RestartPlayerAtPlayerStart_method {
            static internal IntPtr RestartPlayerAtPlayerStart_ptr;
            static RestartPlayerAtPlayerStart_method() {
                RestartPlayerAtPlayerStart_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "RestartPlayerAtPlayerStart");
            }

            internal static unsafe void Invoke(IntPtr obj, Controller NewPlayer, Actor StartSpot) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewPlayer;
                *((IntPtr*)(b+8)) = StartSpot;
                Main.GetProcessEvent(obj, RestartPlayerAtPlayerStart_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RestartPlayerAtTransform_method {
            static internal IntPtr RestartPlayerAtTransform_ptr;
            static RestartPlayerAtTransform_method() {
                RestartPlayerAtTransform_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "RestartPlayerAtTransform");
            }

            internal static unsafe void Invoke(IntPtr obj, Controller NewPlayer, Transform SpawnTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewPlayer;
                *((Transform*)(b+16)) = SpawnTransform;
                Main.GetProcessEvent(obj, RestartPlayerAtTransform_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ReturnToMainMenuHost_method {
            static internal IntPtr ReturnToMainMenuHost_ptr;
            static ReturnToMainMenuHost_method() {
                ReturnToMainMenuHost_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "ReturnToMainMenuHost");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ReturnToMainMenuHost_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartPlay_method {
            static internal IntPtr StartPlay_ptr;
            static StartPlay_method() {
                StartPlay_ptr = Main.GetMethodUFunction(GameModeBase.StaticClass, "StartPlay");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StartPlay_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GameModeBase_events {
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        internal unsafe struct K2_OnChangeName_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnChangeName_link;
            private static unsafe void K2_OnChangeName_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnChangeName(UObject.Make<Controller>(*(IntPtr*)(b+0)), FString.Get(b+8), *(bool*)(b+24));
            }
            internal static void Setup() {
                K2_OnChangeName_link = new DelegateHolder<NativeFuncDelegate>(K2_OnChangeName_process_event);
                var uf = Main.GetUFunction("K2_OnChangeName");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnChangeName_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_OnLogout_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnLogout_link;
            private static unsafe void K2_OnLogout_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnLogout(UObject.Make<Controller>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                K2_OnLogout_link = new DelegateHolder<NativeFuncDelegate>(K2_OnLogout_process_event);
                var uf = Main.GetUFunction("K2_OnLogout");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnLogout_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_OnRestartPlayer_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnRestartPlayer_link;
            private static unsafe void K2_OnRestartPlayer_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnRestartPlayer(UObject.Make<Controller>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                K2_OnRestartPlayer_link = new DelegateHolder<NativeFuncDelegate>(K2_OnRestartPlayer_process_event);
                var uf = Main.GetUFunction("K2_OnRestartPlayer");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnRestartPlayer_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct K2_OnSwapPlayerControllers_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnSwapPlayerControllers_link;
            private static unsafe void K2_OnSwapPlayerControllers_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnSwapPlayerControllers(UObject.Make<PlayerController>(*(IntPtr*)(b+0)), UObject.Make<PlayerController>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                K2_OnSwapPlayerControllers_link = new DelegateHolder<NativeFuncDelegate>(K2_OnSwapPlayerControllers_process_event);
                var uf = Main.GetUFunction("K2_OnSwapPlayerControllers");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnSwapPlayerControllers_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_PostLogin_event {
            private static DelegateHolder<NativeFuncDelegate> K2_PostLogin_link;
            private static unsafe void K2_PostLogin_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_PostLogin(UObject.Make<PlayerController>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                K2_PostLogin_link = new DelegateHolder<NativeFuncDelegate>(K2_PostLogin_process_event);
                var uf = Main.GetUFunction("K2_PostLogin");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_PostLogin_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct CanSpectate_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> CanSpectate_link;
            private static unsafe void CanSpectate_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_CanSpectate(UObject.Make<PlayerController>(*(IntPtr*)(b+0)), UObject.Make<PlayerState>(*(IntPtr*)(b+8)), *(bool*)result);
            }
            internal static void Setup() {
                CanSpectate_link = new DelegateHolder<NativeFuncDelegate>(CanSpectate_process_event);
                var uf = Main.GetUFunction("CanSpectate");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(CanSpectate_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ChoosePlayerStart_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> ChoosePlayerStart_link;
            private static unsafe void ChoosePlayerStart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(IntPtr*)result.ToPointer() = obj.on_ChoosePlayerStart(UObject.Make<Controller>(*(IntPtr*)(b+0)), *(IntPtr*)result);
            }
            internal static void Setup() {
                ChoosePlayerStart_link = new DelegateHolder<NativeFuncDelegate>(ChoosePlayerStart_process_event);
                var uf = Main.GetUFunction("ChoosePlayerStart");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ChoosePlayerStart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        internal unsafe struct FindPlayerStart_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> FindPlayerStart_link;
            private static unsafe void FindPlayerStart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(IntPtr*)result.ToPointer() = obj.on_FindPlayerStart(UObject.Make<Controller>(*(IntPtr*)(b+0)), FString.Get(b+8), *(IntPtr*)result);
            }
            internal static void Setup() {
                FindPlayerStart_link = new DelegateHolder<NativeFuncDelegate>(FindPlayerStart_process_event);
                var uf = Main.GetUFunction("FindPlayerStart");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(FindPlayerStart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct GetDefaultPawnClassForController_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> GetDefaultPawnClassForController_link;
            private static unsafe void GetDefaultPawnClassForController_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(IntPtr*)result.ToPointer() = obj.on_GetDefaultPawnClassForController(UObject.Make<Controller>(*(IntPtr*)(b+0)), *(IntPtr*)result);
            }
            internal static void Setup() {
                GetDefaultPawnClassForController_link = new DelegateHolder<NativeFuncDelegate>(GetDefaultPawnClassForController_process_event);
                var uf = Main.GetUFunction("GetDefaultPawnClassForController");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(GetDefaultPawnClassForController_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct HandleStartingNewPlayer_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> HandleStartingNewPlayer_link;
            private static unsafe void HandleStartingNewPlayer_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                obj.on_HandleStartingNewPlayer(UObject.Make<PlayerController>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                HandleStartingNewPlayer_link = new DelegateHolder<NativeFuncDelegate>(HandleStartingNewPlayer_process_event);
                var uf = Main.GetUFunction("HandleStartingNewPlayer");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(HandleStartingNewPlayer_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct InitializeHUDForPlayer_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> InitializeHUDForPlayer_link;
            private static unsafe void InitializeHUDForPlayer_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                obj.on_InitializeHUDForPlayer(UObject.Make<PlayerController>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                InitializeHUDForPlayer_link = new DelegateHolder<NativeFuncDelegate>(InitializeHUDForPlayer_process_event);
                var uf = Main.GetUFunction("InitializeHUDForPlayer");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(InitializeHUDForPlayer_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct InitStartSpot_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> InitStartSpot_link;
            private static unsafe void InitStartSpot_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                obj.on_InitStartSpot(UObject.Make<Actor>(*(IntPtr*)(b+0)), UObject.Make<Controller>(*(IntPtr*)(b+8)));
            }
            internal static void Setup() {
                InitStartSpot_link = new DelegateHolder<NativeFuncDelegate>(InitStartSpot_process_event);
                var uf = Main.GetUFunction("InitStartSpot");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(InitStartSpot_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct MustSpectate_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> MustSpectate_link;
            private static unsafe void MustSpectate_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_MustSpectate(UObject.Make<PlayerController>(*(IntPtr*)(b+0)), *(bool*)result);
            }
            internal static void Setup() {
                MustSpectate_link = new DelegateHolder<NativeFuncDelegate>(MustSpectate_process_event);
                var uf = Main.GetUFunction("MustSpectate");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(MustSpectate_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct PlayerCanRestart_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> PlayerCanRestart_link;
            private static unsafe void PlayerCanRestart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_PlayerCanRestart(UObject.Make<PlayerController>(*(IntPtr*)(b+0)), *(bool*)result);
            }
            internal static void Setup() {
                PlayerCanRestart_link = new DelegateHolder<NativeFuncDelegate>(PlayerCanRestart_process_event);
                var uf = Main.GetUFunction("PlayerCanRestart");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(PlayerCanRestart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ShouldReset_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> ShouldReset_link;
            private static unsafe void ShouldReset_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_ShouldReset(UObject.Make<Actor>(*(IntPtr*)(b+0)), *(bool*)result);
            }
            internal static void Setup() {
                ShouldReset_link = new DelegateHolder<NativeFuncDelegate>(ShouldReset_process_event);
                var uf = Main.GetUFunction("ShouldReset");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ShouldReset_link.Delegate));
            }
        }
        //TODO: event_native_blueprint: event with ref struct parameterSpawnDefaultPawnAtTransform
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct SpawnDefaultPawnFor_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> SpawnDefaultPawnFor_link;
            private static unsafe void SpawnDefaultPawnFor_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<GameModeBase>(context);
                var b = (byte*) theStack->Locals;
                *(IntPtr*)result.ToPointer() = obj.on_SpawnDefaultPawnFor(UObject.Make<Controller>(*(IntPtr*)(b+0)), UObject.Make<Actor>(*(IntPtr*)(b+8)), *(IntPtr*)result);
            }
            internal static void Setup() {
                SpawnDefaultPawnFor_link = new DelegateHolder<NativeFuncDelegate>(SpawnDefaultPawnFor_process_event);
                var uf = Main.GetUFunction("SpawnDefaultPawnFor");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(SpawnDefaultPawnFor_link.Delegate));
            }
        }
    }
}
