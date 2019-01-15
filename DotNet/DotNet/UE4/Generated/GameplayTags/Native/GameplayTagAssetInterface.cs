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


namespace UE4.GameplayTags.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct GameplayTagAssetInterface_fields {
    }
    internal unsafe struct GameplayTagAssetInterface_methods {
        internal struct GetOwnedGameplayTags_method {
            static internal IntPtr GetOwnedGameplayTags_ptr;
            static GetOwnedGameplayTags_method() {
                GetOwnedGameplayTags_ptr = Main.GetMethodUFunction(GameplayTagAssetInterface.StaticClass, "GetOwnedGameplayTags");
            }

            internal static unsafe GameplayTagContainer Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwnedGameplayTags_ptr, new IntPtr(p)); ;
                return *((GameplayTagContainer*)(b+0));
            }
        }
        internal struct HasAllMatchingGameplayTags_method {
            static internal IntPtr HasAllMatchingGameplayTags_ptr;
            static HasAllMatchingGameplayTags_method() {
                HasAllMatchingGameplayTags_ptr = Main.GetMethodUFunction(GameplayTagAssetInterface.StaticClass, "HasAllMatchingGameplayTags");
            }

            internal static unsafe bool Invoke(IntPtr obj, GameplayTagContainer TagContainer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                Main.GetProcessEvent(obj, HasAllMatchingGameplayTags_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct HasAnyMatchingGameplayTags_method {
            static internal IntPtr HasAnyMatchingGameplayTags_ptr;
            static HasAnyMatchingGameplayTags_method() {
                HasAnyMatchingGameplayTags_ptr = Main.GetMethodUFunction(GameplayTagAssetInterface.StaticClass, "HasAnyMatchingGameplayTags");
            }

            internal static unsafe bool Invoke(IntPtr obj, GameplayTagContainer TagContainer) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTagContainer*)(b+0)) = TagContainer;
                Main.GetProcessEvent(obj, HasAnyMatchingGameplayTags_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct HasMatchingGameplayTag_method {
            static internal IntPtr HasMatchingGameplayTag_ptr;
            static HasMatchingGameplayTag_method() {
                HasMatchingGameplayTag_ptr = Main.GetMethodUFunction(GameplayTagAssetInterface.StaticClass, "HasMatchingGameplayTag");
            }

            internal static unsafe bool Invoke(IntPtr obj, GameplayTag TagToCheck) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((GameplayTag*)(b+0)) = TagToCheck;
                Main.GetProcessEvent(obj, HasMatchingGameplayTag_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
    }
    internal unsafe struct GameplayTagAssetInterface_events {
    }
}
