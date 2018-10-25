using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurance_Quote.Models;
using Insurance_Quote.ViewModels;

namespace Insurance_Quote.Controllers
{
    public class HomeController : Controller
    {
        private readonly connectionString = @"";

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime birthday, int carYear, string carMake, string carModel, bool dUI, int speedingTicket, bool coverage)
        {
            QuoteDetails quote1 = new QuoteDetails();
            quote1.FirstName = firstName;
            quote1.LastName = lastName;
            quote1.EmailAddress = emailAddress;
            quote1.Birthday = birthday;
            quote1.CarYear = carYear;
            quote1.CarMake = carMake;
            quote1.CarModel = carModel;
            quote1.DUI = dUI;
            quote1.SpeedingTicket = speedingTicket;
            quote1.Coverage = coverage;


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                quote1.QuoteAmount = QuoteCalculator.Calculate(quote1);

                string queryString = @"INSERT INTO [table] (FirstName, LastName, EmailAddress, Birthday, CarYear, CarMake, CarModel, DUI, SpeedingTicket, Coverage, QuoteAmount) 
                                        VALUES (@firstName, @lastName, @emailAddress, @birthday, @carYear, @carMake, @carModel, @dUI, @speedingTicket, @coverage, @quoteAmount)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@Birthday", SqlDbType.Date);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUI", SqlDbType.Bit);
                    command.Parameters.Add("@SpeedingTicket", SqlDbType.Int);
                    command.Parameters.Add("@Coverage", SqlDbType.Bit);
                    command.Parameters.Add("@QuoteAmount", SqlDbType.Decimal);


                    command.Parameters["@firstName"].Value = firstName;
                    command.Parameters["@lastName"].Value = lastName;
                    command.Parameters["@emailAddress"].Value = emailAddress;
                    command.Parameters["@dob"].Value = birthday;
                    command.Parameters["@carYear"].Value = carYear;
                    command.Parameters["@carMake"].Value = carMake;
                    command.Parameters["@carModel"].Value = carModel;
                    command.Parameters["@dui"].Value = dUI;
                    command.Parameters["@tickets"].Value = speedingTicket;
                    command.Parameters["@fullCoverage"].Value = coverage;
                    command.Parameters["@quotedPrice"].Value = Math.Round(quote1.QuoteAmount, 2);




                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View(new QuoteVM(quote1.QuoteAmount));
            };
        }
    }
}
          