﻿using UI.Models.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<DiscountViewModel> GetDiscount(string discountCode);
    }
}