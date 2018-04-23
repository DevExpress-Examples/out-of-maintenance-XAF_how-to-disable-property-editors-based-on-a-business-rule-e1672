using System;
using System.ComponentModel;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Editors;

namespace EditorStateExample.Module {
    [DefaultClassOptions]
    [ImageName("BO_Person")]
    public class Contact : BaseObject {
        public Contact(Session session) : base(session) { }        
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
        [ImmediatePostData]
        public bool IsMarried {
            get { return GetPropertyValue<bool>("IsMarried"); }
            set { SetPropertyValue<bool>("IsMarried", value); }
        }
        [Appearance("Single", Visibility = ViewItemVisibility.Hide, Criteria = "!IsMarried", Context="DetailView")]
        public string SpouseName {
            get { return GetPropertyValue<string>("SpouseName"); }
            set { SetPropertyValue<string>("SpouseName", value); }
        }
        [ImmediatePostData]
        public string Address1 {
            get { return GetPropertyValue<string>("Address1"); }
            set { SetPropertyValue<string>("Address1", value); }
        }
        [Appearance("AddressOneIsEmpty", Enabled = false, Criteria = "IsNullOrEmpty(Address1)")]
        public string Address2 {
            get { return GetPropertyValue<string>("Address2"); }
            set { SetPropertyValue<string>("Address2", value); }
        }
    }
}
