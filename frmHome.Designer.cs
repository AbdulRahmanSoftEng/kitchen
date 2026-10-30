
namespace Kitchen
{
    partial class frmHome
    {
        private System.ComponentModel.IContainer components = null;

        // Main containers
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.SplitContainer splitMain;

        // Image section
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.PictureBox picKitchen;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Label lblImageHint;

        // Header
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblKitchenID;

        // Footer buttons
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblKitchenID = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picKitchen = new System.Windows.Forms.PictureBox();
            this.lblImageHint = new System.Windows.Forms.Label();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.pnlDetailsScroll = new System.Windows.Forms.Panel();
            this.pnlDetailsContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKitchen)).BeginInit();
            this.pnlDetailsScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblKitchenID);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 85);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(1038, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نظام تصميم المطابخ | MY KITCHEN";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitle.Location = new System.Drawing.Point(25, 49);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubtitle.Size = new System.Drawing.Size(1027, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "استمارة بيانات ومواصفات المطبخ";
            // 
            // lblKitchenID
            // 
            this.lblKitchenID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKitchenID.AutoSize = true;
            this.lblKitchenID.ForeColor = System.Drawing.Color.White;
            this.lblKitchenID.Location = new System.Drawing.Point(1934, 30);
            this.lblKitchenID.Name = "lblKitchenID";
            this.lblKitchenID.Size = new System.Drawing.Size(128, 19);
            this.lblKitchenID.TabIndex = 2;
            this.lblKitchenID.Text = "رقم الاستمارة: جديدة";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnNew);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.btnUpdate);
            this.pnlFooter.Controls.Add(this.btnDelete);
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 586);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(12);
            this.pnlFooter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFooter.Size = new System.Drawing.Size(1084, 75);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(0, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "استمارة جديدة";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "تعديل";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "طباعة";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "إغلاق";
            // 
            // splitMain
            // 
            this.splitMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 85);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.grpImage);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(4);
            this.splitMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitMain.Panel1MinSize = 0;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.AutoScroll = true;
            this.splitMain.Panel2.Controls.Add(this.pnlDetailsScroll);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitMain.Panel2MinSize = 0;
            this.splitMain.Size = new System.Drawing.Size(1084, 501);
            this.splitMain.SplitterDistance = 652;
            this.splitMain.TabIndex = 0;
            // 
            // grpImage
            // 
            this.grpImage.BackColor = System.Drawing.Color.White;
            this.grpImage.Controls.Add(this.picKitchen);
            this.grpImage.Controls.Add(this.lblImageHint);
            this.grpImage.Controls.Add(this.btnLoadImage);
            this.grpImage.Controls.Add(this.btnRemoveImage);
            this.grpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImage.Location = new System.Drawing.Point(4, 4);
            this.grpImage.Name = "grpImage";
            this.grpImage.Padding = new System.Windows.Forms.Padding(12);
            this.grpImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpImage.Size = new System.Drawing.Size(644, 493);
            this.grpImage.TabIndex = 0;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "صورة المطبخ";
            // 
            // picKitchen
            // 
            this.picKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.picKitchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picKitchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picKitchen.Location = new System.Drawing.Point(12, 30);
            this.picKitchen.Name = "picKitchen";
            this.picKitchen.Size = new System.Drawing.Size(620, 336);
            this.picKitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKitchen.TabIndex = 0;
            this.picKitchen.TabStop = false;
            // 
            // lblImageHint
            // 
            this.lblImageHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblImageHint.Location = new System.Drawing.Point(12, 366);
            this.lblImageHint.Name = "lblImageHint";
            this.lblImageHint.Size = new System.Drawing.Size(620, 35);
            this.lblImageHint.TabIndex = 1;
            this.lblImageHint.Text = "لم يتم تحميل صورة للمطبخ";
            this.lblImageHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveImage.Location = new System.Drawing.Point(12, 439);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(620, 38);
            this.btnRemoveImage.TabIndex = 2;
            this.btnRemoveImage.Text = "إزالة الصورة";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLoadImage.Location = new System.Drawing.Point(12, 401);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(620, 42);
            this.btnLoadImage.TabIndex = 3;
            this.btnLoadImage.Text = "تحميل صورة";
            // 
            // pnlDetailsScroll
            // 
            this.pnlDetailsScroll.AutoScroll = true;
            this.pnlDetailsScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlDetailsScroll.Controls.Add(this.pnlDetailsContent);
            this.pnlDetailsScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailsScroll.Location = new System.Drawing.Point(4, 4);
            this.pnlDetailsScroll.Name = "pnlDetailsScroll";
            this.pnlDetailsScroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlDetailsScroll.Size = new System.Drawing.Size(420, 493);
            this.pnlDetailsScroll.TabIndex = 0;
            // 
            // pnlDetailsContent
            // 
            this.pnlDetailsContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlDetailsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailsContent.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailsContent.Name = "pnlDetailsContent";
            this.pnlDetailsContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDetailsContent.Size = new System.Drawing.Size(420, 493);
            this.pnlDetailsContent.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "frmHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Kitchen - نظام إدارة المطابخ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picKitchen)).EndInit();
            this.pnlDetailsScroll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetailsScroll;
        private System.Windows.Forms.Panel pnlDetailsContent;
    }
}
