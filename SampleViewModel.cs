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

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using WpfControl.Common;


namespace WpfControl.Sample
{

//========================================================================
//
//    SampleViewModel  class.
//
//    このクラスは別リポジトリ WpfControlLibrary  にある
//    Common.SimpleCommand  を利用します
//

public class  SampleViewModel
        : INotifyPropertyChanged, ISampleViewModel
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
        this.m_sampleModel.InputChanged  += OnInputChanged();
        this.m_sampleModel.OutputChanged += OnOutputChanged();

        this.m_runButtonCommand = new SimpleCommand(
                parameter => executeRunButtonCommand(),
                parameter => this.m_sampleModel.canExecute()
        );
        this.m_clearButtonCommand = new SimpleCommand(
                parameter => executeClearButtonCommand()
        );

        this.m_inputText  = "";
        this.m_outputText = "";
    }

//========================================================================
//
//    Public Properties (Implement Interface).
//

    //----------------------------------------------------------------
    /**   「クリア」ボタン用のコマンドを取得するプロパティ。
    **
    **/
    public  virtual  ICommand
    ClearButtonCommand {
        get { return  this.m_clearButtonCommand; }
    }

    //----------------------------------------------------------------
    /**   「実行」ボタン用のコマンドを取得するプロパティ。
    **
    **/
    public  virtual ICommand
    RunButtonCommand {
        get { return  this.m_runButtonCommand; }
    }

    //----------------------------------------------------------------
    /**   「入力テキスト」プロパティ。
    **
    **/
    public  System.String
    InputText {
        get { return  this.m_sampleModel.InputText; }
        set { this.m_sampleModel.setInputText(value); }
    }

/*
    public  System.String
    InputText {
        get { return  this.m_inputText; }
        set {
            this.m_inputText = value;
            raiseCanExecuteChanged();
            raisePropertyChanged(nameof(InputText));
        }
    }
*/

    //----------------------------------------------------------------
    /**   「出力テキスト」プロパティ。
    **
    **/
    public  System.String
    OutputText => this.m_sampleModel.OutputText;
/*
    public  System.String
    OutputText {
        get { return  this.m_outputText; }
        protected set {
            this.m_outputText = value;
            raisePropertyChanged(nameof(OutputText));
        }
    }
*/

    public  event PropertyChangedEventHandler?  PropertyChanged;


//========================================================================
//
//    Protected Member Functions (Pure Virtual Functions).
//

//========================================================================
//
//    Protected Member Functions.
//

    protected  void
    executeClearButtonCommand()
    {
        this.m_sampleModel.clearTexts();
    }

    protected  void
    executeRunButtonCommand()
    {
        this.m_sampleModel.executeCommand();
    }

    protected  void
    OnInputChanged()
    {
        raisePropertyChanged(nameof(InputText));
    }

    protected  void
    OnOutputChanged()
    {
        raisePropertyChanged(nameof(OutputText));
    }

    //----------------------------------------------------------------
    /**
    **
    **/
    protected  void
    raiseCanExecuteChanged()
    {
        this.m_runButtonCommand.RaiseCanExecuteChanged();
    }

    //----------------------------------------------------------------
    /**
    **
    **/
    protected void  raisePropertyChanged(
            [CallerMemberName]  System.String?  propertyName = null)
    {
        PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(propertyName));
    }


//========================================================================
//
//    Member Variables.
//

    private readonly  ISampleModel  m_sampleModel;

    private System.String   m_inputText;
    private System.String   m_outputText;

    private readonly SimpleCommand  m_clearButtonCommand;
    private readonly SimpleCommand  m_runButtonCommand;

}   //  End class SampleViewModel

}   //  End of namespace  WpfControl.Sample
