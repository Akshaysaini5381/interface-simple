using System;

namespace interface_simple
{
    interface simple
    {  
        void S(int num);
        public abstract int show(int num1,int num2);
        public abstract void so();

     /*  douat   public static int k; */  
    }
   
    class Program:simple
    {
       
        public void S(int n)
        {
            Console.WriteLine("first interface  :"+n);

        }
        public int show(int num1,int num2)
        {
            return num1+num2 ;
        }
        public  void so()
        {
            Console.WriteLine("hello :");
        }
      
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.S(6);
           int result= obj.show(12, 101);
            Console.WriteLine(" Abstract method with parametar with return type :"+result);
            obj.so();
            
           
           
           
            
        }
    }
}
