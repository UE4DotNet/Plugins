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

using UE4.Engine;

namespace UE4.GameplayTags.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct BlueprintGameplayTagLibrary_fields {
    }
    internal unsafe struct BlueprintGameplayTagLibrary_methods {
        internal struct AddGameplayTag_method {
            static internal IntPtr AddGameplayTag_ptr;
            static AddGameplayTag_method() {
                AddGameplayTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "AddGameplayTag");
            }

            internal static unsafe void Invoke(GameplayTagContainer TagContainer, GameplayTag Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                *((GameplayTag*)(b+32)) = Tag;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, AddGameplayTag_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AppendGameplayTagContainers_method {
            static internal IntPtr AppendGameplayTagContainers_ptr;
            static AppendGameplayTagContainers_method() {
                AppendGameplayTagContainers_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "AppendGameplayTagContainers");
            }

            internal static unsafe void Invoke(GameplayTagContainer InOutTagContainer, GameplayTagContainer InTagContainer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = InOutTagContainer;
                *((GameplayTagContainer*)(b+32)) = InTagContainer;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, AppendGameplayTagContainers_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BreakGameplayTagContainer_method {
            static internal IntPtr BreakGameplayTagContainer_ptr;
            static BreakGameplayTagContainer_method() {
                BreakGameplayTagContainer_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "BreakGameplayTagContainer");
            }

            internal static unsafe IReadOnlyCollection<GameplayTag> Invoke(GameplayTagContainer GameplayTagContainer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = GameplayTagContainer;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, BreakGameplayTagContainer_ptr, new IntPtr(p)); ;
                 //TODO: array TArray GameplayTags
                return UObject.ToUnmangedCollection<GameplayTag>(b+32);
            }
        }
        internal struct DoesContainerMatchTagQuery_method {
            static internal IntPtr DoesContainerMatchTagQuery_ptr;
            static DoesContainerMatchTagQuery_method() {
                DoesContainerMatchTagQuery_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "DoesContainerMatchTagQuery");
            }

            internal static unsafe bool Invoke(GameplayTagContainer TagContainer, GameplayTagQuery TagQuery) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                *((GameplayTagQuery*)(b+32)) = TagQuery;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, DoesContainerMatchTagQuery_ptr, new IntPtr(p)); ;
                return *((bool*)(b+104));
            }
        }
        internal struct DoesTagAssetInterfaceHaveTag_method {
            static internal IntPtr DoesTagAssetInterfaceHaveTag_ptr;
            static DoesTagAssetInterfaceHaveTag_method() {
                DoesTagAssetInterfaceHaveTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "DoesTagAssetInterfaceHaveTag");
            }

            internal static unsafe bool Invoke(byte TagContainerInterface /*TODO: interface TScriptInterface */, GameplayTag Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface TagContainerInterface
                *((GameplayTag*)(b+16)) = Tag;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, DoesTagAssetInterfaceHaveTag_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface TagContainerInterface
                return *((bool*)(b+28));
            }
        }
        internal struct EqualEqual_GameplayTag_method {
            static internal IntPtr EqualEqual_GameplayTag_ptr;
            static EqualEqual_GameplayTag_method() {
                EqualEqual_GameplayTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "EqualEqual_GameplayTag");
            }

            internal static unsafe bool Invoke(GameplayTag A, GameplayTag B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = A;
                *((GameplayTag*)(b+12)) = B;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, EqualEqual_GameplayTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct EqualEqual_GameplayTagContainer_method {
            static internal IntPtr EqualEqual_GameplayTagContainer_ptr;
            static EqualEqual_GameplayTagContainer_method() {
                EqualEqual_GameplayTagContainer_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "EqualEqual_GameplayTagContainer");
            }

            internal static unsafe bool Invoke(GameplayTagContainer A, GameplayTagContainer B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = A;
                *((GameplayTagContainer*)(b+32)) = B;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, EqualEqual_GameplayTagContainer_ptr, new IntPtr(p)); ;
                return *((bool*)(b+64));
            }
        }
        internal struct GetAllActorsOfClassMatchingTagQuery_method {
            static internal IntPtr GetAllActorsOfClassMatchingTagQuery_ptr;
            static GetAllActorsOfClassMatchingTagQuery_method() {
                GetAllActorsOfClassMatchingTagQuery_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "GetAllActorsOfClassMatchingTagQuery");
            }

            internal static unsafe IReadOnlyCollection<Actor> Invoke(UObject WorldContextObject, SubclassOf<Actor> ActorClass, GameplayTagQuery GameplayTagQuery) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = ActorClass;
                *((GameplayTagQuery*)(b+16)) = GameplayTagQuery;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, GetAllActorsOfClassMatchingTagQuery_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutActors
                return UObject.ToUObjectCollection<Actor>(b+88);
            }
        }
        internal struct GetDebugStringFromGameplayTag_method {
            static internal IntPtr GetDebugStringFromGameplayTag_ptr;
            static GetDebugStringFromGameplayTag_method() {
                GetDebugStringFromGameplayTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "GetDebugStringFromGameplayTag");
            }

            internal static unsafe string Invoke(GameplayTag GameplayTag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = GameplayTag;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, GetDebugStringFromGameplayTag_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct GetDebugStringFromGameplayTagContainer_method {
            static internal IntPtr GetDebugStringFromGameplayTagContainer_ptr;
            static GetDebugStringFromGameplayTagContainer_method() {
                GetDebugStringFromGameplayTagContainer_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "GetDebugStringFromGameplayTagContainer");
            }

            internal static unsafe string Invoke(GameplayTagContainer TagContainer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, GetDebugStringFromGameplayTagContainer_ptr, new IntPtr(p)); ;
                return FString.Get(b+32);
            }
        }
        internal struct GetNumGameplayTagsInContainer_method {
            static internal IntPtr GetNumGameplayTagsInContainer_ptr;
            static GetNumGameplayTagsInContainer_method() {
                GetNumGameplayTagsInContainer_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "GetNumGameplayTagsInContainer");
            }

            internal static unsafe int Invoke(GameplayTagContainer TagContainer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, GetNumGameplayTagsInContainer_ptr, new IntPtr(p)); ;
                return *((int*)(b+32));
            }
        }
        internal struct GetTagName_method {
            static internal IntPtr GetTagName_ptr;
            static GetTagName_method() {
                GetTagName_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "GetTagName");
            }

            internal static unsafe Name Invoke(GameplayTag GameplayTag) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = GameplayTag;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, GetTagName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+12));
            }
        }
        internal struct HasAllMatchingGameplayTags_method {
            static internal IntPtr HasAllMatchingGameplayTags_ptr;
            static HasAllMatchingGameplayTags_method() {
                HasAllMatchingGameplayTags_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "HasAllMatchingGameplayTags");
            }

            internal static unsafe bool Invoke(byte TagContainerInterface /*TODO: interface TScriptInterface */, GameplayTagContainer OtherContainer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: interface TScriptInterface TagContainerInterface
                *((GameplayTagContainer*)(b+16)) = OtherContainer;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, HasAllMatchingGameplayTags_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface TagContainerInterface
                return *((bool*)(b+48));
            }
        }
        internal struct HasAllTags_method {
            static internal IntPtr HasAllTags_ptr;
            static HasAllTags_method() {
                HasAllTags_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "HasAllTags");
            }

            internal static unsafe bool Invoke(GameplayTagContainer TagContainer, GameplayTagContainer OtherContainer, bool bExactMatch) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                *((GameplayTagContainer*)(b+32)) = OtherContainer;
                *((bool*)(b+64)) = bExactMatch;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, HasAllTags_ptr, new IntPtr(p)); ;
                return *((bool*)(b+65));
            }
        }
        internal struct HasAnyTags_method {
            static internal IntPtr HasAnyTags_ptr;
            static HasAnyTags_method() {
                HasAnyTags_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "HasAnyTags");
            }

            internal static unsafe bool Invoke(GameplayTagContainer TagContainer, GameplayTagContainer OtherContainer, bool bExactMatch) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                *((GameplayTagContainer*)(b+32)) = OtherContainer;
                *((bool*)(b+64)) = bExactMatch;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, HasAnyTags_ptr, new IntPtr(p)); ;
                return *((bool*)(b+65));
            }
        }
        internal struct HasTag_method {
            static internal IntPtr HasTag_ptr;
            static HasTag_method() {
                HasTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "HasTag");
            }

            internal static unsafe bool Invoke(GameplayTagContainer TagContainer, GameplayTag Tag, bool bExactMatch) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                *((GameplayTag*)(b+32)) = Tag;
                *((bool*)(b+44)) = bExactMatch;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, HasTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+45));
            }
        }
        internal struct IsGameplayTagValid_method {
            static internal IntPtr IsGameplayTagValid_ptr;
            static IsGameplayTagValid_method() {
                IsGameplayTagValid_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "IsGameplayTagValid");
            }

            internal static unsafe bool Invoke(GameplayTag GameplayTag) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = GameplayTag;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, IsGameplayTagValid_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct MakeGameplayTagContainerFromArray_method {
            static internal IntPtr MakeGameplayTagContainerFromArray_ptr;
            static MakeGameplayTagContainerFromArray_method() {
                MakeGameplayTagContainerFromArray_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "MakeGameplayTagContainerFromArray");
            }

            internal static unsafe GameplayTagContainer Invoke(byte GameplayTags /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray GameplayTags
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, MakeGameplayTagContainerFromArray_ptr, new IntPtr(p)); ;
                 //TODO: array TArray GameplayTags
                return *((GameplayTagContainer*)(b+16));
            }
        }
        internal struct MakeGameplayTagContainerFromTag_method {
            static internal IntPtr MakeGameplayTagContainerFromTag_ptr;
            static MakeGameplayTagContainerFromTag_method() {
                MakeGameplayTagContainerFromTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "MakeGameplayTagContainerFromTag");
            }

            internal static unsafe GameplayTagContainer Invoke(GameplayTag SingleTag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = SingleTag;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, MakeGameplayTagContainerFromTag_ptr, new IntPtr(p)); ;
                return *((GameplayTagContainer*)(b+16));
            }
        }
        internal struct MakeGameplayTagQuery_method {
            static internal IntPtr MakeGameplayTagQuery_ptr;
            static MakeGameplayTagQuery_method() {
                MakeGameplayTagQuery_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "MakeGameplayTagQuery");
            }

            internal static unsafe GameplayTagQuery Invoke(GameplayTagQuery TagQuery) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagQuery*)(b+0)) = TagQuery;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, MakeGameplayTagQuery_ptr, new IntPtr(p)); ;
                return *((GameplayTagQuery*)(b+72));
            }
        }
        internal struct MakeLiteralGameplayTag_method {
            static internal IntPtr MakeLiteralGameplayTag_ptr;
            static MakeLiteralGameplayTag_method() {
                MakeLiteralGameplayTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "MakeLiteralGameplayTag");
            }

            internal static unsafe GameplayTag Invoke(GameplayTag Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = Value;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, MakeLiteralGameplayTag_ptr, new IntPtr(p)); ;
                return *((GameplayTag*)(b+12));
            }
        }
        internal struct MakeLiteralGameplayTagContainer_method {
            static internal IntPtr MakeLiteralGameplayTagContainer_ptr;
            static MakeLiteralGameplayTagContainer_method() {
                MakeLiteralGameplayTagContainer_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "MakeLiteralGameplayTagContainer");
            }

            internal static unsafe GameplayTagContainer Invoke(GameplayTagContainer Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = Value;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, MakeLiteralGameplayTagContainer_ptr, new IntPtr(p)); ;
                return *((GameplayTagContainer*)(b+32));
            }
        }
        internal struct MatchesAnyTags_method {
            static internal IntPtr MatchesAnyTags_ptr;
            static MatchesAnyTags_method() {
                MatchesAnyTags_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "MatchesAnyTags");
            }

            internal static unsafe bool Invoke(GameplayTag TagOne, GameplayTagContainer OtherContainer, bool bExactMatch) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = TagOne;
                *((GameplayTagContainer*)(b+16)) = OtherContainer;
                *((bool*)(b+48)) = bExactMatch;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, MatchesAnyTags_ptr, new IntPtr(p)); ;
                return *((bool*)(b+49));
            }
        }
        internal struct MatchesTag_method {
            static internal IntPtr MatchesTag_ptr;
            static MatchesTag_method() {
                MatchesTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "MatchesTag");
            }

            internal static unsafe bool Invoke(GameplayTag TagOne, GameplayTag TagTwo, bool bExactMatch) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = TagOne;
                *((GameplayTag*)(b+12)) = TagTwo;
                *((bool*)(b+24)) = bExactMatch;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, MatchesTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+25));
            }
        }
        internal struct NotEqual_GameplayTag_method {
            static internal IntPtr NotEqual_GameplayTag_ptr;
            static NotEqual_GameplayTag_method() {
                NotEqual_GameplayTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "NotEqual_GameplayTag");
            }

            internal static unsafe bool Invoke(GameplayTag A, GameplayTag B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = A;
                *((GameplayTag*)(b+12)) = B;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, NotEqual_GameplayTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct NotEqual_GameplayTagContainer_method {
            static internal IntPtr NotEqual_GameplayTagContainer_ptr;
            static NotEqual_GameplayTagContainer_method() {
                NotEqual_GameplayTagContainer_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "NotEqual_GameplayTagContainer");
            }

            internal static unsafe bool Invoke(GameplayTagContainer A, GameplayTagContainer B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = A;
                *((GameplayTagContainer*)(b+32)) = B;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, NotEqual_GameplayTagContainer_ptr, new IntPtr(p)); ;
                return *((bool*)(b+64));
            }
        }
        internal struct NotEqual_TagContainerTagContainer_method {
            static internal IntPtr NotEqual_TagContainerTagContainer_ptr;
            static NotEqual_TagContainerTagContainer_method() {
                NotEqual_TagContainerTagContainer_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "NotEqual_TagContainerTagContainer");
            }

            internal static unsafe bool Invoke(GameplayTagContainer A, string B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = A;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = B.Length;
                *(int*)(b+IntPtr.Size+4+32) = B.Length;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, NotEqual_TagContainerTagContainer_ptr, new IntPtr(p)); ;
                B_handle.Free();
                return *((bool*)(b+48));
            }
        }
        internal struct NotEqual_TagTag_method {
            static internal IntPtr NotEqual_TagTag_ptr;
            static NotEqual_TagTag_method() {
                NotEqual_TagTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "NotEqual_TagTag");
            }

            internal static unsafe bool Invoke(GameplayTag A, string B) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = A;
                var B_handle = GCHandle.Alloc(B, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = B_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = B.Length;
                *(int*)(b+IntPtr.Size+4+16) = B.Length;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, NotEqual_TagTag_ptr, new IntPtr(p)); ;
                B_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct RemoveGameplayTag_method {
            static internal IntPtr RemoveGameplayTag_ptr;
            static RemoveGameplayTag_method() {
                RemoveGameplayTag_ptr = Main.GetMethodUFunction(BlueprintGameplayTagLibrary.StaticClass, "RemoveGameplayTag");
            }

            internal static unsafe bool Invoke(GameplayTagContainer TagContainer, GameplayTag Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                *((GameplayTag*)(b+32)) = Tag;
                Main.GetProcessEvent(BlueprintGameplayTagLibrary.DefaultObject, RemoveGameplayTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+44));
            }
        }
    }
    internal unsafe struct BlueprintGameplayTagLibrary_events {
    }
}
