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


namespace UE4.AIModule{
        ///<summary>EQSParametrized Query Execution Request</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct EQSParametrizedQueryExecutionRequest {
            [FieldOffset(0)] 
            private IntPtr  QueryTemplate_field;
            ///<summary>Query Template</summary>
            public EnvQuery QueryTemplate {
                get {return QueryTemplate_field;}
                set {QueryTemplate_field = value;}
            }

            [FieldOffset(8)] byte QueryConfig; //TODO: array TArray QueryConfig

            ///<summary>blackboard key storing an EQS query template</summary>
            [FieldOffset(24)] BlackboardKeySelector EQSQueryBlackboardKey;

            [FieldOffset(72)] public byte RunMode;

            [FieldOffset(76)] public bool bUseBBKeyForQueryTemplate;

        }
}
