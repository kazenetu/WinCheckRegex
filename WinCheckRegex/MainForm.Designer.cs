namespace WinCheckRegex
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.ResultText = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ReplaceText = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.RegexText = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SrcText = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.ResultText, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.ReplaceText, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.RegexText, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.SrcText, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 633);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // ResultText
      // 
      this.ResultText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ResultText.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
      this.ResultText.Location = new System.Drawing.Point(103, 336);
      this.ResultText.Multiline = true;
      this.ResultText.Name = "ResultText";
      this.ResultText.Size = new System.Drawing.Size(669, 294);
      this.ResultText.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
      this.label4.Location = new System.Drawing.Point(3, 333);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(94, 300);
      this.label4.TabIndex = 6;
      this.label4.Text = "結果";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ReplaceText
      // 
      this.ReplaceText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ReplaceText.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
      this.ReplaceText.Location = new System.Drawing.Point(103, 201);
      this.ReplaceText.Multiline = true;
      this.ReplaceText.Name = "ReplaceText";
      this.ReplaceText.Size = new System.Drawing.Size(669, 79);
      this.ReplaceText.TabIndex = 5;
      this.ReplaceText.Text = "$1！";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
      this.label3.Location = new System.Drawing.Point(3, 198);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(94, 85);
      this.label3.TabIndex = 4;
      this.label3.Text = "置換文字列";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // RegexText
      // 
      this.RegexText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RegexText.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
      this.RegexText.Location = new System.Drawing.Point(103, 102);
      this.RegexText.Multiline = true;
      this.RegexText.Name = "RegexText";
      this.RegexText.Size = new System.Drawing.Size(669, 93);
      this.RegexText.TabIndex = 3;
      this.RegexText.Text = "<summary>(.+?)</summary>";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
      this.label2.Location = new System.Drawing.Point(3, 99);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 99);
      this.label2.TabIndex = 2;
      this.label2.Text = "正規表現";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 99);
      this.label1.TabIndex = 0;
      this.label1.Text = "対象文字列";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // SrcText
      // 
      this.SrcText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SrcText.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
      this.SrcText.Location = new System.Drawing.Point(103, 3);
      this.SrcText.Multiline = true;
      this.SrcText.Name = "SrcText";
      this.SrcText.Size = new System.Drawing.Size(669, 93);
      this.SrcText.TabIndex = 1;
      this.SrcText.Text = "/// <summary>クラスコメント</summary>\r\n/// <typeparam name=\"\"T\"\">A</typeparam>\r\n/// <typ" +
    "eparam name=\"\"U\"\">B</typeparam>\r\n/// <typeparam name=\"\"I\"\">C</typeparam>";
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
      this.button1.Location = new System.Drawing.Point(103, 286);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(669, 44);
      this.button1.TabIndex = 8;
      this.button1.Text = "変換";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 658);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "正規表現確認フォーム";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox ResultText;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox ReplaceText;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox RegexText;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox SrcText;
    private System.Windows.Forms.Button button1;
  }
}

