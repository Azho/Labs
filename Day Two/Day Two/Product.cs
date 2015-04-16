using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Two
{
    //Cyan color is a class name, dark blue is pure C#
   // public class ThisProduct // type class + TAB + TAB
    //Add public modifier
  //  {
        //AUTO IMPLEMENT (prop + TAB + TAB)
        //Tab to run through, Enter to move on, Shift Tab to go back.

        /// <summary>
        /// The name of the product
        /// </summary>
      //  public string Name { get; set; }
        /// <summary>
        /// The price of the product
        /// </summary>
       // public decimal Price { get; set; }

        //--------------------------------


        //FULL PROPERTY (propfull + TAB + TAB)
        //If you need to execute logic while reading/writing property, you need to use propfull.
        //private string _name;

        //public string MyProperty
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //private decimal _price;

        //public decimal Price
        //{
        //    get { return _price; }
        //    set {  //Logic into the set
        //        _price = value < 0 ? 0 : value;
        //        }
        //    }    

        //Instance method, because of "this"
        /// <summary>
        /// Represents tax rate
        /// </summary>
        /// <returns></returns>
     /*   public decimal CalculateTax() //the () marks it as a method instead of a property
        { //Local names between methods are camel cased
            return this.CalculateTax(.50m, 3m);
            //Refers to the current instance of the class you're in. The current object.
            //In general, use return last.
        }
        public decimal CalculateTax(decimal taxRate)
        {
            return this.CalculateTax(taxRate, 3m);
        }
        public decimal CalculateTax(decimal TaxRate, decimal discount){
            return this.Price * TaxRate + discount;
        }
    */
        //METHOD SIGNATURE: the distinctness of a method, its name and its parameters. If there's a diff in either name or param, they have different signatures.
        //METHOD OVERLOADING: one real method with many others delegating work to it.

  //  }
    //public class close bracket
    /*
    class Mail
    {
        public void Send(string to, string from = "MP@CoderCamps.com", string subject = "Official Email", string body = "Read this please!")
        {

        }

    }

    class Other
    {*/
        /* vr mail = new Mail();
         Mail.Send("whoever@wherever.com", subject:"How about lunch?");

     }
         */
        /*
        class OtherOther
        {       
            public void AddToCart(params string[] items)//PARAMETER ARRAY
            {
                var cart = new Other();
                cart.AddToCart("item1");
                cart.AddToCart("item", "item2", "item3");//YOU DON'T NEED TO DECLARE # OF ITEMS IN PARAMETER ARRAYS.
            }
        }
         */

        //Property Initializer: alternative to a constructor that adds the items when the thing is created.
        // var product2 = newProduct
        //{
        // Name = "Eggs",
        // Price = 23.33m
        //};
   // }
    
}
    
          
    

