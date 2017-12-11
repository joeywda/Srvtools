using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Srvtools
{
    [ToolboxBitmap(typeof(InfoMaskedTextBox), "Resources.InfoMaskedTextBox.ico")]
    public partial class InfoMaskedTextBox : MaskedTextBox, IWriteValue
    {
        private Color oldBackColor;   //2016/7/29 JAY

        public InfoMaskedTextBox()
        {
            InitializeComponent();
            //2016/7/29 JAY            
            this.Leave += new EventHandler(InfoMaskedTextBox_Leave);
            this.Enter += new EventHandler(InfoMaskedTextBox_Enter);
            // end
            this.KeyPress += delegate(object sender, KeyPressEventArgs e)
            {
                if (!this.ReadOnly)
                {
                    Binding TextBinding = this.DataBindings["Text"];
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
                }
            };
        }


        public InfoMaskedTextBox(IContainer container):this()
        {
            container.Add(this);

            //InitializeComponent();
        }

        //2016.7.30 Leslie=============
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

        //===End========

        private bool _enterEnable;
        public bool EnterEnable
        {
            get { return _enterEnable; }
            set { _enterEnable = value; }
        }

        //2016/7/29 修改------
        private Color mclrEnterBackColor = System.Drawing.Color.LightGray;
        [Category("TTRI")]
        [Browsable(true)]
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
        //2016/7/29 ----------

        //2016/7/30 Leslie------
        private Color mclrBackColorDisabled = SystemColors.Control;
        private Color mclrForeColorDisabled = SystemColors.ControlDark;

        [Category("TTRI")]
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

        [Category("TTRI")]
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
        
        private string mclrEnterBackGetFixed = "";
        [Category("TTRI")]
        [Browsable(true)]
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

        private InfoDateTimeBox _datetimebox;
        [Browsable(false)]
        public InfoDateTimeBox DatetimeBox
        {
            get
            {
                return _datetimebox;
            }
            set
            {
                _datetimebox = value;
            }
        }

        //2016/7/30 end------

        private void InfoMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.EnterEnable == true)
            {
                SendKeys.Send("{Tab}");
            }
        }

        //2016.7.30 Leslie
        public Color GetValue(string value)
        {
            if (DatetimeBox != null)
            {
                //判斷為Form才抓Method，否則有錯誤
                Control Owner = DatetimeBox.Parent;
                while (!(Owner is InfoForm))
                {
                    Owner = Owner.Parent;
                }
                return (Color)CliUtils.GetValue(this.EnterColorGetFixed, Owner);
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

        //2016.7.29 Leslie
        private void InfoMaskedTextBox_Enter(object sender, EventArgs e)
        {

            if (this.DataBindings["Text"] != null)
            {
                oldBackColor = this.BackColor;
                this.BackColor = EnterColor; //Color.LightGray;  //JAY

            }

            //2016.7.30 Leslie
            if (this.DataBindings.Control.Text != null)
            {
                oldBackColor = this.BackColor;

                if (EnterColorGetFixed != null && EnterColorGetFixed != "")  //取Method
                {
                    if (this.Parent is InfoDateTimeBox)
                    {
                        DatetimeBox = (InfoDateTimeBox)this.Parent;
                    }
                    Color getBackColorFixed = GetValue(EnterColorGetFixed);
                    this.BackColor = getBackColorFixed;
                }
                else
                {
                    this.BackColor = EnterColor; //Color.LightGray;  //JAY
                }
             
            }
         
        }

        public void InfoMaskedTextBox_Leave(object sender, EventArgs e)
        {

            if (this.DataBindings["Text"] != null)
            {
                string txt = this.Text;
                this.BackColor = oldBackColor; //Color.LightGray;  //JAY
                this.DataBindings["Text"].ReadValue();
                if (txt != this.Text)
                {
                    this.Text = txt;
                    this.DataBindings["Text"].WriteValue();
                }
            }

            //2016.7.30 Leslie
            if(this.DataBindings.Control.Text !=null)
            {
                this.BackColor = oldBackColor; //Color.LightGray;  //JAY
            }
        }

        //End  Leslie

        #region IWriteValue Members

        public void WriteValue(object value)
        {
            this.Text = value.ToString();
            WriteValue();
        }

        public void WriteValue()
        {
            if (this.DataBindings["Text"] != null)
            {
                this.DataBindings["Text"].WriteValue();
            }
        }

        #endregion
    }
}
