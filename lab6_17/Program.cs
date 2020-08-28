﻿using ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lab6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            #region unimportant info
            //string m1 = "hello there";
            //int i1 = 4;
            //Point task = new Point("first p" ,() => WriteMes(m1, i1));
            //PointExecutionResult returnHere = new PointExecutionResult();
            //Point p2 = new Point("name", Line, returnHere);
            //Point task2 = new Point("sec p", () => WriteMes(m1, i1));
            ////task.ExecuteMethod();
            //m1 = "hello world";
            //i1 = 12;
            ////task.ExecuteMethod();
            //PointExecutionResult per = new PointExecutionResult();
            //Point pp = new Point("sus", () => Line("sus"), per);
            //pp.ExecuteMethod();
            ////Console.WriteLine(per.result.ToString());
            #endregion


            Point point = new Point("jov", Hello);
            Point point1 = new Point("bem", HowAreYou);
            Point point2 = new Point("nes", ImFine);
            PointExecutionResult returnTo = new PointExecutionResult();
            Point point3 = new Point("bip", Line, returnTo);
            CMenu cm = new CMenu();
            cm.AddPoint(new List<Point> { point, point1, point2, point3 });
            cm.RunMenuButtons();
        }
        static void WriteMes(string message, int t) => Console.WriteLine(message + " " + t);
        static string Line() => "Line";
        static string Line(string line) => line + ".";
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
        static void ImFine()
        {
            Console.WriteLine("I am fine");
        }
    }
}
