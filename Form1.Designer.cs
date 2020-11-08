namespace Xml_Lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbFaculty = new System.Windows.Forms.CheckBox();
            this.cbCathedra = new System.Windows.Forms.CheckBox();
            this.cbMember = new System.Windows.Forms.CheckBox();
            this.cbSex = new System.Windows.Forms.CheckBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxCathedra = new System.Windows.Forms.ComboBox();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbID = new System.Windows.Forms.CheckBox();
            this.cbTimeOfEntry = new System.Windows.Forms.CheckBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxTImeOfEntry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbFaculty
            // 
            this.cbFaculty.AutoSize = true;
            this.cbFaculty.Location = new System.Drawing.Point(12, 15);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(100, 24);
            this.cbFaculty.TabIndex = 0;
            this.cbFaculty.Text = "Факультет";
            this.cbFaculty.UseVisualStyleBackColor = true;
            this.cbFaculty.Click += new System.EventHandler(this.cbFaculty_Click);
            // 
            // cbCathedra
            // 
            this.cbCathedra.AutoSize = true;
            this.cbCathedra.Location = new System.Drawing.Point(12, 50);
            this.cbCathedra.Name = "cbCathedra";
            this.cbCathedra.Size = new System.Drawing.Size(91, 24);
            this.cbCathedra.TabIndex = 1;
            this.cbCathedra.Text = "Кафедра";
            this.cbCathedra.UseVisualStyleBackColor = true;
            this.cbCathedra.Click += new System.EventHandler(this.cbCathedra_Click);
            // 
            // cbMember
            // 
            this.cbMember.AutoSize = true;
            this.cbMember.Location = new System.Drawing.Point(12, 85);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(88, 24);
            this.cbMember.TabIndex = 2;
            this.cbMember.Text = "Учасник";
            this.cbMember.UseVisualStyleBackColor = true;
            this.cbMember.Click += new System.EventHandler(this.cbMember_Click);
            // 
            // cbSex
            // 
            this.cbSex.AutoSize = true;
            this.cbSex.Location = new System.Drawing.Point(12, 120);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(68, 24);
            this.cbSex.TabIndex = 3;
            this.cbSex.Text = "Стать";
            this.cbSex.UseVisualStyleBackColor = true;
            this.cbSex.Click += new System.EventHandler(this.cbSex_Click);
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(141, 13);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(175, 28);
            this.comboBoxFaculty.TabIndex = 4;
            this.comboBoxFaculty.Visible = false;
            // 
            // comboBoxCathedra
            // 
            this.comboBoxCathedra.FormattingEnabled = true;
            this.comboBoxCathedra.Location = new System.Drawing.Point(141, 48);
            this.comboBoxCathedra.Name = "comboBoxCathedra";
            this.comboBoxCathedra.Size = new System.Drawing.Size(175, 28);
            this.comboBoxCathedra.TabIndex = 5;
            this.comboBoxCathedra.Visible = false;
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Location = new System.Drawing.Point(141, 83);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(175, 28);
            this.comboBoxMember.TabIndex = 6;
            this.comboBoxMember.Visible = false;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(141, 118);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(175, 28);
            this.comboBoxSex.TabIndex = 7;
            this.comboBoxSex.Visible = false;
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(217, 239);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(65, 24);
            this.radioButtonDOM.TabIndex = 8;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(217, 269);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSAX.TabIndex = 9;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(217, 299);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(114, 24);
            this.radioButtonLINQ.TabIndex = 10;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ to XML";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(337, 28);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(361, 381);
            this.rtbResult.TabIndex = 11;
            this.rtbResult.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(12, 238);
            this.btnSearch.MaximumSize = new System.Drawing.Size(300, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Знайти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTransform.Location = new System.Drawing.Point(12, 274);
            this.btnTransform.MaximumSize = new System.Drawing.Size(300, 62);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(169, 29);
            this.btnTransform.TabIndex = 13;
            this.btnTransform.Text = "Конвертувати в HTML";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(12, 309);
            this.btnClear.MaximumSize = new System.Drawing.Size(300, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 29);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Location = new System.Drawing.Point(12, 155);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(109, 24);
            this.cbID.TabIndex = 15;
            this.cbID.Text = "ID кафедри";
            this.cbID.UseVisualStyleBackColor = true;
            this.cbID.Click += new System.EventHandler(this.cbID_Click);
            // 
            // cbTimeOfEntry
            // 
            this.cbTimeOfEntry.AutoSize = true;
            this.cbTimeOfEntry.Location = new System.Drawing.Point(12, 190);
            this.cbTimeOfEntry.Name = "cbTimeOfEntry";
            this.cbTimeOfEntry.Size = new System.Drawing.Size(115, 24);
            this.cbTimeOfEntry.TabIndex = 16;
            this.cbTimeOfEntry.Text = "Дата вступу ";
            this.cbTimeOfEntry.UseVisualStyleBackColor = true;
            this.cbTimeOfEntry.Click += new System.EventHandler(this.cbTimeOfEntry_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(141, 153);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(175, 28);
            this.comboBoxID.TabIndex = 17;
            this.comboBoxID.Visible = false;
            // 
            // comboBoxTImeOfEntry
            // 
            this.comboBoxTImeOfEntry.FormattingEnabled = true;
            this.comboBoxTImeOfEntry.Location = new System.Drawing.Point(141, 188);
            this.comboBoxTImeOfEntry.Name = "comboBoxTImeOfEntry";
            this.comboBoxTImeOfEntry.Size = new System.Drawing.Size(175, 28);
            this.comboBoxTImeOfEntry.TabIndex = 18;
            this.comboBoxTImeOfEntry.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 421);
            this.Controls.Add(this.comboBoxTImeOfEntry);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.cbTimeOfEntry);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.comboBoxCathedra);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.cbCathedra);
            this.Controls.Add(this.cbFaculty);
            this.Name = "Form1";
            this.Text = "Xml_Lab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbFaculty;
        private System.Windows.Forms.CheckBox cbCathedra;
        private System.Windows.Forms.CheckBox cbMember;
        private System.Windows.Forms.CheckBox cbSex;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxCathedra;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbID;
        private System.Windows.Forms.CheckBox cbTimeOfEntry;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxTImeOfEntry;
    }
}

