using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CastingTraining
{
    public class CustomWrapper : DynamicObject
    {
        public string FirstName => "Kuba";
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = "There's no such member";
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            return true;
        }
    }
}
