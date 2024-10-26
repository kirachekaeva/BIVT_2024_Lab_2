using Microsoft.VisualBasic;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(6);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        int r = 2;
        if( Math.Abs(x*x + y*y - r*r) <= Math.Pow(10, -3))
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if(y >= 0 && (y + Math.Abs(x))<=1)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if(a > 0)
        {
            if(a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        else
        {
            if(a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min = 0;
        if (a > b)
        {
            min = b;
        }
        else
        {
            min = a;
        }
        if (c > min)
        {
            answer = c;
        }
        else
        {
            answer = min;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        // code here
        double d1 = Math.Sqrt(2 * s);
        double d2 = 2 * Math.Sqrt(r/Math.PI);
        if(d1 < d2)
        {
            answer = true;
        }
        
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d1 = Math.Sqrt(s);
        double d2 = 2 * Math.Sqrt(r / Math.PI);
        if (d1 >= d2)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        {
            answer = 0;
        }
        else if (-1 < x && x <= 0)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        {
            answer = 1;
        }
        else if(-1 < x && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double ves = 0;
        // code here
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out ves);
            if(ves <= 0)
            {
                n++;
                continue;
            }
            answer += ves;
        }
        answer = answer / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if(Math.Sqrt((x - a)*(x - a) + (y-b)*(y-b))<=r)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double ves);
            if (ves < 30)
            {
                answer += 0.2;
            }
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if(Math.Sqrt(x*x + y*y)<r2 && Math.Sqrt(x * x + y * y) > r1)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for(int i = 0; i <  n; i++)
        {
            double.TryParse(Console.ReadLine(), out double res);
            if(res <= norm)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if(0 <= x && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
            {
                answer += 1; 
            }
            Console.WriteLine(answer);

        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (y >= 0 && x >= 0)
            {
                answer1 += 1;
            }
            if(y <= 0 && x <= 0)
            {
                answer3 += 1;
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 1;
        double answerLength = double.MaxValue;

        // code here
        double.TryParse(Console.ReadLine(), out double x);
        double.TryParse(Console.ReadLine(), out double y);
        double minr = Math.Sqrt(x * x + y * y);
        for(int i = 1; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(Math.Sqrt(x*x + y*y) < minr)
            {
                minr = Math.Sqrt(x * x + y * y);
                answer = i + 1;
            }
        }
        answerLength = Math.Round(minr, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double.TryParse(Console.ReadLine(), out double res);
        double best = res;
        for(int i = 1; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if(res < best)
            {
                best = res;
            }
        }
        answer = best;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for(int i = 0; i <  n; i ++)
        {
            double.TryParse(Console.ReadLine(), out double mark1);
            double.TryParse(Console.ReadLine(), out double mark2);
            double.TryParse(Console.ReadLine(), out double mark3);
            double.TryParse(Console.ReadLine(), out double mark4);
            if(mark1 > 3 && mark2 > 3 && mark3 > 3 && mark4 > 3)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double mark1);
            double.TryParse(Console.ReadLine(), out double mark2);
            double.TryParse(Console.ReadLine(), out double mark3);
            double.TryParse(Console.ReadLine(), out double mark4);
            if(mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                answer += 1;
            }
            avg += (mark1 + mark2 + mark3 + mark4) / 4;
        }
        avg = Math.Round( avg / n, 9);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if(r < 0)
        {
            answer = 0;
        }
        else
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;
            }
            answer = Math.Round(answer, 2);
        }
       
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A < 0 || B < 0 || A > (B+B))
        {
            answer = 0;
        }
        else
        {
            switch(type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    break;
                case 2:
                    answer = A * Math.Sqrt(4 * B * B - A * A) / 4;
                    break;
                default:
                    answer = 0;
                    break;

            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        while(double.TryParse(Console.ReadLine(), out double w))
        {
            answer += w;
            n++;
        }
        answer = answer / n;
        Console.WriteLine(answer);
        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        while (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
        {
            if (Math.Sqrt(x * x + y * y) < r2 && Math.Sqrt(x * x + y * y) > r1)
            {
                answer += 1;
                n++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        while (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
        {
            if (y >= 0 && x >= 0)
            {
                answer1 += 1;
            }
            if (y <= 0 && x <= 0)
            {
                answer3 += 1;
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end
        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        while(double.TryParse(Console.ReadLine(), out double mark1) && double.TryParse(Console.ReadLine(), out double mark2) && double.TryParse(Console.ReadLine(), out double mark3) && double.TryParse(Console.ReadLine(), out double mark4))
        {
            if (mark1 > 3 && mark2 > 3 && mark3 > 3 && mark4 > 3)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}
