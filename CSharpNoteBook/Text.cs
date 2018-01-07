using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSharpNoteBook
{
    class Text:Message
    {
        public override void Add()
        {
            Console.WriteLine("请选择要把新建笔记放入以下哪个文件夹中：");
            foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextFileName = Console.ReadLine();
            if (TextFileName.Length != 0)
            {
                if (Directory.Exists(@"D:\C#\新建文件夹\" + TextFileName))
                {
                    Console.WriteLine("请输入要创建文件的名字：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (!File.Exists(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt"))
                        {
                            FileStream fs1 = File.Create(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt");
                            Console.WriteLine("成功,文件名叫：{0}", TextName + ".txt");
                            fs1.Close();
                        }
                        else
                            Console.WriteLine("失败,已存在文件名为：{0}的文件！", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextFileName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }

        public override void Delete()
        {
            Console.WriteLine("请选择要删除哪个文件夹下的笔记：");
            foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextFileName = Console.ReadLine();
            if (TextFileName.Length != 0)
            {
                if (Directory.Exists(@"D:\C#\新建文件夹\" + TextFileName))
                {
                    Console.WriteLine("有以下文件：");
                    foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\" + TextFileName + "\\"))
                    {
                        Console.WriteLine(" " + d);
                    }
                    Console.WriteLine("请输入要删除文件的名字：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (File.Exists(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt"))
                        {
                            File.Delete(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt");
                            Console.WriteLine("成功，删除的文件名叫：{0}", TextName + ".txt");
                        }
                        else
                            Console.WriteLine("失败,{0}的文件不存在！", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextFileName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }

        public override void Read()
        {
            Console.WriteLine("请选择要打开以下哪个文件夹中的笔记：");
            foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextFileName = Console.ReadLine();
            if (TextFileName.Length != 0)
            {
                if (Directory.Exists(@"D:\C#\新建文件夹\" + TextFileName))
                {
                    Console.WriteLine("有以下文件：");
                    foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\" + TextFileName + "\\"))
                    {
                        Console.WriteLine(" " + d);
                    }
                    Console.WriteLine("请输入要操作的文件名：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (File.Exists(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt"))
                        {
                            Console.WriteLine(System.IO.File.ReadAllText(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt", Encoding.Default));
                            Console.WriteLine("成功！");
                        }
                        else
                            Console.WriteLine("错误！{0}文件不存在", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextFileName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }

        public override void Write()
        {
            Console.WriteLine("请选择要在哪个文件夹下输入笔记：：");
            foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextFileName = Console.ReadLine();
            if (TextFileName.Length != 0)
            {
                if (Directory.Exists(@"D:\C#\新建文件夹\" + TextFileName))
                {
                    Console.WriteLine("有以下文件：");
                    foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\" + TextFileName + "\\"))
                    {
                        Console.WriteLine(" " + d);
                    }
                    string ss;
                    Console.WriteLine("请输入要操作的文件名：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (File.Exists(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt"))
                        {
                            Console.WriteLine("请输入需要输入的信息：");
                            ss = Console.ReadLine();
                            File.AppendAllText(@"D:\C#\新建文件夹\" + TextFileName + "\\" + TextName + ".txt", ss, Encoding.Default);//可在文本后面加字符串
                            Console.WriteLine("成功！");
                        }
                        else
                            Console.WriteLine("{0}文件不存在，请新建！", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextFileName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }
    }
    }

