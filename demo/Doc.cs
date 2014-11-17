﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace demo
{
    public partial class Doc : DockContent
    {
        public Doc()
        {
            InitializeComponent();
        }

        private string m_fileName = string.Empty;
        public string FileName
        {
            get { return m_fileName; }
            set
            {
                if (value != string.Empty)
                {
                    Stream s = new FileStream(value, FileMode.Open);

                    FileInfo efInfo = new FileInfo(value);

                    string fext = efInfo.Extension.ToUpper();

                    //if (fext.Equals(".RTF"))
                    //    richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText);
                    //else
                    //    richTextBox1.LoadFile(s, RichTextBoxStreamType.PlainText);
                    s.Close();
                }

                m_fileName = value;
                this.ToolTipText = value;
            }
        }
    }

    
}