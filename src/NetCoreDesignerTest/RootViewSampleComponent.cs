using NetCoreDesigner.RootDesign;
using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace NetCoreDesignerTest
{
    // This sample demonstrates how to provide the root designer view, or
    // design mode background view, by overriding IRootDesigner.GetView().

    // This sample component inherits from RootDesignedComponent which 
    // uses the SampleRootDesigner.
    public class RootViewSampleComponent : RootDesignedComponent
    {
        public RootViewSampleComponent()
        {
        }
    }
}
