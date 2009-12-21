﻿using DevExpress.ExpressApp;
using eXpand.ExpressApp.Core;
using eXpand.ExpressApp.IO.PersistentTypesHelpers;
using eXpand.Persistent.Base.ImportExport;
using eXpand.Utils.Helpers;

namespace eXpand.ExpressApp.IO.Observers {
    public class SerializationConfigurationObserver:ObjectObserver<ISerializationConfiguration> {
        public SerializationConfigurationObserver(ObjectSpace objectSpace) : base(objectSpace) {
        }
        protected override void OnChanged(ObjectChangedEventArgs<ISerializationConfiguration> e)
        {
            base.OnChanged(e);
            ISerializationConfiguration serializationConfiguration = e.Object;
            if (e.PropertyName==serializationConfiguration.GetPropertyName(x=>x.TypeToSerialize)&&e.NewValue!= null) {
                serializationConfiguration.Session.Delete(serializationConfiguration.SerializationGraph);
                new ClassInfoGraphNodeBuilder().Generate(serializationConfiguration);
            }
        }
    }
}