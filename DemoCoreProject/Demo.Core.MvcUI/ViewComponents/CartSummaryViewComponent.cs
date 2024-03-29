﻿
using Demo.Core.MvcUI.Model;
using Demo.Core.MvcUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Demo.Core.MvcUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private ICartSessionService _cartSessionService;
        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService= cartSessionService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    
    }
}
