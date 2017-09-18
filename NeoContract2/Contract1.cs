using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace NeoContract2
{
    public class Contract1 : SmartContract
    {
        public static String Main(String a, String b){
            if (a.Equals("is dank"))
            {
                return "Dank memes";
            } else
            {
                return "Deep fried memes";
            }
  
        }

        public static int Sum (int a, int b)
        {
            return a + b;
        }
    }
}
