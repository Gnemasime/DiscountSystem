using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DiscountSystem.Models
{
    public class Discount
    {

        [Required(ErrorMessage = "Please enter your name")]
        [DisplayName("Customer Name")]
        public string CustName{ get; set; } //string
        [DisplayName("Price per item")]
        public double Price { get; set; }
        [DisplayName("Quantity")]
        public int Qty { get; set; }

        [DisplayName("Subtotal")]
        public double Subtotal { get; set; }

        [DisplayName("Total amount after discount")]
        public double TotalAmt { get; set; }
        [DisplayName("Discount Amount")]
        public double DiscRate { get; set; }
        [DisplayName("Vat Amount")]
        public double Vat { get; set; }

        [DisplayName("Final Due")]
        public double FinalDue { get; set; }

        public double Sub() 
        {
            return Price * Qty;
        }

        public double Disc()
        {
            if (Subtotal < 300)
            {

                DiscRate = Sub() * 0.03;
            }
            else if (Subtotal < 500)
            {
                DiscRate = Sub() * 0.05;
            }
            else
            {
                DiscRate = Sub() * 0.07;
            }
            return DiscRate;
                

        }

        public double Tot()
        {
            return Sub() - Disc();
        }
        public double VatAmt() 
        {
            Vat = Tot() * 0.15;
            return Vat;
        }

        public double Final()
        {
            return Tot() + VatAmt();
        }
        
    }
}