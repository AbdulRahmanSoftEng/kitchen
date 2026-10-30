
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kitchen
{
    public partial class frmHome : Form
    {
        // =========================================
        // CUSTOMER CONTROLS
        // =========================================

        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomerLocation;
        private ComboBox cboDesigner;

        // =========================================
        // KITCHEN INFORMATION
        // =========================================

        private TextBox txtInputColor;
        private TextBox txtMainColor;
        private TextBox txtMarbleColor;
        private TextBox txtBaseColor;
        private TextBox txtFrezColor;

        private NumericUpDown nudKitchenHeight;

        // =========================================
        // FLOORS
        // =========================================

        private NumericUpDown nudFloor1Depth;
        private NumericUpDown nudFloor1Height;

        private NumericUpDown nudFloor2Depth;
        private NumericUpDown nudFloor2Height;

        private NumericUpDown nudFloor3Depth;
        private NumericUpDown nudFloor3Height;

        // =========================================
        // MATERIALS
        // =========================================

        private CheckedListBox clbAluminumTypes;
        private CheckedListBox clbDoorTypes;
        private CheckedListBox clbHingeTypes;
        private CheckedListBox clbDrawerSlideTypes;
        private CheckedListBox clbHandleTypes;

        // =========================================
        // FEATURES
        // =========================================

        private CheckBox chkLighting;
        private TextBox txtLightingDetails;
        private NumericUpDown nudLightingArea;

        private CheckBox chkGlass;
        private TextBox txtGlassDetails;

        private CheckBox chkDecorations;
        private TextBox txtDecorationsDetails;

        private CheckBox chkOtherFeature;
        private TextBox txtOtherFeatureName;
        private TextBox txtOtherFeatureDetails;
        private NumericUpDown nudOtherFeatureArea;

        // =========================================
        // NOTES
        // =========================================

        private TextBox txtNotes;

        // =========================================
        // CONSTRUCTOR
        // =========================================

        public frmHome()
        {
            InitializeComponent();

            BuildInterface();

            Load += frmHome_Load;

            btnLoadImage.Click += btnLoadImage_Click;
            btnRemoveImage.Click += btnRemoveImage_Click;
            btnClose.Click += btnClose_Click;
        }

        // =========================================
        // FORM LOAD
        // =========================================

        private void frmHome_Load(object sender, EventArgs e)
        {
           

            
        }

        // =========================================
        // BUILD INTERFACE
        // =========================================

        private void BuildInterface()
        {
            BuildCustomerGroup();
            BuildKitchenGroup();
            BuildFloorsGroup();
            BuildMaterialsGroup();
            BuildFeaturesGroup();
            BuildNotesGroup();

            // ترتيب المجموعات داخل لوحة البيانات
            int y = 10;

            AddGroupToContent(grpCustomer, ref y, 180);
            AddGroupToContent(grpKitchenInfo, ref y, 240);
            AddGroupToContent(grpFloors, ref y, 190);
            AddGroupToContent(grpMaterials, ref y, 350);
            AddGroupToContent(grpFeatures, ref y, 270);
            AddGroupToContent(grpNotes, ref y, 120);

            // مساحة إضافية أسفل المحتوى
            pnlDetailsContent.Size = new Size(620, y + 20);
            pnlDetailsContent.MinimumSize = new Size(620, y + 20);

            // ضبط حجم لوحة المحتوى لتفعيل التمرير
            pnlDetailsScroll.AutoScrollMinSize =
                new Size(620, y + 20);

            // Footer buttons positions
            btnNew.Location = new Point(685, 12);
            btnSave.Location = new Point(545, 12);
            btnUpdate.Location = new Point(410, 12);
            btnDelete.Location = new Point(275, 12);
            btnPrint.Location = new Point(140, 12);
            btnClose.Location = new Point(5, 12);

            Button[] buttons =
            {
    btnNew, btnSave, btnUpdate,
    btnDelete, btnPrint, btnClose
};

            foreach (Button button in buttons)
            {
                button.Size = new Size(125, 45);
            }

            StyleButton(btnClose, Color.FromArgb(100, 116, 139));
            StyleButton(btnPrint, Color.FromArgb(37, 99, 170));
            StyleButton(btnDelete, Color.FromArgb(185, 55, 55));
            StyleButton(btnUpdate, Color.FromArgb(37, 99, 170));
            StyleButton(btnSave, Color.FromArgb(22, 130, 90));
            StyleButton(btnNew, Color.FromArgb(37, 99, 170));
        }

        // =========================================
        // CUSTOMER GROUP
        // =========================================

        private GroupBox grpCustomer;

        private void BuildCustomerGroup()
        {
            grpCustomer = CreateGroup("بيانات العميل والمصمم", 180);

            txtCustomerName = CreateTextBox();
            txtCustomerPhone = CreateTextBox();
            txtCustomerLocation = CreateTextBox();

            cboDesigner = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10),
                Width = 420
            };

            AddField(grpCustomer, "اسم العميل",
                txtCustomerName, 35);

            AddField(grpCustomer, "رقم الهاتف",
                txtCustomerPhone, 70);

            AddField(grpCustomer, "موقع العميل",
                txtCustomerLocation, 105);

            AddField(grpCustomer, "المصمم",
                cboDesigner, 140);
        }

        // =========================================
        // KITCHEN INFORMATION GROUP
        // =========================================

        private GroupBox grpKitchenInfo;

        private void BuildKitchenGroup()
        {
            grpKitchenInfo =
                CreateGroup("ألوان ومقاسات المطبخ", 210);

            txtInputColor = CreateTextBox();
            txtMainColor = CreateTextBox();
            txtMarbleColor = CreateTextBox();
            txtBaseColor = CreateTextBox();
            txtFrezColor = CreateTextBox();

            nudKitchenHeight = CreateNumber(270);

            AddField(grpKitchenInfo,
                "لون الإدخال", txtInputColor, 35);

            AddField(grpKitchenInfo,
                "اللون الأساسي", txtMainColor, 70);

            AddField(grpKitchenInfo,
                "لون الرخام", txtMarbleColor, 105);

            AddField(grpKitchenInfo,
                "لون القاعدة", txtBaseColor, 140);

            AddField(grpKitchenInfo,
                "لون الفرز", txtFrezColor, 175);
            
            // ارتفاع المطبخ
            AddLabel(grpKitchenInfo, "ارتفاع المطبخ (سم)",
                450, 210, 130);

            nudKitchenHeight.Location =
                new Point(15, 210);

            nudKitchenHeight.Width = 290;
            nudKitchenHeight.RightToLeft = RightToLeft.No;
            grpKitchenInfo.Controls.Add(nudKitchenHeight);
        }

        // =========================================
        // FLOORS GROUP
        // =========================================

        private GroupBox grpFloors;

        private void BuildFloorsGroup()
        {
            grpFloors =
                CreateGroup("مقاسات الأدوار (سم)", 190);

            AddLabel(grpFloors, "الدور",
                440, 35, 100);

            AddLabel(grpFloors, "العمق",
                280, 35, 100);

            AddLabel(grpFloors, "الارتفاع",
                100, 35, 100);

            nudFloor1Depth = CreateNumber(60);
            nudFloor1Height = CreateNumber(90);

            nudFloor2Depth = CreateNumber(35);
            nudFloor2Height = CreateNumber(70);

            nudFloor3Depth = CreateNumber(35);
            nudFloor3Height = CreateNumber(60);

            AddFloorRow("الدور الأول",
                nudFloor1Depth, nudFloor1Height, 70);

            AddFloorRow("الدور الثاني",
                nudFloor2Depth, nudFloor2Height, 105);

            AddFloorRow("الدور الثالث",
                nudFloor3Depth, nudFloor3Height, 140);
        }

        private void AddFloorRow(
            string title,
            NumericUpDown depth,
            NumericUpDown height,
            int y)
        {
            AddLabel(grpFloors, title, 440, y, 110);

            depth.Location = new Point(280, y);
            depth.Width = 110;

            height.Location = new Point(100, y);
            height.Width = 110;

            grpFloors.Controls.Add(depth);
            grpFloors.Controls.Add(height);
        }

        // =========================================
        // MATERIALS GROUP
        // =========================================

        private GroupBox grpMaterials;

        private void BuildMaterialsGroup()
        {
            grpMaterials =
                CreateGroup("المواد والتجهيزات", 350);

            clbAluminumTypes = CreateCheckedListBox();
            clbDoorTypes = CreateCheckedListBox();
            clbHingeTypes = CreateCheckedListBox();
            clbDrawerSlideTypes = CreateCheckedListBox();
            clbHandleTypes = CreateCheckedListBox();

            AddLabel(grpMaterials, "أنواع الألمنيوم",
                310, 35, 240);

            AddLabel(grpMaterials, "أنواع الدرف",
                25, 35, 240);

            AddMaterialList(clbAluminumTypes, 300, 60);
            AddMaterialList(clbDoorTypes, 15, 60);

            AddLabel(grpMaterials, "أنواع المفصلات",
                310, 165, 240);

            AddLabel(grpMaterials, "أنواع السحابات",
                25, 165, 240);

            AddMaterialList(clbHingeTypes, 300, 190);
            AddMaterialList(clbDrawerSlideTypes, 15, 190);

            AddLabel(grpMaterials, "أنواع المسكات",
                310, 295, 240);

            AddMaterialList(clbHandleTypes, 300, 315);
        }

        private void AddMaterialList(
            CheckedListBox list,
            int x,
            int y)
        {
            list.Location = new Point(x, y);
            list.Size = new Size(250, 90);

            grpMaterials.Controls.Add(list);
        }

        // =========================================
        // FEATURES GROUP
        // =========================================

        private GroupBox grpFeatures;

        private void BuildFeaturesGroup()
        {
            grpFeatures =
                CreateGroup("الإضافات والخصائص الاختيارية", 270);

            chkLighting = CreateCheckBox("الإنارة", 475, 35);
            chkGlass = CreateCheckBox("الزجاج", 475, 85);
            chkDecorations = CreateCheckBox("الديكورات", 475, 135);
            chkOtherFeature = CreateCheckBox("عنصر آخر", 475, 185);

            txtLightingDetails = CreateTextBox();
            nudLightingArea = CreateNumber(0);

            txtGlassDetails = CreateTextBox();
            txtDecorationsDetails = CreateTextBox();

            txtOtherFeatureName = CreateTextBox();
            txtOtherFeatureDetails = CreateTextBox();

            nudOtherFeatureArea = CreateNumber(0);

            AddField(grpFeatures, "تفاصيل الإنارة",
                txtLightingDetails, 35);

            AddField(grpFeatures, "مساحة الإنارة",
                nudLightingArea, 65);

            AddField(grpFeatures, "تفاصيل الزجاج",
                txtGlassDetails, 105);

            AddField(grpFeatures, "تفاصيل الديكورات",
                txtDecorationsDetails, 140);

            AddField(grpFeatures, "اسم العنصر",
                txtOtherFeatureName, 175);

            AddField(grpFeatures, "تفاصيل العنصر",
                txtOtherFeatureDetails, 210);

            AddField(grpFeatures, "المساحة (م²)",
                nudOtherFeatureArea, 240);

            grpFeatures.Controls.Add(chkLighting);
            grpFeatures.Controls.Add(chkGlass);
            grpFeatures.Controls.Add(chkDecorations);
            grpFeatures.Controls.Add(chkOtherFeature);
        }

        // =========================================
        // NOTES GROUP
        // =========================================

        private GroupBox grpNotes;

        private void BuildNotesGroup()
        {
            grpNotes =
                CreateGroup("ملاحظات إضافية", 120);

            txtNotes = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Segoe UI", 10),
                Location = new Point(15, 35),
                Size = new Size(545, 70)
            };

            grpNotes.Controls.Add(txtNotes);
        }

        // =========================================
        // ADD GROUP TO CONTENT
        // =========================================

        private void AddGroupToContent(
            GroupBox group,
            ref int y,
            int height)
        {
            group.Location = new Point(10, y);
            group.Size = new Size(580, height);

            pnlDetailsContent.Controls.Add(group);

            y += height + 10;
        }

        // =========================================
        // HELPER METHODS
        // =========================================

        private GroupBox CreateGroup(
            string title,
            int height)
        {
            return new GroupBox
            {
                Text = title,
                Size = new Size(580, height),
                Font = new Font(
                    "Segoe UI", 10,
                    FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 58, 95),
                BackColor = Color.White,
                Padding = new Padding(8)
            };
        }

        private TextBox CreateTextBox()
        {
            return new TextBox
            {
                Font = new Font("Segoe UI", 10),
                Width = 420
            };
        }

        private NumericUpDown CreateNumber(decimal value)
        {
            return new NumericUpDown
            {
                Minimum = 0,
                Maximum = 100000,
                DecimalPlaces = 2,
                Value = value,
                ThousandsSeparator = true,
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 10)
            };
        }

        private CheckedListBox CreateCheckedListBox()
        {
            return new CheckedListBox
            {
                CheckOnClick = true,
                IntegralHeight = false,
                HorizontalScrollbar = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9)
            };
        }

        private CheckBox CreateCheckBox(
            string text,
            int x,
            int y)
        {
            return new CheckBox
            {
                Text = text,
                Location = new Point(x, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 9)
            };
        }

        private void AddLabel(
            Control parent,
            string text,
            int x,
            int y,
            int width)
        {
            Label label = new Label
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(width, 27),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(55, 65, 81)
            };

            parent.RightToLeft = RightToLeft.Yes;
            parent.Controls.Add(label);
        }

        private void AddField(
            Control parent,
            string labelText,
            Control control,
            int y)
        {
            AddLabel(parent, labelText, 450, y, 130);

            control.Location = new Point(15, y);
            control.Size = new Size(290, 28);

            parent.Controls.Add(control);
        }

        // =========================================
        // BUTTON STYLE
        // =========================================

        private void StyleButton(
            Button button,
            Color color)
        {
            button.BackColor = color;
            button.ForeColor = Color.White;

            button.FlatStyle = FlatStyle.Flat;
            button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button.FlatAppearance.BorderSize = 0;

            button.Font = new Font(
                "Segoe UI", 10, FontStyle.Bold);

            button.Cursor = Cursors.Hand;
        }

        // =========================================
        // IMAGE BUTTONS
        // =========================================

        private void btnLoadImage_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "اختر صورة المطبخ";

                dialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image image = Image.FromFile(dialog.FileName))
                        {
                            picKitchen.Image = new Bitmap(image);
                        }

                        lblImageHint.Text = "تم تحميل صورة المطبخ";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "تعذر تحميل الصورة: " + ex.Message,
                            "خطأ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRemoveImage_Click(
            object sender,
            EventArgs e)
        {
            if (picKitchen.Image != null)
            {
                Image oldImage = picKitchen.Image;

                picKitchen.Image = null;
                oldImage.Dispose();
            }

            lblImageHint.Text = "لم يتم تحميل صورة للمطبخ";
        }

        // =========================================
        // CLOSE BUTTON
        // =========================================

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

    }
}
