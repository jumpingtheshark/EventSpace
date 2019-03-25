using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EventSpaceWeb.Pages.Records;
using EventSpaceWeb;

namespace EventSpaceWeb.Pages
{
    public class AddVenueModel : PageModel
    {

        // todo: use webconfig to store the servername
        // user session to store the dbhelper


        //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
        //       string _conString;
        //  string 

        public DBHelper db;

        public AddVenueModel()
        {
            string serverName = @"LAPTOP-73C2CI79\SQLEXPRESS01";
            string database = "EventSpace";
            string constring = string.Format("Server = {0}; Database = {1}; Trusted_Connection = True;", serverName, database);
            db = new DBHelper();
            db._constring = constring;

          



        }


        public void OnGet()
        {
            


        }



        public void OnPost(Venue v)
        {
            string command = "insert into venues (venueID) values (0)";
            db.runCommand2(command);



           


        }
    }
}