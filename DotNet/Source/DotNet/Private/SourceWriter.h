#pragma once

#if WITH_EDITOR
#include "CoreMinimal.h"
#include "Class.h"
#include "BigInt.h"
#include "Archive.h"
#include "FileManager.h"
#include "PlatformFilemanager.h"
#include "FileHelper.h"
#include "GameFramework/InputSettings.h"
#include "Set.h"
#include "Stack.h"
#include <fstream>
#include <iostream>
#include <string>

//TODO: c++ bit flags to bools (and back). UBoolProperty::GetPropertyValue()
//TODO: Add interface to FMemory to allow freeing of TArray and FString (memory leak).
//TODO: Add interface to TWeakObjectPtr
//TODO: TArray copy to List.
//TODO: TArray/TSet/TMap allocate local data for call.
//TODO: Deprecated functions/properties need to be removed :(
//TODO: Remove IsVisible because its not used.

TWeakObjectPtr<UObject> x;
namespace SourceWriter {
	FString int32_type("int32");
	FString int_type("int");
	FString float_type("float");
	FString double_type("double");
	FString byte_type("byte");
	FString bool_type("bool");
	FString S4("    ");

	TSet<FString> UsingModules;
	FString CurrentModule;

	struct WriteState {
	private:
		FString contents;
		UField* field;
		FString tab;
	public:

		WriteState Indent() const { return WriteState(contents, field, tab + S4); }
		WriteState Dedent() const { return WriteState(contents, field, tab.Mid(4)); }

		WriteState Add(TCHAR c) const { return WriteState(contents + c, field, tab); }
		WriteState Add(const FString& s) const { return WriteState(contents + s, field, tab); }
		WriteState Add(const char* s) const { return WriteState(contents + s, field, tab); }

		bool HasField() const { return field != nullptr; }
		UField* GetField() const { return field; }

		UClass* GetClass() const { return Cast<UClass>(field); }
		UEnum* GetEnum() const { return Cast<UEnum>(field); }
		UFunction* GetFunction() const { return Cast<UFunction>(field); }
		UProperty* GetProperty() const { return Cast<UProperty>(field); }
		UStruct* GetStruct() const { return  Cast<UStruct>(field); }
		
		UByteProperty* GetByteProperty() const { return Cast<UByteProperty>(field); }
		UClassProperty* GetClassProperty() const { return Cast<UClassProperty>(field); }
		UEnumProperty* GetEnumProperty() const { return Cast<UEnumProperty>(field); }
		UObjectProperty* GetOjectProperty() const { return Cast<UObjectProperty>(field); }
		UStructProperty* GetStructProperty() const { return Cast<UStructProperty>(field); }
		UArrayProperty* GetArrayProperty() const { return Cast<UArrayProperty>(field); }
		UInterfaceProperty* GetInterfaceProperty() const { return Cast<UInterfaceProperty>(field);  }
		UBoolProperty* GetBoolProperty() const { return Cast<UBoolProperty>(field); }

		FString StructSize() const {
			return IsStruct()
				? FString::FromInt(GetStruct()->GetStructureSize())
				: FString::FromInt(-1);
		}

		FString StructSizeLong() const {
			auto ss = GetStruct()->GetStructureSize() + 7;
			ss /= 8;
			return IsStruct()
				? FString::FromInt(ss)
				: FString::FromInt(-1);
		}

		int StructSizeLongCount() const{
			auto ss = GetStruct()->GetStructureSize() + 7;
			ss /= 8;
			return ss;
		}

		bool IsCallableFunction() const {
			if (IsFunction()) {
				auto flags = GetFunction()->FunctionFlags;
				bool isDelOrEvent = (flags & (FUNC_MulticastDelegate | FUNC_Delegate | FUNC_BlueprintEvent)) != 0;
				bool isCallable = (flags & FUNC_BlueprintCallable) != 0;
				return (isCallable && !isDelOrEvent);
			}
			return false;
		}

		bool IsBlueprintEvent() const {
			if (IsFunction()) {
				auto flags = GetFunction()->FunctionFlags;
				bool isEvent = GetFunction()->HasAnyFunctionFlags(EFunctionFlags::FUNC_BlueprintEvent);
				bool isNative = GetFunction()->HasAnyFunctionFlags(EFunctionFlags::FUNC_Native);
				return isEvent && !isNative;
			}
			return false;
		}

		bool IsNativeBlueprintEvent() const {
			if (IsFunction()) {
				auto flags = GetFunction()->FunctionFlags;
				bool isEvent = GetFunction()->HasAnyFunctionFlags(EFunctionFlags::FUNC_BlueprintEvent);
				bool isNative = GetFunction()->HasAnyFunctionFlags(EFunctionFlags::FUNC_Native);
				return isEvent && isNative;
			}
			return false;
		}

		bool IsStatic() const {
			auto flags = GetFunction()->FunctionFlags;
			return IsFunction() ?
				(flags & FUNC_Static) != 0
				: false;
		}

		bool HasOutParameters() const {
			auto outParams = ReturnType();
			return outParams.Num() > 0;
		}

		bool HasOutOrRefParameters() const {
			return ReturnType(true).Num() > 0;
		}

		bool HasInParameters() const {
			return InParameters().Num() > 0;
		}

		bool HasArrayParameter() const {
			if (IsFunction()) {
				auto func = GetFunction();
				for (auto pIt = TFieldIterator<UProperty>(func); pIt; ++pIt) {
					if ((*pIt)->IsA<UArrayProperty>())
						return true;
				}
			}
			return false;
		}

		bool IsDeprecated() const {
			return IsProperty() ?
				(GetProperty()->GetPropertyFlags() & CPF_Deprecated) != 0
				: false;
		}

		bool IsVisible() const {
			return IsProperty() ?
				(GetProperty()->GetPropertyFlags() & CPF_BlueprintVisible) != 0
				: false;
		}

		bool IsReadonly() const {
			return IsProperty() ?
				(GetProperty()->GetPropertyFlags() & CPF_BlueprintReadOnly) != 0
				: false;
		}

		bool IsOutParameter() const {
			return IsProperty() ?
				GetProperty()->HasAllPropertyFlags(CPF_OutParm)
				: false;
		}

		bool IsReturnParameter() const {
			return IsProperty() ?
				GetProperty()->HasAllPropertyFlags(CPF_ReturnParm)
				: false;
		}

		bool IsConstParameter() const {
			return IsProperty() ?
				GetProperty()->HasAllPropertyFlags(CPF_ConstParm)
				: false;
		}

		bool IsRefParameter() const {
			return IsProperty() ?
				GetProperty()->HasAllPropertyFlags(CPF_ReferenceParm)
				: false;
		}

		bool IsInParameter() const {
			return IsProperty() ?
				GetProperty()->HasAllPropertyFlags(CPF_ReferenceParm /*| CPF_ConstParm*/) ||
				!GetProperty()->HasAnyPropertyFlags(CPF_OutParm | CPF_ReturnParm)
				: false;
		}

		int ParameterCount() const {
			return IsFunction() ?
				GetFunction()->NumParms
				: 0;
		}

		template <typename T>
		bool IsA() const { return HasField() && field->IsA<T>(); }

		bool IsEnum() const { return IsA<UEnum>(); }
		bool IsProperty() const { return IsA<UProperty>(); }
		bool IsStruct() const { return IsA<UStruct>(); }
		bool IsClass() const { return IsA<UClass>(); }
		bool IsFunction() const { return IsA<UFunction>(); }
		bool IsEnumByteProperty() const { return IsA<UByteProperty>() && GetByteProperty()->Enum != nullptr; }
		bool IsEnumProperty() const { return IsA<UEnumProperty>() || IsEnumByteProperty(); }
		bool IsObjectProperty() const { return IsA<UObjectProperty>(); }
		bool IsStructProperty() const { return IsA<UStructProperty>(); }
		bool IsClassProperty() const { return IsA<UClassProperty>(); }
		bool IsArrayProperty() const { return IsA<UArrayProperty>(); }
		bool IsInterfaceProperty() const { return IsA<UInterfaceProperty>(); }
		bool IsBooleanProperty() const { return IsA<UBoolProperty>(); }

		FString EnumValueName(int i)const {
			return GetEnum()->GetNameStringByIndex(i);
		}

		FString EnumValue(int i) const {
			TBigInt<64> value(GetEnum()->GetValueByIndex(i));
			return value.ToString();
		}

		int EnumCount() const {
			return GetEnum()->NumEnums();
		}

		FString ArrayType()const {
			FString name("Unknown");
			if (IsArrayProperty()) {
				auto a = GetArrayProperty();
				auto inner = a->Inner;
				if (inner->IsA<UObjectProperty>()) {

				}
				else {
					auto x = 3;
				}
				
			}
			return name;
		}

		TTuple<FString,FString> SuperClass() const {
			FString superClass;
			FString superClassModule;
			if (IsClass() && GetClass()->GetSuperClass() != nullptr) {
				WriteState s(GetClass()->GetSuperClass(), "");
				superClass = s.Name();
				superClassModule = s.ModuleName();
			}
			return TTuple<FString,FString>(superClass,superClassModule);
		}

		FString CppType() const {
			return IsProperty() ? GetProperty()->GetCPPType() : "Unknown";
		}

		FString CSharpType() const {
			auto type = CppType();
			if (type == float_type || type == double_type || type == byte_type || type == bool_type)
				return type;
			if (type == int32_type)
				return int_type;
			return "unknown";
		}

		FString FieldOffset() const{
			int offset = -9999;
			if (IsProperty())
				offset = GetProperty()->GetOffset_ForInternal();
			return FString::FromInt(offset);
		}

		FString Doc() const {
			return field->GetToolTipText().ToString();
		}

		static FString ModuleName(UField* field) {
			return FPackageName::GetShortFName(field->GetOutermost()->GetFName()).ToString();
		}

		FString ModuleName() const {
			return FPackageName::GetShortFName(field->GetOutermost()->GetFName()).ToString();
		}

		const FString& Contents()  const {
			return contents;
		}

		const FString& Tab() const {
			return tab;
		}

		static FString Comma(const FString& f, const char* text) {
			return f + (f.Len() > 0 ? ", " : "") + text;
		}

		FString CPFFlagsText() const {
			FString flagsSet;
			if (IsProperty()) {
				if (GetProperty()->HasAllPropertyFlags(CPF_Edit))
					flagsSet = Comma(flagsSet, "CPF_Edit");
				if (GetProperty()->HasAllPropertyFlags(CPF_ConstParm))
					flagsSet = Comma(flagsSet, "CPF_ConstParm");
				if (GetProperty()->HasAllPropertyFlags(CPF_BlueprintVisible))
					flagsSet = Comma(flagsSet, "CPF_BlueprintVisible");
				if (GetProperty()->HasAllPropertyFlags(CPF_ExportObject))
					flagsSet = Comma(flagsSet, "CPF_ExportObject");
				if (GetProperty()->HasAllPropertyFlags(CPF_BlueprintReadOnly))
					flagsSet = Comma(flagsSet, "CPF_BlueprintReadOnly");
				if (GetProperty()->HasAllPropertyFlags(CPF_Net))
					flagsSet = Comma(flagsSet, "CPF_Net");
				if (GetProperty()->HasAllPropertyFlags(CPF_EditFixedSize))
					flagsSet = Comma(flagsSet, "CPF_EditFixedSize");
				if (GetProperty()->HasAllPropertyFlags(CPF_Parm))
					flagsSet = Comma(flagsSet, "CPF_Parm");
				if (GetProperty()->HasAllPropertyFlags(CPF_OutParm))
					flagsSet = Comma(flagsSet, "CPF_OutParm");
				if (GetProperty()->HasAllPropertyFlags(CPF_ZeroConstructor))
					flagsSet = Comma(flagsSet, "CPF_ZeroConstructor");
				if (GetProperty()->HasAllPropertyFlags(CPF_ReturnParm))
					flagsSet = Comma(flagsSet, "CPF_ReturnParm");
				if (GetProperty()->HasAllPropertyFlags(CPF_DisableEditOnTemplate))
					flagsSet = Comma(flagsSet, "CPF_DisableEditOnTemplate");
				if (GetProperty()->HasAllPropertyFlags(CPF_Transient))
					flagsSet = Comma(flagsSet, "CPF_Transient");
				if (GetProperty()->HasAllPropertyFlags(CPF_Config))
					flagsSet = Comma(flagsSet, "CPF_Config");
				if (GetProperty()->HasAllPropertyFlags(CPF_DisableEditOnInstance))
					flagsSet = Comma(flagsSet, "CPF_DisableEditOnInstance");
				if (GetProperty()->HasAllPropertyFlags(CPF_EditConst))
					flagsSet = Comma(flagsSet, "CPF_EditConst");
				if (GetProperty()->HasAllPropertyFlags(CPF_GlobalConfig))
					flagsSet = Comma(flagsSet, "CPF_GlobalConfig");
				if (GetProperty()->HasAllPropertyFlags(CPF_InstancedReference))
					flagsSet = Comma(flagsSet, "CPF_InstancedReference");
				if (GetProperty()->HasAllPropertyFlags(CPF_DuplicateTransient))
					flagsSet = Comma(flagsSet, "CPF_DuplicateTransient");
				if (GetProperty()->HasAllPropertyFlags(CPF_SubobjectReference))
					flagsSet = Comma(flagsSet, "CPF_SubobjectReference");
				if (GetProperty()->HasAllPropertyFlags(CPF_SaveGame))
					flagsSet = Comma(flagsSet, "CPF_SaveGame");
				if (GetProperty()->HasAllPropertyFlags(CPF_NoClear))
					flagsSet = Comma(flagsSet, "CPF_NoClear");
				if (GetProperty()->HasAllPropertyFlags(CPF_ReferenceParm))
					flagsSet = Comma(flagsSet, "CPF_ReferenceParm");
				if (GetProperty()->HasAllPropertyFlags(CPF_BlueprintAssignable))
					flagsSet = Comma(flagsSet, "CPF_BlueprintAssignable");
				if (GetProperty()->HasAllPropertyFlags(CPF_Deprecated))
					flagsSet = Comma(flagsSet, "CPF_Deprecated");
				if (GetProperty()->HasAllPropertyFlags(CPF_IsPlainOldData))
					flagsSet = Comma(flagsSet, "CPF_IsPlainOldData");
				if (GetProperty()->HasAllPropertyFlags(CPF_RepSkip))
					flagsSet = Comma(flagsSet, "CPF_RepSkip");
				if (GetProperty()->HasAllPropertyFlags(CPF_RepNotify))
					flagsSet = Comma(flagsSet, "CPF_RepNotify");
				if (GetProperty()->HasAllPropertyFlags(CPF_Interp))
					flagsSet = Comma(flagsSet, "CPF_Interp");
				if (GetProperty()->HasAllPropertyFlags(CPF_NonTransactional))
					flagsSet = Comma(flagsSet, "CPF_NonTransactional");
				if (GetProperty()->HasAllPropertyFlags(CPF_EditorOnly))
					flagsSet = Comma(flagsSet, "CPF_EditorOnly");
				if (GetProperty()->HasAllPropertyFlags(CPF_NoDestructor))
					flagsSet = Comma(flagsSet, "CPF_NoDestructor");
				if (GetProperty()->HasAllPropertyFlags(CPF_AutoWeak))
					flagsSet = Comma(flagsSet, "CPF_AutoWeak");
				if (GetProperty()->HasAllPropertyFlags(CPF_ContainsInstancedReference))
					flagsSet = Comma(flagsSet, "CPF_ContainsInstancedReference");
				if (GetProperty()->HasAllPropertyFlags(CPF_AssetRegistrySearchable))
					flagsSet = Comma(flagsSet, "CPF_AssetRegistrySearchable");
				if (GetProperty()->HasAllPropertyFlags(CPF_SimpleDisplay))
					flagsSet = Comma(flagsSet, "CPF_SimpleDisplay");
				if (GetProperty()->HasAllPropertyFlags(CPF_AdvancedDisplay))
					flagsSet = Comma(flagsSet, "CPF_AdvancedDisplay");
				if (GetProperty()->HasAllPropertyFlags(CPF_Protected))
					flagsSet = Comma(flagsSet, "CPF_Protected");
				if (GetProperty()->HasAllPropertyFlags(CPF_BlueprintCallable))
					flagsSet = Comma(flagsSet, "CPF_BlueprintCallable");
				if (GetProperty()->HasAllPropertyFlags(CPF_BlueprintAuthorityOnly))
					flagsSet = Comma(flagsSet, "CPF_BlueprintAuthorityOnly");
				if (GetProperty()->HasAllPropertyFlags(CPF_TextExportTransient))
					flagsSet = Comma(flagsSet, "CPF_TextExportTransient");
				if (GetProperty()->HasAllPropertyFlags(CPF_NonPIEDuplicateTransient))
					flagsSet = Comma(flagsSet, "CPF_NonPIEDuplicateTransient");
				if (GetProperty()->HasAllPropertyFlags(CPF_ExposeOnSpawn))
					flagsSet = Comma(flagsSet, "CPF_ExposeOnSpawn");
				if (GetProperty()->HasAllPropertyFlags(CPF_PersistentInstance))
					flagsSet = Comma(flagsSet, "CPF_PersistentInstance");
				if (GetProperty()->HasAllPropertyFlags(CPF_UObjectWrapper))
					flagsSet = Comma(flagsSet, "CPF_UObjectWrapper");
				if (GetProperty()->HasAllPropertyFlags(CPF_HasGetValueTypeHash))
					flagsSet = Comma(flagsSet, "CPF_HasGetValueTypeHash");
				if (GetProperty()->HasAllPropertyFlags(CPF_NativeAccessSpecifierPublic))
					flagsSet = Comma(flagsSet, "CPF_NativeAccessSpecifierPublic");
				if (GetProperty()->HasAllPropertyFlags(CPF_NativeAccessSpecifierProtected))
					flagsSet = Comma(flagsSet, "CPF_NativeAccessSpecifierProtected");
				if (GetProperty()->HasAllPropertyFlags(CPF_NativeAccessSpecifierPrivate))
					flagsSet = Comma(flagsSet, "CPF_NativeAccessSpecifierPrivate");
				if (GetProperty()->HasAllPropertyFlags(CPF_SkipSerialization))
					flagsSet = Comma(flagsSet, "CPF_SkipSerialization");
			}
			return flagsSet;
		}


		TArray<UProperty*> InParameters() const {
			TArray<UProperty*> types;
			if (IsFunction()) {
				auto outParams = ReturnType();
				auto func = GetFunction();
				for (auto pIt = TFieldIterator<UProperty>(func); pIt; ++pIt) {
					auto* prop = *pIt;
					for (auto p : outParams)
						if (p == prop) {
							prop = nullptr;
							break;
						}
					if (prop)
						types.Add(prop);
				}
			}
			return types;
		}

		TArray<UProperty*> ReturnType(bool includeReference = false) const {
			TArray<UProperty*> types;
			if (IsFunction()) {
				auto func = GetFunction();
				for (auto pIt = TFieldIterator<UProperty>(func); pIt; ++pIt) {
					auto* prop = *pIt;
					if (prop->HasAnyPropertyFlags(CPF_ReturnParm | CPF_OutParm) &&
						(includeReference || !prop->HasAllPropertyFlags(CPF_ReferenceParm)))
						types.Add(prop);
				}
			}
			return types;
		}

		FString ClassName() const {
			auto prop = GetProperty();
			auto s = GetProperty()->GetOwnerStruct();
			auto n = s->GetName();
			return FixName(n, false);
		}

		FString MethodClassName(bool fixName = true) const {
			FString name("unknown");
			if (IsFunction()) {
				auto func = GetFunction();
				auto c = func->GetOuterUClass();
				name = c->GetName();
				if (fixName)
					name = FixName(name);
			}
			return name;
		}

		void AddToUsing() const {
			if (IsObjectProperty()) {
				auto objProp = GetOjectProperty();
				auto c = objProp->PropertyClass;
				WriteState st(c, "");
				auto mod = st.ModuleName();
				UsingModules.Add(mod);
			}
		}

		void AddToUsing(UField* field) const {
			auto moduleName = ModuleName(field);
			UsingModules.Add(moduleName);
		}

		FString PropertyEnumType() const{
			FString name("Uknown");
			if (IsEnumProperty()) {
				UEnum* e;
				if (IsA<UEnumProperty>()) 
					e = GetEnumProperty()->GetEnum();
				else
					e = GetByteProperty()->Enum;
				UsingModules.Add(ModuleName(e));
				name = e->GetName();
				
				if (name[0] == 'E' && FChar::IsUpper(name[1]))
					name = name = FixEnum(name);
			}
			return name;
		}

		FString PropertyObjectType() const {
			FString name("Unknown");
			if (IsObjectProperty()) {
				auto objProp = GetOjectProperty();

				WriteState st(objProp->PropertyClass, "");
				UsingModules.Add(st.ModuleName());

				name = objProp->PropertyClass->GetName();
				if (name == "EditableMesh")
					name = "UE4.EditableMesh.EditableMesh";
				else
					name = FixName(name, false);
				AddToUsing();
			}
			return name;
		}

		FString PropertyClassType() const {
			FString name("Unknown");
			if (IsClassProperty()) {
				auto classProp = GetClassProperty();
				auto metaClass = classProp->MetaClass;
				auto cppClass = CppType();
				name = metaClass->GetName();
				name = FixName(name, false);
				AddToUsing(metaClass);
			}
			return name;
		}

		FString PropertyStructType() const {
			FString name("Unknown");
			if (IsStructProperty()) {
				auto structProp = GetStructProperty();

				WriteState st(structProp->Struct, "");
				UsingModules.Add(st.ModuleName());

				name = structProp->Struct->GetName();
				name = FixName(name, false);
				AddToUsing();
			}

			return name;
		}

		FString PropertyInterfaceType() const {
			FString name("Unknown");
			if (IsInterfaceProperty()) {
				auto interfaceProp = GetInterfaceProperty();

				WriteState st(interfaceProp->InterfaceClass, "");
				UsingModules.Add(st.ModuleName());

				name = interfaceProp->InterfaceClass->GetName();
				name = FixName(name, false);
				AddToUsing();
			}

			return name;
		}

		static FString FixEnum(const FString& name) {
			return name;
			//return (name == "EAxis" || name == "EAnimCurveType" || name == "EInputEvent") ? name : name.Mid(1);
		}
		FString FixName(const FString& n, bool isProperty = true) const {
			FString name = n;
			if (IsEnum())
				return FixEnum(name);

			if (IsProperty() && name == "bOverrideWorldGravity")
				return name;
			if (name == "Object" || name == "Enum" || name == "MovieScene")
				return "U" + name;
			if (name == "Enum")
				return "UEnum";
			if (name == "DateTime")
				return "FDateTime";
			if (name == "Guid")
				return "FGuid";
			if (IsProperty() && isProperty) {
				auto prop = GetProperty();
				auto s = prop->GetOwnerStruct();
				if (s->GetName() == prop->GetName()) {
					name += "_";
				}
			}
			return name;
		}

		FString Name(bool fixName = true) const {
			if (fixName)
				return FixName(field->GetName());
			return field->GetName();
		}

		void CreatePathTo(FString path) const {
			IPlatformFile& PlatformFile = FPlatformFileManager::Get().GetPlatformFile();
			if (!PlatformFile.DirectoryExists(*path)) {
				auto path2 = FPaths::GetPath(path);
				CreatePathTo(*path2);
				auto r = CreateDirectory(*path, nullptr);
				auto x = 3;
			}
		}

		void  WriteToFile(const FString& FileName) const {
			auto path = FPaths::GetPath(FileName);
			CreatePathTo(path);

			std::wofstream o(*FileName);

			if (!FileName.EndsWith("KismetTextLibrary.cs")) 
				o << *contents;
			else {
				// KismetTextLibrary comment has a unicode 0x200e
				// character which breaks Microsoft's stdio library
				bool found = false;
				for (int i = 0; i < contents.Len(); i++) {
					auto c = contents[i];
					if (contents[i] >= 0x100) {
						FString first = contents.Mid(0, i);
						FString last = contents.Mid(i + 1);
						o << *first;
						o << *last;
						found = true;
						break;
					}
				}
				if (!found)
					o << *contents;
			}
			o.close();

		}

		WriteState() : contents(""), field(nullptr), tab("") {}
		WriteState(UField* f, const FString& tab_) : contents(""), field(f), tab(tab_) {}
		WriteState(const FString& value, UField* f, const FString& tab_) : contents(value), field(f), tab(tab_) {}
		WriteState(const WriteState& state) : contents(state.contents), field(state.field), tab(state.tab) {}
	};

	struct  WriteResult {
		bool OK;
		WriteState State;

		WriteResult(const WriteState& state) : State(state), OK(true) {}

		WriteResult(bool ok = false) : OK(ok) {}
	};

	using WriteFunction = TFunction<WriteResult(const WriteState&)>;

	auto path = FPaths::ProjectPluginsDir() / TEXT("DotNet/DotNet/UE4");

	auto ch(WriteFunction f1, WriteFunction f2) {
		auto f1_ = f1;
		auto f2_ = f2;
		return WriteFunction([=](const WriteState& state) {
			auto r = f1_(state);
			if (!r.OK) {
				auto r1 = f2_(r.State);
				return r1;
			}
			return r;
		});
	}

	auto ch(WriteFunction f1, WriteFunction f2, WriteFunction f3) {
		return ch(f1, ch(f2, f3));
	}

	auto ch(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4) {
		return ch(f1, ch(f2, f3, f4));
	}

	auto ch(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4, WriteFunction f5) {
		return ch(f1, ch(f2, f3, f4, f5));
	}

	auto ch(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4, WriteFunction f5, WriteFunction f6) {
		return ch(f1, ch(f2, f3, f4, f5, f6));
	}

	auto sq_(WriteFunction f1, WriteFunction f2) {
		auto f1_ = f1;
		auto f2_ = f2;
		return WriteFunction([=](const WriteState& state) {
			auto r = f1_(state);
			if (r.OK) {
				auto r1 = f2_(r.State);
				return r1;
			}
			return r;
		});
	}

	template <typename T1, typename T2>
	WriteFunction sq(T1 f1, T2 f2) {
		return sq_(f1, f2);
	}

	template <typename T1, typename...T2>
	WriteFunction sq(T1 f, T2... fs) {
		return sq(f, sq(fs...));
	}

	namespace unused {
		auto sq(WriteFunction f1, WriteFunction f2, WriteFunction f3) {
			return sq(f1, sq(f2, f3));
		}

		auto sq(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4) {
			return sq(f1, sq(f2, f3, f4));
		}

		auto sq(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4, WriteFunction f5) {
			return sq(f1, sq(f2, f3, f4, f5));
		}

		auto sq(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4, WriteFunction f5, WriteFunction f6) {
			return sq(f1, sq(f2, f3, f4, f5, f6));
		}

		auto sq(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4, WriteFunction f5, WriteFunction f6, WriteFunction f7) {
			return sq(f1, sq(f2, f3, f4, f5, f6, f7));
		}

		auto sq(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4, WriteFunction f5, WriteFunction f6, WriteFunction f7, WriteFunction f8) {
			return sq(f1, sq(f2, f3, f4, f5, f6, f7, f8));
		}

		auto sq(WriteFunction f1, WriteFunction f2, WriteFunction f3, WriteFunction f4, WriteFunction f5, WriteFunction f6, WriteFunction f7, WriteFunction f8, WriteFunction f9) {
			return sq(f1, sq(f2, f3, f4, f5, f6, f7, f8, f9));
		}
	}

	auto if_(WriteFunction test_function, WriteFunction if_true) {
		auto test_function_ = test_function;
		auto if_true_ = if_true;
		return WriteFunction([=](const WriteState& state) {
			auto r = test_function_(state);
			if (r.OK)
				return if_true_(state);
			return WriteResult(state);
		});
	}

	auto if_(WriteFunction test_function, WriteFunction if_true, WriteFunction if_false) {
		auto test_function_ = test_function;
		auto if_true_ = if_true;
		auto if_false_ = if_false;
		return WriteFunction([=](const WriteState& state) {
			auto r = test_function_(state);
			if (r.OK)
				return if_true_(state);
			return if_false(state);
		});
	}

	auto write(TCHAR ch) {
		return WriteFunction([=](const WriteState& state) {
			WriteState newState = state.Add(ch);
			WriteResult r(newState);
			return r;
		});
	}

	auto write(const FString& str) {
		auto str_ = str;
		return WriteFunction([=](const WriteState& state) {
			WriteState newState = state.Add(str_);
			WriteResult r(newState);
			return r;
		});
	}

	auto write(const char* str) {
		auto str_ = str;
		return WriteFunction([=](const WriteState& state) {
			WriteState newState = state.Add(str_);
			WriteResult r(newState);
			return r;
		});
	}

	auto write(TFunction<FString(const WriteState&)> func) {
		auto func_ = func;
		return WriteFunction([=](const WriteState& state) {
			WriteState newState = state.Add(func_(state));
			WriteResult r(newState);
			return r;
		});
	}

	using RepeatFunc = TFunction<WriteResult(int, const WriteState&)>;
	auto repeat(TFunction<int(const WriteState&)> count, RepeatFunc func) {
		auto count_ = count;
		auto func_ = func;
		return WriteFunction([=](const WriteState& state) {
			auto s = state;
			auto num = count(state);
			for (int i = 0; i < num; i++) {
				auto r = func(i, s);
				if (!r.OK)
					return r;
				s = r.State;
			}
			WriteResult wr(s);
			return wr;
		});
	}

	auto repeat_fields( WriteFunction func) {
		auto func_ = func;
		return WriteFunction([=](const WriteState& state) {
			auto str = state.GetStruct();
			auto st = state;
			auto it = TFieldIterator<UProperty>(str,
				EFieldIteratorFlags::ExcludeSuper,
				EFieldIteratorFlags::ExcludeDeprecated,
				EFieldIteratorFlags::IncludeInterfaces);
			for (; it; ++it) {
				auto* prop = *it;
				WriteState s(prop, state.Tab());
				WriteResult r = func_(s);
				if (!r.OK)
					return r;
				auto contents = r.State.Contents();
				st = st.Add(contents);
			}
			return WriteResult(st);
		});
	}

	auto tab = [](const WriteState& state) {
		return WriteResult(state.Add(state.Tab()));
	};

	auto indent = [](const WriteState& state) {
		return WriteResult(state.Indent());
	};

	auto dedent = [](const WriteState& state) {
		return WriteResult(state.Dedent());
	};

	auto test(TFunction<bool(const WriteState&)> pred) {
		auto pred_ = pred;
		return WriteFunction([=](const WriteState& state) {
			if (pred_(state))
				return WriteResult(state);
			return WriteResult(false);
		});
	}

	const auto name_ok = test([](const WriteState& state) {
			return !(state.Name().StartsWith("TRASH") || state.Name().StartsWith("ORPHANED"));
		});

	const auto is_enum_byte_property = test([](const WriteState& state) { return state.IsEnumByteProperty(); });

	const auto is_enum = test([](const WriteState& state) { return state.IsEnum(); });

	const auto is_property = test([](const WriteState& state) { return state.IsProperty(); });

	const auto is_struct = test([](const WriteState& state) { return state.IsStruct(); });

	const auto is_visible = test([](const WriteState& state) { return state.IsVisible(); });

	const auto is_deprecated = test([](const WriteState& state) { return state.IsDeprecated(); });

	const auto is_readonly = test([](const WriteState& state) { return state.IsReadonly(); });

	const auto is_writable = test([](const WriteState& state) { return !state.IsReadonly(); });

	const auto is_callable = test([](const WriteState& state) { return state.IsCallableFunction(); });

	const auto is_blueprint_event = test([](const WriteState& state) { return state.IsBlueprintEvent(); });

	const auto is_native_blueprint_event = test([](const WriteState& state) { return state.IsNativeBlueprintEvent(); });

	const auto has_out_parameters = test([](const WriteState& state) { return state.HasOutParameters(); });

	const auto has_out_or_ref_parameters = test([](const WriteState& state) { return state.HasOutOrRefParameters(); });

	const auto has_in_parameters = test([](const WriteState& state) { return state.HasInParameters(); });

	const auto has_array_parameter = test([](const WriteState& state) { return state.HasArrayParameter(); });

	const auto is_out_parameter = test([](const WriteState& state) { return state.IsOutParameter(); });

	const auto is_ref_parameter = test([](const WriteState& state) { return state.IsRefParameter(); });

	const auto is_const_parameter = test([](const WriteState& state) { return state.IsConstParameter(); });

	const auto is_in_parameter = test([](const WriteState& state) { return state.IsInParameter(); });

	const auto is_static = test([](const WriteState& state) { return state.IsStatic(); });

	const auto is_not_static = test([](const WriteState& state) { return !state.IsStatic(); });

	const auto is_not_deprecated = test([](const WriteState& state) { return !(state.Name(false).StartsWith("Deprecated") || state.Name(false).EndsWith("Deprecated")); });

	const auto is_true = test([](const WriteState& state) { return true;  });

	const auto is_false = test([](const WriteState& state) { return false;  });

	auto name_is(const char* name) {
		const char* name_ = name;
		return test([=](const WriteState& state) { return state.Name(false) == name; });
	}
	const auto struct_size = [](const WriteState& state) {
		return write(state.StructSize())(state);
	};
	const auto struct_size_long = [](const WriteState& state) {
		return write(state.StructSizeLong())(state);
	};

	auto map_property(
		const char* source,
		WriteFunction array_property,
		WriteFunction bool_property,
		WriteFunction byte_property,
		WriteFunction class_property,
		WriteFunction delegate_property,
		WriteFunction double_property,
		WriteFunction enum_property,
		WriteFunction float_property,
		WriteFunction int16_property,
		WriteFunction int64_property,
		WriteFunction int8_property,
		WriteFunction interface_property,
		WriteFunction int_property,
		WriteFunction lazy_object_property,
		WriteFunction map_property,
		WriteFunction multicast_delegate_property,
		WriteFunction name_property,
		WriteFunction numeric_property,
		WriteFunction object_property,
		WriteFunction set_property,
		WriteFunction soft_class_property,
		WriteFunction soft_object_property,
		WriteFunction string_property,
		WriteFunction struct_property,
		WriteFunction text_property,
		WriteFunction uint16_property,
		WriteFunction uint32_property,
		WriteFunction uint64_property,
		WriteFunction weak_object_property) {
		auto source_ = source;
		auto array_property_ = array_property;
		auto bool_property_ = bool_property;
		auto byte_property_ = byte_property;
		auto class_property_ = class_property;
		auto delegate_property_ = delegate_property;
		auto double_property_ = double_property;
		auto enum_property_ = enum_property;
		auto float_property_ = float_property;
		auto int16_property_ = int16_property;
		auto int8_property_ = int8_property;
		auto int64_property_ = int64_property;
		auto interface_property_ = interface_property;
		auto int_property_ = int_property;
		auto lazy_object_property_ = lazy_object_property;
		auto map_property_ = map_property;
		auto multicast_delegate_property_ = multicast_delegate_property;
		auto name_property_ = name_property;
		auto numeric_property_ = numeric_property;
		auto object_property_ = object_property;
		auto set_property_ = set_property;
		auto soft_class_property_ = soft_class_property;
		auto soft_object_property_ = soft_object_property;
		auto string_property_ = string_property;
		auto struct_property_ = struct_property;
		auto text_property_ = text_property;
		auto uint16_property_ = uint16_property;
		auto uint32_property_ = uint32_property;
		auto uint64_property_ = uint64_property;
		auto weak_object_property_ = weak_object_property;
		return [=](const WriteState& state) {
			const char* s = source_;
			if (state.IsA<UArrayProperty>())
				return array_property_(state);
			if (state.IsA<UBoolProperty>())
				return bool_property_(state);
			if (state.IsA<UByteProperty>())
				return byte_property_(state);
			if (state.IsA<UClassProperty>())
				return class_property_(state);
			if (state.IsA<UDelegateProperty>())
				return delegate_property_(state);
			if (state.IsA<UDoubleProperty>())
				return double_property_(state);
			if (state.IsA<UEnumProperty>())
				return enum_property_(state);
			if (state.IsA<UFloatProperty>())
				return float_property_(state);
			if (state.IsA<UInt16Property>())
				return int16_property_(state);
			if (state.IsA<UInt64Property>())
				return int64_property_(state);
			if (state.IsA<UInt8Property>())
				return int8_property_(state);
			if (state.IsA<UInterfaceProperty>())
				return interface_property_(state);
			if (state.IsA<UIntProperty>())
				return int_property_(state);
			if (state.IsA<ULazyObjectProperty>())
				return lazy_object_property_(state);
			if (state.IsA<UMapProperty>())
				return map_property_(state);
			if (state.IsA<UMulticastDelegateProperty>())
				return multicast_delegate_property_(state);
			if (state.IsA<UNameProperty>())
				return name_property_(state);
			if (state.IsA<UNumericProperty>())
				return numeric_property_(state);
			if (state.IsA<UObjectProperty>()) 
				return object_property_(state);
			if (state.IsA<USetProperty>())
				return set_property_(state);
			if (state.IsA<USoftClassProperty>())
				return soft_class_property_(state);
			if (state.IsA<USoftObjectProperty>())
				return soft_object_property_(state);
			if (state.IsA<UStrProperty>())
				return string_property_(state);
			if (state.IsA<UStructProperty>())
				return struct_property_(state);
			if (state.IsA<UTextProperty>())
				return text_property_(state);
			if (state.IsA<UUInt16Property>())
				return uint16_property_(state);
			if (state.IsA<UUInt32Property>())
				return uint32_property_(state);
			if (state.IsA<UUInt64Property>())
				return uint64_property_(state);
			if (state.IsA<UWeakObjectProperty>())
				return weak_object_property_(state);
			auto c = state.GetField()->GetClass();
			WriteResult r(false);
			return r;
		};
	}

	auto make(WriteFunction fun, UField* f) {
		WriteState state(f, "");
		WriteResult r = fun(state);

		return r.OK ? r.State.Contents() : "failed";
	}

	const auto byte_ = write("byte ");
	const auto class_ = write("class ");
	const auto enum_ = write("enum ");
	const auto fixed_ = write("fixed ");
	const auto get_ = write("get ");
	const auto internal_ = write("internal ");
	const auto namespace_ = write("namespace ");
	const auto partial_ = write("partial ");
	const auto private_ = write("private ");
	const auto protected_ = write("protected ");
	const auto public_ = write("public ");
	const auto return_ = write("return ");
	const auto set_ = write("set ");
	const auto static_ = write("static ");
	const auto string_ = write("string ");
	const auto struct_ = write("struct ");
	const auto unsafe_ = write("unsafe ");
	const auto using_ = write("using ");
	const auto var_ = write("var ");
	const auto void_ = write("void ");

	const auto _ptr = write("_ptr");
	const auto _method = write("_method");

	const auto IntPtr_ = write("IntPtr ");
	const auto none = [](const WriteState& state) { return WriteResult(state); };

	const auto SP = write(' ');
	const auto LP = write('(');
	const auto RP = write(')');
	const auto LB = write('{');
	const auto RB = write('}');
	const auto LS = write('[');
	const auto RS = write(']');
	const auto SM = write(';');
	const auto NL = write('\n');
	const auto CM = write(", ");
	const auto DT = write('.');

	const auto UE4 = write("UE4.");

	template <typename... Ts>
	auto l(Ts... fs) {
		return sq(tab, fs..., NL);
	}

	template <typename... Ts>
	auto s(Ts... fs) {
		return l(fs..., SM);
	}

	const auto summary = write("///<summary>");
	const auto yrammus = write("</summary>");
	const auto remarks = write("<remarks>");
	const auto skramer = write("</remarks>");
	const auto doc_comment = write("///");

	const auto header() {
		static auto copyright = sq(write("// Copyright 2018 by JCoder58.  See License.txt for license"), NL);

		static auto auto_generated = sq(write("// Auto-generated --- Do not modify."), NL);

		static auto using_statements = sq(
			sq(write("using System;"), NL),
			sq(write("using System.Collections.Generic;"), NL),
			sq(write("using System.Runtime.InteropServices;"), NL),
			sq(write("using UE4.Core;"), NL),
			sq(write("using UE4.CoreUObject;"), NL),
			sq(write("using UE4.CoreUObject.Native;"), NL),
			sq(write("using UE4.InputCore;"), NL),
			sq(write("using UE4.Native;"), NL)
		);
		static auto h = sq(copyright, auto_generated, using_statements, NL);

		return h;
	}

	auto document() {
		auto get_summary = [](const FString& doc) {
			int nl = -1;
			int i = 0;
			for (; i < doc.Len() && doc[i] != '.' && doc[i] != '@'; i++)
				if (doc[i] == '\n')
					nl = i;
			return i < doc.Len() ? i : (nl >= 0 ? nl : doc.Len());
		};

		auto write_summary = [](const WriteState& state, const TArray<FString>& lines) {
			if (lines.Num() == 1)
				return sq(tab, summary, write(lines[0]), yrammus, NL)(state);
			auto c = [&](const WriteState&) { return lines.Num(); };
			auto l = RepeatFunc([&](int i, const WriteState& st) { return sq(tab, doc_comment, write(lines[i]), NL)(st);  });

			return sq(sq(tab, summary, NL),
				repeat(c, l),
				sq(tab, doc_comment, yrammus, NL))(state);

		};

		auto write_remarks = [](const WriteState& state, const TArray<FString>& lines) {
			if (lines.Num() == 1 && lines[0][0] != '@')
				return sq(tab, doc_comment, remarks, write(lines[0]), skramer, NL)(state);

			auto c = [&](const WriteState&) { return lines.Num(); };
			auto l = RepeatFunc([&](int i, const WriteState& st) { return sq(tab, doc_comment, write(lines[i]), NL)(st);  });

			//TODO: handle @params, @return, etc.

			return sq(sq(tab, doc_comment, remarks, NL),
				repeat(c, l),
				sq(tab, doc_comment, skramer, NL))(state);
		};

		auto multiline = [=](const WriteState& state, const FString& doc) {
			auto i = get_summary(doc);
			if (i == doc.Len())
				return sq(tab, summary, write(doc), yrammus, NL)(state);
			auto s = doc.Mid(0, i + 1);
			TArray<FString> summaryLines;
			s.ParseIntoArrayLines(summaryLines, true);

			auto r = doc.Mid(i + 1).TrimStart();
			if (r.Len() == 0)
				return write_summary(state, summaryLines);
			TArray<FString> remarkLines;
			r.ParseIntoArrayLines(remarkLines, false);
			auto result = write_summary(state, summaryLines);
			return write_remarks(result.State, remarkLines);
		};

		return [=](const WriteState& state) {
			auto doc = state.Doc();
			if (!doc.Contains("\n"))
				return sq(tab, summary, write(doc), yrammus, NL)(state);
			if (!doc.StartsWith("@warning"))
				return multiline(state, doc);
			return WriteResult(state);
		};
	}

	auto writeFile = WriteFunction([](const WriteState& state) {
		auto fileName = path / "Generated" / state.ModuleName() / state.Name() + ".cs";
		state.WriteToFile(fileName);
		return WriteResult(state);
	});

	auto writeNativeFile = WriteFunction([](const WriteState& state) {
		auto fileName = path / "Generated" / state.ModuleName() / "Native" / state.Name() + ".cs";
		state.WriteToFile(fileName);
		return WriteResult(state);
	});

	auto writeNamedNativeFile = [](const char* moduleName, const char* fileName) {
		FString fileName_(fileName);
		FString moduleName_(moduleName);
		return WriteFunction([=](const WriteState& state) {
			auto fileName = path / "Generated" / moduleName_ / "Native" / fileName_ + ".cs";
			state.WriteToFile(fileName);
			return WriteResult(state);
		});
	};

	auto breakpoint(const char* str) {
		auto str_ = str;
		return WriteFunction([=](const WriteState& state) {
			auto isFunc = state.IsFunction();
			auto func = state.GetFunction();
			auto types = state.ReturnType(true);
			if (func->GetName() == "ReceiveHit") {
				auto x = 3;
			}
			WriteState newState = state.Add(str_);
			WriteResult r(newState);
			return r;
		});
	}

	auto name = write([](const WriteState& state) { return state.Name(); });
	auto name_cpp = write([](const WriteState& state) { return state.Name(false); });
	auto class_name = write([](const WriteState& state) { return state.ClassName(); });
	auto method_class_name = write([](const WriteState& state) { return state.MethodClassName(); });
	auto method_class_name_cpp = write([](const WriteState& state) { return state.MethodClassName(false); });
	auto cpp_type = write([](const WriteState& state) { return state.CppType(); });
	auto module_name = write([](const WriteState& state) { return state.ModuleName(); });
	auto offset = write([](const WriteState& state) { return state.FieldOffset(); });
	auto object_type = write([](const WriteState& state) { return state.PropertyObjectType(); });
	auto struct_type = write([](const WriteState& state) { return state.PropertyStructType(); });
	auto interface_type = write([](const WriteState& state) { return state.PropertyInterfaceType(); });
	auto enum_type = write([](const WriteState& state) {return state.PropertyEnumType();  });
	auto class_type = write([](const WriteState& state) { return state.PropertyClassType(); });
	auto class_type_is_uobject = test([](const WriteState& state) {return state.PropertyClassType() == "UObject";  });
	auto property_flags_text = write([](const WriteState& state) { return state.CPFFlagsText(); });

	auto struct_layout = sq(tab, write("[StructLayout( LayoutKind.Explicit, Size="), struct_size, write(" )]"), NL);
	auto field_offset = sq(write("[FieldOffset("), offset, write(")] "));
	auto field = sq(tab, field_offset, cpp_type, write(" "), name, SM, NL);
	auto uobject_make = sq(write("UObject.Make<"), object_type, write(">"));


	auto todo(const char* c) {
		return sq(tab, field_offset, sq(write("byte "), name, SM), sq(write(" //TODO: "), write(c), SP, cpp_type, write(" "), name), NL);
	}
	auto todo_c(const char* c) {
		return sq(tab, sq(write(" //TODO: "), write(c), SP, cpp_type, write(" "), name), NL);
	}
	auto todo_cp(const char* c) {
		return sq(tab, sq(write("throw new NotImplementedException(); //TODO: "), write(c), SP, cpp_type, write(" "), name), NL);
	}
	auto todo_r(const char* c) {
		return sq(write("byte /*TODO: "), write(c), SP, cpp_type, write("*/"));
	}

	WriteResult return_type(const WriteState& state);
	auto todo_mr(const char* c) {
		return sq(write("UObject.NotImplemented<byte>() /*TODO: "), write(c), SP, cpp_type, write("*/"));
	}
	auto todo_p(const char*c) {
		return sq(write("byte "), name, write(" /*TODO: "), write(c), SP, cpp_type, write(" */"));
	}
	auto todo_ep(const char* c) {
		return sq(name, write("/*TODO: "), write(c), SP, cpp_type, write("*/"));
	}

	auto struct_value_type = [](const char* type) {
		return s(field_offset, public_, write(type), SP, name);
	};

	auto native_struct_type = s(field_offset, public_, struct_type, SP, name);

	const auto subclass_of =
		sq(write("SubclassOf<"), class_type, write(">"));

	const auto struct_subclass_of_value = sq(
		document(),
		l(public_, subclass_of, SP, name, SP, LB),
		indent,
		l(get_, LB, return_, name, write("_class;"), SP, RB),
		if_(is_writable,
			l(set_, LB, name, write("_class = value; }"))
		),
		dedent,
		l(RB),
		s(field_offset, private_, IntPtr_, name, write("_class"))
	);



	auto struct_field_name = sq(name, write("_field"));
	auto struct_object_type = sq(
				sq(tab, field_offset, NL),
				sq(tab, private_, sq(IntPtr_, SP, struct_field_name, SM), NL),
				document(),
				sq(tab, public_,  sq(object_type, SP, name), SP, LB, NL),
				indent,
				sq(tab, get_, LB, sq(return_, struct_field_name, SM), RB, NL),
				if_(is_writable,
					sq(tab, set_, LB, sq(struct_field_name, write(" = value;"), RB, NL))
				),
				dedent,
				sq(tab, RB, NL)
			);

	auto struct_struct_type = sq(document(), tab, field_offset, struct_type, SP, name, SM, NL);

	const auto param_value_type = [](const char* type) {
		return
			sq(
				sq(tab, field_offset),
				sq(SP, public_, sq(write(type), SP, name, SM), NL)
			);
	};

	const auto copy_value(const WriteFunction fn) {
		return 	sq(tab, write("*(("), fn, write("*)(b+"), offset,
			write(")) = "), name, SM, NL);

	}
	
	const auto copy_param_value = [](const char* type) {
		if (type == byte_type)
			return sq(tab, write("*(b+"),offset,write(") = "), name, SM, NL);
		return copy_value(write(type));
	};

	const auto copy_param_enum = 
		sq(tab, write("*(b+"), offset, write(") = (byte)"), name, SM, NL);

	const auto event_param(const WriteFunction fn) {
		return sq(write("*("), fn, write("*)(b+"), offset, RP);
	}

	auto event_object_param = sq(uobject_make, LP, event_param(write("IntPtr")), RP);
	auto event_struct_param = event_param(struct_type);
	auto event_enum_param = event_param(enum_type);

	const auto event_param_value = [](const char* type) {
		if (type == byte_type)
			return sq(write("*(b+"), offset, RP);
		return event_param(write(type));
	};

	const auto event_string_param_value = sq(write("FString.Get(b+"), offset, RP);

	const auto copy_struct_value =
		copy_value(struct_type);

	const auto string_handle_name = sq(name, write("_handle"));
	const auto copy_string_value =
		sq(
			s(var_, string_handle_name, write(" = GCHandle.Alloc("), name, write(", GCHandleType.Pinned)")),
			s(write("*(IntPtr*)(b+"), offset, RP,write(" = "), string_handle_name, write(".AddrOfPinnedObject()")),
			s(write("*(int*)(b+IntPtr.Size+"), offset, RP, write(" = "), name, write(".Length")),
			s(write("*(int*)(b+IntPtr.Size+4+"), offset, RP, write(" = "), name, write(".Length"))
		);

	const auto cleanup_string =
		if_(is_in_parameter,
			s(string_handle_name, write(".Free()")));

	auto return_value_base(WriteFunction fn) {
		return 	sq(write("*(("), fn, write("*)(b+"), offset,
			write("))"));
	}

	const auto return_value = [](const char* type, bool star = true) {
		
		if (type == byte_type) {
			if (star)
				return sq(write("*(b+"), offset, RP);
			return sq(write("b+"), offset);
		}
		return
			return_value_base(write(type));
	};

	const auto string_return_value = sq(write("FString.Get(b+"), offset, RP);

	const auto struct_return_value = return_value_base(struct_type);

	const auto native_object_property = sq(
		sq(tab, field_offset),
		sq(SP, public_, IntPtr_, SP, name, SM, NL)
	);
	
	const auto param_object_type = sq(
				sq(tab, field_offset),
				sq(SP, public_, sq(IntPtr_, SP, name, SM), NL)
			);

	const auto fstring_name = sq(name, write("_fstr"));
	const auto param_string_type = sq(
		sq(tab, field_offset),
		sq(private_, byte_, fstring_name, SM, NL),
		sq(tab, public_, unsafe_, string_, name, write(" => ((FString*) &"), fstring_name, write(")->ToString();"), NL)
	);

	const auto value_property = [](const char* type) {
		return sq(
			document(),
			l(public_, unsafe_, write(type), SP, name, SP, LB),
			indent,
			l(get_, LB, sq(return_, class_name, _ptr, write("->"), name, SM), RB),
			if_(is_writable,
				l(set_, LB, sq(class_name, _ptr, write("->"), name, write(" = value;"), RB))
			),
			dedent,
			l(RB)
		);
	};

	const auto bool_class_property = sq(
		l(public_, write("bool "), name, SP, LB),
		indent,
		l(get_, LB, return_, write("Main.GetGetBoolPropertyByName(this, \""), name, write("\"); }" )),
		if_(is_writable,
			l(set_, LB, write("Main.SetGetBoolPropertyByName(this, \""), name, write("\", value); }"))
		),
		dedent,
		l(RB)
	);

	const auto class_property = sq(
		document(),
		l(public_, unsafe_, subclass_of, SP, name, SP, LB),
		indent,
		l(get_, LB, sq(return_, class_name, _ptr, write("->"), name, SM), RB),
		if_(is_writable,
			l(set_, LB, sq(class_name, _ptr, write("->"), name, write(" = value;"), RB))
		),
		dedent,
		l(RB)
	);

	const auto struct_property = sq(
		document(),
		l(public_, unsafe_, struct_type, SP, name, SP, LB),
		indent,
		l(get_, LB, sq(return_, class_name, _ptr, write("->"), name, SM), RB),
		if_(is_writable,
			l(set_, LB, sq(class_name, _ptr, write("->"), name, write(" = value;"), RB))
		),
		dedent,
		l(RB)
	);

	auto value_object_property = sq(
			document(),
			l(public_, unsafe_, object_type, SP, name, SP, LB),
			indent,
			l(get_, LB, sq(return_, class_name, _ptr, write("->"), name, SM), RB),
			if_(is_writable,
				l(set_, LB, sq(class_name, _ptr, write("->"), name, write(" = value;"), RB))
			),
			dedent,
			l(RB)
		);

	auto value_param = [](const char* type) {
		return sq(write(type), SP, name);
	};

	auto subclass_param = sq(subclass_of, SP, name);

	const auto object_param = sq(object_type, SP, name);
	const auto struct_param = sq(struct_type, SP, name);
	const auto enum_param = sq(enum_type, SP, name);
	const auto enum_return_value = return_value_base(enum_type);

	auto array_element_return_type = map_property(
		"array_element_return_type",
		todo_r("array"),	// array
		write("bool"),	// bool
		write("byte"),
		write("Class"), //TODO: Make TSubclass<Class> instead // class
		todo_r("delegate"), // delegate
		write("double"),
		enum_type, // enum
		write("float"),
		write("short"),
		write("long"),
		write("sbyte"),
		todo_r("inteface"), // interface
		write("int"),
		todo_r("lazy object"), // lazy_object
		todo_r("map"), // map
		todo_r("multicast delegate"), // multicast delgate
		write("Name"),
		todo_r("numeric"), // numeric
		object_type, // Object
		todo_r("set"), // Set
		todo_r("soft class"), // soft class
		todo_r("soft object"), // soft object
		write("string"), // string
		struct_type, // struct
		todo_r("text"), // text
		write("ushort"),
		write("uint"),
		write("ulong"),
		todo_r("weak object") // weak object
	);

	

	const auto method_return_array_type(const WriteState& state) {
		if (state.IsArrayProperty()) {
			auto a = state.GetArrayProperty();
			auto inner = a->Inner;
			WriteState st(inner, "");
			auto r = array_element_return_type(st);
			if (r.OK) {
				st = state.Add(r.State.Contents());
				return WriteResult(st);
			}
			return r;
		}
		return WriteResult(false);
	}

	const auto is_uobject_array = test([](const WriteState& state) {
		if (state.IsArrayProperty()) {
			auto a = state.GetArrayProperty();
			auto inner = a->Inner;
			return inner->IsA<UObjectProperty>();
		}
		return false;
	});

	const auto is_string_array = test([](const WriteState& state) {
		if (state.IsArrayProperty()) {
			auto a = state.GetArrayProperty();
			auto inner = a->Inner;
			return inner->IsA<UStrProperty>();
		}
		return false;
	});

	const auto return_array_value =
		if_(is_uobject_array,
			sq(write("UObject.ToUObjectCollection<"), method_return_array_type, write(">"), LP, return_value("byte", false), RP),
			if_(is_string_array,
				sq(write("UObject.ToStringCollection"), LP, return_value("byte", false), RP),
				sq(write("UObject.ToUnmangedCollection<"), method_return_array_type, write(">"), LP, return_value("byte", false), RP)
			)
		);

	const auto method_return_array = sq(write("IReadOnlyCollection<"), method_return_array_type, write(">"));

	const auto class_array_field_type = sq(write("ObjectArrayField<"), method_return_array_type, write("> "));
	const auto class_array_field =
		if_(is_not_deprecated,
		if_(is_uobject_array,
			sq(
				document(),
				l(public_, class_array_field_type, name, write("{ get {")),
				indent,
				s(write("if("),name,write("_store == null) "), name, write("_store = new "),
					class_array_field_type, LP, write("&"),
					class_name, write("_ptr->"), name, RP),
				s(return_, name, write("_store")),
				dedent,
				l(RB, SP, RB),
				s(private_, class_array_field_type, name, write("_store")),
				NL
			),
			todo_c("array not UObject")
	));
	const auto struct_field = map_property(
		"struct_field",
		todo("array"), // array
		struct_value_type("bool"),
		struct_value_type("byte"), // byte
		struct_subclass_of_value, // class
		todo("delegate"), // delegate
		struct_value_type("double"),
		todo("enum"), // enum
		struct_value_type("float"),
		struct_value_type("short"),
		struct_value_type("long"),
		struct_value_type("sbyte"),
		todo("interface"), // interface
		struct_value_type("int"),
		todo("lazy_object"), // lazy_object
		todo("map"), // map
		todo("multicast_delegate"), // multicast delgate
		struct_value_type("Name"), // name
		todo("numeric"), // numeric
		struct_object_type, // Object
		todo("set"), // Set
		todo("soft class"), // soft class
		todo("soft object"), // soft object
		todo("string"), // string
		struct_struct_type, // struct
		todo("text"), // text
		struct_value_type("ushort"),
		struct_value_type("uint"),
		struct_value_type("ulong"),
		todo("weak object") // weak object
	);

	auto class_native_field = map_property(
		"struct_field",
		struct_value_type("NativeArray"),
		struct_value_type("bool"),
		struct_value_type("byte"),
		struct_value_type("IntPtr"), // class
		todo("delegate"), // delegate
		struct_value_type("double"),
		todo("enum"), // enum
		struct_value_type("float"),
		struct_value_type("short"),
		struct_value_type("long"),
		struct_value_type("sbyte"),
		todo("interface"), // interface
		struct_value_type("int"),
		todo("lazy_object"), // lazy_object
		todo("map"), // map
		todo("multicast delegate"), // multicast delgate
		struct_value_type("Name"), // name
		todo("numeric"), // numeric
		native_object_property, // Object
		todo("set"), // Set
		todo("soft class"), // soft class
		todo("soft object"), // soft object
		todo("string"), // string
		native_struct_type, // struct
		todo("text"), // text
		struct_value_type("ushort"),
		struct_value_type("uint"),
		struct_value_type("ulong"),
		todo("weak object") // weak object
	);

	auto param_field = map_property(
		"param_field",
		todo("array"),	// array
		param_value_type("bool"),
		param_value_type("byte"),
		param_value_type("Class"), // class
		todo("delegate"), // delegate
		param_value_type("double"),
		todo("enum"), // enum
		param_value_type("float"),
		param_value_type("short"),
		param_value_type("long"),
		param_value_type("sbyte"),
		todo("interface"), // interface
		param_value_type("int"),
		todo("lazy object"), // lazy_object
		todo("map"), // map
		todo("multicast delegate"), // multicast delgate
		param_value_type("Name"), // name
		todo("numeric"), // numeric
		param_object_type, // Object
		todo("set"), // Set
		todo("soft class"), // soft class
		todo("soft object"), // soft object
		param_string_type, // string
		todo("struct"), // struct
		todo("text"), // text
		param_value_type("ushort"),
		param_value_type("uint"),
		param_value_type("ulong"),
		todo("weak object") // weak object
	);

	auto cleanup_method_parameter = map_property(
		"cleanup_method_parameter",
		todo_c("array"),	// array
		none,
		none,
		none,				 // class
		todo_c("delegate"), // delegate
		none,
		none, // enum
		none,
		none,
		none,
		none,
		todo_c("interface"), // interface
		none,
		todo_c("lazy_object"), // lazy_object
		todo_c("map"), // map
		todo_c("multicast delegate"), // multicast delgate
		none,
		todo_c("numeric"), // numeric
		none, // Object
		todo_c("set"), // Set
		todo_c("soft class"), // soft class
		todo_c("soft object"), // soft object
		cleanup_string, // string
		none, // struct
		todo_c("text"), // text
		none,
		none,
		none,
		todo_c("weak object") // weak object
	);

	auto copy_param = map_property(
		"copy_param",
		todo_cp("array"),	// array
		copy_param_value("bool"),
		copy_param_value("byte"),
		copy_param_value("IntPtr"), // class
		todo_cp("delegate"), // delegate
		copy_param_value("double"),
		copy_param_enum,
		copy_param_value("float"),
		copy_param_value("short"),
		copy_param_value("long"),
		copy_param_value("sbyte"),
		todo_cp("interface"), // interface
		copy_param_value("int"),
		todo_cp("lazy object"), // lazy_object
		todo_cp("map"), // map
		todo_cp("multicast delegate"), // multicast delgate
		copy_param_value("Name"), // name
		todo_cp("numeric"), // numeric
		copy_param_value("IntPtr"), // Object
		todo_cp("set"), // Set
		todo_cp("soft class"), // soft class
		todo_cp("soft object"), // soft object
		copy_string_value, // string
		copy_struct_value, // struct
		todo_cp("text"), // text
		copy_param_value("ushort"),
		copy_param_value("uint"),
		copy_param_value("ulong"),
		todo_cp("weak object") // weak object
	);

	auto class_field = map_property(
		"class_field",
		class_array_field,	// array
		bool_class_property,
		value_property("byte"),
		class_property, // class
		todo_c("delegate"), // delegate
		value_property("double"),
		todo_c("enum"), // enum
		value_property("float"),
		value_property("short"),
		value_property("long"),
		value_property("sbyte"),
		todo_c("interface"), // interface
		value_property("int"),
		todo_c("lazy object"), // lazy_object
		todo_c("map"), // map
		todo_c("multicast delegate"), // multicast delgate
		value_property("Name"),
		todo_c("numeric"), // numeric
		value_object_property, // Object
		todo_c("set"), // Set
		todo_c("soft class"), // soft class
		todo_c("soft object"), // soft object
		todo_c("string"), // string
		struct_property, // struct
		todo_c("text"), // text
		value_property("ushort"),
		value_property("uint"),
		value_property("ulong"),
		todo_c("weak object") // weak object
	);

	auto return_value_map = map_property(
		"return_value_map",
		return_array_value,	// array
		return_value("bool"),
		return_value("byte"),
		return_value("IntPtr"), // class
		todo_mr("delegate"), // delegate
		return_value("double"),
		enum_return_value, // enum
		return_value("float"),
		return_value("short"),
		return_value("long"),
		return_value("sbyte"),
		return_value("IntPtr"), // interface
		return_value("int"),
		todo_mr("lazy object"), // lazy_object
		todo_mr("map"), // map
		todo_mr("multicast delegate"), // multicast delgate
		return_value("Name"), // name
		todo_mr("numeric"), // numeric
		return_value("IntPtr"), // Object
		todo_mr("set"), // Set
		todo_mr("soft class"), // soft class
		todo_mr("soft object"), // soft object
		string_return_value, // string
		struct_return_value, // struct
		todo_mr("text"), // text
		return_value("ushort"),
		return_value("uint"),
		return_value("ulong"),
		todo_mr("weak object") // weak object
	);

	auto event_return_value_map = map_property(
		"return_value_map",
		todo_mr("array"),	// array
		return_value("bool"),
		return_value("byte"),
		return_value("IntPtr"), // class
		todo_mr("delegate"), // delegate
		return_value("double"),
		enum_return_value, // enum
		return_value("float"),
		return_value("short"),
		return_value("long"),
		return_value("sbyte"),
		return_value("IntPtr"), // interface
		return_value("int"),
		todo_mr("lazy object"), // lazy_object
		todo_mr("map"), // map
		todo_mr("multicast delegate"), // multicast delgate
		return_value("Name"), // name
		todo_mr("numeric"), // numeric
		return_value("IntPtr"), // Object
		todo_mr("set"), // Set
		todo_mr("soft class"), // soft class
		todo_mr("soft object"), // soft object
		string_return_value, // string
		struct_return_value, // struct
		todo_mr("text"), // text
		return_value("ushort"),
		return_value("uint"),
		return_value("ulong"),
		todo_mr("weak object") // weak object
	);

	auto method_return_type = map_property(
		"method_return_type",
		method_return_array,	// array
		write("bool"),	// bool
		write("byte"),
		subclass_of,   // class
		todo_r("delegate"), // delegate
		write("double"),
		enum_type, // enum
		write("float"),
		write("short"),
		write("long"),
		write("sbyte"),
		interface_type, // interface
		write("int"),
		todo_r("lazy object"), // lazy_object
		todo_r("map"), // map
		todo_r("multicast delegate"), // multicast delgate
		write("Name"),
		todo_r("numeric"), // numeric
		object_type, // Object
		todo_r("set"), // Set
		todo_r("soft class"), // soft class
		todo_r("soft object"), // soft object
		write("string"), // string
		struct_type, // struct
		todo_r("text"), // text
		write("ushort"),
		write("uint"),
		write("ulong"),
		todo_r("weak object") // weak object
	);

	auto class_param = [](const WriteState& state) {
		auto c = state.GetField()->GetClass();
		return WriteResult(state);
	};

	
	auto method_parameter = map_property(
		"method_parameter",
		todo_p("array"),	// array
		value_param("bool"),
		value_param("byte"),
		subclass_param, // class
		todo_p("delegate"), // delegate
		value_param("double"),
		enum_param, // enum
		value_param("float"),
		value_param("short"),
		value_param("long"),
		value_param("sbyte"),
		todo_p("interface"), // interface
		value_param("int"),
		todo_p("lazy_object"), // lazy_object
		todo_p("map"), // map
		todo_p("multicast delegate"), // multicast delgate
		value_param("Name"),
		todo_p("numeric"), // numeric
		object_param, // Object
		todo_p("set"), // Set
		todo_p("soft class"), // soft class
		todo_p("soft object"), // soft object
		value_param("string"), // string
		struct_param, // struct
		todo_p("text"), // text
		value_param("ushort"),
		value_param("uint"),
		value_param("ulong"),
		todo_p("weak object") // weak object
	);

	auto event_value_param = name;
	
	auto event_parameter = map_property(
		"event_parameter",
		todo_ep("array"),	// array
		event_param_value("bool"),
		event_param_value("byte"),
		event_param_value("IntPtr"), // class
		todo_ep("delegate"), // delegate
		event_param_value("double"),
		event_enum_param, // enum
		event_param_value("float"),
		event_param_value("short"),
		event_param_value("long"),
		event_param_value("sbyte"),
		todo_ep("interface"), // interface
		event_param_value("int"),
		todo_ep("lazy object"), // lazy_object
		todo_ep("map"), // map
		todo_ep("multicast delegate"), // multicast delgate
		event_param_value("Name"),
		todo_ep("numeric"), // numeric
		event_object_param, // Object
		todo_ep("set"), // Set
		todo_ep("soft class"), // soft class
		todo_ep("soft object"), // soft object
		event_string_param_value, // string
		event_struct_param, // struct
		todo_ep("text"), // text
		event_param_value("ushort"),
		event_param_value("uint"),
		event_param_value("ulong"),
		todo_ep("weak object") // weak object
	);

	auto using_list = [](const WriteState& state) {
		WriteState st = state;
		auto mn = state.ModuleName();
		for (auto& s : UsingModules) {
			if (s != mn && s != "CoreUObject") {
				auto r = sq(using_, UE4, write(s), SM, NL)(st);
				if (!r.OK)
					break;
				st = r.State;
			}
		}
		return WriteResult(st);
	};

	auto method_loop = [](WriteFunction filter, WriteFunction fn) {
		auto fn_ = fn;
		auto filter_ = filter;
		return [=](const WriteState& state) {
			auto c = state.GetClass();
			TArray<FName> func_list;
			c->GenerateFunctionList(func_list);
			WriteState st = state;
			for (auto func_name : func_list) {
				auto func = c->FindFunctionByName(func_name, EIncludeSuperFlag::ExcludeSuper);
				if (func) {
					WriteState func_state(func, state.Tab());
					auto f = filter_(func_state);
					if (f.OK) {
						auto r = fn_(func_state);
						if (r.OK) {
							st = st.Add(r.State.Contents());
						}
					}
				}
			}

			return WriteResult(st);
		};
	};

	auto property_loop = [](WriteFunction param) {
		auto param_ = param;
		return WriteFunction([=](const WriteState& state) {
			auto func = state.GetFunction();
			auto st = state;
			for (auto it = TFieldIterator<UProperty>(func); it; ++it) {
				auto* prop = *it;
				WriteState s(prop, state.Tab());
				WriteResult r = param_(s);
				if (!r.OK)
					return r;
				st = st.Add(r.State.Contents());
			}
			return WriteResult(st);
		});
	};

	auto parameters_loop = [](WriteFunction filter, WriteFunction param) {
		auto filter_ = filter;
		auto param_ = param;
		return WriteFunction([=](const WriteState& state) {
			auto func = state.GetFunction();
			auto st = state;
			bool first = true;
			for (auto it = TFieldIterator<UProperty>(func); it; ++it) {
				auto* prop = *it;
				WriteState s(prop, state.Tab());
				WriteResult f = filter_(s);
				if (f.OK) {
					WriteResult r = param_(s);
					if (!r.OK)
						return r;
					FString comma = ", ";
					if (first) {
						comma = "";
						first = false;
					}
					auto contents = comma + r.State.Contents();
					st = st.Add(contents);
				}
			}
			return WriteResult(st);
		});
	};


	auto method_struct_name = sq(name, write("_method"));
	auto event_struct_name = sq(name, write("_event"));
	auto method_ufunction = sq(name, _ptr);

	auto return_type_base(const  WriteState& state, TArray<UProperty*>& types) {
		if (types.Num() == 0)
			return write("void")(state);
		if (types.Num() == 1) {
			WriteState st(types[0], "");
			st.AddToUsing();
			auto r = method_return_type(st);
			if (r.OK) {
				auto st2 = state.Add(r.State.Contents());
				return WriteResult(st2);
			}
			return r;
		}
		auto st = state.Add("(");
		bool commaNeeded = false;
		for (auto prop : types) {
			WriteState pst(prop, "");
			pst.AddToUsing();
			auto r = method_return_type(pst);
			if (!r.OK)
				return r;
			auto text = (commaNeeded ? ", " : "") + r.State.Contents();
			commaNeeded = true;
			st = st.Add(text);
		}
		st = st.Add(")");
		return WriteResult(st);
	}

	WriteResult return_type(const WriteState& state) {
		auto types = state.ReturnType(false);
		return return_type_base(state, types);
	};

	WriteResult event_return_type(const WriteState& state) {
		auto types = state.ReturnType(true);
		return return_type_base(state, types);
	};

	auto event_return_values = [](const WriteState& state) {
		auto types = state.ReturnType(true);
		if (types.Num() == 1) {
			WriteState st(types[0], "");
			auto n = name(st);
			if (n.OK) {
				auto st2 = state.Add(n.State.Contents());
				return WriteResult(st2);
			}
			return n;
		}
		auto st = state.Add("(");
		bool commaNeeded = false;
		for (auto prop : types) {
			WriteState pst(prop, "");
			auto r = name(pst);
			if (!r.OK)
				return r;
			auto text = (commaNeeded ? ", " : "") + r.State.Contents();
			commaNeeded = true;
			st = st.Add(text);
		}
		st = st.Add(")");
		return WriteResult(st);
	};

	const auto var_params = sq(
		sq( tab, var_, write("p = new "), method_struct_name, SP,LB, NL),
		if_( has_in_parameters, sq( 
			indent, 
			tab, parameters_loop(is_in_parameter, sq(name, write("="),name)), NL,
			dedent)),
		sq(tab, RB, SM, NL)
		);

	const auto call_process_event = sq(
		tab, write("Main.GetProcessEvent("),
		if_(is_static, sq(method_class_name, write(".DefaultObject")), write("obj")), CM,
		method_ufunction, CM,
		write("new IntPtr(p)); "),
		SM, NL
	);

	auto return_single_value(UProperty* prop) {
		auto prop_ = prop;
		return [=](const WriteState& state) {
			WriteState st(prop_, "");
			auto r = return_value_map(st);
			if (r.OK) {
				auto s = state.Add(r.State.Contents());
				return WriteResult(s);
			}
			return r;
		};
	}

	const auto return_expression = [](const WriteState& state) {
		auto returnTypes = state.ReturnType();
		if (returnTypes.Num() == 1)
			return return_single_value(returnTypes[0])(state);

		TArray<FString> values;

		for (auto ty : returnTypes) {
			WriteState st(ty, "");
			auto r = return_single_value(ty)(st);
			if (!r.OK)
				return r;
			values.Add(r.State.Contents());
		}

		auto s = sq(LP, write(FString::Join(values, TEXT(","))), RP)(state);
		return s;
	};

	const auto return_stmt = sq(tab, write("return "), return_expression, SM, NL);

	const auto delegate_name = sq(name, write("_delegate"));
	const auto on_event = sq(write("on_"), name);

	auto event_delegate_name = sq(name, write("_link"));
	auto event_init_name = sq(name, write("_init"));
	auto process_event_name = sq(name, write("_process_event"));
	auto event_setup_name = write("Setup()");

	auto event_set_return(const WriteState& state) {
		auto returnTypes = state.ReturnType();
		if (returnTypes.Num() > 0) {
			auto lastType = returnTypes[returnTypes.Num() - 1];
			//TODO: Make a new event_return_type to map properly
			if (lastType->IsA<UStrProperty>())
				return sq(write("/*TODO: event_set_return return "),
					event_return_type, write("*/"))(state);
			if (lastType->IsA<UBoolProperty>())
				return write("*(bool*)result.ToPointer() = ")(state);
			if (lastType->IsA<UObjectProperty>() ||
				lastType->IsA<UClassProperty>())
				return write("*(IntPtr*)result.ToPointer() = ")(state);
			return sq(write("*("), event_return_type,
				write("*)result.ToPointer() = "))(state);
		}
		return WriteResult(state);
	}

	auto event_pass_return(const WriteState& state) {
		auto returnTypes = state.ReturnType();
		if (returnTypes.Num() > 0) {
			auto lastType = returnTypes[returnTypes.Num() - 1];
			//TODO: Make a new event_return_type to map properly
			if (lastType->IsA<UStrProperty>())
				return write("FString.Get((byte*)result.ToPointer())")(state);
			if (lastType->IsA<UBoolProperty>())
				return write("*(bool*)result")(state);
			if (lastType->IsA<UObjectProperty>() ||
				lastType->IsA<UClassProperty>())
				return write("*(IntPtr*)result")(state);
			return sq(write("*("), event_return_type,
				write("*)result"))(state);
		}
		return WriteResult(state);
	}

	auto event_parameters(const WriteState& state) {
		auto name = state.Name();
		auto returnTypes = state.ReturnType();
		auto inTypes = state.InParameters();
		if (inTypes.Num() == 0) {
			if (returnTypes.Num() == 1)
				return event_pass_return(state);
			return WriteResult(state);
		}

		auto st = parameters_loop(is_in_parameter, event_parameter)(state);
		if (returnTypes.Num() == 1)
			return sq(CM, event_pass_return)(st.State);

		return WriteResult(st);
	}

	auto event_native_blueprint =
		if_(name_is("SpawnDefaultPawnAtTransform"),
			l(write("//TODO: event_native_blueprint: event with ref struct parameter"), name),
		if_(has_array_parameter,
			l(write("//TODO: event_native_blueprint: event with array parameter "), name),
			sq(
			struct_layout,
			l(internal_, unsafe_, struct_, event_struct_name, SP, LB),
			indent,
			s(private_, static_, write("FNativeFuncPtr NativeFunction")),
			s(private_, static_, write("DelegateHolder<NativeFuncDelegate> "), event_delegate_name),
			sq(
				l(private_, static_, unsafe_, void_, process_event_name, write("(IntPtr context, Frame* theStack, IntPtr result) {")),
				indent,
				s(write("NativeFunction(context, theStack,result)")),
				s(write("var obj = UObject.Make<"), method_class_name, write(">(context)")),
				s(write("var b = (byte*) theStack->Locals")),
				s(event_set_return, write("obj."), on_event, LP, event_parameters, RP),
				dedent,
				l(RB)
			),
			sq(
				l(internal_, static_, void_, event_setup_name, SP, LB),
				indent,
				if_(is_false,
					l(write("//TODO: event_native_blueprint disabled: "), name),
					sq(
						l(event_delegate_name, write(" = new DelegateHolder<NativeFuncDelegate>("), process_event_name, write(");")),
						l(write("var uf = Main.GetUFunction(\""), name, write("\");")),
						l(write("var func = UObject.Make<Function>(uf);")),
						s(write("NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() )")),
						l(write("func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate("), event_delegate_name, write(".Delegate));"))
					)),
				dedent,
				l(RB)
			),
			dedent,
			l(RB)
		)));

	auto event_native = 
		if_(has_array_parameter,
			l(write("//TODO: event_native: event with array parameter"), name),
			sq(
				struct_layout,
				l(internal_, unsafe_, struct_, event_struct_name, SP, LB),
				indent,
				sq(
					l( private_, static_, write("DelegateHolder<NativeFuncDelegate> "), event_delegate_name, SM),
					l(private_, static_, unsafe_, void_, process_event_name, write("(IntPtr context, Frame* theStack, IntPtr result) {")),
					indent,
					l(write("var obj = UObject.Make<"), method_class_name, write(">(context);")),
					l(write("var b = (byte*) theStack->Locals;"),NL),
					l(write("obj."), on_event, LP, parameters_loop(is_true, event_parameter), RP, SM),
					dedent,
					l(RB)
				),
				sq(
					l(internal_, static_, void_, event_setup_name, SP, LB),
					indent,
					l(event_delegate_name, write(" = new DelegateHolder<NativeFuncDelegate>("), process_event_name, write(");")),
					l(write("var uf = Main.GetUFunction(\""), name, write("\");")),
					l(write("var func = UObject.Make<Function>(uf);")),
					l(write("func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);")),
					l(write("func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate("), event_delegate_name,write(".Delegate));")),
					dedent,
					l(RB)
				),
				dedent,
				l(RB)
			));

	const auto copy_parameter = 
		if_(is_in_parameter, copy_param,
		if_(is_ref_parameter, copy_param))
	;

	const auto struct_zero = [](const WriteState& state) {
		auto cnt = state.StructSizeLongCount();
		bool comma = false;
		WriteState st = state;
		for (int i = 0; i <= cnt; i++) {
			if (comma)
				st = st.Add(",");
			comma = true;
			st = st.Add("0L");
		}
		return WriteResult(st);
	};


	auto native = write(".Native");
	auto _fields = write("_fields");
	auto _events = write("_events");
	auto _methods = write("_methods");
	auto fields_name = sq(name, _fields);
	auto methods_name = sq(name, _methods);
	auto events_name = sq(name, _events);


	auto fields_ptr_type = sq(fields_name, write('*'));
	auto field_ptr_getter = sq(
		sq(tab, internal_, unsafe_, fields_ptr_type),
		sq(SP, name, _ptr, write(" => ")),
		sq(LP, fields_ptr_type, RP),
		write(" ObjPointer.ToPointer();"), NL, NL
	);

	auto comma(WriteFunction fn) {
		auto fn_ = fn;
		return [=](const WriteState& state) {
			WriteState st(state.GetField(), state.Tab());
			auto r = fn_(st);
			if (r.OK ) {
				if (r.State.Contents().Len() > 0) {
					st = state.Add(", " + r.State.Contents());
					return WriteResult(st);
				}
				return WriteResult(state);
			}
			return r;
		};
	}

	const auto invoke_param_loop = parameters_loop(is_in_parameter, method_parameter);

	const auto invoke_method = sq(
		sq(tab, internal_, static_, unsafe_, sq(return_type, write(" Invoke"), LP,
			if_(is_not_static, 
				sq(IntPtr_, write("obj"), comma(invoke_param_loop)),
				invoke_param_loop
			),
			RP, SP, LB, NL)),
		indent,
		l(write("long* p = stackalloc long[] {"), struct_zero, write("};")),
		l(write("byte* b = (byte*) p;")),
		repeat_fields(copy_parameter),
		call_process_event,
		repeat_fields(cleanup_method_parameter),
		if_(has_out_parameters, return_stmt),
		dedent,
		l(RB)
		);

	auto method_native = sq(
		sq(tab, internal_, struct_, method_struct_name, SP, LB, NL),
		indent,
		sq(
			s(static_, internal_, IntPtr_, method_ufunction),
			l(static_, method_struct_name, LP, RP, SP, LB),
			indent,
			l(method_ufunction, write(" = Main.GetMethodUFunction("), method_class_name,write(".StaticClass, \""), name, write("\");")),
			dedent,
			l( RB),
			NL
		),
		invoke_method,
		dedent,
		l(RB)
		);

	const auto method_parameter_loop = parameters_loop(is_in_parameter, name);

	auto class_method = sq(
		NL,document(),
		sq(tab, public_, if_(is_static, static_), return_type, SP, name, LP),
		parameters_loop(is_in_parameter, method_parameter),
		sq(RP, SP, write(" => "), NL),
		indent,
		sq(tab,method_class_name, _methods, DT, method_struct_name, write(".Invoke(")),
		if_(is_not_static,
			sq(write("ObjPointer"), comma(method_parameter_loop)),
			method_parameter_loop),
		sq(write(");"), NL),
		// NL, property_loop(sq(tab, write("// "), cpp_type, SP, name, SP, property_flags_text, NL)), NL,
		dedent
	);

	const auto class_event_return_type =
		if_(has_out_or_ref_parameters, sq(event_return_type, SP), void_);

	const auto class_event_function_body =
		if_(has_out_or_ref_parameters,
			s(name, write(" != null ? "),
				name, LP, parameters_loop(is_true, name), RP,
				write(" : "), event_return_values
			),
			s( name, write("?.Invoke"), LP, parameters_loop(is_true, name), RP)
		);
		
	const auto class_event =
		if_ (has_array_parameter,
			l(write("//TODO: class_event: event with array parameter "), name),
			if_(name_is("SpawnDefaultPawnAtTransform"),
				l(write("//TODO: class_event: event with struct parameter "), name),
				sq(
					NL, document(),
					s(public_, write("event "), delegate_name, SP, name),
					s(public_, write("delegate "), class_event_return_type, delegate_name, LP,
						parameters_loop(is_true, method_parameter),
						RP),
					l(internal_, class_event_return_type, on_event, LP, parameters_loop(is_true, method_parameter), RP, SP, write("=>")),
					indent,
						class_event_function_body,
					dedent,
					NL
				)));

	auto super_class = [](const WriteState& state) {
		auto csc = state.SuperClass();
		if (csc.Get<0>().Len() > 0) {
			auto sc = csc.Get<0>();
			auto sc_mod = csc.Get<1>();
			if (sc_mod != state.ModuleName())
				UsingModules.Add(sc_mod);
			if (sc == "Enum")
				return write(": UE4.CoreUObject.Enum")(state);
			if (sc == sc_mod)
				return sq(write(" : "), UE4, write(sc), DT, write(sc), SP)(state);
			return sq(write(" : "), write(sc), SP)(state);
		}
		return WriteResult(state);
	};

	const auto call_event_setup =
		if_(name_is("SpawnDefaultPawnAtTransform"),
			l(write("//TODO: call_event_setup: event with struct parameter "), name),
		if_(has_array_parameter,
			l(write("//TODO: call_event_setup: event with array parameter: "), name),
			l( method_class_name, _events, DT, event_struct_name, DT, event_setup_name, SM)
			));

	auto class_native = sq(
		sq(namespace_, UE4, module_name, native, SP, LB, NL),
		indent,
		sq(
			struct_layout,
			sq(tab, internal_, unsafe_, struct_, fields_name, SP, LB, NL),
			indent,
			repeat_fields(class_native_field),
			dedent,
			sq(tab, RB, NL),
			sq(tab, internal_, unsafe_, struct_, methods_name, SP, LB, NL),
			indent,
			method_loop(is_callable, method_native),
			dedent,
			sq(tab, RB, NL),
			sq(tab, internal_, unsafe_, struct_, events_name, SP, LB, NL),
			indent,
			method_loop(is_blueprint_event, event_native),
			method_loop(is_native_blueprint_event, event_native_blueprint),
			dedent,
			sq(tab, RB, NL)
			),
		dedent,
		sq(RB, NL)
	);

	auto class_implicit_op = sq(
		l(write("///<summary>Convert from IntPtr to UObject</summary>")),
		tab, public_, static_, write("implicit operator "), name,
		write("(IntPtr p) => UObject.Make<"),name,write(">(p);"),NL
	);

	auto class_decl = sq(
		document(),
		l(public_, unsafe_, partial_, class_, name, super_class, SP, LB),
		indent,
		method_loop(is_blueprint_event, class_event),
		method_loop(is_native_blueprint_event, class_event),
		method_loop(is_callable, class_method),
		repeat_fields(class_field),
		sq(
			l(static_, name, write("() {")),
			indent,
			s(write("StaticClass = Main.GetClass(\""), name_cpp, write("\")")),
			method_loop(is_blueprint_event, call_event_setup),
			method_loop(is_native_blueprint_event, call_event_setup),
			dedent,
			l(RB)
		),
		field_ptr_getter,
		class_implicit_op,
		l(write("///<summary>Get UE4 Class</summary>")),
		l(public_, static_, write("Class StaticClass {get; private set;}")),
		l(write("///<summary>Get UE4 Default Object for this Class</summary>")),
		s(public_, static_, name, write(" DefaultObject => Main.GetDefaultObject(StaticClass)")),
		l(write("///<summary>Spawn an object of this class</summary>")),
		s(public_,static_, name, write(" New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name)")),
		dedent,
		l(RB)
	);

	auto class_file() {
		return [=](const WriteState& state) {
			UsingModules.Empty();
			CurrentModule = state.ModuleName();
			if (state.Name().EndsWith("_DEPRECATED")
				|| state.Name().EndsWith("_Deprecated"))
				return WriteResult(state);

			TSet<FString>& um = UsingModules;

			auto cnf = class_native(state);

			auto wf = sq(
				header(),
				using_list, NL,
				write(cnf.State.Contents()),
				writeNativeFile
			)(state);
			
			WriteState ss(state.GetField(), S4);
			auto r = class_decl(ss);

			return if_(name_ok, sq(
				header(),
				sq(write("#pragma warning disable CS0108"), NL),
				sq(using_, UE4, module_name, native, SM, NL),
				using_list,
				NL,
				sq(namespace_, UE4, module_name, SP, LB, NL),
				write(r.State.Contents()),
				sq(RB, NL),
				writeFile
			))(state);
		};

	}

	auto struct_file() {
		auto struct_decl = sq(
			indent,
			document(),
			struct_layout,
			sq(tab, public_, unsafe_, struct_, name, SP, LB, NL),
			indent,
			repeat_fields( sq(struct_field, NL) ),
			dedent,
			sq(tab, RB, NL),
			dedent
		);

		return [=](const WriteState& state) {
			UsingModules.Empty();
			CurrentModule = state.ModuleName();

			WriteState ss(state.GetField(), S4);
			auto r = struct_decl(ss);

			return sq(
				header(),
				using_list,
				NL,
				sq(namespace_, UE4, module_name, LB, NL),
				write(r.State.Contents()),
				sq(RB, NL),
				writeFile
			)(state);
		};
	}

	auto frame_file() {
		FFrame* frame = nullptr;
		auto frameSize = sizeof(*frame);
		auto frameSizeStr = FString::FromInt(frameSize);
		auto offset = (int32) (INT_PTR) &frame->Locals;
		auto localsOffset = FString::FromInt(offset);
		return sq(
			header(),
			write("namespace UE4.CoreUObject.Native {"), NL,
			indent,
			sq(tab, write("[StructLayout(LayoutKind.Explicit, Size = "), write(frameSizeStr), write(")]"), NL),
			sq(tab, internal_, struct_, write("Frame"), SP, LB, NL),
			indent,
			sq(tab, write("[FieldOffset("), write(localsOffset), write(")]public IntPtr Locals;"),NL),
			dedent,
			sq(tab, RB, NL),
			dedent,
			write("}"),
			writeNamedNativeFile("CoreUObject", "Frame")
			);
	}

	auto enum_file() {
		auto enum_count = [](const WriteState& state) {
			return state.EnumCount();
		};

		auto enum_value = [](int i, const WriteState& state) {
			auto name = state.EnumValueName(i);
			auto value = state.EnumValue(i);
			auto comma = write(i < state.EnumCount() - 1 ? ", " : "");
			return sq(tab, write(name), write(" = "), write(value), comma, NL)(state);
		};

		auto enum_decl = sq(
			indent,
			document(),
			sq(tab, public_, enum_, name, SP, LB, NL),
			indent,
			repeat(enum_count, enum_value),
			dedent,
			sq(tab, RB, NL),
			dedent
		);

		return sq(
			header(),
			sq(namespace_, UE4, module_name, SP, LB, NL),
			enum_decl,
			sq(RB, NL),
			writeFile
		);
	}

}

#endif
