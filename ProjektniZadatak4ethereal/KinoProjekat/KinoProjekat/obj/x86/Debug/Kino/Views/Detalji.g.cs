﻿#pragma checksum "C:\Users\User\Desktop\New folder (2)\ethereal\ProjektniZadatak4ethereal\KinoProjekat\KinoProjekat\Kino\Views\Detalji.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "18D1E9315CBD67D2F3B2EB86112F67AF"
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
    partial class Detalji : 
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
                    this.listViewTermini = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 2:
                {
                    this.buttonRezervisi = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 49 "..\..\..\..\Kino\Views\Detalji.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonRezervisi).Click += this.buttonRezervisi_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.buttonNazad = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\..\Kino\Views\Detalji.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonNazad).Click += this.buttonNazad_Click;
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

