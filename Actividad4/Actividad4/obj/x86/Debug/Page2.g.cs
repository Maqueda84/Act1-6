﻿#pragma checksum "C:\Users\BRM\OneDrive - UNIVERSIDAD NACIONAL AUTÓNOMA DE MÉXICO\SEMESTRE 7\06-Programación de Dispositivos Móviles\Unam\Actividad4\Actividad4\Page2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84C352619B64F4F5E864E4E5719A5FA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Actividad4
{
    partial class Page2 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 12 "..\..\..\Page2.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element1).SelectionChanged += this.TextBlock_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.ValueTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

