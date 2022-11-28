using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Setul2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la 1 la 17 pentru a alege una din probleme:");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: P1();
                        break;
                    case 2: P2();
                        break;
                    case 3: P3();
                        break;
                    case 4: P4();
                        break;
                    case 5: P5();
                        break;
                    case 6: P6();
                        break;
                    case 7: P7();
                        break;
                    case 8: P8();
                        break;
                    case 9: P9();
                        break;
                    case 10: P10();
                        break;
                    case 11: P11();
                        break;
                    case 12: P12();
                        break;
                    case 13: P13();
                        break;
                    case 14: P14();
                        break;
                    case 15: P15();
                        break;
                    case 16: P16();
                        break;
                    case 17: P17();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Citeste un vector de N elemente, pe urma ii returneaza elementele sub forma de numere intregi
        /// </summary>
        /// <returns></returns>
        static int[] InitArray()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere:");
            char[] sep = { ' ', ',', ':', ';' };
            string[] line = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int[] v = Array.ConvertAll(line, int.Parse);
            return v;
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        static void P1()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                int k = 0;
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (Math.Abs(x) % 2 == 0)
                        k++;
                }
                if (k == 1)
                    Console.WriteLine("In secventa data este un singur numar par");
                else if (k == 0)
                    Console.WriteLine("In secventa data nu este nici un numar par");
                else
                    Console.WriteLine($"In secventa data sunt {k} numere pare");
            }
        }
        /// <summary>
        /// Se da o secventa de n numere. 
        /// Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        static void P2()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista o secventa de {n} numere!");
            else
            {
                int cntPoz = 0;
                int cntNeg = 0;
                int cntZero = 0;
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (x < 0)
                        cntNeg++;
                    else if (x == 0)
                        cntZero++;
                    else cntPoz++;
                }
                Console.WriteLine($"In secventa data sunt {cntNeg} numere negative, {cntZero} numere zero si {cntPoz} numere pozitive");
            }
        }
        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>
        static void P3()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int p = 1;
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    s += i;
                    p *= i;
                }
                Console.WriteLine($"Suma numerelor pana la {n} este {s}, iar produsul acestor numere este {p}");
            }
        }
        /// <summary>
        /// Se da o secventa de n numere. 
        /// Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero.
        /// Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        static void P4()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti un numar intreg A pe care il veti cauta in secventa de {n} numere:");
                int a = Convert.ToInt32(Console.ReadLine());
                int k = 0;
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                Console.Write($"Numarul {a} din secventa se afla pe pozitia/pozitiile: ");
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (x == a)
                    {
                        Console.Write($"{i} ");
                        k++;
                    }
                }
                if (k == 0)
                    Console.WriteLine("-1");
            }
        }
        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        /// Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
        static void P5()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (x == i)
                        k++;
                }
                if (k == 0)
                    Console.WriteLine("In secventa data nici un element nu este egal cu pozitia pe care apar");
                else if (k == 1)
                    Console.WriteLine("In secventa data un singur element este egal cu pozitia pe care apare");
                else
                    Console.WriteLine($"In secventa data sunt {k} numere care sunt egale cu pozitia pe care apar");
            }
        }
        /// <summary>
        /// Se da o secventa de n numere. 
        /// Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        static void P6()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int k = 0;
                int maxi = -1000000000;
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    /*
                     * De fiecare data cand ni se schimba variabila care determina maximul din secventa,
                     * vom creste contorul cu 1. Daca contorul ajunge la valoarea lui n, inseamna ca toate
                     * numerele sunt in ordine crescatoare, altfel nu.
                     */
                    if (x > maxi)
                    {
                        maxi = x;
                        k++;
                    }
                }
                if (k == n)
                    Console.WriteLine("Numerele din secventa data sunt in ordine crescatoare");
                else
                    Console.WriteLine("Numerele din secventa data nu sunt in ordine crescatoare");
            }
        }
        /// <summary>
        /// Se da o secventa de n numere.
        /// Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        static void P7()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int mini = 1000000000;
                int maxi = -1000000000;
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (x > maxi)
                        maxi = x;
                    if (x < mini)
                        mini = x;
                }
                Console.WriteLine($"Cea mai mare valoare din secventa data este {maxi}, iar cea mai mica este {mini}");
            }
        }
        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci.
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
        /// <example>
        /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </example>
        /// </summary>
        static void P8()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista al {n}-lea termenul in sirul lui Fibonacci!");
            else
            {
                int a = 1;
                int b = 1;
                if (n == 1)
                    Console.WriteLine("Primul numar din sirul lui Fibonacci este 0");
                else
                {
                    int c = 0;
                    n -= 2;
                    while (n > 0)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                        n--;
                    }
                    c -= b - a;
                    Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este {c}");
                }
            }
        }
        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
        /// </summary>
        static void P9()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int cntCrescator = 0;
                int cntDescrescator = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    int maxi = -1000000000;
                    int mini = 1000000000;
                    if (x > maxi)
                    {
                        maxi = x;
                        cntCrescator++;
                    }
                    if (x < mini)
                    {
                        mini = x;
                        cntDescrescator++;
                    }
                }
                if (cntCrescator == n || cntDescrescator == 0)
                    Console.WriteLine("Secventa data este monotona");
                else
                    Console.WriteLine("Secventa data nu este monotona");
            }
        }
        /// <summary>
        /// Se da o secventa de n numere.
        /// Care este numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        static void P10()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int k = 0;
                int cntMax = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    int y = Convert.ToInt32(sep.Split()[i + 1]);
                    if (x == y)
                    {
                        k++;
                        if (k > cntMax)
                            cntMax = k;
                    }
                    if (x != y)
                        k = 0;
                }
                Console.WriteLine($"Numarul maxim de numere egale consecutive egale in secventa data este {cntMax + 1}");
            }
        }
        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        static void P11()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int s = 0;
                for (int i = 0; i < n; i++)
                {
                    int reverseNum = 0;
                    int x = Convert.ToInt32(sep.Split()[i]);
                    while (x != 0)
                    {
                        reverseNum = reverseNum * 10 + x % 10;
                        x /= 10;
                    }
                    s += reverseNum;
                }
                Console.WriteLine($"Suma inverselor numerelor din secventa data este {s}");
            }
        }
        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
        /// <example>
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
        /// </example> 
        /// </summary>
        static void P12()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int y = 0;
                int k = 1;
                for (int i = 1; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (x == 0 && y != 0)
                        k++;
                    if (x != 1 && x == y)
                        i++;
                    y = x;
                }
                if (k == 1)
                    Console.WriteLine($"Secventa nu contine grupuri de numere consecutive diferite de zero");
                else
                    Console.WriteLine($"Secventa contine {k} grupuri de numere consecutive diferite de zero");
            }
        }
        /// <summary>
        /// O secventa crescatoare rotita este o secventa de numere care este in ordine crescatoare
        /// sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga
        /// si primul element devine ultimul).
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        static void P13()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int y = 0;
                int maxi = -1000000000;
                int mini = 1000000000;
                bool ok1 = true;
                bool ok2 = true;
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (y > x && ok1 == true)
                    {
                        ok1 = false;
                        maxi = y;
                        mini = x;
                    }
                    else if (ok1 == false && (x > maxi || x < mini))
                         ok2 = false;
                    y = x;
                }
                if (ok2)
                    Console.WriteLine("Secventa data este secventa crescatoare rotita");
                else
                    Console.WriteLine("Secventa data nu este secventa crescatoare rotita");
            }
        }
        /// <summary>
        /// O secventa monotona rotita este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. 
        /// Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        static void P14()
        {
            Console.WriteLine("Introduceti un numar natural N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu:");
                string sep = Console.ReadLine();
                int y = 0;
                int maxi1 = -1000000000;
                int maxi2 = -1000000000;
                int mini1 = 1000000000;
                int mini2 = 1000000000;
                bool ok1 = true;
                bool ok2 = true;
                bool ok3 = true;
                bool ok4 = true;
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (y > x && ok1 == true)
                    {
                        ok1 = false;
                        maxi1 = y;
                        mini1 = x;
                    }
                    else if (ok1 == false && (x > maxi1 || x < mini1))
                        ok2 = false;
                    if (y < x && ok3 == true)
                    {
                        ok3 = false;
                        mini2 = y;
                        maxi2 = x;
                    }
                    else if (ok3 == false && (x < mini2 || x > maxi2))
                        ok4 = false;
                    y = x;
                }
                if (ok2)
                    Console.WriteLine("Secventa data este secventa monotona rotita");
                else if (ok4)
                    Console.WriteLine("Secventa data este secventa monotona rotita");
                else
                    Console.WriteLine("Secventa data nu este secventa monotona rotita");
            }
        }
        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
        /// <example>
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.
        /// <TODO>
        ///  Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </TODO>
        /// </example>
        /// </summary>
        static void P15()
        {
            var v = InitArray();
            bool ok = true;
            int posMax = Array.IndexOf(v, v.Max());
            if (posMax == 0 || posMax == v.Length)
                ok = false;
            for (int i = 0; i < posMax; i++)
                if (v[i] > v[i + 1])
                    ok = false;
            for (int i = posMax; i < v.Length - 1; i++)
                if (v[i] < v[i + 1])
                    ok = false;
            if (ok)
                Console.WriteLine("Secventa data este o secventa bitonica");
            else
                Console.WriteLine("Secventa data nu este o secventa bitonica");
        }
        /// <summary>
        /// O secventa bitonica rotita este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica 
        /// prin rotiri succesive (rotire = primul element devine ultimul). 
        /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
        /// </summary>
        static void P16()
        {
            var v = InitArray();
            bool ok = true;
            bool ok2 = false;
            /*
             Verificam daca este bitonica
             */
            int posMax = Array.IndexOf(v, v.Max());
            if (posMax == 0 || posMax == v.Length)
                ok = false;
            for (int i = 0; i < posMax; i++)
                if (v[i] > v[i + 1])
                    ok = false;
            for (int i = posMax; i < v.Length - 1; i++)
                if (v[i] < v[i + 1])
                    ok = false;
            for (int i = 0; i < v.Length - 1 && !ok2; i++)
            {
                if (ok)
                {   
                    /*
                     Rotire spre stanga a elementelor
                     */
                    ok2 = true;
                    int aux = v[0];
                    for (int j = 0; j < v.Length - 1; j++)
                        v[i] = v[i + 1];
                        v[v.Length - 1] = aux;
                }
            }
            if (ok2)
                Console.WriteLine("Secventa data este o secventa bitonica rotita");
            else
                Console.WriteLine("Secventa data nu este o secventa bitonica rotita");
        }
        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. 
        /// <example>
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.
        /// </example> 
        /// </summary>
        static void P17()
        {
            var v = InitArray();
            bool ok = false;
            int k1 = 0;
            int k2 = 0;
            if (v.Length % 2 == 1)
                ok = false;
            for (int i = 0; i < v.Length; i++)
                if (v[i] == 1)
                    k1++;
            if (k1 % 2 == 0)
            {
                ok = true;
                k2 = k1 / 2;
            }
            if (ok)
                Console.WriteLine($"Secventa data este corecta, cu nivelul maxim de incuibari egal cu {k2}");
            else
                Console.WriteLine("Secventa data nu este corecta");
        }
    }
}