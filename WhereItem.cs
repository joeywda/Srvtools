﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace Srvtools
{
    public enum condition
    {
        Equals,
        likeBeginWithValue,
        likeWithValue,
        GreaterThan,
        LessThan,
        NotEqual,
        GreaterOrEquals,
        LessOrEquals,
        In, //---2017/8/3 Leslie新增Refval-whereitem in功能
        NotIn //2019/11/28 Leslie新增Refval-whereitem NotIn功能
    }

    public class WhereItem : InfoOwnerCollectionItem, IGetValues
    {
        public WhereItem()
            : this("", condition.Equals, "", true)
        {
        }

        public WhereItem(string fieldName, condition con, string value, bool active)
        {
            _FieldName = fieldName;
            _Condition = con;
            _Value = value;
            _Active = active;
        }

        private string _FieldName;
        [Editor(typeof(FieldNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string FieldName
        {
            get
            {
                return _FieldName;
            }
            set
            {
                _FieldName = value;
            }
        }

        private condition _Condition;
        public condition Condition
        {
            get
            {
                return _Condition;
            }
            set
            {
                _Condition = value;
            }
        }

        private string _Value;
        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        //2019/11/28 Leslie:新增whereitem是否啟用
        private bool _Active = true;
        public bool Active
        {
            get
            {
                return _Active;
            }
            set
            {
                _Active = value;
            }
        }

        public override string Name
        {
            get { return _FieldName; }
            set { _FieldName = value; }
        }

        public override string ToString()
        {
            return _FieldName;
        }

        public string GetSign()
        {
            if (this.Condition == condition.Equals)
            {
                return "=";
            }
            else if (this.Condition == condition.GreaterOrEquals)
            {
                return ">=";
            }
            else if (this.Condition == condition.GreaterThan)
            {
                return ">";
            }
            else if (this.Condition == condition.LessOrEquals)
            {
                return "<=";
            }
            else if (this.Condition == condition.LessThan)
            {
                return "<";
            }
            else if (this.Condition == condition.NotEqual)
            {
                return "<>";
            }
            else if (this.Condition == condition.likeBeginWithValue)
            {
                return "like begin with value";
            }
            else if (this.Condition == condition.likeWithValue)
            {
                return "like with value";
            }
            else if (this.Condition == condition.In) //---2017/8/3 Leslie新增Refval-whereitem in功能
                return "in";
            else if (this.Condition == condition.NotIn) //2019/11/28 Leslie新增Refval-whereitem NotIn功能
                return "not in";
            else
            {
                return null;
            }
        }

        #region IGetValues
        public string[] GetValues(string sKind)
        {
            string[] retList = null;
            if (string.Compare(sKind, "fieldname", true) == 0)//IgnoreCase
            {
                if (this.Owner is InfoRefVal)
                {
                    if (((InfoRefVal)this.Owner).SelectCommand == null || ((InfoRefVal)this.Owner).SelectCommand == "")
                    {
                        if (((InfoRefVal)this.Owner).DataSource != null)
                        {
                            InfoDataSet infoDs = (InfoDataSet)((InfoRefVal)this.Owner).GetDataSource();
                            string strTabName = ((InfoRefVal)this.Owner).GetDataMember();
                            int i = infoDs.GetRealDataSet().Tables[strTabName].Columns.Count;
                            string[] arrItems = new string[i];
                            for (int j = 0; j < i; j++)
                            {
                                arrItems[j] = infoDs.GetRealDataSet().Tables[strTabName].Columns[j].ColumnName;
                            }
                            retList = arrItems;
                        }
                    }
                    else
                    {
                        if (((InfoRefVal)this.Owner).InnerBs != null && ((InfoRefVal)this.Owner).InnerBs.DataSource != null
                            && ((InfoDataSet)((InfoRefVal)this.Owner).InnerBs.DataSource).RealDataSet.Tables.Count > 0)
                        {
                            DataColumnCollection dcc = ((InfoDataSet)((InfoRefVal)this.Owner).InnerBs.DataSource).RealDataSet.Tables[0].Columns;
                            int i = dcc.Count;
                            string[] arrItems = new string[i];
                            for (int j = 0; j < i; j++)
                            {
                                arrItems[j] = dcc[j].ColumnName;
                            }
                            retList = arrItems;
                        }
                    }
                }
            }
            return retList;
        }
        #endregion
    }
}
