using Microsoft.Extensions.Logging;
using Xbim.Common.Geometry;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Ifc4
{
    public interface IXbimEdgeGeometry
    {
        IXbimEdgeSet CreateEdge(IIfcBoundingBox ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcSweptDiskSolid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcShellBasedSurfaceModel ifcSurface, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcSurfaceCurveSweptAreaSolid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcBoxedHalfSpace ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcPolygonalBoundedHalfSpace ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcHalfSpaceSolid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcFaceBasedSurfaceModel ifcSurface, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcTriangulatedFaceSet shell, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcSweptAreaSolid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcExtrudedAreaSolid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcCsgPrimitive3D ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcSphere ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcBlock ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcRightCircularCylinder ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcRevolvedAreaSolid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcRectangularPyramid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcRightCircularCone ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcRevolvedAreaSolidTapered ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcFixedReferenceSweptAreaSolid ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcAdvancedBrep ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcAdvancedBrepWithVoids ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcSectionedSpine ifcSolid, ILogger logger);
        IXbimEdgeSet CreateEdge(IIfcSweptDiskSolidPolygonal ifcSolid, ILogger logger);
    }
}
