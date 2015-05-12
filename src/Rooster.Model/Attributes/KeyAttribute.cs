using System;
using System.Linq.Expressions;

namespace Rooster.Model.Attributes
{
    public class KeyAttribute :Attribute
    {
        public KeyAttribute()
        {

        }

        public KeyAttribute(Expression propertyExpression)
        {

        }
    }
}