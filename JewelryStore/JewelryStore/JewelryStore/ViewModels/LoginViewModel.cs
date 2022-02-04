using JewelryStore.Helper;
using JewelryStore.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace JewelryStore.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        #region Properties
        /// <summary>
        /// Email binding property
        /// </summary>
        public string email;
        public string Email
        {
            get
            {
                return email;

            }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }

        }
        /// <summary>
        ///  Password Properties 
        ////// </summary>
        public string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public Command signupEvent;
        public Command Signupevent
        {
            get { return signupEvent; }
        }
        #endregion
        #region Constructor
        public LoginViewModel()
        {
            signupEvent = new Command(SignUpHandler);
        }
        #endregion

        #region command

        private Command loginCommand;
        /// <summary>
        /// Validation for Email  and Password
        /// Login Command
        /// </summary>
        public Command LoginCommand
        {
            get
            {
                loginCommand = new Command(async () =>
                {
                    try
                    {
                        if (string.IsNullOrEmpty(Email))
                        {
                            await App.Current.MainPage.DisplayAlert(Constants.Alert, Constants.EmailMsg, Constants.Ok);
                        }
                        else if (!string.IsNullOrEmpty(Email) && !Regex.IsMatch(Email, Constants.Regexes.EmailRegex))
                        {
                            await App.Current.MainPage.DisplayAlert(Constants.Alert, Constants.ValidEmailMsg, Constants.Ok);
                        }
                        else
                        {
                            App.Current.MainPage = new NavigationPage(new MainPage());
                        }
                        //UserDialogs.Instance.HideLoading();
                    }
                    catch (Exception ex)
                    {
                        //UserDialogs.Instance.HideLoading();
                        //Crashes.TrackError(ex);
                    }

                });
                return loginCommand;
            }
        }
        /// <summary>
        /// Signup event handler
        /// </summary>
        /// <param name="obj"></param>
        private void SignUpHandler(object obj)
        {
            try
            {
                //  App.Current.MainPage.Navigation.PushAsync(new Sigup());
               // DependencyService.Get<IMessages>().SendMessage();
            }
            catch (Exception exception)
            {
               // Crashes.TrackError(exception);
            }
        }
        #endregion
    }
}
