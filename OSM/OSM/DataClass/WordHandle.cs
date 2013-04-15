using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSM.DataClass
{
    class WordHandle
    {
        /// 
        /// word 应用对象 
        /// 
        private Word.Application _wordApplication;

        /// 
        /// word 文件对象 
        /// 
        private Word.Document _wordDocument;
        /// 
        /// 创建文档 
        ///
        public void CreateAWord()
        {
            //实例化word应用对象 
            this._wordApplication = new Word.ApplicationClass();
            Object myNothing = System.Reflection.Missing.Value;

            this._wordDocument = this._wordApplication.Documents.Add(ref myNothing, ref myNothing, ref myNothing, ref myNothing);
        }
        /// 
        /// 添加页眉 
        /// 
        /// 
        public void SetPageHeader(string pPageHeader)
        {
            //添加页眉 
            this._wordApplication.ActiveWindow.View.Type = Word.WdViewType.wdOutlineView;
            this._wordApplication.ActiveWindow.View.SeekView = Word.WdSeekView.wdSeekPrimaryHeader;
            this._wordApplication.ActiveWindow.ActivePane.Selection.InsertAfter(pPageHeader);
            //设置中间对齐 
            this._wordApplication.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //跳出页眉设置 
            this._wordApplication.ActiveWindow.View.SeekView = Word.WdSeekView.wdSeekMainDocument;
        }
        /// 
        /// 插入文字 
        /// 
        /// 文本信息 
        /// 字体打小 
        /// 字体颜色 
        /// 字体粗体 
        /// 方向 
        public void InsertText(string pText, int pFontSize, Word.WdColor pFontColor, int pFontBold, Word.WdParagraphAlignment ptextAlignment)
        {
            //设置字体样式以及方向 
            this._wordApplication.Application.Selection.Font.Size = pFontSize;
            this._wordApplication.Application.Selection.Font.Bold = pFontBold;
            this._wordApplication.Application.Selection.Font.Color = pFontColor;
            this._wordApplication.Application.Selection.ParagraphFormat.Alignment = ptextAlignment;
            this._wordApplication.Application.Selection.TypeText(pText);
        }


        /// 
        /// 换行 
        /// 
        public void NewLine()
        {

            this._wordApplication.Application.Selection.TypeParagraph();
        }
        /// 
        /// 插入一个图片 
        /// 
        /// 
        public void InsertPicture(string pPictureFileName)
        {
            object myNothing = System.Reflection.Missing.Value;
            //图片居中显示 
            this._wordApplication.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            this._wordApplication.Application.Selection.InlineShapes.AddPicture(pPictureFileName, ref myNothing, ref myNothing, ref myNothing);
        }
        /// 
        /// 保存文件 
        /// 
        /// 保存的文件名 
        public void SaveWord(string pFileName, string docname)
        {
            object myNothing = System.Reflection.Missing.Value;
            object myFileName = pFileName;
            object myWordFormatDocument = Word.WdSaveFormat.wdFormatDocument;
            object myLockd = false;
            object myPassword = "";
            object myAddto = false;
            try
            {
                this._wordDocument.SaveAs(ref myFileName, ref myWordFormatDocument, ref myLockd, ref myPassword, ref myAddto, ref myPassword,
                ref myLockd, ref myLockd, ref myLockd, ref myLockd, ref myNothing, ref myNothing, ref myNothing,
                ref myNothing, ref myNothing, ref myNothing);
            }
            catch
            {
                throw new Exception("导出" + docname + "word文档失败!");
            }
            //zw add
            this._wordDocument.Close(ref myNothing, ref myNothing, ref myNothing);
            this._wordApplication.Quit(ref myNothing, ref myNothing, ref myNothing);//存完立即清除，保持文档不锁定可重复加载生成
        }
        public void close()
        {
            this._wordApplication = null;
            this._wordDocument = null;
        }
    }
}
