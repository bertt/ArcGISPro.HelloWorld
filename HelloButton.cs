using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Internal.Framework.Metro;

namespace ArcGISPro.HelloWorld
{
    public class HelloButton:Button
    {
        protected override void OnClick()
        {
            MessageBox.Show("Hallo!!");
        }
    }
}
