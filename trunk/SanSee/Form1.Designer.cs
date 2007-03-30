using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;

namespace SanSee
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_TOVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_IzgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_Farm_GroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_FarmG_level2StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_Farm_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SPR_CountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_SubstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_Place_storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_EIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SPR_FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mDataSet = new SanSee.MDataSet();
            this.sPR_TOVTableAdapter = new SanSee.MDataSetTableAdapters.SPR_TOVTableAdapter();
            this.sPR_IzgTableAdapter = new SanSee.MDataSetTableAdapters.SPR_IzgTableAdapter();
            this.sPR_CountryTableAdapter = new SanSee.MDataSetTableAdapters.SPR_CountryTableAdapter();
            this.sPR_EITableAdapter = new SanSee.MDataSetTableAdapters.SPR_EITableAdapter();
            this.sPR_Farm_GroupTableAdapter = new SanSee.MDataSetTableAdapters.SPR_Farm_GroupTableAdapter();
            this.sPR_FarmG_level2TableAdapter = new SanSee.MDataSetTableAdapters.SPR_FarmG_level2TableAdapter();
            this.sPR_FormTableAdapter = new SanSee.MDataSetTableAdapters.SPR_FormTableAdapter();
            this.sPR_Place_storageTableAdapter = new SanSee.MDataSetTableAdapters.SPR_Place_storageTableAdapter();
            this.sPR_SubstanceTableAdapter = new SanSee.MDataSetTableAdapters.SPR_SubstanceTableAdapter();
            this.sPR_REGTableAdapter = new SanSee.MDataSetTableAdapters.SPR_REGTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SPR_TOVToolStripMenuItem,
            this.SPR_IzgToolStripMenuItem,
            this.SPR_Farm_GroupToolStripMenuItem,
            this.toolStripSeparator1,
            this.SPR_CountryToolStripMenuItem,
            this.SPR_SubstanceToolStripMenuItem,
            this.SPR_Place_storageToolStripMenuItem,
            this.SPR_EIToolStripMenuItem,
            this.SPR_FormToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItem1.Text = "Справочники";
            // 
            // SPR_TOVToolStripMenuItem
            // 
            this.SPR_TOVToolStripMenuItem.AccessibleName = "SPR_TOV";
            this.SPR_TOVToolStripMenuItem.Name = "SPR_TOVToolStripMenuItem";
            this.SPR_TOVToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_TOVToolStripMenuItem.Tag = "UC_SPR_TOV";
            this.SPR_TOVToolStripMenuItem.Text = "Товаров";
            this.SPR_TOVToolStripMenuItem.ToolTipText = "Справочник товаров";
            this.SPR_TOVToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SPR_IzgToolStripMenuItem
            // 
            this.SPR_IzgToolStripMenuItem.AccessibleName = "SPR_Izg";
            this.SPR_IzgToolStripMenuItem.Name = "SPR_IzgToolStripMenuItem";
            this.SPR_IzgToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_IzgToolStripMenuItem.Tag = "UCSPR";
            this.SPR_IzgToolStripMenuItem.Text = "Изготовителей";
            this.SPR_IzgToolStripMenuItem.ToolTipText = "Справочник изготовителей";
            this.SPR_IzgToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SPR_Farm_GroupToolStripMenuItem
            // 
            this.SPR_Farm_GroupToolStripMenuItem.AccessibleName = "SPR_Farm_Group";
            this.SPR_Farm_GroupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SPR_FarmG_level2StripMenuItem,
            this.SPR_Farm_Group});
            this.SPR_Farm_GroupToolStripMenuItem.Name = "SPR_Farm_GroupToolStripMenuItem";
            this.SPR_Farm_GroupToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_Farm_GroupToolStripMenuItem.Tag = "UCSPR";
            this.SPR_Farm_GroupToolStripMenuItem.Text = "Фармгрупп";
            this.SPR_Farm_GroupToolStripMenuItem.ToolTipText = "Справочник фармгрупп";
            // 
            // SPR_FarmG_level2StripMenuItem
            // 
            this.SPR_FarmG_level2StripMenuItem.AccessibleName = "SPR_FarmG_level2";
            this.SPR_FarmG_level2StripMenuItem.Name = "SPR_FarmG_level2StripMenuItem";
            this.SPR_FarmG_level2StripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.SPR_FarmG_level2StripMenuItem.Tag = "UCSPR";
            this.SPR_FarmG_level2StripMenuItem.Text = "Все группы";
            this.SPR_FarmG_level2StripMenuItem.ToolTipText = "Справочник фармгрупп";
            this.SPR_FarmG_level2StripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SPR_Farm_Group
            // 
            this.SPR_Farm_Group.AccessibleName = "SPR_Farm_Group";
            this.SPR_Farm_Group.Name = "SPR_Farm_Group";
            this.SPR_Farm_Group.Size = new System.Drawing.Size(142, 22);
            this.SPR_Farm_Group.Tag = "UCSPR";
            this.SPR_Farm_Group.Text = "Основные";
            this.SPR_Farm_Group.ToolTipText = "Основные";
            this.SPR_Farm_Group.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // SPR_CountryToolStripMenuItem
            // 
            this.SPR_CountryToolStripMenuItem.AccessibleName = "SPR_Country";
            this.SPR_CountryToolStripMenuItem.Name = "SPR_CountryToolStripMenuItem";
            this.SPR_CountryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_CountryToolStripMenuItem.Tag = "UCSPR";
            this.SPR_CountryToolStripMenuItem.Text = "Стран";
            this.SPR_CountryToolStripMenuItem.ToolTipText = "Справочник стран";
            this.SPR_CountryToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SPR_SubstanceToolStripMenuItem
            // 
            this.SPR_SubstanceToolStripMenuItem.AccessibleName = "SPR_Substance";
            this.SPR_SubstanceToolStripMenuItem.Name = "SPR_SubstanceToolStripMenuItem";
            this.SPR_SubstanceToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_SubstanceToolStripMenuItem.Tag = "UCSPR";
            this.SPR_SubstanceToolStripMenuItem.Text = "Действующих веществ";
            this.SPR_SubstanceToolStripMenuItem.ToolTipText = "Действующие вещества (все)";
            this.SPR_SubstanceToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SPR_Place_storageToolStripMenuItem
            // 
            this.SPR_Place_storageToolStripMenuItem.AccessibleName = "SPR_Place_storage";
            this.SPR_Place_storageToolStripMenuItem.Name = "SPR_Place_storageToolStripMenuItem";
            this.SPR_Place_storageToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_Place_storageToolStripMenuItem.Tag = "UCSPR";
            this.SPR_Place_storageToolStripMenuItem.Text = "Мест хранения";
            this.SPR_Place_storageToolStripMenuItem.ToolTipText = "Места хранения (все)";
            this.SPR_Place_storageToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SPR_EIToolStripMenuItem
            // 
            this.SPR_EIToolStripMenuItem.AccessibleName = "SPR_EI";
            this.SPR_EIToolStripMenuItem.Name = "SPR_EIToolStripMenuItem";
            this.SPR_EIToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_EIToolStripMenuItem.Tag = "UCSPR";
            this.SPR_EIToolStripMenuItem.Text = "Едениц измерения";
            this.SPR_EIToolStripMenuItem.ToolTipText = "Справочник едениц измерения";
            this.SPR_EIToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SPR_FormToolStripMenuItem
            // 
            this.SPR_FormToolStripMenuItem.AccessibleName = "SPR_Form";
            this.SPR_FormToolStripMenuItem.Name = "SPR_FormToolStripMenuItem";
            this.SPR_FormToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SPR_FormToolStripMenuItem.Tag = "UCSPR";
            this.SPR_FormToolStripMenuItem.Text = "Форм выпуска";
            this.SPR_FormToolStripMenuItem.ToolTipText = "Справочник форм выпуска";
            this.SPR_FormToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(496, 309);
            this.tabControl1.TabIndex = 2;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPR_TOVTableAdapter
            // 
            this.sPR_TOVTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_IzgTableAdapter
            // 
            this.sPR_IzgTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_CountryTableAdapter
            // 
            this.sPR_CountryTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_EITableAdapter
            // 
            this.sPR_EITableAdapter.ClearBeforeFill = true;
            // 
            // sPR_Farm_GroupTableAdapter
            // 
            this.sPR_Farm_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_FarmG_level2TableAdapter
            // 
            this.sPR_FarmG_level2TableAdapter.ClearBeforeFill = true;
            // 
            // sPR_FormTableAdapter
            // 
            this.sPR_FormTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_Place_storageTableAdapter
            // 
            this.sPR_Place_storageTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_SubstanceTableAdapter
            // 
            this.sPR_SubstanceTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_REGTableAdapter
            // 
            this.sPR_REGTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 355);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public class SanseeLocalizer : Localizer
        {
           public override string GetLocalizedString(StringId id)
            {
                switch (id)
                {
                    case StringId.None: return "Нет";
                    case StringId.CaptionError: return "CaptionError!!! я !";
                    case StringId.InvalidValueText: return "Неверное значение!";
                    case StringId.CheckChecked: return "Checked";
                    case StringId.CheckUnchecked: return "Unchecked";
                    case StringId.CheckIndeterminate: return "Неопределено";
                    case StringId.DateEditToday: return "Сегодня";
                    case StringId.DateEditClear: return "Очистить";
                    case StringId.OK: return "Да";
                    case StringId.Cancel: return "Отмена";
                    case StringId.NavigatorFirstButtonHint: return "Первый";
                    case StringId.NavigatorPreviousButtonHint: return "Пред.";
                    case StringId.NavigatorPreviousPageButtonHint: return "Пред. страница";
                    case StringId.NavigatorNextButtonHint: return "След.";
                    case StringId.NavigatorNextPageButtonHint: return "След. страница";
                    case StringId.NavigatorLastButtonHint: return "Последний";
                    case StringId.NavigatorAppendButtonHint: return "Добавить";
                    case StringId.NavigatorRemoveButtonHint: return "Удалить";
                    case StringId.NavigatorEditButtonHint: return "Изменить";
                    case StringId.NavigatorEndEditButtonHint: return "Принять изменения";
                    case StringId.NavigatorCancelEditButtonHint: return "Отменить изменения";
                    case StringId.NavigatorTextStringFormat: return "NavigatorTextStringFormat";
                    case StringId.PictureEditOpenFileFilter: return "Открыть FileFilter ";
                    case StringId.PictureEditSaveFileFilter: return "Сохранить FileFilter";
                    case StringId.PictureEditOpenFileTitle: return "Открыть файл";
                    case StringId.PictureEditSaveFileTitle: return "Сахранить в файл";
                    case StringId.PictureEditOpenFileError: return "Ошибка открытия!";
                    case StringId.PictureEditOpenFileErrorCaption: return "Ошибка открытия файла!";
                    case StringId.LookUpEditValueIsNull: return "Пустое значение";
                    case StringId.LookUpInvalidEditValueType: return "Ошибка типа переменной";
                    case StringId.LookUpColumnDefaultName: return "Имя по умолчанию";
                    case StringId.MaskBoxValidateError: return "Ошибка!";
                    case StringId.UnknownPictureFormat: return "Неизвесный формат рисунка";
                    case StringId.DataEmpty: return "Путо";
                    case StringId.NotValidArrayLength: return "Ошибка длины масива";
                    case StringId.ImagePopupEmpty: return "Пусто";
                    case StringId.ImagePopupPicture: return "Рисунок";
                    case StringId.ColorTabCustom: return "Другой";
                    case StringId.ColorTabWeb: return "Веб";
                    case StringId.ColorTabSystem: return "Системный";
                    case StringId.CalcButtonMC: return "MC";
                    case StringId.CalcButtonMR: return "MR";
                    case StringId.CalcButtonMS: return "MS";
                    case StringId.XtraMessageBoxIgnoreButtonText: return "Игнорировать";
                    case StringId.XtraMessageBoxRetryButtonText: return "Повторить";
                    case StringId.XtraMessageBoxAbortButtonText: return "Отменить";
                    case StringId.XtraMessageBoxNoButtonText: return "Нет";
                    case StringId.XtraMessageBoxYesButtonText: return "Да";
                    case StringId.XtraMessageBoxCancelButtonText: return "Отмена";
                    case StringId.XtraMessageBoxOkButtonText: return "Принять";
                    case StringId.TabHeaderButtonClose: return "Закрыть";
                    case StringId.TabHeaderButtonNext: return "Следующая";
                    case StringId.TabHeaderButtonPrev: return "Предыдущая";
                    case StringId.CalcError: return "CalcError";
                    case StringId.CalcButtonC: return "C";
                    case StringId.CalcButtonCE: return "CE";
                    case StringId.CalcButtonBack: return "Back";
                    case StringId.CalcButtonSqrt: return "Sqrt";
                    case StringId.CalcButtonMx: return "Mx";
                    case StringId.TextEditMenuUndo: return "Вернуть";
                    case StringId.TextEditMenuCut: return "Вырезать";
                    case StringId.TextEditMenuCopy: return "Копировать";
                    case StringId.TextEditMenuPaste: return "Вставить";
                    case StringId.TextEditMenuDelete: return "Удалить";
                    case StringId.TextEditMenuSelectAll: return "Выделить все";

                    case StringId.PictureEditMenuCut: return "Вырезать";
                    case StringId.PictureEditMenuCopy: return "Копировать";
                    case StringId.PictureEditMenuPaste: return "Вставить";
                    case StringId.PictureEditMenuDelete: return "Удалить";
                    case StringId.PictureEditMenuLoad: return "Загрузить";
                    // case StringId.PictureEditMenuSave: return "Сохранить";
                    // ...
                }
                return "kz-kz";
            }
        }
        public class SanseeGridLocalizer : GridLocalizer
         { public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FileIsNotFoundError: return "Файл не найден!";
                    case GridStringId.ColumnViewExceptionMessage: return "ColumnViewExceptionMessage";
                    case GridStringId.CustomizationCaption: return "Выбор полей";
                    case GridStringId.CustomizationColumns: return "CustomizationColumns";
                    case GridStringId.CustomizationBands: return "CustomizationBands";
                    case GridStringId.PopupFilterAll: return "Все записи";
                    case GridStringId.PopupFilterCustom: return "Настройка ...";
                    case GridStringId.PopupFilterBlanks: return "Пустые записи";
                    case GridStringId.PopupFilterNonBlanks: return "Непустые записи"; 
                    case GridStringId.CustomFilterDialogFormCaption: return "Настройка фильтра";
                    case GridStringId.CustomFilterDialogCaption: return "Параметры фильтра";
                    case GridStringId.CustomFilterDialogRadioAnd : return "И";
                    case GridStringId.CustomFilterDialogRadioOr: return "ИЛИ";
                    case GridStringId.CustomFilterDialogOkButton: return "Принять";
                    case GridStringId.CustomFilterDialogClearFilter : return "Очистить";
                    case GridStringId.CustomFilterDialog2FieldCheck: return "Выбрать";
                    case GridStringId.CustomFilterDialogCancelButton: return "Отмена";
                    case GridStringId.CustomFilterDialogConditionEQU: return "Равно";
                    case GridStringId.CustomFilterDialogConditionNEQ: return "Не равно";
                    case GridStringId.CustomFilterDialogConditionGT: return "Больше";
                    case GridStringId.CustomFilterDialogConditionGTE: return "Больше или равно";
                    case GridStringId.CustomFilterDialogConditionLT: return "Меньше";
                    case GridStringId.CustomFilterDialogConditionLTE: return "Меньше или равно";
                    case GridStringId.CustomFilterDialogConditionBlanks: return "пустое";
                    case GridStringId.CustomFilterDialogConditionNonBlanks: return "не пустое"; 
                    case GridStringId.CustomFilterDialogConditionLike: return "Содержит";
                    case GridStringId.CustomFilterDialogConditionNotLike: return "Не содержит";
                    case GridStringId.WindowErrorCaption: return "Ошибка!";
                    case GridStringId.MenuFooterSum: return "Сумма";
                    case GridStringId.MenuFooterMin: return "Минимум";
                    case GridStringId.MenuFooterMax: return "Максимум";
                    case GridStringId.MenuFooterCount: return "Количество";
                    case GridStringId.MenuFooterAverage: return "Среднее"; 
                    case GridStringId.MenuFooterNone: return "Нет";
                    case GridStringId.MenuFooterSumFormat: return "Формат суммы";

                    case GridStringId.MenuFooterMinFormat: return "Формат мин";
                    case GridStringId.MenuFooterMaxFormat: return "Формат макс";
                    case GridStringId.MenuFooterCountFormat: return "Формат кол.";
                    case GridStringId.MenuFooterAverageFormat: return "Формат средн.";
                    case GridStringId.MenuColumnSortAscending: return "По возрастанию";
                    case GridStringId.MenuColumnSortDescending: return "По убыванию"; 
                    case GridStringId.MenuColumnGroup: return "Группировать...";
                    case GridStringId.MenuColumnUnGroup: return "Разгуппировать...";
                    case GridStringId.MenuGroupPanelFullCollapse: return "Свернуть все"; 
                    case GridStringId.MenuGroupPanelFullExpand : return "Развернуть все";
                    case GridStringId.MenuColumnBestFitAllColumns: return "Автоформат таблицы";
                    case GridStringId.MenuColumnClearFilter: return "Очистить фильтр";
                    case GridStringId.MenuColumnFilter: return "Фильтр";
                    case GridStringId.MenuColumnBestFit: return "Автоподбор ширины";
                    case GridStringId.MenuColumnColumnCustomization: return "Настройка полей";
                    case GridStringId.MenuColumnGroupBox: return "Панель группировки";
                    case GridStringId.PrintDesignerBandHeader: return "PrintDesignerBandHeader";
                    case GridStringId.PrintDesignerBandedView: return "PrintDesignerBandedView";
                    case GridStringId.PrintDesignerCardView: return "PrintDesignerCardView";
                    case GridStringId.PrintDesignerGridView: return "PrintDesignerGridView";
                    case GridStringId.MenuGroupPanelClearGrouping: return "Отменить группировку";
                    case GridStringId.PrintDesignerDescription: return "PrintDesignerDescription";
                    case GridStringId.GridOutlookIntervals: return "GridOutlookIntervals";
                    case GridStringId.GridNewRowText: return "Новая строка";
                    case GridStringId.GridGroupPanelText: return "Группировать..."; 
                    case GridStringId.CardViewQuickCustomizationButtonSort: return "Сортировать";
                    case GridStringId.CardViewQuickCustomizationButtonFilter : return "Фильтр";
                    case GridStringId.CardViewQuickCustomizationButton: return "Натройка";
                    case GridStringId.CardViewNewCard: return "Новая запись";
                 
                }
                return "GridString не найдена";
            }
        }

        public void FillTable (string NameTable)
        {

            switch (NameTable)
            {
                case "SPR_TOV":
                    this.sPR_TOVTableAdapter.Fill(this.mDataSet.SPR_TOV);
                    break;

                case "SPR_Izg":
                    this.sPR_IzgTableAdapter.Fill(this.mDataSet.SPR_Izg);                                   
                    break;
                
                case "SPR_Country":
                    this.sPR_CountryTableAdapter.Fill(this.mDataSet.SPR_Country);
                    break;

                case "SPR_EI":
                    this.sPR_EITableAdapter.Fill(this.mDataSet.SPR_EI);
                    break;

                case "SPR_Farm_Group":
                    this.sPR_Farm_GroupTableAdapter.Fill(this.mDataSet.SPR_Farm_Group);
                    break;

                case "SPR_FarmG_level2":

                    this.sPR_FarmG_level2TableAdapter.Fill(this.mDataSet.SPR_FarmG_level2);
                    break;
                case "SPR_Place_storage":
                    this.sPR_Place_storageTableAdapter.Fill( this.mDataSet.SPR_Place_storage);
                    break;
                case "SPR_Substance":
                    this.sPR_SubstanceTableAdapter.Fill(this.mDataSet.SPR_Substance);
                    break;
                case "SPR_REG":
                    this.sPR_REGTableAdapter.Fill(this.mDataSet.SPR_REG);
                    break;
                case "SPR_Form":
                    this.sPR_FormTableAdapter.Fill(this.mDataSet.SPR_Form);
                    break;

                default:
                    break;

            };

        }
        public void SaveToBase(string NameTable)
        {

            switch (NameTable)
            {
                case "SPR_TOV":
                    try
                    {
                      this.sPR_TOVTableAdapter.Update(this.mDataSet.SPR_TOV);
                
                    }
                    catch (System.Exception ex)
                    {
                       MessageBox.Show(ex.Message);

              /*       foreach (DataRow item in mDataSet.SPR_TOV.GetErrors())
                          {
                              string tmp;

                              if (item.HasErrors)
                              {
                                  MessageBox.Show(item["IDF_Form", DataRowVersion.Current].ToString());
                                  MessageBox.Show(item[6, DataRowVersion.Default].ToString());
                                  MessageBox.Show(item[6, DataRowVersion.Original].ToString());

                                  tmp = item[1, DataRowVersion.Current].ToString();

                                  this.sPR_IzgTableAdapter.ClearBeforeFill = false;
                                  this.sPR_IzgTableAdapter.FillByID(this.MdataSet.SPR_Izg, (int)item[0]);
                                  item[1] = tmp;

                                  SaveToBase(tablename);
                              }
                          }*/
                    }
           
                   break;

                case "SPR_Izg":
                                 
                        try
                        {
                            this.sPR_IzgTableAdapter.Update(this.mDataSet.SPR_Izg);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                      }
                    break;

                case "SPR_Country":
                    try
                    {
                        this.sPR_CountryTableAdapter.Update(this.mDataSet.SPR_Country);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                case "SPR_EI":
                    try
                    {
                        this.sPR_EITableAdapter.Update(this.mDataSet.SPR_EI);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "SPR_Farm_Group":
                    try
                    {
                        this.sPR_Farm_GroupTableAdapter.Update(this.mDataSet.SPR_Farm_Group);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "SPR_FarmG_level2":

                    try
                    {
                        this.sPR_FarmG_level2TableAdapter.Update(this.mDataSet.SPR_FarmG_level2);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                   
                case "SPR_Place_storage":
                    try
                    {
                        this.sPR_Place_storageTableAdapter.Update(this.mDataSet.SPR_Place_storage);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                case "SPR_Substance":
                    try
                    {
                        this.sPR_SubstanceTableAdapter.Update(this.mDataSet.SPR_Substance);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                case "SPR_REG":
                    try
                    {
                        this.sPR_REGTableAdapter.Update(this.mDataSet.SPR_REG);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                case "SPR_Form":
                    try
                    {
                        this.sPR_FormTableAdapter.Update(this.mDataSet.SPR_Form);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                default:
                    break;

            };
        
        
        }
        public void RejectChanges(string NameTable)
        {

            switch (NameTable)
            {
                case "SPR_TOV":
                   // this.sPR_TOVTableAdapter Fill();
                    this.mDataSet.SPR_TOV.RejectChanges();
                    break;

                case "SPR_Izg":
                    this.sPR_IzgTableAdapter.Fill(this.mDataSet.SPR_Izg);
                    break;

                case "SPR_Country":
                    this.sPR_CountryTableAdapter.Fill(this.mDataSet.SPR_Country);
                    break;

                case "SPR_EI":
                    this.sPR_EITableAdapter.Fill(this.mDataSet.SPR_EI);
                    break;

                case "SPR_Farm_Group":
                    this.sPR_Farm_GroupTableAdapter.Fill(this.mDataSet.SPR_Farm_Group);
                    break;

                case "SPR_FarmG_level2":

                    this.sPR_FarmG_level2TableAdapter.Fill(this.mDataSet.SPR_FarmG_level2);
                    break;
                case "SPR_Place_storage":
                    this.sPR_Place_storageTableAdapter.Fill(this.mDataSet.SPR_Place_storage);
                    break;
                case "SPR_Substance":
                    this.sPR_SubstanceTableAdapter.Fill(this.mDataSet.SPR_Substance);
                    break;
                case "SPR_REG":
                    this.sPR_REGTableAdapter.Fill(this.mDataSet.SPR_REG);
                    break;
                case "SPR_Form":
                    this.sPR_FormTableAdapter.Fill(this.mDataSet.SPR_Form);
                    break;

                default:
                    break;

            };

        }
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SPR_TOVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SPR_IzgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SPR_CountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SPR_FormToolStripMenuItem;
        internal System.Windows.Forms.TabControl tabControl1;
        internal MDataSet mDataSet;

        private MDataSetTableAdapters.SPR_TOVTableAdapter sPR_TOVTableAdapter;
        private MDataSetTableAdapters.SPR_IzgTableAdapter sPR_IzgTableAdapter;
        private MDataSetTableAdapters.SPR_CountryTableAdapter sPR_CountryTableAdapter;
        private MDataSetTableAdapters.SPR_EITableAdapter sPR_EITableAdapter;
        private MDataSetTableAdapters.SPR_Farm_GroupTableAdapter sPR_Farm_GroupTableAdapter;
        private MDataSetTableAdapters.SPR_FarmG_level2TableAdapter sPR_FarmG_level2TableAdapter;
        private MDataSetTableAdapters.SPR_FormTableAdapter sPR_FormTableAdapter;
        private MDataSetTableAdapters.SPR_Place_storageTableAdapter sPR_Place_storageTableAdapter;
        private MDataSetTableAdapters.SPR_SubstanceTableAdapter sPR_SubstanceTableAdapter;
        private MDataSetTableAdapters.SPR_REGTableAdapter sPR_REGTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SPR_Place_storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SPR_EIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SPR_Farm_GroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SPR_SubstanceToolStripMenuItem;
        private ToolStripMenuItem SPR_FarmG_level2StripMenuItem;
        private ToolStripMenuItem SPR_Farm_Group;


    }
}

