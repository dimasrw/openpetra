//
// DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
//
// @Authors:
//       timop
//
// Copyright 2004-2012 by OM International
//
// This file is part of OpenPetra.org.
//
// OpenPetra.org is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// OpenPetra.org is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with OpenPetra.org.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using Ict.Common;
using Ict.Common.Verification;

using Ict.Petra.Client.App.Core.RemoteObjects;
using Ict.Petra.Client.CommonForms;
using Ict.Petra.Client.MFinance.Logic;
using Ict.Petra.Shared.Security;
using Ict.Petra.Client.MCommon;

namespace Ict.Petra.Client.MFinance.Gui.Setup
{
    public partial class TFrmLinkPartnerCostCentreDialog
    {
        private Int32 FLedgerNumber;
        private Boolean FChangedState = false;
        private DataTable FPartnerCostCentreTbl;
        private DataTable FLocalCostCentres;
        private DataView FLinkedView;
        private DataView FUnlinkedView;

        const int CC_CODE_ONLY = 1;
        const int REPORTS_TO_ONLY = 2;

        /// <summary>
        /// Setup the Partner - CostCentre links of this ledger
        /// </summary>
        public Int32 LedgerNumber
        {
            set
            {
                FLedgerNumber = value;
                //0 last argument means for all partners, otherwise supply a specific partner key
            }
        }

        private void RunOnceOnActivationManual()
        {
            TRemote.MFinance.Setup.WebConnectors.LoadCostCentrePartnerLinks(FLedgerNumber, 0, out FPartnerCostCentreTbl);
            FLocalCostCentres = TRemote.MFinance.Setup.WebConnectors.LoadLocalCostCentres(FLedgerNumber);

            //Setup Cost Centre combo
            TFinanceControls.InitialiseLocalCostCentreList(ref cmbCostCentre, FLedgerNumber, false, FLocalCostCentres);
            cmbCostCentre.Width = 300;
            cmbCostCentre.AttachedLabel.Width = 150;

            //Setup Reports To combo
            TFinanceControls.InitialiseLocalCostCentreList(ref cmbReportsTo, FLedgerNumber, true, FLocalCostCentres);
            cmbReportsTo.Width = 300;
            cmbReportsTo.AttachedLabel.Width = 150;

            lblInvisible.Visible = false;

            FLinkedView = new DataView(FPartnerCostCentreTbl);
            FLinkedView.RowFilter = "IsLinked <> '0'";
            FLinkedView.AllowNew = false;

            FUnlinkedView = new DataView(FPartnerCostCentreTbl);
            FUnlinkedView.RowFilter = "IsLinked = '0'";
            FUnlinkedView.AllowNew = false;

            grdLinkedCCs.DataSource = new DevAge.ComponentModel.BoundDataView(FLinkedView);
            grdUnlinkedCCs.DataSource = new DevAge.ComponentModel.BoundDataView(FUnlinkedView);

            grdLinkedCCs.Columns.Clear();
            grdLinkedCCs.AddTextColumn("Partner Name", FPartnerCostCentreTbl.Columns["ShortName"], 240);
            grdLinkedCCs.AddTextColumn("Partner Key", FPartnerCostCentreTbl.Columns["PartnerKey"], 90);
            grdLinkedCCs.AddTextColumn("Cost Centre", FPartnerCostCentreTbl.Columns["IsLinked"], 90);
            grdLinkedCCs.AddTextColumn("Reports To", FPartnerCostCentreTbl.Columns["ReportsTo"], 90);
            grdUnlinkedCCs.Enter += new EventHandler(grdLinkedCCs_Enter);
            grdLinkedCCs.Selection.FocusRowEntered += new SourceGrid.RowEventHandler(grdLinkedCCs_Click);

            grdUnlinkedCCs.Columns.Clear();
            grdUnlinkedCCs.AddTextColumn("Partner Name", FPartnerCostCentreTbl.Columns["ShortName"], 240);
            grdUnlinkedCCs.AddTextColumn("Partner Key", FPartnerCostCentreTbl.Columns["PartnerKey"], 90);
            grdUnlinkedCCs.Enter += new EventHandler(grdUnlinkedCCs_Enter);
            grdUnlinkedCCs.Selection.FocusRowEntered += new SourceGrid.RowEventHandler(grdUnlinkedCCs_Click);

            btnLink.Text = "\u25B2 Link";
            btnLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLink.Enabled = false;

            btnUnlink.Text = "\u25BC Unlink";
            btnUnlink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUnlink.Enabled = false;

            btnRemove.Enabled = false;

            FPetraUtilsObject.ApplySecurity(TSecurityChecks.SecurityPermissionsSetupScreensEditingAndSaving);

            if (FPetraUtilsObject.SecurityReadOnly)
            {
                btnLink.Enabled = false;
                btnUnlink.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>true</returns>
        public bool SaveChanges()
        {
            if (FChangedState)
            {
                TRemote.MFinance.Setup.WebConnectors.SaveCostCentrePartnerLinks(
                    FLedgerNumber, FPartnerCostCentreTbl);
            }

            return true;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FileSave(object sender, EventArgs e)
        {
            SaveChanges();
        }

        /// <summary></summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkCostCentre(object sender, EventArgs e)
        {
            string NewCCCode = cmbCostCentre.GetSelectedString();

            // I can link to this Cost Centre, IF it's not already linked to someone else!
            FPartnerCostCentreTbl.DefaultView.Sort = ("IsLinked");

            DataRow Row = ((DataRowView)grdUnlinkedCCs.SelectedDataRows[0]).Row;
            Int64 PartnerKey = (Int64)Row["PartnerKey"];
            string PartnerShortName = Row["ShortName"].ToString();

            if (FPartnerCostCentreTbl.DefaultView.Find(NewCCCode) >= 0)
            {
                if (MessageBox.Show(String.Format(Catalog.GetString(
                                "Cost Centre - '{0}' has already been assigned to a partner.{1}{1}Do you want to assign it to the following partner as well:{1}{1}'{2} - {3}'?"),
                            NewCCCode, Environment.NewLine, PartnerKey, PartnerShortName),
                        Catalog.GetString("Link Cost Centre"),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }

            string ReportsTo = cmbReportsTo.Text;

            if (ReportsTo == string.Empty)
            {
                MessageBox.Show(String.Format(Catalog.GetString("Error - Select a Cost Centre that {0} will report to."), NewCCCode),
                    Catalog.GetString("Link Cost Centre"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Row["IsLinked"] = NewCCCode;
            Row["ReportsTo"] = ReportsTo;

            cmbCostCentre.Enabled = false;
            ClearCombos();

            btnLink.Enabled = false;
            grdUnlinkedCCs.SelectRowInGrid(-1, false);

            btnOK.Text = "Accept";
            FChangedState = true;
        }

        /// <summary></summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnlinkCostCentre(object sender, EventArgs e)
        {
            DataRow Row = ((DataRowView)grdLinkedCCs.SelectedDataRows[0]).Row;

            string PartnerKey = Row["PartnerKey"].ToString();

            Row["IsLinked"] = '0';

            ClearCombos();

            btnUnlink.Enabled = false;
            grdLinkedCCs.SelectRowInGrid(-1, false);

            grdUnlinkedCCs.Focus();

            int Counter = 0;

            foreach (DataRowView drv in FUnlinkedView)
            {
                Counter++;

                if (drv.Row["PartnerKey"].ToString() == PartnerKey)
                {
                    grdUnlinkedCCs.SelectRowInGrid(Counter);
                    break;
                }
            }

            btnOK.Text = "Accept";
            FChangedState = true;
        }

        /// <summary></summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCostCentreType(object sender, EventArgs e)
        {
            if ((grdUnlinkedCCs.Rows.Count == 1) || (grdUnlinkedCCs.SelectedDataRows.Length == 0))
            {
                return;
            }

            DataRowView[] UnlinkedsRowToRemoveView = grdUnlinkedCCs.SelectedDataRowsAsDataRowView;
            List <Int64>CostCentrePartnerTypeRowsToRemove = new List <Int64>();

            foreach (DataRowView drv in UnlinkedsRowToRemoveView)
            {
                CostCentrePartnerTypeRowsToRemove.Add((Int64)drv.Row["PartnerKey"]);
            }

            if (CostCentrePartnerTypeRowsToRemove.Count > 0)
            {
                foreach (DataRowView drv in FUnlinkedView)
                {
                    if (CostCentrePartnerTypeRowsToRemove.Contains((Int64)drv.Row["PartnerKey"]))
                    {
                        drv.Row.Delete();
                    }
                }
            }

            grdUnlinkedCCs.SelectRowInGrid(1, false);
            grdUnlinkedCCs.Focus();

            if (!FPetraUtilsObject.SecurityReadOnly)
            {
                btnRemove.Enabled = (grdUnlinkedCCs.Rows.Count > 1);
            }

            btnOK.Text = "Accept";
            FChangedState = true;
        }

        private void ClearCombos(int AWhichCombos = 0)
        {
            if (AWhichCombos != REPORTS_TO_ONLY)
            {
                cmbCostCentre.SelectedIndex = -1;
                cmbCostCentre.Text = string.Empty;
                cmbCostCentre.AttachedLabel.Text = string.Empty;
            }

            if (AWhichCombos != CC_CODE_ONLY)
            {
                cmbReportsTo.SelectedIndex = -1;
                cmbReportsTo.Text = string.Empty;
                cmbReportsTo.AttachedLabel.Text = string.Empty;
            }
        }

        private void CostCentreChanged(object sender, EventArgs e)
        {
            bool ValidCostCentre = ((cmbCostCentre.Enabled == true) && (cmbCostCentre.SelectedIndex > -1));
            bool ValidReportTo = false;

            FLocalCostCentres.DefaultView.RowFilter = "CostCentreCode='" + cmbCostCentre.GetSelectedString() + "'";

            if (FLocalCostCentres.DefaultView.Count > 0)
            {
                cmbReportsTo.SetSelectedString(FLocalCostCentres.DefaultView[0].Row["ReportsTo"].ToString());
            }
            else
            {
                ClearCombos(REPORTS_TO_ONLY);
            }

            ValidReportTo = (cmbReportsTo.Text != string.Empty);

            if (!FPetraUtilsObject.SecurityReadOnly)
            {
                btnLink.Enabled = ValidCostCentre && ValidReportTo;
            }
        }

        private void grdLinkedCCs_Enter(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
        }

        private void grdLinkedCCs_Click(object sender, EventArgs e)
        {
            if (grdLinkedCCs.SelectedDataRows.Length > 0)
            {
                if (!FPetraUtilsObject.SecurityReadOnly)
                {
                    btnUnlink.Enabled = true;
                }

                btnLink.Enabled = false;
                btnRemove.Enabled = false;

                DataRow Row = ((DataRowView)grdLinkedCCs.SelectedDataRows[0]).Row;
                txtPartner.Text = Convert.ToString(Row["PartnerKey"]);

                cmbCostCentre.Enabled = false;
                cmbCostCentre.SetSelectedString(Convert.ToString(Row["IsLinked"]));

                cmbReportsTo.SetSelectedString(Convert.ToString(Row["ReportsTo"]));
                grdUnlinkedCCs.SelectRowInGrid(-1, false);
            }
        }

        private void grdUnlinkedCCs_Enter(object sender, EventArgs e)
        {
            cmbCostCentre.Enabled = true;
            ClearCombos();

            btnUnlink.Enabled = false;
            btnLink.Enabled = false;
            btnRemove.Enabled = false;

            grdLinkedCCs.SelectRowInGrid(-1, false);
        }

        private void grdUnlinkedCCs_Click(object sender, EventArgs e)
        {
            if (grdUnlinkedCCs.SelectedDataRows.Length > 0)
            {
                DataRow Row = ((DataRowView)grdUnlinkedCCs.SelectedDataRows[0]).Row;
                txtPartner.Text = Convert.ToString(Row["PartnerKey"]);

                if (!FPetraUtilsObject.SecurityReadOnly)
                {
                    btnRemove.Enabled = true;
                }
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnOK_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void CustomClosingHandler(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (FChangedState)
            {
                if (MessageBox.Show(MCommonResourcestrings.StrFormHasUnsavedChangesQuestion,
                        "Link Cost Centres to Partners",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    SaveChanges();
                }
            }
        }
    }
}