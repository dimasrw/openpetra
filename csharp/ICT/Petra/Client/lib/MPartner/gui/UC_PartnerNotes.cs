/*************************************************************************
 *
 * DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * @Authors:
 *       christiank
 *
 * Copyright 2004-2009 by OM International
 *
 * This file is part of OpenPetra.org.
 *
 * OpenPetra.org is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * OpenPetra.org is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with OpenPetra.org.  If not, see <http://www.gnu.org/licenses/>.
 *
 ************************************************************************/
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Mono.Unix;
using Ict.Common;
using Ict.Petra.Shared.MPartner.Partner.Data;
using Ict.Common.Controls;
using Ict.Petra.Client.CommonControls;
using Ict.Petra.Client.CommonForms;
using System.Globalization;
using System.Threading;
using Ict.Petra.Shared;
using Ict.Petra.Client.App.Core;
using Ict.Petra.Client.App.Gui;
using Ict.Petra.Client.App.Formatting;

namespace Ict.Petra.Client.MPartner.Gui
{
    /// <summary>
    /// UserControl for editing Partner Notes.
    /// </summary>
    public partial class TUC_PartnerNotes : System.Windows.Forms.UserControl, IPetraEditUserControl
    {
        /// <summary>todoComment</summary>
        protected PartnerEditTDS FMainDS;

        /// <summary>todoComment</summary>
        public PartnerEditTDS MainDS
        {
            get
            {
                return FMainDS;
            }

            set
            {
                FMainDS = value;
            }
        }

        /// <summary>todoComment</summary>
        public event TRecalculateScreenPartsEventHandler RecalculateScreenParts;

        /// <summary>
        /// constructor
        /// </summary>
        public TUC_PartnerNotes() : base ()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            #region CATALOGI18N

            // this code has been inserted by GenerateI18N, all changes in this region will be overwritten by GenerateI18N
            this.grpNames.Text = Catalog.GetString("Notes");
            #endregion
        }

        private TFrmPetraEditUtils FPetraUtilsObject;

        /// <summary>
        /// this provides general functionality for edit screens
        /// </summary>
        public TFrmPetraEditUtils PetraUtilsObject
        {
            get
            {
                return FPetraUtilsObject;
            }
            set
            {
                FPetraUtilsObject = value;
            }
        }

        private void TxtPartnerComment_Validated(System.Object sender, System.EventArgs e)
        {
            TRecalculateScreenPartsEventArgs RecalculateScreenPartsEventArgs;

            RecalculateScreenPartsEventArgs = new TRecalculateScreenPartsEventArgs();
            RecalculateScreenPartsEventArgs.ScreenPart = TScreenPartEnum.spCounters;
            OnRecalculateScreenParts(RecalculateScreenPartsEventArgs);
        }

        #region Public methods

        /// <summary>
        /// todoComment
        /// </summary>
        public void InitUserControl()
        {
            // Special information
            btnCreatedPartner.UpdateFields(FMainDS.PPartner);

            // Notes GroupBox
            txtPartnerComment.DataBindings.Add("Text", FMainDS.PPartner, PPartnerTable.GetCommentDBName());

            // Set StatusBar Texts
#if TODO
            FPetraUtilsObject.SetStatusBarText(txtPartnerComment, PPartnerTable.GetCommentHelp());
#endif
            ApplySecurity();

            // Extender Provider
            this.expStringLengthCheckNotes.RetrieveTextboxes(this);
            this.txtPartnerComment.Validated += new EventHandler(this.TxtPartnerComment_Validated);
        }

        /// <summary>
        /// Checks whether there any Tips to show to the User; if there are, they will be
        /// shown.
        ///
        /// </summary>
        /// <returns>void</returns>
        public void CheckForUserTips()
        {
            Rectangle SelectedTabHeaderRectangle;

            // Calculate where the middle of the TabHeader of the Tab lies at this moment
            SelectedTabHeaderRectangle = ((TTabVersatile) this.Parent.Parent.Parent).SelectedTabHeaderRectangle;
            pnlBalloonTipAnchor.Left = SelectedTabHeaderRectangle.X + Convert.ToInt16(SelectedTabHeaderRectangle.Width / 2.0);

            // pnlBalloonTipAnchor.Left := 60;
            // pnlBalloonTipAnchor.Top := 10;
            // Check for BalloonTips to display, and show them
// TODO            System.Threading.ThreadPool.QueueUserWorkItem(@TThreadedNotes.ThreadedCheckForUserTips, pnlBalloonTipAnchor);
        }

        private void OnRecalculateScreenParts(TRecalculateScreenPartsEventArgs e)
        {
            if (RecalculateScreenParts != null)
            {
                RecalculateScreenParts(this, e);
            }
        }

        #endregion

        #region Helper functions
        private void ApplySecurity()
        {
            if (!UserInfo.GUserInfo.IsTableAccessOK(TTableAccessPermission.tapMODIFY, PPartnerTable.GetTableDBName()))
            {
                // need to disable all Fields that are DataBound to p_partner
                // MessageBox.Show('Disabling p_partner fields...');
                CustomEnablingDisabling.DisableControl(pnlNotes, txtPartnerComment);
            }
        }

        #endregion
    }

    /// <summary>
    /// todoComment
    /// </summary>
    public class TThreadedNotes : System.Object
    {
// TODO balloon
#if TODO
        private static TBalloonTip UBalloonTip;

        public static void PrepareBalloonTip()
        {
            // Ensure that we have an instance of TBalloonTip
            if (UBalloonTip == null)
            {
                UBalloonTip = new TBalloonTip();
            }
        }

        public static void ThreadedCheckForUserTips(System.Object AControl)
        {
            /*
             * Check for specific TipStatus: '!' means 'show the Tip, but then set it'
             *
             * This is done to pick up Tips only for the Users that they were specifically
             * set for, and not for users where the TipStatus would be un-set ('-')!
             * This is helfpful eg. for Patch Notices - they should be shown to all current
             * users (the patch program would set the TipStatus to '!' for all current users),
             * but not for users that get created after the Patch was applied (they don't
             * need to know what was new/has changed in a certain Patch that was applied in
             * the past!)
             */
            if (TUserTips.TMPartner.CheckTipStatus(TMPartnerTips.mpatNewTabCountersNotes) == '!')
            {
                // Set Tip Status so it doesn't get picked up again!
                TUserTips.TMPartner.SetTipViewed(TMPartnerTips.mpatNewTabCountersNotes);

                // MessageBox.Show('TUC_PartnerNotes.CheckForUserTips: showing BalloonTip...');
                PrepareBalloonTip();
                UBalloonTip.ShowBalloonTipNewFunction(
                    "Petra Version 2.2.7 Change: Indicator in Notes Tab Header",
                    "An indicator has been added to the tab header that shows whether Notes are entered for the Partner," + "\r\n" +
                    "or not: (0) means that no Notes are entered, (" + (char)8730 + ") means that Notes are entered." + "\r\n" +
                    "The Addresses tab and Subscriptions tab also have changes to the counters in the tab headers.",
                    (Control)AControl);

                // 8730 = 'square root symbol' in Verdana
                UBalloonTip = null;
            }
        }
#endif

    }
}