﻿#pragma checksum "C:\Users\Ena\Desktop\GGG\ethereal\ProjektniZadatak4ethereal\KinoProjekat\KinoProjekat\Kino\Views\Sala.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "80B1ED9D4BA282F643E5E5D8EE25CDEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinoProjekat.Kino.Views
{
    partial class Sala : 
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
                    this.s1 = (global::Windows.UI.Xaml.Controls.Border)(target);
                    #line 207 "..\..\..\..\Kino\Views\Sala.xaml"
                    ((global::Windows.UI.Xaml.Controls.Border)this.s1).PointerPressed += this.s1_PointerPressed;
                    #line default
                }
                break;
            case 2:
                {
                    this.s2 = (global::Windows.UI.Xaml.Controls.Border)(target);
                    #line 208 "..\..\..\..\Kino\Views\Sala.xaml"
                    ((global::Windows.UI.Xaml.Controls.Border)this.s2).PointerPressed += this.s2_PointerPressed;
                    #line default
                }
                break;
            case 3:
                {
                    this.Dalje = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 294 "..\..\..\..\Kino\Views\Sala.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Dalje).Click += this.Dalje_Click;
                    #line default
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

