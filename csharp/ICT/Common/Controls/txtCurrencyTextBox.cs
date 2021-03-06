//
// DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
//
// @Authors:
//       christiank
//
// Copyright 2004-2013 by OM International
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Ict.Common.Controls
{
    /// <summary>
    /// Contains a TTxtNumericTextBox which restricts the data entry to decimal numbers and shows a currency symbol next to the TextBox.
    /// </summary>
    public partial class TTxtCurrencyTextBox : UserControl
    {
        #region Public Currency Constants

        /// <summary>Currency code that uses no decimal digits.  Set to Japanese Yen.</summary>
        public const string CURRENCY_STANDARD_0_DP = "Y";

        /// <summary>Currency code that uses 2 decimal places.  Set to US Dollars.</summary>
        public const string CURRENCY_STANDARD_2_DP = "USD";

        #endregion

        private const string COLUMNNAME_CURRENCY_NAME = "a_currency_name_c";
        private const string COLUMNNAME_DISPLAYFORMAT_NAME = "a_display_format_c";

        private int FOriginalTxtNumericWidth;
        private int FLastControlWidth = -1;
        private string FCurrencyName;

        private static TRetrieveCurrencyList FRetrieveCurrencyList;
        private static DataTable GCurrencyList;
        private string FCurrencyDisplayFormat = "->>>,>>>,>>>,>>9.99";

        private bool FSuppressTextChangeDetection = false;
        private bool FAlwaysHideLabel = false;

        #region Properties (handed through to TTxtNumericTextBox!)

        /// <summary>
        /// This Property is ignored (!) unless ControlMode is 'NormalTextMode'! For all other cases, the value to be displayed needs to be set programmatically through the 'NumberValueDecimal' or 'NumberValueInt' Properties.
        /// </summary>
        [Description(
             "This Property is ignored (!) unless ControlMode is 'NormalTextMode'! For all other cases, the value to be displayed needs to be set programmatically through the 'NumberValueDecimal' or 'NumberValueInt' Properties.")
        ]
        public override string Text
        {
            get
            {
                return FTxtNumeric.Text;
            }

            set
            {
                FTxtNumeric.Text = value;
            }
        }

        /// <summary>
        /// Determines the number of decimal places (valid only for Decimal and Currency ControlModes).
        /// </summary>
        [Category("NumericTextBox"),
         RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All),
         DefaultValue(2),
         Browsable(true),
         Description("Determines the number of decimal places (valid only for Decimal and Currency ControlModes).")]
        public int DecimalPlaces
        {
            get
            {
                return FTxtNumeric.DecimalPlaces;
            }

            set
            {
                FTxtNumeric.DecimalPlaces = value;
            }
        }

        /// <summary>
        /// Determines whether the control allows a null value, or not.
        /// </summary>
        [Category("NumericTextBox"),
         RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All),
         DefaultValue(false),
         Browsable(true),
         Description("Determines whether the control allows a null value, or not.")]
        public bool NullValueAllowed
        {
            get
            {
                return FTxtNumeric.NullValueAllowed;
            }

            set
            {
                FTxtNumeric.NullValueAllowed = value;
            }
        }

        /// <summary>
        /// Determines whether the control allows a negative value, or not. Default = true.
        /// </summary>
        [Category("NumericTextBox"),
         RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All),
         DefaultValue(true),
         Browsable(true),
         Description("Determines whether the control allows a negative value, or not. Default = true.")]
        public bool NegativeValueAllowed
        {
            get
            {
                return FTxtNumeric.NegativeValueAllowed;
            }

            set
            {
                FTxtNumeric.NegativeValueAllowed = value;
            }
        }

        /// This property gets hidden because it doesn't make sense in the Designer!
        [Browsable(false),
         DefaultValue(0.00)]
        public decimal ? NumberValueDecimal
        {
            get
            {
                string NumericStr;

                if (!DesignMode)
                {
                    NumericStr = FTxtNumeric.Text;

                    if (NumericStr != String.Empty)
                    {
                        if (((NumericStr.Length == 1) && (NumericStr.IndexOfAny(new char[] { '-', '.', ',' }) != -1)))
                        {
                            NumericStr = "0";

                            if (!NegativeValueAllowed)
                            {
                                FSuppressTextChangeDetection = true;

                                FTxtNumeric.NumberValueDecimal = 0m;

                                FSuppressTextChangeDetection = false;
                            }
                        }

                        Decimal LocalCultureVersion;

                        if (Decimal.TryParse(NumericStr, System.Globalization.NumberStyles.Any, FTxtNumeric.Culture, out LocalCultureVersion))
                        {
                            return LocalCultureVersion;
                        }
                    }

                    return null;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (value != null)
                {
                    FTxtNumeric.NumberValueDecimal = value;
                }
                else
                {
                    if (FTxtNumeric.FNullValueAllowed)
                    {
                        FTxtNumeric.NumberValueDecimal = null;
                        return;
                    }
                    else
                    {
                        throw new ArgumentNullException(
                            "The 'NumberValueDecimal' Property must not be set to null if the 'NullValueAllowed' Property is false.");
                    }
                }
            }
        }

        /// This property gets hidden because it doesn't make sense in the Designer!
        [Browsable(false),
         DefaultValue(0.00)]
        public double ? NumberValueDouble
        {
            get
            {
                string NumericStr;

                if (!DesignMode)
                {
                    NumericStr = FTxtNumeric.Text;

                    if (NumericStr != String.Empty)
                    {
                        double? Ret = null;

                        if (((NumericStr.Length == 1) && (NumericStr.IndexOfAny(new char[] { '-', '.', ',' }) != -1)))
                        {
                            NumericStr = "0";

                            if (!NegativeValueAllowed)
                            {
                                FSuppressTextChangeDetection = true;

                                FTxtNumeric.NumberValueDouble = 0;

                                FSuppressTextChangeDetection = false;
                            }
                        }

                        try
                        {
                            double LocalCultureVersion;

                            if (Double.TryParse(NumericStr, out LocalCultureVersion))
                            {
                                Ret = LocalCultureVersion;
                            }
                            else
                            {
                                Ret = Convert.ToDouble(NumericStr, FTxtNumeric.Culture);
                            }
                        }
                        catch (Exception)
                        {
                        }
                        return Ret;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (value != null)
                {
                    FTxtNumeric.NumberValueDouble = value;
                }
                else
                {
                    if (FTxtNumeric.FNullValueAllowed)
                    {
                        FTxtNumeric.NumberValueDouble = null;
                        return;
                    }
                    else
                    {
                        throw new ArgumentNullException(
                            "The 'NumberValueDouble' Property must not be set to null if the 'NullValueAllowed' Property is false.");
                    }
                }
            }
        }

        /// <summary>
        /// Whether the TextBox Control is read-only, or not.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return FTxtNumeric.ReadOnly;
            }

            set
            {
                FTxtNumeric.ReadOnly = value;
            }
        }

        /// <summary>
        /// Sets the context for the numerictext box that is part of the Currency TextBox.  This is set automatically by the designer file.
        /// </summary>
        public object Context
        {
            set
            {
                FTxtNumeric.Context = value;
            }
        }

        /// <summary>
        /// Sets the control mode of the text box.  This is set automatically by the designer file.
        /// The value is always set to Currency but may be modified by user preferences.
        /// </summary>
        public TTxtNumericTextBox.TNumericTextBoxMode ControlMode
        {
            set
            {
                FTxtNumeric.ControlMode = TTxtNumericTextBox.TNumericTextBoxMode.Currency;
            }
        }

        /// <summary>
        /// Gets/Sets the current thread's culture
        /// </summary>
        public CultureInfo Culture
        {
            get
            {
                return FTxtNumeric.Culture;
            }

            set
            {
                FTxtNumeric.Culture = value;
            }
        }

        #endregion

        #region Currency Text Box Properties

        /// <summary>
        /// Gets/sets whether the currency label is visible or not. Used for items like 'Hash Total' where the
        /// text box is associated with a currency (so needs the correct format and d.p. but the number is not really in currency units.
        /// This property is usually set by the Designer when the YAML 'HideLabel=true' attribute is set.
        /// </summary>
        public bool ShowLabel
        {
            get
            {
                return FLblCurrency.Visible;
            }

            set
            {
                if (value == true)
                {
                    FLblCurrency.Visible = !FAlwaysHideLabel;
                }
                else
                {
                    FLblCurrency.Visible = false;
                }
            }
        }

        /// <summary>
        /// Gets/sets a value that deals with the visble state of the currency label.  When true the label is always hidden.
        /// When false (default) the label is hidden if the CurrencyCode string is empty text and visible if there is a currency code.
        /// Use this property in order to be able to set specific currency codes and get the correct number of decimal places
        /// while keeping the code label hidden.  This is used in GL screen hash codes because the currencies in a batch may be mixed.
        /// </summary>
        public bool AlwaysHideLabel
        {
            get
            {
                return FAlwaysHideLabel;
            }

            set
            {
                FAlwaysHideLabel = value;

                if (FAlwaysHideLabel)
                {
                    FLblCurrency.Visible = false;
                }
            }
        }

        /// <summary>
        /// Determines the currency symbol and the number of decimal places.
        /// The value can be set to an empty string, in which case the label will be hidden and we will use 2 decimal places.
        /// You should only set the value to empty string under special circumstances, such as screen load or a data row contains
        /// a currency code of empty text but other rows can be expected to have defined values.
        /// If you want to have a box with no label but with a defined currency code in order to have the correct number of decimal places
        /// you should set 'AlwaysHideLabel = true' in YAML or code.
        /// </summary>
        [Category("NumericTextBox"),
         RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All),
         DefaultValue("###"),
         Browsable(true),
         Description("Determines the currency format and symbol.")]
        public string CurrencyCode
        {
            get
            {
                return FLblCurrency.Text;
            }

            set
            {
                FLblCurrency.Text = value;

                if (value == String.Empty)
                {
                    // The value can be empty string.  In that case we hide the label and use a currency format with 2 d.p.
                    ShowLabel = false;
                    FCurrencyName = String.Empty;
                    tipCurrencyName.SetToolTip(FLblCurrency, String.Empty);
                    FCurrencyDisplayFormat = "->>>,>>>,>>>,>>9.99";
                    this.DecimalPlaces = 2;
                    return;
                }
                else if (!FAlwaysHideLabel)
                {
                    ShowLabel = true;
                }

                if (GCurrencyList != null)
                {
                    DataRow CurrencyDR = GCurrencyList.Rows.Find(value);

                    if (CurrencyDR != null)
                    {
                        FCurrencyName = (string)CurrencyDR[COLUMNNAME_CURRENCY_NAME];
                        FCurrencyDisplayFormat = (string)CurrencyDR[COLUMNNAME_DISPLAYFORMAT_NAME];
                        int DecimalSeparatorPos = FCurrencyDisplayFormat.LastIndexOf('.');

                        if (DecimalSeparatorPos != -1)
                        {
                            this.DecimalPlaces = FCurrencyDisplayFormat.Length - DecimalSeparatorPos - 1;
                        }
                        else
                        {
                            this.DecimalPlaces = 0;
                        }
                    }
                    else
                    {
                        FCurrencyName = String.Empty;
                        FCurrencyDisplayFormat = "->>>,>>>,>>>,>>9.99";
                        this.DecimalPlaces = 2;
                    }

                    tipCurrencyName.SetToolTip(FLblCurrency, FCurrencyName);
                }
            }
        }

        /// <summary>
        /// The name of the currency. Only available after (1) assigning the RetrieveCurrencyList Delegate and
        /// (2) assigning the Currency Property and (3) that Currency was found in the Currency List retrieved by the Delegate.
        /// </summary>
        public string CurrencyName
        {
            get
            {
                return FCurrencyName;
            }
        }

        /// <summary>
        /// Gets or sets how text is aligned in the TextBox.
        /// </summary>
        public System.Windows.Forms.HorizontalAlignment TextAlign
        {
            get
            {
                return FTxtNumeric.TextAlign;
            }

            set
            {
                FTxtNumeric.TextAlign = value;
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Raised whenever the TextBox raises the TextChanged Event.
        /// </summary>
        public new event EventHandler TextChanged;

        /// <summary>
        /// Loads a DataTable that contains the list of currencies.
        /// </summary>
        /// <remarks>See implementation in Ict.Petra.Client.CommonControls.TControlExtensions.RetrieveCurrencyList!</remarks>
        /// <returns>A DataTable that contains the list of currencies.</returns>
        public delegate DataTable TRetrieveCurrencyList();

        /// <summary>
        /// This property is used to provide a function which loads the list of Currencies.
        /// </summary>
        /// <description>The Delegate is set up at the start of the application.</description>
        public static TRetrieveCurrencyList RetrieveCurrencyList
        {
            get
            {
                return FRetrieveCurrencyList;
            }

            set
            {
                FRetrieveCurrencyList = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public TTxtCurrencyTextBox()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            #region CATALOGI18N

            // this code has been inserted by GenerateI18N, all changes in this region will be overwritten by GenerateI18N
            this.FLblCurrency.Text = Catalog.GetString("WWW");
            #endregion

            FTxtNumeric.TextChanged += new EventHandler(OnTextChanged);

            if (FRetrieveCurrencyList != null)
            {
                if (GCurrencyList == null)
                {
                    GCurrencyList = FRetrieveCurrencyList();
                }
            }

            FTxtNumeric.IsCurrencyTextBox = true;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Selects all text in the TextBox.
        /// </summary>
        public void SelectAll()
        {
            FTxtNumeric.SelectAll();
        }

        /// <summary>
        /// Clears the content of the text box (sets the value to 0 in the current culture and user preference format)
        /// </summary>
        public void ClearBox()
        {
            FTxtNumeric.ClearBox();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Maintain the custom layout of the TextBox and the Label.
        /// </summary>
        private void MaintainLayoutOfContainedControls()
        {
            FOriginalTxtNumericWidth = FLblCurrency.Left + 4;
            FTxtNumeric.Width = FOriginalTxtNumericWidth;
        }

        /// <summary>
        /// This method overrides the normal user formatting.  It is used by UserPreferences to show examples of formatting options
        /// </summary>
        public void OverrideNormalFormatting(bool AUseNumberFormatForCurrency, bool AShowThousands)
        {
            FTxtNumeric.OverrideNormalFormatting(AUseNumberFormatForCurrency, AShowThousands);
        }

        #endregion

        #region Event Handlers

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!FSuppressTextChangeDetection)
            {
                if (TextChanged != null)
                {
                    TextChanged(sender, e);
                }
            }
        }

        void TTxtCurrencyTextBoxLayout(object sender, LayoutEventArgs e)
        {
            FLblCurrency.Width = 37;
            FLblCurrency.Left = this.Size.Width - FLblCurrency.Width - 1;
            FTxtNumeric.Left = 0;

            if (FLastControlWidth != this.Size.Width)
            {
                FLastControlWidth = this.Size.Width;

                MaintainLayoutOfContainedControls();
            }

            if (ShowLabel)
            {
                FTxtNumeric.Width = FOriginalTxtNumericWidth;
            }
            else
            {
                FTxtNumeric.Width = this.Width;
            }
        }

//        /// <summary>
//        /// Only for debugging the layout of the Controls
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        void FLblCurrencyDoubleClick(object sender, EventArgs e)
//        {
//            MessageBox.Show(String.Format("this.Name: {0}    this.Width: {1}\r\nFLblCurrency.Width: {2}    FLblCurrency.Left: {3}\r\nFTxtNumeric.Width: {4}",
//                this.Name, this.Width, FLblCurrency.Width, FLblCurrency.Left, FTxtNumeric.Width));
//        }

        #endregion
    }
}