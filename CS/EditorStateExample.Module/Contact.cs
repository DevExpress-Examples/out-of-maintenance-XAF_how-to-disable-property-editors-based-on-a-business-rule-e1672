using System;
using System.ComponentModel;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

using DevExpress.ExpressApp.ConditionalEditorState;

namespace EditorStateExample.Module {
    [DefaultClassOptions]
    [ImageName("BO_Person")]
    [EditorStateRuleAttribute("Single", "SpouseName", EditorState.Hidden, "!Married", ViewType.DetailView)]
    [EditorStateRuleAttribute("AddressOneIsEmpty", "Address2", EditorState.Disabled, "IsNullOrEmpty(Address1)", ViewType.DetailView)]
    public class Contact : BaseObject {
        public Contact(Session session) : base(session) { }        

        public string SpouseName {
            get { return GetPropertyValue<string>("SpouseName"); }
            set { SetPropertyValue<string>("SpouseName", value); }
        }

        [ImmediatePostData]        
        public bool Married {
            get { return GetPropertyValue<bool>("Married"); }
            set { SetPropertyValue<bool>("Married", value); }
        }

        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }

        public string Address2 {
            get { return GetPropertyValue<string>("Address2"); }
            set { SetPropertyValue<string>("Address2", value); }
        }

        [ImmediatePostData]
        public string Address1 {
            get { return GetPropertyValue<string>("Address1"); }
            set { SetPropertyValue<string>("Address1", value); }
        }
    }
}
