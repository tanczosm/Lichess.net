﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities.Enum
{
    public enum Color
    {
        [System.Runtime.Serialization.EnumMember(Value = @"random")]
        Random = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"white")]
        White = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"black")]
        Black = 2,

    }
}
