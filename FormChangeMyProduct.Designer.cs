using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormChangeMyProduct
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

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = new Rectangle(0, 0, Width, Height);
            int CornerRadius = 12;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X + 0.7f, bounds.Y + 0.7f, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - CornerRadius, bounds.Y + 1f, CornerRadius - 1.7f, CornerRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - CornerRadius - 2.7f, bounds.Y + bounds.Height - CornerRadius - 2.7f, CornerRadius + 1, CornerRadius + 1, 0, 90);
            path.AddArc(bounds.X + 0.7f, bounds.Y + bounds.Height - CornerRadius - 2f, CornerRadius - 1.7f, CornerRadius, 90, 90);
            path.CloseAllFigures();
            Region = new Region(path);
            base.OnPaint(e);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeMyProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButtonRefreshMyProd = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonPublish = new MaterialSkin.Controls.MaterialButton();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxHouse = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxStreet2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.label15 = new System.Windows.Forms.Label();
            this.materialComboBoxCityForMyProd = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxStreet = new MaterialSkin.Controls.MaterialTextBox2();
            this.label14 = new System.Windows.Forms.Label();
            this.materialTextBoxNameOfMyProduct = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialMultiLineTextBoxDescForMyProd = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.materialComboBoxStatusForMyProd = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxCostForMyProd = new MaterialSkin.Controls.MaterialTextBox2();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.materialComboBoxCategoryForMyProd = new MaterialSkin.Controls.MaterialComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.materialButtonSelectPhotoForMyProduct = new MaterialSkin.Controls.MaterialButton();
            this.label8 = new System.Windows.Forms.Label();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBoxMyProductPicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.materialButtonRefreshMyProd);
            this.panel1.Controls.Add(this.materialButtonPublish);
            this.panel1.Controls.Add(this.materialCard9);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.materialButtonSelectPhotoForMyProduct);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.materialCard6);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 508);
            this.panel1.TabIndex = 16;
            // 
            // materialButtonRefreshMyProd
            // 
            this.materialButtonRefreshMyProd.AutoSize = false;
            this.materialButtonRefreshMyProd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonRefreshMyProd.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonRefreshMyProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonRefreshMyProd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonRefreshMyProd.Depth = 0;
            this.materialButtonRefreshMyProd.HighEmphasis = true;
            this.materialButtonRefreshMyProd.Icon = null;
            this.materialButtonRefreshMyProd.Location = new System.Drawing.Point(18, 402);
            this.materialButtonRefreshMyProd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonRefreshMyProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRefreshMyProd.Name = "materialButtonRefreshMyProd";
            this.materialButtonRefreshMyProd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRefreshMyProd.Size = new System.Drawing.Size(200, 37);
            this.materialButtonRefreshMyProd.TabIndex = 71;
            this.materialButtonRefreshMyProd.Text = "Сбросить";
            this.materialButtonRefreshMyProd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonRefreshMyProd.UseAccentColor = false;
            this.materialButtonRefreshMyProd.UseVisualStyleBackColor = true;
            this.materialButtonRefreshMyProd.Click += new System.EventHandler(this.materialButtonRefreshMyProd_Click);
            // 
            // materialButtonPublish
            // 
            this.materialButtonPublish.AutoSize = false;
            this.materialButtonPublish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPublish.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonPublish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPublish.Depth = 0;
            this.materialButtonPublish.HighEmphasis = true;
            this.materialButtonPublish.Icon = null;
            this.materialButtonPublish.Location = new System.Drawing.Point(18, 451);
            this.materialButtonPublish.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonPublish.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPublish.Name = "materialButtonPublish";
            this.materialButtonPublish.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPublish.Size = new System.Drawing.Size(200, 37);
            this.materialButtonPublish.TabIndex = 70;
            this.materialButtonPublish.Text = "Сохранить";
            this.materialButtonPublish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPublish.UseAccentColor = false;
            this.materialButtonPublish.UseVisualStyleBackColor = true;
            this.materialButtonPublish.Click += new System.EventHandler(this.materialButtonPublish_Click);
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.materialCard10);
            this.materialCard9.Controls.Add(this.materialTextBoxNameOfMyProduct);
            this.materialCard9.Controls.Add(this.materialMultiLineTextBoxDescForMyProd);
            this.materialCard9.Controls.Add(this.label13);
            this.materialCard9.Controls.Add(this.label10);
            this.materialCard9.Controls.Add(this.materialComboBoxStatusForMyProd);
            this.materialCard9.Controls.Add(this.materialTextBoxCostForMyProd);
            this.materialCard9.Controls.Add(this.label11);
            this.materialCard9.Controls.Add(this.label12);
            this.materialCard9.Controls.Add(this.materialComboBoxCategoryForMyProd);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(240, 51);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(545, 437);
            this.materialCard9.TabIndex = 69;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.materialTextBoxHouse);
            this.materialCard10.Controls.Add(this.materialTextBox22);
            this.materialCard10.Controls.Add(this.materialTextBoxStreet2);
            this.materialCard10.Controls.Add(this.label15);
            this.materialCard10.Controls.Add(this.materialComboBoxCityForMyProd);
            this.materialCard10.Controls.Add(this.materialTextBoxStreet);
            this.materialCard10.Controls.Add(this.label14);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(17, 302);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(423, 118);
            this.materialCard10.TabIndex = 65;
            // 
            // materialTextBoxHouse
            // 
            this.materialTextBoxHouse.AnimateReadOnly = false;
            this.materialTextBoxHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxHouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHouse.Depth = 0;
            this.materialTextBoxHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxHouse.HideSelection = true;
            this.materialTextBoxHouse.Hint = "Дом";
            this.materialTextBoxHouse.LeadingIcon = null;
            this.materialTextBoxHouse.Location = new System.Drawing.Point(320, 58);
            this.materialTextBoxHouse.MaxLength = 3;
            this.materialTextBoxHouse.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHouse.Name = "materialTextBoxHouse";
            this.materialTextBoxHouse.PasswordChar = '\0';
            this.materialTextBoxHouse.PrefixSuffixText = null;
            this.materialTextBoxHouse.ReadOnly = false;
            this.materialTextBoxHouse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxHouse.SelectedText = "";
            this.materialTextBoxHouse.SelectionLength = 0;
            this.materialTextBoxHouse.SelectionStart = 0;
            this.materialTextBoxHouse.ShortcutsEnabled = true;
            this.materialTextBoxHouse.Size = new System.Drawing.Size(67, 36);
            this.materialTextBoxHouse.TabIndex = 67;
            this.materialTextBoxHouse.TabStop = false;
            this.materialTextBoxHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHouse.TrailingIcon = null;
            this.materialTextBoxHouse.UseSystemPasswordChar = false;
            this.materialTextBoxHouse.UseTallSize = false;
            this.materialTextBoxHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxHouse_KeyPress);
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.Hint = "д.";
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(263, 58);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = true;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(51, 36);
            this.materialTextBox22.TabIndex = 66;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.Text = "д.";
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            this.materialTextBox22.UseTallSize = false;
            // 
            // materialTextBoxStreet2
            // 
            this.materialTextBoxStreet2.AnimateReadOnly = false;
            this.materialTextBoxStreet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxStreet2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxStreet2.Depth = 0;
            this.materialTextBoxStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxStreet2.HideSelection = true;
            this.materialTextBoxStreet2.Hint = "Улица";
            this.materialTextBoxStreet2.LeadingIcon = null;
            this.materialTextBoxStreet2.Location = new System.Drawing.Point(159, 58);
            this.materialTextBoxStreet2.MaxLength = 15;
            this.materialTextBoxStreet2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxStreet2.Name = "materialTextBoxStreet2";
            this.materialTextBoxStreet2.PasswordChar = '\0';
            this.materialTextBoxStreet2.PrefixSuffixText = null;
            this.materialTextBoxStreet2.ReadOnly = false;
            this.materialTextBoxStreet2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxStreet2.SelectedText = "";
            this.materialTextBoxStreet2.SelectionLength = 0;
            this.materialTextBoxStreet2.SelectionStart = 0;
            this.materialTextBoxStreet2.ShortcutsEnabled = true;
            this.materialTextBoxStreet2.Size = new System.Drawing.Size(98, 36);
            this.materialTextBoxStreet2.TabIndex = 65;
            this.materialTextBoxStreet2.TabStop = false;
            this.materialTextBoxStreet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxStreet2.TrailingIcon = null;
            this.materialTextBoxStreet2.UseSystemPasswordChar = false;
            this.materialTextBoxStreet2.UseTallSize = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(21, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 64;
            this.label15.Text = "Адрес:";
            // 
            // materialComboBoxCityForMyProd
            // 
            this.materialComboBoxCityForMyProd.AutoResize = false;
            this.materialComboBoxCityForMyProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxCityForMyProd.Depth = 0;
            this.materialComboBoxCityForMyProd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxCityForMyProd.DropDownHeight = 118;
            this.materialComboBoxCityForMyProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxCityForMyProd.DropDownWidth = 121;
            this.materialComboBoxCityForMyProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxCityForMyProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxCityForMyProd.FormattingEnabled = true;
            this.materialComboBoxCityForMyProd.Hint = "Город";
            this.materialComboBoxCityForMyProd.IntegralHeight = false;
            this.materialComboBoxCityForMyProd.ItemHeight = 29;
            this.materialComboBoxCityForMyProd.Items.AddRange(new object[] {
            "Альметьевск",
            "Ангарск",
            "Арзамас",
            "Армавир",
            "Артём",
            "Архангельск",
            "Астрахань",
            "Балаково",
            "Балашиха",
            "Барнаул",
            "Батайск",
            "Белгород",
            "Бердск",
            "Березники",
            "Бийск",
            "Благовещенск",
            "Братск",
            "Брянск",
            "Бугульма",
            "Великий Новгород",
            "Видное",
            "Владивосток",
            "Владикавказ",
            "Владимир",
            "Волгоград",
            "Волгодонск",
            "Волжский",
            "Вологда",
            "Воронеж",
            "Грозный",
            "Дербент",
            "Дзержинск",
            "Димитровград",
            "Долгопрудный",
            "Домодедово",
            "Евпатория",
            "Крым",
            "Екатеринбург",
            "Ессентуки",
            "Жуковский",
            "Златоуст",
            "Иваново",
            "Ижевск",
            "Иркутск",
            "Йошкар-Ола",
            "Казань",
            "Калининград",
            "Калуга",
            "Каменск-Уральский",
            "Камышин",
            "Каспийск",
            "Кемерово",
            "Киров",
            "Кисловодск",
            "Ковров",
            "Коломна",
            "Комсомольск-на-Амуре",
            "Копейск",
            "Королёв",
            "Кострома",
            "Красногорск",
            "Краснодар",
            "Красноярск",
            "Курган",
            "Курск",
            "Кызыл",
            "Липецк",
            "Люберцы",
            "Магнитогорск",
            "Майкоп",
            "Махачкала",
            "Миасс",
            "Михайловск",
            "Москва",
            "Мурино",
            "Мурманск",
            "Муром",
            "Мытищи",
            "Набережные Челны",
            "Назрань",
            "Нальчик",
            "Находка",
            "Невинномысск",
            "Нефтекамск",
            "Нефтеюганск",
            "Нижневартовск",
            "Нижнекамск",
            "Нижний Новгород",
            "Нижний Тагил",
            "Новокузнецк",
            "Новомосковск",
            "Новороссийск",
            "Новосибирск",
            "Новочебоксарск",
            "Новочеркасск",
            "Новошахтинск",
            "Новый Уренгой",
            "Ногинск",
            "Норильск",
            "Ноябрьск",
            "Обнинск",
            "Одинцово",
            "Октябрьский",
            "Омск",
            "Орёл",
            "Оренбург",
            "Орехово-Зуево",
            "Орск",
            "Пенза",
            "Первоуральск",
            "Пермь",
            "Петрозаводск",
            "Петропавловск-Камчатский",
            "Подольск",
            "Прокопьевск",
            "Псков",
            "Пушкино",
            "Пятигорск",
            "Раменское",
            "Реутов",
            "Ростов-на-Дону",
            "Рубцовск",
            "Рыбинск",
            "Рязань",
            "Салават",
            "Самара",
            "Санкт-Петербург",
            "Саранск",
            "Саратов",
            "Севастополь",
            "Северодвинск",
            "Северск",
            "Серпухов",
            "Симферополь",
            "Смоленск",
            "Сочи",
            "Ставрополь",
            "Старый Оскол",
            "Стерлитамак",
            "Сургут",
            "Сызрань",
            "Сыктывкар",
            "Таганрог",
            "Тамбов",
            "Тверь",
            "Тольятти",
            "Томск",
            "Тула",
            "Тюмень",
            "Улан-Удэ",
            "Ульяновск",
            "Уссурийск",
            "Уфа",
            "Хабаровск",
            "Ханты-Мансийск",
            "Хасавюрт",
            "Химки",
            "Чебоксары",
            "Челябинск",
            "Череповец",
            "Черкесск",
            "Чита",
            "Шахты",
            "Щёлково",
            "Электросталь",
            "Элиста",
            "Энгельс",
            "Южно-Сахалинск",
            "Якутск",
            "Ярославль"});
            this.materialComboBoxCityForMyProd.Location = new System.Drawing.Point(99, 17);
            this.materialComboBoxCityForMyProd.MaxDropDownItems = 4;
            this.materialComboBoxCityForMyProd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxCityForMyProd.Name = "materialComboBoxCityForMyProd";
            this.materialComboBoxCityForMyProd.Size = new System.Drawing.Size(288, 35);
            this.materialComboBoxCityForMyProd.StartIndex = 0;
            this.materialComboBoxCityForMyProd.TabIndex = 62;
            this.materialComboBoxCityForMyProd.UseTallSize = false;
            // 
            // materialTextBoxStreet
            // 
            this.materialTextBoxStreet.AnimateReadOnly = false;
            this.materialTextBoxStreet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxStreet.Depth = 0;
            this.materialTextBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxStreet.HideSelection = true;
            this.materialTextBoxStreet.Hint = "Ул.";
            this.materialTextBoxStreet.LeadingIcon = null;
            this.materialTextBoxStreet.Location = new System.Drawing.Point(100, 58);
            this.materialTextBoxStreet.MaxLength = 32767;
            this.materialTextBoxStreet.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxStreet.Name = "materialTextBoxStreet";
            this.materialTextBoxStreet.PasswordChar = '\0';
            this.materialTextBoxStreet.PrefixSuffixText = null;
            this.materialTextBoxStreet.ReadOnly = true;
            this.materialTextBoxStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxStreet.SelectedText = "";
            this.materialTextBoxStreet.SelectionLength = 0;
            this.materialTextBoxStreet.SelectionStart = 0;
            this.materialTextBoxStreet.ShortcutsEnabled = true;
            this.materialTextBoxStreet.Size = new System.Drawing.Size(53, 36);
            this.materialTextBoxStreet.TabIndex = 63;
            this.materialTextBoxStreet.TabStop = false;
            this.materialTextBoxStreet.Text = "Ул.";
            this.materialTextBoxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxStreet.TrailingIcon = null;
            this.materialTextBoxStreet.UseSystemPasswordChar = false;
            this.materialTextBoxStreet.UseTallSize = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(23, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 59;
            this.label14.Text = "Город:";
            // 
            // materialTextBoxNameOfMyProduct
            // 
            this.materialTextBoxNameOfMyProduct.AnimateReadOnly = false;
            this.materialTextBoxNameOfMyProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxNameOfMyProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxNameOfMyProduct.Depth = 0;
            this.materialTextBoxNameOfMyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxNameOfMyProduct.HideSelection = true;
            this.materialTextBoxNameOfMyProduct.Hint = "Название";
            this.materialTextBoxNameOfMyProduct.LeadingIcon = null;
            this.materialTextBoxNameOfMyProduct.Location = new System.Drawing.Point(17, 17);
            this.materialTextBoxNameOfMyProduct.MaxLength = 35;
            this.materialTextBoxNameOfMyProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxNameOfMyProduct.Name = "materialTextBoxNameOfMyProduct";
            this.materialTextBoxNameOfMyProduct.PasswordChar = '\0';
            this.materialTextBoxNameOfMyProduct.PrefixSuffixText = null;
            this.materialTextBoxNameOfMyProduct.ReadOnly = false;
            this.materialTextBoxNameOfMyProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxNameOfMyProduct.SelectedText = "";
            this.materialTextBoxNameOfMyProduct.SelectionLength = 0;
            this.materialTextBoxNameOfMyProduct.SelectionStart = 0;
            this.materialTextBoxNameOfMyProduct.ShortcutsEnabled = true;
            this.materialTextBoxNameOfMyProduct.Size = new System.Drawing.Size(250, 36);
            this.materialTextBoxNameOfMyProduct.TabIndex = 52;
            this.materialTextBoxNameOfMyProduct.TabStop = false;
            this.materialTextBoxNameOfMyProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxNameOfMyProduct.TrailingIcon = null;
            this.materialTextBoxNameOfMyProduct.UseSystemPasswordChar = false;
            this.materialTextBoxNameOfMyProduct.UseTallSize = false;
            // 
            // materialMultiLineTextBoxDescForMyProd
            // 
            this.materialMultiLineTextBoxDescForMyProd.AnimateReadOnly = false;
            this.materialMultiLineTextBoxDescForMyProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMultiLineTextBoxDescForMyProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialMultiLineTextBoxDescForMyProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialMultiLineTextBoxDescForMyProd.Depth = 0;
            this.materialMultiLineTextBoxDescForMyProd.HideSelection = true;
            this.materialMultiLineTextBoxDescForMyProd.Hint = "Описание";
            this.materialMultiLineTextBoxDescForMyProd.Location = new System.Drawing.Point(17, 70);
            this.materialMultiLineTextBoxDescForMyProd.MaxLength = 350;
            this.materialMultiLineTextBoxDescForMyProd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMultiLineTextBoxDescForMyProd.Name = "materialMultiLineTextBoxDescForMyProd";
            this.materialMultiLineTextBoxDescForMyProd.PasswordChar = '\0';
            this.materialMultiLineTextBoxDescForMyProd.ReadOnly = false;
            this.materialMultiLineTextBoxDescForMyProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialMultiLineTextBoxDescForMyProd.SelectedText = "";
            this.materialMultiLineTextBoxDescForMyProd.SelectionLength = 0;
            this.materialMultiLineTextBoxDescForMyProd.SelectionStart = 0;
            this.materialMultiLineTextBoxDescForMyProd.ShortcutsEnabled = true;
            this.materialMultiLineTextBoxDescForMyProd.Size = new System.Drawing.Size(250, 187);
            this.materialMultiLineTextBoxDescForMyProd.TabIndex = 54;
            this.materialMultiLineTextBoxDescForMyProd.TabStop = false;
            this.materialMultiLineTextBoxDescForMyProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMultiLineTextBoxDescForMyProd.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(13, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 61;
            this.label13.Text = "Место сделки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(287, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Состояние";
            // 
            // materialComboBoxStatusForMyProd
            // 
            this.materialComboBoxStatusForMyProd.AutoResize = false;
            this.materialComboBoxStatusForMyProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxStatusForMyProd.Depth = 0;
            this.materialComboBoxStatusForMyProd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxStatusForMyProd.DropDownHeight = 118;
            this.materialComboBoxStatusForMyProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxStatusForMyProd.DropDownWidth = 121;
            this.materialComboBoxStatusForMyProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxStatusForMyProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxStatusForMyProd.FormattingEnabled = true;
            this.materialComboBoxStatusForMyProd.Hint = "Выбрать";
            this.materialComboBoxStatusForMyProd.IntegralHeight = false;
            this.materialComboBoxStatusForMyProd.ItemHeight = 29;
            this.materialComboBoxStatusForMyProd.Items.AddRange(new object[] {
            "Новое",
            "Отличное",
            "Хорошее",
            "Удовлетворительное",
            "Требует ремонта"});
            this.materialComboBoxStatusForMyProd.Location = new System.Drawing.Point(291, 36);
            this.materialComboBoxStatusForMyProd.MaxDropDownItems = 4;
            this.materialComboBoxStatusForMyProd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxStatusForMyProd.Name = "materialComboBoxStatusForMyProd";
            this.materialComboBoxStatusForMyProd.Size = new System.Drawing.Size(237, 35);
            this.materialComboBoxStatusForMyProd.StartIndex = 0;
            this.materialComboBoxStatusForMyProd.TabIndex = 56;
            this.materialComboBoxStatusForMyProd.UseTallSize = false;
            // 
            // materialTextBoxCostForMyProd
            // 
            this.materialTextBoxCostForMyProd.AnimateReadOnly = false;
            this.materialTextBoxCostForMyProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxCostForMyProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxCostForMyProd.Depth = 0;
            this.materialTextBoxCostForMyProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxCostForMyProd.HideSelection = true;
            this.materialTextBoxCostForMyProd.Hint = "Цена";
            this.materialTextBoxCostForMyProd.LeadingIcon = null;
            this.materialTextBoxCostForMyProd.Location = new System.Drawing.Point(291, 220);
            this.materialTextBoxCostForMyProd.MaxLength = 10;
            this.materialTextBoxCostForMyProd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxCostForMyProd.Name = "materialTextBoxCostForMyProd";
            this.materialTextBoxCostForMyProd.PasswordChar = '\0';
            this.materialTextBoxCostForMyProd.PrefixSuffixText = null;
            this.materialTextBoxCostForMyProd.ReadOnly = false;
            this.materialTextBoxCostForMyProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxCostForMyProd.SelectedText = "";
            this.materialTextBoxCostForMyProd.SelectionLength = 0;
            this.materialTextBoxCostForMyProd.SelectionStart = 0;
            this.materialTextBoxCostForMyProd.ShortcutsEnabled = true;
            this.materialTextBoxCostForMyProd.Size = new System.Drawing.Size(237, 36);
            this.materialTextBoxCostForMyProd.TabIndex = 60;
            this.materialTextBoxCostForMyProd.TabStop = false;
            this.materialTextBoxCostForMyProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxCostForMyProd.TrailingIcon = null;
            this.materialTextBoxCostForMyProd.UseSystemPasswordChar = false;
            this.materialTextBoxCostForMyProd.UseTallSize = false;
            this.materialTextBoxCostForMyProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxCostForMyProd_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(287, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Категория";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(287, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Стоимость";
            // 
            // materialComboBoxCategoryForMyProd
            // 
            this.materialComboBoxCategoryForMyProd.AutoResize = false;
            this.materialComboBoxCategoryForMyProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxCategoryForMyProd.Depth = 0;
            this.materialComboBoxCategoryForMyProd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxCategoryForMyProd.DropDownHeight = 118;
            this.materialComboBoxCategoryForMyProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxCategoryForMyProd.DropDownWidth = 121;
            this.materialComboBoxCategoryForMyProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxCategoryForMyProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxCategoryForMyProd.FormattingEnabled = true;
            this.materialComboBoxCategoryForMyProd.Hint = "Выбрать";
            this.materialComboBoxCategoryForMyProd.IntegralHeight = false;
            this.materialComboBoxCategoryForMyProd.ItemHeight = 29;
            this.materialComboBoxCategoryForMyProd.Items.AddRange(new object[] {
            "Мобильные телефоны",
            "Планшеты",
            "Телевизоры",
            "Электроника",
            "Хозяйственные приборы",
            "Ноутбуки",
            "Автозапчасти",
            "Транспорт",
            "Продукты",
            "Одежда",
            "Услуги"});
            this.materialComboBoxCategoryForMyProd.Location = new System.Drawing.Point(291, 131);
            this.materialComboBoxCategoryForMyProd.MaxDropDownItems = 4;
            this.materialComboBoxCategoryForMyProd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxCategoryForMyProd.Name = "materialComboBoxCategoryForMyProd";
            this.materialComboBoxCategoryForMyProd.Size = new System.Drawing.Size(237, 35);
            this.materialComboBoxCategoryForMyProd.StartIndex = 0;
            this.materialComboBoxCategoryForMyProd.TabIndex = 58;
            this.materialComboBoxCategoryForMyProd.UseTallSize = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(236, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 32);
            this.label9.TabIndex = 68;
            this.label9.Text = "Информация";
            // 
            // materialButtonSelectPhotoForMyProduct
            // 
            this.materialButtonSelectPhotoForMyProduct.AutoSize = false;
            this.materialButtonSelectPhotoForMyProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSelectPhotoForMyProduct.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSelectPhotoForMyProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSelectPhotoForMyProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSelectPhotoForMyProduct.Depth = 0;
            this.materialButtonSelectPhotoForMyProduct.HighEmphasis = true;
            this.materialButtonSelectPhotoForMyProduct.Icon = null;
            this.materialButtonSelectPhotoForMyProduct.Location = new System.Drawing.Point(18, 257);
            this.materialButtonSelectPhotoForMyProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSelectPhotoForMyProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSelectPhotoForMyProduct.Name = "materialButtonSelectPhotoForMyProduct";
            this.materialButtonSelectPhotoForMyProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSelectPhotoForMyProduct.Size = new System.Drawing.Size(200, 37);
            this.materialButtonSelectPhotoForMyProduct.TabIndex = 67;
            this.materialButtonSelectPhotoForMyProduct.Text = "Выбрать фото";
            this.materialButtonSelectPhotoForMyProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSelectPhotoForMyProduct.UseAccentColor = false;
            this.materialButtonSelectPhotoForMyProduct.UseVisualStyleBackColor = true;
            this.materialButtonSelectPhotoForMyProduct.Click += new System.EventHandler(this.materialButtonSelectPhotoForMyProduct_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 32);
            this.label8.TabIndex = 66;
            this.label8.Text = "Фото";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.pictureBoxMyProductPicture);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(18, 51);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(200, 200);
            this.materialCard6.TabIndex = 65;
            // 
            // pictureBoxMyProductPicture
            // 
            this.pictureBoxMyProductPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxMyProductPicture.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMyProductPicture.Name = "pictureBoxMyProductPicture";
            this.pictureBoxMyProductPicture.Size = new System.Drawing.Size(194, 194);
            this.pictureBoxMyProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMyProductPicture.TabIndex = 27;
            this.pictureBoxMyProductPicture.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png";
            // 
            // FormChangeMyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 576);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeMyProduct";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать объявление";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMessengers_FormClosing);
            this.panel1.ResumeLayout(false);
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyProductPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxHouse;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxStreet2;
        private Label label15;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCityForMyProd;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxStreet;
        private Label label14;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxNameOfMyProduct;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBoxDescForMyProd;
        private Label label13;
        private Label label10;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxStatusForMyProd;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxCostForMyProd;
        private Label label11;
        private Label label12;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCategoryForMyProd;
        private Label label9;
        private MaterialSkin.Controls.MaterialButton materialButtonSelectPhotoForMyProduct;
        private Label label8;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private PictureBox pictureBoxMyProductPicture;
        private MaterialSkin.Controls.MaterialButton materialButtonRefreshMyProd;
        private MaterialSkin.Controls.MaterialButton materialButtonPublish;
        private OpenFileDialog openFileDialog1;
    }
}