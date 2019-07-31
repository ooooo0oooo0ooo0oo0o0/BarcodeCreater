namespace BarcodeCreator
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CodeBox = new System.Windows.Forms.GroupBox();
            this.CodeInputTable = new System.Windows.Forms.TableLayoutPanel();
            this.Code16 = new System.Windows.Forms.MaskedTextBox();
            this.Code26 = new System.Windows.Forms.MaskedTextBox();
            this.Code17 = new System.Windows.Forms.MaskedTextBox();
            this.Code27 = new System.Windows.Forms.MaskedTextBox();
            this.Code18 = new System.Windows.Forms.MaskedTextBox();
            this.Code28 = new System.Windows.Forms.MaskedTextBox();
            this.Code19 = new System.Windows.Forms.MaskedTextBox();
            this.Code29 = new System.Windows.Forms.MaskedTextBox();
            this.Code20 = new System.Windows.Forms.MaskedTextBox();
            this.Code30 = new System.Windows.Forms.MaskedTextBox();
            this.Code11 = new System.Windows.Forms.MaskedTextBox();
            this.Code21 = new System.Windows.Forms.MaskedTextBox();
            this.Code12 = new System.Windows.Forms.MaskedTextBox();
            this.Code22 = new System.Windows.Forms.MaskedTextBox();
            this.Code13 = new System.Windows.Forms.MaskedTextBox();
            this.Code23 = new System.Windows.Forms.MaskedTextBox();
            this.Code14 = new System.Windows.Forms.MaskedTextBox();
            this.Code24 = new System.Windows.Forms.MaskedTextBox();
            this.Code15 = new System.Windows.Forms.MaskedTextBox();
            this.Code25 = new System.Windows.Forms.MaskedTextBox();
            this.Code03 = new System.Windows.Forms.MaskedTextBox();
            this.Code01 = new System.Windows.Forms.MaskedTextBox();
            this.Code02 = new System.Windows.Forms.MaskedTextBox();
            this.Code04 = new System.Windows.Forms.MaskedTextBox();
            this.Code05 = new System.Windows.Forms.MaskedTextBox();
            this.Code06 = new System.Windows.Forms.MaskedTextBox();
            this.Code07 = new System.Windows.Forms.MaskedTextBox();
            this.Code08 = new System.Windows.Forms.MaskedTextBox();
            this.Code09 = new System.Windows.Forms.MaskedTextBox();
            this.Code10 = new System.Windows.Forms.MaskedTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PrinterList = new System.Windows.Forms.ComboBox();
            this.PrinterBox = new System.Windows.Forms.GroupBox();
            this.BarcodeFormatLabel = new System.Windows.Forms.Label();
            this.BarcodeFormatList = new System.Windows.Forms.ComboBox();
            this.CodeBox.SuspendLayout();
            this.CodeInputTable.SuspendLayout();
            this.PrinterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.Controls.Add(this.BarcodeFormatList);
            this.CodeBox.Controls.Add(this.BarcodeFormatLabel);
            this.CodeBox.Controls.Add(this.CodeInputTable);
            this.CodeBox.Location = new System.Drawing.Point(39, 28);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(532, 467);
            this.CodeBox.TabIndex = 0;
            this.CodeBox.TabStop = false;
            this.CodeBox.Text = "生成したいバーコードを入力";
            // 
            // CodeInputTable
            // 
            this.CodeInputTable.ColumnCount = 3;
            this.CodeInputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CodeInputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CodeInputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CodeInputTable.Controls.Add(this.Code16, 1, 5);
            this.CodeInputTable.Controls.Add(this.Code26, 2, 5);
            this.CodeInputTable.Controls.Add(this.Code17, 1, 6);
            this.CodeInputTable.Controls.Add(this.Code27, 2, 6);
            this.CodeInputTable.Controls.Add(this.Code18, 1, 7);
            this.CodeInputTable.Controls.Add(this.Code28, 2, 7);
            this.CodeInputTable.Controls.Add(this.Code19, 1, 8);
            this.CodeInputTable.Controls.Add(this.Code29, 2, 8);
            this.CodeInputTable.Controls.Add(this.Code20, 1, 9);
            this.CodeInputTable.Controls.Add(this.Code30, 2, 9);
            this.CodeInputTable.Controls.Add(this.Code11, 1, 0);
            this.CodeInputTable.Controls.Add(this.Code21, 2, 0);
            this.CodeInputTable.Controls.Add(this.Code12, 1, 1);
            this.CodeInputTable.Controls.Add(this.Code22, 2, 1);
            this.CodeInputTable.Controls.Add(this.Code13, 1, 2);
            this.CodeInputTable.Controls.Add(this.Code23, 2, 2);
            this.CodeInputTable.Controls.Add(this.Code14, 1, 3);
            this.CodeInputTable.Controls.Add(this.Code24, 2, 3);
            this.CodeInputTable.Controls.Add(this.Code15, 1, 4);
            this.CodeInputTable.Controls.Add(this.Code25, 2, 4);
            this.CodeInputTable.Controls.Add(this.Code03, 0, 2);
            this.CodeInputTable.Controls.Add(this.Code01, 0, 0);
            this.CodeInputTable.Controls.Add(this.Code02, 0, 1);
            this.CodeInputTable.Controls.Add(this.Code04, 0, 3);
            this.CodeInputTable.Controls.Add(this.Code05, 0, 4);
            this.CodeInputTable.Controls.Add(this.Code06, 0, 5);
            this.CodeInputTable.Controls.Add(this.Code07, 0, 6);
            this.CodeInputTable.Controls.Add(this.Code08, 0, 7);
            this.CodeInputTable.Controls.Add(this.Code09, 0, 8);
            this.CodeInputTable.Controls.Add(this.Code10, 0, 9);
            this.CodeInputTable.Location = new System.Drawing.Point(26, 39);
            this.CodeInputTable.Name = "CodeInputTable";
            this.CodeInputTable.RowCount = 10;
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CodeInputTable.Size = new System.Drawing.Size(488, 350);
            this.CodeInputTable.TabIndex = 4;
            // 
            // Code16
            // 
            this.Code16.Location = new System.Drawing.Point(160, 158);
            this.Code16.Name = "Code16";
            this.Code16.Size = new System.Drawing.Size(151, 25);
            this.Code16.TabIndex = 15;
            // 
            // Code26
            // 
            this.Code26.Location = new System.Drawing.Point(317, 158);
            this.Code26.Name = "Code26";
            this.Code26.Size = new System.Drawing.Size(151, 25);
            this.Code26.TabIndex = 25;
            // 
            // Code17
            // 
            this.Code17.Location = new System.Drawing.Point(160, 189);
            this.Code17.Name = "Code17";
            this.Code17.Size = new System.Drawing.Size(151, 25);
            this.Code17.TabIndex = 16;
            // 
            // Code27
            // 
            this.Code27.Location = new System.Drawing.Point(317, 189);
            this.Code27.Name = "Code27";
            this.Code27.Size = new System.Drawing.Size(151, 25);
            this.Code27.TabIndex = 26;
            // 
            // Code18
            // 
            this.Code18.Location = new System.Drawing.Point(160, 220);
            this.Code18.Name = "Code18";
            this.Code18.Size = new System.Drawing.Size(151, 25);
            this.Code18.TabIndex = 17;
            // 
            // Code28
            // 
            this.Code28.Location = new System.Drawing.Point(317, 220);
            this.Code28.Name = "Code28";
            this.Code28.Size = new System.Drawing.Size(151, 25);
            this.Code28.TabIndex = 27;
            // 
            // Code19
            // 
            this.Code19.Location = new System.Drawing.Point(160, 251);
            this.Code19.Name = "Code19";
            this.Code19.Size = new System.Drawing.Size(151, 25);
            this.Code19.TabIndex = 18;
            // 
            // Code29
            // 
            this.Code29.Location = new System.Drawing.Point(317, 251);
            this.Code29.Name = "Code29";
            this.Code29.Size = new System.Drawing.Size(151, 25);
            this.Code29.TabIndex = 28;
            // 
            // Code20
            // 
            this.Code20.Location = new System.Drawing.Point(160, 282);
            this.Code20.Name = "Code20";
            this.Code20.Size = new System.Drawing.Size(151, 25);
            this.Code20.TabIndex = 19;
            // 
            // Code30
            // 
            this.Code30.Location = new System.Drawing.Point(317, 282);
            this.Code30.Name = "Code30";
            this.Code30.Size = new System.Drawing.Size(151, 25);
            this.Code30.TabIndex = 29;
            // 
            // Code11
            // 
            this.Code11.Location = new System.Drawing.Point(160, 3);
            this.Code11.Name = "Code11";
            this.Code11.Size = new System.Drawing.Size(151, 25);
            this.Code11.TabIndex = 10;
            // 
            // Code21
            // 
            this.Code21.Location = new System.Drawing.Point(317, 3);
            this.Code21.Name = "Code21";
            this.Code21.Size = new System.Drawing.Size(151, 25);
            this.Code21.TabIndex = 20;
            // 
            // Code12
            // 
            this.Code12.Location = new System.Drawing.Point(160, 34);
            this.Code12.Name = "Code12";
            this.Code12.Size = new System.Drawing.Size(151, 25);
            this.Code12.TabIndex = 11;
            // 
            // Code22
            // 
            this.Code22.Location = new System.Drawing.Point(317, 34);
            this.Code22.Name = "Code22";
            this.Code22.Size = new System.Drawing.Size(151, 25);
            this.Code22.TabIndex = 21;
            // 
            // Code13
            // 
            this.Code13.Location = new System.Drawing.Point(160, 65);
            this.Code13.Name = "Code13";
            this.Code13.Size = new System.Drawing.Size(151, 25);
            this.Code13.TabIndex = 12;
            // 
            // Code23
            // 
            this.Code23.Location = new System.Drawing.Point(317, 65);
            this.Code23.Name = "Code23";
            this.Code23.Size = new System.Drawing.Size(151, 25);
            this.Code23.TabIndex = 22;
            // 
            // Code14
            // 
            this.Code14.Location = new System.Drawing.Point(160, 96);
            this.Code14.Name = "Code14";
            this.Code14.Size = new System.Drawing.Size(151, 25);
            this.Code14.TabIndex = 13;
            // 
            // Code24
            // 
            this.Code24.Location = new System.Drawing.Point(317, 96);
            this.Code24.Name = "Code24";
            this.Code24.Size = new System.Drawing.Size(151, 25);
            this.Code24.TabIndex = 23;
            // 
            // Code15
            // 
            this.Code15.Location = new System.Drawing.Point(160, 127);
            this.Code15.Name = "Code15";
            this.Code15.Size = new System.Drawing.Size(151, 25);
            this.Code15.TabIndex = 14;
            // 
            // Code25
            // 
            this.Code25.Location = new System.Drawing.Point(317, 127);
            this.Code25.Name = "Code25";
            this.Code25.Size = new System.Drawing.Size(151, 25);
            this.Code25.TabIndex = 24;
            // 
            // Code03
            // 
            this.Code03.Location = new System.Drawing.Point(3, 65);
            this.Code03.Name = "Code03";
            this.Code03.Size = new System.Drawing.Size(151, 25);
            this.Code03.TabIndex = 2;
            // 
            // Code01
            // 
            this.Code01.Location = new System.Drawing.Point(3, 3);
            this.Code01.Name = "Code01";
            this.Code01.Size = new System.Drawing.Size(151, 25);
            this.Code01.TabIndex = 0;
            // 
            // Code02
            // 
            this.Code02.Location = new System.Drawing.Point(3, 34);
            this.Code02.Name = "Code02";
            this.Code02.Size = new System.Drawing.Size(151, 25);
            this.Code02.TabIndex = 1;
            // 
            // Code04
            // 
            this.Code04.Location = new System.Drawing.Point(3, 96);
            this.Code04.Name = "Code04";
            this.Code04.Size = new System.Drawing.Size(151, 25);
            this.Code04.TabIndex = 3;
            // 
            // Code05
            // 
            this.Code05.Location = new System.Drawing.Point(3, 127);
            this.Code05.Name = "Code05";
            this.Code05.Size = new System.Drawing.Size(151, 25);
            this.Code05.TabIndex = 4;
            // 
            // Code06
            // 
            this.Code06.Location = new System.Drawing.Point(3, 158);
            this.Code06.Name = "Code06";
            this.Code06.Size = new System.Drawing.Size(151, 25);
            this.Code06.TabIndex = 5;
            // 
            // Code07
            // 
            this.Code07.Location = new System.Drawing.Point(3, 189);
            this.Code07.Name = "Code07";
            this.Code07.Size = new System.Drawing.Size(151, 25);
            this.Code07.TabIndex = 6;
            // 
            // Code08
            // 
            this.Code08.Location = new System.Drawing.Point(3, 220);
            this.Code08.Name = "Code08";
            this.Code08.Size = new System.Drawing.Size(151, 25);
            this.Code08.TabIndex = 7;
            // 
            // Code09
            // 
            this.Code09.Location = new System.Drawing.Point(3, 251);
            this.Code09.Name = "Code09";
            this.Code09.Size = new System.Drawing.Size(151, 25);
            this.Code09.TabIndex = 8;
            // 
            // Code10
            // 
            this.Code10.Location = new System.Drawing.Point(3, 282);
            this.Code10.Name = "Code10";
            this.Code10.Size = new System.Drawing.Size(151, 25);
            this.Code10.TabIndex = 9;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(39, 609);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(532, 50);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "印刷";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(39, 676);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(532, 50);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "入力内容クリア";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PrinterList
            // 
            this.PrinterList.FormattingEnabled = true;
            this.PrinterList.Location = new System.Drawing.Point(29, 24);
            this.PrinterList.Name = "PrinterList";
            this.PrinterList.Size = new System.Drawing.Size(465, 26);
            this.PrinterList.TabIndex = 4;
            // 
            // PrinterBox
            // 
            this.PrinterBox.Controls.Add(this.PrinterList);
            this.PrinterBox.Location = new System.Drawing.Point(39, 524);
            this.PrinterBox.Name = "PrinterBox";
            this.PrinterBox.Size = new System.Drawing.Size(532, 65);
            this.PrinterBox.TabIndex = 5;
            this.PrinterBox.TabStop = false;
            this.PrinterBox.Text = "出力先";
            // 
            // BarcodeFormatLabel
            // 
            this.BarcodeFormatLabel.AutoSize = true;
            this.BarcodeFormatLabel.Location = new System.Drawing.Point(26, 417);
            this.BarcodeFormatLabel.Name = "BarcodeFormatLabel";
            this.BarcodeFormatLabel.Size = new System.Drawing.Size(114, 18);
            this.BarcodeFormatLabel.TabIndex = 5;
            this.BarcodeFormatLabel.Text = "バーコード形式";
            // 
            // BarcodeFormatList
            // 
            this.BarcodeFormatList.FormattingEnabled = true;
            this.BarcodeFormatList.Location = new System.Drawing.Point(164, 414);
            this.BarcodeFormatList.Name = "BarcodeFormatList";
            this.BarcodeFormatList.Size = new System.Drawing.Size(329, 26);
            this.BarcodeFormatList.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 752);
            this.Controls.Add(this.PrinterBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CodeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Barcode Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CodeBox.ResumeLayout(false);
            this.CodeBox.PerformLayout();
            this.CodeInputTable.ResumeLayout(false);
            this.CodeInputTable.PerformLayout();
            this.PrinterBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CodeBox;
        private System.Windows.Forms.MaskedTextBox Code01;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TableLayoutPanel CodeInputTable;
        private System.Windows.Forms.MaskedTextBox Code16;
        private System.Windows.Forms.MaskedTextBox Code26;
        private System.Windows.Forms.MaskedTextBox Code17;
        private System.Windows.Forms.MaskedTextBox Code27;
        private System.Windows.Forms.MaskedTextBox Code18;
        private System.Windows.Forms.MaskedTextBox Code28;
        private System.Windows.Forms.MaskedTextBox Code19;
        private System.Windows.Forms.MaskedTextBox Code29;
        private System.Windows.Forms.MaskedTextBox Code20;
        private System.Windows.Forms.MaskedTextBox Code30;
        private System.Windows.Forms.MaskedTextBox Code11;
        private System.Windows.Forms.MaskedTextBox Code21;
        private System.Windows.Forms.MaskedTextBox Code12;
        private System.Windows.Forms.MaskedTextBox Code22;
        private System.Windows.Forms.MaskedTextBox Code13;
        private System.Windows.Forms.MaskedTextBox Code23;
        private System.Windows.Forms.MaskedTextBox Code14;
        private System.Windows.Forms.MaskedTextBox Code24;
        private System.Windows.Forms.MaskedTextBox Code15;
        private System.Windows.Forms.MaskedTextBox Code25;
        private System.Windows.Forms.MaskedTextBox Code03;
        private System.Windows.Forms.MaskedTextBox Code02;
        private System.Windows.Forms.MaskedTextBox Code04;
        private System.Windows.Forms.MaskedTextBox Code05;
        private System.Windows.Forms.MaskedTextBox Code06;
        private System.Windows.Forms.MaskedTextBox Code07;
        private System.Windows.Forms.MaskedTextBox Code08;
        private System.Windows.Forms.MaskedTextBox Code09;
        private System.Windows.Forms.MaskedTextBox Code10;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox PrinterList;
        private System.Windows.Forms.GroupBox PrinterBox;
        private System.Windows.Forms.ComboBox BarcodeFormatList;
        private System.Windows.Forms.Label BarcodeFormatLabel;
    }
}

