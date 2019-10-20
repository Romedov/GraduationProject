using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Runtime.CompilerServices;
using System.Windows;
using GraduationProject.Model;

namespace GraduationProject
{
    public interface IUser<T> where T : User
    {
        #region Properties

        //[Key]
        //[StringLength(50)]
        //string UId { get; set; }
        //[Required]
        //[StringLength(50)]
        //string Password { get; set; }
        //[Required]
        //[StringLength(50)]
        //string SurName { get; set; }
        //[Required]
        //[StringLength(50)]
        //string Name { get; set; }
        //[StringLength(50)]
        //string FatherName { get; set; }
        #endregion

        #region Methods
        T GetInstance();
        #endregion

        #region Events
        #endregion
    }

    public partial class User : INotifyPropertyChanged, IUser<User>
    {
        #region Fields
            string surName;
            string name;
            string fatherName;
            
        #endregion

        #region Properties
            [Key]
            [StringLength(50)]
            public string UId { get; private set; }
        
            [Required]
            [StringLength(50)]
            public string Password { get; private set; }

            [Required]
            [StringLength(50)]
            public string SurName
            {
                get { return surName; }
                private set
                {
                    surName = value;
                    OnPropertyChanged();
                }
            }
        
            [Required]
            [StringLength(50)]
            public string Name
            {
                get { return name; }
                private set
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        
            [StringLength(50)]
            public string FatherName
            {
                get { return fatherName; }
                private set
                {
                    fatherName = value;
                    OnPropertyChanged();
                }
            }
        #endregion

        #region Events
            public event PropertyChangedEventHandler PropertyChanged;
            public static event EventHandler<SignInEventArgs> SigningIn;
        #endregion

        #region Methods
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public static User SignIn(string uid, string pwd)
        {
            using(CashboxModel db = new CashboxModel())
            {
                User user = null;
                try
                {
                    db.DBConnectionCheck();
                    user = db.Users.FirstOrDefault(u => uid == u.UId && pwd == u.Password);
                    if (user != null)
                    {
                        if(SigningIn != null)
                        {
                            SigningIn(user, new SignInEventArgs(true));
                            return user;
                        }
                    }
                    else 
                    {
                        if (SigningIn != null)
                        {
                            SigningIn(user, new SignInEventArgs(false));
                            return user;
                        }
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return user;
            }
        }

        public User GetInstance()
        {
            return this;
        }
        #endregion
    }
}
