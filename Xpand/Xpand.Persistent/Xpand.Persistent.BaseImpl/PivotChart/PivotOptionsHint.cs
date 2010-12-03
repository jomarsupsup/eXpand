﻿using DevExpress.Xpo;
using Xpand.Persistent.Base;
using Xpand.Persistent.Base.PivotChart;

namespace Xpand.Persistent.BaseImpl.PivotChart {
    [NonPersistent]
    public class PivotOptionsHint : XpandBaseCustomObject, IPivotOptionsHint {
        public PivotOptionsHint(Session session)
            : base(session) {
        }
    }
}