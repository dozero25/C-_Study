using System;

namespace ex_SealedMethod
{
    internal class Program
    {
        class Base
        {
            public virtual void SealMe()
            { 
            
            }
        }

        class Derived : Base
        {
            public sealed override void SealMe()
            {
                
            }
        
        }

        class WantToOverride : Derived
        {
            public override void SealMe() // 오류 발생 : error CS0239 : 'WantToOverride.SealMe()' 멤버는 봉인된어 있으므로 재정의할 수 없습니다.
            { 
            }
        }

        static void Main(string[] args)
        {
            /*
            메서드 봉인
            : 더 이상 메서드를 오버라이드 하지 못하도록 막는 것
            : 상속 중단
            : sealed 키워드 사용해서 메서드 봉인
             */
        }
    }
}
