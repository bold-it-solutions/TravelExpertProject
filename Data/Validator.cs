using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Data
{
    //// a collection methods
    //// every method assumes that the controls have Tag property set
    //public static class Validator
    //{
        
    //    // check if text box is not empty
    //    public static bool IsPresent(TextBox tb)
    //    {
    //        bool result = true; //innocent until proven guilty
    //        if (tb.Text == "")
    //        {
    //            MessageBox.Show(tb.Tag + "has to be provided", "Input Error");
    //            result = false;
    //            tb.Focus();
    //        }
    //        return result;
    //    }

    //    //check if input in a text box is an int
    //    public static bool IsInteger(TextBox tb)
    //    {
    //        bool result = true;
    //        int parsedValue;
    //        if(!(Int32.TryParse(tb.Text,out parsedValue)))//bad
    //        {
    //            MessageBox.Show(tb.Tag + "has to be a whole number", "Input Error");
    //            result = false;
    //            tb.Focus();
    //        }
    //        return result;
    //    }

    //    //check if input in a text box is a double
    //    public static bool IsDouble(TextBox tb)
    //    {
    //        bool result = true;
    //        double parsedValue;
    //        if (!(double.TryParse(tb.Text, out parsedValue)))//bad
    //        {
    //            MessageBox.Show(tb.Tag + "has to be a double number", "Input Error");
    //            result = false;
    //            tb.Focus();
    //        }
    //        return result;
    //    }

    //    //check if input in a text box is a non-negative int
    //    public static bool IsNonNegativeInteger(TextBox tb)
    //    {
    //        bool result = true;
    //        int parsedValue=Int32.Parse(tb.Text); //we already know it is an integer
    //        if (parsedValue<0)//bad
    //        {
    //            MessageBox.Show(tb.Tag + "has to be positive or zero", "Input Error");
    //            result = false;
    //            tb.Focus();
    //        }
    //        return result;
    //    }
    //    //check if input in a text box is a non-negative double
    //    public static bool IsNonNegativeDouble(TextBox tb)
    //    {
    //        bool result = true;
    //        double parsedValue=double.Parse(tb.Text);
    //        if (parsedValue<0)//bad
    //        {
    //            MessageBox.Show(tb.Tag + "has to be a non-negative double number", "Input Error");
    //            result = false;
    //            tb.SelectAll();
    //            tb.Focus();
    //        }
    //        return result;
    //    }
    //    //check if input in a text box is a double
    //    public static bool IsDecimal(TextBox tb)
    //    {
    //        bool result = true;
    //        decimal parsedValue;
    //        if (!(decimal.TryParse(tb.Text, out parsedValue)))//bad
    //        {
    //            MessageBox.Show(tb.Tag + "has to be a decimal number", "Input Error");
    //            result = false;
    //            tb.Focus();
    //        }
    //        return result;
    //    }

    //    //check if a decimal in range
    //    public static bool IsDecimalInRange(TextBox tb, decimal minValue, decimal maxValue)
    //    {
    //        bool result = true;
    //        decimal parsedValue = decimal.Parse(tb.Text); //already know it is a decimal
    //        if (parsedValue < minValue || parsedValue>maxValue)//bad
    //        {
    //            MessageBox.Show(tb.Tag + "has to be a between"+maxValue.ToString()+" and "+minValue.ToString() ,"Input Error");
    //            result = false;
    //            tb.SelectAll();
    //            tb.Focus();
    //        }
    //        return result;
    //    }

        // check: is empty -> is integer -> is non-negative
       
        

    //}
}
