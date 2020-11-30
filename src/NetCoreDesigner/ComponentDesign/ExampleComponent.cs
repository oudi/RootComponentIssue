using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace NetCoreDesigner.ComponentDesign
{
    [Designer(typeof(ExampleComponentDesigner), typeof(IDesigner))]
    public class ExampleComponent : System.ComponentModel.Component
    {
        public ExampleComponent()
        {
        }
    }
}
