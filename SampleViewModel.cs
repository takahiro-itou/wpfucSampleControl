//  -*-  coding: utf-8-with-signature-unix     -*-  //
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

using   System.ComponentModel;
using   System.Runtime.CompilerServices;
using   System.Windows.Input;

using   WpfHelper.Commands;
using   WpfHelper.ViewModels;


namespace  WpfControl.Sample  {

//========================================================================
//
//    SampleViewModel  class.
//
//    このクラスは別リポジトリ  WpfHelper にある
//    抽象クラス ViewModels.ViewModelBase を利用します
//

public  class  SampleViewModel
        : ViewModelBase, ISampleViewModel
{

//========================================================================
//
//    Constructor(s) and Destructor.
//

//----------------------------------------------------------------
/**   コンストラクタ。
**
**/

public
SampleViewModel(
        ISampleModel    model)
{
    this.m_sampleModel  = model;
    this.m_sampleModel.InputChanged  += OnInputChanged;
    this.m_sampleModel.OutputChanged += OnOutputChanged;

    this.RunButtonCommand = new SimpleCommand<int>(
            parameter => ExecuteRunButtonCommand(),
            parameter => this.m_sampleModel.canExecute()
    );
    this.ClearButtonCommand = new SimpleCommand<int>(
            parameter => ExecuteClearButtonCommand()
    );
}


//========================================================================
//
//    Public Properties (Implement Interface).
//

//----------------------------------------------------------------
/**   「クリア」ボタン用のコマンドを取得するプロパティ。
**
**/

public  virtual  ICommand  ClearButtonCommand { get; }

//----------------------------------------------------------------
/**   「実行」ボタン用のコマンドを取得するプロパティ。
**
**/

public  virtual  ICommand  RunButtonCommand { get; }


//----------------------------------------------------------------
/**   「入力テキスト」プロパティ。
**
**/

public  System.String
InputText {
    get { return  this.m_sampleModel.InputText; }
    set { this.m_sampleModel.setInputText(value); }
}

//----------------------------------------------------------------
/**   「出力テキスト」プロパティ。
**
**/

public  System.String
OutputText => this.m_sampleModel.OutputText;


//========================================================================
//
//    Protected Member Functions (Pure Virtual Functions).
//

//========================================================================
//
//    Protected Member Functions.
//

protected  virtual  void
ExecuteClearButtonCommand()
{
    this.m_sampleModel.clearTexts();
}

protected  virtual  void
ExecuteRunButtonCommand()
{
    this.m_sampleModel.executeCommand();
}

protected  virtual  void
OnInputChanged()
{
    RaisePropertyChanged(nameof(InputText));
}

protected  virtual  void
OnOutputChanged()
{
    RaisePropertyChanged(nameof(OutputText));
}

//----------------------------------------------------------------
/**
**
**/
protected  override  void
CheckCommandsCanExecute()
{
    base.RaiseCanExecuteChanged(this.RunButtonCommand);
}


//========================================================================
//
//    Member Variables.
//

private  readonly   ISampleModel        m_sampleModel;


}   //  End of class  SampleViewModel

}   //  End of namespace  WpfControl.Sample
