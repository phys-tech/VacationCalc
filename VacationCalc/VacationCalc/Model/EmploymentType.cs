using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationCalc.Model
{

    public abstract class BaseAttribute : Attribute
    {
        private readonly object _value;
        public BaseAttribute(object value) { this._value = value; }

        public object GetValue() { return this._value; }
    }

    public static class EnumAttributesBaseLogic
    {
        /// <param name="enumItem">Элемент перечисления</param>
        /// <param name="attributeType">Тип атрибута, значение которого хотим получить</param>
        /// <param name="defaultValue">
        /// Значение по-умолчанию, которое будет возвращено, 
        /// если переданный элемент перечисления не помечен переданным атрибутом </param>
        /// <returns>Возвращает значение переданного атрибута у переданного элемента перечисления</returns>
        public static VAL GetAttributeValue<ENUM, VAL>(this ENUM enumItem, Type attributeType, VAL defaultValue)
        {
            var attribute = enumItem.GetType().GetField(enumItem.ToString()).GetCustomAttributes(attributeType, true)
              .Where(a => a is BaseAttribute)
              .Select(a => (BaseAttribute)a)
              .FirstOrDefault();

            return attribute == null ? defaultValue : (VAL)attribute.GetValue();
        }
    }



    public class VacationDaysPerYear : BaseAttribute { public VacationDaysPerYear(int value) : base(value) { } }
    public class RussianName : BaseAttribute { public RussianName(string value) : base(value) { } }

    public static class EnumExtensionMethods
    {
        public static int GetVacationDaysPerYear(this Enum enumItem)
        {
            return enumItem.GetAttributeValue(typeof(VacationDaysPerYear), 0);
        }

        public static string GetRussianName(this Enum enumItem)
        {
            return enumItem.GetAttributeValue(typeof(RussianName), string.Empty);
        }
    }

    public enum EmploymentType
    { 
        [RussianName("ИП")]
        [VacationDaysPerYear(21)]
        IP,

        [RussianName("ООО")]
        [VacationDaysPerYear(28)]
        OOO,
        [RussianName("Швеция")]
        [VacationDaysPerYear(25)]
        SVE
    }

    public class TypeDataSource
    {
        private EmploymentType EmpType;
        private int Value;
        private string Display;

        public TypeDataSource(EmploymentType _value)
        {
            EmpType = _value;
            Value = (int) EmpType;
            Display = EmpType.GetRussianName();
        }

        public int iValue
        {
            get { return Value; }
            set { Value = value; }
        }

        public string sDisplay
        {
            get { return Display; }
            set { Display = value; }
        }
    }

    public class EmploymentTypeList
    {
        private List<TypeDataSource> DataList;
        public EmploymentTypeList()
        {
            DataList = new List<TypeDataSource>();
            foreach (EmploymentType t in Enum.GetValues( typeof(EmploymentType) ) )
                DataList.Add(new TypeDataSource(t));
        }

        public List<TypeDataSource> GetDataList()
        {
            return DataList;
        }
    }
}
