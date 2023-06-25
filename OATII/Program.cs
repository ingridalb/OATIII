using OATII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    public class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU DE QUESTÕES");
                Console.WriteLine("");
                Console.Write("DIGITE UMA QUESTÃO DE 1 ATÉ 64: ");
               
                if (int.TryParse(Console.ReadLine(), out escolha))
                Console.Clear();

                {
                    switch (escolha)
                    {
                        case 1:

                            Q1 objQ1 = new Q1();

                        break;

                        case 2:

                            Q2 objQ2 = new Q2();

                        break;

                        case 3:

                            Q3 objQ3 = new Q3();

                        break;

                        case 4:

                            Q4 objQ4 = new Q4();

                        break;

                        case 5:

                            Q5 objQ5 = new Q5();

                        break;

                        case 6:

                            Q6 objQ6 = new Q6();

                        break;

                        case 7:

                            Q7 objQ7 = new Q7();

                        break;

                        case 8:

                            Q8 objQ8 = new Q8();

                        break;

                        case 9:

                            Q9 objQ9 = new Q9();

                        break;

                        case 10:

                            Q10 objQ10 = new Q10();

                        break;

                        case 11:

                            Q11 objQ11 = new Q11();

                        break;

                        case 12:

                            Q12 objQ12 = new Q12();

                        break;

                        case 13:

                            Q13 objQ13 = new Q13();

                        break;

                        case 14:

                            Q14 objQ14 = new Q14();

                        break;

                        case 15:

                            Q15 objQ15 = new Q15();

                        break;

                        case 16:

                            Q16 objQ16 = new Q16();

                        break;

                        case 17:

                            Q17 objQ17 = new Q17();

                        break;

                        case 18:

                            Q18 objQ18 = new Q18();

                        break;

                        case 19:

                            Q19 objQ19 = new Q19();

                        break;

                        case 20:

                            Q20 objQ20 = new Q20();

                        break;

                        case 21:

                            Q21 objQ21 = new Q21();

                        break;

                        case 22:

                            Q22 objQ22 = new Q22();

                        break;

                        case 23:

                            Q23 objQ23 = new Q23();

                        break;

                        case 24:

                            Q24 objQ24 = new Q24();

                        break;

                        case 25:

                            Q25 objQ25 = new Q25();

                        break;

                        case 26:
                            Q26 objQ26 = new Q26();

                        break;

                        case 27:

                            Q27 objQ27 = new Q27();

                        break;

                        case 28:

                            Q28 obj28 = new Q28();

                        break;

                        case 29:

                            Q29 obj29 = new Q29();

                        break;

                        case 30:

                            Q30 obj30 = new Q30();

                        break;

                        case 31:

                            Q31 objQ31 = new Q31();

                        break;

                        case 32:

                            Q32 objQ32 = new Q32();

                        break;

                        case 33:

                            Q33 objQ33 = new Q33();

                        break;

                        case 34:

                            Q34 objQ34 = new Q34();

                        break;

                        case 35:

                            Q35 objQ35 = new Q35();

                        break;

                        case 36:

                            Q36 objQ36 = new Q36();

                        break;

                        case 37:

                            Q37 objQ37 = new Q37();

                        break;

                        case 38:

                            Q38 objQ38 = new Q38();

                        break;

                        case 39:

                            Q39 objQ39 = new Q39();

                        break;

                        case 40:

                            Q40 objQ40 = new Q40();

                        break;

                        case 41:

                            Q41 obj41 = new Q41();

                        break;

                        case 42:

                            Q42 obj42 = new Q42();
                        
                        break;

                        case 43:

                            Q43 objQ43 = new Q43();
                            
                        break;

                        case 44:

                            Q44 objQ44 = new Q44();

                        break;

                        case 45:

                            Q45 obj45 = new Q45();

                            break;

                        case 46:

                            Q46 objQ46 = new Q46();

                            break;

                        case 47:

                            Q47 objQ47 = new Q47();

                            break;

                        case 48:

                            Q48 objQ48 = new Q48();

                            break;

                        case 49:

                            Q49 objQ49 = new Q49();

                            break;

                        case 50:

                            Q50 objQ50 = new Q50();

                            break;

                        case 51:

                            Q51 obj51 = new Q51();

                            break;

                        case 52:

                            Q52 obj52 = new Q52();

                            break;

                        case 53:

                            Q53 objQ53 = new Q53();

                            break;

                        case 54:

                            Q54 objQ54 = new Q54();

                            break;

                        case 55:

                            Q55 objQ55 = new Q55();

                            break;

                        case 56:

                            Q56 objQ56 = new Q56();

                            break;

                        case 57:

                            Q57 objQ57 = new Q57();

                            break;

                        case 58:

                            Q58 objQ58 = new Q58();

                            break;

                        case 59:

                            Q59 objQ59 = new Q59();

                            break;

                        case 60:

                            Q60 objQ60 = new Q60();

                            break;

                        case 61:

                            Q61 objQ61 = new Q61();

                            break;

                        case 62:

                            Q62 objQ62 = new Q62();

                            break;

                        case 63:

                            Q63 objQ63 = new Q63();

                            break;

                        case 64:

                            Q64 objQ64 = new Q64();

                            break;
                    }
                }

            } while (escolha != 64);
            
        }
    }
}
