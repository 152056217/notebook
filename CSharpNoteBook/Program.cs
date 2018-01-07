using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace CSharpNoteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //string URL = @"D:\C#\新建文件夹\";
            Text text=new Text();
            TextFile textfile=new TextFile();
            bool a = true;
            bool b=true;
            while (a)
            {
                try
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("*                                           *");
                    Console.WriteLine("*        1:新建/删除笔记  2:打开笔记        *");
                    Console.WriteLine("*        3:输入/保存笔记  4:新建文件夹      *");
                    Console.WriteLine("*        5:管理文件夹     6:退出            *");
                    Console.WriteLine("*                                           *");
                    Console.WriteLine("*********************************************");
                    Console.Write("请输入菜单选项（1-6）");
                    int choice = Int32.Parse(Console.ReadLine());                    
                    switch (choice)
                    {
                        case 1:
                          b = true;
                            while (b)
                            {
                                Console.Clear();
                                Console.WriteLine("************************************************************");
                                Console.WriteLine("*                     新建笔记菜单                         *");
                                Console.WriteLine("*        1:新建笔记                    2:删除笔记          *");
                                Console.WriteLine("*        3:退出本菜单                                      *");
                                Console.WriteLine("************************************************************");
                                Console.Write("请输入菜单选项(1-3):");
                                choice = Int32.Parse(Console.ReadLine());
                                    switch (choice)
                                    {
                                case 1:
                                    text.Add();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    text.Delete();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    b = false;
                                    break;
                                default:
                                    Console.WriteLine("请输入1-3！");
                                    Console.ReadLine();
                                    break;
                                   }
                          }
                                    break;
                        case 2:
                                 b = true;
                            while (b)
                            {
                                Console.Clear();
                                Console.WriteLine("************************************************************");
                                Console.WriteLine("*                     打开笔记菜单                         *");
                                Console.WriteLine("*        1:打开笔记                    2:退出本菜单        *");
                                Console.WriteLine("************************************************************");
                                Console.Write("请输入菜单选项(1-2)");
                                choice = int.Parse(Console.ReadLine());
                                switch (choice)
                                {
                                    case 1:
                                        text.Read();
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        b = false; 
                                        break;
                                    default:
                                        Console.WriteLine("输入错误！！请输入数字(1-2)！按任意键继续。");
                                        Console.ReadKey();
                                        break;
                                }
                            }

                            break;
                        case 3:
                              b = true;
                            while (b)
                            {
                                Console.Clear();
                                Console.WriteLine("************************************************************");
                                Console.WriteLine("*                   输入/保存笔记笔记菜单                  *");
                                Console.WriteLine("*        1:输入/保存笔记             2:退出本菜单          *");
                                Console.WriteLine("*                                                          *");
                                Console.WriteLine("************************************************************");
                                Console.Write("请输入菜单选项(1-2):");
                                choice = int.Parse(Console.ReadLine());
                                switch (choice)
                                {
                                    case 1:
                                        text.Write();
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        b = false;
                                        break;
                                    default:
                                        Console.WriteLine("输入错误！！请输入数字(1-2)！按任意键继续。");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            break;
                        case 4:
                             b = true;
                            while (b)
                            {
                                Console.Clear();
                                Console.WriteLine("************************************************************");
                                Console.WriteLine("*                     新建文件夹菜单                       *");
                                Console.WriteLine("*        1:新建文件夹                    2:退出本菜单      *");
                                Console.WriteLine("************************************************************");
                                Console.Write("请输入菜单选项(1-2):");
                                choice= int.Parse(Console.ReadLine());
                                switch (choice)
                                {
                                    case 1:
                                        textfile.Add();
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        b = false; 
                                        break;
                                    default:
                                        Console.WriteLine("输入错误！！请输入数字(1-2)！按任意键继续。");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            break;
                        case 5:
                             b = true;
                            while (b)
                            {
                                Console.Clear();
                                Console.WriteLine("************************************************************");
                                Console.WriteLine("*                     管理文件夹菜单                       *");
                                Console.WriteLine("*        1:删除文件夹                    2:查看文件夹      *");
                                Console.WriteLine("*        3:退出本菜单                                      *");
                                Console.WriteLine("************************************************************");
                                Console.Write("请输入菜单选项(1-3):");
                                choice = int.Parse(Console.ReadLine());
                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("有以下文件夹：");
                                        foreach (string d in Directory.GetFileSystemEntries(@"D:\C#\新建文件夹\"))
                                        {
                                            Console.WriteLine(" "+d);
                                        }
                                        textfile.Delete();
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        textfile.Read();
                                        Console.ReadKey();
                                        break;
                                    case 3: b = false; break;
                                    default:
                                        Console.WriteLine("输入错误！！请输入数字(1-2)！按任意键继续。");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            break;
                        case 6:
                            a = false;
                            break;
                        default:
                            Console.Write("请输入1-6");
                            Console.ReadKey();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入错误！！！！！");
                }
            }
        }
    }
        }
 