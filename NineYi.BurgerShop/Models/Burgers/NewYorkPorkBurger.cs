﻿using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 紐約豬肉堡。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Burgers.Burger" />
    public class NewYorkPorkBurger : Burger
    {
        /// <summary>
        /// 初始化 <see cref="NewYorkPorkBurger"/> 類別新的執行個體。
        /// </summary>
        /// <param name="bread">麵包。</param>
        /// <param name="veggie">蔬菜。</param>
        /// <param name="meat">肉類。</param>
        public NewYorkPorkBurger(Bread bread, Veggie veggie, Meat meat)
            : base("NewYork Pork Burger", bread, veggie, meat)
        {
        }
    }
}