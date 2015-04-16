using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Two
{
    /*
    class Product
    {
        public Product(string name, decimal price, int unitsInStock)
        {
            this.ProductName = name;
            this.ProductPrice = price;
            this.UnitsInStock = unitsInStock;
        }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; set; }


        //Name, Price, UnitsInstock
        // No description needed
        //Should be able to modify Name, Price, and UnitsInStock
    
    }

    */

    //class Address
    //{
    //    public string Street { get; set; }
    //    public string City { get; set; }

    //}
    ////COMPLEX CLASS, a class which uses other classes.
    //public class Customer
    //{
    //    public Customer()
    //    {
    //        this.BillingAddress = new Address();//If you initialize it in a constructor, you don't have to put the line in the program.
    //        this.ShippingAddress = new Address();
    //    }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public Address ShippingAddress { get; set; }
    //    public Address BillingAddress { get; set; }
    //DON'T DO THIS. INEFFICIENT. CREATE A CLASS INSTEAD.


    /*
    public Customer(string firstName) //See how the constructor (ctor + TAB TAB) has the same name as the original class
    {//THIS REQUIRES A FIRST NAME BEFORE YOU CAN CREATE THE CLASS.
        this.FirstName = firstName;
    }
    public string FirstName { get; set; }
*/
    //public string FirstName { get; set; }

    //private int _age;

    //public int Age
    //{
    //    get { return _age; }
    //    set { 

    //    _age = value < 0 ? _age : value; 

    //    }
    //}

    //public DateTime DoB { get; set; }

    //-------------

    //INHERITANCE: Extends a class to have new properties while keeping ones from the old

    public class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
    }

    public class NewCar //:Classname DERIVES FROM THE BASE CAR
    {
    }

    public class UsedCar 
    {
        public int Age { get; set; }
    }

    public class CertifiedUsedCar //GRANDCHILD PULLS FROM CHILD TO GET INHERITACE FROM BOTH
    {
        public int Age { get; set; }
        public DateTime LastInspected { get; set; }
    }



//--------------------------------------------------


//INHERITANCE PRACTICE
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShowFullName()
        {
            return FirstName + ' ' + LastName;
        }
    }
    class FullTimeEmployee:Employee
    {
        public int YearsEmployed { get; set; }
    }
    class PartTimeEmployee:Employee
    {
        public int MonthsEmployed { get; set; }
    }

}

