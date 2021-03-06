﻿using System;
using System.Windows.Forms;
using IntralismToolBox.Forms.StoryboardForms;
using IntralismToolBox.Forms.StoryboardForms.GeometryFigures;

namespace IntralismToolBox.Forms
{
    /// <summary>
    ///     <see cref="ThemedForm"/> that gets shown when <see cref="MainForm.StoryboardAssistantButton"/> was pressed.
    /// </summary>
    public partial class StoryboardAssistantForm : ThemedForm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StoryboardAssistantForm"/> class.
        /// </summary>
        public StoryboardAssistantForm()
        {
            this.InitializeComponent();
            this.ReloadTheme();
            ToolTip toolTip = new();
            toolTip.SetToolTip(this.resetButton, "U just found an Undertale reeeeeeffffeeeeerrrrenceeeee");
        }

        private void FillOrbitButtonClicked(object sender, EventArgs e)
        {
            FillOrbitForm fillOrbitForm = new(this);
            fillOrbitForm.Show();
        }

        private void ResetButtonClicked(object sender, EventArgs e) => this.resultTextBox.Text = string.Empty;

        private void IntervalColorButtonClicked(object sender, EventArgs e)
        {
            IntervalColorForm intervalColorForm = new(this);
            intervalColorForm.Show();
        }

        private void AutoGradientButtonClicked(object sender, EventArgs e)
        {
            AutoGradientForm autoGradientForm = new(this);
            autoGradientForm.Show();
        }

        private void GeometricFiguresButtonClicked(object sender, EventArgs e)
        {
            GeometryForm geometryForm = new(this);
            geometryForm.Show();
        }
    }
}
