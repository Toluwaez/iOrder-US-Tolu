using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iOrder.Pages
{
 public class DashboardModel : PageModel
   {
//        // Properties to hold the username and role retrieved from the session cookie
       public string Username { get; set; }
        public string Role { get; set; }

//        public void OnGet()
//        {
//            // Check if a session cookie exists and retrieve its value
//            if (Request.Cookies.TryGetValue("sessionID", out string sessionID))
//            {

//                //// Split the session ID by the colon character to separate the username and role
//                //string[] parts = sessionID.Split(':');
//                //if (parts.Length == 2)
//                //{
//                //    // Assign the username and role values to the respective properties
//                //    Username = parts[0];
//                //    Role = parts[1];
//                //}
//            }
//        }
     }
  }
