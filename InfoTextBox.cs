﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Srvtools
{
    [ToolboxBitmap(typeof(InfoTextBox), "Resources.InfoTextBox.ico")]
    public partial class InfoTextBox : TextBox, IGetCurrentDataRow, IDisabled,IWriteValue
    {
        private Color oldBackColor;   //2016/7/29 JAY
        public InfoTextBox()
        {
            this.EnterEnable = true;
            this.Leave += new EventHandler(InfoTextBox_Leave);
            this.KeyDown += new KeyEventHandler(InfoTextBox_KeyDown);

            //2016/7/29 JAY
            this.Enter += new EventHandler(InfoTextBox_Enter);
            // end

            //poca
            this.Validating += delegate(Object sender, System.ComponentModel.CancelEventArgs e)
            {
                double value = 0;
                if (double.TryParse(this.Text, out value) == false) return;
                string tempStr = "";
                if (_MaximumVaule != -1)
                {
                    
                    if (value > _MaximumVaule)
                    {
                        e.Cancel = true;
                        tempStr = "超出範圍值\n 最大值: " + _MaximumVaule.ToString() + "\n ";
                        //if (_MinimumVaule != -1)
                        //{
                        //    tempStr += " 最小值: "+_MinimumVaule.ToString();
                        //}
                        MessageBox.Show(tempStr);
                        return;
                    }
                }
                if (_MinimumVaule == -1) return;

                if (value < _MinimumVaule)
                {
                    e.Cancel = true;
                    tempStr = "超出範圍值\n 最小值: " + _MinimumVaule.ToString() + "\n ";
                    //if (_MaximumVaule != -1)
                    //{
                    //    tempStr += " 最大值: " + _MaximumVaule.ToString();
                    //}
                    MessageBox.Show(tempStr);
                }

            };


            //poca


            // Add By Chenjian 2006-01-09
            this.KeyPress += delegate(object sender, KeyPressEventArgs e)
            {

                //poca

                if (_Integer_Press)
                {
                 
                       if (char.IsDigit(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar.Equals((Char)8))
                        {

                        }
                        else if (e.KeyChar.ToString() == "-" && this.Text == "")
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                           
                }

             

                if (_Numerical_Press)
                {
                    if (char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == "." || e.KeyChar.Equals((Char)8))
                    {
                        
                        if (e.KeyChar.ToString() == "." && this.Text.IndexOf(".") >= 0)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                                           }
                    else if (e.KeyChar.ToString() == "-" && this.Text == "")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                                 

                }

              
                //poca

                if (!this.ReadOnly)
                {
                    Binding TextBinding = this.DataBindings["Text"];
                    Binding SelectedValueBinding = this.DataBindings["SelectedValue"];
                    if (TextBinding != null)
                    {
                        InfoBindingSource bindingSource = TextBinding.DataSource as InfoBindingSource;
                        if (bindingSource != null)
                        {
                            if (!bindingSource.BeginEdit())
                            {
                                e.KeyChar = (char)0;
                                return;
                            }
                        }
                    }
                    if (SelectedValueBinding != null)
                    {
                        InfoBindingSource bindingSource = SelectedValueBinding.DataSource as InfoBindingSource;
                        if (bindingSource != null)
                        {
                            if (!bindingSource.BeginEdit())
                            {
                                e.KeyChar = (char)0;
                                return;
                            }
                        }
                    }
                }
            };
           this.DataBindings.CollectionChanged+=new CollectionChangeEventHandler(DataBindings_CollectionChanged);
            // End Add
        }

        void DataBindings_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Add && e.Element is Binding)
            {
                SetContextMenu(e.Element as Binding);
            }
        }

        public void SetContextMenu(Binding binding)
        {
            if (binding.DataSource is InfoBindingSource)
            {
                if (!(binding.DataSource as InfoBindingSource).AllowUpdate)
                {
                    this.ContextMenu = new ContextMenu();
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Binding TextBinding = this.DataBindings["Text"];
                Binding SelectedValueBinding = this.DataBindings["SelectedValue"];
                if (TextBinding != null)
                {
                    InfoBindingSource bindingSource = TextBinding.DataSource as InfoBindingSource;
                    if (bindingSource != null)
                    {
                        if (!bindingSource.AllowUpdate)
                        {
                            return;
                        }
                    }
                }
                if (SelectedValueBinding != null)
                {
                    InfoBindingSource bindingSource = SelectedValueBinding.DataSource as InfoBindingSource;
                    if (bindingSource != null)
                    {
                        if (!bindingSource.AllowUpdate)
                        {
                            return;
                        }
                    }
                }
                base.OnMouseClick(e);
            }
        }

        public DataRowView GetCurrentDataRow()
        {

            DataRowView drv = null;

            if (this.DataBindings["SelectedValue"] != null && this.DataBindings["SelectedValue"].DataSource != null)
            {
                if (this.DataBindings["SelectedValue"].DataSource is InfoDataSet)
                {
                    drv = (DataRowView)this.BindingContext[this.GetDataSource(), this.GetBindingMember()].Current;
                }
                else if (this.DataBindings["SelectedValue"].DataSource is InfoBindingSource)
                {
                    drv = (DataRowView)this.BindingContext[this.DataBindings["SelectedValue"].DataSource].Current;
                }
            }

            return drv;
        }

        public object GetDataSource()
        {
            object obj = new object();
            if (this.DataBindings["SelectedValue"] != null)
            {
                obj = this.DataBindings["SelectedValue"].DataSource;
                while (!(obj is InfoDataSet))
                {
                    if (obj is InfoBindingSource)
                    {
                        obj = ((InfoBindingSource)obj).DataSource;
                    }
                }
            }
            return obj;
        }

        public string GetBindingMember()
        {
            string strBindingMember = "";
            if (this.DataBindings["SelectedValue"].DataSource != null)
            {
                if (this.DataBindings["SelectedValue"].DataSource is InfoDataSet)
                {
                    strBindingMember = this.DataBindings["SelectedValue"].BindingMemberInfo.BindingPath;
                }
                else if (this.DataBindings["SelectedValue"].DataSource is InfoBindingSource)
                {
                    strBindingMember = ((InfoBindingSource)this.DataBindings["SelectedValue"].DataSource).DataMember;
                }
            }
            return strBindingMember;
        }

        public string GetBindingField()
        {
            string strBindingField = "";
            if (this.DataBindings["SelectedValue"].DataSource != null)
            {
                if (this.DataBindings["SelectedValue"].DataSource is InfoDataSet)
                {
                    strBindingField = this.DataBindings["SelectedValue"].BindingMemberInfo.BindingField;
                }
                else if (this.DataBindings["SelectedValue"].DataSource is InfoBindingSource)
                {
                    strBindingField = this.DataBindings["SelectedValue"].BindingMemberInfo.BindingField;
                }
            }
            return strBindingField;
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (BackColorDisabled != SystemColors.Control || ForeColorDisabled != SystemColors.ControlDark)
            {
                if (!this.Enabled)
                    this.SetStyle(ControlStyles.UserPaint, true);
                else
                    //this.SetStyle(ControlStyles.UserPaint, false);
                    this.Invalidate();
            }
            base.OnEnabledChanged(e);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush textBrush;
            StringFormat sf = new StringFormat();

            switch (this.TextAlign)
            {
                case HorizontalAlignment.Center:
                    sf.Alignment = StringAlignment.Center;
                    break;
                case HorizontalAlignment.Left:
                    sf.Alignment = StringAlignment.Near;
                    break;
                case HorizontalAlignment.Right:
                    sf.Alignment = StringAlignment.Far;
                    break;
            }

            RectangleF rDraw = RectangleF.FromLTRB(this.ClientRectangle.Left, this.ClientRectangle.Top, this.ClientRectangle.Right, this.ClientRectangle.Bottom);
            //rDraw.Inflate(0, 0);
            if (this.Enabled)
            {
                textBrush = new SolidBrush(this.ForeColor);
            }
            else
            {
                textBrush = new SolidBrush(this.ForeColorDisabled);
                SolidBrush backBrush = new SolidBrush(this.BackColorDisabled);
                e.Graphics.FillRectangle(backBrush, 0.0F, 0.0F, this.Width, this.Height);
            }
            e.Graphics.DrawString(this.Text, this.Font, textBrush, rDraw, sf);
        }

        internal bool fDisplayReal = false;
        private InfoRefVal _RefVal;
        [Category("Infolight"),
        Description("The RefVal which the control is bound to")]
        public InfoRefVal RefVal
        {
            get
            {
                return _RefVal;
            }
            set
            {
                _RefVal = value;

                if (null != _RefVal)
                {
                    _RefVal.SetToTxt(this);
                    if (this.DataBindings["Text"] != null)
                    {
                        Binding binding = new Binding("SelectedValue", this.DataBindings["Text"].DataSource, this.DataBindings["Text"].BindingMemberInfo.BindingMember);
                        if (this.DataBindings["SelectedValue"] != null)
                        {
                            this.DataBindings.Remove(this.DataBindings["SelectedValue"]);
                        }
                        this.DataBindings.Add(binding);
                        this.DataBindings.Remove(this.DataBindings["Text"]);
                    }
                }
                else
                {
                    if (this.DataBindings["SelectedValue"] != null)
                    {
                        Binding binding = new Binding("Text", this.DataBindings["SelectedValue"].DataSource, this.DataBindings["SelectedValue"].BindingMemberInfo.BindingMember);
                        if (this.DataBindings["Text"] != null)
                        {
                            this.DataBindings.Remove(this.DataBindings["Text"]);
                        }
                        this.DataBindings.Add(binding);
                        this.DataBindings.Remove(this.DataBindings["SelectedValue"]);
                    }
                }
            }
        }

        private string fSelectedValue = "";
        [Category("Infolight"),
        Description("The value of the member property specified by the ValueMember property when the control is bound to RefVal")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedValue
        {
            get
            {
                return fSelectedValue;
            }
            set
            {
                if (null != this.RefVal)
                {
                    if (fDisplayReal)
                    {
                        this.Text = value;
                    }
                    else
                    {
                        object[] obj = this.RefVal.CheckValid_And_ReturnDisplayValue(ref value, false, true);
                        this.Text = (string)obj[1];
                        object[] obj2 = this.RefVal.CheckValid_And_ReturnLinkValue(ref value);
                        if (this.FindForm() != null)
                        {
                            this.RefVal.DoLinkMatch(obj2[1].ToString(), (Form)this.FindForm());
                        }
                    }
                }
                fSelectedValue = value;
                if (this.DataBindings["SelectedValue"] != null)
                    this.DataBindings["SelectedValue"].DataSourceUpdateMode = DataSourceUpdateMode.Never;
            }
        }

        private bool _EnterEnable;
        [Category("Infolight"),
        Description("Indicate whether user can leave the control by pressing key of enter")]
        public bool EnterEnable
        {
            get { return _EnterEnable; }
            set { _EnterEnable = value; }
        }

        ////poca
        private bool _Numerical_Press = false;
        [Category("Infolight"),
        Description("the control by pressing key of Numerical")]
        public bool Numerical_Press
        {
            get { return _Numerical_Press; }
            set { _Numerical_Press = value; }
        }
        private bool _Integer_Press = false;
        [Category("Infolight"),
        Description("the control by pressing key of Integer")]
        public bool Integer_Press
        {
            get { return _Integer_Press; }
            set { _Integer_Press = value; }
        }

        private double _MaximumVaule = -1;
        [Category("Infolight"),
        Description("輸入數字最大值")]
        public double MaximumVaule
        {
            get { return _MaximumVaule; }
            set { _MaximumVaule = value; }
        }
        private double _MinimumVaule = -1;
        [Category("Infolight"),
         Description("輸入數字最小值")]
        public double MinimumVaule
        {
            get { return _MinimumVaule; }
            set { _MinimumVaule = value; }
        }


       ////poca

        private void InfoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!e.Control && !e.Alt)
                {
                    if (this.EnterEnable)
                    {
                        if (!e.Shift)
                        {
                            SendKeys.Send("{Tab}");
                        }
                        else
                        {
                            SendKeys.Send("+{Tab}");
                        }
                        e.SuppressKeyPress = true;
                    }
                }
                else
                {
                    if (this.Parent is InfoRefvalBox)
                    {
                        InfoRefvalBox refBox = (InfoRefvalBox)this.Parent;
                        foreach (Control ctrl in refBox.Controls)
                        {
                            if (ctrl is Button)
                            {
                                ((Button)ctrl).PerformClick();
                            }
                        }
                    }
                }
            }
        }

        //private Color mclrBackColorDisabled = Color.Gainsboro;
        //private Color mclrForeColorDisabled = SystemColors.ControlText;
        private Color mclrBackColorDisabled = SystemColors.Control;
        private Color mclrForeColorDisabled = SystemColors.ControlDark;

        [Category("Infolight")]
        [DefaultValue(typeof(Color), "Control")]
        public Color BackColorDisabled
        {
            get
            {
                return mclrBackColorDisabled;
            }
            set
            {
                mclrBackColorDisabled = value;
            }
        }

        [Category("Infolight")]
        [DefaultValue(typeof(Color), "ControlDark")]
        public Color ForeColorDisabled
        {
            get
            {
                return mclrForeColorDisabled;
            }
            set
            {
                mclrForeColorDisabled = value;
            }
        }

        //2016/7/29 JAY修改------
        private Color mclrEnterBackColor = System.Drawing.Color.White;

        [Category("Infolight")]
        [DefaultValue(typeof(Color), "ControlDark")]
        public Color EnterColor
        {
            get
            {
                return mclrEnterBackColor;
            }
            set
            {
                mclrEnterBackColor = value;
            }
        }
        //2016/7/29  End----------

        //2016/7/30 Leslie------
        private string mclrEnterBackGetFixed = "";
        [Category("Infolight")]
        [Browsable(true),Description("Get EnterBackcolor By Method")]
        public string EnterColorGetFixed
        {
            get
            {
                return mclrEnterBackGetFixed;
            }
            set
            {
                mclrEnterBackGetFixed = value;
            }
        }
        
        //2016/7/30 end------

        private string _LeaveText;
        [Browsable(false)]
        public string LeaveText
        {
            get
            {
                return _LeaveText;
            }
            set
            {
                _LeaveText = value;
            }
        }

        public void InfoTextBox_Leave(object sender, EventArgs e)
        {

            //poca
            if (_Integer_Press || _Numerical_Press)
            {
                if (this .Text =="")
                {
                    this.Text = "0";
                }
            }
            //poca


            if (this.DataBindings["Text"] != null)
            {
                string txt = this.Text;                
                this.DataBindings["Text"].ReadValue();
                if (txt != this.Text)
                {
                    this.Text = txt;
                    this.DataBindings["Text"].WriteValue();
                }
            }
            if (this.RefVal != null)
            {
                this.LeaveText = this.Text;                
                //if (this.DataBindings["SelectedValue"] != null)
                //{
                //    this.DataBindings["SelectedValue"].WriteValue();
                //}
            }

            this.BackColor = oldBackColor; //Color.LightGray;  //JAY
        }

        //2016/7/29 新增
        public void InfoTextBox_Enter(object sender, EventArgs e)
        {

            oldBackColor = this.BackColor;

            if (this.DataBindings.Control.Text != null) //2016/7/30 Leslie 原寫法會有問題 this.DataBindings["Text"] != null
            {
                //oldBackColor = this.BackColor;
                this.BackColor = EnterColor; //Color.LightGray;  //JAY

            }
            if (this.RefVal != null)
            {
                //oldBackColor = this.BackColor;
                this.BackColor = EnterColor;

            }

            if (EnterColorGetFixed != null && EnterColorGetFixed != "")  //取Method
            {                
                Color getBackColorFixed = GetValue(EnterColorGetFixed);
                this.BackColor = getBackColorFixed;
            }
        }

        //2016.7.30 Leslie
        public Color GetValue(string value)
        {
            if (RefVal != null)
            {
                return (Color)CliUtils.GetValue(this.EnterColorGetFixed, RefVal.OwnerComp);
            }
            else
            {
                //判斷為Form才抓Method，否則有錯誤
                Control Owner = this.Parent;
                while (!(Owner is InfoForm))
                {
                    Owner = Owner.Parent;
                }
                return (Color)CliUtils.GetValue(this.EnterColorGetFixed, Owner);
            }

        }

        //2016.7.30 Leslie=========

        #region IWriteValue Members

        public void WriteValue()
        {
            if (this.DataBindings["Text"] != null)
            {
                this.DataBindings["Text"].WriteValue();
            }
        }

        public void WriteValue(object value)
        {
            this.Text = value.ToString();
            WriteValue();
        }

        #endregion
    }
}
