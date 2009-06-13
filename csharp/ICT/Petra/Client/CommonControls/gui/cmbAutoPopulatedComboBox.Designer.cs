﻿/*************************************************************************
 *
 * DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * @Authors:
 *       christiank, markusm
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
using System.Windows.Forms;
using System.Drawing.Printing;
using Ict.Common.Controls;
using Ict.Petra.Client.CommonControls;

namespace Ict.Petra.Client.CommonControls
{
    partial class TCmbAutoPopulated
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAutoPopulated = new Ict.Common.Controls.TCmbLabelled();
            this.SuspendLayout();

            //
            // cmbAutoPopulated
            //
            this.cmbAutoPopulated.Anchor =
                (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.cmbAutoPopulated.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAutoPopulated.ColumnWidthCol1 = 121;
            this.cmbAutoPopulated.ColumnWidthCol2 = 0;
            this.cmbAutoPopulated.ColumnWidthCol3 = 0;
            this.cmbAutoPopulated.ColumnWidthCol4 = 0;
            this.cmbAutoPopulated.ComboBoxWidth = 121;
            this.cmbAutoPopulated.DisplayInColumn1 = "";
            this.cmbAutoPopulated.DisplayInColumn2 = null;
            this.cmbAutoPopulated.DisplayInColumn3 = null;
            this.cmbAutoPopulated.DisplayInColumn4 = null;
            this.cmbAutoPopulated.DisplayMember = "";
            this.cmbAutoPopulated.Font =
                new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (Byte)0);
            this.cmbAutoPopulated.ImageColumn = 0;
            this.cmbAutoPopulated.Images = null;
            this.cmbAutoPopulated.LabelDisplaysColumn = null;
            this.cmbAutoPopulated.Location = new System.Drawing.Point(0, 0);
            this.cmbAutoPopulated.Name = "cmbAutoPopulated";
            this.cmbAutoPopulated.Size = new System.Drawing.Size(234, 22);
            this.cmbAutoPopulated.TabIndex = 0;
            this.cmbAutoPopulated.ValueMember = "";

            //
            // TCmbAutoPopulated
            //
            this.Controls.Add(this.cmbAutoPopulated);
            this.Name = "TCmbAutoPopulated";
            this.Size = new System.Drawing.Size(234, 22);
            this.ResumeLayout(false);
        }

        private TCmbLabelled cmbAutoPopulated;
    }
}