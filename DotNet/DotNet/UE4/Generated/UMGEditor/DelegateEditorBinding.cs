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


namespace UE4.UMGEditor{
        ///<summary>Delegate Editor Binding</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct DelegateEditorBinding {
            [FieldOffset(0)] byte ObjectName; //TODO: string FString ObjectName

            [FieldOffset(16)] public Name PropertyName;

            [FieldOffset(28)] public Name FunctionName;

            [FieldOffset(40)] public Name SourceProperty;

            ///<summary>Source Path</summary>
            [FieldOffset(56)] EditorPropertyPath SourcePath;

            ///<summary>If it's an actual Function Graph in the blueprint that we're bound to, there's a GUID we can use to lookup that function, to deal with renames better.  This is that GUID.</summary>
            [FieldOffset(72)] FGuid MemberGuid;

            [FieldOffset(88)] byte Kind; //TODO: enum EBindingKind Kind

        }
}
