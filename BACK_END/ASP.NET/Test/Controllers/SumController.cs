using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class SumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult SumForm()
        {
            return View();
        }
        ///////////////////////////////////////////////////////////////////////////
        //[HttpPost]
        ///model binding +viewbag
        //public IActionResult SumForm(int n1 , int n2)
        // {
        //    ViewBag.n1 = n1;
        //    ViewBag.n2 = n2;
        //    ViewBag.sum=n1+ n2;
        //    return View();
        //}

        ////////////////////////////////////////////////////////////////////////////////
        ///requestform +viewbag
        //[HttpPost,ActionName("SumForm")]
        //public IActionResult SumFormPost()
        //{
        //    string n1 = Request.Form["n1"];
        //    string n2 = Request.Form["n2"];
        //    int sum = Convert.ToInt32(n1) + Convert.ToInt32(n2);
        //    ViewBag.n1= n1;
        //    ViewBag.n2= n2;    
        //    ViewBag.Sum = sum;

        //    return View();
        //}

        ///////////////////////////////////////////////////////////////////////////////////////
        //modelbinding + viewdata
        //[HttpPost]
        //public IActionResult SumForm(int n1 , int n2 )
        //{
        //    ViewData["n1"] = n1;
        //    ViewData["n2"] = n2;
        //    ViewData["Sum"] = n1 + n2;

        //    return View();
        //}
        //////////////////////////////////////////////////////////////////////////////////////
        ///modelbinding +tempdata

        //[HttpPost]
        //public IActionResult SumForm(int n1 , int n2 )
        //{
        //    TempData["n1"]=n1;
        //    TempData["n2"] = n2;
        //    TempData["Sum"] = n1 + n2;
        //    return RedirectToAction("SumFormResult");
        //}
        //public IActionResult SumFormResult()
        //{
        //    return View();
        //}
        /////////////////////////////////////////////////////////////////////////////////////
        ///we will try transfer data using viewbag or viewdata from one view to another like tempdata
        //[HttpPost]
        //public IActionResult SumForm(int n1, int n2)
        //{
        //    ViewData["n1"] = n1;
        //    ViewData["n2"] = n2;
        //    ViewData["Sum"] = n1 + n2;
        //    return RedirectToAction("SumFormResult");
        //}
        //public IActionResult SumFormResult()
        //{
        //    return View();
        //}

        //we see that no thing saved 

        /////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost]
        //modelbinding + session
        public IActionResult SumForm(int n1 , int n2)
        {
            HttpContext.Session.SetInt32("n1", n1 );
            HttpContext.Session.SetInt32("n2",  n2);
            HttpContext.Session.SetInt32("Sum",n1+n2);


            return RedirectToAction("SumFormResult");
        }
        public IActionResult SumFormResult()
        {
            return View();
        }
    }
}
/*
 viewBag VS viewData VS TempData VS session VS modelView || modelbinding VS request.form

1-viewdata 
    * sorting the data as [key , value] so it is like dictionary
    * syntax -->ViewData["key"]=value;
    * viewdata transfer data in the same view 
    * we need casting the data 
    * keep the data only in current request (this mean if we cilck the button again || refresh the viewdata will be empty ) 
2-viewbag
    *is a wrapper of viewData? 
    *this means it works like viewdata but in different syntax , and the viewbag sort at the same place of viewdata and we access the data we sort using viewbag and vs.
    *viewbag transfer data in the same view 
    *syntax -->ViewBag.key=value
    *dynamic no need to casting 
    *keep the data only in current request (this mean if we cilck the button again || refresh the viewbag will be empty ) 
(You can think of them as two different keys to the same room. It doesn't matter which key you use to enter; the furniture inside (the data) is exactly the same!)
3-tempdata
    *transfer data from on action to action (across two followed http requests )
    *this mean it transfers data from one view to another but they should be followed
    *sorting the data as [key , value] so it is like dictionary
    *syntax -->tempData["key"]=value
    *usually used with redirctaction to show a message 
    *live in Current + Next Request
    *Temporary storage for the next page only
4-session 
    *live in all requests (as long as the tab is open not closed this mean the session is live)
    *sorting the data as [key , value] so it is like dictionary
    
    *we need casting the data
    *we should to use it add it as a service in program.cs
    *builder.Services.AddSession(Options => Options.IdleTimeout = TimeSpan.FromMinutes(30));
    *app.UseSession();(before the routing) ;
    *even we refresh the data still exist 

    *syntax -->
    *HttpContext.Session.SetInt32(key,value);
    *HttpContext.Session.Set(key,value);
    *HttpContext.Session.SetString(key,value);
    *
    *to access it from html -->
    *@Context.Session.GetInt32("key")
    *@Context.Session.GetString("key")
    

request.form -->
    *post IActionresult  will not take any parameters 
    *syntax (Request.Form["nameOfTheInput"])
    *note that request.form return string value
    *so we need to convert it in arithmetic operations




model binding --> 
    *this mean i should give names for each input in the form 
    *those names should be as parameters in the [httpPost]  IActionResult 
    *this only take data from the view no way to use it alone to send the result to the view

so we use it with viewbag or viewdata or tempdata 

1-modelbinding with viewbage -done 
2-requestForm with viewbag   -done
3-modelbinding with viewData -done
4-modelbinding with tempdata -done
5-modelbinding with session  -done
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */