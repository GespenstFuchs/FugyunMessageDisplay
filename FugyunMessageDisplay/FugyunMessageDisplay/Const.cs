using System.Collections.Generic;

namespace FugyunMessageDisplay
{
    /// <summary>
    /// 定数クラス
    /// </summary>
    internal class Const
    {
        /// <summary>
        /// ボタンテキストリスト（ＯＫ）
        /// </summary>
        public static readonly List<string> ButtonTextListOkOnly = new List<string>()
        {
            "ＯＫ"
        };

        /// <summary>
        /// ボタンテキストリスト（質問）
        /// </summary>
        public static readonly List<string> ButtonTextListForQustion = new List<string>()
        {
            "はい",
            "いいえ"
        };

        /// <summary>
        /// 全角数値リスト
        /// </summary>
        public static readonly List<string> FullWidthNumberList = new List<string>()
        {
            "０",
            "１",
            "２",
            "３",
            "４",
            "５",
            "６",
            "７",
            "８",
            "９"
        };
    }
}
