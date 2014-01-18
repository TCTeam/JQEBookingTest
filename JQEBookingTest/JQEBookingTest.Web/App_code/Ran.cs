using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 验证码实现
/// </summary>
public class Ran
{
    public Ran()
    {

    }
    /// <summary>
    /// 随机数产生方法
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string RandomNum(int n)
    {
        // 随机数
        string str = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        string[] VcArray = str.Split(',');
        string VNum = "";
        int temp = -1;
        Random rand = new Random();
        for (int i = 1; i < n + 1; i++)
        {
            if (temp != -1)
            {
                rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
            }
            int t = rand.Next(61);
            if (temp != -1 && temp == t)
            {
                return RandomNum(n);
            }
            temp = t;
            VNum += VcArray[t];
        }
        return VNum;
    }
}