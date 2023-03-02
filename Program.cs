class program {
    static void Main(string[] args) {
        Console.Write("input your password : ");
        int password = int.Parse(Console.ReadLine());
        

        if(password >= 100000 && password <= 999999){   
            Console.Write("input your agency :");
        string agency = (Console.ReadLine());
            int a = password/100000;
            password = password - a * 100000;
            int b = password/10000;
            password = password - b * 10000;
            int c = password/1000;
            password = password - c * 1000;
            int d = password/100;
            password = password - d * 100;
            int e = password/10;
            password = password - e * 10;
            int f = password/1;
            password = password - f * 1;

            if ((agency == "CIA") && (f % 3 == 0) && 
            (e != 1 && e != 3 && e != 5) && 
            (c >=6 && c != 8)) {
                Console.WriteLine("True");
            }
            else if ((agency == "FBI") &&
             (a >= 4 && a <= 7) && 
             (d % 2 == 0 && d != 6) && 
             (b == 1 || b == 3 || b == 5 || b == 7 || b == 9)) {
              Console.WriteLine("True");
             }
            else if ((agency == "NSA") &&
             (f == 1 || f == 2 || f == 3 || f == 5 || f == 6) &&
             (d %3 == 0 && d %2 != 0) && 
             (a == 7 || b == 7 || c == 7 || d == 7 || e == 7 || f == 7)){
                Console.WriteLine("True");
             }
        else {Console.WriteLine("False");
         }

            }
        else {Console.WriteLine("False");
        }

         }
    }
