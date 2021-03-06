﻿using CheckNET.Core.Interactives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static Check<T> IsNotNull<T>(this T val)
        {
            var value = (object)val ?? throw new ArgumentNullException();

            return new Check<T>((T)value, true);
        }

        public static Check<T> IsNull<T>(this T val)
        {
            var value = (object)"IsNull" ?? (object)val;

            if (value == "IsNull")
                throw new ArgumentException();

            return new Check<T>((T)value, true);
        }

        public static Check<T> IsEqual<T>(this T val, T otherVal)
        {
            var value = (object)val ?? throw new ArgumentNullException();
            var other = (object)otherVal ?? throw new ArgumentNullException();

            return value.Equals(other) ? new Check<T>((T)value, true) : throw new ArgumentException();
        }
    }
}
