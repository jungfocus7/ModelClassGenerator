using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


namespace Tester_mcg
{
    class Program
    {
        static void Main(string[] args)
        {

            CUser tus = new CUser();
        }
    }

    public class CUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Ratio { get; set; }
        private DateTime _dtx { get; set; }
        internal bool IsChecked { get; set; }

        public override string ToString()
        {
            StringBuilder tsb = new StringBuilder();
            tsb.Append(string.Format("Name = {0}, ", Name));
            tsb.Append(string.Format("Age = {0}, ", Age));
            tsb.Append(string.Format("Ratio = {0}, ", Ratio));
            tsb.Append(string.Format("_dtx = {0}, ", _dtx));
            tsb.Append(string.Format("IsChecked = {0}", IsChecked));
            if (tsb.Length > 0)
                return tsb.ToString();
            else
                return base.ToString();
        }

    }
    public class CUserCollection : ObservableCollection<CUser>
    {
        public CUserCollection() : base() { }
        public CUserCollection(IEnumerable<CUser> tclt) : base(tclt) { }
        public CUserCollection(List<CUser> tlst) : base(tlst) { }
    }


    
}
