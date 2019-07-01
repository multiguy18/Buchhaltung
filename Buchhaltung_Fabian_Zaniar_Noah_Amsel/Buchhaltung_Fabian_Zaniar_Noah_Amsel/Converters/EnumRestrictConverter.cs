using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Buchhaltung_Fabian_Zaniar_Noah_Amsel.Converters
{
    public class EnumRestrictConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Array))
                return null;

            string filters = parameter == null ? String.Empty : parameter.ToString();
            IEnumerable enumList;
            string[] splitFilters = filters != null ? filters.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries) : new string[] { };
            List<string> removalList = new List<string>(splitFilters);
            Type enumType = ((Array)value).GetValue(0).GetType();
            Array allValues = Enum.GetValues(enumType);
            try
            {
                var filteredValues = from object enumVal in allValues
                                     where !removalList.Contains(Enum.GetName(enumType, enumVal))
                                     select enumVal;
                enumList = filteredValues;
            }
            catch (ArgumentNullException)
            {
                enumList = allValues;
            }
            catch (ArgumentException)
            {
                enumList = allValues;
            }
            return enumList;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
