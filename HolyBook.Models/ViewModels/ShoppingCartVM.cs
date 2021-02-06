using System;
using System.Collections.Generic;
using System.Text;

namespace HolyBook.Models.ViewModels
{
   public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
