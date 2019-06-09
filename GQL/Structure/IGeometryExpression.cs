using GeoAPI.Geometries;

namespace GQL.Structure
{
    public interface IGeometryExpression : IValueExpression
    {
        new IGeometry Value { get; }
    }
}
