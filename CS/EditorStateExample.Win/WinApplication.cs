using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace EditorStateExample.Win {
    public partial class EditorStateExampleWindowsFormsApplication : WinApplication {
        public EditorStateExampleWindowsFormsApplication() {
            InitializeComponent();
        }

        private void EditorStateExampleWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();

            e.Handled = true;
        }
    }
}
