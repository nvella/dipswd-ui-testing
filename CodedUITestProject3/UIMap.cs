namespace CodedUITestProject3
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;



    public partial class UIMap
    {
        public UIMap() {
            // Test refactoring - search for new button with name buttonA
            this.UIMainWindowWindow2.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }

        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void ModifiedRecordedMethod1()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow2.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow2.UICheckBoxCheckBox;
            WinTitleBar uIMainWindowTitleBar = this.UIMainWindowWindow3.UIMainWindowTitleBar;
            #endregion

            // Launch 'C:\proj\dipswd-ui-testing\DipSWDUITesting\bin\Debug\DipSWDUITesting.exe'
            ApplicationUnderTest uIMainWindowWindow2 = ApplicationUnderTest.Launch(this.RecordedMethod1Params.UIMainWindowWindow2ExePath, this.RecordedMethod1Params.UIMainWindowWindow2AlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(63, 16));

            // Wait for checkbox to become enabled
            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.RecordedMethod1Params.UICheckBoxCheckBoxChecked;

            // Click 'MainWindow' title bar
            Mouse.Click(uIMainWindowTitleBar, new Point(758, 15));
        }

        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }

        private RecordedMethod1Params mRecordedMethod1Params;
    }
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class RecordedMethod1Params
    {

        #region Fields
        /// <summary>
        /// Launch 'C:\proj\dipswd-ui-testing\DipSWDUITesting\bin\Debug\DipSWDUITesting.exe'
        /// </summary>
        public string UIMainWindowWindow2ExePath = "C:\\proj\\dipswd-ui-testing\\DipSWDUITesting\\bin\\Debug\\DipSWDUITesting.exe";

        /// <summary>
        /// Launch 'C:\proj\dipswd-ui-testing\DipSWDUITesting\bin\Debug\DipSWDUITesting.exe'
        /// </summary>
        public string UIMainWindowWindow2AlternateExePath = "C:\\proj\\dipswd-ui-testing\\DipSWDUITesting\\bin\\Debug\\DipSWDUITesting.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
