﻿#pragma checksum "..\..\..\Views\WindowAddGuest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8F804508FECC4308BB497D5B01B241A684DF5AAB0E74C74332A1064F94917B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Hotel.Views;
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


namespace Hotel.Views {
    
    
    /// <summary>
    /// WindowAddGuest
    /// </summary>
    public partial class WindowAddGuest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 75 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxDateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFullName;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPassportData;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockFullName;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockDateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\WindowAddGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockPassportData;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hotel;component/views/windowaddguest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\WindowAddGuest.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 70 "..\..\..\Views\WindowAddGuest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxDateOfBirth = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBoxFullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textBoxPassportData = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBoxPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textBlockFullName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.textBlockDateOfBirth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.textBlockPhoneNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.textBlockPassportData = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

