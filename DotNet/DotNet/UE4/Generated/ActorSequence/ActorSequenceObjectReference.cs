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


namespace UE4.ActorSequence{
        ///<summary>An external reference to an level sequence object, resolvable through an arbitrary context.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct ActorSequenceObjectReference {
            [FieldOffset(0)] byte Type; //TODO: enum EActorSequenceObjectReferenceType Type

            ///<summary>The ID of the actor - if this is set, we're either the owner actor, or an object outside of the context</summary>
            [FieldOffset(4)] FGuid ActorId;

            [FieldOffset(24)] byte PathToComponent; //TODO: string FString PathToComponent

        }
}
