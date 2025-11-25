using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dopamine
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBoxCity = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.materialComboBoxCategories = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonCancelFind = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxFind = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPageNewProduct = new System.Windows.Forms.TabPage();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialButtonRefreshMyProd = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonPublish = new MaterialSkin.Controls.MaterialButton();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxCostForMyProd = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.materialComboBoxCategoryForMyProd = new MaterialSkin.Controls.MaterialComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.materialButtonSelectPhotoForMyProduct = new MaterialSkin.Controls.MaterialButton();
            this.label8 = new System.Windows.Forms.Label();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.labelNonSelled = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.labelNoMyProd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialButtonSetUpAccount = new MaterialSkin.Controls.MaterialButton();
            this.labelMyUserName = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tabPageCart = new System.Windows.Forms.TabPage();
            this.labelNonFav = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanelCarts = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPageSeller = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelSellersProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSellersProducts = new System.Windows.Forms.Label();
            this.materialButtonConnect2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonShowPhone2 = new MaterialSkin.Controls.MaterialButton();
            this.labelSellerName = new System.Windows.Forms.Label();
            this.materialCardSellerPicture = new MaterialSkin.Controls.MaterialCard();
            this.panelPopUp = new System.Windows.Forms.Panel();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabelCarts = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelViews = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.materialCardPicturePreview = new MaterialSkin.Controls.MaterialCard();
            this.materialCardAddress = new MaterialSkin.Controls.MaterialCard();
            this.labelAdress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCardInfo = new MaterialSkin.Controls.MaterialCard();
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialButtonConnect = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonShowPhone = new MaterialSkin.Controls.MaterialButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelProductCost = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialButtonRefresh = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonFind = new MaterialSkin.Controls.MaterialButton();
            this.pictureBoxMyProductPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxMyPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxSellerPicture = new System.Windows.Forms.PictureBox();
            this.materialFloatingActionButtonClose2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.pictureBoxCarts = new System.Windows.Forms.PictureBox();
            this.pictureBoxViews = new System.Windows.Forms.PictureBox();
            this.materialFloatingActionButtonClose = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new Dopamine.CustomFlowLayoutPanel();
            this.flowLayoutPanelMyArchive = new Dopamine.CustomFlowLayoutPanel();
            this.flowLayoutPanelMyProducts = new Dopamine.CustomFlowLayoutPanel();
            this.materialTabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageNewProduct.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabPageCart.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.tabPageSeller.SuspendLayout();
            this.materialCardSellerPicture.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCardPicturePreview.SuspendLayout();
            this.materialCardAddress.SuspendLayout();
            this.materialCardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSellerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Каталог объявлений";
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
            this.materialComboBoxCity.Location = new System.Drawing.Point(854, 20);
            this.materialComboBoxCity.MaxDropDownItems = 6;
            this.materialComboBoxCity.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxCity.Name = "materialComboBoxCity";
            this.materialComboBoxCity.Size = new System.Drawing.Size(276, 35);
            this.materialComboBoxCity.StartIndex = 0;
            this.materialComboBoxCity.TabIndex = 15;
            this.materialComboBoxCity.UseTallSize = false;
            this.materialComboBoxCity.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxCity_SelectedIndexChanged);
            this.materialComboBoxCity.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCity_TextChanged);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageHome);
            this.materialTabControl1.Controls.Add(this.tabPageNewProduct);
            this.materialTabControl1.Controls.Add(this.tabPageProfile);
            this.materialTabControl1.Controls.Add(this.tabPageCart);
            this.materialTabControl1.Controls.Add(this.tabPageSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 72);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1173, 745);
            this.materialTabControl1.TabIndex = 16;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageHome.Controls.Add(this.materialComboBoxCategories);
            this.tabPageHome.Controls.Add(this.flowLayoutPanel1);
            this.tabPageHome.Controls.Add(this.materialButtonRefresh);
            this.tabPageHome.Controls.Add(this.materialButtonCancelFind);
            this.tabPageHome.Controls.Add(this.materialTextBoxFind);
            this.tabPageHome.Controls.Add(this.materialComboBoxCity);
            this.tabPageHome.Controls.Add(this.materialButtonFind);
            this.tabPageHome.Controls.Add(this.label1);
            this.tabPageHome.ImageKey = "icons8-home-48.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 31);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(1165, 710);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Главная";
            this.tabPageHome.Enter += new System.EventHandler(this.tabPageHome_Enter);
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
            this.materialComboBoxCategories.Location = new System.Drawing.Point(854, 61);
            this.materialComboBoxCategories.MaxDropDownItems = 6;
            this.materialComboBoxCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxCategories.Name = "materialComboBoxCategories";
            this.materialComboBoxCategories.Size = new System.Drawing.Size(276, 35);
            this.materialComboBoxCategories.StartIndex = 0;
            this.materialComboBoxCategories.TabIndex = 19;
            this.materialComboBoxCategories.UseTallSize = false;
            this.materialComboBoxCategories.TextChanged += new System.EventHandler(this.materialComboBoxCategories_TextChanged);
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
            this.materialButtonCancelFind.Location = new System.Drawing.Point(537, 21);
            this.materialButtonCancelFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCancelFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancelFind.Name = "materialButtonCancelFind";
            this.materialButtonCancelFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCancelFind.Size = new System.Drawing.Size(97, 34);
            this.materialButtonCancelFind.TabIndex = 16;
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
            this.materialTextBoxFind.Location = new System.Drawing.Point(175, 21);
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
            this.materialTextBoxFind.TabIndex = 13;
            this.materialTextBoxFind.TabStop = false;
            this.materialTextBoxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxFind.TrailingIcon = null;
            this.materialTextBoxFind.UseSystemPasswordChar = false;
            this.materialTextBoxFind.UseTallSize = false;
            this.materialTextBoxFind.TextChanged += new System.EventHandler(this.materialTextBoxFind_TextChanged);
            // 
            // tabPageNewProduct
            // 
            this.tabPageNewProduct.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNewProduct.Controls.Add(this.materialSlider1);
            this.tabPageNewProduct.Controls.Add(this.materialButtonRefreshMyProd);
            this.tabPageNewProduct.Controls.Add(this.materialButtonPublish);
            this.tabPageNewProduct.Controls.Add(this.materialCard9);
            this.tabPageNewProduct.Controls.Add(this.label9);
            this.tabPageNewProduct.Controls.Add(this.materialButtonSelectPhotoForMyProduct);
            this.tabPageNewProduct.Controls.Add(this.label8);
            this.tabPageNewProduct.Controls.Add(this.materialCard6);
            this.tabPageNewProduct.ImageKey = "icons8-new-48.png";
            this.tabPageNewProduct.Location = new System.Drawing.Point(4, 31);
            this.tabPageNewProduct.Name = "tabPageNewProduct";
            this.tabPageNewProduct.Size = new System.Drawing.Size(1165, 710);
            this.tabPageNewProduct.TabIndex = 4;
            this.tabPageNewProduct.Text = "Разместить объявление";
            this.tabPageNewProduct.Enter += new System.EventHandler(this.tabPageNewProduct_Enter);
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialSlider1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(798, 267);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 999999;
            this.materialSlider1.RangeMin = 10;
            this.materialSlider1.Size = new System.Drawing.Size(214, 40);
            this.materialSlider1.TabIndex = 66;
            this.materialSlider1.Text = "";
            this.materialSlider1.Visible = false;
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
            this.materialButtonRefreshMyProd.Location = new System.Drawing.Point(14, 402);
            this.materialButtonRefreshMyProd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonRefreshMyProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRefreshMyProd.Name = "materialButtonRefreshMyProd";
            this.materialButtonRefreshMyProd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRefreshMyProd.Size = new System.Drawing.Size(200, 37);
            this.materialButtonRefreshMyProd.TabIndex = 66;
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
            this.materialButtonPublish.Location = new System.Drawing.Point(14, 450);
            this.materialButtonPublish.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonPublish.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPublish.Name = "materialButtonPublish";
            this.materialButtonPublish.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPublish.Size = new System.Drawing.Size(200, 37);
            this.materialButtonPublish.TabIndex = 65;
            this.materialButtonPublish.Text = "Опубликовать";
            this.materialButtonPublish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPublish.UseAccentColor = false;
            this.materialButtonPublish.UseVisualStyleBackColor = true;
            this.materialButtonPublish.Click += new System.EventHandler(this.materialButtonPublish_Click);
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.materialTextBoxCostForMyProd);
            this.materialCard9.Controls.Add(this.materialCard10);
            this.materialCard9.Controls.Add(this.materialTextBoxNameOfMyProduct);
            this.materialCard9.Controls.Add(this.materialMultiLineTextBoxDescForMyProd);
            this.materialCard9.Controls.Add(this.label13);
            this.materialCard9.Controls.Add(this.label10);
            this.materialCard9.Controls.Add(this.materialComboBoxStatusForMyProd);
            this.materialCard9.Controls.Add(this.label11);
            this.materialCard9.Controls.Add(this.label12);
            this.materialCard9.Controls.Add(this.materialComboBoxCategoryForMyProd);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(236, 50);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(545, 437);
            this.materialCard9.TabIndex = 64;
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
            this.materialTextBoxCostForMyProd.Location = new System.Drawing.Point(291, 221);
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
            this.materialTextBoxCostForMyProd.TabIndex = 66;
            this.materialTextBoxCostForMyProd.TabStop = false;
            this.materialTextBoxCostForMyProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxCostForMyProd.TrailingIcon = null;
            this.materialTextBoxCostForMyProd.UseSystemPasswordChar = false;
            this.materialTextBoxCostForMyProd.UseTallSize = false;
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
            this.label9.Location = new System.Drawing.Point(232, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 32);
            this.label9.TabIndex = 53;
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
            this.materialButtonSelectPhotoForMyProduct.Location = new System.Drawing.Point(14, 256);
            this.materialButtonSelectPhotoForMyProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSelectPhotoForMyProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSelectPhotoForMyProduct.Name = "materialButtonSelectPhotoForMyProduct";
            this.materialButtonSelectPhotoForMyProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSelectPhotoForMyProduct.Size = new System.Drawing.Size(200, 37);
            this.materialButtonSelectPhotoForMyProduct.TabIndex = 51;
            this.materialButtonSelectPhotoForMyProduct.Text = "Выбрать фото";
            this.materialButtonSelectPhotoForMyProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSelectPhotoForMyProduct.UseAccentColor = false;
            this.materialButtonSelectPhotoForMyProduct.UseVisualStyleBackColor = true;
            this.materialButtonSelectPhotoForMyProduct.Click += new System.EventHandler(this.materialButtonSelectPhotoForMyProduct_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 32);
            this.label8.TabIndex = 50;
            this.label8.Text = "Фото";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.pictureBoxMyProductPicture);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 50);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(200, 200);
            this.materialCard6.TabIndex = 49;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProfile.Controls.Add(this.flowLayoutPanelMyArchive);
            this.tabPageProfile.Controls.Add(this.flowLayoutPanelMyProducts);
            this.tabPageProfile.Controls.Add(this.labelNonSelled);
            this.tabPageProfile.Controls.Add(this.materialButton1);
            this.tabPageProfile.Controls.Add(this.labelNoMyProd);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.label6);
            this.tabPageProfile.Controls.Add(this.materialButtonSetUpAccount);
            this.tabPageProfile.Controls.Add(this.labelMyUserName);
            this.tabPageProfile.Controls.Add(this.materialCard3);
            this.tabPageProfile.ImageKey = "icons8-male-user-48.png";
            this.tabPageProfile.Location = new System.Drawing.Point(4, 31);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(1165, 710);
            this.tabPageProfile.TabIndex = 1;
            this.tabPageProfile.Text = "Профиль";
            this.tabPageProfile.Enter += new System.EventHandler(this.tabPageProfile_Enter);
            // 
            // labelNonSelled
            // 
            this.labelNonSelled.AutoSize = true;
            this.labelNonSelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNonSelled.Location = new System.Drawing.Point(-95, 492);
            this.labelNonSelled.Name = "labelNonSelled";
            this.labelNonSelled.Size = new System.Drawing.Size(357, 25);
            this.labelNonSelled.TabIndex = 54;
            this.labelNonSelled.Text = "У Вас еще нет проданных товаров";
            this.labelNonSelled.Visible = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(17, 346);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(200, 37);
            this.materialButton1.TabIndex = 56;
            this.materialButton1.Text = "Выйти";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // labelNoMyProd
            // 
            this.labelNoMyProd.AutoSize = true;
            this.labelNoMyProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoMyProd.Location = new System.Drawing.Point(400, 318);
            this.labelNoMyProd.Name = "labelNoMyProd";
            this.labelNoMyProd.Size = new System.Drawing.Size(273, 25);
            this.labelNoMyProd.TabIndex = 55;
            this.labelNoMyProd.Text = "Активных объявлений нет";
            this.labelNoMyProd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(252, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 31);
            this.label7.TabIndex = 52;
            this.label7.Text = "Архив";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(252, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 31);
            this.label6.TabIndex = 50;
            this.label6.Text = "Мои объявления";
            // 
            // materialButtonSetUpAccount
            // 
            this.materialButtonSetUpAccount.AutoSize = false;
            this.materialButtonSetUpAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSetUpAccount.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSetUpAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSetUpAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSetUpAccount.Depth = 0;
            this.materialButtonSetUpAccount.HighEmphasis = true;
            this.materialButtonSetUpAccount.Icon = null;
            this.materialButtonSetUpAccount.Location = new System.Drawing.Point(17, 297);
            this.materialButtonSetUpAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSetUpAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSetUpAccount.Name = "materialButtonSetUpAccount";
            this.materialButtonSetUpAccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSetUpAccount.Size = new System.Drawing.Size(200, 37);
            this.materialButtonSetUpAccount.TabIndex = 48;
            this.materialButtonSetUpAccount.Text = "Настроить";
            this.materialButtonSetUpAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSetUpAccount.UseAccentColor = false;
            this.materialButtonSetUpAccount.UseVisualStyleBackColor = true;
            this.materialButtonSetUpAccount.Click += new System.EventHandler(this.materialButtonSetUpAccount_Click);
            // 
            // labelMyUserName
            // 
            this.labelMyUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyUserName.Location = new System.Drawing.Point(14, 231);
            this.labelMyUserName.Name = "labelMyUserName";
            this.labelMyUserName.Size = new System.Drawing.Size(254, 60);
            this.labelMyUserName.TabIndex = 47;
            this.labelMyUserName.Text = "UserName";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.pictureBoxMyPicture);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 17);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(200, 200);
            this.materialCard3.TabIndex = 46;
            // 
            // tabPageCart
            // 
            this.tabPageCart.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCart.Controls.Add(this.labelNonFav);
            this.tabPageCart.Controls.Add(this.label16);
            this.tabPageCart.Controls.Add(this.flowLayoutPanelCarts);
            this.tabPageCart.ImageKey = "favorite_FILL0_wght400_GRAD0_opsz24.png";
            this.tabPageCart.Location = new System.Drawing.Point(4, 31);
            this.tabPageCart.Name = "tabPageCart";
            this.tabPageCart.Size = new System.Drawing.Size(1165, 710);
            this.tabPageCart.TabIndex = 2;
            this.tabPageCart.Text = "Избранные";
            this.tabPageCart.Click += new System.EventHandler(this.tabPageCart_Click);
            this.tabPageCart.Enter += new System.EventHandler(this.tabPageCart_Enter);
            // 
            // labelNonFav
            // 
            this.labelNonFav.AutoSize = true;
            this.labelNonFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNonFav.Location = new System.Drawing.Point(321, 15);
            this.labelNonFav.Name = "labelNonFav";
            this.labelNonFav.Size = new System.Drawing.Size(250, 25);
            this.labelNonFav.TabIndex = 56;
            this.labelNonFav.Text = "Избранных товаров нет";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(14, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(335, 31);
            this.label16.TabIndex = 51;
            this.label16.Text = "Избранные объявления";
            // 
            // flowLayoutPanelCarts
            // 
            this.flowLayoutPanelCarts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelCarts.AutoScroll = true;
            this.flowLayoutPanelCarts.Location = new System.Drawing.Point(20, 58);
            this.flowLayoutPanelCarts.Name = "flowLayoutPanelCarts";
            this.flowLayoutPanelCarts.Size = new System.Drawing.Size(772, 636);
            this.flowLayoutPanelCarts.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSettings.Controls.Add(this.materialButton5);
            this.tabPageSettings.Controls.Add(this.materialButton4);
            this.tabPageSettings.Controls.Add(this.materialCard7);
            this.tabPageSettings.Controls.Add(this.materialLabel5);
            this.tabPageSettings.ImageKey = "icons8-settings-48.png";
            this.tabPageSettings.Location = new System.Drawing.Point(4, 31);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(1165, 710);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Настройки";
            this.tabPageSettings.Enter += new System.EventHandler(this.tabPageSettings_Enter);
            // 
            // materialButton5
            // 
            this.materialButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton5.AutoSize = false;
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(846, 642);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(132, 37);
            this.materialButton5.TabIndex = 53;
            this.materialButton5.Text = "Сбросить";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(986, 642);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(132, 37);
            this.materialButton4.TabIndex = 52;
            this.materialButton4.Text = "Применить";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialButton3);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(34, 50);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(343, 63);
            this.materialCard7.TabIndex = 7;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(18, 14);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(132, 37);
            this.materialButton3.TabIndex = 51;
            this.materialButton3.Text = "Справка";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(30, 23);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 24);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Основные";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-new-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-cart-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-male-user-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-settings-48.png");
            this.imageList1.Images.SetKeyName(5, "icons8-big-parcel-48.png");
            this.imageList1.Images.SetKeyName(6, "favorite_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // tabPageSeller
            // 
            this.tabPageSeller.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSeller.Controls.Add(this.flowLayoutPanelSellersProducts);
            this.tabPageSeller.Controls.Add(this.labelSellersProducts);
            this.tabPageSeller.Controls.Add(this.materialButtonConnect2);
            this.tabPageSeller.Controls.Add(this.materialButtonShowPhone2);
            this.tabPageSeller.Controls.Add(this.labelSellerName);
            this.tabPageSeller.Controls.Add(this.materialCardSellerPicture);
            this.tabPageSeller.Controls.Add(this.materialFloatingActionButtonClose2);
            this.tabPageSeller.Location = new System.Drawing.Point(4, 31);
            this.tabPageSeller.Name = "tabPageSeller";
            this.tabPageSeller.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeller.Size = new System.Drawing.Size(1165, 710);
            this.tabPageSeller.TabIndex = 6;
            this.tabPageSeller.Text = "UserName";
            // 
            // flowLayoutPanelSellersProducts
            // 
            this.flowLayoutPanelSellersProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelSellersProducts.AutoScroll = true;
            this.flowLayoutPanelSellersProducts.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelSellersProducts.Location = new System.Drawing.Point(311, 106);
            this.flowLayoutPanelSellersProducts.Name = "flowLayoutPanelSellersProducts";
            this.flowLayoutPanelSellersProducts.Size = new System.Drawing.Size(744, 481);
            this.flowLayoutPanelSellersProducts.TabIndex = 49;
            // 
            // labelSellersProducts
            // 
            this.labelSellersProducts.AutoSize = true;
            this.labelSellersProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSellersProducts.Location = new System.Drawing.Point(305, 53);
            this.labelSellersProducts.Name = "labelSellersProducts";
            this.labelSellersProducts.Size = new System.Drawing.Size(375, 31);
            this.labelSellersProducts.TabIndex = 48;
            this.labelSellersProducts.Text = "Объявления пользователя";
            // 
            // materialButtonConnect2
            // 
            this.materialButtonConnect2.AutoSize = false;
            this.materialButtonConnect2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonConnect2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonConnect2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonConnect2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonConnect2.Depth = 0;
            this.materialButtonConnect2.HighEmphasis = true;
            this.materialButtonConnect2.Icon = null;
            this.materialButtonConnect2.Location = new System.Drawing.Point(20, 457);
            this.materialButtonConnect2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonConnect2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonConnect2.Name = "materialButtonConnect2";
            this.materialButtonConnect2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonConnect2.Size = new System.Drawing.Size(252, 47);
            this.materialButtonConnect2.TabIndex = 47;
            this.materialButtonConnect2.Text = "Связаться с продавцом";
            this.materialButtonConnect2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonConnect2.UseAccentColor = false;
            this.materialButtonConnect2.UseVisualStyleBackColor = true;
            // 
            // materialButtonShowPhone2
            // 
            this.materialButtonShowPhone2.AutoSize = false;
            this.materialButtonShowPhone2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowPhone2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonShowPhone2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonShowPhone2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowPhone2.Depth = 0;
            this.materialButtonShowPhone2.HighEmphasis = true;
            this.materialButtonShowPhone2.Icon = null;
            this.materialButtonShowPhone2.Location = new System.Drawing.Point(20, 398);
            this.materialButtonShowPhone2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonShowPhone2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowPhone2.Name = "materialButtonShowPhone2";
            this.materialButtonShowPhone2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowPhone2.Size = new System.Drawing.Size(252, 47);
            this.materialButtonShowPhone2.TabIndex = 46;
            this.materialButtonShowPhone2.Text = "Показать телефон";
            this.materialButtonShowPhone2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowPhone2.UseAccentColor = false;
            this.materialButtonShowPhone2.UseVisualStyleBackColor = true;
            // 
            // labelSellerName
            // 
            this.labelSellerName.AutoSize = true;
            this.labelSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSellerName.Location = new System.Drawing.Point(17, 322);
            this.labelSellerName.Name = "labelSellerName";
            this.labelSellerName.Size = new System.Drawing.Size(152, 31);
            this.labelSellerName.TabIndex = 45;
            this.labelSellerName.Text = "UserName";
            // 
            // materialCardSellerPicture
            // 
            this.materialCardSellerPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardSellerPicture.Controls.Add(this.pictureBoxSellerPicture);
            this.materialCardSellerPicture.Depth = 0;
            this.materialCardSellerPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardSellerPicture.Location = new System.Drawing.Point(20, 53);
            this.materialCardSellerPicture.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardSellerPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardSellerPicture.Name = "materialCardSellerPicture";
            this.materialCardSellerPicture.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardSellerPicture.Size = new System.Drawing.Size(255, 255);
            this.materialCardSellerPicture.TabIndex = 43;
            // 
            // panelPopUp
            // 
            this.panelPopUp.Location = new System.Drawing.Point(483, 46);
            this.panelPopUp.Name = "panelPopUp";
            this.panelPopUp.Size = new System.Drawing.Size(343, 20);
            this.panelPopUp.TabIndex = 18;
            this.panelPopUp.Visible = false;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.AutoScroll = true;
            this.tabPageProduct.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProduct.Controls.Add(this.materialCard2);
            this.tabPageProduct.Controls.Add(this.materialCard1);
            this.tabPageProduct.Controls.Add(this.materialFloatingActionButtonClose);
            this.tabPageProduct.Controls.Add(this.materialCardPicturePreview);
            this.tabPageProduct.Controls.Add(this.materialCardAddress);
            this.tabPageProduct.Controls.Add(this.materialCardInfo);
            this.tabPageProduct.Controls.Add(this.materialButtonConnect);
            this.tabPageProduct.Controls.Add(this.materialButtonShowPhone);
            this.tabPageProduct.Controls.Add(this.labelStatus);
            this.tabPageProduct.Controls.Add(this.labelProductCost);
            this.tabPageProduct.Controls.Add(this.labelProductName);
            this.tabPageProduct.ImageKey = "icons8-big-parcel-48.png";
            this.tabPageProduct.Location = new System.Drawing.Point(4, 31);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(1117, 611);
            this.tabPageProduct.TabIndex = 5;
            this.tabPageProduct.Text = "ProductName";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabelCarts);
            this.materialCard2.Controls.Add(this.materialLabelViews);
            this.materialCard2.Controls.Add(this.pictureBoxCarts);
            this.materialCard2.Controls.Add(this.pictureBoxViews);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(24, 380);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(255, 67);
            this.materialCard2.TabIndex = 42;
            // 
            // materialLabelCarts
            // 
            this.materialLabelCarts.AutoEllipsis = true;
            this.materialLabelCarts.Depth = 0;
            this.materialLabelCarts.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelCarts.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabelCarts.Location = new System.Drawing.Point(158, 22);
            this.materialLabelCarts.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCarts.Name = "materialLabelCarts";
            this.materialLabelCarts.Size = new System.Drawing.Size(73, 20);
            this.materialLabelCarts.TabIndex = 36;
            this.materialLabelCarts.Text = "0";
            // 
            // materialLabelViews
            // 
            this.materialLabelViews.AutoEllipsis = true;
            this.materialLabelViews.Depth = 0;
            this.materialLabelViews.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelViews.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabelViews.Location = new System.Drawing.Point(48, 22);
            this.materialLabelViews.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelViews.Name = "materialLabelViews";
            this.materialLabelViews.Size = new System.Drawing.Size(73, 20);
            this.materialLabelViews.TabIndex = 35;
            this.materialLabelViews.Text = "0";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.labelUserName);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(823, 233);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(210, 104);
            this.materialCard1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Продавец";
            // 
            // labelUserName
            // 
            this.labelUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUserName.Location = new System.Drawing.Point(17, 49);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(166, 45);
            this.labelUserName.TabIndex = 30;
            this.labelUserName.Text = "Сахил Рагимов";
            // 
            // materialCardPicturePreview
            // 
            this.materialCardPicturePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardPicturePreview.Controls.Add(this.pictureBoxPreview);
            this.materialCardPicturePreview.Depth = 0;
            this.materialCardPicturePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardPicturePreview.Location = new System.Drawing.Point(27, 97);
            this.materialCardPicturePreview.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardPicturePreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardPicturePreview.Name = "materialCardPicturePreview";
            this.materialCardPicturePreview.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardPicturePreview.Size = new System.Drawing.Size(255, 255);
            this.materialCardPicturePreview.TabIndex = 42;
            // 
            // materialCardAddress
            // 
            this.materialCardAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardAddress.Controls.Add(this.labelAdress);
            this.materialCardAddress.Controls.Add(this.label4);
            this.materialCardAddress.Depth = 0;
            this.materialCardAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardAddress.Location = new System.Drawing.Point(317, 97);
            this.materialCardAddress.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardAddress.Name = "materialCardAddress";
            this.materialCardAddress.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardAddress.Size = new System.Drawing.Size(309, 88);
            this.materialCardAddress.TabIndex = 41;
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdress.AutoEllipsis = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.Location = new System.Drawing.Point(17, 49);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(276, 25);
            this.labelAdress.TabIndex = 32;
            this.labelAdress.Text = "Бугульма, ул Ленина 94";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Адрес";
            // 
            // materialCardInfo
            // 
            this.materialCardInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardInfo.Controls.Add(this.labelProductInfo);
            this.materialCardInfo.Controls.Add(this.label3);
            this.materialCardInfo.Depth = 0;
            this.materialCardInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardInfo.Location = new System.Drawing.Point(317, 213);
            this.materialCardInfo.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardInfo.Name = "materialCardInfo";
            this.materialCardInfo.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardInfo.Size = new System.Drawing.Size(309, 206);
            this.materialCardInfo.TabIndex = 40;
            this.materialCardInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCardInfo_Paint);
            // 
            // labelProductInfo
            // 
            this.labelProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductInfo.Location = new System.Drawing.Point(17, 48);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(276, 133);
            this.labelProductInfo.TabIndex = 34;
            this.labelProductInfo.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Описание";
            // 
            // materialButtonConnect
            // 
            this.materialButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonConnect.AutoSize = false;
            this.materialButtonConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonConnect.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonConnect.Depth = 0;
            this.materialButtonConnect.HighEmphasis = true;
            this.materialButtonConnect.Icon = null;
            this.materialButtonConnect.Location = new System.Drawing.Point(823, 166);
            this.materialButtonConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonConnect.Name = "materialButtonConnect";
            this.materialButtonConnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonConnect.Size = new System.Drawing.Size(210, 47);
            this.materialButtonConnect.TabIndex = 39;
            this.materialButtonConnect.Text = "Связаться с продавцом";
            this.materialButtonConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonConnect.UseAccentColor = false;
            this.materialButtonConnect.UseVisualStyleBackColor = true;
            // 
            // materialButtonShowPhone
            // 
            this.materialButtonShowPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonShowPhone.AutoSize = false;
            this.materialButtonShowPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowPhone.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonShowPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonShowPhone.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowPhone.Depth = 0;
            this.materialButtonShowPhone.HighEmphasis = true;
            this.materialButtonShowPhone.Icon = null;
            this.materialButtonShowPhone.Location = new System.Drawing.Point(823, 107);
            this.materialButtonShowPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonShowPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowPhone.Name = "materialButtonShowPhone";
            this.materialButtonShowPhone.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowPhone.Size = new System.Drawing.Size(210, 47);
            this.materialButtonShowPhone.TabIndex = 38;
            this.materialButtonShowPhone.Text = "Показать телефон";
            this.materialButtonShowPhone.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowPhone.UseAccentColor = false;
            this.materialButtonShowPhone.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(23, 60);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 24);
            this.labelStatus.TabIndex = 35;
            this.labelStatus.Text = "Status";
            // 
            // labelProductCost
            // 
            this.labelProductCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductCost.AutoSize = true;
            this.labelProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductCost.Location = new System.Drawing.Point(817, 19);
            this.labelProductCost.Name = "labelProductCost";
            this.labelProductCost.Size = new System.Drawing.Size(86, 31);
            this.labelProductCost.TabIndex = 28;
            this.labelProductCost.Text = "999 ₽";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductName.Location = new System.Drawing.Point(21, 19);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(191, 31);
            this.labelProductName.TabIndex = 26;
            this.labelProductName.Text = "ProductName";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialButtonRefresh
            // 
            this.materialButtonRefresh.AutoSize = false;
            this.materialButtonRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialButtonRefresh.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonRefresh.Depth = 0;
            this.materialButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonRefresh.HighEmphasis = true;
            this.materialButtonRefresh.Icon = global::Dopamine.Properties.Resources.icons8_refresh_48;
            this.materialButtonRefresh.Location = new System.Drawing.Point(15, 21);
            this.materialButtonRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRefresh.Name = "materialButtonRefresh";
            this.materialButtonRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRefresh.Size = new System.Drawing.Size(119, 34);
            this.materialButtonRefresh.TabIndex = 17;
            this.materialButtonRefresh.Text = "Обновить";
            this.materialButtonRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonRefresh.UseAccentColor = false;
            this.materialButtonRefresh.UseVisualStyleBackColor = false;
            this.materialButtonRefresh.Click += new System.EventHandler(this.materialButtonRefresh_Click);
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
            this.materialButtonFind.Location = new System.Drawing.Point(432, 21);
            this.materialButtonFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonFind.Name = "materialButtonFind";
            this.materialButtonFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonFind.Size = new System.Drawing.Size(97, 34);
            this.materialButtonFind.TabIndex = 14;
            this.materialButtonFind.Text = "Найти";
            this.materialButtonFind.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonFind.UseAccentColor = false;
            this.materialButtonFind.UseVisualStyleBackColor = false;
            this.materialButtonFind.Click += new System.EventHandler(this.linkLabelSearch_Click);
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
            // pictureBoxMyPicture
            // 
            this.pictureBoxMyPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxMyPicture.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMyPicture.Name = "pictureBoxMyPicture";
            this.pictureBoxMyPicture.Size = new System.Drawing.Size(194, 194);
            this.pictureBoxMyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMyPicture.TabIndex = 27;
            this.pictureBoxMyPicture.TabStop = false;
            // 
            // pictureBoxSellerPicture
            // 
            this.pictureBoxSellerPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxSellerPicture.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSellerPicture.Name = "pictureBoxSellerPicture";
            this.pictureBoxSellerPicture.Size = new System.Drawing.Size(249, 249);
            this.pictureBoxSellerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSellerPicture.TabIndex = 27;
            this.pictureBoxSellerPicture.TabStop = false;
            // 
            // materialFloatingActionButtonClose2
            // 
            this.materialFloatingActionButtonClose2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFloatingActionButtonClose2.Depth = 0;
            this.materialFloatingActionButtonClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFloatingActionButtonClose2.Icon = global::Dopamine.Properties.Resources.icons8_close_48__1_;
            this.materialFloatingActionButtonClose2.ImageKey = "(отсутствует)";
            this.materialFloatingActionButtonClose2.Location = new System.Drawing.Point(1074, 3);
            this.materialFloatingActionButtonClose2.Mini = true;
            this.materialFloatingActionButtonClose2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButtonClose2.Name = "materialFloatingActionButtonClose2";
            this.materialFloatingActionButtonClose2.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButtonClose2.TabIndex = 44;
            this.materialFloatingActionButtonClose2.Text = "Закрыть";
            this.materialFloatingActionButtonClose2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCarts
            // 
            this.pictureBoxCarts.Image = global::Dopamine.Properties.Resources.icons8_cart_48;
            this.pictureBoxCarts.Location = new System.Drawing.Point(127, 21);
            this.pictureBoxCarts.Name = "pictureBoxCarts";
            this.pictureBoxCarts.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCarts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarts.TabIndex = 1;
            this.pictureBoxCarts.TabStop = false;
            // 
            // pictureBoxViews
            // 
            this.pictureBoxViews.Image = global::Dopamine.Properties.Resources.icons8_eye_48;
            this.pictureBoxViews.Location = new System.Drawing.Point(17, 21);
            this.pictureBoxViews.Name = "pictureBoxViews";
            this.pictureBoxViews.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxViews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxViews.TabIndex = 0;
            this.pictureBoxViews.TabStop = false;
            // 
            // materialFloatingActionButtonClose
            // 
            this.materialFloatingActionButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFloatingActionButtonClose.Depth = 0;
            this.materialFloatingActionButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFloatingActionButtonClose.Icon = global::Dopamine.Properties.Resources.icons8_close_48__1_;
            this.materialFloatingActionButtonClose.ImageKey = "(отсутствует)";
            this.materialFloatingActionButtonClose.Location = new System.Drawing.Point(1042, 3);
            this.materialFloatingActionButtonClose.Mini = true;
            this.materialFloatingActionButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButtonClose.Name = "materialFloatingActionButtonClose";
            this.materialFloatingActionButtonClose.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButtonClose.TabIndex = 43;
            this.materialFloatingActionButtonClose.Text = "Закрыть";
            this.materialFloatingActionButtonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(249, 249);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 27;
            this.pictureBoxPreview.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1115, 531);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // flowLayoutPanelMyArchive
            // 
            this.flowLayoutPanelMyArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMyArchive.AutoScroll = true;
            this.flowLayoutPanelMyArchive.Location = new System.Drawing.Point(258, 357);
            this.flowLayoutPanelMyArchive.Name = "flowLayoutPanelMyArchive";
            this.flowLayoutPanelMyArchive.Size = new System.Drawing.Size(885, 332);
            this.flowLayoutPanelMyArchive.TabIndex = 59;
            // 
            // flowLayoutPanelMyProducts
            // 
            this.flowLayoutPanelMyProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMyProducts.AutoSize = true;
            this.flowLayoutPanelMyProducts.Location = new System.Drawing.Point(258, 67);
            this.flowLayoutPanelMyProducts.Name = "flowLayoutPanelMyProducts";
            this.flowLayoutPanelMyProducts.Size = new System.Drawing.Size(885, 225);
            this.flowLayoutPanelMyProducts.TabIndex = 58;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1179, 820);
            this.Controls.Add(this.panelPopUp);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 255;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(955, 585);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dopamine (Гость)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageNewProduct.ResumeLayout(false);
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.tabPageCart.ResumeLayout(false);
            this.tabPageCart.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.tabPageSeller.ResumeLayout(false);
            this.tabPageSeller.PerformLayout();
            this.materialCardSellerPicture.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCardPicturePreview.ResumeLayout(false);
            this.materialCardAddress.ResumeLayout(false);
            this.materialCardAddress.PerformLayout();
            this.materialCardInfo.ResumeLayout(false);
            this.materialCardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSellerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxFind;
        private MaterialSkin.Controls.MaterialButton materialButtonFind;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCity;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageCart;
        private System.Windows.Forms.TabPage tabPageNewProduct;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelProductInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelProductCost;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label labelProductName;
        private MaterialSkin.Controls.MaterialButton materialButtonShowPhone;
        private MaterialSkin.Controls.MaterialButton materialButtonConnect;
        private MaterialSkin.Controls.MaterialCard materialCardInfo;
        private MaterialSkin.Controls.MaterialCard materialCardAddress;
        private MaterialSkin.Controls.MaterialCard materialCardPicturePreview;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButtonClose;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBoxCarts;
        private System.Windows.Forms.PictureBox pictureBoxViews;
        private MaterialSkin.Controls.MaterialLabel materialLabelViews;
        private MaterialSkin.Controls.MaterialLabel materialLabelCarts;
        private System.Windows.Forms.TabPage tabPageSeller;
        private MaterialSkin.Controls.MaterialCard materialCardSellerPicture;
        private System.Windows.Forms.PictureBox pictureBoxSellerPicture;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButtonClose2;
        private System.Windows.Forms.Label labelSellerName;
        private MaterialSkin.Controls.MaterialButton materialButtonConnect2;
        private MaterialSkin.Controls.MaterialButton materialButtonShowPhone2;
        private System.Windows.Forms.Label labelSellersProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSellersProducts;
        private MaterialSkin.Controls.MaterialButton materialButtonCancelFind;
        private MaterialSkin.Controls.MaterialButton materialButtonRefresh;
        private System.Windows.Forms.Panel panelPopUp;
        private Timer timer1;
        private Label labelMyUserName;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private PictureBox pictureBoxMyPicture;
        private MaterialSkin.Controls.MaterialButton materialButtonSetUpAccount;
        private Label label6;
        private Label label7;
        public MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private Label labelNonSelled;
        private Label labelNoMyProd;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButtonSelectPhotoForMyProduct;
        private Label label8;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private PictureBox pictureBoxMyProductPicture;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxNameOfMyProduct;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBoxDescForMyProd;
        private Label label9;
        private Label label10;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxStatusForMyProd;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCategoryForMyProd;
        private Label label11;
        private Label label12;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCityForMyProd;
        private Label label13;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxStreet;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private Label label15;
        private Label label14;
        private MaterialSkin.Controls.MaterialButton materialButtonRefreshMyProd;
        private MaterialSkin.Controls.MaterialButton materialButtonPublish;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxHouse;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxStreet2;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxCostForMyProd;
        private FlowLayoutPanel flowLayoutPanelCarts;
        private Label label16;
        private Label labelNonFav;
        private CustomFlowLayoutPanel flowLayoutPanel1;
        private CustomFlowLayoutPanel flowLayoutPanelMyProducts;
        private CustomFlowLayoutPanel flowLayoutPanelMyArchive;
        private TabPage tabPageSettings;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxCategories;
    }
}