namespace Enterprise.Applications.ClientDashboard.Controllers
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Security;

    using BootstrapMvcSample.Controllers;

    using Enterprise.Services.Authentication;
    using Enterprise.Services.Authentication.Models;

    [AllowAnonymous]
    public class AccountController : BootstrapBaseController
    {

        protected MsiMembershipProvider MsiMembership 
        {
            get { return (MsiMembershipProvider) Membership.Provider; }
        }

        //
        // GET: /Account/LogOn

        public ActionResult LogOn()
        {
            return View();
        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (MsiMembership.ValidateUser(model.UserName, model.Password))
                    {
                        //force user to change password if applicable
                        if (MsiMembership.IsPasswordExpired(model.UserName))
                        {
                            Attention("Your password has expired! You must change it before continuing.");
                            return View("ChangePassword", new ChangePasswordModel { Username = model.UserName });
                        }

                        //password has not expired, set the auth cookie
                        FormsAuthentication.SetAuthCookie(model.UserName, false);

                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                            return Redirect(returnUrl);
                        }
                        
                            return RedirectToAction("Index", "Home");
                        
                    }
                    
                    ModelState.AddModelError("", "Username and/or password are not valid.");
                    
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            //if we are here then something failed, re-display the form with model errors
            return View(model);
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus;
                Membership.CreateUser(model.UserName, model.Password, model.Email, model.SecretQuestion, model.SecretAnswer, true, null, out createStatus);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false /* createPersistentCookie */);
                    return RedirectToAction("Index", "Home");
                }
                
                ModelState.AddModelError("", ErrorCodeToString(createStatus));
                
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            var model = new ChangePasswordModel {Username = User.Identity.Name};
            return View(model);
        }

        //
        // POST: /Account/ChangePassword
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                // ChangePassword will throw an exception rather
                // than return false in certain failure scenarios.
                bool changePasswordSucceeded;
                string errorMessage = null;
                try
                {
                    changePasswordSucceeded = MsiMembership.ChangePassword(model.Username, model.OldPassword, model.NewPassword);
                }
                catch (Exception ex)
                {
                    changePasswordSucceeded = false;
                    errorMessage = ex.Message;
                }

                if (changePasswordSucceeded)
                {
                    Success("Password changed was successful!");
                    return Redirect("/");
                }
                
                    ModelState.AddModelError("", errorMessage ?? "The current password is incorrect, or the new password is invalid.");
                
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public ActionResult ResetPassword_1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResetPassword_1(ResetPasswordModel model)
        {


            try
            {

                var user = MsiMembership.GetUser(model.Username, false);

                if (user != null)
                {
                    model.SecretQuestion = user.PasswordQuestion;
                    ModelState.Clear();
                    return View("ResetPassword_2", model);
                }
                    
                ModelState.AddModelError("", "The user name provided was not found.");
                return View();
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
            
        }

        [HttpPost]
        public ActionResult ResetPassword_2(ResetPasswordModel model)
        {
         
            
            if (ModelState.IsValid)
            {
                try
                {

                    var tempPassword = MsiMembership.ResetPassword(model.Username, model.SecretAnswer);
                    Success(new HtmlString(String.Format("Password reset successful! Here is your temp password: <b>{0}</b>", tempPassword)));
                    return View("LogOn");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View();
                }
            }

            return View();
            
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
                    
                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
