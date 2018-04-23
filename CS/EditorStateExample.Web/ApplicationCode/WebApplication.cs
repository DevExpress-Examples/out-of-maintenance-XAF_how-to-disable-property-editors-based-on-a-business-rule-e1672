using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;

namespace EditorStateExample.Web {
    public partial class EditorStateExampleAspNetApplication : WebApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProviderThreadSafe(args.ConnectionString, args.Connection);
        }
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private EditorStateExample.Module.EditorStateExampleModule module3;

        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
        private DevExpress.ExpressApp.Validation.ValidationModule module5;

        public EditorStateExampleAspNetApplication() {
            InitializeComponent();
        }

        private void EditorStateExampleAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }

        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new EditorStateExample.Module.EditorStateExampleModule();
            this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // module5
            // 
            this.module5.AllowValidationDetailsAccess = true;
            // 
            // EditorStateExampleAspNetApplication
            // 
            this.ApplicationName = "EditorStateExample";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module6);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module5);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.EditorStateExampleAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
