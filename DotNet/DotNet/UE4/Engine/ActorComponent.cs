using System;

using UE4.CoreUObject;

namespace UE4.Engine {
    public partial class ActorComponent : UObject{
        public void RegisterComponent() =>
            UObject.RegisterComponent(this);

        public void UnregisterComponent() =>
            UObject.UnregisterComponent( this );
    }
}
