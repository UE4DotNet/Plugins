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


namespace UE4.Engine{
        ///<summary>
        ///FWorldContext
        ///   A context for dealing with UWorlds at the engine level.
        ///</summary>
        ///<remarks>
        ///As the engine brings up and destroys world, we need a way to keep straight
        ///   what world belongs to what.
        ///
        ///   WorldContexts can be thought of as a track. By default we have 1 track that we load and unload levels on. Adding a second context is adding
        ///   a second track; another track of progression for worlds to live on.
        ///
        ///   For the GameEngine, there will be one WorldContext until we decide to support multiple simultaneous worlds.
        ///   For the EditorEngine, there may be one WorldContext for the EditorWorld and one for the PIE World.
        ///
        ///   FWorldContext provides both a way to manage 'the current PIE UWorld*' as well as state that goes along with connecting/travelling to
        ///new worlds.
        ///
        ///   FWorldContext should remain internal to the UEngine classes. Outside code should not keep pointers or try to manage FWorldContexts directly.
        ///   Outside code can still deal with UWorld*, and pass UWorld*s into Engine level functions. The Engine code can look up the relevant context
        ///   for a given UWorld*.
        ///
        ///For convenience, FWorldContext can maintain outside pointers to UWorld*s. For example, PIE can tie UWorld* UEditorEngine::PlayWorld to the PIE
        ///   world context. If the PIE UWorld changes, the UEditorEngine::PlayWorld pointer will be automatically updated. This is done with AddRef() and
        ///SetCurrentWorld().
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=672 )]
        public unsafe struct WorldContext {
            ///<summary>URL the last time we traveled</summary>
            [FieldOffset(240)] URL LastURL;

            ///<summary>last server we connected to (for "reconnect" command)</summary>
            [FieldOffset(352)] URL LastRemoteURL;

            [FieldOffset(464)] 
            private IntPtr  PendingNetGame_field;
            ///<summary>Pending Net Game</summary>
            public PendingNetGame PendingNetGame {
                get {return PendingNetGame_field;}
                set {PendingNetGame_field = value;}
            }

            [FieldOffset(472)] byte PackagesToFullyLoad; //TODO: array TArray PackagesToFullyLoad

            [FieldOffset(504)] byte LoadedLevelsForPendingMapChange; //TODO: array TArray LoadedLevelsForPendingMapChange

            [FieldOffset(544)] byte ObjectReferencers; //TODO: array TArray ObjectReferencers

            [FieldOffset(560)] byte PendingLevelStreamingStatusUpdates; //TODO: array TArray PendingLevelStreamingStatusUpdates

            [FieldOffset(576)] 
            private IntPtr  GameViewport_field;
            ///<summary>Game Viewport</summary>
            public GameViewportClient GameViewport {
                get {return GameViewport_field;}
                set {GameViewport_field = value;}
            }

            [FieldOffset(584)] 
            private IntPtr  OwningGameInstance_field;
            ///<summary>Owning Game Instance</summary>
            public GameInstance OwningGameInstance {
                get {return OwningGameInstance_field;}
                set {OwningGameInstance_field = value;}
            }

            [FieldOffset(592)] byte ActiveNetDrivers; //TODO: array TArray ActiveNetDrivers

        }
}
