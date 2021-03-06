//
// DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
//
// @Authors:
//       alanp
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
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;
using System.Collections.Specialized;
using GNU.Gettext;

using Ict.Common;
using Ict.Common.Controls;
using Ict.Common.IO;
using Ict.Common.Remoting.Client;
using Ict.Common.Verification;
using Ict.Petra.Client.App.Core;
using Ict.Petra.Client.App.Core.RemoteObjects;
using Ict.Petra.Client.MFinance.Logic;
using Ict.Petra.Shared.MFinance.GL.Data;
using Ict.Petra.Shared.MFinance.Gift.Data;
using Ict.Petra.Shared.MFinance;
using Ict.Petra.Shared.MFinance.Account.Data;
using Ict.Petra.Shared.MPartner;
using Ict.Petra.Shared.MPartner.Partner.Data;
using Ict.Petra.Client.App.Gui;
using Ict.Petra.Shared;
using Ict.Petra.Client.CommonDialogs;

namespace Ict.Petra.Client.MFinance.Gui.Setup
{
    public partial class TFrmEmailDestinationSetup
    {
        private void NewRowManual(ref AEmailDestinationRow ARow)
        {
            ARow.FileCode = "HOSA";
            ARow.PartnerKey = 0;
            string newValue = Catalog.GetString("NEWVALUE");
            int countNewValue = 1;

            if (FMainDS.AEmailDestination.Rows.Find(new object[] { ARow.FileCode, newValue, ARow.PartnerKey }) != null)
            {
                while (FMainDS.AEmailDestination.Rows.Find(new object[] {
                               ARow.FileCode,
                               newValue + countNewValue.ToString(),
                               ARow.PartnerKey
                           }) != null)
                {
                    countNewValue++;
                }

                newValue += countNewValue.ToString();
            }

            ARow.ConditionalValue = newValue;
            ARow.EmailAddress = String.Empty;
        }

        private void NewRecord(Object sender, EventArgs e)
        {
            CreateNewAEmailDestination();
        }

        private void ShowDetailsManual(AEmailDestinationRow ARow)
        {
            if (ARow != null)
            {
                string s = ARow.EmailAddress;
                s = s.Replace(",", Environment.NewLine);
                s = s.Replace(";", Environment.NewLine);
                txtDetailEmailAddress.Text = s;
            }
        }

        private void OnFileCodeChange(Object sender, EventArgs e)
        {
            switch (cmbDetailFileCode.GetSelectedString())
            {
                case "AFO":
                case "BRANCH":
                case "STEWARDSHIP":
                case "FUND BALANCE":
                case "FUND BALS-AFO":
                    txtDetailConditionalValue.Enabled = false;
                    txtDetailConditionalValue.Text = "";
                    break;

                case "HOSA":
                case "ICH":
                    txtDetailConditionalValue.Enabled = true;
                    FPetraUtilsObject.SetStatusBarText(txtDetailConditionalValue, "Enter a Fund Number");
                    break;

                case "GIFT STATEMENT":
                    txtDetailConditionalValue.Enabled = true;
                    FPetraUtilsObject.SetStatusBarText(txtDetailConditionalValue, "Enter a Motivation Group and Detail, separated by a | character");
                    break;

                default:
                    txtDetailConditionalValue.Enabled = true;
                    FPetraUtilsObject.SetStatusBarText(txtDetailConditionalValue, "Enter the condition value");
                    break;
            }
        }

        private void GetDetailDataFromControlsManual(AEmailDestinationRow ARow)
        {
            ARow.EmailAddress = txtDetailEmailAddress.Text.Replace(Environment.NewLine, ",");

            if (!txtDetailConditionalValue.Enabled)
            {
                ARow.ConditionalValue = "NOT SET";
            }
        }

        private void PartnerKeyChanged(Int64 APartnerKey,
            String APartnerShortName,
            bool AValidSelection)
        {
            string NewEmailAddresses = String.Empty;
            string EmailAddress;
            PartnerInfoTDS PartnerInfoDS;

            if (TServerLookup.TMPartner.PartnerInfo(APartnerKey, TPartnerInfoScopeEnum.pisPartnerAttributesOnly,
                    out PartnerInfoDS))
            {
                if (PartnerInfoDS.PPartnerAttribute.Rows.Count > 0)
                {
                    Calculations.DeterminePartnerContactDetailAttributes(PartnerInfoDS.PPartnerAttribute);

                    // This will return either true or false. If it returns true then the email information needs to be displayed;
                    // Otherwise the email information will be cleared.
                    if (Calculations.GetPrimaryEmailAddress(PartnerInfoDS.PPartnerAttribute, out EmailAddress))
                    {
                        // There can be multiple addresses, separated by comma or semicolon
                        string[] addresses = StringHelper.SplitEmailAddresses(EmailAddress);

                        for (int i = 0; i < addresses.Length; i++)
                        {
                            if (NewEmailAddresses.Length > 0)
                            {
                                NewEmailAddresses += Environment.NewLine;
                            }

                            NewEmailAddresses += addresses[i].Trim();
                        }
                    }
                }
            }

            txtDetailEmailAddress.Text = NewEmailAddresses;
        }

        private bool PreDeleteManual(AEmailDestinationRow ARowToDelete, ref string ADeletionQuestion)
        {
            if (txtDetailPartnerKey.LabelText.Length > 0)
            {
                ADeletionQuestion = Catalog.GetString("Are you sure you want to delete the current row?");

                ADeletionQuestion += String.Format("{0}{0}({1} {2}, {3} {4})",
                    Environment.NewLine,
                    lblDetailPartnerKey.Text,
                    txtDetailPartnerKey.LabelText,
                    lblDetailConditionalValue.Text,
                    txtDetailConditionalValue.Text);
            }

            return true;
        }

        private void PrintGrid(TStandardFormPrint.TPrintUsing APrintApplication, bool APreviewMode)
        {
            TFrmSelectPrintFields.SelectAndPrintGridFields(this, APrintApplication, APreviewMode, TModule.mPartner, this.Text, grdDetails,
                new int[]
                {
                    AEmailDestinationTable.ColumnFileCodeId,
                    AEmailDestinationTable.ColumnConditionalValueId,
                    AEmailDestinationTable.ColumnPartnerKeyId,
                    AEmailDestinationTable.ColumnEmailAddressId
                });
        }
    }
}