using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared
{
    public class Messages
    {
        public const string Success = "با موفقیت {0} شد";
        public const string RunTimeError = "مشکلی پیش آمده است.با پشتیبانی تماس بگیرید";
        public const string Duplicate = "{0} وارد شده قبلا ذخیره شده است";
        public const string FalseValidation = "{0} وارد شده اشتباه است";
        public const string Required = "وارد کردن {0} ضروری است";
        public const string NotExist = "این اطلاعات در سیستم ثبت نشده است";
        public const string WrongLanguage = "لطفا {0} را فارسی وارد کنید";
        public const string Insert = "ذخیره";
        public const string Send = "ارسال";
        public const string Update = "ویرایش";
        public const string Delete = "حذف";
        public const string Mobile = "شماره";
        public const string FirstName = "نام";
        public const string LastName = "نام خانوادگی";
        public const string FullName = "نام و نام خانوادگی";
        public const string NationalCode = "کد ملی";
        public const string Nezam = "کد نظام پزشکی";
        public const string SmsText = "کد ورود به سامانه ویزیت24";
    }
}
