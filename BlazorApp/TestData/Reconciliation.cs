using System;

namespace BlazorApp.Data
{
    public class Reconciliation // TEST CLASS FOR RECONCILIATION TABLE
    {

        public Reconciliation(int id, string result, DateTime timestamp, string description)
        {
            _id = id;
            _result = result;
            _timestamp = timestamp;
            _description = description;
        }

        public int _id { get; protected set; }
        public DateTime _timestamp { get; protected set; }
        public string _result { get; private set; }
        public string _description { get; private set; }

        public string DecideResultColor()
        {
            switch (_result)
            {
                case "OK"       : return "color1";
                case "DISABLED" : return "color2";
                case "MISMATCH" : return "color3";
                case "FAILED"   : return "color4";
                default         : return "failColor";
            }
        }
        


    }
}