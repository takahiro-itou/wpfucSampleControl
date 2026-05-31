//  -*-  coding: utf-8-with-signature-unix;        -*-  //
/*************************************************************************
**                                                                      **
**                  ---  WPF UserControl Library.  ---                  **
**                                                                      **
**          Copyright (C), 2026-2026, Takahiro Itou                     **
**          All Rights Reserved.                                        **
**                                                                      **
**          License: (See COPYING or LICENSE files)                     **
**          GNU Affero General Public License (AGPL) version 3,         **
**          or (at your option) any later version.                      **
**                                                                      **
*************************************************************************/


namespace WpfControl.Sample
{

//========================================================================
//
//    AbstractSampleViewModel  class.
//
//    このクラスは別リポジトリ WpfControlLibrary  にある
//    Common.SimpleCommand  を利用します
//

public abstract class  AbstractSampleModel
        : ISampleModel
{

    //----------------------------------------------------------------
    /**   コンストラクタ。
    **
    **/
    public  AbstractSampleModel()
    {
        this.InputText  = "";
        this.OutputText = "";
    }

    //----------------------------------------------------------------
    /**   コマンドを実行可能か判定する。
    **
    **/
    public  virtual  bool
    canExecute()
    {
        return ( this.InputText != "" );
    }

    //----------------------------------------------------------------
    /**   クリア動作を実行する。
    **
    **/
    public  virtual  void
    clearTexts()
    {
        this.InputText  = "";
        this.OutputText = "";
        notifyInputChanged();
        notifyOutputChanged();
    }

    //----------------------------------------------------------------
    /**   適当な動作を実行する。
    **
    **/
    public  abstract  void
    executeCommand();


//========================================================================
//
//    Properties.
//

    public  System.String   InputText  { get; private set; }
    public  System.String   OutputText { get; private set; }

    public  event  Action?  InputChanged;
    public  event  Action?  OutputChanged;


//========================================================================
//
//    Accessors.
//

    public  void
    setInputText(System.String  value)
    {
        this.InputText  = value;
        notifyInputChanged();
    }

    public  void
    setOutputText(System.String  value)
    {
        this.OutputText = value;
        notifyOutputChanged();
    }


//========================================================================
//
//    Protected Member Functions.
//

    protected  void
    notifyInputChanged() => InputChanged?.Invoke();

    protected  void
    notifyOutputChanged() => OutputChanged?.Invoke();

}   //  End class AbstractSampleModel

}   //  End of namespace  WpfControl.Sample
