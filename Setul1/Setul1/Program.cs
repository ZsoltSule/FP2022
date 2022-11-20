using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Setul1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la 1 la 21 pentru a alege una din probleme:");
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
                    case 18: P18();
                        break;
                    case 19: P19();
                        break;
                    case 20: P20();
                        break;
                    case 21: P21();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /// <summary>
            /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
            /// </summary>
            static void P1()
            {
                Console.WriteLine("Introduceti o valoare intreaga pentru A:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti o valoare intreaga pentru B:");
                int b = Convert.ToInt32(Console.ReadLine());

                double x = -b / a;
                Console.WriteLine($"Rezultatul ecuatiei este x = {x}");
            }
            /// <summary>
            /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
            /// Tratati toate cazurile posibile.
            /// </summary>  
            static void P2()
            {
                Console.WriteLine("Introduceti o valoare rationala pentru A:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti o valoare rationala pentru B:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti o valoare rationala pentru C:");
                int c = Convert.ToInt32(Console.ReadLine());

                int dt = b * b - 4 * a * c;
                if (dt > 0)
                {
                    double x1 = (-b - Math.Sqrt(dt)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(dt)) / (2 * a);
                    Console.WriteLine($"Solutiile ecuatiei de gradul al doilea sunt x1 = {x1} si x2 = {x2}");
                }
                else if (dt == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Solutia ecuatiei de gradul al doilea este x = {x}");
                }
                else
                {
                    /* Pentru delta negativ solutiile vor fi numere complexe
                     * Impartim fractia in 2 fractii cu acelasi numitor 
                     * De exemplu: (a + b) / c == (a / c) + (b / c)
                     * Din cele 2 fractii vom avea astfel 4
                     * 2 Fractii pentru prima solutie adica x1 si 2 fractii pentru x2
                     * Vom avea x1 = -b / 2 * a + fractia numarul 2 adica (sqrt(-dt) / 2 * a) * i
                     * Pentru x2 vom avea acelasi lucru doar ca vom scadea cele 2 fractii
                     * Din moment ce numarul imaginar "i" este un caracter va trebui sa-l afisam ca un string
                     * Am impartit cele 2 solutii in 4 fractii astfel deoarece in momentul in care le adunam 
                     * sau le scadem, nu vom obtine rezultatul corect deoarece nu va tine cont de
                     * inmultirea cu "i", acesta fiind un caracter
                     * Astfel ca dupa ce calculam cele 2 fractii cu acelasi numitor pentru x1 le vom converti separat
                     * in string ca sa avem separat partea reationala si cea imaginara a solutiei. La fel facem si pentru x2
                     * La final afisam rezultatul sub forma de string 
                     */
                    double x11 = -b / 2 * a;
                    double x12 = Math.Sqrt(-dt) / 2 * a;
                    double x21 = -b / 2 * a;
                    double x22 = Math.Sqrt(-dt) / 2 * a;
                    Convert.ToString(x11);
                    Convert.ToString(x12);
                    Convert.ToString(x21);
                    Convert.ToString(x22);
                    Console.WriteLine($"Solutiile ecuatiei de gradul al doilea sunt x1 = {x11} + {x12}i si x2 = {x21} -{x22}i");
                }
            }
            /// <summary>
            /// Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            /// </summary>
            static void P3()
            {
                Console.WriteLine("Introduceti o valoare intreaga pentru N:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceto o valoare intreaga pentru K:");
                int k = Convert.ToInt32(Console.ReadLine());

                if (n % k == 0)
                    Console.WriteLine($"{n} se divide cu {k}");
                else
                    Console.WriteLine($"{n} nu se divide cu {k}");
            }
            /// <summary>
            /// Detreminati daca un an y este an bisect. 
            /// </summary>
            static void P4()
            {
                Console.WriteLine("Introduceti un an:");
                int y = Convert.ToInt32(Console.ReadLine());

                if (y % 4 == 0 && y % 100 != 0 || (y % 400 == 0))
                    Console.WriteLine($"Anul {y} este an bisect");
                else
                    Console.WriteLine($"Anul {y} nu este an bisect");
            }
            /// <summary>
            /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. 
            /// Cifrele se numara de la dreapta la stanga.
            /// </summary>
            static void P5()
            {
                Console.WriteLine("Introduceti un numar:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti a cata cifra a acestui numar doriti sa o extrageti:");
                int k = Convert.ToInt32(Console.ReadLine());

                int aux = k;
                int p = 1;
                int cn = n;
                while (aux > 1)
                {
                    p *= 10;
                    aux--;
                }
                n /= p;
                if (p > cn)
                    Console.WriteLine("Numarul ales nu are suficiente cifre!");
                else if (k == 1)
                    Console.WriteLine($"Prima cifra a numarului ales este {Math.Abs(n % 10)}");
                else
                    Console.Write($"A {k}-a cifra a numarului ales este {Math.Abs(n % 10)}");
            }
            /// <summary>
            /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            /// </summary>
            static void P6()
            {
                Console.WriteLine("Introduceti o valoare pentru A:");
                float a = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Introduceti o valoare pentru B:");
                float b = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Introduceti o valoare pentru C:");
                float c = Convert.ToSingle(Console.ReadLine());

                if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b)
                    Console.WriteLine("Numerele pot forma un triunghi");
                else
                    Console.WriteLine("Numerele nu pot forma triunghi");
            }
            /// <summary>
            /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
            /// Se cere sa se inverseze valorile lor. 
            /// </summary>
            static void P7()
            {
                Console.WriteLine("Introduceti o valoare rationala pentru prima variabila:");
                float a = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Introduceti o valoare rationala pentru a doua variabila:");
                float b = Convert.ToSingle(Console.ReadLine());

                float aux = a;
                a = b;
                b = aux;
                Console.WriteLine($"Valoarea primei variabile a devenit {a}, iar a doua variabila a devenit {b}");
            }
            /// <summary>
            /// (Swap restrictionat) Se dau doua variabile numerice a si b ale caror valori sunt date de intrare.
            /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
            /// </summary>
            static void P8()
            {
                Console.WriteLine("Introduceti o valoare rationala pentru prima variabila:");
                float a = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Introduceti o valoare rationala pentru a doua variabila:");
                float b = Convert.ToSingle(Console.ReadLine());

                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine($"Valoarea primei variabile a devenit {a}, iar a doua variabila a devenit {b}");
            }
            /// <summary>
            /// Afisati toti divizorii numarului n. 
            /// </summary>
            static void P9()
            {
                Console.WriteLine("Introduceti un numar intreg:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                    Console.WriteLine("Divizorii lui 0 sunt toate numerele intregi");
                else
                {
                    Console.Write($"Divizorii lui {n} sunt: ");
                    for (int i = -Math.Abs(n); i < 0; i++)
                    {
                        if (Math.Abs(n) % i == 0)
                            Console.Write($"{i} ");
                    }
                    for (int i = 1; i <= Math.Abs(n); i++)
                    {
                        if (Math.Abs(n) % i == 0)
                            Console.Write($"{i} ");
                    }
                }
            }
            /// <summary>
            /// Test de primalitate: determinati daca un numar n este prim.
            /// </summary>
            static void P10()
            {
                Console.WriteLine("Introduceti o valoare:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (isPrime(n) == 1)
                    Console.WriteLine($"{n} este numar prim");
                else
                    Console.WriteLine($"{n} nu este numar prim");
            }
            /// <summary>
            /// Aceasta functie returneaza 1 daca numarul este prim si 0 in caz contrar
            /// </summary>
            /// <param name = "x"></param>
            /// <returns></returns>
            static int isPrime(int n)
            {
                if (n < 2)
                    return 0;
                if (n == 2)
                    return 1;
                if (n % 2 == 0)
                    return 0;
                for (int d = 3; d * d <= n; d += 2)
                    if (n % d == 0)
                        return 0;
                return 1;
            }
            /// <summary>
            /// Afisati in ordine inversa cifrele unui numar n. 
            /// </summary>
            static void P11()
            {
                Console.WriteLine("Introduceti un numar intreg:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (Math.Abs(n) < 10)
                    Console.WriteLine($"{Math.Abs(n)} este singura cifra a numarului {Math.Abs(n)}");
                else
                {
                    Console.WriteLine("Cifrele numarului in ordine inversa sunt:");
                    while (Math.Abs(n) > 0)
                    {
                        Console.Write($"{Math.Abs(n) % 10} ");
                        n /= 10;
                    }
                }
            }
            /// <summary>
            /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
            /// </summary>
            static void P12()
            {
                Console.WriteLine("Introduceti un numar interg:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg pentru marginea inferioara al intervalului:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg pentru marginea superioara al intervalului:");
                int b = Convert.ToInt32(Console.ReadLine());

                int k = 0;
                for (int d = a; d <= b; d++)
                {
                    if (n % d == 0)
                        k++;
                }
                Console.WriteLine($"Numarul {n} are {k} divizori din intervalul [{a}, {b}]");
            }
            /// <summary>
            /// Determianti cati ani bisecti sunt intre anii y1 si y2.
            /// </summary>
            static void P13()
            {
                Console.WriteLine("Introduceti un:");
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Mai introduceti un an diferit de primul:");
                int y2 = Convert.ToInt32(Console.ReadLine());

                if (y1 > y2)
                {
                    int aux = y1;
                    y1 = y2;
                    y2 = aux;
                }

                int k = 0;
                for (int i = y1; i <= y2; i++)
                    if (i % 4 == 0 && i % 100 != 0 || (i % 400 == 0))
                        k++;
                Console.WriteLine($"Intre anii {y1} si {y2} sunt {k} ani bisecti");
            }
            /// <summary>
            /// Determianti daca un numar n este palindrom.
            /// <example>
            /// Un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
            /// </example> 
            /// </summary>
            static void P14()
            {
                Console.WriteLine("Introduceti un numar intreg");
                int n = Convert.ToInt32(Console.ReadLine());

                if (isPalindrom(Math.Abs(n)))
                    Console.WriteLine($"{n} este un palindrom");
                else
                    Console.WriteLine($"{n} nu este un palindrom");
            }
            /// <summary>
            /// Verifica si returneaza "true" daca numarul este palindrom si "false" in caz contrar
            /// </summary>
            static bool isPalindrom(int n)
            {
                int reverse = 0;
                int aux = n;
                while (aux > 0)
                {
                    reverse = reverse * 10 + aux % 10;
                    aux /= 10;
                }
                if (reverse == n)
                    return true;
                return false;
            }
            /// <summary>
            /// Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            /// </summary>
            static void P15()
            {
                Console.WriteLine("Introduceti un numar intreg A:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg B:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg C:");
                int c = Convert.ToInt32(Console.ReadLine());

                int maxi = 0;
                int mini = 100000000;

                if (a > b && a > c)
                    maxi = a;
                else if (b > c && b > a)
                    maxi = b;
                else
                    maxi = c;

                if (a < b && a < c)
                    mini = a;
                else if (b < c && b < a)
                    mini = b;
                else
                    mini = c;

                Console.WriteLine($"Cele 3 numere in ordine crescatoare sunt: {mini}, {a + b + c - (maxi + mini)} si {maxi}");
            }
            /// <summary>
            /// Se dau 5 numere. Sa se afiseze in ordine crescatoare.
            /// <exception>
            /// (nu folositi tablouri)
            /// </exception>
            /// </summary>
            static void P16()
            {
                Console.WriteLine("Introduceti un numar intreg A:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg B:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg C:");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg D:");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar intreg E:");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e < d)
                    Swap(ref e, ref d);
                if (e < c)
                    Swap(ref e, ref c);
                if (e < b)
                    Swap(ref e, ref b);
                if (e < a)
                    Swap(ref e, ref a);
                if (d < c)
                    Swap(ref d, ref c);
                if (d < b)
                    Swap(ref d, ref b);
                if (d < a)
                    Swap(ref d, ref a);
                if (c < b)
                    Swap(ref c, ref b);
                if (c < a)
                    Swap(ref c, ref a);
                if (b < a)
                    Swap(ref b, ref a);
                Console.WriteLine($"Cele 5 numere in ordine crescatoare sunt: {a}, {b}, {c}, {d} si {e}");
            }
            /// <summary>
            /// Interschimbare de 2 variabile pentru rapiditate in scriere
            /// </summary>
            static void Swap(ref int a, ref int b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            /// <summary>
            /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. 
            /// Folositi algoritmul lui Euclid. 
            /// </summary>
            static void P17()
            {
                Console.WriteLine("Introduceti un numar intreg:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un alt numar intreg:");
                int b = Convert.ToInt32(Console.ReadLine());

                int num1 = cmmdc(Math.Abs(a), Math.Abs(b));
                int num2 = cmmmc(Math.Abs(a), Math.Abs(b));

                Console.WriteLine($"Cel mai mare divizor comun al numerelor {a} si {b} este {num1}, iar cel mai mic multiplu comun al acestor numere este {num2}");
            }
            /// <summary>
            /// Returneaza cel mai mare divizor comun
            /// </summary>
            static int cmmdc(int a, int b)
            {
                while (b != 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }
                return a;
            }
            /// <summary>
            /// Returneaza cel mai mic multiplu comun
            /// </summary>
            static int cmmmc(int a, int b)
            {
                int auxa = a;
                int auxb = b;
                while (b > 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }
                return auxa * auxb / a;
            }
            /// <summary>
            /// Afisati descompunerea in factori primi ai unui numar n.
            /// <example>
            ///  Pentru n = 1176 afisati 2^3 x 3^1 x 7^2.
            /// </example>
            /// </summary>
            static void P18()
            {
                Console.WriteLine("Introduceti un numar natural:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Numarul {n} descompus in factori primi este: ");
                int d = 2;
                int p = 0;
                while (n > 1)
                {
                    p = 0;
                    while (n % d == 0)
                    {
                        p++;
                        n /= d;
                    }
                    if (p != 0)
                        Console.Write($" {d}^{p} ");
                    d++;
                    if (n > 1 && d * d > n)
                    {
                        d = n;
                    }
                }
            }
            /// <summary>
            /// Determinati daca un numar este format doar cu 2 cifre care se pot repeta.
            /// <example>
            /// Pentru 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
            /// </example>
            /// </summary>
            static void P19()
            {
                Console.WriteLine("Introduceti un numar intreg:");
                int n = Convert.ToInt32(Console.ReadLine());

                int k = 0;
                int aux = n;
                int[] counter = new int[10];
                while(Math.Abs(n) != 0)
                {
                    counter[Math.Abs(n) % 10]++;
                    n /= 10;
                }
                foreach (int i in counter)
                {
                    if (i != 0)
                        k++;
                }
                n = aux;
                if (k == 2)
                    Console.WriteLine($"Numarul {n} este format doar cu 2 cifre");
                else
                    Console.WriteLine($"Numarul {n} nu este format cu doar 2 cifre");
            }
            /// <summary>
            /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).
            /// <example>
            /// Exemplu: 13/30 = 0.4(3).
            /// </example>
            /// </summary>
            static void P20()
            {
                Console.WriteLine("Introduceti un numar natural M:");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti un numar natural N:");
                int n = Convert.ToInt32(Console.ReadLine());

                int parteInt = m / n; 
                int parteFract = m % n;
                Console.Write($"{parteInt},");
                int cifra, rest;
                List<int> resturi = new List<int>();
                List<int> cifre = new List<int>();
                resturi.Add(parteFract);
                bool periodic = false;
                do
                {
                    cifra = parteFract * 10 / n;
                    cifre.Add(cifra);
                    rest = parteFract * 10 % n;
                    if (!resturi.Contains(rest))
                        resturi.Add(rest);
                    else
                    {
                        periodic = true;
                        break;
                    }
                    parteFract = rest;
                } while (rest != 0);

                if (!periodic)
                {
                    foreach (var item in cifre)
                    {
                        Console.Write(item);
                    }
                }
                else
                {
                    for (int i = 0; i < resturi.Count; i++)
                    {
                        if (resturi[i] == rest)
                        {
                            Console.Write("(");
                        }
                        Console.Write(cifre[i]);
                    }
                    Console.WriteLine(")");
                }
            }
            /// <summary>
            /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
            /// </summary>
            static void P21()
            {
                Console.WriteLine("M-am gandit la un numar cuprins intre 1 si 1024.");
                Console.WriteLine("Incearca sa-l ghicesti!");
                Console.WriteLine("Ai la dispozitie 10 incercari!");
                Console.WriteLine("Daca reusesti sa ghicesti numarul la care m-am ganidt in mai putin de 10 incercari ai castigat jocul!");
                Console.WriteLine("Daca nu reusesti, ai pierdut jocul si eu am castigat!");
                Random rnd = new Random();
                int nr;
                int x = rnd.Next(1, 1024);
                int k = 1;
                int tries = 9;
                Console.WriteLine();
                Console.WriteLine("Care este prima incercare?");
                do
                {
                    nr = Convert.ToInt32(Console.ReadLine());

                    if (nr < x)
                    {
                        if (tries == 1)
                        {
                            Console.WriteLine($"Gresit! M-am gandit la alt numar decat {nr}!");
                            Console.WriteLine($"Numarul la care m-am gandit este mai mare decat {nr}!");
                            Console.WriteLine("Incearca din nou!");
                            Console.WriteLine($"Mai ai o singura incercare la dispozitie!");
                            k++;
                        }
                        else
                        {
                            Console.WriteLine($"Gresit! M-am gandit la alt numar decat {nr}!");
                            Console.WriteLine($"Numarul la care m-am gandit este mai mare decat {nr}!");
                            Console.WriteLine("Incearca din nou!");
                            Console.WriteLine($"Mai ai {tries--} incercari la dispozitie!");
                            k++;
                        }
                    }
                    if (nr > x)
                    {
                        if (tries == 1)
                        {
                            Console.WriteLine($"Gresit! M-am gandit la alt numar decat {nr}!");
                            Console.WriteLine($"Numarul la care m-am gandit este mai mic decat {nr}!");
                            Console.WriteLine("Incearca din nou!");
                            Console.WriteLine($"Mai ai o singura incercare la dispozitie!");
                            k++;
                        }
                        else
                        {
                            Console.WriteLine($"Gresit! M-am gandit la alt numar decat {nr}!");
                            Console.WriteLine($"Numarul la care m-am gandit este mai mic decat {nr}!");
                            Console.WriteLine("Incearca din nou!");
                            Console.WriteLine($"Mai ai {tries--} incercari la dispozitie!");
                            k++;
                        }
                    }
                }
                while(k != 10);
                nr = Convert.ToInt32(Console.ReadLine());
                if (nr != x)
                {
                    Console.WriteLine($"Gresit!M-am gandit la alt numar decat {nr}!");
                    Console.WriteLine($"Numarul la care m-am gandit este {x}.");
                    Console.WriteLine($"Ai pierdut jocul!");
                }
                else
                {
                    Console.WriteLine("Ai ghicit!");
                    Console.WriteLine($"Numarul la care m-am gandit este {x}!");
                    Console.WriteLine($"Ai avut nevoie doar de {k++} incercari!");
                    Console.WriteLine("Felicitari!");
                }
            }
        }
    }
}
