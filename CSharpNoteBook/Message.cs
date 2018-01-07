using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpNoteBook
{
    abstract class Message
    {
            //文件名
            private string _TextName;
            protected string TextName
            {
                get { return _TextName; }
                set { _TextName = value; }
            }
            //文件夹名
            private string _TextFileName;
            protected string TextFileName
            {
                get { return _TextFileName; }
                set { _TextFileName = value; }
            }
            public abstract void Add(); //添加
            public abstract void Delete();//删除
            public abstract void Write();//输入
            public abstract void Read();//输出
        }
    
}
