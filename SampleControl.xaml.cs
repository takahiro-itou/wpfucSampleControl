
using System.ComponentModel;
using System.Windows.Controls;

namespace WpfControl.Sample
{

public partial class SampleControl : UserControl
{

    //----------------------------------------------------------------
    /**   デフォルトコンストラクタ
    **
    **/
    public  SampleControl()
    {
        InitializeComponent();
    }

    //----------------------------------------------------------------
    /**   InputText プロパティ
    **
    **/
    [Browsable(true)
      , Description("入力テキストボックスに入力された文字列")
      , Category("表示")
    ]
    public System.String InputText
    {
        get { return  txtInput.Text; }
        set { txtInput.Text = value; }
    }

    //----------------------------------------------------------------
    /**   イベントハンドラ
    **
    **    「クリア」ボタンのクリックイベント。
    **/
    private void btnClear_Click(object sender, EventArgs e)
    {
        txtInput.Text = "";
        txtOutput.Text = "";
    }

    //----------------------------------------------------------------
    /**   イベントハンドラ
    **
    **    「実行」ボタンのクリックイベント。
    **/
    private void btnRun_Click(object sender, EventArgs e)
    {
    }

}

}   //  End of namespace  WpfControl.Sample
