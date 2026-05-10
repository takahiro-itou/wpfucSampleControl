
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
