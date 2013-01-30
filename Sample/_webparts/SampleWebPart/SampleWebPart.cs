using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;

namespace Sample._webparts.SampleWebPart
{
    [ToolboxItemAttribute(false)]
    public class SampleWebPart : WebPart
    {
        protected override void Render(HtmlTextWriter writer)
        {
            // Added a change!
            writer.Write("Hello world!");
        }
    }
}
