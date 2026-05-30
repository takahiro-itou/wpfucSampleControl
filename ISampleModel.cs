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
//    ISampleViewModel  interface.
//

public  interface  ISampleViewModel
{

    public  System.String   InputText  { get; set }
    public  System.String   OutputText { get; private set; }

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

}   //  End interface ISampleModel

}   //  End of namespace  WpfControl.Sample
