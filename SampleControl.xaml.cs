
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


//========================================================================
//
//    外部に公開するプロパティ
//

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
    /**   OutputText  プロパティ
    **
    **/
    [Browsable(true)
      , Description("出力テキストボックスに表示する文字列")
      , Category("表示")
    ]
    public System.String OutputText
    {
        get { return  txtInput.Text; }
        set { txtInput.Text = value; }
    }


//========================================================================
//
//    外部に公開するイベント
//

    //----------------------------------------------------------------
    /**   RunButtonClick  イベント
    **
    **/
    [Browsable(true)
      , Description("実行ボタンがクリックされた時に発生します")
      , Category("アクション")
    ]
    public event EventHandler<EventArgs>? RunButtonClick;


//========================================================================
//
//    Protected Member Functions.
//

    //----------------------------------------------------------------
    /**   イベントハンドラを呼び出すメソッド。
    **
    **/
    protected virtual void OnRunButtonClick(EventArgs e)
    {
        var eventHandler = RunButtonClick;
        if ( eventHandler != null ) {
            eventHandler(this, me);
        }
    }


//========================================================================
//
//    For Internal Use Only.
//

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
