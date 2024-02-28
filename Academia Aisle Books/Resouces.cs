using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Aisle_Books
{
    public partial class Resouces : Component
    {
        public Resouces()
        {
            InitializeComponent();
        }

        public Resouces(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
