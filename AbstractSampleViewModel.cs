//  -*-  coding: utf-8-with-signature;  mode: c++  -*-  //
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
using System.Windows.Input;

using WpfControl.Common;


namespace WpfControl.Sample
{

//========================================================================
//
//    AbstractSampleViewModel  class.
//
//    このクラスは別リポジトリ WpfControlLibrary  にある
//    Common.SimpleCommand  を利用します
//

public abstract class  AbstractSampleViewModel
        : INotifyPropertyChanged, ISampleViewModel
{

//========================================================================
//
//    Constructor(s) and Destructor.
//

//========================================================================
//
//    Public Properties (Implement Interface).
//

    //----------------------------------------------------------------
    /**   「クリア」ボタン用のコマンドを取得するプロパティ。
    **
    **/
    public  abstract  ICommand
    ClearButtonCommand { get; }

    //----------------------------------------------------------------
    /**   「実行」ボタン用のコマンドを取得するプロパティ。
    **
    **/
    public  abstract  ICommand
    RunButtonCommand { get; }

    //----------------------------------------------------------------
    /**   「入力テキスト」プロパティ。
    **
    **/
    public  System.String
    InputText {
        get { return  this.m_inputText; }
        set { this.m_inputText = value; }
    }

    //----------------------------------------------------------------
    /**   「出力テキスト」プロパティ。
    **
    **/
    public  System.String
    OutputText {
        get { return  this.m_outputText; }
    }

//========================================================================
//
//    Member Variables.
//

    private System.String?  m_inputText;
    private System.String?  m_outputText;

}   //  End class AbstractSampleViewModel

}   //  End of namespace  WpfControl.Sample
