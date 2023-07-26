using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critical_Attack_Monster
{
    public class Program   // 공격 중 60 % 확률로 적에게 크리티컬 공격하기 시스템
    {
        static void Main(string[] args)
        {
            Random random = new Random();   // 랜덤값 사용 선언

            float criNum = 1.5f;   // 크리티컬 데미지 배율
            float resultDmg = 0;   // 크리티컬 계산한 데미지
            int dmgNum = 100;   // 일반 데미지
            int randomNum = 0;   // 크리티컬 공격 랜덤값
            int loop = 1;   // while 문 loop 숫자
            int hp = 1000;   // 적 hp
            int control = 0;   // 유저 입력 숫자 판단
            int count = 1;   // 총 공격 횟수

            resultDmg = dmgNum * criNum;   // 미리 크리티컬 데미지 계산
            
            while (0 < loop)   // loop 가 0이 되면 while 문을 탈출
            {
                if (hp > 0)   // 적 hp 가 0 이상이면 while 문 계속 유지
                {
                    if (loop == 1)   // loop 1 에서 유저 입력값 받기
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("공격을 진행하려면 숫자 [ 1 ] 을 입력해주세요.");
                        Console.WriteLine("게임을 종료하시려면 숫자 [ 0 ] 을 입력해주세요.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("몬스터의 남은 HP : {0}", hp);
                        Console.WriteLine("유저의 공격력 : {0}", dmgNum);
                        Console.WriteLine("유저의 크리티컬 확률 : 60 %");
                        Console.WriteLine("유저의 크리티컬 피해량 : {0} 배", criNum);
                        Console.WriteLine();
                        Console.WriteLine();
                        int.TryParse(Console.ReadLine(), out control);

                        loop = 2;   // 유저 입력값을 받으면 loop 2 로 이동
                    }
                    else if (loop == 2)   // loop 2 에서 데미지 계산
                    {
                        if (control == 1)   // 유저 입력값이 1 이면 공격
                        {
                            randomNum = random.Next(0, 100);   // 크리티컬 공격 확률 세팅
                            if (randomNum < 60)   // 60% 확률로 크리티컬 공격
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("총 공격 횟수 : {0}", count);
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("회심의 크리티컬 한방!!! 준 데미지 : {0}", (int)resultDmg);
                                Console.WriteLine();
                                Console.WriteLine();

                                hp -= (int)resultDmg;
                                count += 1;
                                loop = 1;   // loop 1 로 이동

                                if (hp > 0)   // 데미지 계산 후 hp 가 0 이하면 게임 클리어
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("M o n s t e r K I L L !");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("G A M E C L E A R !");
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    loop = 0;   // 게임 클리어시 while 문 탈출
                                }
                            }
                            else   // 나머지 40% 확률로 일반 공격
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("총 공격 횟수 : {0}", count);
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Unlucky.. 일반 공격!! 준 데미지 : {0}", dmgNum);
                                Console.WriteLine();
                                Console.WriteLine();

                                hp -= dmgNum;
                                count += 1;
                                loop = 1;   // loop 1 로 이동

                                if (hp > 0)   // 데미지 계산 후 hp 가 0 이하면 게임 클리어
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("M o n s t e r K I L L !");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("G A M E C L E A R !");
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    loop = 0;   // 게임 클리어시 while 문 탈출
                                }
                            }
                        }
                        else if (control == 2)   // 유저 입력값이 2 이면 게임 종료
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("G A M E O V E R");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
                else   // 적 hp 가 0 이하면 게임 클리어
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("M o n s t e r K I L L !");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("G A M E C L E A R !");
                    Console.WriteLine();
                    Console.WriteLine();

                    loop = 0;   // 게임 클리어시 while 문 탈출
                }
            }
        }
    }
}
