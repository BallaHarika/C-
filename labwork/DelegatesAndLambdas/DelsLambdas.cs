using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndLambdas
{
    delegate int AddDel(int a, int b);
    delegate int SubDel(int a, int b);
    delegate int MulDel(int a, int b);
    delegate int DivDel(int a, int b);
    public class DelsLambdas
    {
        
        
            public int Start(int a, int b)
            {


                AddDel objAdd = new AddDel(Add);

                return objAdd(100, 50);
               

            }
            public int SubMethod(int a,int b)
            {
                SubDel objSub = new SubDel(Sub);

                return objSub(100, 50);
            }

          

            public int UsinganonymousMulMethod(int a, int b)
            {
                MulDel objmul = new MulDel(delegate (int a, int b) { return a * b; });
              
                return objmul(a, b); //50
            }



            public int UsingLambda(int a, int b)
            {
                DivDel objDiv = (int a, int b) =>
                {
                    int r = a / b;
                    return r;
                };
                AddDel objshortlambda = (a, b) => a / b;
                return objshortlambda(a, b);






            }

            private int Add(int a, int b)
            {
                return a + b;
            }
            private int Sub(int a, int b)
            {
                return a - b;
            }





        }

        
    }
