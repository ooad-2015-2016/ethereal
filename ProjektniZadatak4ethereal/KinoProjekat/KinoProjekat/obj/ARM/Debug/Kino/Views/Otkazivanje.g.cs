﻿#pragma checksum "C:\Users\User\Desktop\HEJJJ\ethereal\ProjektniZadatak4ethereal\KinoProjekat\KinoProjekat\Kino\Views\Otkazivanje.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AEA93C6730FE5A155C4CAAAA8C8A7891"
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
    partial class Otkazivanje : 
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
                    this.buttonNazad = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\..\Kino\Views\Otkazivanje.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonNazad).Click += this.buttonNazad_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.textBoxIme = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 36 "..\..\..\..\Kino\Views\Otkazivanje.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBoxIme).TextChanged += this.textBoxIme_TextChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.buttonOtkazi = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\..\Kino\Views\Otkazivanje.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonOtkazi).Click += this.buttonOtkazi_Click;
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

