using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;

namespace Docker.AutoDl
{
    class MefExport : IMefTest
    {
        public string Text => "MEF 1";
    }

    class MefExport2 : IMefTest
    {
        private IMefTest2 Localtest { get; set; }
        public MefExport2(IMefTest2 test)
        {
            Localtest = test;
        }

        public string Text => "MEF 2 / " + Localtest.Text;
    }
}
