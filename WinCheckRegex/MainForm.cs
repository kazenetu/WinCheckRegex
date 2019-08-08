using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinCheckRegex
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // 結果をクリア
      ResultText.Text = "";

      // 入力情報取得
      var src = SrcText.Text;
      var reg = RegexText.Text;
      var replace = ReplaceText.Text;
      var result = "";

      // 対象文字列から正規表現で該当するか確認
      var matches = Regex.Matches(src, reg);
      if (matches.Count < 1 || matches[0].Groups.Count <= 1)
      {
        return;
      }

      // 正規表現で取得できた要素の置き換え
      foreach (Match match in matches)
      {
        var matcheGroup = match.Groups;
        var replaceSentence = replace;
        for (var i = 1; i < matcheGroup.Count; i++)
        {
          replaceSentence = replaceSentence.Replace($"${ i}", matcheGroup[i].Value);
          src = src.Replace(matcheGroup[i].Value, replaceSentence);
        }
        result += replaceSentence + Environment.NewLine;
      }

      // 置き換え結果を表示
      ResultText.Text = $"置き換え後の対象文字:{Environment.NewLine}{result}{Environment.NewLine}置換後:{Environment.NewLine}{src}";
    }
  }
}
