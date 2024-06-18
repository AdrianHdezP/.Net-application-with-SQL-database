namespace App
{
    partial class FormArticleList
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.TextBoxFilter = new System.Windows.Forms.TextBox();
            this.LabelFiled = new System.Windows.Forms.Label();
            this.ComboBoxField = new System.Windows.Forms.ComboBox();
            this.LabelPrinciple = new System.Windows.Forms.Label();
            this.ComboBoxPrinciple = new System.Windows.Forms.ComboBox();
            this.LabelFilter2 = new System.Windows.Forms.Label();
            this.TextBoxFilter2 = new System.Windows.Forms.TextBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnResetFilter = new System.Windows.Forms.Button();
            this.BtnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.Location = new System.Drawing.Point(12, 84);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(636, 336);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Location = new System.Drawing.Point(782, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(353, 523);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(662, 188);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 37);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BtnModify
            // 
            this.BtnModify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModify.Location = new System.Drawing.Point(662, 266);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(110, 37);
            this.BtnModify.TabIndex = 3;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(662, 350);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(110, 37);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LabelFilter
            // 
            this.LabelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFilter.Location = new System.Drawing.Point(8, 33);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(48, 20);
            this.LabelFilter.TabIndex = 5;
            this.LabelFilter.Text = "Filter:";
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFilter.Location = new System.Drawing.Point(62, 31);
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(714, 26);
            this.TextBoxFilter.TabIndex = 6;
            this.TextBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
            // 
            // LabelFiled
            // 
            this.LabelFiled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFiled.AutoSize = true;
            this.LabelFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiled.Location = new System.Drawing.Point(12, 506);
            this.LabelFiled.Name = "LabelFiled";
            this.LabelFiled.Size = new System.Drawing.Size(47, 20);
            this.LabelFiled.TabIndex = 7;
            this.LabelFiled.Text = "Field:";
            // 
            // ComboBoxField
            // 
            this.ComboBoxField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxField.FormattingEnabled = true;
            this.ComboBoxField.Location = new System.Drawing.Point(62, 503);
            this.ComboBoxField.Name = "ComboBoxField";
            this.ComboBoxField.Size = new System.Drawing.Size(138, 28);
            this.ComboBoxField.TabIndex = 8;
            this.ComboBoxField.SelectedIndexChanged += new System.EventHandler(this.ComboBoxField_SelectedIndexChanged);
            // 
            // LabelPrinciple
            // 
            this.LabelPrinciple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrinciple.AutoSize = true;
            this.LabelPrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrinciple.Location = new System.Drawing.Point(206, 506);
            this.LabelPrinciple.Name = "LabelPrinciple";
            this.LabelPrinciple.Size = new System.Drawing.Size(72, 20);
            this.LabelPrinciple.TabIndex = 9;
            this.LabelPrinciple.Text = "Principle:";
            // 
            // ComboBoxPrinciple
            // 
            this.ComboBoxPrinciple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPrinciple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPrinciple.FormattingEnabled = true;
            this.ComboBoxPrinciple.Location = new System.Drawing.Point(284, 503);
            this.ComboBoxPrinciple.Name = "ComboBoxPrinciple";
            this.ComboBoxPrinciple.Size = new System.Drawing.Size(234, 28);
            this.ComboBoxPrinciple.TabIndex = 10;
            // 
            // LabelFilter2
            // 
            this.LabelFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFilter2.AutoSize = true;
            this.LabelFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFilter2.Location = new System.Drawing.Point(524, 506);
            this.LabelFilter2.Name = "LabelFilter2";
            this.LabelFilter2.Size = new System.Drawing.Size(48, 20);
            this.LabelFilter2.TabIndex = 11;
            this.LabelFilter2.Text = "Filter:";
            // 
            // TextBoxFilter2
            // 
            this.TextBoxFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFilter2.Location = new System.Drawing.Point(578, 503);
            this.TextBoxFilter2.Name = "TextBoxFilter2";
            this.TextBoxFilter2.Size = new System.Drawing.Size(198, 26);
            this.TextBoxFilter2.TabIndex = 12;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFilter.Location = new System.Drawing.Point(12, 440);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(110, 37);
            this.BtnFilter.TabIndex = 13;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnResetFilter
            // 
            this.BtnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResetFilter.Location = new System.Drawing.Point(168, 440);
            this.BtnResetFilter.Name = "BtnResetFilter";
            this.BtnResetFilter.Size = new System.Drawing.Size(110, 37);
            this.BtnResetFilter.TabIndex = 14;
            this.BtnResetFilter.Text = "Reset Filter";
            this.BtnResetFilter.UseVisualStyleBackColor = true;
            this.BtnResetFilter.Click += new System.EventHandler(this.BtnResetFilter_Click);
            // 
            // BtnDetail
            // 
            this.BtnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetail.Location = new System.Drawing.Point(662, 115);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(110, 37);
            this.BtnDetail.TabIndex = 15;
            this.BtnDetail.Text = "Detail";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // FormArticleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 547);
            this.Controls.Add(this.BtnDetail);
            this.Controls.Add(this.BtnResetFilter);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.TextBoxFilter2);
            this.Controls.Add(this.LabelFilter2);
            this.Controls.Add(this.ComboBoxPrinciple);
            this.Controls.Add(this.LabelPrinciple);
            this.Controls.Add(this.ComboBoxField);
            this.Controls.Add(this.LabelFiled);
            this.Controls.Add(this.TextBoxFilter);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.DataGridView);
            this.MaximumSize = new System.Drawing.Size(1163, 586);
            this.MinimumSize = new System.Drawing.Size(1163, 586);
            this.Name = "FormArticleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Article List";
            this.Load += new System.EventHandler(this.FormArticleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LabelFilter;
        private System.Windows.Forms.TextBox TextBoxFilter;
        private System.Windows.Forms.Label LabelFiled;
        private System.Windows.Forms.ComboBox ComboBoxField;
        private System.Windows.Forms.Label LabelPrinciple;
        private System.Windows.Forms.ComboBox ComboBoxPrinciple;
        private System.Windows.Forms.Label LabelFilter2;
        private System.Windows.Forms.TextBox TextBoxFilter2;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnResetFilter;
        private System.Windows.Forms.Button BtnDetail;
    }
}

