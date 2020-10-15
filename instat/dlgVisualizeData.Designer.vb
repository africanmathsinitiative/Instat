﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgVisualizeData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rdoVisDat = New System.Windows.Forms.RadioButton()
        Me.rdoVisMiss = New System.Windows.Forms.RadioButton()
        Me.rdoVisGuess = New System.Windows.Forms.RadioButton()
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.lblPalette = New System.Windows.Forms.Label()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.lblMillionDataPoints = New System.Windows.Forms.Label()
        Me.lblPaltte = New System.Windows.Forms.Label()
        Me.lblMaximumS = New System.Windows.Forms.Label()
        Me.lblDataPoints = New System.Windows.Forms.Label()
        Me.lblSampling = New System.Windows.Forms.Label()
        Me.ucrNudSamplingFunction = New instat.ucrNud()
        Me.ucrNudMaximum = New instat.ucrNud()
        Me.ucrNudMaximumSize = New instat.ucrNud()
        Me.ucrInputComboboxPaletteGuess = New instat.ucrInputComboBox()
        Me.ucrChkSortMiss = New instat.ucrCheck()
        Me.ucrChkSortVariables = New instat.ucrCheck()
        Me.ucrInputComboboxPalette = New instat.ucrInputComboBox()
        Me.ucrReceiverVisualizeData = New instat.ucrReceiverMultiple()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrPnlVisualizeData = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrSelectorVisualizeData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'rdoVisDat
        '
        Me.rdoVisDat.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisDat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatAppearance.BorderSize = 2
        Me.rdoVisDat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisDat.Location = New System.Drawing.Point(60, 11)
        Me.rdoVisDat.Name = "rdoVisDat"
        Me.rdoVisDat.Size = New System.Drawing.Size(100, 28)
        Me.rdoVisDat.TabIndex = 1
        Me.rdoVisDat.TabStop = True
        Me.rdoVisDat.Text = "Data"
        Me.rdoVisDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisDat.UseVisualStyleBackColor = True
        '
        'rdoVisMiss
        '
        Me.rdoVisMiss.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisMiss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatAppearance.BorderSize = 2
        Me.rdoVisMiss.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisMiss.Location = New System.Drawing.Point(156, 11)
        Me.rdoVisMiss.Name = "rdoVisMiss"
        Me.rdoVisMiss.Size = New System.Drawing.Size(100, 28)
        Me.rdoVisMiss.TabIndex = 2
        Me.rdoVisMiss.TabStop = True
        Me.rdoVisMiss.Text = "Missing"
        Me.rdoVisMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisMiss.UseVisualStyleBackColor = True
        '
        'rdoVisGuess
        '
        Me.rdoVisGuess.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisGuess.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatAppearance.BorderSize = 2
        Me.rdoVisGuess.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisGuess.Location = New System.Drawing.Point(252, 11)
        Me.rdoVisGuess.Name = "rdoVisGuess"
        Me.rdoVisGuess.Size = New System.Drawing.Size(100, 28)
        Me.rdoVisGuess.TabIndex = 3
        Me.rdoVisGuess.TabStop = True
        Me.rdoVisGuess.Text = "Guess"
        Me.rdoVisGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisGuess.UseVisualStyleBackColor = True
        '
        'rdoWholeDataFrame
        '
        Me.rdoWholeDataFrame.AutoSize = True
        Me.rdoWholeDataFrame.Location = New System.Drawing.Point(243, 80)
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.Size = New System.Drawing.Size(80, 17)
        Me.rdoWholeDataFrame.TabIndex = 6
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.Text = "Data Frame"
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedColumn
        '
        Me.rdoSelectedColumn.AutoSize = True
        Me.rdoSelectedColumn.Location = New System.Drawing.Point(243, 103)
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.Size = New System.Drawing.Size(113, 17)
        Me.rdoSelectedColumn.TabIndex = 7
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.Text = "Selected Variables"
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'lblPalette
        '
        Me.lblPalette.AutoSize = True
        Me.lblPalette.Location = New System.Drawing.Point(22, 272)
        Me.lblPalette.Name = "lblPalette"
        Me.lblPalette.Size = New System.Drawing.Size(43, 13)
        Me.lblPalette.TabIndex = 13
        Me.lblPalette.Text = "Palette:"
        '
        'lblMaximumSize
        '
        Me.lblMaximumSize.AutoSize = True
        Me.lblMaximumSize.Location = New System.Drawing.Point(5, 305)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(77, 13)
        Me.lblMaximumSize.TabIndex = 15
        Me.lblMaximumSize.Text = "Maximum Size:"
        '
        'lblMillionDataPoints
        '
        Me.lblMillionDataPoints.AutoSize = True
        Me.lblMillionDataPoints.Location = New System.Drawing.Point(154, 305)
        Me.lblMillionDataPoints.Name = "lblMillionDataPoints"
        Me.lblMillionDataPoints.Size = New System.Drawing.Size(94, 13)
        Me.lblMillionDataPoints.TabIndex = 16
        Me.lblMillionDataPoints.Text = "Million Data Points"
        '
        'lblPaltte
        '
        Me.lblPaltte.AutoSize = True
        Me.lblPaltte.Location = New System.Drawing.Point(22, 272)
        Me.lblPaltte.Name = "lblPaltte"
        Me.lblPaltte.Size = New System.Drawing.Size(43, 13)
        Me.lblPaltte.TabIndex = 21
        Me.lblPaltte.Text = "Palette:"
        '
        'lblMaximumS
        '
        Me.lblMaximumS.AutoSize = True
        Me.lblMaximumS.Location = New System.Drawing.Point(5, 305)
        Me.lblMaximumS.Name = "lblMaximumS"
        Me.lblMaximumS.Size = New System.Drawing.Size(77, 13)
        Me.lblMaximumS.TabIndex = 24
        Me.lblMaximumS.Text = "Maximum Size:"
        '
        'lblDataPoints
        '
        Me.lblDataPoints.AutoSize = True
        Me.lblDataPoints.Location = New System.Drawing.Point(154, 305)
        Me.lblDataPoints.Name = "lblDataPoints"
        Me.lblDataPoints.Size = New System.Drawing.Size(94, 13)
        Me.lblDataPoints.TabIndex = 25
        Me.lblDataPoints.Text = "Million Data Points"
        '
        'lblSampling
        '
        Me.lblSampling.AutoSize = True
        Me.lblSampling.Enabled = False
        Me.lblSampling.Location = New System.Drawing.Point(213, 268)
        Me.lblSampling.Name = "lblSampling"
        Me.lblSampling.Size = New System.Drawing.Size(94, 13)
        Me.lblSampling.TabIndex = 27
        Me.lblSampling.Text = "Sampling Fraction:"
        '
        'ucrNudSamplingFunction
        '
        Me.ucrNudSamplingFunction.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSamplingFunction.Enabled = False
        Me.ucrNudSamplingFunction.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSamplingFunction.Location = New System.Drawing.Point(313, 265)
        Me.ucrNudSamplingFunction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSamplingFunction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSamplingFunction.Name = "ucrNudSamplingFunction"
        Me.ucrNudSamplingFunction.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSamplingFunction.TabIndex = 26
        Me.ucrNudSamplingFunction.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaximum
        '
        Me.ucrNudMaximum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximum.Location = New System.Drawing.Point(98, 302)
        Me.ucrNudMaximum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximum.Name = "ucrNudMaximum"
        Me.ucrNudMaximum.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaximum.TabIndex = 23
        Me.ucrNudMaximum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaximumSize
        '
        Me.ucrNudMaximumSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximumSize.Location = New System.Drawing.Point(98, 302)
        Me.ucrNudMaximumSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Name = "ucrNudMaximumSize"
        Me.ucrNudMaximumSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaximumSize.TabIndex = 22
        Me.ucrNudMaximumSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputComboboxPaletteGuess
        '
        Me.ucrInputComboboxPaletteGuess.AddQuotesIfUnrecognised = True
        Me.ucrInputComboboxPaletteGuess.GetSetSelectedIndex = -1
        Me.ucrInputComboboxPaletteGuess.IsReadOnly = False
        Me.ucrInputComboboxPaletteGuess.Location = New System.Drawing.Point(97, 268)
        Me.ucrInputComboboxPaletteGuess.Name = "ucrInputComboboxPaletteGuess"
        Me.ucrInputComboboxPaletteGuess.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputComboboxPaletteGuess.TabIndex = 20
        '
        'ucrChkSortMiss
        '
        Me.ucrChkSortMiss.Checked = False
        Me.ucrChkSortMiss.Location = New System.Drawing.Point(6, 244)
        Me.ucrChkSortMiss.Name = "ucrChkSortMiss"
        Me.ucrChkSortMiss.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkSortMiss.TabIndex = 19
        '
        'ucrChkSortVariables
        '
        Me.ucrChkSortVariables.Checked = False
        Me.ucrChkSortVariables.Location = New System.Drawing.Point(6, 244)
        Me.ucrChkSortVariables.Name = "ucrChkSortVariables"
        Me.ucrChkSortVariables.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkSortVariables.TabIndex = 18
        '
        'ucrInputComboboxPalette
        '
        Me.ucrInputComboboxPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputComboboxPalette.GetSetSelectedIndex = -1
        Me.ucrInputComboboxPalette.IsReadOnly = False
        Me.ucrInputComboboxPalette.Location = New System.Drawing.Point(97, 268)
        Me.ucrInputComboboxPalette.Name = "ucrInputComboboxPalette"
        Me.ucrInputComboboxPalette.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputComboboxPalette.TabIndex = 12
        '
        'ucrReceiverVisualizeData
        '
        Me.ucrReceiverVisualizeData.frmParent = Me
        Me.ucrReceiverVisualizeData.Location = New System.Drawing.Point(243, 130)
        Me.ucrReceiverVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVisualizeData.Name = "ucrReceiverVisualizeData"
        Me.ucrReceiverVisualizeData.Selector = Nothing
        Me.ucrReceiverVisualizeData.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverVisualizeData.strNcFilePath = ""
        Me.ucrReceiverVisualizeData.TabIndex = 8
        Me.ucrReceiverVisualizeData.ucrSelector = Nothing
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(235, 80)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(133, 40)
        Me.ucrPnlSelectData.TabIndex = 5
        '
        'ucrPnlVisualizeData
        '
        Me.ucrPnlVisualizeData.Location = New System.Drawing.Point(44, 1)
        Me.ucrPnlVisualizeData.Name = "ucrPnlVisualizeData"
        Me.ucrPnlVisualizeData.Size = New System.Drawing.Size(324, 46)
        Me.ucrPnlVisualizeData.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(4, 330)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(264, 24)
        Me.ucrSaveGraph.TabIndex = 9
        '
        'ucrSelectorVisualizeData
        '
        Me.ucrSelectorVisualizeData.bDropUnusedFilterLevels = False
        Me.ucrSelectorVisualizeData.bShowHiddenColumns = False
        Me.ucrSelectorVisualizeData.bUseCurrentFilter = True
        Me.ucrSelectorVisualizeData.Location = New System.Drawing.Point(10, 50)
        Me.ucrSelectorVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVisualizeData.Name = "ucrSelectorVisualizeData"
        Me.ucrSelectorVisualizeData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorVisualizeData.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 358)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'dlgVisualizeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 413)
        Me.Controls.Add(Me.lblSampling)
        Me.Controls.Add(Me.ucrNudSamplingFunction)
        Me.Controls.Add(Me.lblDataPoints)
        Me.Controls.Add(Me.lblMaximumS)
        Me.Controls.Add(Me.ucrNudMaximum)
        Me.Controls.Add(Me.ucrNudMaximumSize)
        Me.Controls.Add(Me.lblPaltte)
        Me.Controls.Add(Me.ucrInputComboboxPaletteGuess)
        Me.Controls.Add(Me.ucrChkSortMiss)
        Me.Controls.Add(Me.ucrChkSortVariables)
        Me.Controls.Add(Me.lblMillionDataPoints)
        Me.Controls.Add(Me.lblMaximumSize)
        Me.Controls.Add(Me.lblPalette)
        Me.Controls.Add(Me.ucrInputComboboxPalette)
        Me.Controls.Add(Me.ucrReceiverVisualizeData)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.rdoVisGuess)
        Me.Controls.Add(Me.rdoVisMiss)
        Me.Controls.Add(Me.rdoVisDat)
        Me.Controls.Add(Me.ucrPnlVisualizeData)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrSelectorVisualizeData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgVisualizeData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualise Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorVisualizeData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrPnlVisualizeData As UcrPanel
    Friend WithEvents rdoVisDat As RadioButton
    Friend WithEvents rdoVisMiss As RadioButton
    Friend WithEvents rdoVisGuess As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents ucrReceiverVisualizeData As ucrReceiverMultiple
    Friend WithEvents ucrInputComboboxPalette As ucrInputComboBox
    Friend WithEvents lblPalette As Label
    Friend WithEvents lblMillionDataPoints As Label
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents ucrChkSortVariables As ucrCheck
    Friend WithEvents ucrChkSortMiss As ucrCheck
    Friend WithEvents ucrInputComboboxPaletteGuess As ucrInputComboBox
    Friend WithEvents lblPaltte As Label
    Friend WithEvents ucrNudMaximumSize As ucrNud
    Friend WithEvents ucrNudMaximum As ucrNud
    Friend WithEvents lblMaximumS As Label
    Friend WithEvents lblDataPoints As Label
    Friend WithEvents lblSampling As Label
    Friend WithEvents ucrNudSamplingFunction As ucrNud
End Class