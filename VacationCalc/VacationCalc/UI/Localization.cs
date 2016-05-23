using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Telerik.WinControls.UI.Localization;

namespace VacationCalc.UI
{
    public class RussianGridViewLocalization : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.ConditionalFormattingInvalidParameters: return "Неверные параметры";
                case RadGridStringId.FilterFunctionBetween: return "Между";
                case RadGridStringId.FilterFunctionContains: return "Содержит";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Не содержит";
                case RadGridStringId.FilterFunctionEndsWith: return "Заканчивается на";
                case RadGridStringId.FilterFunctionEqualTo: return "Равен";
                case RadGridStringId.FilterFunctionGreaterThan: return "Больше";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Больше или равно";
                case RadGridStringId.FilterFunctionIsEmpty: return "Пуст";
                case RadGridStringId.FilterFunctionIsNull: return "Нулевой";
                case RadGridStringId.FilterFunctionLessThan: return "Меньше";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Меньше или равно";
                case RadGridStringId.FilterFunctionNoFilter: return "Без фильтрации";
                case RadGridStringId.FilterFunctionNotBetween: return "Не между";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Не равен";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Не пуст";
                case RadGridStringId.FilterFunctionNotIsNull: return "Не нулевой";
                case RadGridStringId.FilterFunctionStartsWith: return "Начинается с";
                case RadGridStringId.FilterFunctionCustom: return "Произвольный";

                case RadGridStringId.FilterOperatorBetween: return "Между";
                case RadGridStringId.FilterOperatorContains: return "Содержит";
                case RadGridStringId.FilterOperatorDoesNotContain: return "Не содержит";
                case RadGridStringId.FilterOperatorEndsWith: return "Заканчивается на";
                case RadGridStringId.FilterOperatorEqualTo: return "Равно";
                case RadGridStringId.FilterOperatorGreaterThan: return "Больше, чем";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Больше или равно";
                case RadGridStringId.FilterOperatorIsEmpty: return "Пуст";
                case RadGridStringId.FilterOperatorIsNull: return "Нулевой";
                case RadGridStringId.FilterOperatorLessThan: return "Меньше, чем";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Меньше или равно";
                case RadGridStringId.FilterOperatorNoFilter: return "Нет фильтра";
                case RadGridStringId.FilterOperatorNotBetween: return "Не между";
                case RadGridStringId.FilterOperatorNotEqualTo: return "Не равно";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Не пуст";
                case RadGridStringId.FilterOperatorNotIsNull: return "Не нулевой";
                case RadGridStringId.FilterOperatorStartsWith: return "Начинается с";
                case RadGridStringId.FilterOperatorIsLike: return "Like";
                case RadGridStringId.FilterOperatorNotIsLike: return "NotLike";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Содержится";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "Не содержится";
                case RadGridStringId.FilterOperatorCustom: return "Произвольно";

                case RadGridStringId.SortAscendingMenuItem: return "Сортировать по возрастанию";
                case RadGridStringId.SortDescendingMenuItem: return "Сортировать по убыванию";
                case RadGridStringId.ClearSortingMenuItem: return "Убрать сортировку";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Условное форматирование";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Сгруппировать по этому столбцу";
                case RadGridStringId.UngroupThisColumn: return "Убрать группировку";
                case RadGridStringId.ColumnChooserMenuItem: return "Выбрать столбцы";
                case RadGridStringId.HideMenuItem: return "Спрятать столбец";
                case RadGridStringId.HideGroupMenuItem: return "Спрятать группу";
                case RadGridStringId.UnpinMenuItem: return "Открепить столбец";
                case RadGridStringId.UnpinRowMenuItem: return "Открепить ряд";
                case RadGridStringId.PinMenuItem: return "Закрепленное состояние:";
                case RadGridStringId.PinAtLeftMenuItem: return "Закрепить слева";
                case RadGridStringId.PinAtRightMenuItem: return "Закрепить справа";
                case RadGridStringId.PinAtBottomMenuItem: return "Закрепить снизу";
                case RadGridStringId.PinAtTopMenuItem: return "Закрепить сверху";
                case RadGridStringId.BestFitMenuItem: return "Выровнять";
                case RadGridStringId.PasteMenuItem: return "Вставить";
                case RadGridStringId.EditMenuItem: return "Редактировать";
                case RadGridStringId.ClearValueMenuItem: return "Очистить значение";
                case RadGridStringId.CopyMenuItem: return "Копировать";
                case RadGridStringId.CutMenuItem: return "Вырезать";
                case RadGridStringId.DeleteRowMenuItem: return "Удалить ряд";

                case RadGridStringId.AddNewRowString: return "Нажмите сюда, чтобы добавить новый ряд";

                case RadGridStringId.ColumnChooserFormCaption: return "Выбор столбцов";
                case RadGridStringId.ColumnChooserFormMessage: return "Перетащите сюда заголовок столбца\nиз таблицы, чтобы убрать его\nиз текущего просмотра.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Перетащите сюда столбец, чтобы сгруппировать данные по этому столбцу";
                case RadGridStringId.GroupingPanelHeader: return "Сгруппировать по:";
                //case RadGridStringId.PagingPanelPagesLabel: return "Страница";
                //case RadGridStringId.PagingPanelOfPagesLabel: return "из";
                case RadGridStringId.NoDataText: return "Нет данных для отображения";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "Ошибка фильтрации";
                case RadGridStringId.CompositeFilterFormInvalidFilter: return "The composite filter descriptor is not valid.";
            }
            return base.GetLocalizedString(id);
        }
    }
}
