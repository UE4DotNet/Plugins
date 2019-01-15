using System;
using System.Collections.Generic;
using System.Text;

namespace UE4.CoreUObject {
    public partial class BoolProperty : Property {
        public bool Get( UObject container ) =>
             GetBoolPropertyValue( container, this );
        public void Set( UObject container, bool value ) =>
            SetBoolPropertyValue( container, this, value );
    }
}
