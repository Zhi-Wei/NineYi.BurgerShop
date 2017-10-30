﻿namespace NineYi.BurgerShop.Models.Breads
{
    /// <summary>
    /// 麵包類。
    /// </summary>
    public class Bread
    {
        /// <summary>
        /// 取得或設定名稱。
        /// </summary>
        /// <value>
        /// 名稱。
        /// </value>
        public string Name { get; protected set; }

        /// <summary>
        /// 傳回這個 <see cref="System.String" /> 的執行個體；不會執行實際的轉換。
        /// </summary>
        /// <returns>
        /// 目前的字串。
        /// </returns>
        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}