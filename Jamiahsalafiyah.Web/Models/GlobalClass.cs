using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jamiahsalafiyah.Web.Models
{
    public class GlobalClass
    {
        static private string _MasterSession = "MasterSession";
        public static bool MasterSession
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._MasterSession] == null)
                {
                    return false;
                }
                else
                {
                    return (bool)(HttpContext.Current.Session[GlobalClass._MasterSession]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._MasterSession] = value;
            }
        }
        static private string _AnchorID = "AnchorID";
        public static int AnchorID
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._AnchorID] == null)
                {
                    return -99;
                }
                else
                {
                    return (int)(HttpContext.Current.Session[GlobalClass._AnchorID]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._AnchorID] = value;
            }
        }
        static private string _SystemSession = "SystemSession";
        public static bool SystemSession
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._SystemSession] == null)
                {
                    return false;
                }
                else
                {
                    return (bool)(HttpContext.Current.Session[GlobalClass._SystemSession]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._SystemSession] = value;
            }
        }
        static private string _LoginUser = "LoginUser";
        public static StaffList LoginUser
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._LoginUser] == null)
                {
                    return null;
                }
                else
                {
                    return (StaffList)(HttpContext.Current.Session[GlobalClass._LoginUser]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._LoginUser] = value;
            }
        }
        static private string _Company = "Company";
        public static Company Company
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._Company] == null)
                {
                    return null;
                }
                else
                {
                    return (Company)(HttpContext.Current.Session[GlobalClass._Company]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._Company] = value;
            }
        }
        static private string _TempGuid = "TempGuid";
        public static int TempGuid
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._TempGuid] == null)
                {
                    return -99;
                }
                else
                {
                    return (int)(HttpContext.Current.Session[GlobalClass._TempGuid]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._TempGuid] = value;
            }
        }
        static private string _StoreGuid = "StoreGuid";
        public static Guid StoreGuid
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._StoreGuid] == null)
                {
                    return Guid.Empty;
                }
                else
                {
                    return (Guid)(HttpContext.Current.Session[GlobalClass._StoreGuid]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._StoreGuid] = value;
            }
        }
        static private string _StoreGuid1 = "StoreGuid1";
        public static Guid StoreGuid1
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._StoreGuid1] == null)
                {
                    return Guid.Empty;
                }
                else
                {
                    return (Guid)(HttpContext.Current.Session[GlobalClass._StoreGuid1]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._StoreGuid1] = value;
            }
        }


        static private string _GuidList = "GuidList";
        public static List<Guid> GuidList
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._GuidList] == null)
                {
                    return null;
                }
                else
                {
                    return (List<Guid>)(HttpContext.Current.Session[GlobalClass._GuidList]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._GuidList] = value;
            }
        }
        //static private string _GlobalSales = "GlobalSales";
        //public static List<JobSalesInvoiceClass> GlobalSales
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[GlobalClass._GlobalSales] == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return (List<JobSalesInvoiceClass>)(HttpContext.Current.Session[GlobalClass._GlobalSales]);
        //        }
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session[GlobalClass._GlobalSales] = value;
        //    }
        //}

        //static private string _GlobalDecimal = "GlobalDecimal";
        //public static decimal GlobalDecimal
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[GlobalClass._GlobalSales] == null)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return (decimal)(HttpContext.Current.Session[GlobalClass._GlobalSales]);
        //        }
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session[GlobalClass._GlobalSales] = value;
        //    }
        //}

        static private string _MenuGuid = "MenuGuid";
        public static Guid MenuGuid
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._MenuGuid] == null)
                {
                    return Guid.Empty;
                }
                else
                {
                    return (Guid)(HttpContext.Current.Session[GlobalClass._MenuGuid]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._MenuGuid] = value;
            }
        }

        static private string _GlobalURL = "GlobalURL";
        public static string GlobalURL
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._GlobalURL] == null)
                {
                    return "";
                }
                else
                {
                    return (string)(HttpContext.Current.Session[GlobalClass._GlobalURL]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._GlobalURL] = value;
            }
        }

        //static private string _BillDetail = "BillDetail";
        //public static List<BillDetailClass> BillDetail
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[GlobalClass._BillDetail] == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return (List<BillDetailClass>)(HttpContext.Current.Session[GlobalClass._BillDetail]);
        //        }
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session[GlobalClass._BillDetail] = value;
        //    }
        //}
        //static private string _AccountingList = "AccountingList";

        //public static List<DashboardJobClass> AccountingList
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[GlobalClass._AccountingList] == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return (List<DashboardJobClass>)(HttpContext.Current.Session[GlobalClass._AccountingList]);
        //        }
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session[GlobalClass._AccountingList] = value;
        //    }
        //}



        //static private string _InvoiceSentContact = "InvoiceSentContact";
        //public static List<SendInvoiceContact> InvoiceSentContact
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[GlobalClass._InvoiceSentContact] == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return (List<SendInvoiceContact>)(HttpContext.Current.Session[GlobalClass._InvoiceSentContact]);
        //        }
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session[GlobalClass._InvoiceSentContact] = value;
        //    }
        //}

        //static private string _SendInvoiceFileList = "SendInvoiceFileList";
        //public static List<SendInvoiceFile> SendInvoiceFileList
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[GlobalClass._SendInvoiceFileList] == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return (List<SendInvoiceFile>)(HttpContext.Current.Session[GlobalClass._SendInvoiceFileList]);
        //        }
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session[GlobalClass._SendInvoiceFileList] = value;
        //    }
        //}



        static private string _sendDate = "SendDate";
        public static string SendDate
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._sendDate] == null)
                {
                    return "";
                }
                else
                {
                    return (string)(HttpContext.Current.Session[GlobalClass._sendDate]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._sendDate] = value;
            }
        }

        static private string _sender = "Sender";
        public static string Sender
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._sender] == null)
                {
                    return "";
                }
                else
                {
                    return (string)(HttpContext.Current.Session[GlobalClass._sender]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._sender] = value;
            }
        }


        static private string _subject = "Subject";
        public static string Subject
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._subject] == null)
                {
                    return "";
                }
                else
                {
                    return (string)(HttpContext.Current.Session[GlobalClass._subject]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._subject] = value;
            }
        }


        static private string _body = "Body";
        public static string Body
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._body] == null)
                {
                    return "";
                }
                else
                {
                    return (string)(HttpContext.Current.Session[GlobalClass._body]);
                }
            }
            set
            {
                HttpContext.Current.Session[GlobalClass._body] = value;
            }
        }




    }
}