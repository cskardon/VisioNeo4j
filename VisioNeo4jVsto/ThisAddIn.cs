﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Visio = Microsoft.Office.Interop.Visio;
using Office = Microsoft.Office.Core;

namespace VisioNeo4jVsto
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
//            myUserControl1 = new MyUserControl();
//            Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "My Task Pane");
//            myCustomTaskPane.Visible = true;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void AddWindow()
        {
            var window = Application.ActiveWindow.Windows.Add("Export to Cypher", Visio.VisWindowStates.visWSVisible | Visio.VisWindowStates.visWSDockedBottom, Visio.)
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
