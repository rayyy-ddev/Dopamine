namespace Dopamine
{
    partial class FormAdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanel));
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.materialComboBoxCategories = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxCity = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonCancelFind = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxFind = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonFind = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanelProducts = new Dopamine.CustomFlowLayoutPanel();
            this.materialButtonUpdateProducts = new MaterialSkin.Controls.MaterialButton();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.materialButtonCancelFind2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxFind2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonFind2 = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanelProfiles = new Dopamine.CustomFlowLayoutPanel();
            this.materialButtonUpdate2 = new MaterialSkin.Controls.MaterialButton();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxLoginAdmin = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxPasswordAdmin = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonLogin = new MaterialSkin.Controls.MaterialButton();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxIP = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxDatabase = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxLoginServer = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxPassServer = new MaterialSkin.Controls.MaterialTextBox2();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPageProducts);
            this.materialTabControl.Controls.Add(this.tabPageUsers);
            this.materialTabControl.Controls.Add(this.tabPageReports);
            this.materialTabControl.Controls.Add(this.tabPage1);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.ImageList = this.imageList;
            this.materialTabControl.Location = new System.Drawing.Point(3, 72);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1173, 745);
            this.materialTabControl.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProducts.Controls.Add(this.materialComboBoxCategories);
            this.tabPageProducts.Controls.Add(this.materialComboBoxCity);
            this.tabPageProducts.Controls.Add(this.materialButtonCancelFind);
            this.tabPageProducts.Controls.Add(this.materialTextBoxFind);
            this.tabPageProducts.Controls.Add(this.materialButtonFind);
            this.tabPageProducts.Controls.Add(this.flowLayoutPanelProducts);
            this.tabPageProducts.Controls.Add(this.materialButtonUpdateProducts);
            this.tabPageProducts.ImageKey = "dns_FILL0_wght400_GRAD0_opsz24.png";
            this.tabPageProducts.Location = new System.Drawing.Point(4, 31);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1165, 710);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Объявления";
            // 
            // materialComboBoxCategories
            // 
            this.materialComboBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBoxCategories.AutoResize = false;
            this.materialComboBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxCategories.Depth = 0;
            this.materialComboBoxCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxCategories.DropDownHeight = 176;
            this.materialComboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxCategories.DropDownWidth = 121;
            this.materialComboBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxCategories.FormattingEnabled = true;
            this.materialComboBoxCategories.Hint = "Категория";
            this.materialComboBoxCategories.IntegralHeight = false;
            this.materialComboBoxCategories.ItemHeight = 29;
            this.materialComboBoxCategories.Items.AddRange(new object[] {
            "Все категории",
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
            this.materialComboBoxCategories.Location = new System.Drawing.Point(852, 59);
            this.materialComboBoxCategories.MaxDropDownItems = 6;
            this.materialComboBoxCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxCategories.Name = "materialComboBoxCategories";
            this.materialComboBoxCategories.Size = new System.Drawing.Size(276, 35);
            this.materialComboBoxCategories.StartIndex = 0;
            this.materialComboBoxCategories.TabIndex = 24;
            this.materialComboBoxCategories.UseTallSize = false;
            this.materialComboBoxCategories.SelectionChangeCommitted += new System.EventHandler(this.materialComboBoxCategories_SelectionChangeCommitted);
            // 
            // materialComboBoxCity
            // 
            this.materialComboBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBoxCity.AutoResize = false;
            this.materialComboBoxCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxCity.Depth = 0;
            this.materialComboBoxCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxCity.DropDownHeight = 176;
            this.materialComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxCity.DropDownWidth = 121;
            this.materialComboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxCity.FormattingEnabled = true;
            this.materialComboBoxCity.Hint = "Город";
            this.materialComboBoxCity.IntegralHeight = false;
            this.materialComboBoxCity.ItemHeight = 29;
            this.materialComboBoxCity.Items.AddRange(new object[] {
            "Все города",
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
            this.materialComboBoxCity.Location = new System.Drawing.Point(852, 18);
            this.materialComboBoxCity.MaxDropDownItems = 6;
            this.materialComboBoxCity.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxCity.Name = "materialComboBoxCity";
            this.materialComboBoxCity.Size = new System.Drawing.Size(276, 35);
            this.materialComboBoxCity.StartIndex = 0;
            this.materialComboBoxCity.TabIndex = 23;
            this.materialComboBoxCity.UseTallSize = false;
            this.materialComboBoxCity.SelectionChangeCommitted += new System.EventHandler(this.materialComboBoxCity_SelectionChangeCommitted);
            // 
            // materialButtonCancelFind
            // 
            this.materialButtonCancelFind.AutoSize = false;
            this.materialButtonCancelFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCancelFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonCancelFind.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonCancelFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCancelFind.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCancelFind.Depth = 0;
            this.materialButtonCancelFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonCancelFind.HighEmphasis = true;
            this.materialButtonCancelFind.Icon = null;
            this.materialButtonCancelFind.Location = new System.Drawing.Point(444, 60);
            this.materialButtonCancelFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCancelFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancelFind.Name = "materialButtonCancelFind";
            this.materialButtonCancelFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCancelFind.Size = new System.Drawing.Size(97, 34);
            this.materialButtonCancelFind.TabIndex = 22;
            this.materialButtonCancelFind.Text = "Отменить";
            this.materialButtonCancelFind.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonCancelFind.UseAccentColor = false;
            this.materialButtonCancelFind.UseVisualStyleBackColor = false;
            this.materialButtonCancelFind.Visible = false;
            this.materialButtonCancelFind.Click += new System.EventHandler(this.materialButtonCancelFind_Click);
            // 
            // materialTextBoxFind
            // 
            this.materialTextBoxFind.AnimateReadOnly = false;
            this.materialTextBoxFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxFind.Depth = 0;
            this.materialTextBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxFind.HideSelection = true;
            this.materialTextBoxFind.Hint = "Поиск";
            this.materialTextBoxFind.LeadingIcon = null;
            this.materialTextBoxFind.Location = new System.Drawing.Point(187, 18);
            this.materialTextBoxFind.MaxLength = 32767;
            this.materialTextBoxFind.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxFind.Name = "materialTextBoxFind";
            this.materialTextBoxFind.PasswordChar = '\0';
            this.materialTextBoxFind.PrefixSuffixText = null;
            this.materialTextBoxFind.ReadOnly = false;
            this.materialTextBoxFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxFind.SelectedText = "";
            this.materialTextBoxFind.SelectionLength = 0;
            this.materialTextBoxFind.SelectionStart = 0;
            this.materialTextBoxFind.ShortcutsEnabled = true;
            this.materialTextBoxFind.Size = new System.Drawing.Size(250, 36);
            this.materialTextBoxFind.TabIndex = 20;
            this.materialTextBoxFind.TabStop = false;
            this.materialTextBoxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxFind.TrailingIcon = null;
            this.materialTextBoxFind.UseSystemPasswordChar = false;
            this.materialTextBoxFind.UseTallSize = false;
            // 
            // materialButtonFind
            // 
            this.materialButtonFind.AutoSize = false;
            this.materialButtonFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonFind.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonFind.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonFind.Depth = 0;
            this.materialButtonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonFind.HighEmphasis = true;
            this.materialButtonFind.Icon = global::Dopamine.Properties.Resources.search_FILL0_wght400_GRAD0_opsz24;
            this.materialButtonFind.Location = new System.Drawing.Point(444, 18);
            this.materialButtonFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonFind.Name = "materialButtonFind";
            this.materialButtonFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonFind.Size = new System.Drawing.Size(97, 34);
            this.materialButtonFind.TabIndex = 21;
            this.materialButtonFind.Text = "Найти";
            this.materialButtonFind.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonFind.UseAccentColor = false;
            this.materialButtonFind.UseVisualStyleBackColor = false;
            this.materialButtonFind.Click += new System.EventHandler(this.materialButtonFind_Click);
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(6, 117);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(1153, 587);
            this.flowLayoutPanelProducts.TabIndex = 19;
            // 
            // materialButtonUpdateProducts
            // 
            this.materialButtonUpdateProducts.AutoSize = false;
            this.materialButtonUpdateProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonUpdateProducts.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonUpdateProducts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonUpdateProducts.Depth = 0;
            this.materialButtonUpdateProducts.HighEmphasis = true;
            this.materialButtonUpdateProducts.Icon = global::Dopamine.Properties.Resources.icons8_refresh_48;
            this.materialButtonUpdateProducts.Location = new System.Drawing.Point(20, 18);
            this.materialButtonUpdateProducts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonUpdateProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonUpdateProducts.Name = "materialButtonUpdateProducts";
            this.materialButtonUpdateProducts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonUpdateProducts.Size = new System.Drawing.Size(122, 31);
            this.materialButtonUpdateProducts.TabIndex = 6;
            this.materialButtonUpdateProducts.Text = "Обновить";
            this.materialButtonUpdateProducts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonUpdateProducts.UseAccentColor = false;
            this.materialButtonUpdateProducts.UseVisualStyleBackColor = true;
            this.materialButtonUpdateProducts.Click += new System.EventHandler(this.materialButtonUpdateProducts_Click);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageUsers.Controls.Add(this.materialButtonCancelFind2);
            this.tabPageUsers.Controls.Add(this.materialTextBoxFind2);
            this.tabPageUsers.Controls.Add(this.materialButtonFind2);
            this.tabPageUsers.Controls.Add(this.flowLayoutPanelProfiles);
            this.tabPageUsers.Controls.Add(this.materialButtonUpdate2);
            this.tabPageUsers.ImageKey = "icons8-male-user-24.png";
            this.tabPageUsers.Location = new System.Drawing.Point(4, 31);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1165, 710);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Пользователи";
            // 
            // materialButtonCancelFind2
            // 
            this.materialButtonCancelFind2.AutoSize = false;
            this.materialButtonCancelFind2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCancelFind2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonCancelFind2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonCancelFind2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCancelFind2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCancelFind2.Depth = 0;
            this.materialButtonCancelFind2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonCancelFind2.HighEmphasis = true;
            this.materialButtonCancelFind2.Icon = null;
            this.materialButtonCancelFind2.Location = new System.Drawing.Point(549, 18);
            this.materialButtonCancelFind2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCancelFind2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancelFind2.Name = "materialButtonCancelFind2";
            this.materialButtonCancelFind2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCancelFind2.Size = new System.Drawing.Size(97, 34);
            this.materialButtonCancelFind2.TabIndex = 19;
            this.materialButtonCancelFind2.Text = "Отменить";
            this.materialButtonCancelFind2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonCancelFind2.UseAccentColor = false;
            this.materialButtonCancelFind2.UseVisualStyleBackColor = false;
            this.materialButtonCancelFind2.Visible = false;
            this.materialButtonCancelFind2.Click += new System.EventHandler(this.materialButtonCancelFind2_Click);
            // 
            // materialTextBoxFind2
            // 
            this.materialTextBoxFind2.AnimateReadOnly = false;
            this.materialTextBoxFind2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxFind2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxFind2.Depth = 0;
            this.materialTextBoxFind2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxFind2.HideSelection = true;
            this.materialTextBoxFind2.Hint = "Поиск";
            this.materialTextBoxFind2.LeadingIcon = null;
            this.materialTextBoxFind2.Location = new System.Drawing.Point(187, 18);
            this.materialTextBoxFind2.MaxLength = 32767;
            this.materialTextBoxFind2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxFind2.Name = "materialTextBoxFind2";
            this.materialTextBoxFind2.PasswordChar = '\0';
            this.materialTextBoxFind2.PrefixSuffixText = null;
            this.materialTextBoxFind2.ReadOnly = false;
            this.materialTextBoxFind2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxFind2.SelectedText = "";
            this.materialTextBoxFind2.SelectionLength = 0;
            this.materialTextBoxFind2.SelectionStart = 0;
            this.materialTextBoxFind2.ShortcutsEnabled = true;
            this.materialTextBoxFind2.Size = new System.Drawing.Size(250, 36);
            this.materialTextBoxFind2.TabIndex = 17;
            this.materialTextBoxFind2.TabStop = false;
            this.materialTextBoxFind2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxFind2.TrailingIcon = null;
            this.materialTextBoxFind2.UseSystemPasswordChar = false;
            this.materialTextBoxFind2.UseTallSize = false;
            // 
            // materialButtonFind2
            // 
            this.materialButtonFind2.AutoSize = false;
            this.materialButtonFind2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonFind2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonFind2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonFind2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonFind2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonFind2.Depth = 0;
            this.materialButtonFind2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonFind2.HighEmphasis = true;
            this.materialButtonFind2.Icon = global::Dopamine.Properties.Resources.search_FILL0_wght400_GRAD0_opsz24;
            this.materialButtonFind2.Location = new System.Drawing.Point(444, 18);
            this.materialButtonFind2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonFind2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonFind2.Name = "materialButtonFind2";
            this.materialButtonFind2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonFind2.Size = new System.Drawing.Size(97, 34);
            this.materialButtonFind2.TabIndex = 18;
            this.materialButtonFind2.Text = "Найти";
            this.materialButtonFind2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonFind2.UseAccentColor = false;
            this.materialButtonFind2.UseVisualStyleBackColor = false;
            this.materialButtonFind2.Click += new System.EventHandler(this.materialButtonFind2_Click);
            // 
            // flowLayoutPanelProfiles
            // 
            this.flowLayoutPanelProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelProfiles.AutoScroll = true;
            this.flowLayoutPanelProfiles.Location = new System.Drawing.Point(6, 68);
            this.flowLayoutPanelProfiles.Name = "flowLayoutPanelProfiles";
            this.flowLayoutPanelProfiles.Size = new System.Drawing.Size(1153, 636);
            this.flowLayoutPanelProfiles.TabIndex = 9;
            // 
            // materialButtonUpdate2
            // 
            this.materialButtonUpdate2.AutoSize = false;
            this.materialButtonUpdate2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonUpdate2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonUpdate2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonUpdate2.Depth = 0;
            this.materialButtonUpdate2.HighEmphasis = true;
            this.materialButtonUpdate2.Icon = global::Dopamine.Properties.Resources.icons8_refresh_48;
            this.materialButtonUpdate2.Location = new System.Drawing.Point(20, 18);
            this.materialButtonUpdate2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonUpdate2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonUpdate2.Name = "materialButtonUpdate2";
            this.materialButtonUpdate2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonUpdate2.Size = new System.Drawing.Size(122, 31);
            this.materialButtonUpdate2.TabIndex = 8;
            this.materialButtonUpdate2.Text = "Обновить";
            this.materialButtonUpdate2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonUpdate2.UseAccentColor = false;
            this.materialButtonUpdate2.UseVisualStyleBackColor = true;
            this.materialButtonUpdate2.Click += new System.EventHandler(this.materialButtonUpdate2_Click);
            // 
            // tabPageReports
            // 
            this.tabPageReports.BackColor = System.Drawing.Color.White;
            this.tabPageReports.Controls.Add(this.materialButton1);
            this.tabPageReports.Controls.Add(this.materialListView1);
            this.tabPageReports.ImageKey = "assignment_FILL0_wght400_GRAD0_opsz24.png";
            this.tabPageReports.Location = new System.Drawing.Point(4, 31);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Size = new System.Drawing.Size(1165, 710);
            this.tabPageReports.TabIndex = 3;
            this.tabPageReports.Text = "Отчеты";
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::Dopamine.Properties.Resources.output_FILL0_wght400_GRAD0_opsz24;
            this.materialButton1.Location = new System.Drawing.Point(18, 665);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(162, 31);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Вывести в Excel";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(18, 21);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(802, 635);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Товар";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Стоимость";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Продавец";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата продажи";
            this.columnHeader4.Width = 200;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialCard5);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialCard4);
            this.tabPage1.ImageKey = "icons8-settings-48.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 710);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Настройки";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel6.Location = new System.Drawing.Point(479, 22);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(185, 17);
            this.materialLabel6.TabIndex = 44;
            this.materialLabel6.Text = "Настройки аккаунта";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialLabel8);
            this.materialCard5.Controls.Add(this.materialLabel9);
            this.materialCard5.Controls.Add(this.materialButton2);
            this.materialCard5.Controls.Add(this.materialCard9);
            this.materialCard5.Controls.Add(this.materialCard10);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(482, 47);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(354, 180);
            this.materialCard5.TabIndex = 43;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel8.Location = new System.Drawing.Point(17, 92);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(76, 20);
            this.materialLabel8.TabIndex = 45;
            this.materialLabel8.Text = "Пароль";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel9.Location = new System.Drawing.Point(17, 35);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(76, 20);
            this.materialLabel9.TabIndex = 44;
            this.materialLabel9.Text = "Логин";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButton2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(215, 131);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(113, 34);
            this.materialButton2.TabIndex = 41;
            this.materialButton2.Text = "Сохранить";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.materialTextBoxLoginAdmin);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(110, 19);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(218, 36);
            this.materialCard9.TabIndex = 37;
            // 
            // materialTextBoxLoginAdmin
            // 
            this.materialTextBoxLoginAdmin.AnimateReadOnly = false;
            this.materialTextBoxLoginAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLoginAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLoginAdmin.Depth = 0;
            this.materialTextBoxLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLoginAdmin.HideSelection = true;
            this.materialTextBoxLoginAdmin.Hint = "Логин";
            this.materialTextBoxLoginAdmin.LeadingIcon = null;
            this.materialTextBoxLoginAdmin.LeaveOnEnterKey = true;
            this.materialTextBoxLoginAdmin.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxLoginAdmin.MaxLength = 45;
            this.materialTextBoxLoginAdmin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLoginAdmin.Name = "materialTextBoxLoginAdmin";
            this.materialTextBoxLoginAdmin.PasswordChar = '\0';
            this.materialTextBoxLoginAdmin.PrefixSuffixText = null;
            this.materialTextBoxLoginAdmin.ReadOnly = false;
            this.materialTextBoxLoginAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLoginAdmin.SelectedText = "";
            this.materialTextBoxLoginAdmin.SelectionLength = 0;
            this.materialTextBoxLoginAdmin.SelectionStart = 0;
            this.materialTextBoxLoginAdmin.ShortcutsEnabled = true;
            this.materialTextBoxLoginAdmin.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxLoginAdmin.TabIndex = 19;
            this.materialTextBoxLoginAdmin.TabStop = false;
            this.materialTextBoxLoginAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLoginAdmin.TrailingIcon = null;
            this.materialTextBoxLoginAdmin.UseSystemPasswordChar = false;
            this.materialTextBoxLoginAdmin.UseTallSize = false;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.materialTextBoxPasswordAdmin);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(110, 74);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(218, 36);
            this.materialCard10.TabIndex = 38;
            // 
            // materialTextBoxPasswordAdmin
            // 
            this.materialTextBoxPasswordAdmin.AnimateReadOnly = false;
            this.materialTextBoxPasswordAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxPasswordAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxPasswordAdmin.Depth = 0;
            this.materialTextBoxPasswordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPasswordAdmin.HideSelection = true;
            this.materialTextBoxPasswordAdmin.Hint = "Пароль";
            this.materialTextBoxPasswordAdmin.LeadingIcon = null;
            this.materialTextBoxPasswordAdmin.LeaveOnEnterKey = true;
            this.materialTextBoxPasswordAdmin.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxPasswordAdmin.MaxLength = 45;
            this.materialTextBoxPasswordAdmin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPasswordAdmin.Name = "materialTextBoxPasswordAdmin";
            this.materialTextBoxPasswordAdmin.PasswordChar = '\0';
            this.materialTextBoxPasswordAdmin.PrefixSuffixText = null;
            this.materialTextBoxPasswordAdmin.ReadOnly = false;
            this.materialTextBoxPasswordAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxPasswordAdmin.SelectedText = "";
            this.materialTextBoxPasswordAdmin.SelectionLength = 0;
            this.materialTextBoxPasswordAdmin.SelectionStart = 0;
            this.materialTextBoxPasswordAdmin.ShortcutsEnabled = true;
            this.materialTextBoxPasswordAdmin.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxPasswordAdmin.TabIndex = 19;
            this.materialTextBoxPasswordAdmin.TabStop = false;
            this.materialTextBoxPasswordAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPasswordAdmin.TrailingIcon = null;
            this.materialTextBoxPasswordAdmin.UseSystemPasswordChar = false;
            this.materialTextBoxPasswordAdmin.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(27, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(185, 17);
            this.materialLabel2.TabIndex = 42;
            this.materialLabel2.Text = "Настройки сервера";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel5);
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Controls.Add(this.materialLabel3);
            this.materialCard4.Controls.Add(this.materialLabel1);
            this.materialCard4.Controls.Add(this.materialButtonLogin);
            this.materialCard4.Controls.Add(this.materialCard7);
            this.materialCard4.Controls.Add(this.materialCard3);
            this.materialCard4.Controls.Add(this.materialCard1);
            this.materialCard4.Controls.Add(this.materialCard2);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(30, 47);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(411, 283);
            this.materialCard4.TabIndex = 40;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel5.Location = new System.Drawing.Point(17, 200);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(133, 20);
            this.materialLabel5.TabIndex = 46;
            this.materialLabel5.Text = "Имя базы данных";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(17, 145);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 20);
            this.materialLabel4.TabIndex = 45;
            this.materialLabel4.Text = "Пароль";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel3.Location = new System.Drawing.Point(17, 88);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(133, 20);
            this.materialLabel3.TabIndex = 44;
            this.materialLabel3.Text = "Логин";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(17, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 20);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "IP адрес сервера";
            // 
            // materialButtonLogin
            // 
            this.materialButtonLogin.AutoSize = false;
            this.materialButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonLogin.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLogin.Depth = 0;
            this.materialButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonLogin.HighEmphasis = true;
            this.materialButtonLogin.Icon = null;
            this.materialButtonLogin.Location = new System.Drawing.Point(272, 238);
            this.materialButtonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLogin.Name = "materialButtonLogin";
            this.materialButtonLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLogin.Size = new System.Drawing.Size(113, 34);
            this.materialButtonLogin.TabIndex = 41;
            this.materialButtonLogin.Text = "Сохранить";
            this.materialButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLogin.UseAccentColor = false;
            this.materialButtonLogin.UseVisualStyleBackColor = false;
            this.materialButtonLogin.Click += new System.EventHandler(this.materialButtonLogin_Click);
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialTextBoxIP);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(167, 17);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(218, 36);
            this.materialCard7.TabIndex = 36;
            // 
            // materialTextBoxIP
            // 
            this.materialTextBoxIP.AnimateReadOnly = false;
            this.materialTextBoxIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIP.Depth = 0;
            this.materialTextBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIP.HideSelection = true;
            this.materialTextBoxIP.Hint = "IP адрес сервера";
            this.materialTextBoxIP.LeadingIcon = null;
            this.materialTextBoxIP.LeaveOnEnterKey = true;
            this.materialTextBoxIP.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxIP.MaxLength = 45;
            this.materialTextBoxIP.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIP.Name = "materialTextBoxIP";
            this.materialTextBoxIP.PasswordChar = '\0';
            this.materialTextBoxIP.PrefixSuffixText = null;
            this.materialTextBoxIP.ReadOnly = false;
            this.materialTextBoxIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIP.SelectedText = "";
            this.materialTextBoxIP.SelectionLength = 0;
            this.materialTextBoxIP.SelectionStart = 0;
            this.materialTextBoxIP.ShortcutsEnabled = true;
            this.materialTextBoxIP.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxIP.TabIndex = 19;
            this.materialTextBoxIP.TabStop = false;
            this.materialTextBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIP.TrailingIcon = null;
            this.materialTextBoxIP.UseSystemPasswordChar = false;
            this.materialTextBoxIP.UseTallSize = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialTextBoxDatabase);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(167, 182);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(218, 36);
            this.materialCard3.TabIndex = 39;
            // 
            // materialTextBoxDatabase
            // 
            this.materialTextBoxDatabase.AnimateReadOnly = false;
            this.materialTextBoxDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxDatabase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxDatabase.Depth = 0;
            this.materialTextBoxDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDatabase.HideSelection = true;
            this.materialTextBoxDatabase.Hint = "Имя базы данных";
            this.materialTextBoxDatabase.LeadingIcon = null;
            this.materialTextBoxDatabase.LeaveOnEnterKey = true;
            this.materialTextBoxDatabase.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxDatabase.MaxLength = 45;
            this.materialTextBoxDatabase.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDatabase.Name = "materialTextBoxDatabase";
            this.materialTextBoxDatabase.PasswordChar = '\0';
            this.materialTextBoxDatabase.PrefixSuffixText = null;
            this.materialTextBoxDatabase.ReadOnly = false;
            this.materialTextBoxDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxDatabase.SelectedText = "";
            this.materialTextBoxDatabase.SelectionLength = 0;
            this.materialTextBoxDatabase.SelectionStart = 0;
            this.materialTextBoxDatabase.ShortcutsEnabled = true;
            this.materialTextBoxDatabase.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxDatabase.TabIndex = 19;
            this.materialTextBoxDatabase.TabStop = false;
            this.materialTextBoxDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxDatabase.TrailingIcon = null;
            this.materialTextBoxDatabase.UseSystemPasswordChar = false;
            this.materialTextBoxDatabase.UseTallSize = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialTextBoxLoginServer);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(167, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(218, 36);
            this.materialCard1.TabIndex = 37;
            // 
            // materialTextBoxLoginServer
            // 
            this.materialTextBoxLoginServer.AnimateReadOnly = false;
            this.materialTextBoxLoginServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLoginServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLoginServer.Depth = 0;
            this.materialTextBoxLoginServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLoginServer.HideSelection = true;
            this.materialTextBoxLoginServer.Hint = "Логин";
            this.materialTextBoxLoginServer.LeadingIcon = null;
            this.materialTextBoxLoginServer.LeaveOnEnterKey = true;
            this.materialTextBoxLoginServer.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxLoginServer.MaxLength = 45;
            this.materialTextBoxLoginServer.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLoginServer.Name = "materialTextBoxLoginServer";
            this.materialTextBoxLoginServer.PasswordChar = '\0';
            this.materialTextBoxLoginServer.PrefixSuffixText = null;
            this.materialTextBoxLoginServer.ReadOnly = false;
            this.materialTextBoxLoginServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLoginServer.SelectedText = "";
            this.materialTextBoxLoginServer.SelectionLength = 0;
            this.materialTextBoxLoginServer.SelectionStart = 0;
            this.materialTextBoxLoginServer.ShortcutsEnabled = true;
            this.materialTextBoxLoginServer.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxLoginServer.TabIndex = 19;
            this.materialTextBoxLoginServer.TabStop = false;
            this.materialTextBoxLoginServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLoginServer.TrailingIcon = null;
            this.materialTextBoxLoginServer.UseSystemPasswordChar = false;
            this.materialTextBoxLoginServer.UseTallSize = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialTextBoxPassServer);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(167, 127);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(218, 36);
            this.materialCard2.TabIndex = 38;
            // 
            // materialTextBoxPassServer
            // 
            this.materialTextBoxPassServer.AnimateReadOnly = false;
            this.materialTextBoxPassServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxPassServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxPassServer.Depth = 0;
            this.materialTextBoxPassServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassServer.HideSelection = true;
            this.materialTextBoxPassServer.Hint = "Пароль";
            this.materialTextBoxPassServer.LeadingIcon = null;
            this.materialTextBoxPassServer.LeaveOnEnterKey = true;
            this.materialTextBoxPassServer.Location = new System.Drawing.Point(2, 2);
            this.materialTextBoxPassServer.MaxLength = 45;
            this.materialTextBoxPassServer.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassServer.Name = "materialTextBoxPassServer";
            this.materialTextBoxPassServer.PasswordChar = '\0';
            this.materialTextBoxPassServer.PrefixSuffixText = null;
            this.materialTextBoxPassServer.ReadOnly = false;
            this.materialTextBoxPassServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxPassServer.SelectedText = "";
            this.materialTextBoxPassServer.SelectionLength = 0;
            this.materialTextBoxPassServer.SelectionStart = 0;
            this.materialTextBoxPassServer.ShortcutsEnabled = true;
            this.materialTextBoxPassServer.Size = new System.Drawing.Size(222, 36);
            this.materialTextBoxPassServer.TabIndex = 19;
            this.materialTextBoxPassServer.TabStop = false;
            this.materialTextBoxPassServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPassServer.TrailingIcon = null;
            this.materialTextBoxPassServer.UseSystemPasswordChar = false;
            this.materialTextBoxPassServer.UseTallSize = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icons8-settings-48.png");
            this.imageList.Images.SetKeyName(1, "account_circle_FILL1_wght400_GRAD0_opsz24.png");
            this.imageList.Images.SetKeyName(2, "dns_FILL0_wght400_GRAD0_opsz24.png");
            this.imageList.Images.SetKeyName(3, "assignment_FILL0_wght400_GRAD0_opsz24.png");
            this.imageList.Images.SetKeyName(4, "icons8-male-user-24.png");
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 820);
            this.Controls.Add(this.materialTabControl);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.DrawerUseColors = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(955, 585);
            this.Name = "FormAdminPanel";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dopamine (Администратор)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminPanel_FormClosing);
            this.materialTabControl.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard9.ResumeLayout(false);
            this.materialCard10.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.ImageList imageList;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdateProducts;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdate2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private CustomFlowLayoutPanel flowLayoutPanelProducts;
        private CustomFlowLayoutPanel flowLayoutPanelProfiles;
        private MaterialSkin.Controls.MaterialButton materialButtonCancelFind;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxFind;
        private MaterialSkin.Controls.MaterialButton materialButtonFind;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCategories;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCity;
        private MaterialSkin.Controls.MaterialButton materialButtonCancelFind2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxFind2;
        private MaterialSkin.Controls.MaterialButton materialButtonFind2;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIP;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxDatabase;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPassServer;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLoginServer;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton materialButtonLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLoginAdmin;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPasswordAdmin;
    }
}