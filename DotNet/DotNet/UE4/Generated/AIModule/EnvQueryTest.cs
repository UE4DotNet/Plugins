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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>Env Query Test</summary>
    public unsafe partial class EnvQueryTest : EnvQueryNode  {
        ///<summary>Number of test as defined in data asset</summary>
        public unsafe int TestOrder {
            get {return EnvQueryTest_ptr->TestOrder;}
            set {EnvQueryTest_ptr->TestOrder = value;}
        }
        ///<summary>The purpose of this test.  Should it be used for filtering possible results, scoring them, or both?</summary>
        public unsafe byte TestPurpose {
            get {return EnvQueryTest_ptr->TestPurpose;}
            set {EnvQueryTest_ptr->TestPurpose = value;}
        }
         //TODO: string FString TestComment
        ///<summary>Determines filtering operator when context returns multiple items</summary>
        public unsafe byte MultipleContextFilterOp {
            get {return EnvQueryTest_ptr->MultipleContextFilterOp;}
            set {EnvQueryTest_ptr->MultipleContextFilterOp = value;}
        }
        ///<summary>Determines scoring operator when context returns multiple items</summary>
        public unsafe byte MultipleContextScoreOp {
            get {return EnvQueryTest_ptr->MultipleContextScoreOp;}
            set {EnvQueryTest_ptr->MultipleContextScoreOp = value;}
        }
        ///<summary>Does this test filter out results that are below a lower limit, above an upper limit, or both?  Or does it just look for a matching value?</summary>
        public unsafe byte FilterType {
            get {return EnvQueryTest_ptr->FilterType;}
            set {EnvQueryTest_ptr->FilterType = value;}
        }
        ///<summary>Desired boolean value of the test for scoring to occur or filtering test to pass.</summary>
        public unsafe AIDataProviderBoolValue BoolValue {
            get {return EnvQueryTest_ptr->BoolValue;}
            set {EnvQueryTest_ptr->BoolValue = value;}
        }
        ///<summary>Minimum limit (inclusive) of valid values for the raw test value. Lower values will be discarded as invalid.</summary>
        public unsafe AIDataProviderFloatValue FloatValueMin {
            get {return EnvQueryTest_ptr->FloatValueMin;}
            set {EnvQueryTest_ptr->FloatValueMin = value;}
        }
        ///<summary>Maximum limit (inclusive) of valid values for the raw test value. Higher values will be discarded as invalid.</summary>
        public unsafe AIDataProviderFloatValue FloatValueMax {
            get {return EnvQueryTest_ptr->FloatValueMax;}
            set {EnvQueryTest_ptr->FloatValueMax = value;}
        }
        ///<summary>The shape of the curve equation to apply to the normalized score before multiplying by factor.</summary>
        public unsafe byte ScoringEquation {
            get {return EnvQueryTest_ptr->ScoringEquation;}
            set {EnvQueryTest_ptr->ScoringEquation = value;}
        }
        ///<summary>How should the lower bound for normalization of the raw test value before applying the scoring formula be determined?</summary>
        ///<remarks>Should it use the lowest value found (tested), the lower threshold for filtering, or a separate specified normalization minimum?</remarks>
        public unsafe byte ClampMinType {
            get {return EnvQueryTest_ptr->ClampMinType;}
            set {EnvQueryTest_ptr->ClampMinType = value;}
        }
        ///<summary>How should the upper bound for normalization of the raw test value before applying the scoring formula be determined?</summary>
        ///<remarks>Should it use the highest value found (tested), the upper threshold for filtering, or a separate specified normalization maximum?</remarks>
        public unsafe byte ClampMaxType {
            get {return EnvQueryTest_ptr->ClampMaxType;}
            set {EnvQueryTest_ptr->ClampMaxType = value;}
        }
         //TODO: enum EEQSNormalizationType NormalizationType
        ///<summary>Minimum value to use to normalize the raw test value before applying scoring formula.</summary>
        public unsafe AIDataProviderFloatValue ScoreClampMin {
            get {return EnvQueryTest_ptr->ScoreClampMin;}
            set {EnvQueryTest_ptr->ScoreClampMin = value;}
        }
        ///<summary>Maximum value to use to normalize the raw test value before applying scoring formula.</summary>
        public unsafe AIDataProviderFloatValue ScoreClampMax {
            get {return EnvQueryTest_ptr->ScoreClampMax;}
            set {EnvQueryTest_ptr->ScoreClampMax = value;}
        }
        ///<summary>The weight (factor) by which to multiply the normalized score after the scoring equation is applied.</summary>
        public unsafe AIDataProviderFloatValue ScoringFactor {
            get {return EnvQueryTest_ptr->ScoringFactor;}
            set {EnvQueryTest_ptr->ScoringFactor = value;}
        }
        ///<summary>
        ///When specified gets used to normalize test's results in such a way that the closer a value is to ReferenceValue
        ///    the higher normalized result it will produce.
        ///</summary>
        ///<remarks>
        ///Value farthest from ReferenceValue will be normalized
        ///    to 0, and all the other values in between will get normalized linearly with the distance to ReferenceValue.
        ///</remarks>
        public unsafe AIDataProviderFloatValue ReferenceValue {
            get {return EnvQueryTest_ptr->ReferenceValue;}
            set {EnvQueryTest_ptr->ReferenceValue = value;}
        }
        public bool bDefineReferenceValue {
            get {return Main.GetGetBoolPropertyByName(this, "bDefineReferenceValue"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefineReferenceValue", value); }
        }
        public bool bWorkOnFloatValues {
            get {return Main.GetGetBoolPropertyByName(this, "bWorkOnFloatValues"); }
            set {Main.SetGetBoolPropertyByName(this, "bWorkOnFloatValues", value); }
        }
        static EnvQueryTest() {
            StaticClass = Main.GetClass("EnvQueryTest");
        }
        internal unsafe EnvQueryTest_fields* EnvQueryTest_ptr => (EnvQueryTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest(IntPtr p) => UObject.Make<EnvQueryTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
