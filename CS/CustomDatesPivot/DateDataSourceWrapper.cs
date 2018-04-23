using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CustomDatesPivot
{
    class DateDataSourceWrapper : ITypedList, IList, IEnumerator
    {
        int position = -1;
        public readonly IList NestedList;
        public readonly List<DateTime> CustomDates;
        public ITypedList NestedTypedList { get { return (ITypedList)NestedList; } }
        public DateDataSourceWrapper(ITypedList OriginalDatasource, List<string> dateFields, List<DateTime> customDates)
        {
            _DateFields = dateFields;
            this.NestedList = (IList)OriginalDatasource;
            CustomDates = customDates;
        }

        private readonly List<string> _DateFields;



        class EmptyObjectPropertyDescriptor : PropertyDescriptor
        {
            private readonly List<string> _DateFields;
            public readonly PropertyDescriptor NestedDescriptor;
            public EmptyObjectPropertyDescriptor(PropertyDescriptor nestedDescriptor, List<string> dateFields)
                : base(nestedDescriptor.Name, (Attribute[])new ArrayList(nestedDescriptor.Attributes).ToArray(typeof(Attribute)))
            {
                _DateFields = dateFields;
                this.NestedDescriptor = nestedDescriptor;
            }
            public override bool CanResetValue(object component)
            {
                return false;
            }
            public override Type ComponentType
            {
                get { return typeof(object); }
            }
            public override object GetValue(object component)
            {
                if (component is DateTime)
                {
                    if (_DateFields.Contains(NestedDescriptor.Name))
                        return (DateTime)component;
                    return null;
                }
                else
                    return NestedDescriptor.GetValue(component);
            }
            public override bool IsReadOnly
            {
                get { return true; }
            }
            public override Type PropertyType
            {
                get { return NestedDescriptor.PropertyType; }
            }
            public override void ResetValue(object component)
            {
                throw new NotSupportedException("The method or operation is not implemented.");
            }
            public override void SetValue(object component, object value)
            {
                throw new NotSupportedException("The method or operation is not implemented.");
            }
            public override bool ShouldSerializeValue(object component)
            {
                return true;
            }
        }
        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            List<PropertyDescriptor> result = new List<PropertyDescriptor>();
            foreach (PropertyDescriptor pd in NestedTypedList.GetItemProperties(ExtractOriginalDescriptors(listAccessors)))
            {

                result.Add(new EmptyObjectPropertyDescriptor(pd, _DateFields));
            }
            return new PropertyDescriptorCollection(result.ToArray());
        }
        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return NestedTypedList.GetListName(ExtractOriginalDescriptors(listAccessors));
        }

        protected static PropertyDescriptor[] ExtractOriginalDescriptors(PropertyDescriptor[] listAccessors)
        {
            if (listAccessors == null)
                return null;
            PropertyDescriptor[] convertedDescriptors = new PropertyDescriptor[listAccessors.Length];
            for (int i = 0; i < convertedDescriptors.Length; ++i)
            {
                PropertyDescriptor d = listAccessors[i];
                EmptyObjectPropertyDescriptor c = d as EmptyObjectPropertyDescriptor;
                if (c != null)
                    convertedDescriptors[i] = c.NestedDescriptor;
                else
                    convertedDescriptors[i] = d;
            }
            return convertedDescriptors;
        }
        public int Add(object value)
        {
            throw new NotSupportedException("The method or operation is not implemented.");
        }
        public void Clear()
        {
            throw new NotSupportedException("The method or operation is not implemented.");
        }
        public bool Contains(object value)
        {
            if (value is DateTime)
                return CustomDates.Contains((DateTime)value);
            return NestedList.Contains(value);
        }
        public int IndexOf(object value)
        {
            if (value is DateTime && CustomDates.Contains((DateTime)value))
                return CustomDates.IndexOf((DateTime)value);
            int nres = NestedList.IndexOf(value);
            if (nres < 0)
                return nres;
            return nres + CustomDates.Count;
        }
        public void Insert(int index, object value)
        {
            throw new NotSupportedException("The method or operation is not implemented.");
        }
        public bool IsFixedSize
        {
            get { return true; }
        }
        public bool IsReadOnly
        {
            get { return true; }
        }
        public void Remove(object value)
        {
            throw new NotSupportedException("The method or operation is not implemented.");
        }
        public void RemoveAt(int index)
        {
            throw new NotSupportedException("The method or operation is not implemented.");
        }
        public object this[int index]
        {
            get
            {
                if (index < CustomDates.Count)
                    return CustomDates[index];
                else
                    return NestedList[index - CustomDates.Count];
            }
            set
            {
                throw new NotSupportedException("The method or operation is not implemented.");
            }
        }
        public void CopyTo(Array array, int index)
        {
            throw new NotSupportedException("The method or operation is not implemented.");
        }
        public int Count
        {
            get { return NestedList.Count + CustomDates.Count; }
        }
        public bool IsSynchronized
        {
            get { return false; }
        }
        public object SyncRoot
        {
            get { return NestedList.SyncRoot; }
        }

        public object Current
        {
            get
            {
                if (position < CustomDates.Count)
                    return CustomDates[position];
                else
                    return NestedList[position - CustomDates.Count];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < Count);
        }

        public void Reset()
        {
            position = 0;
        }
    }
}