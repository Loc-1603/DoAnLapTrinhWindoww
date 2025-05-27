
using System.Windows.Forms;

namespace Csharp_Entity_Store_Management
{
    partial class frmDashboard
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
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSuppilerManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnStockInManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnCategoryManagement = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
        }
        // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(222, 74);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.tableLayoutPanel1.SetRowSpan(this.panel, 2);
            this.panel.Size = new System.Drawing.Size(1259, 672);
            this.panel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1481, 746);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogout, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnDashboard, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuppilerManagement, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnProductManagement, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnStockInManagement, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnOrderManagement, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCategoryManagement, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAccountManagement, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 672);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 588);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(222, 84);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(222, 84);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSuppilerManagement
            // 
            this.btnSuppilerManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppilerManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuppilerManagement.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSuppilerManagement.FlatAppearance.BorderSize = 0;
            this.btnSuppilerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppilerManagement.ForeColor = System.Drawing.Color.White;
            this.btnSuppilerManagement.Location = new System.Drawing.Point(0, 504);
            this.btnSuppilerManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuppilerManagement.Name = "btnSuppilerManagement";
            this.btnSuppilerManagement.Size = new System.Drawing.Size(222, 84);
            this.btnSuppilerManagement.TabIndex = 0;
            this.btnSuppilerManagement.Text = "Quản lý nhà cung cấp";
            this.btnSuppilerManagement.UseVisualStyleBackColor = false;
            this.btnSuppilerManagement.Click += new System.EventHandler(this.btnSuppilerManagement_Click);
        // 
            // btnProductManagement
            // 
            this.btnProductManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductManagement.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnProductManagement.FlatAppearance.BorderSize = 0;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.ForeColor = System.Drawing.Color.White;
            this.btnProductManagement.Location = new System.Drawing.Point(0, 84);
            this.btnProductManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(222, 84);
            this.btnProductManagement.TabIndex = 0;
            this.btnProductManagement.Text = "Quản lý sản phẩm";
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnStockInManagement
            // 
            this.btnStockInManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockInManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStockInManagement.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStockInManagement.FlatAppearance.BorderSize = 0;
            this.btnStockInManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockInManagement.ForeColor = System.Drawing.Color.White;
            this.btnStockInManagement.Location = new System.Drawing.Point(0, 420);
            this.btnStockInManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnStockInManagement.Name = "btnStockInManagement";
            this.btnStockInManagement.Size = new System.Drawing.Size(222, 84);
            this.btnStockInManagement.TabIndex = 0;
            this.btnStockInManagement.Text = "Quản lý nhập kho";
            this.btnStockInManagement.UseVisualStyleBackColor = false;
            this.btnStockInManagement.Click += new System.EventHandler(this.btnStockInManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOrderManagement.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOrderManagement.FlatAppearance.BorderSize = 0;
            this.btnOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManagement.ForeColor = System.Drawing.Color.White;
            this.btnOrderManagement.Location = new System.Drawing.Point(0, 168);
            this.btnOrderManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(222, 84);
            this.btnOrderManagement.TabIndex = 0;
            this.btnOrderManagement.Text = "Quản lý hoá đơn";
            this.btnOrderManagement.UseVisualStyleBackColor = false;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnCategoryManagement
            // 
            this.btnCategoryManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoryManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCategoryManagement.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCategoryManagement.FlatAppearance.BorderSize = 0;
            this.btnCategoryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManagement.ForeColor = System.Drawing.Color.White;
            this.btnCategoryManagement.Location = new System.Drawing.Point(0, 336);
            this.btnCategoryManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategoryManagement.Name = "btnCategoryManagement";
            this.btnCategoryManagement.Size = new System.Drawing.Size(222, 84);
            this.btnCategoryManagement.TabIndex = 0;
            this.btnCategoryManagement.Text = "Quản lý danh mục";
            this.btnCategoryManagement.UseVisualStyleBackColor = false;
            this.btnCategoryManagement.Click += new System.EventHandler(this.btnCategoryManagement_Click);
        }