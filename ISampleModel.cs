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
//    ISampleModel  interface.
//

public  interface  ISampleModel
{

    //----------------------------------------------------------------
    /**   コマンドを実行可能か判定する。
    **
    **/
    public  bool
    canExecute();

    //----------------------------------------------------------------
    /**   クリア動作を実行する。
    **
    **/
    public  void
    clearTexts();

    //----------------------------------------------------------------
    /**   適当な動作を実行する。
    **
    **/
    public  void
    executeCommand();


//========================================================================
//
//    Properties.
//

    public  System.String   InputText  { get; }
    public  System.String   OutputText { get; }

    public  event  Action?  InputChanged;
    public  event  Action?  OutputChanged;


//========================================================================
//
//    Accessors.
//

    public  void
    setInputText(System.String  value);

    public  void
    setOutputText(System.String  value);

}   //  End interface ISampleModel

}   //  End of namespace  WpfControl.Sample
