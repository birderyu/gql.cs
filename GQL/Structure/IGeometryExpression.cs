using GeoAPI.Geometries;
using System;
using System.Collections.Generic;
using System.Text;

namespace GQL.Structure
{
    public interface IGeometryExpression : IValueExpression
    {
        new IGeometry Value { get; }
    }
}
