using System;
using System.Collections.Generic;
using System.Text;

namespace UE4.CoreUObject {
    public partial class FloatProperty : NumericProperty {
        public float Get( UObject container ) =>
            GetFloatPropertyValue( container, this );
        public void Set( UObject container, float value ) =>
            SetFloatPropertyValue( container, this, value );
    }
}
