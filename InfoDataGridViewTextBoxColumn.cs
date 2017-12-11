using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Srvtools
{
    //2014/10/09 ttri
    public class InfoDataGridViewTextBoxColumn: DataGridViewTextBoxColumn
    {
        public InfoDataGridViewTextBoxColumn()
            : base()
        {
            base.CellTemplate = new InfoDataGridViewTextBoxCell();   
        }

        [Category("Appearance")]
        public DataGridViewCellStyle HeaderCellStyle
        {
            get { return this.HeaderCell.Style; }
            set { this.HeaderCell.Style = value; }
        }


        [Category("ttri")]
        public bool Integer_Press 
        {
            get {
                return (this.CellTemplate as InfoDataGridViewTextBoxCell).Integer_Press;
            }
            set {

                InfoDataGridViewTextBoxCell template = this.CellTemplate as InfoDataGridViewTextBoxCell;
                if (template != null)
                {
                    template.Integer_Press = value;
                }
                if (base.DataGridView != null)
                {
                    int rowCount = base.DataGridView.Rows.Count;
                    DataGridViewRowCollection rowCollection = base.DataGridView.Rows;
                    for (int index = 0; index < rowCount; ++index)
                    {
                        DataGridViewRow row = rowCollection.SharedRow(index);
                        InfoDataGridViewTextBoxCell cell =
                            row.Cells[base.Index] as InfoDataGridViewTextBoxCell;
                        if (cell != null)
                        {
                            cell.Integer_Press = value;
                        }
                    }                
                }

            }
        }
   
        [Category("ttri")]
        public double MaximumValue
        {
            get
            {
                return (this.CellTemplate as InfoDataGridViewTextBoxCell).MaximumValue;
            }
            set
            {
                InfoDataGridViewTextBoxCell template = this.CellTemplate as InfoDataGridViewTextBoxCell;
                if (template != null)
                {
                    template.MaximumValue = value;
                }
                if (base.DataGridView != null)
                {
                    int rowCount = base.DataGridView.Rows.Count;
                    DataGridViewRowCollection rowCollection = base.DataGridView.Rows;
                    for (int index = 0; index < rowCount; ++index)
                    {
                        DataGridViewRow row = rowCollection.SharedRow(index);
                        InfoDataGridViewTextBoxCell cell =row.Cells[base.Index] as InfoDataGridViewTextBoxCell;
                        if (cell != null)
                        {
                            cell.MaximumValue = value;
                        }
                    }
                }

            }
        }

        [Category("ttri")]
        public double MinimumValue
        {
            get
            {
                return (this.CellTemplate as InfoDataGridViewTextBoxCell).MinimumValue;
            }
            set
            {
                InfoDataGridViewTextBoxCell template = this.CellTemplate as InfoDataGridViewTextBoxCell;
                if (template != null)
                {
                    template.MinimumValue = value;
                }
                if (base.DataGridView != null)
                {
                    int rowCount = base.DataGridView.Rows.Count;
                    DataGridViewRowCollection rowCollection = base.DataGridView.Rows;
                    for (int index = 0; index < rowCount; ++index)
                    {
                        DataGridViewRow row = rowCollection.SharedRow(index);
                        InfoDataGridViewTextBoxCell cell =row.Cells[base.Index] as InfoDataGridViewTextBoxCell;
                        if (cell != null)
                        {
                            cell.MinimumValue = value;
                        }
                    }
                }

            }
        }

        [Category("ttri")]
        public bool Numerical_Press
        {
            get
            {
                return (this.CellTemplate as InfoDataGridViewTextBoxCell).Numerical_Press;
            }
            set
            {
         

                InfoDataGridViewTextBoxCell template = this.CellTemplate as InfoDataGridViewTextBoxCell;
                if (template != null)
                {
                    template.Numerical_Press = value;
                }
                if (base.DataGridView != null)
                {
                    int rowCount = base.DataGridView.Rows.Count;
                    DataGridViewRowCollection rowCollection = base.DataGridView.Rows;
                    for (int index = 0; index < rowCount; ++index)
                    {
                        DataGridViewRow row = rowCollection.SharedRow(index);
                        InfoDataGridViewTextBoxCell cell =row.Cells[base.Index] as InfoDataGridViewTextBoxCell;
                        if (cell != null)
                        {
                            cell.Numerical_Press = value;
                        }
                    }
                }

            }
        }

        [Category("ttri")]
        public CharacterCasing CharacterCasing
        {
            get
            {
                return (this.CellTemplate as InfoDataGridViewTextBoxCell).CharacterCasing;
            }
            set
            {
                InfoDataGridViewTextBoxCell template = this.CellTemplate as InfoDataGridViewTextBoxCell;
                if (template != null)
                {
                    template.CharacterCasing = value;
                }
                if (base.DataGridView != null)
                {
                    int rowCount = base.DataGridView.Rows.Count;
                    DataGridViewRowCollection rowCollection = base.DataGridView.Rows;
                    for (int index = 0; index < rowCount; ++index)
                    {
                        DataGridViewRow row = rowCollection.SharedRow(index);
                        InfoDataGridViewTextBoxCell cell =row.Cells[base.Index] as InfoDataGridViewTextBoxCell;
                        if (cell != null)
                        {
                            cell.CharacterCasing = value;
                        }
                    }
                }

            }
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value == null || value is InfoDataGridViewTextBoxCell)
                {
                    base.CellTemplate = value;
                }
                else
                {
                    throw new Exception("Must be a InfoDataGridViewTextBoxCell");
                }
            }
        }
        public class InfoDataGridViewTextBoxCell : DataGridViewTextBoxCell
        {
            public override object Clone()
            {
                InfoDataGridViewTextBoxCell cell = base.Clone() as InfoDataGridViewTextBoxCell;
              
                cell.Integer_Press = this._Integer_Press;
                cell.Numerical_Press = this._Numerical_Press;
                cell.MaximumValue = this._MaximumValue;
                cell.MinimumValue = this._MinimumValue;
                cell.CharacterCasing = this._CharacterCasing;                
                return cell;
            }

            bool _Integer_Press = false;
            public bool Integer_Press
            {
                get
                {
                    return _Integer_Press;
                }
                set
                {
                    _Integer_Press = value;
                }
            }
            bool _Numerical_Press = false;
            public bool Numerical_Press
            {
                get
                {
                    return _Numerical_Press;
                }
                set
                {
                    _Numerical_Press = value;
                }
            }

            double _MaximumValue = -1;
            public double MaximumValue
            {
                get
                {
                    return _MaximumValue;
                }
                set
                {
                    _MaximumValue = value;
                }
            }
            double _MinimumValue = -1;
            public double MinimumValue
            {
                get
                {
                    return _MinimumValue;
                }
                set
                {
                    _MinimumValue = value;
                }
            }
            CharacterCasing _CharacterCasing;
            public CharacterCasing CharacterCasing
            {
                get
                {
                    return _CharacterCasing;
                }
                set
                {
                    _CharacterCasing = value;
                }
            }
                       
            public override Type EditType
            {
                get
                {
                    return typeof(InfoDataGridViewTextBoxEditingControl);
                }
            }

         
            public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
                InfoDataGridViewTextBoxEditingControl ctrl = (InfoDataGridViewTextBoxEditingControl)this.DataGridView.EditingControl;
                ctrl._CharacterCasing = this._CharacterCasing;
                ctrl._Integer_Press = this._Integer_Press;
                ctrl._Numerical_Press = this._Numerical_Press;
                ctrl._MinimumValue = this._MinimumValue;
                ctrl._MaximumValue = this._MaximumValue;
            }
        

        }
        [ToolboxItem(false)]
        public class InfoDataGridViewTextBoxEditingControl : DataGridViewTextBoxEditingControl 
        {

            public CharacterCasing _CharacterCasing;
            public bool _Integer_Press = false;
            public bool _Numerical_Press = false;
            public double _MaximumValue = -1;
            public double _MinimumValue = -1;

            public InfoDataGridViewTextBoxEditingControl() :base()
            {
            
              this.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
              this.Validating += new CancelEventHandler(dataGridViewTextBox_Validating);
              this.Leave += new EventHandler(dataGridViewTextBox_Leave);
            }

            private void dataGridViewTextBox_Leave(object sender, EventArgs e)
            {
             
                InfoDataGridViewTextBoxEditingControl s = (InfoDataGridViewTextBoxEditingControl)sender;
                string thisText = s.Text;
                if (_CharacterCasing == CharacterCasing.Upper)
                {
                    s.Text = thisText.ToUpper();
                }
                else if (_CharacterCasing == CharacterCasing.Lower)
                {
                    s.Text = thisText.ToLower();
                }
                if (_Integer_Press || _Numerical_Press)
                {
                    if (this.Text == "")
                    {
                        this.Text = "0";
                    }
                }
            }

            private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (_Integer_Press)
                {
                    if (char.IsDigit(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar.Equals((Char)8))
                    { }
                    else if (e.KeyChar.ToString() == "-" && ((DataGridViewTextBoxEditingControl)sender).Text == "")
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
                        if (e.KeyChar.ToString() == "." && ((DataGridViewTextBoxEditingControl)sender).Text.IndexOf(".") >= 0)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                    else if (e.KeyChar.ToString() == "-" && ((DataGridViewTextBoxEditingControl)sender).Text == "")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

                }

            }
            private void dataGridViewTextBox_Validating(Object sender, System.ComponentModel.CancelEventArgs e)
            {
                double value = 0;
                if (double.TryParse(((DataGridViewTextBoxEditingControl)sender).Text, out value) == false) return;
                string tempStr = "";
                if (_MaximumValue != -1)
                {

                    if (value > _MaximumValue)
                    {
                        e.Cancel = true;
                        tempStr = "禬絛瞅\n 程: " + _MaximumValue.ToString() + "\n ";
                        //if (_MinimumVaule != -1)
                        //{
                        //    tempStr += " 程: "+_MinimumVaule.ToString();
                        //}
                        MessageBox.Show(tempStr);
                    }
                }

                           
                if (_MinimumValue == -1) return;

                if (value < _MinimumValue)
                {
                    e.Cancel = true;
                    tempStr = "禬絛瞅\n 程: " + _MinimumValue.ToString() + "\n ";
                    //if (_MaximumVaule != -1)
                    //{
                    //    tempStr += " 程: " + _MaximumVaule.ToString();
                    //}
                    MessageBox.Show(tempStr);
                }

            }
        }

    }
}
