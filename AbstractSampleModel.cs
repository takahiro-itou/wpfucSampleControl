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

public class  AbstractSampleModel
        : ISampleModel
{

    //----------------------------------------------------------------
    /**   クリア動作を実行する。
    **
    **/
    public  void
    clearTexts()
    {
        this.InputText  = "";
        this.OutputText = "";
    }

    //----------------------------------------------------------------
    /**   適当な動作を実行する。
    **
    **/
    public  void
    executeCommand()
    {
    }

}   //  End class AbstractSampleModel

}   //  End of namespace  WpfControl.Sample
