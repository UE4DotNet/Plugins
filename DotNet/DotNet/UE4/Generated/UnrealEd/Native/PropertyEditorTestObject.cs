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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=3024 )]
    internal unsafe struct PropertyEditorTestObject_fields {
        [FieldOffset(56)] public sbyte Int8Property;
        [FieldOffset(58)] public short Int16roperty;
        [FieldOffset(60)] public int Int32Property;
        [FieldOffset(64)] public long Int64Property;
        [FieldOffset(72)] public byte ByteProperty;
        [FieldOffset(74)] byte UnsignedInt16Property; //TODO: numeric uint16 UnsignedInt16Property
        [FieldOffset(76)] byte UnsignedInt32Property; //TODO: numeric uint32 UnsignedInt32Property
        [FieldOffset(80)] byte UnsignedInt64Property; //TODO: numeric uint64 UnsignedInt64Property
        [FieldOffset(88)] public float FloatProperty;
        [FieldOffset(96)] public double DoubleProperty;
        [FieldOffset(104)] public Name NameProperty;
        [FieldOffset(116)] public bool BoolProperty;
        [FieldOffset(120)] byte StringProperty; //TODO: string FString StringProperty
        [FieldOffset(136)] byte TextProperty; //TODO: text FText TextProperty
        [FieldOffset(160)] public IntPoint IntPointProperty;
        [FieldOffset(168)] public Vector Vector3Property;
        [FieldOffset(180)] public Vector2D Vector2Property;
        [FieldOffset(192)] public Vector4 Vector4Property;
        [FieldOffset(208)] public Rotator RotatorProperty;
        [FieldOffset(224)]  public IntPtr  ObjectProperty;
        [FieldOffset(232)] public IntPtr ClassProperty;
        [FieldOffset(240)] public LinearColor LinearColorProperty;
        [FieldOffset(256)] public Color ColorProperty;
        [FieldOffset(260)] public byte EnumProperty;
        [FieldOffset(272)] public Matrix MatrixProperty;
        [FieldOffset(336)] public Transform TransformProperty;
        [FieldOffset(384)] public NativeArray IntProperty32Array;
        [FieldOffset(400)] public NativeArray BytePropertyArray;
        [FieldOffset(416)] public NativeArray FloatPropertyArray;
        [FieldOffset(432)] public NativeArray NamePropertyArray;
        [FieldOffset(448)] public NativeArray BoolPropertyArray;
        [FieldOffset(464)] public NativeArray StringPropertyArray;
        [FieldOffset(480)] public NativeArray TextPropertyArray;
        [FieldOffset(496)] public NativeArray Vector3PropertyArray;
        [FieldOffset(512)] public NativeArray Vector2PropertyArray;
        [FieldOffset(528)] public NativeArray Vector4PropertyArray;
        [FieldOffset(544)] public NativeArray RotatorPropertyArray;
        [FieldOffset(560)] public NativeArray ObjectPropertyArray;
        [FieldOffset(576)] public NativeArray ActorPropertyArray;
        [FieldOffset(592)] public NativeArray LinearColorPropertyArray;
        [FieldOffset(608)] public NativeArray ColorPropertyArray;
        [FieldOffset(624)] public NativeArray EnumPropertyArray;
        [FieldOffset(640)] public NativeArray StructPropertyArray;
        [FieldOffset(656)] public NativeArray FixedArrayOfInts;
        [FieldOffset(672)] public int StaticArrayOfInts;
        [FieldOffset(692)] public int StaticArrayOfIntsWithEnumLabels;
        [FieldOffset(716)] public float FloatPropertyWithClampedRange;
        [FieldOffset(720)] public int IntPropertyWithClampedRange;
        [FieldOffset(724)] public int IntThatCannotBeChanged;
        [FieldOffset(728)] byte StringThatCannotBeChanged; //TODO: string FString StringThatCannotBeChanged
        [FieldOffset(744)]  public IntPtr  ObjectThatCannotBeChanged;
        [FieldOffset(752)] byte StringPasswordProperty; //TODO: string FString StringPasswordProperty
        [FieldOffset(768)] byte TextPasswordProperty; //TODO: text FText TextPasswordProperty
        [FieldOffset(792)] public PropertyEditorTestBasicStruct ThisIsBrokenIfItsVisibleInADetailsView;
        [FieldOffset(864)] public PropertyEditorTestBasicStruct StructWithMultipleInstances1;
        [FieldOffset(936)] public bool bEditConditionStructWithMultipleInstances2;
        [FieldOffset(944)] public PropertyEditorTestBasicStruct StructWithMultipleInstances2;
        [FieldOffset(1016)] public SoftObjectPath AssetReferenceCustomStruct;
        [FieldOffset(1048)] public SoftObjectPath AssetReferenceCustomStructWithThumbnail;
        [FieldOffset(1080)] public bool bEditCondition;
        [FieldOffset(1084)] public int SimplePropertyWithEditCondition;
        [FieldOffset(1088)] public bool bEditConditionAssetReferenceCustomStructWithEditCondition;
        [FieldOffset(1096)] public SoftObjectPath AssetReferenceCustomStructWithEditCondition;
        [FieldOffset(1128)] public NativeArray ArrayOfStructs;
        [FieldOffset(1144)]  public IntPtr  EditInlineNewStaticMeshComponent;
        [FieldOffset(1152)] public NativeArray ArrayOfEditInlineNewSMCs;
        [FieldOffset(1168)]  public IntPtr  TextureProp;
        [FieldOffset(1176)]  public IntPtr  StaticMeshProp;
        [FieldOffset(1184)]  public IntPtr  AnyMaterialInterface;
        [FieldOffset(1192)]  public IntPtr  OnlyActorsAllowed;
        [FieldOffset(1200)] byte Int32Set; //TODO: set TSet Int32Set
        [FieldOffset(1280)] byte FloatSet; //TODO: set TSet FloatSet
        [FieldOffset(1360)] byte StringSet; //TODO: set TSet StringSet
        [FieldOffset(1440)] byte ObjectSet; //TODO: set TSet ObjectSet
        [FieldOffset(1520)] byte ActorSet; //TODO: set TSet ActorSet
        [FieldOffset(1600)] byte EditColorSet; //TODO: set TSet EditColorSet
        [FieldOffset(1680)] byte NameSet; //TODO: set TSet NameSet
        [FieldOffset(1760)] byte Int32ToStringMap; //TODO: map TMap Int32ToStringMap
        [FieldOffset(1840)] byte StringToColorMap; //TODO: map TMap StringToColorMap
        [FieldOffset(1920)] byte Int32ToStructMap; //TODO: map TMap Int32ToStructMap
        [FieldOffset(2000)] byte StringToFloatMap; //TODO: map TMap StringToFloatMap
        [FieldOffset(2080)] byte StringToObjectMap; //TODO: map TMap StringToObjectMap
        [FieldOffset(2160)] byte StringToActorMap; //TODO: map TMap StringToActorMap
        [FieldOffset(2240)] byte ObjectToInt32Map; //TODO: map TMap ObjectToInt32Map
        [FieldOffset(2320)] byte ObjectToColorMap; //TODO: map TMap ObjectToColorMap
        [FieldOffset(2400)] byte IntToEnumMap; //TODO: map TMap IntToEnumMap
        [FieldOffset(2480)] byte NameToNameMap; //TODO: map TMap NameToNameMap
        [FieldOffset(2560)] byte LinearColorSet; //TODO: set TSet LinearColorSet
        [FieldOffset(2640)] byte VectorSet; //TODO: set TSet VectorSet
        [FieldOffset(2720)] byte LinearColorToStringMap; //TODO: map TMap LinearColorToStringMap
        [FieldOffset(2800)] byte VectorToFloatMap; //TODO: map TMap VectorToFloatMap
        [FieldOffset(2880)] byte LinearColorToVectorMap; //TODO: map TMap LinearColorToVectorMap
        [FieldOffset(2960)] byte BlendableInterface; //TODO: interface TScriptInterface BlendableInterface
        [FieldOffset(2976)] byte AnimClassInterface; //TODO: interface TScriptInterface AnimClassInterface
        [FieldOffset(2992)] byte LightPropagationVolumeBlendable; //TODO: interface TScriptInterface LightPropagationVolumeBlendable
        [FieldOffset(3008)]  public IntPtr  TextureOrBlendableInterface;
    }
    internal unsafe struct PropertyEditorTestObject_methods {
    }
    internal unsafe struct PropertyEditorTestObject_events {
    }
}
