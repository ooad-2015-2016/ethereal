﻿#pragma checksum "C:\Users\User\Desktop\New folder (2)\ethereal\ProjektniZadatak4ethereal\KinoProjekat\KinoProjekat\Kino\Views\Pocetna.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5F9B59A4192086ADC14FFDCE1F3428A5"
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
    partial class Pocetna : 
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
                    this.textBlockNaslov = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.textBlockAutori = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.textBlockOpis1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.textBlockOpis2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.textBlockOpis3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.buttonRepertoar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\..\Kino\Views\Pocetna.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonRepertoar).Click += this.buttonRepertoar_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.buttonRezervacija = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\..\Kino\Views\Pocetna.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonRezervacija).Click += this.buttonRezervacija_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.buttonOtkazi = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\..\Kino\Views\Pocetna.xaml"
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

