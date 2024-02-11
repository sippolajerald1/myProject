using System;

namespace myProject
{


    class Injection_Molding_Press
    {
        private static int _transactions = 0;

        public void SetTrans() 
        { 
            _transactions++; 
        }

        public int GetTrans()
        {
            return _transactions;
        } 


        private int _Number;
        private int _Size;
        private string _Press;

        public Injection_Molding_Press()
        {
            _Number = 0;
            _Size = 0;
            _Press = "";
        }

        public Injection_Molding_Press(int i, int size, string press)
        {
            _Number = i;
            _Size = size;
            _Press = press;
        }

        public int GetNumber()
        {
            return _Number;
        }

        public int GetSize()
        {
            return _Size;
        }

        public string GetPress()
        {
            return _Press;
        }

        public void setNumber(int identification)
        {
            _Number = identification;
        }

        public void setSize(int size)
        {
            _Size = size;
        }

        public void setPress(string press)
        {
            _Press = press;
        }




        static void Main(string[] args)
        {
            Injection_Molding_Press member10 = new Injection_Molding_Press();
            member10.SetTrans();
            member10.setNumber(10);
            member10.setSize(150);
            member10.setPress("Husky");


            Injection_Molding_Press member20 = new Injection_Molding_Press();
            member20.SetTrans();
            Console.WriteLine("Please enter Id for injection molding press:");
            member20.setNumber(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter size Injection Molding Press member size: ");
            member20.setSize(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the manufacturer of Injection Molding press: ");
            member20.setPress(Console.ReadLine());

            Injection_Molding_Press member30 = new Injection_Molding_Press(20, 100, "Van Dorn");
            member30.SetTrans();

            Console.WriteLine("Please enter the combination Id: ");
            int combinationId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter injection molding press size: ");
            int combinationSize = int.Parse(Console.ReadLine());
            Console.WriteLine(("Please enter Injection Molding Press manufacturer: "));
            string combinationPress = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Injection_Molding_Press member40 = new Injection_Molding_Press(combinationId, combinationSize, combinationPress);
            member40.SetTrans();


            Console.WriteLine($"The number of injection molding presses are {member10.GetTrans()}");
            Console.WriteLine();
            displayMembers(member10);
            displayMembers(member20);
            displayMembers(member30);
            displayMembers(member40);



        }
           static void displayMembers(Injection_Molding_Press member)
        {
            Console.WriteLine();
            Console.WriteLine("Here's your injection molding press information: ");
            Console.WriteLine($"ID: {member.GetNumber()}");
            Console.WriteLine($"Size: {member.GetSize()}");
            Console.WriteLine($"Press Manufacturer: {member.GetPress()}");

        }

        

    }
}
      

