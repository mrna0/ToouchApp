﻿#pragma checksum "c:\users\mustafa\documents\visual studio 2012\Projects\toouch\toouch\oyn.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F35F853DB8E6CF9A661F6B9B5C518B96"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace toouch {
    
    
    public partial class oyn : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock tb_arka;
        
        internal System.Windows.Controls.TextBlock txt_sayi;
        
        internal System.Windows.Controls.TextBlock tb_skor;
        
        internal System.Windows.Controls.TextBlock tb_zaman;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/toouch;component/oyn.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.tb_arka = ((System.Windows.Controls.TextBlock)(this.FindName("tb_arka")));
            this.txt_sayi = ((System.Windows.Controls.TextBlock)(this.FindName("txt_sayi")));
            this.tb_skor = ((System.Windows.Controls.TextBlock)(this.FindName("tb_skor")));
            this.tb_zaman = ((System.Windows.Controls.TextBlock)(this.FindName("tb_zaman")));
        }
    }
}

