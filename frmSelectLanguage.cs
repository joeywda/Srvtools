﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Srvtools
{
    public partial class frmSelectLanguage : Form
    {
        public frmSelectLanguage(SelectedLanguages language)
        {
            InitializeComponent();
            String message = SysMsg.GetSystemMessage(CliSysMegLag.GetClientLanguage(), "Srvtools", "MultiLanguage", "languages");
            this.checkedListBoxLanguages.Items.AddRange(message.Split(';'));
            Languages = language;
        }

        public SelectedLanguages Languages
        {
            get
            {
                int value = 0;
                int flag = 1;
                for (int i = 0; i < 8; i++)
                {
                    if (checkedListBoxLanguages.CheckedIndices.Contains(i))
                    {
                        value |= flag;
                    }
                    flag *= 2;
                }
                return (SelectedLanguages)value;
            }
            set 
            {
                int flag = 1;
                for (int i = 0; i < 8; i++)
                {
                    if (((int)value & flag) > 0)
                    {
                        this.checkedListBoxLanguages.SetItemChecked(i, true);
                    }
                    else
                    {
                        this.checkedListBoxLanguages.SetItemChecked(i, false);
                    }
                    flag *= 2;
                }
            }
        }
	
    }
}