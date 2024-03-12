using Xbim.Common.Geometry;

namespace Xbim.Common.Model
{
    internal class InMemoryGeometryStoreInitialiser : IGeometryStoreInitialiser
    {
        private readonly InMemoryGeometryStore _inMemoryGeometryStore;
        
        public InMemoryGeometryStoreInitialiser(InMemoryGeometryStore inMemoryGeometryStore)
        {          
            _inMemoryGeometryStore = inMemoryGeometryStore;
        }
        public int AddShapeGeometry(XbimShapeGeometry shapeGeometry)
        {           
          return  _inMemoryGeometryStore.AddShapeGeometry(shapeGeometry);           
        }

        public int AddEdgeGeometry(int id,IXbimEdgeSet shapeGeometry)
        {
            return _inMemoryGeometryStore.AddEdgeGeometry(id,shapeGeometry);
        }

        public int AddShapeInstance(XbimShapeInstance shapeInstance, int geometryId)
        {           
           return _inMemoryGeometryStore.AddShapeInstance(shapeInstance, geometryId);
        }



        public int AddRegions(XbimRegionCollection regions)
        {
            return _inMemoryGeometryStore.AddRegions(regions);        
        }

        public void Dispose()
        {
            
        }

        void IGeometryStoreInitialiser.Commit()
        {      
            _inMemoryGeometryStore.EndInit(this);     
        }


    }
}
