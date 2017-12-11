using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections;
using System.IO;

namespace Srvtools
{
    public partial class frmAgent : InfoForm
    {
        public frmAgent()
        {
            InitializeComponent();
        }

        private string _roleId = "";
        public string RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        private string _roleName = "";
        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            SYS_LANGUAGE language = CliUtils.fClientLang;
            try
            {
                string[] captions = SysMsg.GetSystemMessage(language, "Srvtools", "frmAgent", "UITexts").Split(',');
                this.colAgent.HeaderText = captions[0];
                this.colFlowDesc.HeaderText = captions[1];
                this.colSDate.HeaderText = captions[2];
                this.colSTime.HeaderText = captions[3];
                this.colEDate.HeaderText = captions[4];
                this.colETime.HeaderText = captions[5];
                this.colParAgent.HeaderText = captions[6];
                this.colRemark.HeaderText = captions[7];
                this.lblRoleId.Text = captions[8];
                this.lblRoleName.Text = captions[9];
            }
            catch { }

            string flowDefPath = string.Format("{0}\\WorkFlow\\", EEPRegistry.Server);
            DirectoryInfo dir = new DirectoryInfo(flowDefPath);
            if (dir.Exists)
            {
                object[] obj = CliUtils.CallFLMethod("GetFLDescriptions", new object[] { flowDefPath });
                if (Convert.ToInt16(obj[0]) == 0)
                {
                    ArrayList flDescs = (ArrayList)obj[1];
                    flDescs.Insert(0, "*");
                    this.colFlowDesc.DataSource = flDescs;
                }
                this.txtRoleId.Text = this._roleId;
                this.txtRoleName.Text = this._roleName;
            }
            this.dsRoleAgent.SetWhere("role_id='" + _roleId + "'");
        }

        public string DefRoleId()
        {
            return this.RoleId;
        }

        void navRoleAgent_BeforeItemClick(object sender, BeforeItemClickEventArgs e)
        {
            if (e.ItemName == "Apply" || e.ItemName == "OK")
            {
                if (bsRoleAgent.Current != null)
                {
                    (bsRoleAgent.Current as DataRowView).EndEdit();
                }
                DataTable table = dsRoleAgent.RealDataSet.Tables[0].GetChanges();
                if (table != null)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        DataRow row = table.Rows[i];
                        if (row.RowState != DataRowState.Deleted)
                        {
                            string start = row["START_DATE"].ToString() + row["START_TIME"].ToString();

                            string end = row["END_DATE"].ToString() + row["END_TIME"].ToString();
                            if (start.CompareTo(end) > 0)
                            {
                                MessageBox.Show("START_DATE can not larger than END_DATE.");
                                e.Cancel = true;
                            }
                        }
                    }
                }
            }
        }
    }
}