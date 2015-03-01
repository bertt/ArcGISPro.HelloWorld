using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Mapping;

namespace ArcGISPro.HelloWorld
{
    public class HelloButton:Button
    {
        protected async override void OnClick()
        {
            // zoomin, because we can
            var mapView = MappingModule.ActiveMapView;
            await mapView.ZoomInFixedAsync();

        }
    }
}
