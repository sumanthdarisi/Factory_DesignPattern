using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
    /*
     * 1. Client
     * 2. Interface 
     * 3. Factory Class
     * 4. Business classes 
     */ 

    //client
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello type the business area");
            int BusinessArea = Convert.ToInt16(Console.ReadLine());
            clsFactoryInterface obj = factoryClass.getType(BusinessArea);
            obj.getInvoice();
            Console.ReadKey();
        }
    }



    //Invoice generator class
    public interface clsFactoryInterface
    {
         void getInvoice();
    }

    //business - HYD
    class HYDBusiness : clsFactoryInterface
    {
        double stateTaxPercentage = 10.5;
        double statePropTaxPercentage = 6.89;

        public void getInvoice()
        {
            Console.WriteLine($"Hyderabad business, state tax is {stateTaxPercentage}% and state property tax is {statePropTaxPercentage}%");
        }
    }
    //business - MUM
    class BOMBusiness : clsFactoryInterface
    {
        double stateTaxPercentage = 16.7;
        double statePropTaxPercentage = 11.32;


        public void getInvoice()
        {
            Console.WriteLine($"Mumbai business, state tax is {stateTaxPercentage}% and state property tax is {statePropTaxPercentage}%");
        }
    }

    //business - CHN
    class MASBusiness : clsFactoryInterface
    {
        double stateTaxPercentage = 12.3;
        double statePropTaxPercentage = 8.65;


        public void getInvoice()
        {
            Console.WriteLine($"Chennai business, state tax is {stateTaxPercentage}% and state property tax is {statePropTaxPercentage}%");
        }
    }

    //factoryClass
    class factoryClass
    {
        static public clsFactoryInterface getType(int type)
        {
            clsFactoryInterface obj;
            if (type == 1)
            {
                obj = new HYDBusiness();
                return obj;
            }
            else if (type == 2)
            {
                obj = new BOMBusiness();
                return obj;
            }
            else
            {
                obj = new MASBusiness();
                return obj;
            }
        }
    }
}
