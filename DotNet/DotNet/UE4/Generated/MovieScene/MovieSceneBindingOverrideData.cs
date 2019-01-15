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


namespace UE4.MovieScene{
        ///<summary>Movie scene binding override data</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct MovieSceneBindingOverrideData {
            ///<summary>Specifies the object binding to override.</summary>
            [FieldOffset(0)] MovieSceneObjectBindingID ObjectBindingId;

            [FieldOffset(24)] byte UObject; //TODO: weak object TWeakObjectPtr<UObject> UObject

            [FieldOffset(32)] public bool bOverridesDefault;

        }
}
