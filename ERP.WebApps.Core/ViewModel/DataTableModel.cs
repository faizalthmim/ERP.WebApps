using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebApps.Core.ViewModel
{
    public class DataTableModel
    {
        // properties are not capital due to json mapping
        public int draw { get; set; }
        public int? status { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<Column> columns { get; set; }
        public Search search { get; set; }
        //public FilterParam[] filter { get; set; }

        public List<Order> order { get; set; }
        //public List<string> headers { get; set; }

        public string? detailId { get; set; }
    }
    public class Column
    {
        public string? data { get; set; }
        public string? name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public Search search { get; set; }
    }

    public class Search
    {
        public string? value { get; set; }
        public bool? regex { get; set; }
        public int? status { get; set; }

    }

    public class Order
    {
        public int column { get; set; }
        public string dir { get; set; }
    }
    public class FilterParam
    {
        public string Comparator { get; set; }
        public string FieldName { get; set; }
        public string Operator { get; set; }
        public string FieldType { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }

        public bool BgnBrackets { get; set; }
        public bool EndBrackets { get; set; }
    }
    public class DataTableReturnModel<T>
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<T> data { get; set; }
        public List<string> listAllId { get; set; }
        public List<string> listFilteredId { get; set; }
    }
}
