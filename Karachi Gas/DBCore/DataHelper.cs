using System;

namespace Karachi_Gas
{
    class DataHelper
    {
        public static string stringParse(object value)
        {
            try
            {
                if (value != null)
                {
                    return value.ToString();
                }
                else
                {
                    return "";
                }
            }

            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static int intParse(object value)
        {
            try
            {
                if (value != null)
                {
                    int i = 0;
                    string[] values = value.ToString().Split('.');

                    int.TryParse(values[0].ToString().Replace(",", "").Replace("_", "").Replace("(", "-").Replace(")", ""), out i);
                    return i;

                }
                else
                {
                    return 0;
                }
            }

            catch (Exception)
            {
                return 0;
            }
        }

        public static long LongParse(object value)
        {
            try
            {
                if (value != null)
                {
                    long i = 0;
                    string[] values = value.ToString().Split('.');
                    long.TryParse(values[0].Replace(",", "").Replace("_", "").Replace("(", "-").Replace(")", ""), out i);
                    return i;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static float floatParse(object value)
        {
            try
            {
                if (value != null)
                {
                    float i = 0;
                    float.TryParse(value.ToString().Replace(",", "").Replace("_", "").Replace("(", "-").Replace(")", ""), out i);
                    return i;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static Double DoubleParse(object value)
        {
            try
            {
                if (value != null)
                {
                    double i = 0;
                    double.TryParse(value.ToString().Replace(",", "").Replace("_", "").Replace("(", "-").Replace(")", ""), out i);
                    return i;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static decimal DecimalParse(object value)
        {
            try
            {
                if (value != null)
                {
                    decimal i = 0;
                    decimal.TryParse(value.ToString().Replace(",", "").Replace("_", "").Replace("(", "").Replace(")", ""), out i);
                    return i;

                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static bool BoolParse(object value)
        {
            try
            {
                if (value != null)
                {
                    bool i = false;
                    bool.TryParse(value.ToString().Replace(",", "").Replace("_", ""), out i);
                    return i;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string dateOnly(object value)
        {
            try
            {
                if (value != null)
                {
                    DateTime i;
                    if (DateTime.TryParse(value.ToString().Replace(",", "").Replace("_", ""), out i))
                        return i.ToString("dd-MMM-yyyy");
                    return "";

                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static DateTime dateParse(object value)
        {
            try
            {
                if (value != null)
                {
                    DateTime i;
                    if (DateTime.TryParse(value.ToString(), out i))
                        return i;
                    return DateTime.Now;
                }
                else
                {
                    return DateTime.Now;
                }

            }
            catch (Exception)
            {

                return DateTime.Now;
            }

        }

        public static int RowCount(System.Data.DataTable dt)
        {
            int Row = 0;
            if (dt != null)
            {
                Row = dt.Rows.Count;
            }
            return Row;
        }

        public static bool HasRows(System.Data.DataTable dt)
        {
            bool has = false;
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    has = true;
                }
            }
            return has;
        }


    }
}

