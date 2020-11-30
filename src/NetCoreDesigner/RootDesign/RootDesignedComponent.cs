using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace NetCoreDesigner.RootDesign
{
    // The following attribute associates the SampleRootDesigner designer 
    // with the SampleComponent component.
    [Designer(typeof(SampleRootDesigner), typeof(IRootDesigner))]
    public class RootDesignedComponent : Component
    {
        public RootDesignedComponent()
        {
        }
    }
}
