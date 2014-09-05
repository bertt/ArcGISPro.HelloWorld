using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Metro;
using ArcGIS.Desktop.Internal.Mapping;

namespace ArcGISPro.HelloWorld
{
    public class HelloButton:Button
    {
        protected override void OnClick()
        {
            // some SDK tests....
            // get the layers:
            var activePane = FrameworkApplication.Panes.ActivePane as ViewerPaneViewModel;
            var mapView = activePane.GetActiveView() as MapView;
            //activePane.
            //MessageBox.Show("Hallo!! Number of layers:" + mapView.Map.Layers.Count);

            // zoomin, because we can
            mapView.MapScale = mapView.MapScale * 0.8;

            /**
            // get a layer
            var firstLayer = (RasterLayer)mapView.Map.Layers[0];
            // add a new layer
            var l = new CIMTiledServiceLayer
            {
                MaxScale = 3334,
                URI =
                    "http://services.arcgisonline.nl/ArcGIS/rest/services/Basiskaarten/Canvas/MapServer/Basiskaarten/Canvas/MapServer"
            };

            //ArcGIS.Desktop.Mapping.
            mapView.Map.InternalLayers.Add(new FeatureLayer());
            // ILayerPropertySet p = new LayerPropertySet();

            // make a selection
            //firstLayer.SelectByFeatureIds(new int[] {0, 1});
            //var dc = (CIMStandardDataConnection)firstLayer.DataConnection;
            var p = new CIMTiledVectorServiceLayer();
            
            var p1 = new CIMTiledServiceLayer();
            var n=new ServiceLayer();
            */

            //ArcGIS.Desktop.Internal.Mapping.Viewer






        }
    }
}
