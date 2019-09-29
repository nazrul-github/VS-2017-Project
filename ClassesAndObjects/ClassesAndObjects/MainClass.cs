using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MainClass
    {
        static void Main(string[] args)
        {
        ClassesAndObjects.Sports cricket = new ClassesAndObjects.Sports();
        cricket.SetSportName("Cricket");

        Console.WriteLine(cricket.GetSportName());

        ClassesAndObjects.Sports footBall = new ClassesAndObjects.Sports();
        footBall.SetSportName("Football");

        ClassesAndObjects.Sports hockey = new ClassesAndObjects.Sports();
        hockey.SetSportName("Hockey");

        Console.WriteLine($"{footBall.GetSportName()} {cricket.GetSportName()} {hockey.GetSportName()}");

    }

}

