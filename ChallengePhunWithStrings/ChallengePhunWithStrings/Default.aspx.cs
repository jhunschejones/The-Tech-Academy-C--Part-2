using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            
            /*
            string name = "Josh Jones";
            string reverse = "";

            for (int i = name.Length - 1; i > -1; i--)
            {
                reverse += name[i];
            }
            resultLabel.Text = reverse;
            */



            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            /*
            string reverse = "";
            string[] namesArray = names.Split(',');
            Array.Reverse(namesArray);

            foreach(var item in namesArray)
            {
                reverse = reverse + item.ToString() + ",";
            }

            resultLabel.Text = reverse.Remove(reverse.Length - 1);
            */



            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            /*
            string myString = "";
            string[] namesArray = names.Split(',');

            foreach (var item in namesArray)
            {
                myString += item.PadLeft(((14 - item.Length) / 2) + item.Length, '*').PadRight(14, '*');
                myString += "<br />";
            }

            resultLabel.Text = myString;
            */



            // 4. Solve this puzzle:
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            /*
            string solution = puzzle.ToLower().Replace("z", "t").Remove(10, 9).Remove(0, 1).Insert(0, "N");

            resultLabel.Text = solution;
            */



        }
    }
}