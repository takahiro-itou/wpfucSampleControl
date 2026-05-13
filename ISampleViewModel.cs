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

using System.Windows.Input;

namespace WpfControl.Sample
{

//========================================================================
//
//    ISampleViewModel  interface.
//

public  interface  ISampleViewModel
{

    //----------------------------------------------------------------
    /**   「クリア」ボタン用のコマンドを取得するプロパティ。
    **
    **/
    public  ICommand
    ClearButtonCommand { get; }

    //----------------------------------------------------------------
    /**   「実行」ボタン用のコマンドを取得するプロパティ。
    **
    **/
    public  ICommand
    RunButtonCommand { get; }

    //----------------------------------------------------------------
    /**   「入力テキスト」プロパティ。
    **
    **/
    public  System.String
    InputText { get; set; }

    //----------------------------------------------------------------
    /**   「出力テキスト」プロパティ。
    **
    **/
    public  System.String
    OutputText { get; set; }

}   //  End interface ISampleViewModel

}   //  End of namespace  WpfControl.Sample
