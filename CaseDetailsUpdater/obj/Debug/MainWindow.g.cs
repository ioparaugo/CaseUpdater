// Updated by XamlIntelliSenseFileGenerator 9/28/2022 5:30:29 PM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FCD4FDD6CAC3BA3B8A187476227575BB2F471E19CC6338AB5A1B754C29DDE905"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CaseDetailsUpdater;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CaseDetailsUpdater
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button executeqrybtn;

#line default
#line hidden


#line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label connectstatuslbl;

#line default
#line hidden


#line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button crmConnectbtn;

#line default
#line hidden


#line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fetchqry;

#line default
#line hidden


#line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label statuslbl;

#line default
#line hidden


#line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox qryselectorbox;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CaseDetailsUpdater;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.executeqrybtn = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\MainWindow.xaml"
                    this.executeqrybtn.Click += new System.Windows.RoutedEventHandler(this.executeqrybtn_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.connectstatuslbl = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.crmConnectbtn = ((System.Windows.Controls.Button)(target));

#line 17 "..\..\MainWindow.xaml"
                    this.crmConnectbtn.Click += new System.Windows.RoutedEventHandler(this.crmConnectbtn_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.fetchqry = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.cityGuid = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.statuslbl = ((System.Windows.Controls.Label)(target));
                    return;
                case 7:
                    this.qryselectorbox = ((System.Windows.Controls.ComboBox)(target));

#line 23 "..\..\MainWindow.xaml"
                    this.qryselectorbox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.qryselectorbox_SelectionChanged);

#line default
#line hidden

#line 23 "..\..\MainWindow.xaml"
                    this.qryselectorbox.Initialized += new System.EventHandler(this.qryselectorbox_Initialized);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox wrkflowGuid;
    }
}

