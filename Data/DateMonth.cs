using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRatingBlazor.Models;

public partial class DateMonth
{
    public int Id { get; set; }

    public short Year { get; set; }

    public short Month { get; set; }
    public string DateString
    {
        get
        {
            var res = new StringBuilder();
            res.Append(Year);
            res.Append(' ');
            res.Append(Month);
            return res.ToString();
        }
    }
}
