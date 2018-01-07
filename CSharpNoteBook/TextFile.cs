using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSharpNoteBook
{
    class TextFile:Message
    {
         public override void Add()
        {
            Console.WriteLine("请输入要创建文件夹的名字：");
            TextFileName = Console.ReadLine();
            if (TextFileName.Length != 0)
            {
                if (Directory.Exists(@"D:\C#\新建文件夹\" + TextFileName) == false)
                {
                    Directory.CreateDirectory(@"D:\C#\新建文件夹\" + TextFileName); //如果文件夹不存在，直接创建文件夹。
                    Console.WriteLine("成功");
                }
                else
                    if (Directory.Exists(@"D:\C#\新建文件夹\" + TextFileName))
                    {
                        Console.WriteLine("{0}：文件夹已有！！", @"D:\C#\新建文件夹\" + TextFileName);
                    }
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }
        public override void Delete()
        {
            Console.WriteLine("请输入要删除的文件夹名字：");
            TextFileName = Console.ReadLine();
            if (TextFileName.Length != 0)
            {
                if (Directory.Exists(@"D:\C#\新建文件夹\" + TextFileName)) //如果存在这个文件夹删除之 
                {
                    Directory.Delete(@"D:\C#\新建文件夹\" + TextFileName);
                    Console.WriteLine("成功！");
                }
                else
                    Console.WriteLine("{0}此文件夹不存在！", @"D:\C#\新建文件夹\" + TextFileName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }
        public override void Write()
        {
            throw new NotImplementedException();
        }
        public override void Read()
        {
            Console.WriteLine("已创建的文件夹如下：");
            foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            } }  }
    }

