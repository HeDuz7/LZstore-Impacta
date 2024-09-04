using Microsoft.AspNetCore.Mvc.Rendering;

namespace LZStore.Models.Extensions
{
    public static class ExtensionsMethods
    {
        public static SelectList ToSelectList<TEnum>(this TEnum obj)
           where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new SelectList(Enum.GetValues(typeof(TEnum)).OfType<Enum>()
                .Select(x => new SelectListItem
                {
                    Text = Enum.GetName(typeof(TEnum), x),
                    Value = Convert.ToInt16(x).ToString()
                }), "Value", "Text");
        }

        public static SelectList ToSelectList<TEnum>(this TEnum obj, object SelectValue)
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new SelectList(Enum.GetValues(typeof(TEnum)).OfType<Enum>()
                .Select(x => new SelectListItem
                {
                    Text = Enum.GetName(typeof(TEnum), x),
                    Value = Convert.ToInt32(x).ToString()
                }), "Value", "Text", SelectValue);
        }
    }
}
